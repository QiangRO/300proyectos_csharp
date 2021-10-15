using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProcessDetailInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();
            // Get the process start information of notepad.
            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo("notepad.exe");
            // Assign 'StartInfo' of notepad to 'StartInfo' of 'myProcess' object.
            myProcess.StartInfo = myProcessStartInfo;
            // Create a notepad.
            myProcess.Start();
            System.Threading.Thread.Sleep(1000);
            ProcessModule myProcessModule;
            // Get all the modules associated with 'myProcess'.
            ProcessModuleCollection myProcessModuleCollection = myProcess.Modules;
            listBox1.Items.Add("Properties of the modules  associated "
               + "with 'notepad' are:");
            // Display the properties of each of the modules.
            for (int i = 0; i < myProcessModuleCollection.Count; i++)
            {
                myProcessModule = myProcessModuleCollection[i];
                listBox1.Items.Add("The moduleName is "
                   + myProcessModule.ModuleName);
                listBox1.Items.Add("The " + myProcessModule.ModuleName + "'s base address is: "
                   + myProcessModule.BaseAddress);
                listBox1.Items.Add("The " + myProcessModule.ModuleName + "'s Entry point address is: "
                   + myProcessModule.EntryPointAddress);
                listBox1.Items.Add("The " + myProcessModule.ModuleName + "'s File name is: "
                   + myProcessModule.FileName);
            }
            // Get the main module associated with 'myProcess'.
            myProcessModule = myProcess.MainModule;
            // Display the properties of the main module.
            listBox1.Items.Add("The process's main moduleName is:  "
               + myProcessModule.ModuleName);
            listBox1.Items.Add("The process's main module's base address is: "
               + myProcessModule.BaseAddress);
            listBox1.Items.Add("The process's main module's Entry point address is: "
               + myProcessModule.EntryPointAddress);
            listBox1.Items.Add("The process's main module's File name is: "
               + myProcessModule.FileName);
            myProcess.CloseMainWindow();
        }
    }
}