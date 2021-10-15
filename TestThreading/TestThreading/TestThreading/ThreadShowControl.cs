using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace TestThreading
{
    public partial class ThreadShowControl : UserControl
    {
        // Programmed by PC2st.ir at Barnamenevis.org
        // Please Observe the Rules of Copyright :]
        // Mail: PC2st.ir@gmail.com

        private delegate void DoDraw( Point point, int degree, int d );

        private Thread _thdDraw;
        private Graphics _graphic;
        private Point _center;
        private double _tabdil;
        private double _lastDeg;

        public ThreadShowControl()
        {
            InitializeComponent();
            _thdDraw = new Thread( new ThreadStart( DoWork ) );
            _graphic = this.picPaint.CreateGraphics();
            this._center = new Point( this.picPaint.Width / 2, this.picPaint.Height / 2 );
            this._tabdil = Math.PI / 180;
            this.ClearAfterDraw = true;
            this._lastDeg = 0;
        }

        public ThreadPriority Priority
        {
            get
            {
                return _thdDraw.Priority;
            }
            set
            {
                if( ( int )value > 2 && this.Sleep == 0 && MessageBox.Show( "\t\t\t  .این کار خطرناک است، برنامه هنگ خواهد کرد\n\n!نباید در صورتی که اهمیت بیشتر از معمولی است، مقدار خواب برابر صفر باشد\n\n\tآیا مطمئن هستید که می‌خواهید چنین عملی را انجام دهید؟", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Error ) == DialogResult.No )
                {
                    _thdDraw.Priority = ThreadPriority.Normal;
                    this.cboPriority.SelectedIndex = 2;
                }
                else
                {
                    _thdDraw.Priority = value;
                    this.cboPriority.SelectedIndex = ( int )value;
                }
            }
        }

        private int _sleep;
        public int Sleep
        {
            get { return _sleep; }
            set
            {
                if( value == 0 && ( int )( this.Priority ) > 2 && MessageBox.Show( "\t\t\t  .این کار خطرناک است، برنامه هنگ خواهد کرد\n\n!نباید در صورتی که اهمیت بیشتر از معمولی است، مقدار خواب برابر صفر باشد\n\n\tآیا مطمئن هستید که می‌خواهید چنین عملی را انجام دهید؟", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Error ) == DialogResult.No )
                {
                    _sleep = 1;
                    this.nmrSleep.Value = 1;
                }
                else
                {
                    _sleep = Math.Min( value, ( int )( this.nmrSleep.Maximum ) );
                    this.nmrSleep.Value = value;
                }
            }
        }

        private int _side;
        public int Side
        {
            get { return _side; }
            set { _side = value; }
        }

        private void DoWork()
        {
            int degree;
            StartAgain:
            degree = 0;
            for( ; degree <= int.MaxValue; degree++ )
            {
                this.Invoke( new DoDraw( SafeDraw ), new object[3] { _center, degree, this.Side } );
                Thread.Sleep( this.Sleep );
            }
            goto StartAgain;
        }

        private void SafeDraw( Point point, int degree, int d )
        {
            double deg = degree * this._tabdil;
            if( this.ClearAfterDraw ) _graphic.Clear( this.picPaint.BackColor );
            Point[] p = new Point[4];
            p[0].X = ( int )( d * ( Math.Cos( deg ) - Math.Sin( deg ) ) );
            p[0].Y = ( int )( d * ( Math.Cos( deg ) + Math.Sin( deg ) ) );
            p[1].X = ( int )( d * ( Math.Cos( deg ) + Math.Sin( deg ) ) );
            p[1].Y = ( int )( d * ( Math.Cos( deg ) - Math.Sin( deg ) ) );
            p[2].X = p[0].X;
            p[2].Y = p[0].Y;
            p[3].X = p[1].X;
            p[3].Y = p[1].Y;
            p[0].X = point.X - p[0].X;
            p[0].Y = point.Y - p[0].Y;
            p[1].X = point.X - p[1].X;
            p[1].Y = point.Y + p[1].Y;
            p[2].X = point.X + p[2].X;
            p[2].Y = point.Y + p[2].Y;
            p[3].X = point.X + p[3].X;
            p[3].Y = point.Y - p[3].Y;
            _graphic.DrawLines( Pens.Red, p );
            _graphic.DrawLine( Pens.Yellow, p[3], p[0] );
            this.txtDegree.Text = degree.ToString();
        }

        public void Start()
        {
            _thdDraw.Start();
            this.tmrSpeed.Enabled = true;
            this.btnSuspend.Enabled = true;
        }

        public void Suspend()
        {
            _thdDraw.Suspend();
            this.tmrSpeed.Enabled = false;
        }

        public void Resume()
        {
            _thdDraw.Resume();
            this.tmrSpeed.Enabled = true;
        }

        public void Abort()
        {
            if( this._thdDraw.ThreadState == ThreadState.Suspended )
                this._thdDraw.Resume();
            _thdDraw.Abort();
            this.tmrSpeed.Enabled = false;
        }

        private void cboPriority_SelectedIndexChanged( object sender, EventArgs e )
        {
            this.Priority = ( ThreadPriority )( this.cboPriority.SelectedIndex );
        }

        private void nmrSleep_ValueChanged( object sender, EventArgs e )
        {
            this.Sleep = ( int )( this.nmrSleep.Value );
        }

        private void btnSuspend_Click( object sender, EventArgs e )
        {
            if( _thdDraw.ThreadState == ThreadState.Suspended )
            {
                this.Resume();
                this.btnSuspend.Text = "تعلیق";
            }
            else
            {
                this.Suspend();
                this.btnSuspend.Text = "ادامه";
            }
        }

        private bool _clearAfterDraw;
        public bool ClearAfterDraw
        {
            get
            {
                return _clearAfterDraw;
            }
            set
            {
                _clearAfterDraw = value;
                this.chkClear.Checked = value;
            }
        }

        public int Degree
        {
            get { return int.Parse( this.txtDegree.Text ); }
        }

        public double Speed
        {
            get { return double.Parse( this.txtSpeed.Text ); }
        }

        private void chkClear_CheckedChanged( object sender, EventArgs e )
        {
            this.ClearAfterDraw = this.chkClear.Checked;
        }

        private void nmrSleep_KeyDown( object sender, KeyEventArgs e )
        {
            if( e.KeyCode == Keys.Enter ) this.txtDegree.Focus();
        }

        private void tmrSpeed_Tick( object sender, EventArgs e )
        {
            this.txtSpeed.Text = ( ( double )( ( this.Degree - this._lastDeg ) / this.tmrSpeed.Interval ) ).ToString();
            this._lastDeg = this.Degree;
        }
    }
}
