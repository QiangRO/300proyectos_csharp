using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ColorFinder
{
    public partial class MainForm : Form
    {
        AboutForm aboutForm;
        /* ضرایب لازم برای تشخیص نوع رنگ
         * این ضرایت تجربی است، در صورت نیاز، میتوانید آنرا تغییر دهید
         * K1 = ضریب برای رنگهای قرمز، سبز و آبی
         * K2 = ضریب برای رنگهای زرد، فیروزه ای و بنفش
         * K3 = ضریب برای رنگهای صورتی، سرمه ای، نیلی، یشمی، پسته ای و نارنجی
         */
        private const float K1 = 2, K2 = 4, K3 = 0.5F;

        public MainForm()
        {
            InitializeComponent();
            aboutForm = new AboutForm();
            // دو کد زیر، تنها برای شکل دهی به دکمه ها مورد استفاده قرار میگیره
            Program.MakeButtonStyle( this.btnAbout );
            Program.MakeButtonStyle( this.btnClose );
        }

        /* این تابع، سه رنگ را دریافت میکند
         * درصورتی که رنگ سومی، غلظت بیشتری به نسبت رنگ اول و دوم داشت
         * آنگاه مقدار درست برگشت داده میشود
         * از این تابع میتوان برای تشخیص رنگهای تکی، مثل آبی، قرمز و سبز استفاده کرد
         */
        private bool ColorIsBase( params byte[] colors )
        {
            if( colors[2] >= Math.Max( colors[0], colors[1] ) + Math.Abs( colors[0] - colors[1] ) * K1 )
                return true;
            return false;
        }

        /* این تابع، سه رنگ را دریافت میکند
         * درصورتی که رنگ اول و دوم، غلظت بیشتری به نسبت رنگ سوم داشت
         * آنگاه مقدار درست برگشت داده میشود
         * به کمک پارامتر اول، میتوان ضریبی را مشخص کرد تا دقت یافتن رنگ مشحص گردد
         * این ضریب برای رنگهای صورتی و سرمه ای و ... با رنگهای بنفش و فیروزه ای و زرد متفاوت است
         * از این تابع برای یافتن رنگهای زرد و نارنجی و بنفش و صورتی و ... استفاده میشود
         */
        private bool ColorIsDouble( float zarib, params byte[] colors )
        {
            if( colors[2] <= Math.Min( colors[0], colors[1] ) - Math.Abs( colors[0] - colors[1] ) * zarib )
                return true;
            return false;
        }

        // این تابع، تنها برای نمایش اطلاعات بکار میرود
        private void ShowMessage( string message, Color color )
        {
            this.lblMessage.ForeColor = color;
            this.lblMessage.Text = "هم اکنون رنگ " + message + " انتخاب شده است.";
        }

        private void btnSelect_Click( object sender, EventArgs e )
        {
            if( this.clrdlgSelect.ShowDialog() == DialogResult.OK )
            {
                // در اینجا تشخیص نوع رنگ صورت میگیره
                // توجه کنید که خطوط کد شکسته شده اند تا کمی خواناتر بشه
                Color color = this.clrdlgSelect.Color;
                if( this.ColorIsDouble
                    ( K2
                    , color.R
                    , color.G
                    , color.B ) )
                    this.ShowMessage
                        ( "زرد"
                        , Color.FromArgb( 128, 128, 0 ) );
                else
                    if( this.ColorIsDouble
                        ( K2
                        , color.B
                        , color.R
                        , color.G ) )
                        this.ShowMessage
                            ( "بنفش"
                            , Color.FromArgb( 255, 0, 255 ) );
                else
                    if( this.ColorIsDouble
                        ( K2
                        , color.G
                        , color.B
                        , color.R ) )
                        this.ShowMessage
                            ( "فیروزه‌ای"
                            , Color.FromArgb( 0, 128, 128 ) );
                else
                    if( this.ColorIsDouble
                        ( K3
                        , color.R
                        , color.G
                        , color.B ) )
                        if( color.R >= color.G )
                            this.ShowMessage
                                ( "نارنجی"
                                , Color.FromArgb( 255, 128, 0 ) );
                        else
                            this.ShowMessage
                                ( "پسته‌ای"
                                , Color.FromArgb( 64, 128, 0 ) );
                else
                    if( this.ColorIsDouble
                        ( K3
                        , color.B
                        , color.R
                        , color.G ) )
                        if( color.B >= color.R )
                            this.ShowMessage
                                ( "سرمه‌ای"
                                , Color.FromArgb( 128, 0, 255 ) );
                        else
                            this.ShowMessage
                                ( "صورتی"
                                , Color.FromArgb( 255, 0, 128 ) );
                else
                    if( this.ColorIsDouble
                        ( K3
                        , color.G
                        , color.B
                        , color.R ) )
                        if( color.G >= color.B )
                            this.ShowMessage
                                ( "یشمی"
                                , Color.FromArgb( 0, 128, 64 ) );
                        else
                            this.ShowMessage
                                ( "نیلی"
                                , Color.FromArgb( 0, 128, 255 ) );
                else
                    if( this.ColorIsBase
                        ( color.R
                        , color.G
                        , color.B ) )
                        this.ShowMessage
                            ( "آبی"
                            , Color.FromArgb( 0, 0, 255 ) );
                else
                    if( this.ColorIsBase
                        ( color.B
                        , color.R
                        , color.G ) )
                        this.ShowMessage
                            ( "سبز"
                            , Color.FromArgb( 0, 128, 0 ) );
                else
                    if( this.ColorIsBase
                        ( color.G
                        , color.B
                        , color.R ) )
                        this.ShowMessage
                            ( "قرمز"
                            , Color.FromArgb( 255, 0, 0 ) );
                else
                {
                    this.lblMessage.ForeColor = SystemColors.ControlText;
                    this.lblMessage.Text = "هم اکنون هیچ رنگی انتخاب نشده است.";
                }
            }
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            Application.Exit();
        }

        private void btnAbout_Click( object sender, EventArgs e )
        {
            aboutForm.ShowDialog();
            this.btnSelect.Focus();
        }
    }
}