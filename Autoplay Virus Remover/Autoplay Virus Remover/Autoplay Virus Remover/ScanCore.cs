using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;

namespace Autoplay_Virus_Remover
{
    public enum ScanType
    {
        QuickScan = 1,
        DeepScan = 2
    }

    public class ScanCore
    {
        #region Variables
        public static int infected, deleted;
        private object[] row = new object[2];
        private int MaxVirus = 200;
        private static string[] Viruses;
        public static DataTable SearchTable = new DataTable();
        private static string _searchmessage = "";
        FileStream input = null;
        FileStream output = null;
        BinaryReader binaryinput;
        BinaryWriter binaryoutput;
        #endregion

        #region Properties
        public string SearchMessage
        {
            set
            {
                _searchmessage = value;
            }
            get
            {
                return _searchmessage;
            }
        }

        public bool IsVirusFounded
        {
            get
            {
                if (infected == 0) return false;
                return true;
            }
        }
        #endregion

        #region Methods
        public ScanCore()
        {
            InitializeTable();
        }

        private void CreateVirusDatabase()
        {
            Viruses = new string[MaxVirus];
            try
            {
                if (File.Exists("VirusDefinition.mmm"))
                {
                    input = new FileStream("VirusDefinition.mmm", FileMode.Open, FileAccess.Read);
                    binaryinput = new BinaryReader(input);
                    input.Seek(0, 0);
                    int i = 0;
                    while (true)
                    {
                        try
                        {
                            Viruses.Initialize();
                            Viruses[i] = binaryinput.ReadString();
                            i++;
                        }
                        catch (EndOfStreamException) { break; }
                    }
                    if (input != null) input.Close();
                }
            }
            catch { }
        }

        private void InitializeTable()
        {
            SearchTable.Columns.Add("Directory");
            SearchTable.Columns.Add("Action");
        }

        public void Scan(DriveInfo[] Drives,ScanType Type)
        {
            try
            {
                infected = deleted = 0;               
                SearchMessage = "Search Drives :\n";
                SearchTable.Rows.Clear();
                CreateVirusDatabase();
                string patch, patch1, patch2, patch3;
                foreach (DriveInfo drive in Drives)
                {
                    if (drive == null) continue;
                    if (drive.IsReady == false) continue;
                    SearchMessage += drive.Name.Substring(0, 1) + ",";
                    patch = drive.ToString() + "autorun.inf";
                    if (File.Exists(patch))
                    {
                        infected++;
                        row[0] = patch;
                        row[1] = "Leave Alone";
                        SearchTable.Rows.Add(row);

                    }
                    if (Type == ScanType.DeepScan) DeepSearch(drive.Name.Substring(0,2));
                    else
                    {
                        foreach (string virus in Viruses)
                        {
                            if (virus == null || virus == "") continue;
                            patch1 = drive.ToString() + "RECYCLER\\" + virus;
                            patch2 = drive.ToString() + "System Volume Information\\" + virus;
                            patch3 = drive.ToString() + virus;
                            if (File.Exists(patch1))
                            {
                                infected++;
                                row[0] = patch1;
                                row[1] = "Leave Alone";
                                SearchTable.Rows.Add(row);
                            }
                            if (File.Exists(patch2))
                            {
                                infected++;
                                row[0] = patch2;
                                row[1] = "Leave Alone";
                                SearchTable.Rows.Add(row);
                            }
                            if (File.Exists(patch3))
                            {
                                infected++;
                                row[0] = patch3;
                                row[1] = "Leave Alone";
                                SearchTable.Rows.Add(row);
                            }
                        }
                        if (Directory.Exists(drive.ToString() + "RECYCLER")) DeepSearch(drive.ToString() + "RECYCLER");
                        try
                        {
                            if (Directory.Exists(drive.ToString() + "System Volume Information")) DeepSearch(drive.ToString() + "System Volume Information");
                        }
                        catch { }
                    }
                }
                if (SearchMessage != "Search Drives :\n")
                {
                    SearchMessage = SearchMessage.Substring(0, SearchMessage.Length - 1);                                        
                }
                if (infected == 0) SearchMessage += "\nNo Virus Found.";
                else SearchMessage += "\nSome Viruses Found.";
                
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message,"Scan Core", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void DeepSearch(string patch)
        {
            try
            {
                string patch1 = "";
                System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(patch);
                System.IO.DirectoryInfo[] recdir = directory.GetDirectories();
                foreach (System.IO.DirectoryInfo dir in recdir)
                {
                    foreach (string virus in Viruses)
                    {
                        if (virus == null || virus == "") continue;
                        patch1 = patch + "\\" + dir.Name + "\\" + virus;
                        try
                        {
                            if (File.Exists(patch1))
                            {
                                infected++;
                                row[0] = patch1;
                                row[1] = "Leave Alone";
                                SearchTable.Rows.Add(row);
                            }
                        }
                        catch { }
                    }
                    DeepSearch(patch + "\\" + dir.Name);
                }
            }
            catch { }
        }
        #endregion

    }
}
