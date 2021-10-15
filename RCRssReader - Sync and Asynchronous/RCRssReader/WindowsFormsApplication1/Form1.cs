using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RCRssReader;
using RCRssReader.RssUnits;

namespace WindowsFormsApplication1
{
    public partial class FrmTestRssReader : Form
    {
        private clsRssProvider _rssProvider;

        public FrmTestRssReader()
        {
            InitializeComponent();
            txtRssUrl.MaxLength = 128;

            _rssProvider = new clsRssProvider();

            _rssProvider.OnRssFeedsGettingCompleted += new EventHandler<clsRssFeedsGettingCompletedEventArgs>(_rssProvider_OnRssFeedsGettingCompleted);
            _rssProvider.OnRssFeedsGettingErrorOccurred += new EventHandler<clsRssFeedsGettingErrorOccurred>(_rssProvider_OnRssFeedsGettingErrorOccurred);
            _rssProvider.OnRssFeedsGettingBegan += new EventHandler<clsRssFeedsGettingBegan>(_rssProvider_OnRssFeedsGettingBegan);
        
            reset_UI();
        }

        #region Sync
        private void btnGetRssSync_Click(object sender, EventArgs e)
        {
            Uri uriRss = null;
            try
            {
                uriRss = new Uri(txtRssUrl.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            reset_UI();
            picAsyncWorking.Show();
            lblRssItemCount.Text = string.Format("<Sync> Getting Rss contents from {0}...", uriRss.ToString());
            Application.DoEvents();

            string errors;
            clsRssChannel channel = _rssProvider.Get_Rss(uriRss, out errors);
            
            set_UI(string.Format("<Sync> Getting Rss feeds from {0} Completed - Errors={1} - Count={2}"
                , channel.Link!=null ? channel.Link.ToString() : "---", errors, channel.RssItems.Count), channel, false);
        }
        #endregion Sync

        
        #region Async
        private void btnGetRssAsync_Click(object sender, EventArgs e)
        {
            Uri uriRss =null;
            try
            {
                uriRss = new Uri(txtRssUrl.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
                       
            _rssProvider.Get_Rss_Async(uriRss);
        }

        private void _rssProvider_OnRssFeedsGettingBegan(object sender, clsRssFeedsGettingBegan e)
        {
            reset_UI();
            picAsyncWorking.Show();
            lblRssItemCount.Text = string.Format("<Async> Getting Rss contents from {0}..." , e.RssChannel.Link.ToString() );
            Application.DoEvents();
        }
        private void _rssProvider_OnRssFeedsGettingErrorOccurred(object sender, clsRssFeedsGettingErrorOccurred e)
        {
            set_UI("<Async> Error(s) occurred." + e.ErrorMessage, null, true );
        }
        private void _rssProvider_OnRssFeedsGettingCompleted(object sender, clsRssFeedsGettingCompletedEventArgs e)
        {
            set_UI(string.Format("<Async> Getting Rss feeds from {0} Completed - Count={1}", e.RssChannel.Link.ToString(),e.RssChannel.RssItems.Count),e.RssChannel,false);
        }
        #endregion Async

        private void reset_UI()
        {
            picAsyncWorking.Hide();
            dgRssItems.Columns.Clear();

            lblRssItemCount.Text = string.Empty;
            lblRssItemCount.ForeColor = Color.Black;

            foreach (Control con in gboxChannelInfo.Controls)
            {
                if (con is TextBox)
                    (con as TextBox).ResetText();
            }
        }
        private void set_UI(string pMsg, clsRssChannel pRssChannel, bool pErrorOccurred)
        {
            if (dgRssItems.InvokeRequired)
            {
                DelgInvokerSetRssChannelUI d = new DelgInvokerSetRssChannelUI(set_UI);
                Invoke(d, pMsg, pRssChannel,pErrorOccurred);
                return;
            }

            picAsyncWorking.Hide();
            lblRssItemCount.Text = pMsg;

            if (pErrorOccurred)
            {
                lblRssItemCount.ForeColor = Color.Red;
                return;
            }

            dgRssItems.DataSource = pRssChannel.RssItems;

            txtChannelTitle.Text = pRssChannel.Title ?? "---";
            txtChannelDescription.Text = pRssChannel.Description ?? "---";
            txtChannelPubDate.Text = pRssChannel.PubDate == DateTime.MinValue
                ? "---"
                : pRssChannel.PubDate.ToString();
            txtChannelLink.Text = pRssChannel.Link == null
                ? "---"
                : pRssChannel.Link.ToString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rss Reader (Synchronous + Asynchronous) by  :::RED-C0DE:::");
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}