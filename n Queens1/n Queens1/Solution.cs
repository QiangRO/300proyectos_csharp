using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;  

namespace n_Queens1
{
    class Solution        
    {
        //=============================
            # region Compute Promising 
              public int Promising(int[,] ch, int n)
        {
            int i, j, k = 0, b, Counter = 0,CounterRow = 0, FirstCol,FirstRow;
            int[] Col = new int[20];
            int[] Row = new int[20];

            //---- Get Where Is True ------------
            for (i = 0; i <= n - 1; i++)
                for (j = 0; j <= n - 1; j++)
                {
                    if (ch[i, j] == 1)
                    {
                        Col[k] = j;
                        Row[k] = i;
                        k++;
                    }
                }
            //-------------------------------

            
           //--- Check Equal Columes --------
            int S = 0;
            while (S < k)
            {
                FirstCol = Col[S];
                FirstRow = Row[S];
                for (b = 0; b < k; ++b)
                {
                    if ((FirstCol == Col[b]))
                    {
                        Counter++;
                    }

                    if ((FirstRow == Row[b]))
                    {
                        CounterRow++;
                    }
                }
                S++;
            }

            //-------------------------------
            //---- Check Ghotr ---------------
            int Counter2 = 0;
            for (int c = 0; c <k; c++)
            {
                {
                    int Check = Math.Abs(Col[c] - Col[c + 1]);
                    int Chck2 = Math.Abs(Row[c] - Row[c + 1]);

                    if (Check == Chck2)
                        Counter2++;
                }

            }                       
            //----------------------------------

            //----True Or False ----------------
            if ((Counter2 > 0) || (Counter > S) || (CounterRow > S ))
                return 0;
            else
                return 1;

            if (Counter > S)
            {
                Variables.CountError++;
                Variables.Errors[Variables.CountError] = "Error Col : Colume Equal";
            }

            if (CounterRow > S)
            {
                Variables.CountError++;
                Variables.Errors[Variables.CountError] = "Error Row : Row Equal";
            }

            if (Counter2 > 0)
            {
                Variables.CountError++;
                Variables.Errors[Variables.CountError] = "Error Ghotr : Ghotr Equal";
            }
            //----------------------------------
        }
            #endregion
              


              #region All Solutions
           public int AllSolution(int n)
           {
               return 1;
           }

              int Promising(int i, int j,int n)
              {
                  
                    return 1 ;
              }
    
        #endregion 

        //===================
    }
}
