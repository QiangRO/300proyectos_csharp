using System;
using Microsoft.Win32;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace DevelopedTextBox
{
    public enum Change { Add, Delete };
    public delegate void AddDeleteKeyEventHandLer(object sender, AddDeleteKeyEventArgs e);
    public class DevelopedBox : TextBox
    {
        /// <summary>
        /// Methods Defenition Begin
        /// </summary>
        #region
        public DevelopedBox()
        {
            this.time.Interval = 1000;
            previouse = "";
            now = this.Text;
        }
        private Change recognize(string sn, string sp, out char ch)
        {
            if (sn.Length > sp.Length)
            {
                ch = sn[sn.Length - 1];
                return Change.Add;
            }
            else
            {
                ch = sp[sp.Length - 1];
                return Change.Delete;
            }
        }
        private void findString()
        {

            if (strFind == "" || this.Text == "" || counter == 1)
                return;
            string str = this.Text.ToUpper();
            bool b = false;
            strFind = strFind.ToUpper();
            if ((str.IndexOf(strFind)) != -1)
                b = true;
            if (b && StringFinded != null)
            {
                counter = 1;
                StringFinded(this, new EventArgs());
            }
        }
        private void numericEntered()
        {
            char ch = '\0';
            string str = recognize(now, previouse, out ch).ToString();
            bool b = (ch >= 48 && ch <= 57);
            if (str == "Add" && b && NumericEntered != null)
                NumericEntered(this, new EventArgs());
        }
        private void alphabetEntered()
        {
            char ch;
            ch = '\0';
            string str = recognize(now, previouse, out ch).ToString();
            bool b = ((ch >= 65 && ch <= 90) || (ch >= 97 && ch <= 122));
            if (str == "Add" && b && AlphabetEntered != null)
                AlphabetEntered(this, new EventArgs());
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            previouse = now;
            now = this.Text;
            if (!status) return;
            findString();
            alphabetEntered();
            numericEntered();
            char changed;
            changed = '\0';
            string s = recognize(now, previouse, out changed).ToString();
            if (s == "Add" && CharacterAdded != null)
            {
                AddDeleteKeyEventArgs ad = new AddDeleteKeyEventArgs(changed);
                CharacterAdded(this, ad);
            }
            else
                if (s == "Delete" && CharacterDeleted != null)
                {
                    AddDeleteKeyEventArgs ad = new AddDeleteKeyEventArgs(changed);
                    CharacterDeleted(this, ad);
                }
        }
        void time_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.Text = dt.ToLongTimeString();
        }

        #endregion
        /// <summary>
        /// Methods Defenition End
        /// </summary>

        /// <summary>
        /// Properties And Indexer Defenition Begin
        /// </summary>
        #region
        [Description("Return A Character That Specified With Index.")]
        public virtual char this[int index]
        {
            get
            {
                if (index > this.Text.Length || index < 1)
                    throw new ArgumentOutOfRangeException("Bad Index");
                return this.Text[index - 1];
            }
        }
        public virtual int this[string str]
        {
            get
            {
                string s = this.Text.ToUpper();
                str = str.ToUpper();
                int i = s.IndexOf(str);
                return i;

            }
        }
        [Description("Find This String.When Finded StringFinded Event Rais.")]
        public string FindString
        {
            get 
            { 
                return strFind; 
            }
            set 
            { 
                strFind = value; 
            }
        }
        [Description("StringFinded Event Rais When This Property be 0.")]
        public byte RepeatFind
        {
            get 
            { 
                return counter; 
            }
            set 
            { 
                counter = value; 
            }
        }
        [Description("If True This Instance Using As A Timer")]
        public bool UseAsTimer
        {
            get 
            { 
                return useAsTimer; 
            }
            set
            {
                if (value)
                    if (!timerIsEnabled)
                    {
                        time.Start();
                        time.Tick += new EventHandler(time_Tick);
                        this.Enabled = false;
                        timerIsEnabled = true;
                        useAsTimer = value;
                        status = false;
                        return;
                    }
                if (value == false)
                    if (timerIsEnabled)
                    {

                        time.Stop();
                        time.Tick -= new EventHandler(time_Tick);
                        this.Text = "";
                        this.previouse = "";
                        this.counter = 0;
                        this.now = "";
                        this.Enabled = true;
                        timerIsEnabled = false;
                        useAsTimer = value;
                        status = true;
                        return;
                    }
            }
        }
        /// <summary>
        /// Properties And Indexer Defenition End
        /// </summary
        #endregion

        /// <summary>
        /// Event Defenition Begin
        /// </summary>
        #region

        [Description("Event Raised When A Character of Text Add")]
        public event AddDeleteKeyEventHandLer CharacterAdded;
        [Description("Event Raised When A Character Of Text Delete")]
        public event AddDeleteKeyEventHandLer CharacterDeleted;
        [Description("Occurs When Valu Of The FindString Property Was Finded")]
        public event EventHandler StringFinded;
        [Description("Occurs When Numeric Characters Entered")]
        public event EventHandler NumericEntered;
        [Description("Occurs When Alphabet Characters Entered")]
        public event EventHandler AlphabetEntered;
        #endregion

        /// <summary>
        /// Event Defenition End
        /// </summary>
        
        /*
         * Fields
         */
        #region
        private string strFind = "";
        private Timer time = new Timer();
        private bool useAsTimer = false;
        bool status = true;
        private bool timerIsEnabled = false;
        private byte counter = 0;
        string previouse = "", now = "";
        #endregion
    }
    public  class AddDeleteKeyEventArgs : EventArgs
    {
        public char Change
        { 
            get 
            { 
                return change; 
            }
        }
        public AddDeleteKeyEventArgs(char ch)
        {
            change = ch;
        }
        char change;
    }
}
