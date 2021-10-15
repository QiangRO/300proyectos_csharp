using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Xml;
using RCRssReader.RssUnits;

namespace RCRssReader
{
    /// <summary>
    /// used in the Set_UI method in GUI class
    /// </summary>
    /// <param name="pMsg"></param>
    /// <param name="pRssChannel"></param>
    /// <param name="pErrorOccrured"></param>
    public delegate void DelgInvokerSetRssChannelUI(string pMsg, clsRssChannel pRssChannel , bool pErrorOccrured);

    public class clsRssProvider
    {
        #region XML elements constants
        
        const string _RSS_CHANNEL = "rss/channel";
        const string _XPATH_RSS_ITEM = "rss/channel/item";
        const string _RSS_TITLE = "title";
        const string _RSS_DESCRIPTION = "description";
        const string _RSS_LINK = "link";
        const string _RSS_PUBDATE = "pubDate";

        #endregion XML elements constants\

        #region RssProvider Events
        
        public virtual event EventHandler<clsRssFeedsGettingBegan> OnRssFeedsGettingBegan;
        public virtual event EventHandler<clsRssFeedsGettingCompletedEventArgs> OnRssFeedsGettingCompleted;
        public virtual event EventHandler<clsRssFeedsGettingErrorOccurred> OnRssFeedsGettingErrorOccurred;
        
        #endregion RssProvider Events\



        #region Synchronous RssReader
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pUriRss">
        ///RSS Feed , ex: 
        ///http://www.microsoft.com/feeds/msdn/en-us/rss.xml
        ///http://www.securityfocus.com/rss/news.xml 
        /// </param>
        /// <returns>List of RssItems</returns>
        public clsRssChannel Get_Rss(Uri pUriRss, out string outpErrors)
        {
            // empty RssChannel
            clsRssChannel retRssChannel = new clsRssChannel();

            string errors = string.Empty;

            // web request to the pUriRss
            WebRequest webreqRss = WebRequest.Create(pUriRss);

            // get the response from the pUriRss
            using (WebResponse webrespRss = webreqRss.GetResponse())
            {
                // get the stream from the response , 
                // stream that contains xml document with Rss schema
                using (Stream srRss = webrespRss.GetResponseStream())
                {
                    // get the RssItems from the xmlDocument in the stream
                    retRssChannel = clsRssProvider.get_Rss_Channel_From_Raw_Stream(srRss);
                }
            }

            // log the errors in application's current dir
            if (!string.IsNullOrEmpty(errors))
                RCEventLogger.clsEventLogger.Log_This(errors.Substring(0, errors.Length - 2));

            outpErrors = errors;

            // finaly , return the RssChannel...
            return retRssChannel;            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pUriRss"></param>
        /// <returns></returns>
        public clsRssChannel Get_Rss(Uri pUriRss)
        {
            // empty RssChannel
            clsRssChannel retRssChannel = new clsRssChannel();

            string errors = string.Empty;

            // web request to the pUriRss
            WebRequest webreqRss = WebRequest.Create(pUriRss);

            // get the response from the pUriRss
            using (WebResponse webrespRss = webreqRss.GetResponse())
            {
                // get the stream from the response , 
                // stream that contains xml document with Rss schema
                using (Stream srRss = webrespRss.GetResponseStream())
                {
                    // get the RssItems from the xmlDocument in the stream
                    retRssChannel = clsRssProvider.get_Rss_Channel_From_Raw_Stream(srRss);
                }
            }

            // log the errors in application's current dir
            if (!string.IsNullOrEmpty(errors))
                RCEventLogger.clsEventLogger.Log_This(errors.Substring(0, errors.Length - 2));

            // finaly , return the RssChannel...
            return retRssChannel;
        }

        #endregion sync


        #region Asynchronous RssReader

        public void Get_Rss_Async(Uri pUriRss )
        {
            try
            {
                // make request to the pUriRss
                WebRequest webReqRssContent = WebRequest.Create(pUriRss);

                // make requestState for holding the request + response state in the callBack method (callback_Rss_Got_Response)
                clsRequestState requestState = new clsRequestState();
                requestState.Request = webReqRssContent;

                // raise the event begin getting RssItms
                if (OnRssFeedsGettingBegan != null)
                {
                    clsRssChannel rsschannel = new clsRssChannel() { Link = pUriRss };
                    clsRssFeedsGettingBegan e = new clsRssFeedsGettingBegan(rsschannel);
                    OnRssFeedsGettingBegan(this, e);
                }

                // **Getting response from the source...the gui working properly too
                webReqRssContent.BeginGetResponse(callback_Rss_Got_Response, requestState);
            }
            catch (Exception ex)
            {
                // log errors in app's current dir
                RCEventLogger.clsEventLogger.Log_This(ex.Message);
            }
        }

        private void callback_Rss_Got_Response(IAsyncResult pAsyncResult)
        {
            // for fetching requestState from the pAsyncResult,,, (requestState holds WebRequest + WebResponse)
            clsRequestState reqStateAsyncState = null;
            try
            {
                // and now fetching requestState from the pAsyncResult,,, (requestState holds WebRequest + WebResponse)
                reqStateAsyncState = (clsRequestState)pAsyncResult.AsyncState;
                
                // getting webRequest from the RequestState to get Response from it
                WebRequest webreqAsyncRssReader = reqStateAsyncState.Request;

                // end the Asynchronous response
                reqStateAsyncState.Response = webreqAsyncRssReader.EndGetResponse(pAsyncResult);

                // read the response into a 'Stream' object.
                Stream responseStream = reqStateAsyncState.Response.GetResponseStream();
                using (StreamReader srRss = new StreamReader(responseStream))
                {
                    // get the RssChannel from the ResponseStream
                    clsRssChannel rssChannel = clsRssProvider.get_Rss_Channel_From_Raw_Stream(srRss.BaseStream);

                    // raise the error event if there r any
                    if (rssChannel.HasRssItems == false && OnRssFeedsGettingErrorOccurred != null)
                    {
                        clsRssFeedsGettingErrorOccurred e = new  clsRssFeedsGettingErrorOccurred (rssChannel,"Empty content.Check ur connection,uri or try again.");
                        OnRssFeedsGettingErrorOccurred(this,e);
                        return;
                    }

                    // raise the CompeletedGettingRssEvent for handling in the GUI Class
                    if (OnRssFeedsGettingCompleted != null)
                    {
                        clsRssFeedsGettingCompletedEventArgs e = new clsRssFeedsGettingCompletedEventArgs(rssChannel);
                        OnRssFeedsGettingCompleted(this, e);
                    }
                }
            }
            catch (Exception ex)
            {
                if (OnRssFeedsGettingErrorOccurred != null)
                {
                    clsRssFeedsGettingErrorOccurred err = new clsRssFeedsGettingErrorOccurred(null, ex.Message);
                    OnRssFeedsGettingErrorOccurred(this, err);
                }
            }
            finally
            {
                if (reqStateAsyncState != null && reqStateAsyncState.Response != null)
                    reqStateAsyncState.Response.Close();
            }
        }

        #endregion Asynchronous RssReader\


        /// <summary>
        /// Make RssChannel from d raw stream that contains xml document with RSS schema
        /// </summary>
        /// <param name="pRawStream">Stream that contains xml document with RSS schema</param>
        /// <returns></returns>
        private static clsRssChannel get_Rss_Channel_From_Raw_Stream(Stream pRawStream)
        {
            string errors = string.Empty;
            clsRssChannel retRssChannel = new clsRssChannel();
            XmlDocument xmldocRssContent = new XmlDocument();

            try
            {
                // load stream in xmlDocument from raw stream 
                xmldocRssContent.Load(pRawStream);

                // *** xml schema should be have d standard structure of the Rss (Title,Decription,Link)

                // geting RSS Channel info
                XmlNode xmlNodeChannel = xmldocRssContent.SelectSingleNode(_RSS_CHANNEL);
                try
                {
                    retRssChannel.Title = xmlNodeChannel.SelectSingleNode(_RSS_TITLE).InnerText ?? string.Empty;
                    retRssChannel.Description = xmlNodeChannel.SelectSingleNode(_RSS_DESCRIPTION).InnerText ?? string.Empty;
                    retRssChannel.Link = new Uri(xmlNodeChannel.SelectSingleNode(_RSS_LINK).InnerText ?? string.Empty);
                    retRssChannel.PubDate = DateTime.Parse(xmlNodeChannel.SelectSingleNode(_RSS_PUBDATE).InnerText);
                }
                catch (FormatException fex)
                {
                    //...
                    errors += fex.Message + Environment.NewLine;
                }
                catch (NullReferenceException nrex)
                {
                    //...
                    errors += nrex.Message + Environment.NewLine;
                }


                // Geting RSS Items info 
                XmlNodeList xmlnodeRssItems = xmldocRssContent.SelectNodes(_XPATH_RSS_ITEM);
                foreach (XmlNode xmlnodeRss in xmlnodeRssItems)
                {
                    clsRssItem rssItem = new clsRssItem();

                    try
                    {
                        rssItem.Title = xmlnodeRss.SelectSingleNode(_RSS_TITLE).InnerText ?? string.Empty;
                        rssItem.Description = xmlnodeRss.SelectSingleNode(_RSS_DESCRIPTION).InnerText ?? string.Empty;
                        rssItem.Link = new Uri(xmlnodeRss.SelectSingleNode(_RSS_LINK).InnerText ?? string.Empty);
                        rssItem.PubDate = DateTime.Parse(xmlnodeRss.SelectSingleNode(_RSS_PUBDATE).InnerText);
                    }
                    catch (FormatException fex)
                    {
                        //...
                        errors += fex.Message + Environment.NewLine;
                    }
                    catch (NullReferenceException nrex)
                    {
                        //...
                        errors += nrex.Message + Environment.NewLine;
                    }
                    finally
                    {
                        if (!string.IsNullOrEmpty(rssItem.Title))
                            retRssChannel.RssItems.Add(rssItem);
                    }
                }
            }
            catch (Exception ex)
            {
                errors += ex.Message + Environment.NewLine;
            }
            finally
            {
                pRawStream.Close();
            }

            if (!string.IsNullOrEmpty(errors))
                RCEventLogger.clsEventLogger.Log_This(errors.Substring(0, errors.Length - 2));

            //finaly , return the RssChannel...
            return retRssChannel;
        }
    }
}
