using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    class matrix
    {
        //----------------------------- محاسبه ترانهاده ماتريس --------------------------------------------
        public float[,] Transpose(float[,] x, int row, int col)
        {
            int i, j;
            float[,] temp = new float[col, row];
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    temp[j, i] = x[i, j];
                }
            }
            return temp;
        }
        //------------------------------- محاسبه حاصل ضرب يک عدددر ماتريس ------------------------------------------  
        public float[,] NumberMultiple(float Num, float[,] x, int row, int col)
        {
            float[,] temp = new float[row, col];
            int i, j;
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    temp[i, j] = Num * x[i, j];
                }
            }
            return temp;
        }
        //------------------------------ محاسبه حاصل ضرب دو ماتریس--------------------------------------------------
        public float[,] MatrixMultiple(float[,] x, float[,] y, int rowx, int colx, int coly)
        {
            float[,] temp = new float[rowx, coly];
            int i, j, k;
            for (i = 0; i < rowx; i++)
            {
                for (j = 0; j < coly; j++)
                {
                    temp[i, j] = 0;
                    for (k = 0; k < colx; k++)
                    {
                        temp[i, j] = temp[i, j] + x[i, k] * y[k, j];
                    }
                }
            }
            return temp;
        }
        //------------------------------- محاسبه دترمينان ماتريس 2 در 2 ---------------------
        private float det2(float[,] x)
        {
            return x[0, 0] * x[1, 1] - x[0, 1] * x[1, 0];
        }
        //------------------------------- محاسبه دترمينان ماتريس 3 در 3 ---------------------
        private float det3(float[,] x)
        {
            int sign = 1, i;
            float d = 0;
            int n = x.GetLength(0);
            for (i = 0; i < 3; i++)
            {
                d = d + sign * x[0, i] * det2(cofactor(x, 0, i));
                sign = -sign;
            }
            return d;
        }
        //------------------------------- محاسبه كوفاكتور ماتريس ---------------------------------------------------
        public float[,] cofactor(float[,] x, int r, int c)
        {
            float[,] temp = new float[10, 10];
            int i, j, a = 0, b;
            for (i = 0; i < 3; i++)
            {
                if (i != r)
                {
                    b = 0;
                    for (j = 0; j < 3; j++)
                    {
                        if (j != c)
                        {
                            temp[a, b] = x[i, j];
                            b++;
                        }
                    }
                    a++;
                }
            }
            return temp;
        }
        //------------------------------- محاسبه همسازه ماتريس ---------------------------------------------------
        public float[,] hamsaze(float[,] x,int row,int col)
        {
            float[,] temp = new float[10, 10];
            int i, j,k,p;
            for (i = 0; i < row; i++)
                for (j = 0; j < col; j++)
                {
                    p = 1;
                    for (k = 0; k < (i + j); k++)
                        p = p * (-1);
                    temp[i, j] = (p) * det2(cofactor(x, i, j));
                }
            return temp;
        }
        //------------------------------- محاسبه دترمینان ماتریس ---------------------------------------------------
        public float Determinan(float[,] x, int row, int col)
        {
            if (row == col && row == 2)
                return det2(x);
            else
                return det3(x);
        }
        //------------------------------- معکوس ماتریس 2در2 -------------------------------------------------------
        public float[,] Invers(float[,] x, int row, int col)
        {
            float[,] inver = new float[row, col];
            float[,] temp = new float[row, col];
            if (row == 2)
            {
                inver[0, 0] = x[1, 1];
                inver[0, 1] = -x[1, 0];
                inver[1, 0] = -x[0, 1];
                inver[1, 1] = x[0, 0];
                temp = NumberMultiple(1 / Determinan(x, row, col), inver, row, col);
            }
            else if (row == 3)
            {
                temp = Transpose(hamsaze(x,row,col),row,col);
                inver = NumberMultiple(1 / Determinan(x, row, col), temp, row, col);
                return inver;
            }
            return temp;
        }

    }

}