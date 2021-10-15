using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OWC11;

namespace MicrosoftOfficeChart11_Example
{
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {

            #region ChartSpace1

            //The ChartLayout property says that the Charts shows in Horizontal, Vertical or Automatic position in the ChartSpace
            ChartSpace1.ChartLayout = ChartChartLayoutEnum.chChartLayoutHorizontal;

            //The Size of the ChartSpace to become a constant value and don't change
            ChartSpace1.Size = new Size(500, 300);
            ChartSpace1.Location = new Point(8, 8);

            //Trying to set the ChartSpace Title
            ChartSpace1.HasChartSpaceTitle = true;
            ChartSpace1.ChartSpaceTitle.Caption = "ChartSpace1";

            #region Chart[0]

            //Adding a Chart to the ChartSpace
            ChartSpace1.Charts.Add(0);

            //Chossing a ChartType
            ChartSpace1.Charts[0].Type = ChartChartTypeEnum.chChartTypeColumnClustered;

            //Adding a Series to to our Chart
            ChartSpace1.Charts[0].SeriesCollection.Add(0);

            //Caption of a Series shown in the Legend of the Chart
            ChartSpace1.Charts[0].SeriesCollection[0].Caption = "1385";

            //Setting(Sending) data to our Series by using SetData Method.
            //By ChartDimensionsEnum we say that which values type we sent:Catagories or Values or ...
            //Realy I don't know what is the meaning of:(int)(ChartSpecialDataSourcesEnum.chDataLiteral)
            //Then the STRING of our values, in which a TAB is between our values.
            ChartSpace1.Charts[0].SeriesCollection[0].SetData(ChartDimensionsEnum.chDimCategories, (int)(ChartSpecialDataSourcesEnum.chDataLiteral), "First\tSecond\tThird");
            ChartSpace1.Charts[0].SeriesCollection[0].SetData(ChartDimensionsEnum.chDimValues, (int)(ChartSpecialDataSourcesEnum.chDataLiteral), "10\t20\t100");

            ChartSpace1.Charts[0].SeriesCollection.Add(1);
            ChartSpace1.Charts[0].SeriesCollection[1].Caption = "1386";
            ChartSpace1.Charts[0].SeriesCollection[1].SetData(ChartDimensionsEnum.chDimValues, (int)(ChartSpecialDataSourcesEnum.chDataLiteral), "15\t23\t121");

            //Adding the Labels of a DataValue in the Series. It shows the value on the chart.
            ChartSpace1.Charts[0].SeriesCollection[0].DataLabelsCollection.Add();

            //Also shows the Percentage in the Series if we set the HasPercentage to true
            ChartSpace1.Charts[0].SeriesCollection[0].DataLabelsCollection[0].HasPercentage = true;

            //Show the Values in the Series.
            ///ChartSpace1.Charts[0].SeriesCollection[0].DataLabelsCollection[0].HasValue = true;
            ///
            //The Separator of Value and Percentage
            ChartSpace1.Charts[0].SeriesCollection[0].DataLabelsCollection[0].Separator = " , ";

            //Bold the DataLabelCollection Font
            ChartSpace1.Charts[0].SeriesCollection[0].DataLabelsCollection[0].Font.Bold = true;
            
            //the Chart at first has not Legend, we change the HasLegend property to true
            ChartSpace1.Charts[0].HasLegend = true;

            //the Position of the Legend
            ChartSpace1.Charts[0].Legend.Position = ChartLegendPositionEnum.chLegendPositionTop;

            //Trying to set the Chart Title
            ChartSpace1.Charts[0].HasTitle = true;
            ChartSpace1.Charts[0].Title.Caption = "Chart[0]";


            #endregion

            #region Chart[1]
            //Adding a new Chart to the ChartSpace. The Index of this Chart set as 1. Setting the Index instead of 1 is a run-time error
            ChartSpace1.Charts.Add(1);
            ChartSpace1.Charts[1].SeriesCollection.Add(0);

            
            ChartSpace1.Charts[1].Type = ChartChartTypeEnum.chChartTypeScatterMarkers;
            ChartSpace1.Charts[1].SeriesCollection[0].SetData(ChartDimensionsEnum.chDimXValues, (int)(ChartSpecialDataSourcesEnum.chDataLiteral), "1.2\t6.5\t7.6");
            ChartSpace1.Charts[1].SeriesCollection[0].SetData(ChartDimensionsEnum.chDimYValues, (int)(ChartSpecialDataSourcesEnum.chDataLiteral), "5.2\t12.5\t22.3");

            //In below codes we change the horizontal(x) Axis to the Logarithmic Scale and also change the Orientaion from Max to Min values
            ChScaling[] scale = new ChScaling[1];
            scale[0] = ChartSpace1.Charts[1].get_Scalings(ChartDimensionsEnum.chDimXValues);
            scale[0].Type = ChartScaleTypeEnum.chScaleTypeLogarithmic;
            scale[0].Orientation = ChartScaleOrientationEnum.chScaleOrientationMaxMin;
            ///ChartSpace1.Charts[1].Axes.Add(scale[0]).Position = ChartAxisPositionEnum.chAxisPositionTop;

            ChartSpace1.Charts[1].HasTitle = true;
            ChartSpace1.Charts[1].Title.Caption = "Chart[1]";

            #endregion

            #endregion

            #region ChartSpace2

            ChartSpace2.Charts.Add(0);
            ChartSpace2.Charts[0].Type = ChartChartTypeEnum.chChartTypeScatterLine;

            string xValues = "",
                sinValues = "",
                cosValues = "";

            //Generating our set of data into strings to pass them to the SetData method
            for (double x = -2 * Math.PI; x <= 2 * Math.PI; x = x + 0.01)
            {
                xValues += x + "\t";
                sinValues += Math.Sin(x) + "\t";
                cosValues += Math.Cos(x) + "\t";

            }


            ChartSpace2.Charts[0].SeriesCollection.Add(0);
            ChartSpace2.Charts[0].SeriesCollection[0].SetData(ChartDimensionsEnum.chDimXValues, (int)(ChartSpecialDataSourcesEnum.chDataLiteral), xValues);
            ChartSpace2.Charts[0].SeriesCollection[0].SetData(ChartDimensionsEnum.chDimYValues, (int)(ChartSpecialDataSourcesEnum.chDataLiteral), sinValues);
            ChartSpace2.Charts[0].SeriesCollection[0].Caption = "y=sin(x)";

            ChartSpace2.Charts[0].SeriesCollection.Add(1);
            ChartSpace2.Charts[0].SeriesCollection[1].SetData(ChartDimensionsEnum.chDimXValues, (int)(ChartSpecialDataSourcesEnum.chDataLiteral), xValues);
            ChartSpace2.Charts[0].SeriesCollection[1].SetData(ChartDimensionsEnum.chDimYValues, (int)(ChartSpecialDataSourcesEnum.chDataLiteral), cosValues);
            ChartSpace2.Charts[0].SeriesCollection[1].Caption = "y=cos(x)";


            ChartSpace2.Charts[0].HasLegend = true;
            ChartSpace2.Charts[0].Legend.Position = ChartLegendPositionEnum.chLegendPositionTop;

            #endregion

            #region ChartSpace3

            ChartSpace3.Size = new Size(500, 300);
            ChartSpace3.Charts.Add(0);
            ChartSpace3.Charts[0].Type = ChartChartTypeEnum.chChartTypeScatterMarkers;
            ChartSpace3.Charts[0].SeriesCollection.Add(0);
            ChartSpace3.Charts[0].SeriesCollection[0].Caption = "Data Points";
            ChartSpace3.Charts[0].SeriesCollection[0].SetData(ChartDimensionsEnum.chDimXValues, (int)(ChartSpecialDataSourcesEnum.chDataLiteral), "1.3\t2.4\t5.6\t6.3\t8.4");
            ChartSpace3.Charts[0].SeriesCollection[0].SetData(ChartDimensionsEnum.chDimYValues, (int)(ChartSpecialDataSourcesEnum.chDataLiteral), "6.4\t10\t15\t20\t24");

            //The Marker of any Series can be set by changing its Style and Size
            ChartSpace3.Charts[0].SeriesCollection[0].Marker.Style = ChartMarkerStyleEnum.chMarkerStyleCircle;
            ChartSpace3.Charts[0].SeriesCollection[0].Marker.Size = 8;

            //Working with the Trendline of a Series. Order is the order of the polynomial in these codes.
            ChartSpace3.Charts[0].SeriesCollection[0].Trendlines.Add();
            ChartSpace3.Charts[0].SeriesCollection[0].Trendlines[0].Type = ChartTrendlineTypeEnum.chTrendlineTypePolynomial;
            ChartSpace3.Charts[0].SeriesCollection[0].Trendlines[0].Order = 4;
            ChartSpace3.Charts[0].SeriesCollection[0].Trendlines[0].Caption = "Polynomial Trendline";
            ChartSpace3.Charts[0].SeriesCollection[0].Trendlines[0].Line.DashStyle = ChartLineDashStyleEnum.chLineDash;
            ChartSpace3.Charts[0].SeriesCollection[0].Trendlines[0].DataLabel.Font.Italic = true;
            ChartSpace3.Charts[0].SeriesCollection[0].Trendlines[0].DataLabel.Font.Bold = true;
            ChartSpace3.Charts[0].SeriesCollection[0].Trendlines[0].DataLabel.Font.Size = 10;

            //Working with the Color of each property:
            ChartSpace3.Border.Color = (object)("#0000FF");
            ChartSpace3.Interior.Color = (object)("#F0F8FF");
            ChartSpace3.Charts[0].PlotArea.Interior.Color = (object)("#ffffff");
            ChartSpace3.Charts[0].SeriesCollection[0].Interior.Color = (object)("#800000");
            ChartSpace3.Charts[0].SeriesCollection[0].Trendlines[0].Line.Color = (object)("#006400");


            ChartSpace3.Charts[0].HasLegend = true;
            ChartSpace3.Charts[0].Legend.Position = ChartLegendPositionEnum.chLegendPositionTop;

            #endregion

        }
    }
}