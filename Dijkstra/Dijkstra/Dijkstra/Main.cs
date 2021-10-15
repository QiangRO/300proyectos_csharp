using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using System.Drawing.Drawing2D;


namespace Dijkstra
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }       

        struct NodeStructure
        {
            public int NodeName;
            public Point Point;
        }
        struct JoinStructure
        {
            public int source;
            public int destination;
            public int joinLenght;
            public bool selected;
        }


        NodeStructure srcNode;
        ArrayList NodeList = new ArrayList();
        ArrayList JointList = new ArrayList();
        int startNode = -1, endNode = -1;
        
        private void processBtn_Click(object sender, EventArgs e)
        {
            string ErrText = JointList.Count == 0 ? "!...مسیری بین گره ها وجود ندارد" : startNode == -1 ? ".نقطه شروع مسیر مشخص نشده است" : endNode == -1 ? ".نقطه پایان مسیر مشخص نشده است" : null;
            if (JointList.Count == 0 || startNode==-1 || endNode==-1)
            {
                MessageBox.Show(ErrText, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
             
            int n = NodeList.Count;
            float[] distance = new float[n], previous = new float[n];
            float[,] graph = new float[n, n];
             
            for (int i = 0; i <n; i++)
                for (int j = 0; j < n; j++)
                    if (i == j) graph[i, j] = 0; else graph[i, j] = float.PositiveInfinity;
            for (int i = 0; i < JointList.Count; i++)
                graph[((JoinStructure)JointList[i]).source, ((JoinStructure)JointList[i]).destination] = ((JoinStructure)JointList[i]).joinLenght;
            for (int i = 0; i < n; i++)
                previous[i] = -1;   
            for (int i = 0; i < n; i++)
                distance[i] = graph[startNode, i];
            do
            {
                int min = -1;
                for (int j = 0; j < n; j++)
                {
                    if (min != -1)
                    {
                        if (distance[j] < distance[min] && distance[j]!=-1) min = j;
                    }
                    else
                        if (distance[j]!=-1 && distance[j] != 0)
                            min = j;
                }
                if (min == -1) break;                
                for (int j = 0; j < n; j++)
                {
                    if (distance[min] + graph[min, j] < distance[j])
                    {
                        distance[j] = distance[min] + graph[min, j];
                        previous[j] = min;
                    }
                }
                distance[min] = -1;
            }
            while (true);

            DrawPath();
            DikjstraPath(previous, endNode, (int)previous[endNode]);
            DrawAllNode();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            srcNode.NodeName = -1;
            DrawPath();
            this.Cursor = Cursors.Hand;
        }

        private void DikjstraPath(float[] path, int src, int dest)
        {
            if (dest == -1)
            {
                if (RecognizeJoint(startNode, src))
                    DrawNearestPath(((NodeStructure)NodeList[startNode]).Point, ((NodeStructure)NodeList[src]).Point);
            }
            else
            {
                DrawNearestPath(((NodeStructure)NodeList[src]).Point, ((NodeStructure)NodeList[dest]).Point);
                DikjstraPath(path, dest, (int)path[dest]);
            }                
        }

        void DrawNearestPath(Point src, Point dest)
        {
            Bitmap bmp = new Bitmap(graphBoardPB.Image);
            Graphics gph = Graphics.FromImage(bmp);
            gph.SmoothingMode = SmoothingMode.AntiAlias;
            gph.DrawLine(new Pen(Brushes.Gold, 5), src, dest);
            graphBoardPB.Image = bmp;
        }        

        private void DrawNode(string nodeTxt, Point point, Brush TextColor, Brush BackColor)
        {
            Bitmap bmp = new Bitmap(graphBoardPB.Image);
            Graphics gph = Graphics.FromImage(bmp);
            gph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gph.FillPie(BackColor, new Rectangle(point.X - 10, point.Y - 10, 20, 20), 0, 360);
            gph.DrawArc(new Pen(TextColor), new Rectangle(point.X - 10, point.Y - 10, 20, 20), 0, 360);
            gph.DrawString(nodeTxt, new Font("tahoma", 8, FontStyle.Bold), TextColor, new PointF(point.X - (gph.MeasureString(nodeTxt, new Font("tahoma", 8, FontStyle.Bold)).Width) / 2, point.Y - 6));
            graphBoardPB.Image = bmp;
        }

        private void DrawPath()
        {
            Bitmap bmp = new Bitmap(graphBoardPB.Width, graphBoardPB.Height);
            Graphics gph = Graphics.FromImage(bmp);
            gph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gph.FillRectangle(Brushes.SkyBlue, new Rectangle(0, 0, bmp.Width, bmp.Height));
            for (int i = 0; i < JointList.Count; i++)
            {
                Point srcPoint = ((NodeStructure)NodeList[((JoinStructure)JointList[i]).source]).Point, destPoint = ((NodeStructure)NodeList[((JoinStructure)JointList[i]).destination]).Point;
                LinearGradientBrush gBrushe = new LinearGradientBrush(srcPoint, destPoint, Color.Transparent, Color.Black);
                gph.DrawLine(new Pen(gBrushe, 1), srcPoint, destPoint);
                gph.DrawString(((JoinStructure)JointList[i]).joinLenght.ToString(), new Font("tahoma", 6, FontStyle.Bold), Brushes.Black, new PointF((Math.Max(srcPoint.X, destPoint.X) + Math.Min(srcPoint.X, destPoint.X)) / 2, (Math.Max(srcPoint.Y, destPoint.Y) + Math.Min(srcPoint.Y, destPoint.Y)) / 2));
                Application.DoEvents();
            }           
            graphBoardPB.Image = bmp;
            DrawAllNode();            
        }

        private void DrawAllNode()
        {
            for (int i = 0; i < NodeList.Count; i++)
            {
                Brush brush = i == startNode || i == endNode ? Brushes.Gold : Brushes.WhiteSmoke;
                DrawNode(((NodeStructure)NodeList[i]).NodeName.ToString(), ((NodeStructure)NodeList[i]).Point, Brushes.Black, brush);
            }
        }
       
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void graphBoardPB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (graphBoardPB.Cursor == Cursors.Cross)
                {
                    DrawNode(NodeList.Count.ToString(), e.Location, Brushes.Black, Brushes.WhiteSmoke);
                    NodeStructure Node = new NodeStructure();
                    Node.NodeName = NodeList.Count;
                    Node.Point = new Point(e.X, e.Y);
                    NodeList.Add(Node);
                }
                else
                    MessageBox.Show(".در این ناحیه گره دیگری وجود دارد و امکان ایجاد گره جدید وجود ندارد", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void graphBoardPB_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NodeStructure destNode = RecognizeNode(e.X, e.Y);
                if (destNode.NodeName != -1)
                    if (srcNode.NodeName == -1)
                    {
                        srcNode = destNode;
                        DrawNode(srcNode.NodeName.ToString(), srcNode.Point, Brushes.Black, Brushes.LightGray);
                    }
                    else
                    {
                        string ErrText = destNode.Point == srcNode.Point ? "!...امکان ایجاد دور وجود ندارد" : RecognizeJoint(srcNode.NodeName, destNode.NodeName) ? ".این اتصال قبلا ایجاد شده است و امکان برقراری مجدد آن وجود ندارد" : null;
                        if (destNode.Point != srcNode.Point && !RecognizeJoint(srcNode.NodeName, destNode.NodeName))
                        {
                            JoinStructure join = new JoinStructure();
                            join.source = srcNode.NodeName;
                            join.destination = destNode.NodeName;
                            join.joinLenght = (int)Math.Sqrt(Math.Pow(srcNode.Point.X - destNode.Point.X, 2) + Math.Pow(srcNode.Point.Y - destNode.Point.Y, 2));
                            join.selected = false;
                            JointList.Add(join);
                            DrawPath();
                            srcNode.NodeName = -1;
                        }
                        else
                        {
                            MessageBox.Show(ErrText, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                            srcNode.NodeName = -1;
                            DrawPath();
                        }
                    }
            }
            else if (e.Button == MouseButtons.Right)
            {
                NodeStructure destNode = RecognizeNode(e.X, e.Y);
                if (destNode.NodeName != -1)
                {
                    if (destNode.NodeName != startNode)
                    {
                        if (startNode == -1)
                            startNode = destNode.NodeName;
                        else
                            endNode = destNode.NodeName;
                    }
                    else
                        MessageBox.Show("!...نقاط شروع و پایان نمی توانند یکسان باشند", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
                else
                    startNode = endNode = -1;
                DrawPath();
            }            
        }

        private bool RecognizeJoint(int src, int dest)
        {
            for (int i = 0; i < JointList.Count; i++)
                if (((JoinStructure)JointList[i]).source == src && ((JoinStructure)JointList[i]).destination == dest) return true;
            return false;
        }

        private NodeStructure RecognizeNode(int X, int Y)
        {
            for (int i = 0; i < NodeList.Count; i++)
                if (X >= ((NodeStructure)NodeList[i]).Point.X-10 && X <= ((NodeStructure)NodeList[i]).Point.X + 10 && Y >= ((NodeStructure)NodeList[i]).Point.Y-10 && Y <= ((NodeStructure)NodeList[i]).Point.Y + 10)
                    return (NodeStructure)NodeList[i];
            NodeStructure nullNode = new NodeStructure();
            nullNode.NodeName = -1;
            return nullNode;
        }

        private void graphBoardPB_MouseMove(object sender, MouseEventArgs e)
        {
            if (RecognizeNode(e.X, e.Y).NodeName != -1)
                graphBoardPB.Cursor = Cursors.Hand;
            else
                graphBoardPB.Cursor = Cursors.Cross;
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    processBtn_Click(processBtn, new EventArgs());
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }
    }
}