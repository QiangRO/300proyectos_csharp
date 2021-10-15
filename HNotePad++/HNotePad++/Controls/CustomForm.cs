using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace HNotePad__.Controls
{
    public partial class CustomForm : Form
    {
        #region Variables

        private CustomizedTextBox _currentTextBox;

        private ArrayList _positioOfTextBoxes;

        private bool _boolIsDocumentHaveAnswer;
        private bool _replaceForOne;
        private bool _matchCase;

        private string _replacementText;
        private string _lastSearchedWord;


        private int _lastIndexShowed;
        private int _directoinOfSearch;
        private int _numOfOneReplace;

        public bool IsDocumentHaveAnswer
        {
            get
            {
                return this._boolIsDocumentHaveAnswer;
            }
            set
            {
                this._boolIsDocumentHaveAnswer = value;
            }
        }

        #endregion

        #region Constructor And Initilizers

        public CustomizedTextBox CurrentTextBox
        {
            set
            {
                this._currentTextBox = value;
            }
            get
            {
                return this._currentTextBox;
            }
        }

        public CustomForm(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public CustomForm()
        {
            InitializeComponent();
            _lastSearchedWord = string.Empty;
        }

        #endregion

        #region Find And Replace And Selection Methods

        /// <summary>
        /// get the input text from find form and set built in
        /// variables to show how to searched and select text
        /// such as direction and find text with match case.
        /// </summary>
        /// direction 1 \" Up
        /// direction 2 \" Down
        public void GetFindInfo(string FindWhat, bool MatchCase, int DirectionOfSearch)
        {
            this._replaceForOne = false;
            this._matchCase = MatchCase;

            if (FindWhat != this._lastSearchedWord)
            {

                this._lastSearchedWord = FindWhat;
                SearchForFinAndReplace();

                if (this.IsDocumentHaveAnswer)
                {

                    this._directoinOfSearch = DirectionOfSearch;
                    this._lastIndexShowed = 0;

                    this.SelectThis((int)this._positioOfTextBoxes[0], FindWhat.Length);

                }
                else
                {
                    MessageBox.Show("گشتم نبود نگرد نیست");
                }
            }
            else
            {
                this._directoinOfSearch = DirectionOfSearch;
                this.showNextSelection();
            }
        }

        /// <summary>
        /// get the input text and replace ment from replace form
        /// </summary>
        public void GetReplaceInfo(bool MatchCase, string SearchedWord, string ReplaceWord)
        {
            this._numOfOneReplace = 0;
            this._matchCase = MatchCase;
            if (SearchedWord != this._lastSearchedWord)
            {
                this._replacementText = ReplaceWord;
                this._lastSearchedWord = SearchedWord;
                SearchForFinAndReplace();
                if (this.IsDocumentHaveAnswer)
                {

                    this._directoinOfSearch = 2;
                    this._lastIndexShowed = 0;

                    SelectThis((int)this._positioOfTextBoxes[0], SearchedWord.Length);
                }
                else
                {
                    MessageBox.Show("گشتم نبود نگرد نیست");
                }
            }
            else
            {
                this._directoinOfSearch = 2;
                this.showNextSelection();
            }
        }

        /// <summary>
        /// this method search in all of text of a class and then
        /// compute an array that contains index of searched word
        /// in the whole document
        /// </summary>
        private void SearchForFinAndReplace()
        {
            int counterOfEntries = 0;
            this._boolIsDocumentHaveAnswer = false;
            this._positioOfTextBoxes = new ArrayList();

            for (int i = 0; i < this.CurrentTextBox.TextLength - this._lastSearchedWord.Length; i++)
            {
                if (this._matchCase)
                {
                    if (this.CurrentTextBox.Text.Substring(i, this._lastSearchedWord.Length).Equals(this._lastSearchedWord))
                    {
                        this._positioOfTextBoxes.Insert(counterOfEntries++, i);
                        this._boolIsDocumentHaveAnswer = true;
                    }
                }
                else
                {
                    if (this.CurrentTextBox.Text.Substring(i, this._lastSearchedWord.Length).Equals(this._lastSearchedWord.ToLower())
                     || this.CurrentTextBox.Text.Substring(i, this._lastSearchedWord.Length).Equals(this._lastSearchedWord.ToUpper()))
                    {
                        this._positioOfTextBoxes.Insert(counterOfEntries++, i);
                        this._boolIsDocumentHaveAnswer = true;
                    }
                }
            }
        }

        public void ReplaceTextInTextBoxes(bool ReplaceAll)
        {
            if (this._boolIsDocumentHaveAnswer)
            {
                if (ReplaceAll)
                {
                    this._numOfOneReplace = 0;

                    this._replaceForOne = false;
                    string Temp = this._lastSearchedWord;
                    this._lastSearchedWord = "";
                    this.GetReplaceInfo(this._matchCase, Temp, this._replacementText);

                    int NumOfReplacementForAll = 0;

                    for (int i = 0; i < this._positioOfTextBoxes.Count; i++)
                    {
                        this.CurrentTextBox.Focus();

                        this._currentTextBox.SelectionStart = (int)this._positioOfTextBoxes[i] + NumOfReplacementForAll * (this._replacementText.Length - 1);
                        this._currentTextBox.SelectionLength = this._lastSearchedWord.Length;

                        if (this.CurrentTextBox.SelectedText != null && this.CurrentTextBox.SelectedText.Length > 0)
                            this.CurrentTextBox.SelectedText.Remove(0);

                        this._currentTextBox.Paste(this._replacementText);
                        NumOfReplacementForAll++;
                    }
                    MessageBox.Show("تعداد " + NumOfReplacementForAll.ToString() + " جایگزینی انجام شد");
                }
                else
                {
                    this._replaceForOne = true;

                    if (this._currentTextBox.SelectedText.Length > 0 &&
                        this._currentTextBox.SelectedText.Equals(this._lastSearchedWord))
                        ;
                    else
                        showNextSelection();

                    this._currentTextBox.SelectedText = this._replacementText;

                    this._replaceForOne = false;
                    string Temp = this._lastSearchedWord;
                    this._lastSearchedWord = "";
                    this.GetReplaceInfo(this._matchCase, Temp, this._replacementText);

                    this._numOfOneReplace++;
                }
            }
        }

        /// <summary>
        /// sellected the next strin must select in base of input
        /// </summary>
        public void showNextSelection()
        {
            int PositionToShow = this._lastIndexShowed;
            if (this._replaceForOne)
                PositionToShow += this._numOfOneReplace;
            if (this.IsDocumentHaveAnswer)
            {
                if ((this._directoinOfSearch == 1 && PositionToShow == 0) ||
                    (this._directoinOfSearch == 2 && PositionToShow == this._positioOfTextBoxes.Count))
                {
                    MessageBox.Show("هر چی گشتم دیگه واسه \" " + this._lastSearchedWord + " \" چیزی پیدا نمیکنم",
                                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information,
                                    MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                    this.SelectThis((int)this._positioOfTextBoxes[PositionToShow], this._lastSearchedWord.Length);

                }
                else if (this._directoinOfSearch == 1)
                {
                    if (PositionToShow + 1 > 0)
                    {

                        --this._lastIndexShowed;

                        this.SelectThis((int)this._positioOfTextBoxes[PositionToShow], this._lastSearchedWord.Length);

                    }
                    else
                    {
                        MessageBox.Show("هر چی گشتم دیگه واسه \" " + this._lastSearchedWord + " \" چیزی پیدا نمیکنم",
                                                            this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information,
                                                            MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                        this.SelectThis((int)this._positioOfTextBoxes[PositionToShow], this._lastSearchedWord.Length);

                    }
                }
                else if (this._directoinOfSearch == 2)
                {
                    if (PositionToShow + 1 < this._positioOfTextBoxes.Count)
                    {

                        ++this._lastIndexShowed;

                        this.SelectThis((int)this._positioOfTextBoxes[PositionToShow], this._lastSearchedWord.Length);

                    }
                    else
                    {
                        MessageBox.Show("هر چی گشتم دیگه واسه \" " + this._lastSearchedWord + " \" چیزی پیدا نمیکنم",
                                                            this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information,
                                                            MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                        this.SelectThis((int)this._positioOfTextBoxes[PositionToShow], this._lastSearchedWord.Length);

                    }
                }
            }
        }

        private void SelectThis(int SelectionStartIndex, int SelectionLenght)
        {

            this.CurrentTextBox.Focus();
            this.CurrentTextBox.SelectionStart = SelectionStartIndex;
            this.CurrentTextBox.SelectionLength = SelectionLenght;

        }

        #endregion
    }
}