
//
//  For TCP, the server name is
// resolved and a socket is created to attempt a connection to each address
// returned until a connection succeeds. Once connected the client sends a "request"
// message to the server and shuts down the sending side. The client then loops
// to receive the server response until the server closes the connection at which
// point the client closes its socket and exits. Note that the server
// sends several zero byte datagrams but if they are lost, the client will never
// exit.
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;


namespace Client
{
    /// <summary>
    /// This is a simple TCP based client.
    /// </summary>
    public partial class Form1 : Form
    {
        Socket clientSocket = null;
        IPEndPoint destination = null;
        byte[] sendBuffer, recvBuffer;
        Thread readThread;
        ProtocolType sockProtocol;
        SocketType sockType;
        int rc;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        /// <summary>
        /// This routine repeatedly copies a string message into a byte array until filled.
        /// </summary>
        /// <param name="dataBuffer">Byte buffer to fill with string message</param>
        static public void FormatBuffer(byte[] dataBuffer, string message)
        {
            byte[] byteMessage = System.Text.Encoding.ASCII.GetBytes(message);
            int index = 0;

            // First convert the string to bytes and then copy into send buffer
            while (index < byteMessage.Length)
            {
                for (int j = 0; j < dataBuffer.Length; j++)
                {
                    // Make sure another byte of data buffer became zero
                    if (index >= byteMessage.Length)
                    {
                        dataBuffer[j] = 0;
                    }
                    else
                    {
                        dataBuffer[j] = byteMessage[index];
                        index++;
                    }                    
                }
            }
        }

        /// <summary>
        /// This is the main function for the simple client. It parses the command line and creates
        /// a socket of the requested type. For TCP, it will resolve the name and attempt to connect
        /// to each resolved address until a successful connection is made. Once connected a request
        /// message is sent followed by shutting down the send connection. The client then receives
        /// data until the server closes its side at which point the client socket is closed. For
        /// UDP, the socket is created and if indicated connected to the server's address. A single
        /// request datagram message. The client then waits to receive a response and continues to
        /// do so until a zero byte datagram is receive which indicates the end of the response.
        /// </summary>
        private void RunClient()
        {
            sockType = SocketType.Stream;
            sockProtocol = ProtocolType.Tcp;
            IPAddress addr = IPAddress.Parse("127.0.0.1");

            // Port number for the destination
            int remotePort = 5150;

            // Size of the send and receive buffers
            int bufferSize = 4096;
            int rc;

            // Specified TCP
            sockType = SocketType.Stream;
            sockProtocol = ProtocolType.Tcp;

            sendBuffer = new byte[bufferSize];
            recvBuffer = new Byte[bufferSize];

            try
            {
                clientSocket = new Socket(
                addr.AddressFamily,
                sockType,
                sockProtocol
                );
                try
                {
                    // Create the endpoint that describes the destination
                    destination = new IPEndPoint(addr, remotePort);
                    StatusLabel1.Text = "Attempting connection to: " + destination.ToString();
                    clientSocket.Connect(destination);
  
                    if (clientSocket != null)
                        StatusLabel1.Text = "Connection to Server on " + destination.ToString();
                }
                catch (SocketException errr)
                {
                    // Connect faile so close the socket and try the next address
                    StatusLabel1.Text = errr.Message;
                    clientSocket.Close();
                    clientSocket = null;
                    BtnDC_Click(null, null);

                }


                // Make sure we have a valid socket before trying to use it
                if (clientSocket != null)
                {
                        // Receive data in a loop until the server closes the connection. For
                        //    TCP this occurs when the server performs a shutodwn or closes
                        //    the socket. For UDP, we'll know to exit when the remote host
                        //    sends a zero byte datagram.
                        while (true)
                        {
                            rc = clientSocket.Receive(recvBuffer);

                            StatusLabel1.Text = "Read "+rc+" bytes";

                            if (rc > 0)
                            {
                                TxtbxRcv.Text += System.Text.Encoding.ASCII.GetString(recvBuffer);            
                            }

                            // Exit loop if server indicates shutdown
                            if (rc == 0)
                            {
                                clientSocket.Close();
                                break;
                            }
                        }
                }
                else
                {
                    StatusLabel1.Text = "Unable to establish connection to server!";
                    BtnDC_Click(null, null);
                }
            }
            catch (SocketException err)
            {
                clientSocket.Close();
                BtnDC_Click(null, null);
                StatusLabel1.Text = err.Message;
            }

        }

        private void BtnSnd_Click(object sender, EventArgs e)
        {
            // Text message to put into the send buffer
            string textMessage = TxtbxSend.Text.Trim();

            // Format the string message into the send buffer
            FormatBuffer(sendBuffer, textMessage + "\r\n");

            // Send the request to the server
            rc = clientSocket.Send(sendBuffer);

            StatusLabel1.Text = "Sent request of " + rc + " bytes ";

            TxtbxSend.Clear();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // For TCP, shutdown sending on our side since the client won't send any more data
            BtnDC_Click(null, null);
            Application.ExitThread();
            System.Environment.Exit(System.Environment.ExitCode);
            Application.Exit();

        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            readThread = new Thread(new ThreadStart(RunClient));
            readThread.Start();
            BtnDC.Enabled = true;
            BtnSnd.Enabled = true;
            BtnConnect.Enabled = false;
        }

        private void BtnDC_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientSocket != null)
                {// For TCP, shutdown sending on our side since the client won't send any more data
                    clientSocket.Shutdown(SocketShutdown.Send);
                }
            }
            catch (Exception err)
            {
                StatusLabel1.Text = err.Message;
            }
            BtnConnect.Enabled = true;
            BtnSnd.Enabled = false;
        }

        private void TxtbxSend_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSnd_Click(null, null);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BtnExit_Click(null, null);
        }
    }
}

