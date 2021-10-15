using System;

namespace RCRssReader.RssUnits
{
    /// <summary>
    /// Base abstract Rss unit
    /// </summary>
    public abstract class clsBaseRssUnit
    {
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public Uri Link { get; set; }

        /// <summary>
        /// Publish date
        /// </summary>
        public DateTime PubDate { get; set; }
        
        public override string ToString()
        {
            return Title;
        }
    }
}
