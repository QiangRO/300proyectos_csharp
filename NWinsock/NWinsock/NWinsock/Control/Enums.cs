
namespace Control.Notify
{
    public enum NotifyStates
    {
        Closed = 0,
        Open = 1,
        Listening = 2,
        ConnectionPending = 3,
        ResolvingHost = 4,
        HostResolved = 5,
        Connecting = 6,
        Connected = 7,
        Closing = 8,
        Error = 9
    }//end enum

    public enum CompressionType
    {
        None = 0,
        GZipStream = 1,
        DeflateStream = 2
    }//end enum

    public enum DataType
    {
        String = 0,
        /// <summary>
        /// این نوع فعلا پشتیبانی نمیگردد
        /// </summary>
        Image = 1,
        DataTable = 2,
        DataSet = 3,
        IList = 4,
        ID=5,
        Other = 6
    }//end enum

    public enum ProtocolType
    {
        Tcp = 6,
        Udp = 17
    }//end enum

    public enum ActionType
    {
        None = 0,
        Insert = 1,
        Update = 2,
        Delete = 3,
        Sign = 4
    }//end enum

}//end namespace
