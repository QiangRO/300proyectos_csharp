using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Speech.Synthesis;
using System.Xml.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace DictionaryFromHamze
{
    public partial class DicForm : Form
    {

        #region Reqiered Variables

        IEnumerable SearchResult1;
        IEnumerable SearchResult2;

        string[] DictionariesPath = {Application.StartupPath+@"\Dictionaries\A-N Words.xml",
                               Application.StartupPath + @"\Dictionaries\O-Z Words.xml" };
        string[] WordAndMeaninig;
        string PrevStart;

        const int NumberOfSuggestion = 10;
        int CultInfo;

        Boolean ApplicationStarted = false;

        IntPtr _ClipboardViewerNext;

        SpeechSynthesizer Speaker;

        Thread Say;

        #endregion

        public DicForm()
        {
            InitializeComponent();
            _ClipboardViewerNext = Win32.User32.SetClipboardViewer(this.Handle);
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(inputTextB, "کلمه مورد نظر برای جستجو را اینجا وارد کنید");
            Speaker = new SpeechSynthesizer();
            Speaker.Volume = 100;
            Speaker.Rate = 0;
            CultInfo = 1;
            ChangeControlDirections();
        }

        protected override void WndProc(ref Message m)
        {
            switch ((Win32.Msgs)m.Msg)
            {
                case Win32.Msgs.WM_DRAWCLIPBOARD:
                    IDataObject idata = new DataObject();
                    idata = Clipboard.GetDataObject();
                    if (idata.GetDataPresent(DataFormats.Text))
                        SetFromCilpBoard(idata);
                    Win32.User32.SendMessage(_ClipboardViewerNext, m.Msg, m.WParam, m.LParam);
                    break;
                case Win32.Msgs.WM_CHANGECBCHAIN:
                    if (m.WParam == _ClipboardViewerNext)
                    {
                        _ClipboardViewerNext = m.LParam;
                    }
                    else
                    {
                        Win32.User32.SendMessage(_ClipboardViewerNext, m.Msg, m.WParam, m.LParam);
                    }
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void SetFromCilpBoard(IDataObject idata)
        {
            if (ApplicationStarted)
            {
                notifyIcon1_MouseDoubleClick(null, null);
                String text = ((string)idata.GetData(DataFormats.Text)).ToLower();
                inputTextB.Text = text;
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Say = new Thread(new ThreadStart(SpeakText));
            Say.Start();

        }

        void SpeakText()
        {
            try
            {
                Speaker.Volume = 100;
                Speaker.Rate = 0;
                Speaker.Speak(inputTextB.Text);
            }
            catch { }
        }

        private void DicForm_MouseDown(object sender, MouseEventArgs e)
        {
            Win32.User32.ReleaseCapture();
            Win32.User32.SendMessage(this.Handle.ToInt32(), Win32.User32.WM_NCLBUTTONDOWN, 2, 0);
        }

        private void inputTextB_TextChanged(object sender, EventArgs e)
        {
            String mustFind = inputTextB.Text;
            try
            {
                ChangeControlDirections();
                if (mustFind != "")
                    FindWord(mustFind.Trim());
            }
            catch { }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                FindExact(inputTextB.Text.Trim());
            }
            catch { }
        }

        private void inputTextB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                inputTextB.Text.Trim();
                toolStripButton3_Click(null, null);
            }
        }

        private void FindWord(String mustFind)
        {
            String Start = mustFind.Substring(0, 1);
            XDocument xmlDoc1;
            XDocument xmlDoc2;
            if (CultInfo == 1)
            {

                if (!Start.Equals(PrevStart))
                    goto queryNotSet;
                else 
                    goto querySet;

            queryNotSet:

                PrevStart = Start;

                if (Start[0] >= 'a' && Start[0] <= 'n')
                    xmlDoc1 = XDocument.Load(DictionariesPath[0]);
                else
                    xmlDoc1 = XDocument.Load(DictionariesPath[1]);

                SearchResult1 = from xElem in xmlDoc1.Descendants("DicEnt")
                                where xElem.Element("W_M").Value.StartsWith(mustFind)
                                select new Words
                                {
                                    Eng_Per = xElem.Element("W_M").Value
                                };

                dataGridView1.Rows.Clear();
                SetResult(mustFind, 1);

            querySet:

                dataGridView1.Rows.Clear();
                SetResult(mustFind, 1);

            }
            else if (CultInfo == 2)
            {

                if (mustFind.Length >= 2)
                {

                    dataGridView1.Rows.Clear();

                    if (!Start.Equals(PrevStart))
                        goto queryNotSet;
                    else 
                        goto querySet;

                queryNotSet:

                    PrevStart = Start;
                    xmlDoc1 = XDocument.Load(DictionariesPath[0]);

                    SearchResult1 = from xElem in xmlDoc1.Descendants("DicEnt")
                                    where xElem.Element("W_M").Value.Contains(mustFind)
                                    select new Words
                                    {
                                        Eng_Per = xElem.Element("W_M").Value
                                    };

                    xmlDoc2 = XDocument.Load(DictionariesPath[1]);

                    SearchResult2 = from xElem in xmlDoc2.Descendants("DicEnt")
                                    where xElem.Element("W_M").Value.Contains(mustFind)
                                    select new Words
                                    {
                                        Eng_Per = xElem.Element("W_M").Value
                                    };

                    SetResult(mustFind, 1);

                querySet:

                    SetResult(mustFind, 1);
                }
            }
        }

        private void FindExact(String mustFind)
        {
            originalWordTxt.Text = mustFind;
            try
            {
                IEnumerable Results;
                String[] PersianSplit = new String[100];
                meanTxtBox.Text = "";
                ArrayList Meaning = new ArrayList();
                if (CultInfo == 1)
                {
                    foreach (Words wrd in SearchResult1)
                        if (wrd.Eng_Per.StartsWith(mustFind))
                        {
                            WordAndMeaninig = wrd.Eng_Per.Split(Data.RequierdVariables.Separator2, StringSplitOptions.None);
                            if (WordAndMeaninig[0].Trim().Equals(mustFind.Trim()))
                            {
                                Meaning.Add(WordAndMeaninig[1].Trim());
                                break;
                            }
                        }
                }
                else if (CultInfo == 2)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Results = i == 0 ? SearchResult1 : SearchResult2;
                        foreach (Words wrd in Results)
                            if (wrd.Eng_Per.Contains(mustFind))
                            {
                                WordAndMeaninig = wrd.Eng_Per.Split(Data.RequierdVariables.Separator2, StringSplitOptions.None);
                                PersianSplit = WordAndMeaninig.Length == 3 ? SplitToPer(WordAndMeaninig[2]) : SplitToPer(WordAndMeaninig[1]);
                                foreach (String str in PersianSplit)
                                    if (str != null && str.Equals(mustFind))
                                        Meaning.Add(WordAndMeaninig[0].Trim());
                            }
                    }
                }
                meanTxtBox.Text = SetWordToDicType(Meaning);
            }
            catch { }
            meanTxtBox.Text = meanTxtBox.Text.Trim();
            if (meanTxtBox.Text.Trim().Length == 0)
            {
                meanTxtBox.RightToLeft = RightToLeft.Yes;
                meanTxtBox.Text = Data.RequierdVariables.errFindTxt;
            }
        }

        public void ChangeControlDirections()
        {
            if (InputLanguage.CurrentInputLanguage.Culture.ToString().Equals("en-US"))
            {
                inputTextB.RightToLeft = originalWordTxt.RightToLeft = RightToLeft.No;
                meanTxtBox.RightToLeft = RightToLeft.Yes;
                if (CultInfo == 2)
                {
                    CultInfo = 1;
                    meanTxtBox.Text = originalWordTxt.Text = "";
                }
            }
            else if (InputLanguage.CurrentInputLanguage.Culture.ToString().Equals("fa-IR"))
            {
                inputTextB.RightToLeft = originalWordTxt.RightToLeft = RightToLeft.Yes;
                meanTxtBox.RightToLeft = RightToLeft.No;
                if (CultInfo == 1)
                {
                    CultInfo = 2;
                    meanTxtBox.Text = originalWordTxt.Text = "";
                }
            }

        }

        //set result mehtod
        public void SetResult(String mustFind, int type)
        {
            int counter = 0;
            ArrayList Meaning = new ArrayList();
            String[] PersianSplit;
            IEnumerable Results;
            if (CultInfo == 1)
            {
                if (type == 1)
                {
                    foreach (Words wrd in SearchResult1)
                        if (wrd.Eng_Per.StartsWith(mustFind))
                        {
                            WordAndMeaninig = wrd.Eng_Per.Split(Data.RequierdVariables.Separator2, StringSplitOptions.None);
                            counter++;
                            AddToListView(WordAndMeaninig);
                            Application.DoEvents();
                            if (counter == NumberOfSuggestion)
                                return;
                        }
                }
                else if (type == 2)
                {
                    foreach (Words wrd in SearchResult1)
                        if (wrd.Eng_Per.StartsWith(mustFind))
                        {
                            WordAndMeaninig = wrd.Eng_Per.Split(Data.RequierdVariables.Separator2, StringSplitOptions.None);
                            if (WordAndMeaninig[0].Trim().Equals(mustFind.Trim()))
                            {
                                Meaning.Add(WordAndMeaninig[1].Trim());
                                break;
                            }
                        }
                    if (Meaning.Count != 0)
                        meanTxtBox.Text = SetWordToDicType(Meaning);
                    else
                        meanTxtBox.Text = Data.RequierdVariables.errFindTxt;
                }
            }
            else if (CultInfo == 2)
            {
                if (type == 1)
                {
                    ArrayList EnglishIndg = new ArrayList();
                    for (int i = 0; i < 2; i++)
                    {
                        Results = i == 0 ? SearchResult1 : SearchResult2;
                        counter = 0;
                        foreach (Words wrd in Results)
                            if (wrd.Eng_Per.Contains(mustFind))
                            {
                                WordAndMeaninig = wrd.Eng_Per.Split(Data.RequierdVariables.Separator2, StringSplitOptions.None);
                                PersianSplit = WordAndMeaninig.Length == 3 ? SplitToPer(WordAndMeaninig[2]) : SplitToPer(WordAndMeaninig[1]);
                                foreach (String str in PersianSplit)
                                    if (str.Contains(mustFind))
                                    {
                                        if (!EnglishIndg.Contains(WordAndMeaninig[0]))
                                        {
                                            EnglishIndg.Add(WordAndMeaninig[0]);
                                            counter++;
                                            String[] temp = { str, WordAndMeaninig[0] };
                                            dataGridView1.Rows.Add(temp);
                                            break;
                                        }
                                    }
                                Application.DoEvents();
                                if (counter == 10)
                                    break;
                            }
                    }
                }
                else if (type == 2)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Results = i == 0 ? SearchResult1 : SearchResult2;
                        foreach (Words wrd in Results)
                            if (wrd.Eng_Per.Contains(mustFind))
                            {
                                WordAndMeaninig = wrd.Eng_Per.Split(Data.RequierdVariables.Separator2, StringSplitOptions.None);
                                PersianSplit = WordAndMeaninig.Length == 3 ? SplitToPer(WordAndMeaninig[2]) : SplitToPer(WordAndMeaninig[1]);
                                foreach (String str in PersianSplit)
                                    if (str.Equals(mustFind))
                                    {
                                        Meaning.Add(WordAndMeaninig[0]);
                                        meanTxtBox.Text = SetWordToDicType(Meaning);
                                        return;
                                    }
                            }
                    }
                    if (Meaning.Count != 0)
                        meanTxtBox.Text = Data.RequierdVariables.errFindTxt;
                }
            }
        }

        //set word to dic type method
        public String SetWordToDicType(ArrayList Source)
        {
            String Meaning = "";
            if (CultInfo == 1)
            {
                String NewSource = Source[0].ToString();
                String temp;
                int IndexOfStart = NewSource.IndexOf('[');
                int IndexOfEnd = NewSource.IndexOf(']');
                while (IndexOfStart >= 0)
                {
                    Meaning += "واژه نامه  " + NewSource.Substring(IndexOfStart + 1, IndexOfEnd - IndexOfStart - 1).Trim() +
                        Environment.NewLine + "-------------------" + Environment.NewLine
                        + SplitTo(NewSource.Substring(0, IndexOfStart)) + Environment.NewLine;
                    if (IndexOfEnd + 1 != NewSource.Length)
                    {
                        temp = NewSource.Substring(IndexOfEnd + 1, NewSource.Length - IndexOfEnd - 1);
                        NewSource = temp.Trim();
                        IndexOfStart = NewSource.IndexOf('[');
                        IndexOfEnd = NewSource.IndexOf(']');
                    }
                    else
                        break;
                }
                if (IndexOfStart < 0)
                    Meaning += "واژه نامه عمومی  " + Environment.NewLine + "-------------------"
                        + Environment.NewLine + SplitTo(NewSource) + Environment.NewLine;
            }
            else
            {
                foreach (String strMean in Source)
                    Meaning += strMean + Environment.NewLine;
            }
            return Meaning;
        }

        //set to persian methods
        public String SplitTo(String Spliter)
        {
            String retStr = String.Empty;
            String[] array = Spliter.Split(Data.RequierdVariables.Separator3, StringSplitOptions.None);
            foreach (String str in array)
                retStr += str.Trim() + Environment.NewLine;
            return retStr;
        }
        public String[] SplitToPer(String Spliter)
        {
            String[] retStr = new String[100];
            int counter = 0;
            String[] array = Spliter.Split(Data.RequierdVariables.Separator3, StringSplitOptions.None);
            foreach (String str in array)
                retStr[counter++] = str.Trim();
            return retStr;
        }
        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            Win32.User32.ReleaseCapture();
            Win32.User32.SendMessage(this.Handle.ToInt32(), Win32.User32.WM_NCLBUTTONDOWN, 2, 0);
        }
        private void AddToListView(String[] addToList)
        {
            String[] words = { (SplitToPer(addToList.Length == 3 ? addToList[2] : addToList[1]))[0], 
                                addToList[0] };
            dataGridView1.Rows.Add(words);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                dataGridView1_CurrentCellChanged(null, null);
            }
            catch
            {
            }
        }
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                String Word;
                switch (CultInfo)
                {
                    case 1:
                        Word = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                        FindExact(Word);
                        break;
                    case 2:
                        Word = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                        FindExact(Word);
                        break;
                }
            }
            catch
            {
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            DisposeAll();
            this.Visible = false;
            notifyIcon1.Visible = true;
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void نمایشلغتنامهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Visible = true;
        }

        private void DicForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
            this.inputTextB.Focus();
            ApplicationStarted = true;
        }

        private void inputTextB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                dataGridView1.Focus();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Visible = true;
        }

        private void DicForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                this.inputTextB.Text = "";
                inputTextB.Focus();
            }
        }

        private void toolStrip1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                this.inputTextB.Text = "";
                inputTextB.Focus();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Visible = true;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                notifyIcon1_DoubleClick(null, null);
            }
            
        }
        private void DisposeAll()
        {

            SearchResult1 = SearchResult2 = null;
            PrevStart = "";
            dataGridView1.Rows.Clear();
            inputTextB.Text = meanTxtBox.Text = originalWordTxt.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String mustFind = inputTextB.Text;
            try
            {
                ChangeControlDirections();
                if (mustFind != "")
                    FindWord(mustFind.Trim());
            }
            catch { }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                dataGridView1.Focus();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                toolStripButton3_Click(null, null);
        }

        private void toolStrip2_MouseDown(object sender, MouseEventArgs e)
        {
            toolStrip1_MouseDown(sender, e);
        }
        private void DicForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Win32.User32.ChangeClipboardChain(this.Handle, _ClipboardViewerNext);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            AboutMe About = new AboutMe();
            About.ShowDialog();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            SettingForm st = new SettingForm();
            if (st.ShowDialog() == DialogResult.OK)
            {
                LoadSettings();
            }
        }
        private void LoadSettings()
        {
            //set BackGround Color
            switch ((string)Properties.Settings.Default.BackImage)
            {
                case "Green":
                    this.BackgroundImage = global::DictionaryFromHamze.Properties.Resources.greenBG;
                    break;
                case "Red":
                    this.BackgroundImage = global::DictionaryFromHamze.Properties.Resources.redBG;
                    break;
                case "Blue":
                    this.BackgroundImage = global::DictionaryFromHamze.Properties.Resources.blueBG;
                    break;
            }
        }

    }
    /// <summary>
    /// class for search in xml files
    /// </summary>
    public class Words
    {
        public String Eng_Per { set; get; }
    }
}