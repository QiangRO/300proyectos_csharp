using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Staging;

namespace Autoplay_Virus_Remover
{
    public partial class frmmain : Form
    {
        #region Variables
        ScanCore objScan = new ScanCore();
        DeviceVolumeMonitor fNative;
        #endregion

        #region Form Events
        public frmmain()
        {
            InitializeComponent();
            fNative = new DeviceVolumeMonitor(this.Handle);
            fNative.OnVolumeInserted += new DeviceVolumeAction(VolumeInserted);
            fNative.OnVolumeRemoved += new DeviceVolumeAction(VolumeRemoved);
         }

        private void Form1_Load(object sender, EventArgs e)
        {            
            UpdateTreeNode();
        }

        private void frmmain_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmmain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) this.Hide();
        }
        #endregion

        #region Button Events
        private void btnstart_Click(object sender, EventArgs e)
        {
            try
            {
                DriveInfo[] drives = new DriveInfo[20];
                int i = 0;
                foreach (TreeNode node in treeView1.Nodes[0].Nodes)
                {
                    if (node.Checked)
                    {
                        DriveInfo drv = new DriveInfo(node.Tag.ToString());                        
                            drives[i] = drv;
                            i++;                        
                    }
                }
                if (i == 0)
                {
                    MessageBox.Show("You Must Select One Drive At Least.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if(optquickscan.Checked) objScan.Scan(drives,ScanType.QuickScan);
                else objScan.Scan(drives, ScanType.DeepScan); 
                notifyIcon1.BalloonTipText = objScan.SearchMessage;
                notifyIcon1.BalloonTipTitle = "My Simple Antivirus - Scan Complete";
                if (objScan.IsVirusFounded)
                {
                    System.Media.SystemSounds.Hand.Play();               
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                    notifyIcon1.ShowBalloonTip(5000);
                }
                else
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.ShowBalloonTip(1000);
                }
                foreach (TreeNode node in treeView1.Nodes[0].Nodes) node.Checked = false;
                this.Hide();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            UpdateTreeNode();
        }
        #endregion

        #region TreeView Events
        private void UpdateTreeNode()
        {
            try
            {
                treeView1.Nodes[0].Nodes.Clear();
                string type = "", letter = "";
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    TreeNode node = new TreeNode();
                    switch (drive.DriveType)
                    {
                        case DriveType.CDRom:
                            node.ImageIndex = node.SelectedImageIndex = node.StateImageIndex = 3;
                            if (drive.IsReady) type = drive.VolumeLabel;
                            else type = "CD/DVD";
                            break;
                        case DriveType.Fixed:
                            node.ImageIndex = node.SelectedImageIndex = node.StateImageIndex = 2;
                            if (drive.IsReady) type = drive.VolumeLabel;
                            else type = "LocalDisk";
                            break;
                        case DriveType.Removable:
                            if (drive.Name == "A:\\")
                            {
                                node.ImageIndex = node.SelectedImageIndex = node.StateImageIndex = 1;
                                type = "3½ Floppy";
                            }
                            else
                            {
                                node.ImageIndex = node.SelectedImageIndex = node.StateImageIndex = 4;
                                if (drive.IsReady) type = drive.VolumeLabel;
                                else type = "Removable";
                            }
                            break;
                    }
                    letter = drive.Name.Remove(drive.Name.Length - 1);
                    node.Text = type + "(" + letter + ")";
                    node.Tag = drive.Name;
                    treeView1.Nodes[0].Nodes.Add(node);
                }
                treeView1.Nodes[0].Expand();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (e.Node == treeView1.Nodes[0])
                {

                    for (int i = 0; i < treeView1.Nodes[0].Nodes.Count; i++)
                    {
                        treeView1.Nodes[0].Nodes[i].Checked = treeView1.Nodes[0].Checked;
                    }
                }
                else
                {
                    int n = 0;
                    for (int j = 0; j < treeView1.Nodes[0].Nodes.Count; j++)
                    {
                        if (treeView1.Nodes[0].Nodes[j].Checked) n++;
                    }
                    if (n == treeView1.Nodes[0].Nodes.Count) treeView1.Nodes[0].Checked = true;
                    else if (n == 0) treeView1.Nodes[0].Checked = false;
                    else treeView1.Nodes[0].Checked = true; ;
                }
                if (e.Node.Checked) treeView1.Nodes[0].Checked = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region NotifyIcon Events
        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            if (objScan.IsVirusFounded)
            {
                FrmScan objform = new FrmScan(ScanCore.infected, ScanCore.deleted);
                objform.ShowDialog();
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) notifyIcon1.ContextMenuStrip.Show();
        }
        #endregion

        #region ContextMenuStrip Events
        private void cmnuopen_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }
        
        private void cmnuexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmnuautoprotect_Click(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Icon icon1, icon2;
                if (File.Exists("My Simple Antivirus.ico")) icon1 = new Icon("My Simple Antivirus.ico", 64, 64);
                else icon1 = notifyIcon1.Icon;
                if (File.Exists("My Simple Antivirus2.ico")) icon2 = new Icon("My Simple Antivirus2.ico", 64, 64);
                else icon2 = icon1;
                cmnuautoprotect.Checked = !cmnuautoprotect.Checked;
                if (cmnuautoprotect.Checked) notifyIcon1.Icon = icon1;
                else notifyIcon1.Icon = notifyIcon1.Icon = icon2;                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmnupreviousresults_Click(object sender, EventArgs e)
        {
            FrmScan objform = new FrmScan(ScanCore.infected, ScanCore.deleted);
            objform.ShowDialog();
        }

        private void cmnuvirusManager_Click(object sender, EventArgs e)
        {
            FrmVirusManager objform = new FrmVirusManager();
            objform.ShowDialog();
        }

        private void cmnuabout_Click(object sender, EventArgs e)
        {
            FrmAbout objform = new FrmAbout();
            objform.ShowDialog();
        }
        #endregion

        private void VolumeInserted(int aMask)
        {
            // -------------------------
            // A volume was inserted
            // -------------------------
            UpdateTreeNode();
            if (cmnuautoprotect.Checked)
            {
                DriveInfo[] drive = new DriveInfo[1];
                drive[0] = new DriveInfo(fNative.MaskToLogicalPaths(aMask));
                if (drive[0].IsReady == false) return;
                objScan.Scan(drive,ScanType.QuickScan);
                notifyIcon1.BalloonTipText = objScan.SearchMessage;
                notifyIcon1.BalloonTipTitle = "My Simple Antivirus - Scan Complete";
                if (objScan.IsVirusFounded)
                {
                    System.Media.SystemSounds.Hand.Play();
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                    notifyIcon1.ShowBalloonTip(5000);
                }
                else
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.ShowBalloonTip(1000);
                }
            }
        }

        private void VolumeRemoved(int aMask)
        {
            // --------------------
            // A volume was removed
            // --------------------
            UpdateTreeNode();
        }

        

       
       
        
       

       
                           
    }
}