using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestThreading
{
    public partial class MainForm : Form
    {
        private ThreadShowControl[] _threadShowControl;
        private delegate void FunctionDelegate();

        public MainForm()
        {
            InitializeComponent();
            this.MakeControlsInstance();
        }

        private void MakeControlsInstance()
        {
            this._threadShowControl = new ThreadShowControl[4];
            for( int counter = 0; counter < _threadShowControl.Length; counter++ )
            {
                this._threadShowControl[counter] = new ThreadShowControl();
                this._threadShowControl[counter].ClearAfterDraw = true;
                this._threadShowControl[counter].Font = new System.Drawing.Font( "Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 178 ) ) );
                this._threadShowControl[counter].Location = new System.Drawing.Point( 456 - ( counter == 0 ? 0 : ( this._threadShowControl[counter - 1].Width + 4 ) * counter ), 20 );
                this._threadShowControl[counter].Name = "_threadShowControl" + counter.ToString();
                this._threadShowControl[counter].Priority = System.Threading.ThreadPriority.Normal;
                this._threadShowControl[counter].RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this._threadShowControl[counter].Side = 40;
                this._threadShowControl[counter].Size = new System.Drawing.Size( 146, 310 );
                this._threadShowControl[counter].Sleep = 10;
                this._threadShowControl[counter].TabIndex = 0;
                this.grpShow.Controls.Add( this._threadShowControl[counter] );
            }
        }

        private void btnExit_Click( object sender, EventArgs e )
        {
            this.DoFunction( _threadShowControl, "Abort" );
            Application.Exit();
        }

        private void btnStart_Click( object sender, EventArgs e )
        {
            this.btnStart.Enabled = false;
            this.DoFunction( _threadShowControl, "Start" );
            this.btnStop.Enabled = true;
        }

        private void btnAbout_Click( object sender, EventArgs e )
        {
            MessageBox.Show( "Programmed by PC2st.ir at Barnamenevis.org\t\n\nPlease Observe the Rules of Copyright :]\n\n\tMail: PC2st.ir@gmail.com", "About Threading Tester", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void btnStop_Click( object sender, EventArgs e )
        {
            this.DoFunction( _threadShowControl, "Suspend" );
            this.btnStop.Enabled = false;
            this.btnContinue.Enabled = true;
        }

        private void btnContinue_Click( object sender, EventArgs e )
        {
            this.DoFunction( _threadShowControl, "Resume" );
            this.btnStop.Enabled = true;
            this.btnContinue.Enabled = false;
        }

        private void DoFunction(ThreadShowControl[] tsc, string method)
        {
            for( int counter = 0; counter < tsc.Length; counter++ )
            {
                tsc[counter].GetType().GetMethod( method ).Invoke( tsc[counter], null );
            }
        }
    }
}