//////////////////////////////////
//				                //
//		   TicTacToe            //
//	         v1.0.3             //
//         everything		    //
//	         C0DED		        //
//    	       by		        //
//	        RED-C0DE		    //
//				                //
//				                //
//////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    interface ICpu
    {
        bool Initialize_Table();

        void CPU_Inc_Cells_Ham_Masir(byte bIndex1, byte bIndex2);
        void CPU_Dec_Cells_Ham_Masir(byte bIndex1, byte bIndex2);

        void Dec_Paths_Priority_Contain_This_Cell(byte bIndex1, byte bIndex2);
        void Inc_Paths_Priority_Contain_This_Cell(byte bIndex1, byte bIndex2);

        void CPU_Defence(byte bIndex1, byte bIndex2, bool PlayerOrCPU);
        void CPU_Select_Max_Priority(ref int bIndex1, ref int bIndex2);
    }
}

