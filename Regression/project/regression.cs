using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace project
{
    class regression : matrix
    {
        private short flagIO;
        private float[] Input_Array = new float[50];
        private float[] Output_Array = new float[50];
        public float[,] Beta = new float[5,5];
        private int Num;
        private int Set_Array(int n)
        {
            if (Num == 0 || Num == n)
                return 1;
            return 0;
        }
        public void SetflagIO(string f)
        {
            if (f == "i")
                flagIO = 1;
            else if (f == "o")
                flagIO = 0;
        }
        public short get_Input(float[] x, int n)
        {
            int i;
            if (Set_Array(n) == 1)
            {
                for (i = 0; i < n; i++)
                {
                    Input_Array[i] = x[i];
                }
                Num = n;
                return 1;
            }
            return 0;
        }
        public short get_Output(float[] y, int n)
        {
            int i;
            if (Set_Array(n) == 1)
            {
                for (i = 0; i < n; i++)
                {
                    Output_Array[i] = y[i];
                }
                Num = n;
                return 1;
            }
            return 0;
        }
        public float[] show_input()
        {
            return Input_Array;
        }
        public float[] show_output()
        {
            return Output_Array;
        }
        public string linear()
        {
            int i;
            float[,] x = new float[Num, 2];
            float[,] xt = new float[2, Num];
            float[,] y = new float[Num, 1];
            float[,] temp1 = new float[2, 2];
            float[,] temp2 = new float[2, 1];
            float[,] inver = new float[2, 2];
            for (i = 0; i < Num; i++)
            {
                x[i, 0] = 1;
                x[i, 1] = Input_Array[i];
                y[i, 0] = Output_Array[i];
            }
            xt = Transpose(x, Num, 2);
            temp1 = MatrixMultiple(xt, x, 2, Num, 2);
            temp2 = MatrixMultiple(xt, y, 2, Num, 1);
            inver = Invers(temp1, 2, 2);
            Beta = MatrixMultiple(inver, temp2, 2, 2, 1);
            string st;
            st = "y=";
            if (Beta[0, 0] != 0)
            {
                st = st + Beta[0, 0];
            }
            if (Beta[1, 0] == 1)
                st = st + "+x";
            else if (Beta[1, 0] < 0)
            {
                st = st + Beta[1, 0];
                st = st + "x";
            }
            else
                st = st + "+" + Beta[1, 0] + "x";
            return st;
        }
        public string quadratic()
        {
            int i;
            float[,] x = new float[Num, 3];
            float[,] xt = new float[3, Num];
            float[,] y = new float[Num, 1];
            float[,] temp1 = new float[3, 3];
            float[,] temp2 = new float[3, 1];
            float[,] inver = new float[3, 3];
            for (i = 0; i < Num; i++)
            {
                x[i, 0] = 1;
                x[i, 1] = Input_Array[i];
                x[i, 2] = Input_Array[i] * Input_Array[i];
                y[i, 0] = Output_Array[i];
            }

            xt = Transpose(x, Num, 3);
            temp1 = MatrixMultiple(xt, x, 3, Num, 3);
            temp2 = MatrixMultiple(xt, y, 3, Num, 1);
            inver = Invers(temp1, 3, 3);
            Beta = MatrixMultiple(inver, temp2, 3, 3, 1);
            string st1;
            st1 = "y=";
            if (Beta[0, 0] != 0)
            {
                st1 = st1 + Beta[0, 0];
            }
            if (Beta[1, 0] == 1)
                st1 = st1 + "+x";
            else if (Beta[1, 0] < 0)
            {
                st1 = st1 + Beta[1, 0];
                st1 = st1 + "x";
            }
            else if (Beta[1, 0] > 0)
                st1 = st1 + "+" + Beta[1, 0] + "x";
            if (Beta[2, 0] == 1)
                st1 = st1 + "+x^2";
            else if (Beta[2, 0] < 0)
            {
                st1 = st1 + Beta[2, 0];
                st1 = st1 + "x^2";
            }
            else if (Beta[2, 0] > 0)
                st1 = st1 + "+" + Beta[2, 0] + "x^2";

            return st1;
        }
        public void draw(Form2 f1)
        {
            int i; float m, M, d, rate, ym, yM, yd, yrate, y1, y2, x, y;
            Graphics gg;
            Brush bb;
            Pen pp;
            PointF pt1, pt2;
            f1.Show();
            linear();
            float L =85, T = 60, W = 500, H = 400, E = 20;
            float e = E / 2;
            int sct = 10, Srate;// ⁄œ«œ  ﬁ”Ì„ »‰œÌ Â«: Sector
            gg = f1.CreateGraphics();
            bb = new SolidBrush(Color.Blue);
            pp = new Pen(bb);
            gg.DrawRectangle(pp, L, T, W + E, H + E);
            bb = new SolidBrush(Color.Black);
            pp = new Pen(bb);
            m = minimum(Input_Array, Num);
            M = maximum(Input_Array, Num);
            d = M - m;
            rate = W / d;
            y1 = m * Beta[1, 0] + Beta[0, 0];
            y2 = M * Beta[1, 0] + Beta[0, 0];
            ym = minimum(Output_Array, Num);
            yM = maximum(Output_Array, Num);
            if (y1 < ym)
                ym = y1;
            else if (y1 > yM)
                yM = y1;
            if (y2 > yM)
                yM = y2;
            else if (y2 < ym)
                ym = y2;
            yd = yM - ym;
            yrate = H / yd;
            //******************************  ﬁ”„  »‰œÌ „ÕÊ— «›ﬁÌ  ********************************
            Font ff = new Font("Arial", 11);
            pp.Width = 10;
            Srate = (int)(d / sct);
            if (Srate == 0)
                Srate = 1;
            x = (int)(((m - m) * rate) + L + e);
            y = (int)(H + T + E);
            pt1 = new PointF((float)(x), (float)(y + 3));
            pt2 = new PointF((float)(x + 1), (float)(y + 3));
            gg.DrawLine(pp, pt1, pt2);
            gg.DrawString(System.Convert.ToString((int)m), ff, bb, x - 5, y + 8);
            i = 1;
            while (m + i * Srate <= M)
            {
                x = (int)(((m + (i * Srate) - m) * rate) + L + e);
                y = (int)(H + T + E);
                pt1 = new PointF((float)(x), (float)(y + 3));
                pt2 = new PointF((float)(x + 1), (float)(y + 3));
                gg.DrawLine(pp, pt1, pt2);
                gg.DrawString(System.Convert.ToString((int)m + (i * Srate)), ff, bb, x - 5, y + 8);
                i++;
            }
            //******************************  ﬁ”„  »‰œÌ „ÕÊ— ⁄„ÊœÌ  ********************************
            pp.Width = 1;
            Srate = (int)(yd / sct);
            if (Srate == 0)
                Srate = 1;
            x = (int)L;
            y = (int)((H + T + e) - ((ym - ym) * yrate));
            pt1 = new PointF((float)(x), (float)(y));
            pt2 = new PointF((float)(x - 10), (float)(y));
            gg.DrawLine(pp, pt1, pt2);
            gg.DrawString(System.Convert.ToString((int)ym), ff, bb, x - 50, y - 10);
            i = 1;
            while (ym + i * Srate <= yM)
            {
                x = (int)L;
                y = (int)((H + T + e) - ((ym + (i * Srate) - ym) * yrate));
                pt1 = new PointF((float)(x), (float)(y));
                pt2 = new PointF((float)(x - 10), (float)(y));
                gg.DrawLine(pp, pt1, pt2);
                gg.DrawString(System.Convert.ToString((int)ym + (i * Srate)), ff, bb, x - 50, y - 10);
                i++;
            }

            //******************************  —”„ ‰ﬁ«ÿ œ— ’›ÕÂ  ********************************
            bb = new SolidBrush(Color.Red);
            pp = new Pen(bb);
            pp.Width = 4;
            for (i = 0; i < Num; i++)
            {
                pt1 = new PointF((float)(((Input_Array[i] - m) * rate) + (L - 2) + e), (float)((H + T + e) - ((Output_Array[i] - ym) * yrate)));
                pt2 = new PointF((float)(((Input_Array[i] - m) * rate) + (L + 2) + e), (float)((H + T + e) - ((Output_Array[i] - ym) * yrate)));
                gg.DrawLine(pp, pt1, pt2);
            }
            //******************************  —”„ Œÿ œ— ’›ÕÂ  ********************************
            bb = new SolidBrush(Color.Black);
            pp = new Pen(bb);
            pp.Width = 1;
            y1 = m * Beta[1, 0] + Beta[0, 0];
            y2 = M * Beta[1, 0] + Beta[0, 0];
            pt1 = new PointF((float)(((m - m) * rate) + L + e), (float)((H + T + e) - ((y1 - ym) * yrate)));
            pt2 = new PointF((float)(((M - m) * rate) + L + e), (float)((H + T + e) - ((y2 - ym) * yrate)));
            gg.DrawLine(pp, pt1, pt2);

        }
        private float minimum(float[] x, int n)
        {
            float min; int i;
            min = x[0];
            for (i = 1; i < n; i++)
                if (x[i] < min)
                    min = x[i];
            return min;
        }
        private float maximum(float[] x, int n)
        {
            float max; int i;
            max = x[0];
            for (i = 1; i < n; i++)
                if (x[i] > max)
                    max = x[i];
            return max;
        }
        public static regression operator ++(regression op1)
        {
            int i;
            if (op1.flagIO == 1)
            {
                for (i = 0; i < op1.Num; i++)
                    op1.Input_Array[i]++;
            }
            else if (op1.flagIO == 0)
            {
                for (i = 0; i < op1.Num; i++)
                    op1.Output_Array[i]++;
            }
            return op1;
        }
        public static regression operator --(regression op1)
        {
            int i;
            if (op1.flagIO == 1)
            {
                for (i = 0; i < op1.Num; i++)
                    op1.Input_Array[i]--;
            }
            else if (op1.flagIO == 0)
            {
                for (i = 0; i < op1.Num; i++)
                    op1.Output_Array[i]--;
            }
            return op1;
        }
        public static regression operator +(regression op1, float x)
        {
            int i;
            if (op1.flagIO == 1)
            {
                for (i = 0; i < op1.Num; i++)
                    op1.Input_Array[i] += x;
            }
            else if (op1.flagIO == 0)
            {
                for (i = 0; i < op1.Num; i++)
                    op1.Output_Array[i] += x;
            }
            return op1;
        }
        public static regression operator -(regression op1, float x)
        {
            int i;
            if (op1.flagIO == 1)
            {
                for (i = 0; i < op1.Num; i++)
                    op1.Input_Array[i] -= x;
            }
            else if (op1.flagIO == 0)
            {
                for (i = 0; i < op1.Num; i++)
                    op1.Output_Array[i] -= x;
            }
            return op1;
        }
         public float this[int x]
        {

            get
            {
                if (this.flagIO == 1)
                    return Input_Array[x];
                else if (this.flagIO == 0)
                    return Output_Array[x];
                else return 0;
            }
            set
            {
                if (this.flagIO == 1)
                    Input_Array[x] = value;
                else if (this.flagIO == 0)
                    Output_Array[x] = value;
            }
        }

    }
}