using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Persian_Date__Vista_Skin_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Persian_Date()
        {
            //############################################################################################
            //Get Persian Date.
            System.Globalization.PersianCalendar PrsClnd = new System.Globalization.PersianCalendar();
            DateTime DT = DateTime.Now;
            string Year;
            string Month;
            string Day;
            Year = PrsClnd.GetYear(DT).ToString();
            Month = PrsClnd.GetMonth(DT).ToString();
            Day = PrsClnd.GetDayOfMonth(DT).ToString();
            
            //############################################################################################

            //############################################################################################
            //Declare Variables.
            string App_Path;
            App_Path = Application.StartupPath.ToString();
            //-------------------------------------------
            string[] Img = new String[10];
            Img[0] = App_Path + "\\Resource\\0.jpg".ToString();
            Img[1] = App_Path + "\\Resource\\1.jpg".ToString();
            Img[2] = App_Path + "\\Resource\\2.jpg".ToString();
            Img[3] = App_Path + "\\Resource\\3.jpg".ToString();
            Img[4] = App_Path + "\\Resource\\4.jpg".ToString();
            Img[5] = App_Path + "\\Resource\\5.jpg".ToString();
            Img[6] = App_Path + "\\Resource\\6.jpg".ToString();
            Img[7] = App_Path + "\\Resource\\7.jpg".ToString();
            Img[8] = App_Path + "\\Resource\\8.jpg".ToString();
            Img[9] = App_Path + "\\Resource\\9.jpg".ToString();
            //############################################################################################

            //This Code For Year.
            switch (Year)
            {
                
                case "1358":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[5]);
                    y4.Image = Image.FromFile(Img[8]);
                    break;
                case "1359":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[5]);
                    y4.Image = Image.FromFile(Img[9]);
                    break;
                case "1360":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[6]);
                    y4.Image = Image.FromFile(Img[0]);
                    break;
                case "1361":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[6]);
                    y4.Image = Image.FromFile(Img[1]);
                    break;
                case "1362":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[6]);
                    y4.Image = Image.FromFile(Img[2]);
                    break;
                case "1363":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[6]);
                    y4.Image = Image.FromFile(Img[3]);
                    break;
                case "1364":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[6]);
                    y4.Image = Image.FromFile(Img[4]);
                    break;
                case "1365":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[6]);
                    y4.Image = Image.FromFile(Img[5]);
                    break;
                case "1366":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[6]);
                    y4.Image = Image.FromFile(Img[6]);
                    break;
                case "1367":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[6]);
                    y4.Image = Image.FromFile(Img[7]);
                    break;
                case "1368":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[6]);
                    y4.Image = Image.FromFile(Img[8]);
                    break;
                case "1369":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[6]);
                    y4.Image = Image.FromFile(Img[9]);
                    break;
                case "1370":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[7]);
                    y4.Image = Image.FromFile(Img[0]);
                    break;
                case "1371":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[7]);
                    y4.Image = Image.FromFile(Img[1]);
                    break;
                case "1372":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[7]);
                    y4.Image = Image.FromFile(Img[2]);
                    break;
                case "1373":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[7]);
                    y4.Image = Image.FromFile(Img[3]);
                    break;
                case "1374":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[7]);
                    y4.Image = Image.FromFile(Img[4]);
                    break;
                case "1375":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[7]);
                    y4.Image = Image.FromFile(Img[5]);
                    break;
                case "1376":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[7]);
                    y4.Image = Image.FromFile(Img[6]);
                    break;
                case "1377":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[7]);
                    y4.Image = Image.FromFile(Img[7]);
                    break;
                case "1378":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[7]);
                    y4.Image = Image.FromFile(Img[8]);
                    break;
                case "1379":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[7]);
                    y4.Image = Image.FromFile(Img[9]);
                    break;
                case "1380":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[8]);
                    y4.Image = Image.FromFile(Img[0]);
                    break;
                case "1381":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[8]);
                    y4.Image = Image.FromFile(Img[1]);
                    break;
                case "1382":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[8]);
                    y4.Image = Image.FromFile(Img[2]);
                    break;
                case "1383":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[8]);
                    y4.Image = Image.FromFile(Img[3]);
                    break;
                case "1384":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[8]);
                    y4.Image = Image.FromFile(Img[4]);
                    break;
                case "1385":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[8]);
                    y4.Image = Image.FromFile(Img[5]);
                    break;
                case "1386":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[8]);
                    y4.Image = Image.FromFile(Img[6]);
                    break;
                case "1387":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[8]);
                    y4.Image = Image.FromFile(Img[7]);
                    break;
                case "1388":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[8]);
                    y4.Image = Image.FromFile(Img[8]);
                    break;
                case "1389":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[8]);
                    y4.Image = Image.FromFile(Img[9]);
                    break;
                case "1390":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[9]);
                    y4.Image = Image.FromFile(Img[0]);
                    break;
                case "1391":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[9]);
                    y4.Image = Image.FromFile(Img[1]);
                    break;
                case "1392":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[9]);
                    y4.Image = Image.FromFile(Img[2]);
                    break;
                case "1393":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[9]);
                    y4.Image = Image.FromFile(Img[3]);
                    break;
                case "1394":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[9]);
                    y4.Image = Image.FromFile(Img[4]);
                    break;
                case "1395":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[9]);
                    y4.Image = Image.FromFile(Img[5]);
                    break;
                case "1396":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[9]);
                    y4.Image = Image.FromFile(Img[6]);
                    break;
                case "1397":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[9]);
                    y4.Image = Image.FromFile(Img[7]);
                    break;
                case "1398":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[9]);
                    y4.Image = Image.FromFile(Img[8]);
                    break;
                case "1399":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[3]);
                    y3.Image = Image.FromFile(Img[9]);
                    y4.Image = Image.FromFile(Img[9]);
                    break;
                case "1400":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[0]);
                    y4.Image = Image.FromFile(Img[0]);
                    break;
                case "1401":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[0]);
                    y4.Image = Image.FromFile(Img[1]);
                    break;
                case "1402":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[0]);
                    y4.Image = Image.FromFile(Img[2]);
                    break;
                case "1403":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[0]);
                    y4.Image = Image.FromFile(Img[3]);
                    break;
                case "1404":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[0]);
                    y4.Image = Image.FromFile(Img[4]);
                    break;
                case "1405":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[0]);
                    y4.Image = Image.FromFile(Img[5]);
                    break;
                case "1406":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[0]);
                    y4.Image = Image.FromFile(Img[6]);
                    break;
                case "1407":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[0]);
                    y4.Image = Image.FromFile(Img[7]);
                    break;
                case "1408":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[0]);
                    y4.Image = Image.FromFile(Img[8]);
                    break;
                case "1409":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[0]);
                    y4.Image = Image.FromFile(Img[9]);
                    break;
                case "1410":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[1]);
                    y4.Image = Image.FromFile(Img[0]);
                    break;
                case "1411":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[1]);
                    y4.Image = Image.FromFile(Img[1]);
                    break;
                case "1412":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[1]);
                    y4.Image = Image.FromFile(Img[2]);
                    break;
                case "1413":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[1]);
                    y4.Image = Image.FromFile(Img[3]);
                    break;
                case "1414":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[1]);
                    y4.Image = Image.FromFile(Img[4]);
                    break;
                case "1415":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[1]);
                    y4.Image = Image.FromFile(Img[5]);
                    break;
                case "1416":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[1]);
                    y4.Image = Image.FromFile(Img[6]);
                    break;
                case "1417":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[1]);
                    y4.Image = Image.FromFile(Img[7]);
                    break;
                case "1418":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[1]);
                    y4.Image = Image.FromFile(Img[8]);
                    break;
                case "1419":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[1]);
                    y4.Image = Image.FromFile(Img[9]);
                    break;
                case "1420":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[2]);
                    y4.Image = Image.FromFile(Img[0]);
                    break;
                case "1421":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[2]);
                    y4.Image = Image.FromFile(Img[1]);
                    break;
                case "1422":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[2]);
                    y4.Image = Image.FromFile(Img[2]);
                    break;
                case "1423":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[2]);
                    y4.Image = Image.FromFile(Img[3]);
                    break;
                case "1424":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[2]);
                    y4.Image = Image.FromFile(Img[4]);
                    break;
                case "1425":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[2]);
                    y4.Image = Image.FromFile(Img[5]);
                    break;
                case "1426":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[2]);
                    y4.Image = Image.FromFile(Img[6]);
                    break;
                case "1427":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[2]);
                    y4.Image = Image.FromFile(Img[7]);
                    break;
                case "1428":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[2]);
                    y4.Image = Image.FromFile(Img[8]);
                    break;
                case "1429":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[2]);
                    y4.Image = Image.FromFile(Img[9]);
                    break;
                case "1430":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[3]);
                    y4.Image = Image.FromFile(Img[0]);
                    break;
                case "1431":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[3]);
                    y4.Image = Image.FromFile(Img[1]);
                    break;
                case "1432":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[3]);
                    y4.Image = Image.FromFile(Img[2]);
                    break;
                case "1433":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[3]);
                    y4.Image = Image.FromFile(Img[3]);
                    break;
                case "1434":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[3]);
                    y4.Image = Image.FromFile(Img[4]);
                    break;
                case "1435":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[3]);
                    y4.Image = Image.FromFile(Img[5]);
                    break;
                case "1436":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[3]);
                    y4.Image = Image.FromFile(Img[6]);
                    break;
                case "1437":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[3]);
                    y4.Image = Image.FromFile(Img[7]);
                    break;
                case "1438":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[3]);
                    y4.Image = Image.FromFile(Img[8]);
                    break;
                case "1439":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[3]);
                    y4.Image = Image.FromFile(Img[9]);
                    break;
                case "1440":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[4]);
                    y4.Image = Image.FromFile(Img[0]);
                    break;
                case "1441":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[4]);
                    y4.Image = Image.FromFile(Img[1]);
                    break;
                case "1442":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[4]);
                    y4.Image = Image.FromFile(Img[2]);
                    break;
                case "1443":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[4]);
                    y4.Image = Image.FromFile(Img[3]);
                    break;
                case "1444":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[4]);
                    y4.Image = Image.FromFile(Img[4]);
                    break;
                case "1445":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[4]);
                    y4.Image = Image.FromFile(Img[5]);
                    break;
                case "1446":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[4]);
                    y4.Image = Image.FromFile(Img[6]);
                    break;
                case "1447":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[4]);
                    y4.Image = Image.FromFile(Img[7]);
                    break;
                case "1448":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[4]);
                    y4.Image = Image.FromFile(Img[8]);
                    break;
                case "1449":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[4]);
                    y4.Image = Image.FromFile(Img[9]);
                    break;
                case "1450":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[5]);
                    y4.Image = Image.FromFile(Img[0]);
                    break;
                case "1451":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[5]);
                    y4.Image = Image.FromFile(Img[1]);
                    break;
                case "1452":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[5]);
                    y4.Image = Image.FromFile(Img[2]);
                    break;
                case "1453":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[5]);
                    y4.Image = Image.FromFile(Img[3]);
                    break;
                case "1454":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[5]);
                    y4.Image = Image.FromFile(Img[4]);
                    break;
                case "1455":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[5]);
                    y4.Image = Image.FromFile(Img[5]);
                    break;
                case "1456":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[5]);
                    y4.Image = Image.FromFile(Img[6]);
                    break;
                case "1457":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[5]);
                    y4.Image = Image.FromFile(Img[7]);
                    break;
                case "1458":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[5]);
                    y4.Image = Image.FromFile(Img[8]);
                    break;
                case "1459":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[5]);
                    y4.Image = Image.FromFile(Img[9]);
                    break;
                case "1460":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[6]);
                    y4.Image = Image.FromFile(Img[0]);
                    break;
                case "1461":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[6]);
                    y4.Image = Image.FromFile(Img[1]);
                    break;
                case "1462":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[6]);
                    y4.Image = Image.FromFile(Img[2]);
                    break;
                case "1463":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[6]);
                    y4.Image = Image.FromFile(Img[3]);
                    break;
                case "1464":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[6]);
                    y4.Image = Image.FromFile(Img[4]);
                    break;
                case "1465":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[6]);
                    y4.Image = Image.FromFile(Img[4]);
                    break;
                case "1466":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[6]);
                    y4.Image = Image.FromFile(Img[6]);
                    break;
                case "1467":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[6]);
                    y4.Image = Image.FromFile(Img[7]);
                    break;
                case "1468":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[6]);
                    y4.Image = Image.FromFile(Img[8]);
                    break;
                case "1469":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[6]);
                    y4.Image = Image.FromFile(Img[9]);
                    break;
                case "1470":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[7]);
                    y4.Image = Image.FromFile(Img[0]);
                    break;
                case "1471":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[7]);
                    y4.Image = Image.FromFile(Img[1]);
                    break;
                case "1472":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[7]);
                    y4.Image = Image.FromFile(Img[2]);
                    break;
                case "1473":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[7]);
                    y4.Image = Image.FromFile(Img[3]);
                    break;
                case "1474":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[7]);
                    y4.Image = Image.FromFile(Img[4]);
                    break;
                case "1475":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[7]);
                    y4.Image = Image.FromFile(Img[5]);
                    break;
                case "1476":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[7]);
                    y4.Image = Image.FromFile(Img[6]);
                    break;
                case "1477":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[7]);
                    y4.Image = Image.FromFile(Img[7]);
                    break;
                case "1478":
                    y1.Image = Image.FromFile(Img[1]);
                    y2.Image = Image.FromFile(Img[4]);
                    y3.Image = Image.FromFile(Img[7]);
                    y4.Image = Image.FromFile(Img[8]);
                    break;
            }
            //-------------------------------------------

            //This Code For Month.
            switch (Month)
            {
                case "1":
                    m1.Image = Image.FromFile(Img[0]);
                    m2.Image = Image.FromFile(Img[1]);
                    break;
                case "2":
                    m1.Image = Image.FromFile(Img[0]);
                    m2.Image = Image.FromFile(Img[2]);
                    break;
                case "3":
                    m1.Image = Image.FromFile(Img[0]);
                    m2.Image = Image.FromFile(Img[3]);
                    break;
                case "4":
                    m1.Image = Image.FromFile(Img[0]);
                    m2.Image = Image.FromFile(Img[4]);
                    break;
                case "5":
                    m1.Image = Image.FromFile(Img[0]);
                    m2.Image = Image.FromFile(Img[5]);
                    break;
                case "6":
                    m1.Image = Image.FromFile(Img[0]);
                    m2.Image = Image.FromFile(Img[6]);
                    break;
                case "7":
                    m1.Image = Image.FromFile(Img[0]);
                    m2.Image = Image.FromFile(Img[7]);
                    break;
                case "8":
                    m1.Image = Image.FromFile(Img[0]);
                    m2.Image = Image.FromFile(Img[8]);
                    break;
                case "9":
                    m1.Image = Image.FromFile(Img[0]);
                    m2.Image = Image.FromFile(Img[9]);
                    break;
                case "10":
                    m1.Image = Image.FromFile(Img[1]);
                    m2.Image = Image.FromFile(Img[0]);
                    break;
                case "11":
                    m1.Image = Image.FromFile(Img[1]);
                    m2.Image = Image.FromFile(Img[1]);
                    break;
                case "12":
                    m1.Image = Image.FromFile(Img[1]);
                    m2.Image = Image.FromFile(Img[2]);
                    break;
            }
            //-------------------------------------------

            //This Code For Day.
            switch (Day)
            {
                case "1":
                    d1.Image = Image.FromFile(Img[0]);
                    d2.Image = Image.FromFile(Img[1]);
                    break;
                case "2":
                    d1.Image = Image.FromFile(Img[0]);
                    d2.Image = Image.FromFile(Img[2]);
                    break;
                case "3":
                    d1.Image = Image.FromFile(Img[0]);
                    d2.Image = Image.FromFile(Img[3]);
                    break;
                case "4":
                    d1.Image = Image.FromFile(Img[0]);
                    d2.Image = Image.FromFile(Img[4]);
                    break;
                case "5":
                    d1.Image = Image.FromFile(Img[0]);
                    d2.Image = Image.FromFile(Img[5]);
                    break;
                case "6":
                    d1.Image = Image.FromFile(Img[0]);
                    d2.Image = Image.FromFile(Img[6]);
                    break;
                case "7":
                    d1.Image = Image.FromFile(Img[0]);
                    d2.Image = Image.FromFile(Img[7]);
                    break;
                case "8":
                    d1.Image = Image.FromFile(Img[0]);
                    d2.Image = Image.FromFile(Img[8]);
                    break;
                case "9":
                    d1.Image = Image.FromFile(Img[0]);
                    d2.Image = Image.FromFile(Img[9]);
                    break;
                case "10":
                    d1.Image = Image.FromFile(Img[1]);
                    d2.Image = Image.FromFile(Img[0]);
                    break;
                case "11":
                    d1.Image = Image.FromFile(Img[1]);
                    d2.Image = Image.FromFile(Img[1]);
                    break;
                case "12":
                    d1.Image = Image.FromFile(Img[1]);
                    d2.Image = Image.FromFile(Img[2]);
                    break;
                case "13":
                    d1.Image = Image.FromFile(Img[1]);
                    d2.Image = Image.FromFile(Img[3]);
                    break;
                case "14":
                    d1.Image = Image.FromFile(Img[1]);
                    d2.Image = Image.FromFile(Img[4]);
                    break;
                case "15":
                    d1.Image = Image.FromFile(Img[1]);
                    d2.Image = Image.FromFile(Img[5]);
                    break;
                case "16":
                    d1.Image = Image.FromFile(Img[1]);
                    d2.Image = Image.FromFile(Img[6]);
                    break;
                case "17":
                    d1.Image = Image.FromFile(Img[1]);
                    d2.Image = Image.FromFile(Img[7]);
                    break;
                case "18":
                    d1.Image = Image.FromFile(Img[1]);
                    d2.Image = Image.FromFile(Img[8]);
                    break;
                case "19":
                    d1.Image = Image.FromFile(Img[1]);
                    d2.Image = Image.FromFile(Img[9]);
                    break;
                case "20":
                    d1.Image = Image.FromFile(Img[2]);
                    d2.Image = Image.FromFile(Img[0]);
                    break;
                case "21":
                    d1.Image = Image.FromFile(Img[2]);
                    d2.Image = Image.FromFile(Img[1]);
                    break;
                case "22":
                    d1.Image = Image.FromFile(Img[2]);
                    d2.Image = Image.FromFile(Img[2]);
                    break;
                case "23":
                    d1.Image = Image.FromFile(Img[2]);
                    d2.Image = Image.FromFile(Img[3]);
                    break;
                case "24":
                    d1.Image = Image.FromFile(Img[2]);
                    d2.Image = Image.FromFile(Img[4]);
                    break;
                case "25":
                    d1.Image = Image.FromFile(Img[2]);
                    d2.Image = Image.FromFile(Img[5]);
                    break;
                case "26":
                    d1.Image = Image.FromFile(Img[2]);
                    d2.Image = Image.FromFile(Img[6]);
                    break;
                case "27":
                    d1.Image = Image.FromFile(Img[2]);
                    d2.Image = Image.FromFile(Img[7]);
                    break;
                case "28":
                    d1.Image = Image.FromFile(Img[2]);
                    d2.Image = Image.FromFile(Img[8]);
                    break;
                case "29":
                    d1.Image = Image.FromFile(Img[2]);
                    d2.Image = Image.FromFile(Img[9]);
                    break;
                case "30":
                    d1.Image = Image.FromFile(Img[3]);
                    d2.Image = Image.FromFile(Img[0]);
                    break;
                case "31":
                    d1.Image = Image.FromFile(Img[3]);
                    d2.Image = Image.FromFile(Img[1]);
                    break;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show ("Pogrammer : Alireza Zare " + "\n" + "Y-Mail : alireza_2297@yahoo.com" + "\n" + "G-Mail : jacksmith354@yahoo.com" + "\n" + "Web : www.ali-virus.blogfa.com","Information : ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Persian_Date();
        }


    }
}

       
    
    



