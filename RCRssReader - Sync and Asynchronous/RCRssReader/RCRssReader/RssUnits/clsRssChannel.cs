using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RCRssReader.RssUnits
{
    /// <summary>
    /// Rss Channel, contains RssItems
    /// </summary>
    public class clsRssChannel :clsBaseRssUnit
    {
        /// <summary>
        /// RssItems in d channel
        /// </summary>
        public List<clsRssItem> RssItems { get; set; }

        public clsRssChannel()
        {
            RssItems = new List<clsRssItem>();
        }

        public override string ToString()
        {
            return string.Format("RSS Channel : {0}", base.ToString());
        }

        public bool HasRssItems
        {
            get { return RssItems.Count > 0; }
        }

        public int RssItemsCount
        {
            get { return RssItems.Count; } 
        }
    }
}
