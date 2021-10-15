namespace FreeControls
{
    #region Using Directives
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    #endregion

    [ToolboxBitmap(typeof(System.Windows.Forms.DateTimePicker))]
    [DefaultProperty("Value")]
    [DefaultEvent("ValueChanged")]
    public partial class PersianDateTimePicker : Control
    {
        #region Delegate & Events
        public delegate void onValueChanged(object sender, PersianMonthCalendarEventArgs e);
        public event onValueChanged ValueChanged;
        #endregion

        #region Fields

        private Pen borderPen = new Pen(Brushes.RoyalBlue, 1.25F);
        private SolidBrush selectedBrush = new SolidBrush(Color.RoyalBlue);
        private StringFormat sf = StringFormat.GenericDefault;

        private RectangleF rectYear, rectMonth, rectDay, rectSep1, rectSep2;
        private RectangleF rectFillYear, rectFillMonth, rectFillDay;
        private Rectangle rectComboButton;

        private PersianDate persianValue;

        private SelectedCommandType selectedCommand = SelectedCommandType.None;

        private Form popup;
        private PersianMonthCalendar persianMonthCalendar;

        private bool keepFocus = false;
        private bool sizeChanging = false;
        private bool isOpen = false;
        #endregion

        #region Ctor
        public PersianDateTimePicker()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.Selectable, true);

            persianMonthCalendar = new PersianMonthCalendar();
            persianMonthCalendar.ValueChanged += new PersianMonthCalendar.onValueChanged(persianMonthCalendar_ValueChanged);
            persianMonthCalendar.PopupClosed += new EventHandler(persianMonthCalendar_PopupClosed);
            popup = new Form
                    {
                        FormBorderStyle = FormBorderStyle.None,
                        Size = persianMonthCalendar.Size,
                        ShowInTaskbar = false,
                        StartPosition = FormStartPosition.Manual
                    };
            popup.Controls.Add(persianMonthCalendar);

            popup.Deactivate += delegate(object sender, EventArgs e)
            {
                isOpen = false;
                popup.Hide();
                this.FindForm().Activate();
            };

            persianValue = new PersianDate();
            sf.Alignment = StringAlignment.Far;
            UpdateRectangle(persianValue);
        }

        ~PersianDateTimePicker()
        {
            popup = null;
            persianMonthCalendar = null;
        }
        #endregion

        #region Props
        [TypeConverter(typeof(PersianDateConverter))]
        [Description("The value of control")]
        [Category("Behavior")]
        [Bindable(true)]
        public PersianDate Value
        {
            get { return persianValue; }
            set
            {
                try
                {
                    //if (value != persianValue)

                    if (!this.DesignMode)
                    {

                        if (value == PersianDate.MinValue)
                        {
                            value = PersianDate.Now;
                        }
                    }
                    PersianDate tmpDate = persianValue;
                    persianValue = value;
                    OnValueChanged(value, tmpDate);

                }
                catch (ArgumentException) { }
            }
        }

        #endregion

        #region Methods

        #region Override Methods
        protected override void OnPaint(PaintEventArgs e)
        {
            //draw Border
            Rectangle rect = this.ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;
            e.Graphics.DrawRectangle(borderPen, rect);

            DrawDate(e.Graphics);
            e.Graphics.DrawString("/", this.Font, Brushes.Black, rectSep1, sf);
            e.Graphics.DrawString("/", this.Font, Brushes.Black, rectSep2, sf);

            DrawComboButton(e.Graphics, ButtonState.Normal);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            this.Focus();
            if (rectFillYear.Contains(e.Location))
            {
                selectedCommand = SelectedCommandType.Year;
                DrawDate(null);
            }
            else if (rectMonth.Contains(e.Location))
            {
                selectedCommand = SelectedCommandType.Month;
                DrawDate(null);
            }
            else if (rectComboButton.Contains(e.Location))
            {
                DrawComboButton(null, ButtonState.Pushed);
                ShowCalendar();
            }
            else
            {
                selectedCommand = SelectedCommandType.Day;
                DrawDate(null);
            }

        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            DrawComboButton(null, ButtonState.Normal);
            base.OnMouseUp(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            if (keepFocus)
            {
                this.Focus();
                keepFocus = false;
                return;
            }
            selectedCommand = SelectedCommandType.None;
            this.Invalidate();
            base.OnLostFocus(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (e.Delta < 0)
                OnPreviewKeyDown(new PreviewKeyDownEventArgs(Keys.Down));
            else
                OnPreviewKeyDown(new PreviewKeyDownEventArgs(Keys.Up));
            base.OnMouseWheel(e);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            if (!keepFocus)
            {
                selectedCommand = SelectedCommandType.Day;
                DrawDate(null);
            }
            base.OnGotFocus(e);
        }

        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    {
                        if (selectedCommand == SelectedCommandType.None) return;

                        keepFocus = true;
                        switch (selectedCommand)
                        {
                            case SelectedCommandType.Day:
                                selectedCommand = SelectedCommandType.Month;
                                break;
                            case SelectedCommandType.Month:
                                selectedCommand = SelectedCommandType.Year;
                                break;
                            case SelectedCommandType.Year:
                                selectedCommand = SelectedCommandType.Day;
                                break;
                        }
                        DrawDate(null);

                    }
                    break;
                case Keys.Right:
                    {
                        if (selectedCommand == SelectedCommandType.None) return;

                        keepFocus = true;
                        switch (selectedCommand)
                        {
                            case SelectedCommandType.Day:
                                selectedCommand = SelectedCommandType.Year;
                                break;
                            case SelectedCommandType.Month:
                                selectedCommand = SelectedCommandType.Day;
                                break;
                            case SelectedCommandType.Year:
                                selectedCommand = SelectedCommandType.Month;
                                break;
                        }
                        DrawDate(null);

                    }
                    break;
                case Keys.Up:
                    {
                        if (selectedCommand == SelectedCommandType.None) return;

                        keepFocus = true;
                        switch (selectedCommand)
                        {
                            case SelectedCommandType.Day:
                                {
                                    int iCount = -1;
                                    if ((iCount = this.persianValue.GetDaysInMonth()) != this.persianValue.Day)
                                        this.Value = new PersianDate(persianValue.Year, persianValue.Month, persianValue.Day + 1);
                                    else
                                        this.Value = new PersianDate(persianValue.Year, persianValue.Month, 1);
                                }
                                break;
                            case SelectedCommandType.Month:
                                {
                                    if (this.persianValue.Month != 12)
                                        this.Value = this.Value.AddDays(this.persianValue.GetDaysInMonth());
                                    else
                                        this.Value = new PersianDate(persianValue.Year, 1, persianValue.Day);
                                }
                                break;
                            case SelectedCommandType.Year:
                                {
                                    this.Value = new PersianDate(persianValue.Year + 1, persianValue.Month, persianValue.Day);
                                }
                                break;
                        }
                    }
                    break;
                case Keys.Down:
                    {
                        if (selectedCommand == SelectedCommandType.None) return;

                        keepFocus = true;
                        switch (selectedCommand)
                        {
                            case SelectedCommandType.Day:
                                {

                                    if (1 != this.persianValue.Day)
                                        this.Value = new PersianDate(persianValue.Year, persianValue.Month, persianValue.Day - 1);
                                    else
                                        this.Value = new PersianDate(persianValue.Year, persianValue.Month, this.persianValue.GetDaysInMonth());
                                }
                                break;
                            case SelectedCommandType.Month:
                                {
                                    if (this.persianValue.Month != 1)
                                        this.Value = this.Value.AddDays(this.persianValue.Month > 7 ? -30 : -31);
                                    else
                                        this.Value = new PersianDate(persianValue.Year, 12, persianValue.Day);
                                }
                                break;
                            case SelectedCommandType.Year:
                                {
                                    this.Value = new PersianDate(persianValue.Year - 1, persianValue.Month, persianValue.Day);
                                }
                                break;
                        }
                    }
                    break;
                case Keys.Enter:
                    {
                        if (e.Control)
                            ShowCalendar();
                    }
                    break;

            }
            base.OnPreviewKeyDown(e);
        }

        protected override void OnFontChanged(EventArgs e)
        {
            UpdateRectangle(this.Value);

            base.OnFontChanged(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            if (!this.sizeChanging)
                UpdateRectangle(Value);
        }

        #endregion

        #region Painting Method
        private void DrawDate(Graphics gr)
        {
            if (gr == null) gr = Graphics.FromHwnd(this.Handle);

            gr.FillRectangle(Brushes.White, rectFillMonth);
            gr.FillRectangle(Brushes.White, rectFillDay);
            gr.FillRectangle(Brushes.White, rectFillYear);
            //draw Persian Value

            Brush brDay, brMonth, brYear;
            brDay = brMonth = brYear = Brushes.Black;
            switch (selectedCommand)
            {
                case SelectedCommandType.Day:
                    gr.FillRectangle(selectedBrush, rectFillDay);
                    brDay = Brushes.White;
                    break;
                case SelectedCommandType.Month:
                    gr.FillRectangle(selectedBrush, rectFillMonth);
                    brMonth = Brushes.White;
                    break;
                case SelectedCommandType.Year:
                    gr.FillRectangle(selectedBrush, rectFillYear);
                    brYear = Brushes.White;
                    break;
            }
            gr.DrawString(Value.Year.ToString("0000"), this.Font, brYear, rectYear, sf);
            gr.DrawString(Value.Month.ToString("00"), this.Font, brMonth, rectMonth, sf);
            gr.DrawString(Value.Day.ToString("00"), this.Font, brDay, rectDay, sf);
        }

        private void DrawComboButton(Graphics gr, ButtonState state)
        {
            if (gr == null) gr = Graphics.FromHwnd(this.Handle);

            ControlPaint.DrawComboButton(gr, rectComboButton, state);
        }
        #endregion

        #region Private Methods
        private int GetTop(Control ct, int topTotal)
        {
            if (ct != null)
                topTotal += GetTop(ct.Parent, ct.Location.Y);
            return topTotal;
        }

        private int GetLeft(Control ct, int leftTotal)
        {
            if (ct != null)
                leftTotal += GetLeft(ct.Parent, ct.Location.X);
            return leftTotal;
        }

        private void ShowCalendar()
        {

            if (isOpen) return;

            Point p = new Point(GetLeft(this, 0), GetTop(this, 0));
            Form f;
            if ((f = this.FindForm()) != null)
            {
                p.X -= f.Left;
                p.Y -= f.Top; 
                p = f.PointToScreen(p);
                p.Y += this.Height;
            }
            else
            {
                p.X += 3;
                p.Y += this.Height * 2 + this.Height / 2;
            }
            popup.Location = p;
            persianMonthCalendar.Value = this.Value;
            popup.Hide();
            popup.Show(this);
        }

        private void UpdateRectangle(PersianDate curDate)
        {
            if (curDate == null) return;
            this.sizeChanging = true;
            Graphics gr = Graphics.FromHwnd(this.Handle);

            SizeF textSize = gr.MeasureString(curDate.Year.ToString("0000"), this.Font);
            this.Height = ((int)textSize.Height) + 4;
            float fY = ((((float)this.Height) / 2) - (textSize.Height / 2));
            //rectYear = new RectangleF(0, (int)((this.Height / 2) - (textSize.Height / 2)), textSize.Width, textSize.Height);
            rectYear = new RectangleF(0, fY, textSize.Width, textSize.Height);

            textSize = gr.MeasureString("/", this.Font);
            rectSep1 = new RectangleF(rectYear.Width - 3, fY, textSize.Width, textSize.Height);

            textSize = gr.MeasureString(curDate.Month.ToString("00"), this.Font);
            rectMonth = new RectangleF((rectYear.Width + rectSep1.Width) - 8, fY, textSize.Width, textSize.Height);


            rectSep2 = new RectangleF((rectYear.Width + rectSep1.Width + rectMonth.Width) - 13, rectSep1.Y, rectSep1.Width, rectSep1.Height);

            textSize = gr.MeasureString(curDate.Day.ToString("00"), this.Font);
            rectDay = new RectangleF((rectYear.Width + (rectSep1.Width * 2) + rectMonth.Width) - 17, fY, textSize.Width, textSize.Height);


            this.rectFillYear = this.rectYear;
            this.rectFillYear.Height -= 1;
            this.rectFillYear.Width -= 5;
            this.rectFillYear.X += 3;

            this.rectFillMonth = this.rectMonth;
            this.rectFillMonth.Height -= 1;
            this.rectFillMonth.Width -= 5;
            this.rectFillMonth.X += 3;

            this.rectFillDay = this.rectDay;
            this.rectFillDay.Height -= 1;
            this.rectFillDay.Width -= 5;
            this.rectFillDay.X += 3;

            rectComboButton = new Rectangle(this.Width - 21, (int)rectYear.Y, 18, (int)rectYear.Height);

            gr.Dispose();
            this.sizeChanging = false;
        }

        #endregion

        #region Virtual Methods
        protected virtual void OnValueChanged(PersianDate curDate, PersianDate oldDate)
        {
            //UpdateRectangle(curDate);
            DrawDate(null);
            if (ValueChanged != null)
                ValueChanged(this, new PersianMonthCalendarEventArgs { CurrentValue = curDate, OldValue = oldDate });
        }
        #endregion

        #endregion

        #region Method of events
        private void persianMonthCalendar_PopupClosed(object sender, EventArgs e)
        {
            isOpen = false;
            popup.Hide();
            selectedCommand = SelectedCommandType.Day;
            this.Value = persianMonthCalendar.Value;
            this.FindForm().Activate();

        }

        private void persianMonthCalendar_ValueChanged(object sender, PersianMonthCalendarEventArgs e)
        {
            //UpdateRectangle(e.CurrentValue);
            selectedCommand = SelectedCommandType.Day;
            this.Value = e.CurrentValue;
        }
        #endregion

        #region Enums
        private enum SelectedCommandType
        {
            None = 0,
            Day = 1,
            Month = 2,
            Year = 3
        }
        #endregion
    }
}
