using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HNotePad__
{
    public partial class CustomizedTextBox : TextBox
    {
        
        #region Reqiered Variables

        private bool _isSaved;
        private string _txtTypedPath;
        private bool _inOriginalSaved;

        #endregion

        #region Constructors

        public CustomizedTextBox()
        {
            this.MaxLength = (int)Int32.MaxValue;
            this._isSaved = false;
            this._inOriginalSaved = false;
            this._txtTypedPath = null;
            InitializeComponent();
        }
        public CustomizedTextBox(string filePath)
        {
            this.MaxLength = (int)Int32.MaxValue;
            this._isSaved = true;
            this._inOriginalSaved = true;
            this._txtTypedPath = filePath;
            InitializeComponent();
        }

        #endregion

        #region Data Access Methods

        public bool IsOriginalySaved
        {
            set
            {
                this._inOriginalSaved = value;
            }
            get
            {
                return this._inOriginalSaved;
            }
        }
        public string TextBoxPath
        {
            get
            {
                return this._txtTypedPath;
            }
            set
            {
                this._txtTypedPath = value;
            }
        }

        public bool Saved
        {
            set
            {
                this._isSaved = value;
            }
            get
            {
                return this._isSaved;
            }
        }

        #endregion

        #region Other Methods

        public void ConvertToSaved(string filePath)
        {
            this._inOriginalSaved = this.Saved = true;
            this.TextBoxPath = filePath;
        }

        public CustomizedTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #endregion
    }
}