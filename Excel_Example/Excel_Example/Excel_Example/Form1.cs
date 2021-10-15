using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Excel_Example
{
    public partial class Form1 : Form
    {
        ///Excel.Application app;
        
        //making a new Appliction of Excell
        Excel.ApplicationClass app = new Excel.ApplicationClass();

        //making a Workbook by usig Excel.Workbook interface
        Excel.Workbook WBi;

        //making a Worksheet by usig Excel.Worksheet interface
        Excel.Worksheet WSi;

        string path;
         
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {  
            app.Quit();
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Saving As ...";

            ///saveFile.DefaultExt = ".xls";

            DialogResult result = saveFile.ShowDialog();

            WBi.SaveAs(
                saveFile.FileName,                      //Filename: This parameter is intended for internal use only.
                Excel.XlFileFormat.xlWorkbookNormal,    //FileFormat: This parameter is intended for internal use only.
                "",                                     //Password: This parameter is intended for internal use only.
                "",                                     //WriteResPassword: This parameter is intended for internal use only.
                Type.Missing,                           //ReadOnlyRecommended: This parameter is intended for internal use only.
                Type.Missing,                           //CreateBackup: This parameter is intended for internal use only.
                Excel.XlSaveAsAccessMode.xlExclusive,   //AccessMode: This parameter is intended for internal use only.
                Type.Missing,                           //ConflictResolution: This parameter is intended for internal use only.
                true,                                   //AddToMru: This parameter is intended for internal use only.
                Type.Missing,                           //TextCodepage: This parameter is intended for internal use only.
                Type.Missing,                           //TextVisualLayout: This parameter is intended for internal use only.
                Type.Missing                            //Local: This parameter is intended for internal use only.
                );
        }

        private void buttonNewSheet_Click(object sender, EventArgs e)
        {
            //making a new Sheet base on the name that user input into the TextBoex. It added befor the Active Sheet
            WSi = (Excel.Worksheet)WBi.Worksheets.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            WSi.Name = textBoxSheetName.Text;

            //Below code select the third sheet for the WSi
            ///WSi = (Excel.Worksheet)WBi.Sheets[(object)(3)];
            ///


            //Active the "Sheet1"

            //(Excel.Worksheet)WBi.Sheets[(object)"Sheet1"]

            try
            {
                if ((WSi = (Excel.Worksheet)WBi.Sheets[(object)"Sheet1"]) != null)
                    WSi.Activate();
            }
            catch { MessageBox.Show("Sheet1 was not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();

            if ( (path = openFile.FileName) != null)
            {
                WBi = (Excel.Workbook)app.Workbooks._Open(
                    path,                                           //FileName
                    Excel.XlUpdateLinks.xlUpdateLinksNever,         //UpdateLink
                    false,                                          //ReadOnly
                    Excel.XlFormatConditionOperator.xlNotEqual,     //Format
                    "mohammad",                                     //Password
                    "reza",                                         //WriteResPassword
                    true,                                           //IgnoreReadOnlyRecommanded
                    Excel.XlPlatform.xlWindows,                     //Origin
                    false,                                          //Delimiter
                    false,                                          //Editable
                    true,                                           //Notify
                    null,                                           //Converter
                    true);                                          //AddtoMu

                #region Optional
            /*
             * Parameters
            Filename
            Required String. The file name of the workbook to be opened.

            UpdateLinks
            Optional Object. Specifies the way links in the file are updated. If this argument is omitted, the user is prompted to specify how links will be updated. Otherwise, this argument is one of the values listed in the following table.

            Value
             Meaning
             
            1
             User specifies how links will be updated
             
            2
             Never update links for this workbook on opening
             
            3
             Always update links for this workbook on opening
             

            If Microsoft Excel is opening a file in the WKS, WK1, or WK3 format and the UpdateLinks argument is 2, Microsoft Excel generates charts from the graphs attached to the file. If the argument is 0, no charts are created.

            ReadOnly
            Optional Object. True to open the workbook in read-only mode.

            Format
            Optional Object. If Microsoft Excel is opening a text file, this argument specifies the delimiter character, as shown in the following table. If this argument is omitted, the current delimiter is used.

            Value
             Delimiter
             
            1
             Tabs
             
            2
             Commas
             
            3
             Spaces
             
            4
             Semicolons
             
            5
             Nothing
             
            6
             Custom character (see the Delimiter argument)
             


            Password
            Optional Object. A string that contains the password required to open a protected workbook. If this argument is omitted and the workbook requires a password, the user is prompted for the password.

            WriteResPassword
            Optional Object. A string that contains the password required to write to a write-reserved workbook. If this argument is omitted and the workbook requires a password, the user will be prompted for the password.

            IgnoreReadOnlyRecommended
            Optional Object. True to have Microsoft Excel not display the read-only recommended message (if the workbook was saved with the Read-Only Recommended option).

            Origin
            Optional Object. If the file is a text file, this argument indicates where it originated (so that code pages and Carriage Return/Line Feed (CR/LF) can be mapped correctly). Can be one of the following XlPlatform constants: xlMacintosh, xlWindows, or xlMSDOS. If this argument is omitted, the current operating system is used.

            Delimiter
            Optional Object. If the file is a text file and the Format argument is 6, this argument is a string that specifies the character to be used as the delimiter. For example, use Chr(9) for tabs, use "," for commas, use ";" for semicolons, or use a custom character. Only the first character of the string is used.

            Editable
            Optional Object. If the file is a Microsoft Excel 4.0 add-in, this argument is True to open the add-in so that it’s a visible window. If this argument is False or omitted, the add-in is opened as hidden, and it cannot be unhidden. This option doesn't apply to add-ins created in Microsoft Excel 5.0 or later. If the file is an Excel template, use True to open the specified template for editing or False to open a new workbook based on the specified template. The default value is False.

            Notify
            Optional Object. If the file cannot be opened in read/write mode, this argument is True to add the file to the file notification list. Microsoft Excel will open the file as read-only, poll the file notification list, and then notify the user when the file becomes available. If this argument is False or omitted, no notification is requested, and any attempts to open an unavailable file will fail.

            Converter
            Optional Object. The index of the first file converter to try when opening the file. The specified file converter is tried first; if this converter doesn’t recognize the file, all other converters are tried. The converter index consists of the row numbers of the converters returned by the FileConverters property.

            AddToMru
            Optional Object. True to add this workbook to the list of recently used files. The default value is False.

            */
                #endregion

                //To see the Excel form and our WorkBooks. If we do not write the below code it becane hide.
                app.Visible = true;
            }
        }

        private void buttonOpenTemplate_Click(object sender, EventArgs e)
        {
            path = System.IO.Directory.GetCurrentDirectory() + "\\Template";

            if (path != null)
            {
                WBi = (Excel.Workbook)app.Workbooks._Open(
                    path,                                           //FileName
                    Excel.XlUpdateLinks.xlUpdateLinksNever,         //UpdateLink
                    false,                                          //ReadOnly
                    Excel.XlFormatConditionOperator.xlNotEqual,     //Format
                    "mohammad",                                     //Password
                    "reza",                                         //WriteResPassword
                    true,                                           //IgnoreReadOnlyRecommanded
                    Excel.XlPlatform.xlWindows,                     //Origin
                    false,                                          //Delimiter
                    false,                                          //Editable
                    true,                                           //Notify
                    null,                                           //Converter
                    true);                                          //AddtoMu

                app.Visible = true;
            }

            //Display the form in Full Screen mode
            ///app.DisplayFullScreen = true;
            
            //Activate the Form
            Activate();
        }

        private void buttonAverage_Click(object sender, EventArgs e)
        {
            path = System.IO.Directory.GetCurrentDirectory() + "\\Average";

            WBi = (Excel.Workbook)app.Workbooks._Open(
                    path,                                           //FileName
                    Excel.XlUpdateLinks.xlUpdateLinksNever,         //UpdateLink
                    false,                                          //ReadOnly
                    Excel.XlFormatConditionOperator.xlNotEqual,     //Format
                    "",                                             //Password
                    "",                                             //WriteResPassword
                    true,                                           //IgnoreReadOnlyRecommanded
                    Excel.XlPlatform.xlWindows,                     //Origin
                    false,                                          //Delimiter
                    false,                                          //Editable
                    true,                                           //Notify
                    null,                                           //Converter
                    true);                                          //AddtoMu

            app.Visible = true;
            Activate();
        }


        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {

                WSi = (Excel.Worksheet)WBi.Worksheets["Data"];

                //finding the count of mark that enter in the worksheet
                int markCount;
                for (markCount = 2; ; markCount++)
                {
                    //cheking the cell for filling or not. The first next line is a cell realy not more than a cell
                    Excel.Range range = WSi.get_Range("A" + markCount, Type.Missing);
                    if (range.Value2 == null) //cheking the cell for filling by Value2
                        break;
                }

                //Sellect or interest cells with another view
                Excel.Range rng1 = WSi.get_Range("A2", "B" + (markCount - 1));
                rng1.Borders.Color = System.Drawing.ColorTranslator.ToOle(Color.Blue);
                rng1.Font.Bold = true;

                //Parsing our data to the an Array 
                System.Array valueArray = (System.Array)rng1.Value2;

                double total = 0.0,
                    average;
                int credits = 0;

                double[,] values = new double[valueArray.GetLength(0), valueArray.GetLength(1)];

                try
                {
                    for (int i = 1; i <= valueArray.GetLength(0); i++)
                    {
                        total += (double)valueArray.GetValue(i, 1) * (double)valueArray.GetValue(i, 2);
                        credits += Convert.ToInt32(valueArray.GetValue(i, 2));
                    }
                }
                catch
                {
                    rng1.Borders.Color = System.Drawing.ColorTranslator.ToOle(Color.White);
                    rng1.Font.Bold = false;
                }

                average = total / credits;

                WSi.Cells[3, 5] = total;
                WSi.Cells[4, 5] = average;
                textBoxTotal.Text = total.ToString();
                textBoxAverage.Text = average.ToString();

                Excel.Range rng2 = WSi.get_Range("E3", "E4");
                rng2.Font.Color = System.Drawing.ColorTranslator.ToOle(Color.Crimson);
                rng2.Font.Bold = true;
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
    }
}