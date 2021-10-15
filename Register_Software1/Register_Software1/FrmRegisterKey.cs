using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
namespace Register_Software
{
    public partial class FrmRegisterKey : Form
    {
        string code1, code2, code3, code4;
        public FrmRegisterKey()
        {
            InitializeComponent();
        }
        private void GetHDDSerialNumber()
        {
            ManagementObjectSearcher searcher;
            string query1 = "SELECT * FROM Win32_DiskDrive";
            string query2 = "SELECT * FROM Win32_PhysicalMedia";

            searcher = new ManagementObjectSearcher(query1);
            foreach (ManagementObject wmi_HD in searcher.Get())
                if (wmi_HD["Model"] != null)
                    code1= wmi_HD["Model"].ToString();

            searcher = new ManagementObjectSearcher(query2);
            foreach (ManagementObject wmi_HD in searcher.Get())
                if (wmi_HD["SerialNumber"] != null)
                    code2= wmi_HD["SerialNumber"].ToString();
        }
        public void GetCPUManufacturer()
        {
            string cpuMan = String.Empty;
            //create an instance of the Managemnet class with the
            //Win32_Processor class
            ManagementClass mgmt = new ManagementClass("Win32_Processor");
            //create a ManagementObjectCollection to loop through
            ManagementObjectCollection objCol = mgmt.GetInstances();
            //start our loop for all processors found
            foreach (ManagementObject obj in objCol)
            {
                if (cpuMan == String.Empty)
                {
                    // only return manufacturer from first CPU
                    cpuMan = obj.Properties["Manufacturer"].Value.ToString();
                    code3 = cpuMan;
                }
            }
            
        }
        public void GetCPUId()
        {
            string cpuInfo = String.Empty;
            //create an instance of the Managemnet class with the
            //Win32_Processor class
            ManagementClass mgmt = new ManagementClass("Win32_Processor");
            //create a ManagementObjectCollection to loop through
            ManagementObjectCollection objCol = mgmt.GetInstances();
            //start our loop for all processors found
            foreach (ManagementObject obj in objCol)
            {
                if (cpuInfo == String.Empty)
                {
                    // only return cpuInfo from first CPU
                    cpuInfo = obj.Properties["ProcessorId"].Value.ToString();
                    code4 = cpuInfo;
                 }
            }
        }
        

        

        

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ///////////به این دلیل توابع توی ترای قرار گرفته که اگه یه وقت این توابع با ////////////
            ///////////بعضی سخت افزار ها نخوند و نتونست کدشو//////////////////////
            /////////////////////////////دربیاره ما از خودمون یه کد برای ثبت کردن داشته باشیم و اجرای برنامه با خطا متوقف نشه  ////////////
            try
            {
                GetHDDSerialNumber();
            }
            catch 
            {
                code1 = "2458";
                code2 = "3367";
            }
            try
            {
                GetCPUManufacturer();
            }
            catch
            {
                code3 = "4589";
            }
            try
            {
                GetCPUId();
            }
            catch
            {
                code4 = "9978";
            }
            string strCode="";
            Double DoubleCode=0;
            int i;
            AES_Encryption.AES a = new AES_Encryption.AES();
            textBox1.Text = a.Encrypt(code1, "1", 128);
            textBox2.Text = a.Encrypt(code2, "1", 128);
            textBox3.Text = a.Encrypt(code3, "1", 128);
            textBox4.Text = a.Encrypt(code4, "1", 128);
            /////////////////////////////////////////////////////
            for (i = 1; i <= code1.Length; i++)
            {

                strCode = (((int)(Convert.ToChar(textBox1.Text.Substring(i, 1)))).ToString());
                DoubleCode = DoubleCode + Convert.ToDouble(strCode);
            }
            textBox1.Text = Convert.ToString(DoubleCode);
            textBox1.Text = textBox1.Text.Substring(0, 4);
            ///////////////////////////////////////////////////
            for (i = 1; i <= code2.Length; i++)
            {

                strCode = (((int)(Convert.ToChar(textBox2.Text.Substring(i, 1)))).ToString());
                DoubleCode = DoubleCode + Convert.ToDouble(strCode);
            }
            textBox2.Text = Convert.ToString(DoubleCode);
            textBox2.Text = textBox2.Text.Substring(0, 4);
            //////////////////////////////////////////////////
            for (i = 1; i <= code3.Length; i++)
            {

                strCode = (((int)(Convert.ToChar(textBox3.Text.Substring(i, 1)))).ToString());
                DoubleCode = DoubleCode + Convert.ToDouble(strCode);
            }
            textBox3.Text = Convert.ToString(DoubleCode);
            textBox3.Text = textBox3.Text.Substring(0, 4);
            /////////////////////////////////////////
            for (i = 1; i <= code4.Length; i++)
            {

                strCode = (((int)(Convert.ToChar(textBox4.Text.Substring(i, 1)))).ToString());
                DoubleCode = DoubleCode + Convert.ToDouble(strCode);
            }
            textBox4.Text = Convert.ToString(DoubleCode);
            textBox4.Text = textBox4.Text.Substring(0, 4);
            /////////////////////////////////////////////////
            MessageBox.Show("کد های راه انداز نرم افزار با موفقیت ثبت شد . لطفا بدقت این کد ها را برای واحد پشتیبانی تکرار نمایید  ","",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

        }
    }
}
