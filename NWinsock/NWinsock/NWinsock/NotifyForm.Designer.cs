namespace NWinsock
{
    partial class NotifyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyForm));
            this.sourceListBox = new System.Windows.Forms.ListBox();

            this.transferButton = new System.Windows.Forms.Button();
            this.destListBox = new System.Windows.Forms.ListBox();
            this.notifyListener = new Control.Notify.NotifyProvider(this.components);
            this.notifySender = new Control.Notify.NotifyProvider(this.components);
            this.SuspendLayout();
            // 
            // sourceListBox
            // 
            this.sourceListBox.DisplayMember = "Name";
            this.sourceListBox.FormattingEnabled = true;
            this.sourceListBox.Location = new System.Drawing.Point(17, 17);
            this.sourceListBox.Name = "sourceListBox";
            this.sourceListBox.Size = new System.Drawing.Size(177, 290);
            this.sourceListBox.TabIndex = 0;
            this.sourceListBox.ValueMember = "ID";
            // 
            // transferButton
            // 
            this.transferButton.Location = new System.Drawing.Point(201, 122);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(147, 23);
            this.transferButton.TabIndex = 1;
            this.transferButton.Text = ">>";
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // destListBox
            // 
            this.destListBox.DisplayMember = "Name";
            this.destListBox.FormattingEnabled = true;
            this.destListBox.Location = new System.Drawing.Point(359, 17);
            this.destListBox.Name = "destListBox";
            this.destListBox.Size = new System.Drawing.Size(177, 290);
            this.destListBox.TabIndex = 2;
            this.destListBox.ValueMember = "ID";
            // 
            // notifyListener
            // 
            this.notifyListener.HeaderLen = 10;
            this.notifyListener.LocalPort = 128;
            this.notifyListener.ParentForm = this;
            this.notifyListener.Protocol = Control.Notify.ProtocolType.Tcp;
            this.notifyListener.RemoteIPs = new System.Net.IPAddress[] {
        ((System.Net.IPAddress)(resources.GetObject("notifyListener.RemoteIPs")))};
            this.notifyListener.RemotePort = 80;
            this.notifyListener.RunEventsOnCurrentThread = true;
            this.notifyListener.Version = ((System.Version)(resources.GetObject("notifyListener.Version")));
            this.notifyListener.ConnectionRequest += new System.EventHandler<Control.Notify.NotifyRequestEventArgs>(this.notifyListener_ConnectionRequest);
            this.notifyListener.DataArrival += new System.EventHandler<Control.Notify.NotifyDataArrivalEventArgs>(this.notifyListener_DataArrival);
            // 
            // notifySender
            // 
            this.notifySender.HeaderLen = 10;
            this.notifySender.LocalPort = 80;
            this.notifySender.ParentForm = null;
            this.notifySender.Protocol = Control.Notify.ProtocolType.Tcp;
            this.notifySender.RemoteIPs = new System.Net.IPAddress[] {
        ((System.Net.IPAddress)(resources.GetObject("notifySender.RemoteIPs")))};
            this.notifySender.RemotePort = 128;
            this.notifySender.RunEventsOnCurrentThread = false;
            this.notifySender.Version = ((System.Version)(resources.GetObject("notifySender.Version")));
            // 
            // NotifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 326);
            this.Controls.Add(this.destListBox);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.sourceListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NotifyForm";
            this.Text = "Notifiy Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotifyForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Control.Notify.NotifyProvider notifyListener;
        private Control.Notify.NotifyProvider notifySender;
        private System.Windows.Forms.ListBox destListBox;
        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.ListBox sourceListBox;
        
        
    }
}

