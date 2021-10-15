namespace Control.Notify
{
    #region Usings
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Management;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading;
    using System.Xml.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO.Compression;
    using System.Windows.Forms;
    using System.Data;
    using System.Collections;
    #endregion

    //Author: H.Esmaeily
    [ToolboxBitmap(typeof(System.IO.FileSystemWatcher))]
    public partial class NotifyProvider : Component
    {
        #region Events
        public event EventHandler Connected;
        public event EventHandler Disconnected;
        public event EventHandler SendComplete;

        public event EventHandler<NotifyDataArrivalEventArgs> DataArrival;
        public event EventHandler<NotifyRequestEventArgs> ConnectionRequest;
        public event EventHandler<NotifyHandleErrorEventArgs> HandleError;
        public event EventHandler<NotifyStateEventArgs> StateChanged;
        #endregion

        #region Fields
        private const int BufferSize = 1024;

        //فعلا استفاده نشد
        //private string stRemoteIP = "127.0.0.1";
        private IPAddress[] remoteIPs = new IPAddress[1] { IPAddress.Parse("255.255.255.255") };

        private int iLocalPort = 80;
        private int iRemotePort = 80;

        private NotifyStates state = NotifyStates.Closed;

        private byte[] buffer;
        private byte[] byteBuffer = new byte[BufferSize];

        //private List<byte[]> bufferList;

        protected bool autoUpdate = false;

        private TcpListener tcpListener = null;
        private UdpClient udpListener = null;
        private Socket client = null;

        private ProtocolType protocol = ProtocolType.Tcp;
        private static readonly NWinsockData Data = new NWinsockData();
        #endregion

        #region Ctor
        public NotifyProvider()
        {
            InitializeComponent();
        }

        public NotifyProvider(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #endregion

        #region props
        [Category("Behavior")]
        [Description("Get or set the port used on the local computer.")]
        public int LocalPort
        {
            get { return iLocalPort; }
            set
            {
                if (State == NotifyStates.Closed)
                    iLocalPort = value;
                else
                    throw new Exception("Must be idle to change the local port");
            }
        }

        [Category("Behavior")]
        [Description("Get or set the port to be connected to on the remote computer.")]
        public int RemotePort
        {
            get { return iRemotePort; }
            set
            {
                if (State != NotifyStates.Connected)
                    iRemotePort = value;
                else
                    throw new Exception("Can't be connected to a server and change the remote port.");
            }
        }


        [Category("Behavior")]
        [Description("Get or set the name used to identify the remote computer/with ',' or enter key seprated .")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [TypeConverter(typeof(IPAddressConvertor))]
        public IPAddress[] RemoteIPs
        {
            get { return remoteIPs; }
            set
            {
                if (State == NotifyStates.Closed)
                    remoteIPs = value;
                else
                    throw new Exception("Must be closed to set the remote ips.");
            }
        }

        [Category("Behavior")]
        [Description("Get or set the socket  protocol.")]
        public ProtocolType Protocol
        {
            get { return protocol; }
            set
            {
                if (State == NotifyStates.Closed)
                    protocol = value;
                else
                    throw new Exception("Must be closed to set the protocol.");
            }
        }

        [Category("Behavior")]
        [Description("Get or set the ParentForm/استفاده میشود در کراس ترد.")]
        public Form ParentForm { get; set; }


        [Category("Behavior")]
        [Description("Get or set the RunEventsOnCurrentThread/استفاده میشود در کراس ترد.")]
        public bool RunEventsOnCurrentThread { get; set; }


        [Browsable(false)]
        public NotifyStates State
        {
            get { return state; }
        }

        private string packageName = "PKG";
        [Browsable(false)]
        [DefaultValue("PKG")]
        public string PackageName
        {
            get { return packageName; }
            set
            {
                packageName = value;
            }
        }


        private int headerLen = 10;
        [Browsable(false)]
        public int HeaderLen
        {
            get
            {
                return headerLen;
            }
            set { headerLen = value; }
        }

        private Version version = new Version(1, 0);
        [Browsable(false)]
        public Version Version
        {
            get
            {
                return version;
            }
            set
            {
                version = value;
            }

        }


        #endregion

        #region Methods

        #region Public
        public void Listen()
        {
            Thread thread = new Thread(new ThreadStart(DoListen));
            thread.Start();
        }

        public void Accept(Socket request)
        {

            try
            {
                OnStateChanged(new NotifyStateEventArgs(NotifyStates.ConnectionPending));
                client = request;
                OnConnected();
                OnStateChanged(new NotifyStateEventArgs(NotifyStates.Connected));
                client.BeginReceive(byteBuffer, 0, BufferSize, SocketFlags.None, new AsyncCallback(DoStreamReceive), null);
            }
            catch (Exception ex)
            {
                this.Close();
                OnStateChanged(new NotifyStateEventArgs(NotifyStates.Error));
                OnHandleError(new NotifyHandleErrorEventArgs(ex));
            }
        }

        public void Connect()
        {
            if (State == NotifyStates.Connected || (State == NotifyStates.Listening))
            {
                OnHandleError(new NotifyHandleErrorEventArgs(
                              new Exception("Already open, must be closed first")
                                                              )
                             );
                return;
            }
            try
            {
                IPAddress[] addresses = RemoteIPs;
                OnStateChanged(new NotifyStateEventArgs(NotifyStates.ResolvingHost));

                OnStateChanged(new NotifyStateEventArgs(NotifyStates.HostResolved));

                client = new Socket(
                                     AddressFamily.InterNetwork,
                                    Protocol == ProtocolType.Tcp ? SocketType.Stream : SocketType.Dgram,
                                    (System.Net.Sockets.ProtocolType)Protocol
                                    );
                client.SendBufferSize = BufferSize;


                // IPEndPoint remotEndPoint = new IPEndPoint(IPAddress.Parse(remIP), RemotePort);

                OnStateChanged(new NotifyStateEventArgs(NotifyStates.Connecting));
                client.BeginConnect(addresses, RemotePort, new AsyncCallback(OnConnected), null);
            }
            catch (Exception ex)
            {
                OnStateChanged(new NotifyStateEventArgs(NotifyStates.Error));
                OnHandleError(new NotifyHandleErrorEventArgs(ex));
            }
        }

        public void Connect(bool wait)
        {
            if (!wait) { Connect(); return; }

            if (State == NotifyStates.Connected || (State == NotifyStates.Listening))
            {
                OnHandleError(new NotifyHandleErrorEventArgs(
                              new Exception("Already open, must be closed first")
                                                              )
                             );
                return;
            }
            try
            {
                IPAddress[] addresses = RemoteIPs;
                OnStateChanged(new NotifyStateEventArgs(NotifyStates.ResolvingHost));


                client = new Socket(
                                     AddressFamily.InterNetwork,
                                    Protocol == ProtocolType.Tcp ? SocketType.Stream : SocketType.Dgram,
                                    (System.Net.Sockets.ProtocolType)Protocol
                                    );
                client.SendBufferSize = BufferSize;


                // IPEndPoint remotEndPoint = new IPEndPoint(IPAddress.Parse(remIP), RemotePort);

                OnStateChanged(new NotifyStateEventArgs(NotifyStates.Connecting));
                client.Connect(addresses, RemotePort);
                OnStateChanged(new NotifyStateEventArgs(NotifyStates.Connected));
            }
            catch (Exception ex)
            {
                OnStateChanged(new NotifyStateEventArgs(NotifyStates.Error));
                OnHandleError(new NotifyHandleErrorEventArgs(ex));
            }
        }

        public void Connect(IPAddress[] addresses, int port)
        {
            RemoteIPs = addresses;
            RemotePort = port;
            Connect();
        }

        public void Connect(string ip, int port)
        {
            RemoteIPs = new IPAddress[1] { IPAddress.Parse(ip) };
            RemotePort = port;
            Connect();
        }

        public void Close()
        {
            try
            {
                switch (State)
                {
                    case NotifyStates.Listening:
                        {
                            OnStateChanged(new NotifyStateEventArgs(NotifyStates.Closing));
                            if (tcpListener != null)
                                tcpListener.Stop();

                        }
                        break;
                    case NotifyStates.Connected:
                    case NotifyStates.Connecting:
                    case NotifyStates.ConnectionPending:
                    case NotifyStates.HostResolved:
                    case NotifyStates.Open:
                    case NotifyStates.ResolvingHost:
                        {
                            OnStateChanged(new NotifyStateEventArgs(NotifyStates.Closing));
                            if (client != null)
                                client.Close();
                        }
                        break;
                    case NotifyStates.Closed:
                        {
                            //    do nothing
                        }
                        break;
                }
                if (udpListener != null)
                {
                    udpListener.Client.Shutdown(SocketShutdown.Both);
                    udpListener = null;
                }
                OnStateChanged(new NotifyStateEventArgs(NotifyStates.Closed));
            }
            catch (Exception ex)
            {
                OnStateChanged(new NotifyStateEventArgs(NotifyStates.Error));
                OnHandleError(new NotifyHandleErrorEventArgs(ex));
            }
        }

        public string GetLocalIP()
        {
            IPHostEntry host = Dns.GetHostEntry(System.Net.Dns.GetHostName());
            return (host.AddressList.GetValue(0) as IPAddress).ToString();
        }

        public string GetRemoteHostIP()
        {
            IPEndPoint ipEndPoint = client.RemoteEndPoint as IPEndPoint;
            return ipEndPoint.Address.ToString();
        }

        #region Send Overloads

        public void Send(NWinsockData data, CompressionType compressionType)
        {
            try
            {

                string header = string.Format("{0}-{1}-{2}-",
                                    PackageName,
                                    Version,
                                    (byte)compressionType);

                byte[] headerBytes = Encoding.ASCII.GetBytes(header);

                data.Context = Serialize(GetTypeWithDataType(data.DataType), data.Context);

                XmlSerializer serializer = new XmlSerializer(GetDataType(PackageName));
                using (MemoryStream mStream = new MemoryStream())
                {
                    serializer.Serialize(mStream, data);
                    byte[] serializeBytes = Compress(mStream.GetBuffer(), compressionType);

                    byte[] buffer = new byte[serializeBytes.Length + headerBytes.Length + 1];
                    Array.Copy(headerBytes, buffer, headerBytes.Length);
                    Array.Copy(serializeBytes, 0, buffer, headerBytes.Length, serializeBytes.Length);

                    buffer[buffer.Length - 1] = 4;
                    DoSend(buffer);
                }
            }
            catch (Exception) { }
        }


        #endregion


        public object Deserilize(Type type, byte[] bytes)
        {
            try
            {
                XmlSerializer deSerializer = new XmlSerializer(type);

                using (MemoryStream mStream = new MemoryStream(bytes, false))
                {
                    return deSerializer.Deserialize(mStream);
                }
            }
            catch { }
            return null;
        }

        public byte[] Serialize(Type type, object data)
        {
            XmlSerializer serializer = new XmlSerializer(type);
            byte[] bytes = null;
            using (MemoryStream mStream = new MemoryStream())
            {
                serializer.Serialize(mStream, data);
                bytes = mStream.ToArray();
            }
            return bytes;
        }
        #endregion

        #region Virtual
        protected virtual void OnConnected()
        {
            if (Connected != null)
            {
                if (RunEventsOnCurrentThread && ParentForm != null)
                {
                    if (ParentForm.IsHandleCreated)
                    {
                        ParentForm.Invoke(
                            (EventHandler)delegate(object sender, EventArgs nde)
                            {
                                Connected(sender, EventArgs.Empty);
                            }, this);
                    }
                }
                else
                    Connected(this, EventArgs.Empty);
            }
        }

        protected virtual void OnDisconnected()
        {
            if (Disconnected != null)
            {
                if (RunEventsOnCurrentThread && ParentForm != null)
                {
                    if (ParentForm.IsHandleCreated)
                    {
                        ParentForm.Invoke(
                            (EventHandler)delegate(object sender, EventArgs nde)
                            {
                                Disconnected(sender, EventArgs.Empty);
                            }, this);
                    }
                }
                else
                    Disconnected(this, EventArgs.Empty);
            }
        }

        protected virtual void OnSendComplete()
        {
            if (SendComplete != null)
            {
                if (RunEventsOnCurrentThread && ParentForm != null)
                {
                    if (ParentForm.IsHandleCreated)
                    {
                        ParentForm.Invoke(
                            (EventHandler)delegate(object sender, EventArgs nde)
                            {
                                SendComplete(sender, EventArgs.Empty);
                            }, this);
                    }
                }
                else
                    SendComplete(this, EventArgs.Empty);
            }
        }

        protected virtual void OnDataArrival(NotifyDataArrivalEventArgs e)
        {
            //if (e.Data.IP == Data.IP) return;
            

            if (DataArrival != null )
            {
                
                if (RunEventsOnCurrentThread && ParentForm != null)
                {
                    if (!ParentForm.IsHandleCreated) return;
                    ParentForm.Invoke(
                        (EventHandler<NotifyDataArrivalEventArgs>)
                        delegate(object sender, NotifyDataArrivalEventArgs nde)
                        {
                            DataArrival(sender, nde);
                        }, this, e);

                }
                else
                    DataArrival(this, e);


            }
        }

        protected virtual void OnConnectionRequest(NotifyRequestEventArgs e)
        {
            if (ConnectionRequest != null)
            {
                if (RunEventsOnCurrentThread && ParentForm != null)
                {
                    if (!ParentForm.IsHandleCreated) return;
                    ParentForm.Invoke(
                             (EventHandler<NotifyRequestEventArgs>)
                             delegate(object sender, NotifyRequestEventArgs nre)
                             {
                                 ConnectionRequest(sender, nre);
                             }, this, e);
                }
                else
                    ConnectionRequest(this, e);
            }
        }

        protected virtual void OnHandleError(NotifyHandleErrorEventArgs e)
        {
            if (HandleError != null)
            {
                if (RunEventsOnCurrentThread && ParentForm != null)
                {
                    if (!ParentForm.IsHandleCreated) return;
                    ParentForm.Invoke(
                             (EventHandler<NotifyHandleErrorEventArgs>)
                             delegate(object sender, NotifyHandleErrorEventArgs nhe)
                             {
                                 HandleError(sender, nhe);
                             }, this, e);
                }
                else
                    HandleError(this, e);
            }
        }

        protected virtual void OnStateChanged(NotifyStateEventArgs e)
        {
            state = e.State;
            if (StateChanged != null)
            {
                if (RunEventsOnCurrentThread && ParentForm != null)
                {
                    ParentForm.Invoke(
                                 (EventHandler<NotifyStateEventArgs>)
                                 delegate(object sender, NotifyStateEventArgs nse)
                                 {
                                     StateChanged(sender, nse);
                                 }, this, e);
                }
                else
                    StateChanged(this, e);
            }
        }

        #endregion

        #region Private

        private void AddToBuffer(byte[] bytes, int count)
        {

            int iCurUB = (buffer != null) ? buffer.Length - 1 : -1;

            
            int iNewUB = iCurUB + count;
            if (buffer == null)
                buffer = new byte[iNewUB + 1];
            else
                Array.Resize<byte>(ref buffer, iNewUB + 1);

            Array.Copy(bytes, 0, buffer, iCurUB + 1, count);
            

            byte byteRem = 4;//♦
            

            byte iIdx = buffer[buffer.Length - 1];

            if (iIdx == byteRem)//EQUAL WITH ♦
            {
                //this.bufferList.Add(buffer);

                byte[] headerBytes = new byte[HeaderLen];
                byte[] bodyBytes = new byte[buffer.Length - headerLen];

                //header
                Array.Copy(buffer, 0, headerBytes, 0, HeaderLen);
                //body
                Array.Copy(buffer, HeaderLen, bodyBytes, 0, buffer.Length - 10);

                //get header
                string[] stHeaders = Encoding.ASCII.GetString(headerBytes).Split('-');

                //get CompressionType
                CompressionType compressionType = (CompressionType)byte.Parse(stHeaders[2]);

                //get Body
                NWinsockData data = Deserilize(GetDataType(stHeaders[0]), Decompress(bodyBytes, compressionType)) as NWinsockData;

                data.Context = Deserilize(GetTypeWithDataType(data.DataType), data.Context as byte[]);


                //call dataArrival
                OnDataArrival(new NotifyDataArrivalEventArgs(stHeaders[0],
                                  new Version(stHeaders[1]),
                                  buffer.Length,
                                  compressionType,
                                  data));

                this.buffer = null;
            }
        }

        private void OnClientConnect(IAsyncResult asyn)
        {
            try
            {
                Socket tempSocket;
                if (State == NotifyStates.Listening)
                {
                    tempSocket = tcpListener.EndAcceptSocket(asyn);
                    OnConnectionRequest(new NotifyRequestEventArgs(tempSocket));

                    tcpListener.BeginAcceptSocket(new AsyncCallback(OnClientConnect), null);
                }
            }
            catch (Exception ex)
            {
                this.Close();
                OnStateChanged(new NotifyStateEventArgs(NotifyStates.Error));
                OnHandleError(new NotifyHandleErrorEventArgs(ex));
            }
        }

        private void OnConnected(IAsyncResult asyn)
        {
            try
            {
                client.EndConnect(asyn);
                this.CliennalizeConnection();
            }
            catch (Exception ex)
            {
                OnStateChanged(new NotifyStateEventArgs(NotifyStates.Error));
                OnHandleError(new NotifyHandleErrorEventArgs(ex));
            }
        }

        private void CliennalizeConnection()
        {
            OnStateChanged(new NotifyStateEventArgs(NotifyStates.Connected));
            client.BeginReceive(byteBuffer, 0, BufferSize, SocketFlags.None, new AsyncCallback(DoRead), null);
            OnConnected();
        }

        private void DoListen()
        {
            try
            {
                IPEndPoint ipLocal = new IPEndPoint(IPAddress.Any, LocalPort);
                if (Protocol == ProtocolType.Tcp)
                {
                    tcpListener = new TcpListener(ipLocal);

                    tcpListener.Start(10);
                    OnStateChanged(new NotifyStateEventArgs(NotifyStates.Listening));

                    tcpListener.BeginAcceptSocket(new AsyncCallback(OnClientConnect), null);
                }
                else
                {
                    bool done = false;
                    try
                    {
                        udpListener = new UdpClient(LocalPort);
                        OnStateChanged(new NotifyStateEventArgs(NotifyStates.Connected));
                        while (!done)
                        {
                            byteBuffer = udpListener.Receive(ref ipLocal);
                            int iCount = byteBuffer.Length;
                            if (iCount < 1)
                            {
                                this.Close();
                                byteBuffer = new byte[BufferSize];
                                OnDisconnected();
                                continue;
                            }
                            try
                            {
                                AddToBuffer(byteBuffer, iCount);
                                Array.Clear(byteBuffer, 0, iCount);
                            }
                            catch { buffer = null; }
                        }
                    }
                    catch (Exception ex)
                    {
                        OnStateChanged(new NotifyStateEventArgs(NotifyStates.Error));
                        OnHandleError(new NotifyHandleErrorEventArgs(ex));
                    }
                    finally
                    {
                        udpListener.Close();
                    }

                }

            }
            catch (Exception ex)
            {
                this.Close();
                OnStateChanged(new NotifyStateEventArgs(NotifyStates.Error));
                OnHandleError(new NotifyHandleErrorEventArgs(ex));
            }

        }

        private void DoSend(byte[] data)
        {
            if (State != NotifyStates.Connected)
            {
                Connect(true);
            }
            if (State == NotifyStates.Connected)
            {
                try
                {

                    if (Protocol == ProtocolType.Tcp)
                    {
                        //client.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(IPAddress.Parse("10.0.255.255")));
                        client.Send(data);
                    }
                    else
                    {
                        int offset = 0;
                        int len = 0;


                        while (offset != data.Length)
                        {
                            len = data.Length - offset > 1024 ? 1024 : data.Length - offset;
                            client.Send(data, offset, len, SocketFlags.None);
                            offset += len;
                        }
                    }
                    OnSendComplete();
                }
                catch (Exception ex)
                {
                    this.Close();
                    OnStateChanged(new NotifyStateEventArgs(NotifyStates.Error));
                    OnHandleError(new NotifyHandleErrorEventArgs(ex));
                }
            }
        }

        private void DoRead(IAsyncResult async)
        {
            int iCount = 0;
            try
            {
                iCount = client.EndReceive(async);
                if (iCount < 1)
                {
                    this.Close();
                    byteBuffer = new byte[BufferSize];
                    OnDisconnected();
                    return;
                }
                AddToBuffer(byteBuffer, iCount);

                Array.Clear(byteBuffer, 0, iCount);
                client.BeginReceive(byteBuffer, 0, BufferSize, SocketFlags.None, new AsyncCallback(DoRead), null);
            }
            catch (Exception)
            {
                this.Close();
                byteBuffer = new byte[BufferSize];
                OnDisconnected();
            }
        }

        private void DoStreamReceive(IAsyncResult asyn)
        {
            int iCount = 0;
            try
            {
                lock (client) { iCount = client.EndReceive(asyn); }
                if (iCount < 1)
                {
                    this.Close();
                    Array.Resize<byte>(ref byteBuffer, BufferSize);
                    OnDisconnected();
                    return;
                }
                AddToBuffer(byteBuffer, iCount);
                Array.Clear(byteBuffer, 0, iCount);
                lock (client)
                {
                    client.BeginReceive(byteBuffer, 0, BufferSize, SocketFlags.None, new AsyncCallback(DoStreamReceive), null);
                }
            }
            catch (Exception)
            {
                this.Close();
                Array.Resize(ref byteBuffer, BufferSize);
                OnDisconnected();
            }
        }

        private byte[] Compress(byte[] bytes, CompressionType type)
        {
            if (type == CompressionType.None || bytes.Length == 0) return bytes;

            using (MemoryStream mStreamWrite = new MemoryStream())
            {

                if (type == CompressionType.GZipStream)
                {
                    GZipStream ziper = new GZipStream(
                                                      mStreamWrite,
                                                      CompressionMode.Compress,
                                                      true
                                                      );
                    ziper.Write(bytes, 0, bytes.Length);
                    ziper.Close();
                }
                else
                {
                    DeflateStream deflater = new DeflateStream(
                                                            mStreamWrite,
                                                            CompressionMode.Compress,
                                                            true
                                                            );
                    deflater.Write(bytes, 0, bytes.Length);
                    deflater.Close();
                }

                return mStreamWrite.ToArray();
            }
        }

        private byte[] Decompress(byte[] bytes, CompressionType type)
        {
            if (type == CompressionType.None || bytes.Length == 0) return bytes;

            if (bytes == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                using (MemoryStream mStreamWrite = new MemoryStream(bytes))
                {
                    bytes = new byte[bytes.Length];


                    if (type == CompressionType.GZipStream)
                    {
                        GZipStream unZiper = new GZipStream(mStreamWrite, CompressionMode.Decompress);

                        Pump(unZiper, ms);

                        unZiper.Close();
                    }
                    else
                    {
                        DeflateStream unDeflater = new DeflateStream(mStreamWrite, CompressionMode.Decompress);

                        Pump(unDeflater, ms);

                        unDeflater.Close();
                    }
                }
                bytes = ms.ToArray();
            }
            return bytes;
        }

        private Type GetDataType(string pocketName)
        {
            switch (pocketName)
            {
                case "PKG":
                    return typeof(NWinsockData);
                default:
                    return typeof(Data);
            }
        }

        private Type GetTypeWithDataType(DataType dataType)
        {
            switch (dataType)
            {
                case DataType.String:
                    return typeof(string);
                case DataType.DataTable:
                    return typeof(DataTable);
                case DataType.DataSet:
                    return typeof(DataSet);
                case DataType.ID:
                    return typeof(int);
                case DataType.IList:
                    return typeof(IList);
            }
            return null;
        }
        #endregion

        #region Static
        private static void Pump(Stream input, Stream output)
        {

            byte[] bytes = new byte[4096];

            int n;

            while ((n = input.Read(bytes, 0, bytes.Length)) != 0)
            {
                output.Write(bytes, 0, n);
            }

        }
        #endregion



        #endregion


    }//end class


    public sealed class NWinsockData : Data, IData
    {
        public NWinsockData()
        {
            Init();
            base.Date = DateTime.Now;
            base.Params = new SerializableDictionary<string, NameValue>();
        }


        #region Props
        public string ApplicationName { get; set; }

        public DataType DataType { get; set; }

        public ActionType Action { get; set; }

        public object Context { get; set; }//default null

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format(@"Subject:{0},
DataType:{1},
Context:{2},
Date:{3},
MacAddress:{4},
IP:{5}",
                                  Subject,
                                  DataType,
                                  Context,
                                  Date,
                                  MacAddress,
                                  IP);
        }

        public void Init()
        {
            try
            {
                ManagementScope theScope = new ManagementScope("\\\\" + Environment.MachineName + "\\root\\cimv2");
                StringBuilder theQueryBuilder = new StringBuilder();
                theQueryBuilder.Append("Select MacAddress,IPAddress from Win32_NetworkAdapterConfiguration where IPEnabled=TRUE");

                ObjectQuery theQuery = new ObjectQuery(theQueryBuilder.ToString());

                ManagementObjectSearcher theSearcher = new ManagementObjectSearcher(theScope, theQuery);

                ManagementObjectCollection theCollectionOfResults = theSearcher.Get();

                foreach (ManagementObject theCurrentObject in theCollectionOfResults)
                {
                    base.MacAddress = theCurrentObject["MACAddress"] != null ? theCurrentObject["MACAddress"].ToString() : null;

                    string[] sArray = theCurrentObject["IPAddress"] as string[];
                    if (sArray != null && sArray.Length > 0)
                        base.IP = sArray[0];

                    break;
                }
            }
            catch (Exception) { }
        }

        #endregion



    }//end class

   

    internal class IPAddressConvertor : ExpandableObjectConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
                return true;
            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {

            if (value is string)
            {
                try
                {
                    if (value == null || (value.ToString().Length != 0))
                    {
                        string[] values = value.ToString().Split(',');
                        IPAddress[] ips = new IPAddress[values.Length];
                        try
                        {
                            for (int i = 0; i < values.Length; i++)
                            {
                                ips[i] = IPAddress.Parse(values[i]);
                            }
                        }
                        catch { }
                        return ips;
                    }
                    return new IPAddress[1] { IPAddress.None };
                }
                catch (Exception ex)
                {
                    throw new FormatException(ex.Message);
                }
            }
            return base.ConvertFrom(context, culture, value);

        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType)
        {
            if (destinationType == typeof(string) && (value is IPAddress[]))
            {
                string retVal = string.Empty;
                foreach (IPAddress ipAddress in (IPAddress[])value)
                {
                    retVal += ipAddress.ToString() + ",";
                }
                return retVal;
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }


    }//end class

}//end namespace

