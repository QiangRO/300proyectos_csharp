using System;
using System.Net;

namespace RCRssReader.RssUnits
{
    /// <summary>
    /// Holding the WebRequest and WebResponse for the Async Callback
    /// see the clsRssProvider.callback_Rss_Got_Response (...) private method
    /// </summary>
    public class clsRequestState
    {
        /// <summary>
        /// Async Request to the RssUri
        /// </summary>
        public WebRequest Request;

        /// <summary>
        /// Async Response from the RssUri
        /// </summary>
        public WebResponse Response;

        public clsRequestState()
        {
            Request = null;
            Response = null;
        }
    }
}
