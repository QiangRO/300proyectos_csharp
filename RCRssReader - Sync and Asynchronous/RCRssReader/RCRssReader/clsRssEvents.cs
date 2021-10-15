using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RCRssReader.RssUnits;

namespace RCRssReader
{
    public abstract class clsBaseRssFeedsEventArgs : EventArgs
    {
        public clsRssChannel RssChannel{ get; set; }
        public bool GettingRssContentCompleted { get; set; }
        public bool GettingRssContentBegan { get; set; }

        public clsBaseRssFeedsEventArgs(clsRssChannel pRssChannel, bool pGettingRssContentCompleted, bool pGettingRssContentBegan)
        {
            RssChannel = pRssChannel;
            GettingRssContentCompleted = pGettingRssContentCompleted;
            GettingRssContentBegan = pGettingRssContentBegan;
        }
    }


    public sealed class clsRssFeedsGettingCompletedEventArgs :clsBaseRssFeedsEventArgs
    {
        public clsRssFeedsGettingCompletedEventArgs(clsRssChannel pRssChannel)
            :base(pRssChannel,true,false)
        {   }
    }

    public sealed class clsRssFeedsGettingBegan : clsBaseRssFeedsEventArgs
    {
        public clsRssFeedsGettingBegan(clsRssChannel pRssChannel)
            :base(pRssChannel,false,true)
        {   }
    }

    public sealed class clsRssFeedsGettingErrorOccurred: clsBaseRssFeedsEventArgs
    {
        public string ErrorMessage { get; set; }

        public clsRssFeedsGettingErrorOccurred(clsRssChannel pRssChannel ,string pErrorMsg)
            : base(pRssChannel, false, false)
        {
            ErrorMessage = pErrorMsg;
        }
    }

}
