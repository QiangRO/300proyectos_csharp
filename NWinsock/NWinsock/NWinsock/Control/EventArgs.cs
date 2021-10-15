using System;
using System.Net.Sockets;

namespace Control.Notify
{


    public class CommandArrivalEventArgs : EventArgs
    {
        public string Replay
        {
            get;
            set;
        }

        public DateTime ReplaySendTime
        {
            get;
            set;
        }

        public string IP
        {
            get;
            set;
        }
    }//end class

    public class NotifyDataArrivalEventArgs : EventArgs
    {
        public NotifyDataArrivalEventArgs(string packageName, Version version, int bytesTotal, CompressionType compressionType, NWinsockData data)
        {
            PocketName = packageName;
            Version = version;
            CompressionType = compressionType;

            BytesTotal = bytesTotal;
            this.Data = data;
        }

        public NWinsockData Data
        {
            get;
            private set;
        }

        public int BytesTotal
        {
            get;
            private set;
        }

        public Version Version
        {
            get;
            private set;
        }

        public CompressionType CompressionType
        {
            get;
            private set;
        }

        public string PocketName
        {
            get;
            private set;
        }

    }//end class


    public class NotifyRequestEventArgs : EventArgs
    {
        public NotifyRequestEventArgs(Socket socket)
        {
            Request = socket;
        }

        public Socket Request
        {
            get;
            private set;
        }
    }//end class



    public class NotifyHandleErrorEventArgs : EventArgs
    {

        public NotifyHandleErrorEventArgs(Exception ex)
        {
            Description = ex.Message;
            if (ex.TargetSite != null)
                SenderMethod = ex.TargetSite.Name;
            Exception = ex;
        }

        public string Description
        {
            get;
            private set;
        }

        public string SenderMethod
        {
            get;
            private set;
        }

        public Exception Exception
        {
            get;
            private set;
        }

    }//end class

    public class NotifyStateEventArgs : EventArgs
    {
        public NotifyStateEventArgs(NotifyStates state)
        {
            State = state;
        }

        public NotifyStates State
        {
            get;
            private set;
        }
    }//end class
}//end namespace