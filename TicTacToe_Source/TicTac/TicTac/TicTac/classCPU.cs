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
using System.Windows.Forms;

namespace TicTacToe
{
    class classCPU : ICpu
    {
        #region def 4 CPU Defence :
        private static int cpuDef_IndexCellsRadif = 0;
        private static string[] cpuDef_strCellsRadif;
        private static int cpuDef_sum = 0;
        private static bool cpuDef_RadifOK = false;
        #endregion def 4 cpu defence/

        bool blnInitializedOK;
        public const byte _MAX_ = 13;       //tedad Cell-ha
        public static byte _LEVEL_ = 5;     //yani chand-tayi beshe baraye WIN. {Default=5}
        int index4MakingPaths= 0;           //index baraye sakhtan-e Array Paths va harkat dar in Array
        public char[] chars = new char[2];
        int indexCellPaths = 0;

        struct CELL_INFO
        {
            public string Cell;     //har Cell
            public int CellPriority;    //Olaviat baraye har Cell
            //public char[,] Chars;    //Khanehaye ham Masir            
            public char[] Chars;    //Khanehaye ham Masir            
            public int CharsCount;
        }
        struct PATHS
        {
            public string[] Cells;   //3 Cell baraye tashkile yek Path
            public int CpuSelectedCount;   //Tedade Cell Entekhab shode dar in Path
            public int PlayerSelectedCount;   //Tedade Cell Entekhab shode Harif dar in Path
            public int PathPriority;    //Olaviat baraye har Path
            public int _PathMaxCellPriorityBetweenSpaceCells;    //beine Cell-haye khali Olaviate ooni k bishtare ro dar khod dare
        }
        private CELL_INFO[] Cell_Info ;     //Cells Array
        private PATHS[] Paths;              //Paths Array
  //----------------------------------------------------\\      
        


        #region First Initializing
        private void F_Chap_2_Rast(int i)
        {
            if (i < 0)
                return;
            else
                F_Chap_2_Rast(i - 1);

            for (int c = 0; (c + _LEVEL_) <= _MAX_; c++, indexCellPaths++)
            {
                //for new path (inc the Paths Array size):
                Array.Resize(ref Paths, indexCellPaths + 1);
                Paths[indexCellPaths ] = new PATHS();
                Paths[indexCellPaths].Cells = new string[_LEVEL_];

                for (int i2 = 0; i2 <= _LEVEL_ - 1; i2++)
                    Paths[indexCellPaths].Cells[index4MakingPaths++] = (i.ToString() + "," + (c + i2).ToString());
                if (index4MakingPaths >= _LEVEL_ - 1) 
                    index4MakingPaths = 0;
            }
        }
        private void F_Bala_2_Payin(int j)
        {
            if (j < 0)
                return;
            else
                F_Bala_2_Payin(j - 1);

            for (int c = 0; (c + _LEVEL_) <= _MAX_; c++, indexCellPaths++)
            {
                //for new path (inc the Paths Array size):
                Array.Resize(ref Paths, indexCellPaths + 1);
                Paths[indexCellPaths] = new PATHS();
                Paths[indexCellPaths].Cells = new string[_LEVEL_];
                for (int i2 = 0; i2 <= _LEVEL_ - 1; i2++)
                    Paths[indexCellPaths].Cells[index4MakingPaths++] = ((c + i2).ToString() + "," + j.ToString());

                if (index4MakingPaths >= _LEVEL_ - 1) 
                    index4MakingPaths = 0;
            }
        }
        private void F_Ghotre_Asli(byte i, byte j) 
        {
            for (int c = 0; (c + _LEVEL_) <= _MAX_; c++, indexCellPaths++)
            {
                if (i + c + (_LEVEL_ - 1) >= _MAX_ || j + c + (_LEVEL_ - 1) >= _MAX_) 
                    break;

                //for new path (inc the Paths Array size):
                Array.Resize(ref Paths, indexCellPaths + 1);
                Paths[indexCellPaths] = new PATHS();
                Paths[indexCellPaths].Cells = new string[_LEVEL_];
                
                for (int i2 = 0; i2 <= _LEVEL_ - 1; i2++)
                    Paths[indexCellPaths].Cells[index4MakingPaths++] = ((i + c + i2).ToString() + "," + (j + c + i2).ToString());

                if (index4MakingPaths >= _LEVEL_ - 1) 
                    index4MakingPaths = 0;
            }
        }
        private void F_Ghotre_Farei(byte i, byte j)
        {
            for (int c = 0; (c + _LEVEL_) <= _MAX_; c++, indexCellPaths++)
            {
                if ((i + c + (_LEVEL_ - 1) >= _MAX_) || (j - c - _LEVEL_ + 1 < 0))
                    break;

                //for new path (inc the Paths Array size):
                Array.Resize(ref Paths, indexCellPaths + 1);
                Paths[indexCellPaths] = new PATHS();
                Paths[indexCellPaths].Cells = new string[_LEVEL_];
                
                for (int i2 = 0; i2 <= _LEVEL_ - 1; i2++)
                    Paths[indexCellPaths].Cells[index4MakingPaths++] = ((i + c + i2).ToString() + "," + (j - c - i2).ToString());

                if (index4MakingPaths >= _LEVEL_ - 1) 
                    index4MakingPaths = 0;
            }
        }
        private void make_Cell_Info()
        {
            int c = 0;
            for (int i = 0; i < _MAX_; i++)
                for (int j = 0; j < _MAX_; j++)
                {
                    Cell_Info[c++].Cell = i.ToString() + "," + j.ToString();
                }
        }
        private void make_Cell_Info_Chars()
        {
            char ch = 'A';
            for (int i = 0; i <= Paths.Length - 1; i++)
            {
                for (int j = 0; j <= (_LEVEL_ - 1); j++)
                {
                    string[] strTmp = Paths[i].Cells[j].Split(',');
                    int index = giveMe_Cell_Index_From_This_Index_String(strTmp[0] + "," + strTmp[1]);
                    Cell_Info[index].Chars[Cell_Info[index].CharsCount++] = ch;
                    Cell_Info[index].CellPriority = Cell_Info[index].CharsCount;
                }
                ch++;
            }
        }
        public bool Initialize_Table()
        {       //peida kardane Tamami-e PATHs-haye momken dar jadval
                //va por kardane maghadir-e sayer-e Arraye-ha
            try
            {
                Cell_Info = new CELL_INFO[_MAX_ * _MAX_];//b andazeye tedad Cell-ha
                index4MakingPaths = indexCellPaths = 0;

                for (int i = 0; i <= Cell_Info.Length - 1; i++)
                    Cell_Info[i].Chars = new char[30];

                //Path-haye mojood b soorat-e radifi az chap b rast
                F_Chap_2_Rast(_MAX_ - 1);
                //Path-haye mojood b soorat-e radifi az bala b payin
                F_Bala_2_Payin(_MAX_ - 1);

                //Path-haye mojood b soorat-e Movarrab rooye ghotr-e asli
                for (byte i = 0; i <= _MAX_ - _LEVEL_; i++)
                    F_Ghotre_Asli(i, 0);
                for (byte j = 1; j <= _MAX_ - _LEVEL_; j++)
                    F_Ghotre_Asli(0, j);

                //Path-haye mojood b soorat-e Movarrab rooye ghotr-e farei
                for (byte i = 0; i <= _MAX_ - _LEVEL_; i++)
                    F_Ghotre_Farei(i, _MAX_ - 1);
                for (byte j = (byte)(_LEVEL_ - 1); j < (_MAX_ - 1); j++)
                    F_Ghotre_Farei(0, j);

                make_Cell_Info();
                make_Cell_Info_Chars();
                blnInitializedOK = true;
                return true;
            }
            catch (Exception ex)
            {
                blnInitializedOK = false;
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion first initializing\

        #region GiveMe Index

        private void giveMe_Indexes_From_This_String(string strIndex, ref int iIndex1, ref int iIndex2)
        {
            string[] arrTmpCells = strIndex.Split(',');
            iIndex1 = byte.Parse(arrTmpCells[0]);
            iIndex2 = byte.Parse(arrTmpCells[1]);
        }

        private int giveMe_Cell_Index_From_This_Index_String(string strIndex)
        {
            for (byte i = 0; i < Cell_Info.Length; i++)
            {
                if (Cell_Info[i].Cell == strIndex)
                    return i;
            }
            return -1;
        }

        private int giveMe_Cell_Info_Index_From_Indexes(byte bIndex1, byte bIndex2)
        {
            return bIndex1 * _MAX_ + bIndex2;
        }

        private int giveMe_Max_Cell_Priority_Between_Space_Cells_In_This_PATH(int PathIndex)
        {
            int maxPriority = 0;
            int iIndex1 = 0; int iIndex2 = 0;
            for (int i = 0; i < _LEVEL_ ; i++)
            {
                string tmpIndex = Paths[PathIndex].Cells[i];
                giveMe_Indexes_From_This_String(tmpIndex, ref iIndex1, ref iIndex2);
                int _CellIndex = giveMe_Cell_Index_From_This_Index_String(tmpIndex);
                if (FrmMain.lblCells[iIndex1, iIndex2].Tag.ToString().Split(',').Length == 2 && Cell_Info[_CellIndex].CellPriority > maxPriority)
                {
                    maxPriority = Cell_Info[_CellIndex].CellPriority;
                }
            }
            return maxPriority;
        }

        private void giveMe_Indexes_From_This_Index(int Index, ref int  iIndex1, ref int  iIndex2)
        {
            iIndex1 = Index / _MAX_;
            iIndex2 = Index % _MAX_;
        }

        #endregion giveme index/

        #region WORKING... :
        //********************************:
        private byte[] make_Cell_Max_Priority()
        {
            //in Func pas az inke Best_Cell[s] ra entekhab kard (momkene chand ta Cell ba ham dAraye 1 Olaviat baraye entekhab bashand)
            //k b hamin khater meghdare bargashti in Func b soorate Array hast va in maghadir k index khooneha
            //hastan,  Out mishe ta 1ki Random entekhab beshe 
            //shayad ham Array-e k Out shode faghat 1 Member dashte bashe

            #region Select_Best Cell In Best Path:

            #region Def:
            byte[] arrMaxIndexesPriority = new byte[0];
            int[] arrCpu_4_Tayi = new int[0];
            int[] arrCpu_3_Tayi = new int[0];
            int[] arrCpu_2_Tayi = new int[0];
            int[] arrPlayer_4_Tayi = new int[0];
            int[] arrPlayer_3_Tayi = new int[0];
            int[] arrPlayer_2_Tayi = new int[0];
            byte c0 = 0;
            #endregion def/

            #region Get_paths :
            //gereftan-e Path-ha ..albate b tartib-e Olaviat :

            _maxPrio_Get_Best_Paths(ref arrCpu_4_Tayi, 4, true);
            _maxPrio_Get_Best_Paths(ref arrPlayer_4_Tayi, 4, false);
            _maxPrio_Get_Best_Paths(ref arrCpu_3_Tayi, 3, true);
            _maxPrio_Get_Best_Paths(ref arrPlayer_3_Tayi, 3, false);
            _maxPrio_Get_Best_Paths(ref arrCpu_2_Tayi, 2, true);
            _maxPrio_Get_Best_Paths(ref arrPlayer_2_Tayi, 2, false);

            #endregion get_paths/

            #region Select_Best Path :
            //khob hala tamame PATH-haye chand-tayi ro darim, hala bayad b tartib-e olaviat (mesle 1 Adam) entekhab konim ==> yani masalan age k man mitoonam alan 1 Path 5-tayi dorost konam va bazi ro bebaram , dige niazi b negah kardan b baghie chiza nadaram.
            //>>albate Exception(estesna) ham dar bazi marahel momkene pish biad...k baes beshe olaviat-ha b ham bekhore. vali dar 99% mavared hamin olaviat-ha OK
            //Select CELL From above Arrays :
            //tooye Paths 4-tayi avval 1-ki az path-ha ro entekhab kon va badesh tanha Celli k az tooye 1 Path 4-tayi bayad entekhab beshe ro befrest Out :
            if (arrCpu_4_Tayi.Length > 0)
            {
                _maxPrio_Select_Best_Path(ref arrCpu_4_Tayi, ref arrMaxIndexesPriority);
                goto _selectMaxCellPriority;
            }

            //tooye Paths 4-tayi avval 1-ki az path-ha ro entekhab kon va badesh tanha Celli k az tooye 1 Path 4-tayi bayad entekhab beshe ro befrest Out :
            if (arrPlayer_4_Tayi.Length > 0)
            {
                _maxPrio_Select_Best_Path(ref arrPlayer_4_Tayi, ref arrMaxIndexesPriority);
                goto _selectMaxCellPriority;
            }

            //tooye Paths 3-tayi avval 1-ki az path-ha ro entekhab kon va badesh 1ki az 2 Cell baghimande ro az tooye 1 Path 3-tayi bayad entekhab beshe :
            #region 3-Tayi CPU Exception :

            if (arrCpu_3_Tayi.Length > 0)
            {
                //
                _maxPrio_Select_Best_Path(ref arrCpu_3_Tayi, ref arrMaxIndexesPriority);
                goto _selectMaxCellPriority;
                //
                /*
                
                int _j = 0; int _maxPathPriority = 0; int _indexOfMaxPathPriority = 0;
                for (_j = 0; _j < arrCpu_3_Tayi.Length; _j++)
                {
                    if (Paths[arrCpu_3_Tayi[_j]]._PathMaxCellPriorityBetweenSpaceCells > _maxPathPriority)
                    {
                        _maxPathPriority = Paths[arrCpu_3_Tayi[_j]]._PathMaxCellPriorityBetweenSpaceCells;
                        _indexOfMaxPathPriority = _j;
                    }
                }

                int i; int iIndex1 = 0; int iIndex2 = 0; c0 = 0;
                for (i = 0; i < _LEVEL_ ; i++)
                {
                    string tmpIndex = Paths[arrCpu_3_Tayi[_indexOfMaxPathPriority]].Cells[i];
                    giveMe_Indexes_From_This_String(tmpIndex, ref iIndex1, ref iIndex2);
                    if (FrmMain.lblCells[iIndex1, iIndex2].Tag.ToString().Split(',').Length == 2)
                    {
                        Array.Resize(ref arrMaxIndexesPriority, ++c0);
                        arrMaxIndexesPriority[c0 - 1] = (byte)(giveMe_Cell_Index_From_This_Index_String(Paths[arrCpu_3_Tayi[_indexOfMaxPathPriority]].Cells[i]));
                    }
                }

                //baraye arrCPU_3_Tayi 2 ta Cell khali vojood dare..(yani mitoone alan 4-tayi beshe in Path) bayad oon Cell-i ro entekhab konam k age entekhab beshe Path ro b soorate chasbide b ham az 4 ta Cell dar biare...
                //++avval baraye 4-tayi :
                for (i = 0; i < arrMaxIndexesPriority.Length; i++)
                {
                    byte tmpIndex = arrMaxIndexesPriority[i];
                    //++ avval agar k 2 taraf-esh dar in PATH entekhab shode
                    //+  dovvom agar k 1 taraf-esh dar in PATH entekhab shode
                    for (int i2 = 0; i2 <= 1; i2++)
                    {
                        giveMe_Indexes_From_This_String(Paths[arrCpu_3_Tayi[_indexOfMaxPathPriority]].Cells[i2 + 0], ref iIndex1, ref iIndex2);
                        if ((FrmMain.lblCells[iIndex1, iIndex2].Tag.ToString().Split(',').Length == 3 || Cell_Info[tmpIndex].Cell == Paths[arrCpu_3_Tayi[_indexOfMaxPathPriority]].Cells[i2 + 0]))
                        {
                            giveMe_Indexes_From_This_String(Paths[arrCpu_3_Tayi[_indexOfMaxPathPriority]].Cells[i2 + 1], ref iIndex1, ref iIndex2);
                            if ((FrmMain.lblCells[iIndex1, iIndex2].Tag.ToString().Split(',').Length == 3 || Cell_Info[tmpIndex].Cell == Paths[arrCpu_3_Tayi[_indexOfMaxPathPriority]].Cells[i2 + 1]))
                            {
                                giveMe_Indexes_From_This_String(Paths[arrCpu_3_Tayi[_indexOfMaxPathPriority]].Cells[i2 + 2], ref iIndex1, ref iIndex2);
                                if ((FrmMain.lblCells[iIndex1, iIndex2].Tag.ToString().Split(',').Length == 3 || Cell_Info[tmpIndex].Cell == Paths[arrCpu_3_Tayi[_indexOfMaxPathPriority]].Cells[i2 + 2]))
                                {
                                    giveMe_Indexes_From_This_String(Paths[arrCpu_3_Tayi[_indexOfMaxPathPriority]].Cells[i2 + 3], ref iIndex1, ref iIndex2);
                                    if ((FrmMain.lblCells[iIndex1, iIndex2].Tag.ToString().Split(',').Length == 3 || Cell_Info[tmpIndex].Cell == Paths[arrCpu_3_Tayi[_indexOfMaxPathPriority]].Cells[i2 + 3]))
                                    {
                                        Array.Resize(ref arrMaxIndexesPriority, 1);
                                        arrMaxIndexesPriority[0] = tmpIndex;
                                        goto _selectMaxCellPriority;
                                    }
                                }
                            }
                        }
                    }
                }

                //+baraye 3-tayi b ham chasbideh:
                for (i = 0; i < arrMaxIndexesPriority.Length; i++)
                {

                    byte tmpIndex = arrMaxIndexesPriority[i];
                    for (int i2 = 0; i2 <= 2; i2++)
                    {
                        giveMe_Indexes_From_This_String(Paths[arrCpu_3_Tayi[_indexOfMaxPathPriority]].Cells[i2 + 0], ref iIndex1, ref iIndex2);
                        if ((FrmMain.lblCells[iIndex1, iIndex2].Tag.ToString().Split(',').Length == 3 || Cell_Info[tmpIndex].Cell == Paths[arrCpu_3_Tayi[_indexOfMaxPathPriority]].Cells[i2 + 0]))
                        {
                            giveMe_Indexes_From_This_String(Paths[arrCpu_3_Tayi[_indexOfMaxPathPriority]].Cells[i2 + 1], ref iIndex1, ref iIndex2);
                            if ((FrmMain.lblCells[iIndex1, iIndex2].Tag.ToString().Split(',').Length == 3 || Cell_Info[tmpIndex].Cell == Paths[arrCpu_3_Tayi[_indexOfMaxPathPriority]].Cells[i2 + 1]))
                            {
                                giveMe_Indexes_From_This_String(Paths[arrCpu_3_Tayi[_indexOfMaxPathPriority]].Cells[i2 + 2], ref iIndex1, ref iIndex2);
                                if ((FrmMain.lblCells[iIndex1, iIndex2].Tag.ToString().Split(',').Length == 3 || Cell_Info[tmpIndex].Cell == Paths[arrCpu_3_Tayi[_indexOfMaxPathPriority]].Cells[i2 + 2]))
                                {
                                    {
                                        Array.Resize(ref arrMaxIndexesPriority, 1);
                                        arrMaxIndexesPriority[0] = tmpIndex;
                                        goto _selectMaxCellPriority;
                                    }
                                }
                            }
                        }
                    }
                }

                _maxPrio_Select_Best_Path(ref arrCpu_3_Tayi, ref arrMaxIndexesPriority);
                goto _selectMaxCellPriority;
                */
            }
            
            #endregion 3-tayi exception/


            //tooye Paths 3-tayi avval 1-ki az path-ha ro entekhab kon va badesh 1ki az 2 Cell baghimande ro az tooye 1 Path 3-tayi bayad entekhab beshe :
            #region 3-Tayi Player Exception :
            if (arrPlayer_3_Tayi.Length > 0)
            {
                //exception for 3-tayi b ham chasbideh :
                int iIndex1 ,iIndex2 ;
                int[] iArrTmp=new int[0];
                c0 = 0;
                
                for (int i = 0; i < arrPlayer_3_Tayi.Length; i++)
                {
                    iIndex1 = 0; iIndex2 = 0;
                    for (int j = 0; j <=2 ; j++)
                    {
                        giveMe_Indexes_From_This_String(Paths[arrPlayer_3_Tayi[i]].Cells[j],ref iIndex1,ref iIndex2);
                        if (FrmMain.blnArrPlayer1Selection[iIndex1, iIndex2] || FrmMain.blnArrPlayer2Selection[iIndex1, iIndex2])
                        {
                            giveMe_Indexes_From_This_String(Paths[arrPlayer_3_Tayi[i]].Cells[j+1], ref iIndex1, ref iIndex2);
                            if (FrmMain.blnArrPlayer1Selection[iIndex1, iIndex2] || FrmMain.blnArrPlayer2Selection[iIndex1, iIndex2])
                            {
                                giveMe_Indexes_From_This_String(Paths[arrPlayer_3_Tayi[i]].Cells[j+2], ref iIndex1, ref iIndex2);
                                if (FrmMain.blnArrPlayer1Selection[iIndex1, iIndex2] || FrmMain.blnArrPlayer2Selection[iIndex1, iIndex2])
                                {       //yani 3-tayi b ham chasbide peida karde
                                    Array.Resize(ref iArrTmp, ++c0);
                                    iArrTmp[c0-1]=arrPlayer_3_Tayi[i];                                                                                                           
                                }
                            }
                        }
                    }
                }

                if (iArrTmp.Length > 0)    //agar k 3-tayi b ham chasbideh peida kard bayad tooye oon Max-Cells ro peida kone
                    _maxPrio_Select_Best_Path(ref iArrTmp, ref arrMaxIndexesPriority);
                else
                    _maxPrio_Select_Best_Path(ref arrPlayer_3_Tayi, ref arrMaxIndexesPriority);
                goto _selectMaxCellPriority;
            }
            #endregion 3-tayi player exception\


            #region Kalak-e LOZI Exception :
            {
                //age kalak-e LOZI bashe bayad khonsash konam : (4-ta khoone b soorate LOZI chide beshan, tori k vasat-esh khali bashe)
                int iIndex1 = 0; int iIndex2 = 0;
                if (kalak_LOZI(ref iIndex1, ref iIndex2))
                {
                    Array.Resize(ref arrMaxIndexesPriority, 1);
                    byte bIndex1=Convert.ToByte(iIndex1);
                    byte bIndex2=Convert.ToByte(iIndex2);
                    arrMaxIndexesPriority[0] =(byte) (giveMe_Cell_Info_Index_From_Indexes(bIndex1 ,bIndex2 ));
                    goto _selectMaxCellPriority;
                }
            }
            #endregion kalak-e lozi exception\


            //tooye Paths 2-tayi avval 1-ki az path-ha ro entekhab kon va badesh 1ki az 3 Cell baghimande ro az tooye 1 Path 2-tayi bayad entekhab beshe :
            if (arrCpu_2_Tayi.Length > 0)
            {
                _maxPrio_Select_Best_Path(ref arrCpu_2_Tayi, ref arrMaxIndexesPriority);
                goto _selectMaxCellPriority;
            }

            //tooye Paths 2-tayi avval 1-ki az path-ha ro entekhab kon va badesh 1ki az 3 Cell baghimande ro az tooye 1 Path 2-tayi bayad entekhab beshe :
            if (arrPlayer_2_Tayi.Length > 0)
            {
                _maxPrio_Select_Best_Path(ref arrPlayer_2_Tayi, ref arrMaxIndexesPriority);
                goto _selectMaxCellPriority;
            }
            #endregion select_best path/
            
            #region Select_Best Cell in Best Path:
        _selectMaxCellPriority:
            if (arrMaxIndexesPriority.Length == 0)//agar k Path-i chand-tayi peida nakard bayad 1 Cell RND k bishtarin Priority ro dare entekhab kone
                goto __randomMaxCellPriority;
            //else : bayad beine Cell-haye khali k dar arrMaxIndexes... vojood dare Cell-i ba bishtarin Priority ro entekhab konam

            //avval maxPririty ro peida kon:
            string[] arrTmp2Cells_1 = new string[0];
            int maxPriority_1 = Cell_Info[arrMaxIndexesPriority[0]].CellPriority;
            for (int i = 0; i <= arrMaxIndexesPriority.Length - 1; i++)
            {//-1x yani CPU , -2x yani Player :
                //Exceptions :
                if (Cell_Info[arrMaxIndexesPriority[i]].CellPriority == -10)//agar k in cell Hatman bayad sel beshe yani alan halate-e 4 tayi hast (ya CPU ya Player) va bayad hatman entekhab beshe...
                {
                    byte[] index_e_Max_PriorityTmp = new byte[1];
                    index_e_Max_PriorityTmp[0] = (byte)giveMe_Cell_Index_From_This_Index_String(Cell_Info[arrMaxIndexesPriority[i]].Cell);
                    return index_e_Max_PriorityTmp;
                }
                if (Cell_Info[arrMaxIndexesPriority[i]].CellPriority == -20)//agar k in cell Hatman bayad sel beshe yani alan halate-e 4 tayi hast (ya CPU ya Player) va bayad hatman entekhab beshe...
                {
                    byte[] index_e_Max_PriorityTmp = new byte[1];
                    index_e_Max_PriorityTmp[0] = (byte)giveMe_Cell_Index_From_This_Index_String(Cell_Info[arrMaxIndexesPriority[i]].Cell);
                    return index_e_Max_PriorityTmp;
                }
                //-1 yani computer va -2 Player1 yani olvaiat ba CPU bashe

                arrTmp2Cells_1 = Cell_Info[arrMaxIndexesPriority[i]].Cell.Split(',');
                byte tmpIndex1 = byte.Parse(arrTmp2Cells_1[0]);
                byte tmpIndex2 = byte.Parse(arrTmp2Cells_1[1]);
                if (Cell_Info[arrMaxIndexesPriority[i]].CellPriority > maxPriority_1 && FrmMain.lblCells[tmpIndex1, tmpIndex2].Tag.ToString().Split(',').Length < 3)
                    maxPriority_1 = Cell_Info[arrMaxIndexesPriority[i]].CellPriority;
            }

            //hala khoonehayi k == ba in maxPrioriy hastan ro dar 1 Array beriz ta RND entekhab beshe 1ki :
            //momkene tool Array 1 ham beshe.
            byte[] _1_index_e_Max_Priority = new byte[0];
            byte tmpArrayIndex_1 = 0;
            for (int i = 0; i <= arrMaxIndexesPriority.Length - 1; i++)
            {
                arrTmp2Cells_1 = Cell_Info[arrMaxIndexesPriority[i]].Cell.Split(',');
                byte tmpIndex1 = byte.Parse(arrTmp2Cells_1[0]);
                byte tmpIndex2 = byte.Parse(arrTmp2Cells_1[1]);
                if (Cell_Info[arrMaxIndexesPriority[i]].CellPriority == maxPriority_1 && FrmMain.lblCells[tmpIndex1, tmpIndex2].Tag.ToString().Split(',').Length < 3)
                {
                    Array.Resize(ref _1_index_e_Max_Priority, ++tmpArrayIndex_1);
                    _1_index_e_Max_Priority[tmpArrayIndex_1 - 1] = (byte)giveMe_Cell_Index_From_This_Index_String(Cell_Info[arrMaxIndexesPriority[i]].Cell);
                }
            }
            return _1_index_e_Max_Priority;

            #endregion select_best cell in best path/


            #endregion select_best cell in best path/

            #region Just_Select Best Cell no Best Path:
        
        __randomMaxCellPriority:

            //momkene Path ba olaviat -bala dige nabashe k bayad az bein-e Tak-Cell -ha entekhab konam (Cell-i k olaviat-esh Max bashe)
            //avval maxPririty  ro peida kon:
            string[] arrTmpCells = new string[0];
            int maxPriority = Cell_Info[0].CellPriority;
            for (int i = 0; i <= Cell_Info.Length - 1; i++)
            {//-1x yani CPU , -2x yani Player :
                if (Cell_Info[i].CellPriority == -10)//agar k in cell Hatman bayad sel beshe yani alan halate-e 4 tayi hast (ya CPU ya Player) va bayad hatman entekhab beshe...hala badan bayad dorost konam k CPU ro olaviat bede
                {
                    byte[] index_e_Max_PriorityTmp = new byte[1];
                    index_e_Max_PriorityTmp[0] = (byte)giveMe_Cell_Index_From_This_Index_String(Cell_Info[i].Cell);
                    return index_e_Max_PriorityTmp;
                }
                if (Cell_Info[i].CellPriority == -20)//agar k in cell Hatman bayad sel beshe yani alan halate-e 4 tayi hast (ya CPU ya Player) va bayad hatman entekhab beshe...hala badan bayad dorost konam k CPU ro olaviat bede
                {
                    byte[] index_e_Max_PriorityTmp = new byte[1];
                    index_e_Max_PriorityTmp[0] = (byte)giveMe_Cell_Index_From_This_Index_String(Cell_Info[i].Cell);
                    return index_e_Max_PriorityTmp;
                }//-1 yani computer va -2 Player1 yani olvaiat ba CPU bashe

                arrTmpCells = Cell_Info[i].Cell.Split(',');
                byte tmpIndex1 = byte.Parse(arrTmpCells[0]);
                byte tmpIndex2 = byte.Parse(arrTmpCells[1]);
                if (Cell_Info[i].CellPriority > maxPriority && FrmMain.lblCells[tmpIndex1, tmpIndex2].Tag.ToString().Split(',').Length < 3)
                    maxPriority = Cell_Info[i].CellPriority;
            }

            //hala khoonehayi k == ba in maxPrioriy hastan ro dar 1 Array beriz ta RND entekhab beshe 1ki :
            _1_index_e_Max_Priority = new byte[0];
            byte tmpArrayIndex = 0;
            for (int i = 0; i <= Cell_Info.Length - 1; i++)
            {
                arrTmpCells = Cell_Info[i].Cell.Split(',');
                byte tmpIndex1 = byte.Parse(arrTmpCells[0]);
                byte tmpIndex2 = byte.Parse(arrTmpCells[1]);
                if (Cell_Info[i].CellPriority == maxPriority && FrmMain.lblCells[tmpIndex1, tmpIndex2].Tag.ToString().Split(',').Length < 3)
                {
                    Array.Resize(ref _1_index_e_Max_Priority, ++tmpArrayIndex);
                    _1_index_e_Max_Priority[tmpArrayIndex - 1] = (byte)giveMe_Cell_Index_From_This_Index_String(Cell_Info[i].Cell);
                }
            }
            return _1_index_e_Max_Priority;

            #endregion just_select best cell no best path/
        }

        private bool kalak_LOZI(ref int iIndex1,ref int iIndex2)
        {//baraye check kardan-e inke aya rooye Board halat-e KALAK-LOZI vojood dare ya na? :
            //kalak LOZI = vaghti k harif 4 ta khoone ro tori entekhab kone k b soorate LOZI dar biad va vasat-esh khali bashe va ...
            //agar k dafeye bad, oon vasati ro entekhab kone => az 2 taraf 3-tayi dare.
            int iIndex = 0;

            if (!FrmMain.blnFlagWhatPlayer)//check player 1
            {
                foreach (bool bln in FrmMain.blnArrPlayer1Selection)
                {
                    if (iIndex <= 0 || iIndex % 13 <= 0 || iIndex % 13 >= 12 || iIndex / 13 >= 10)
                    {
                        iIndex++;
                        continue;
                    }
                    if (bln)//agar k khodesh entekhab shode :
                    {
                        giveMe_Indexes_From_This_Index(iIndex + 12, ref  iIndex1, ref iIndex2);
                        if (FrmMain.blnArrPlayer1Selection[iIndex1, iIndex2])//agar k 1ki payin && samte chapesh entehab shode :
                        {
                            giveMe_Indexes_From_This_Index(iIndex + 14, ref  iIndex1, ref iIndex2);
                            if (FrmMain.blnArrPlayer1Selection[iIndex1,iIndex2])//agar k 1ki payin && samte rastesh entekhab shode :
                            {
                                giveMe_Indexes_From_This_Index(iIndex + 26, ref  iIndex1, ref iIndex2);
                                if (FrmMain.blnArrPlayer1Selection[iIndex1, iIndex2])//AND agar k 2ta payin-tar-esh ham entekhab shode :
                                {
                                    giveMe_Indexes_From_This_Index(iIndex + 13, ref  iIndex1, ref iIndex2);
                                    if (!FrmMain.blnArrPlayer1Selection[iIndex1, iIndex2] && !FrmMain.blnArrPlayer2Selection[iIndex1, iIndex2])//AND agar k vasateshoon khali bood :
                                    {
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                    iIndex++;
                }
                return false;
            }

            else//check player 2
            {
                foreach (bool bln in FrmMain.blnArrPlayer2Selection)
                {
                    if (iIndex <= 0 || iIndex % 13 <= 0 || iIndex % 13 >= 12 || iIndex / 13 >= 10)
                        continue;
                    if (bln)//agar k khodesh entekhab shode :
                    {
                        giveMe_Indexes_From_This_Index(iIndex + 12, ref  iIndex1, ref iIndex2);
                        if (FrmMain.blnArrPlayer2Selection[iIndex1, iIndex2])//agar k 1ki payin && samte chapesh entehab shode :
                        {
                            giveMe_Indexes_From_This_Index(iIndex + 14, ref  iIndex1, ref iIndex2);
                            if (FrmMain.blnArrPlayer2Selection[iIndex1, iIndex2])//agar k 1ki payin && samte rastesh entekhab shode :
                            {
                                giveMe_Indexes_From_This_Index(iIndex + 26, ref  iIndex1, ref iIndex2);
                                if (FrmMain.blnArrPlayer2Selection[iIndex1,iIndex2])//AND agar k 2ta payin-tar-esh ham entekhab shode :
                                {
                                    giveMe_Indexes_From_This_Index(iIndex + 13, ref  iIndex1, ref iIndex2);
                                    if (!FrmMain.blnArrPlayer1Selection[iIndex1, iIndex2])//AND agar k vasateshoon khali bood :
                                    {
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                    iIndex++;
                }
                return false;
            }
            
        }

        private void _maxPrio_Get_Best_Paths(ref int[] array_ChandTayi, int chandTayi, bool CpuOrPlayer)
        {//return : Index-e PATH
            int c = 0;
            if (CpuOrPlayer)
            {
                for (int i = 0; i < Paths.Length; i++)
                {
                    if (Paths[i].CpuSelectedCount == chandTayi  && Paths[i].PlayerSelectedCount == 0)
                    {
                        Array.Resize(ref array_ChandTayi , ++c);
                        array_ChandTayi [c - 1] = i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < Paths.Length; i++)
                {
                    if (Paths[i].PlayerSelectedCount == chandTayi && Paths[i].CpuSelectedCount == 0)
                    {
                        Array.Resize(ref array_ChandTayi, ++c);
                        array_ChandTayi[c - 1] = i;
                    }
                }
            }
        }

        private void _maxPrio_Select_Best_Path(ref int[] array,ref byte[] arrayMax)
        {
            int _j = 0; int _maxPathPriority = 0; int _indexOfMaxPathPriority = 0;
            for (_j = 0; _j < array .Length; _j++)
            {
                if (Paths[array [_j]]._PathMaxCellPriorityBetweenSpaceCells > _maxPathPriority)
                {
                    _maxPathPriority = Paths[array [_j]]._PathMaxCellPriorityBetweenSpaceCells;
                    _indexOfMaxPathPriority = _j;
                }
            }

            int i; int iIndex1 = 0; int iIndex2 = 0;int c0 = 0;
            for (i = 0; i < _LEVEL_ ; i++)
            {
                string tmpIndex = Paths[array [_indexOfMaxPathPriority]].Cells[i];
                giveMe_Indexes_From_This_String(tmpIndex, ref iIndex1, ref iIndex2);
                if (FrmMain.lblCells[iIndex1, iIndex2].Tag.ToString().Split(',').Length == 2)
                {
                    Array.Resize(ref arrayMax , ++c0);
                    arrayMax [c0 - 1] = (byte)(giveMe_Cell_Index_From_This_Index_String(Paths[array [_indexOfMaxPathPriority]].Cells[i]));
                }
            }
        }

        private void Inc_Cells_Ham_Masir_Priority(byte iIndex1, byte iIndex2, bool Inc, bool Dec)
        {
            //Console.WriteLine("\n===============print_Cell_Ham_Masir_Ba({0},{1})================", i0, i1);

            string[] arrCellHamMasir = new string[0];
            int c = 0;
            int index = giveMe_Cell_Info_Index_From_Indexes(iIndex1, iIndex2);

            foreach (char ch1 in Cell_Info[index].Chars)//ham-masirha ro peida kon va dar arrCellHamMasir beriz:
            {                               
                if (ch1 == 0) break;
                //Console.Write("\n" + ch1 + " >");
                for (int i = 0; i <= Cell_Info.Length - 1; i++)
                {
                    foreach (char ch2 in Cell_Info[i].Chars)
                    {
                        if (ch2 == 0) break;
                        if (ch2 == ch1)
                        {
                            Array.Resize(ref arrCellHamMasir, ++c);
                            arrCellHamMasir[c-1] = Cell_Info[i].Cell;
                            //Console.Write(" [" + Cell_Info[i].Cell + "]");
                        }
                    }
                }
            }

            foreach (string str in arrCellHamMasir)
            {
            //    if (str == null) break;
                string[] arrStr = str.Split(',');
                byte  bIndex1 = byte.Parse (arrStr[0]);
                byte bIndex2 = byte.Parse(arrStr[1]);

                int iTmp = giveMe_Cell_Info_Index_From_Indexes(iIndex1, iIndex2);
                
                /////////Inc++ the Priority of the Cell:
                if(Inc)
                    Cell_Info[iTmp].CellPriority += 10;
                else if (Dec)/////////Dec-- the Priority of the Cell:
                    Cell_Info[iTmp].CellPriority -= 10;
                //Cell_Info[iTmp].CharsNum++;


                ////if (Form1.lblCells[iIndex1, iIndex2].Image == null)
                ////    Form1.lblCells[iIndex1, iIndex2].Image = TicTac.Properties.Resources.CurrentHighLight;
                ////////System.Windows.Forms.MessageBox.Show(Form1.lblCells[iIndex1, iIndex2].Tag.ToString() + " = " + Cell_Info[iTmp].Priority.ToString());
                ////if (Form1.lblCells[iIndex1, iIndex2].Image == TicTac.Properties.Resources.CurrentHighLight)
                ////    Form1.lblCells[iIndex1, iIndex2].Image = null;
            }
        }

        private void Inc_PATH_Priority(byte iIndex1, byte iIndex2,bool CpuSelected,bool PlayerSelected)
        {

            //inha az bala b payin b tartib-e Olaviat hastan : 

            ////bayad begarde bishtarin PATH.Priority ro peida kone va 
            //agar k PATH-i ro peida kard k Priority oon 4 hast va nobate CPU
            //yani CPU alan mitoone FINISH kone va bayad Tanha Cell mojood ro entekhab kard

            //agar k "      "       "       "       "     -4 hast va nobate CPU
            //yani k Player alan mitoone FINISH kone va bayad jolosh gerefte beshe..

            //agar k "      "       "       "       "       3 hast va nobate 
            //CPU hast, bayad 1-ki az 2 Cell in PATH entekhab beshe ta 4-tayi beshe

            //agar k "      "       "       "       "       -3 hast va nobate CPU
            //yani Player mitoone 4-tayi kone va bayad jolosh gerefte beshe...bayad 
            //1-ki az 2 ta Cell mojood dar PATH entekhab beshe
            
            string sIndex = iIndex1.ToString() + "," + iIndex2.ToString();

            for (int i = 0; i < Paths.Length; i++)
            {
                foreach (string str in Paths[i].Cells)
                {
                    if (str == sIndex)
                    {
                        if(CpuSelected)
                            Paths[i].CpuSelectedCount++;
                        else if(PlayerSelected)
                            Paths[i].PlayerSelectedCount++;
                        Paths[i].PathPriority = Paths[i].CpuSelectedCount - Paths[i].PlayerSelectedCount;
                        Paths[i]._PathMaxCellPriorityBetweenSpaceCells = giveMe_Max_Cell_Priority_Between_Space_Cells_In_This_PATH(i);
                    }
                }
            }
        }

        #endregion working/

        #region ICpu Members

        public void CPU_Select_Max_Priority(ref int bIndex1, ref int bIndex2)
        {
            //har harkati k CPU mikhad anjam bede bayad b in Func ferestade beshe :
            //ebteda khoonehayi k bishtarin Olaviat ro baraye entekhab daran bayad peida kard va dar Array rikht :
            byte[] Indexes = make_Cell_Max_Priority();
            
            if (Indexes.Length == 0)//Game Draw..tamam-e Cell-ha por shode , ya rahi baraye entekhab dige nist
            {
                bIndex1 = bIndex2 = -99;
                return;
            }

            //momkene Olaviat-ha mosavi ham beshe, hala Random 1kishoono Select kon :
            Random rndNumber = new Random(DateTime.Now.Millisecond);
            int index = rndNumber.Next(0, Indexes.Length);
            string[] tmpIndex = Cell_Info[Indexes[index]].Cell.Split(',');
            bIndex1 = byte.Parse(tmpIndex[0]);  //return bIndex1
            bIndex2 = byte.Parse(tmpIndex[1]);  //return bIndex2
        }

        public void CPU_Inc_Cells_Ham_Masir(byte bIndex1, byte  bIndex2)
        {
            //Cell-haye ham-masir ba in Cell ro bayad olaviateshoono afzayesh bedam:
            Inc_Cells_Ham_Masir_Priority(bIndex1, bIndex2, true, false);
        }

        public void CPU_Dec_Cells_Ham_Masir(byte bIndex1, byte bIndex2)
        {
            Inc_Cells_Ham_Masir_Priority(bIndex1, bIndex2, false , true );
            Inc_PATH_Priority(bIndex1, bIndex2, false, true); 
        }

        public void Inc_Paths_Priority_Contain_This_Cell(byte  bIndex1, byte bIndex2)
        {
            Inc_PATH_Priority(bIndex1, bIndex2, true , false);
        }

        public void Dec_Paths_Priority_Contain_This_Cell(byte bIndex1, byte bIndex2)
        {
            Inc_PATH_Priority(bIndex1, bIndex2, false , true );
        }


        #region CPU Defence :

        public void CPU_Defence(byte iIndex1, byte iIndex2, bool PlayerOrCPU)
        {
            if (PlayerOrCPU)//Player :
            {
                byte[] cellsIndexPlayer4Tayi = cpuDef_Check_And_Get_States_Player_Chand_Tayi_Haye_Mokhtalef(iIndex1, iIndex2, true, 4);
                byte[] cellsIndexPlayer3Tayi = cpuDef_Check_And_Get_States_Player_Chand_Tayi_Haye_Mokhtalef(iIndex1, iIndex2, true, 3);
                byte[] cellsIndexPlayer2Tayi = cpuDef_Check_And_Get_States_Player_Chand_Tayi_Haye_Mokhtalef(iIndex1, iIndex2, true, 2);

                if (cellsIndexPlayer4Tayi.Length > 0)
                {
                    inc_Array_Cells(ref cellsIndexPlayer4Tayi, 400, true);//age mitone 5-tayi kone dige baghie ro check nakon
                    return;
                }
                if (cellsIndexPlayer3Tayi.Length > 0)
                    inc_Array_Cells(ref cellsIndexPlayer3Tayi, 350, true);
                if (cellsIndexPlayer2Tayi.Length > 0)
                    inc_Array_Cells(ref cellsIndexPlayer2Tayi, 200, true);
            }
            else//CPU :
            {
                byte[] cellsIndexCPU4Tayi = cpuDef_Check_And_Get_States_Player_Chand_Tayi_Haye_Mokhtalef(iIndex1, iIndex2, false, 4);
                byte[] cellsIndexCPU3Tayi = cpuDef_Check_And_Get_States_Player_Chand_Tayi_Haye_Mokhtalef(iIndex1, iIndex2, false, 3);
                byte[] cellsIndexCPU2Tayi = cpuDef_Check_And_Get_States_Player_Chand_Tayi_Haye_Mokhtalef(iIndex1, iIndex2, false, 2);
                byte[] cellsIndexCPU1Tayi = cpuDef_Check_And_Get_States_Player_Chand_Tayi_Haye_Mokhtalef(iIndex1, iIndex2, false, 1);

                if (cellsIndexCPU4Tayi.Length>0)//age k mitoone 5-tayi beshe dige baghie ro check nakon
                {
                    inc_Array_Cells(ref cellsIndexCPU4Tayi, 400, false);
                    return ;
                }
                if (cellsIndexCPU3Tayi.Length > 0)
                    inc_Array_Cells(ref cellsIndexCPU3Tayi, 300, false);
                if (cellsIndexCPU2Tayi .Length>0)
                    inc_Array_Cells(ref cellsIndexCPU2Tayi, 200, false);
                if (cellsIndexCPU1Tayi.Length > 0)
                    inc_Array_Cells(ref cellsIndexCPU1Tayi, 100, false);
            }
        }

        private void inc_Array_Cells(ref byte[] CellsArray, int PriorityToInc,bool PlayerOrCPU)
        {
            for (int i = 0; i < CellsArray.Length; i++)
            {
                Cell_Info[CellsArray[i]].CellPriority += PriorityToInc;
                
                if (PriorityToInc == 400)//agar k alan 4-tayi dasht bayad Olaviat beheshoon bedam
                {
                    if (PlayerOrCPU)
                        Cell_Info[CellsArray[i]].CellPriority = -20;//baraye Player -20 bezar
                    else
                        Cell_Info[CellsArray[i]].CellPriority = -10;//baraye CPU -10 bezar
                }
            }
        }

        private void cpuDef_Reset_Vars()
        {
            Array.Resize(ref cpuDef_strCellsRadif, 0);
            cpuDef_IndexCellsRadif = 0;
            cpuDef_sum = 0;
            cpuDef_RadifOK = false;
        }

        private byte[] cpuDef_Check_And_Get_States_Player_Chand_Tayi_Haye_Mokhtalef(byte iIndex1, byte iIndex2, bool PlayerOrCPU, byte chandTayi)
        {   //if PlayerOrCPU == True => Player else CPU
            int  i = iIndex1; int j= iIndex2;   //baraye inke Indexha ro baraye Ghotre
            if (i < j)                          //Asli Temp konam
            { j = j - i; i = 0; }
            else if (i > j)
            { i = i - j; j = 0; }
            else
                i = j = 0;

            int i2 = iIndex1; int j2 = iIndex2;   //baraye inke Indexha ro baraye Ghotre
            if ((i2 + j2) >= 13)                  //Farei Temp konam
            {
                i2 = (i2 + j2) - 13 + 1;
                j2 = 13 - 1;
            }
            else
            {
                j2 = (i2 + j2) - 0;
                i2 = 0;
            }

            byte[] bArrStatesHarifChandTayi = new byte[0];

            //chap-2-Rast :
            //reset variables 4 checking state 
            cpuDef_Reset_Vars();
            //baraye inke state-haye 4-tayi ro check kone 
            Array.Resize(ref cpuDef_strCellsRadif, chandTayi);
            //Array baraye inke state-haye 4-tayi ro dashte bashim 
            byte[] bArrStatesChap2Rast = cpuDef_Check_Chap_2_Rast(iIndex1, 0, PlayerOrCPU , chandTayi);

            //bala-2-Payin :
            //reset variables 4 checking state :
            cpuDef_Reset_Vars();
            //baraye inke state-haye 4-tayi ro check kone :
            Array.Resize(ref cpuDef_strCellsRadif, chandTayi);
            //Array baraye inke state-haye 4-tayi ro dashte bashim :
            byte[] bArrStatesBala2Payin = cpuDef_Check_Bala_2_Payin(0, iIndex2, PlayerOrCPU, chandTayi);

            //Ghotre-Asli :
            //reset variables 4 checking state :
            cpuDef_Reset_Vars();
            //baraye inke state-haye 4-tayi ro check kone :
            Array.Resize(ref cpuDef_strCellsRadif, chandTayi);
            //Array baraye inke state-haye 4-tayi ro dashte bashim :
            byte[] bArrStatesGhotreAsli = cpuDef_Check_Ghotre_Asli(i, j, PlayerOrCPU, chandTayi);

            //Ghotre-Farei :
            //reset variables 4 checking state :
            cpuDef_Reset_Vars();
            //baraye inke state-haye 4-tayi ro check kone :
            Array.Resize(ref cpuDef_strCellsRadif, chandTayi);
            //Array baraye inke state-haye 4-tayi ro dashte bashim :
            byte[] bArrStatesGhotreFarei = cpuDef_Check_Ghotre_Farei(i2, j2, PlayerOrCPU, chandTayi);


            if (bArrStatesBala2Payin != null)
            {
                Array.Resize(ref bArrStatesHarifChandTayi, bArrStatesHarifChandTayi.Length + bArrStatesBala2Payin.Length);
                Array.Copy(bArrStatesBala2Payin, 0, bArrStatesHarifChandTayi, 0, bArrStatesBala2Payin.Length);
            }
            if (bArrStatesChap2Rast != null)
            {
                int iIndexTmp = bArrStatesHarifChandTayi.Length;
                Array.Resize(ref bArrStatesHarifChandTayi, bArrStatesHarifChandTayi.Length + bArrStatesChap2Rast.Length);
                Array.Copy(bArrStatesChap2Rast, 0, bArrStatesHarifChandTayi, iIndexTmp, bArrStatesChap2Rast.Length);
            }
            if (bArrStatesGhotreAsli != null)
            {
                int iIndexTmp = bArrStatesHarifChandTayi.Length;
                Array.Resize(ref bArrStatesHarifChandTayi, bArrStatesHarifChandTayi.Length + bArrStatesGhotreAsli.Length);
                Array.Copy(bArrStatesGhotreAsli, 0, bArrStatesHarifChandTayi, iIndexTmp, bArrStatesGhotreAsli.Length);
            }
            if (bArrStatesGhotreFarei != null)
            {
                int iIndexTmp = bArrStatesHarifChandTayi.Length;
                Array.Resize(ref bArrStatesHarifChandTayi, bArrStatesHarifChandTayi.Length + bArrStatesGhotreFarei.Length);
                Array.Copy(bArrStatesGhotreFarei, 0, bArrStatesHarifChandTayi, iIndexTmp, bArrStatesGhotreFarei.Length);
            }
            return bArrStatesHarifChandTayi;//Cell-haye 2 taraf-e yek reshteye chand-tayi ro bar migardoone
        }

        #region Checking chap_2_Rast o Bala_2_Payin , Ghotr-ha ... :

        private byte[] cpuDef_Check_Chap_2_Rast(int  i, int  j, bool blnArrPlayer1OR2, byte chandTaCell)
        {
            if (j > 12)
                return null;
            else
                cpuDef_Check_Chap_2_Rast(i, j + 1, blnArrPlayer1OR2,chandTaCell );

            if (blnArrPlayer1OR2)        //blnArrPlayer1OR2 = True => player1 else player2
                if (FrmMain.blnArrPlayer1Selection[i, j])
                {
                    if (cpuDef_IndexCellsRadif < chandTaCell && !cpuDef_RadifOK)
                    {
                        string tmp1 = FrmMain.lblCells[i, j].Tag.ToString();
                        string tmp2 = tmp1.Substring(0, tmp1.LastIndexOf(',') );
                        cpuDef_strCellsRadif[cpuDef_IndexCellsRadif++] = tmp2;
                    }
                    cpuDef_sum++;
                    if (cpuDef_sum >= chandTaCell )
                        cpuDef_RadifOK = true;
                }
                else
                    cpuDef_sum = cpuDef_IndexCellsRadif  = 0;
            else//cpu moving :
                if (FrmMain.blnArrPlayer2Selection[i, j])
                {
                    if (cpuDef_IndexCellsRadif < chandTaCell && !cpuDef_RadifOK)
                    {
                        string tmp1 = FrmMain.lblCells[i, j].Tag.ToString();
                        string tmp2 = tmp1.Substring(0, tmp1.LastIndexOf(','));
                        cpuDef_strCellsRadif[cpuDef_IndexCellsRadif++] = tmp2;
                    }
                    cpuDef_sum++;
                    if (cpuDef_sum >= chandTaCell)
                        cpuDef_RadifOK = true;
                }
                else
                    cpuDef_sum = cpuDef_IndexCellsRadif = 0;


            //agar k 4-tayi peida kard bayad> Cell-haye ghabl az avvalin khoone va Bad az akharin khoone ro begiram Index-esho...yani bayad in 2 ta khoone k migiram ro Priority shoono ++ konam
            if (cpuDef_RadifOK)
            {
                return cpuDef_F_Get_Cells_For_Chap_2_Rast();
            }
            else
            {
                return null;
            }
        }

        private byte[] cpuDef_F_Get_Cells_For_Chap_2_Rast()
        {
            byte[] iTmp = new byte[0];
            byte iTmpIndex = 0;
            string[] strArrTmp = cpuDef_strCellsRadif[cpuDef_strCellsRadif.Length - 1].Split(',');
            byte bIndex1 = byte.Parse(strArrTmp[0]);
            byte bIndex2 = byte.Parse(strArrTmp[1]);
            if (bIndex2 - 1 >= 0 && FrmMain.lblCells[bIndex1, bIndex2 - 1].Tag.ToString().Split(',').Length < 3) // && entekhab nashoe bashe)
            {
                byte iCellIndexFirst = (byte)giveMe_Cell_Index_From_This_Index_String(cpuDef_strCellsRadif[cpuDef_strCellsRadif.Length - 1]);
                iCellIndexFirst--;
                Array.Resize(ref iTmp, iTmpIndex + 1);
                iTmp[iTmpIndex++] = iCellIndexFirst;
            }

            //baraye khooneye Samt-e Rasti //yani bayad bebine k bad az akharin khoone aya khali hast :
            strArrTmp = cpuDef_strCellsRadif[0].Split(',');
            bIndex1 = byte.Parse(strArrTmp[0]);
            bIndex2 = byte.Parse(strArrTmp[1]);
            if (bIndex2 + 1 <= 12 && FrmMain.lblCells[bIndex1, bIndex2 + 1].Tag.ToString().Split(',').Length < 3) // && entekhab nashoe bashe)
            {
                byte iCellIndexLast = (byte)giveMe_Cell_Index_From_This_Index_String(cpuDef_strCellsRadif[0]);
                iCellIndexLast++;
                Array.Resize(ref iTmp, iTmpIndex + 1);
                iTmp[iTmpIndex] = iCellIndexLast;
            }
            return iTmp;
        }

        private byte[] cpuDef_Check_Bala_2_Payin(int i, int j, bool blnArrPlayer1OR2, byte chandTaCell)
        {
            if (i > 12)
                return null;
            else
                cpuDef_Check_Bala_2_Payin(i + 1, j, blnArrPlayer1OR2,chandTaCell );

            if (blnArrPlayer1OR2)        //blnArrPlayer1OR2 = True => player1 else player2
                if (FrmMain.blnArrPlayer1Selection[i, j])
                {
                    if (cpuDef_IndexCellsRadif < chandTaCell && !cpuDef_RadifOK)
                    {
                        string tmp1 = FrmMain.lblCells[i, j].Tag.ToString();
                        string tmp2 = tmp1.Substring(0, tmp1.LastIndexOf(','));
                        cpuDef_strCellsRadif[cpuDef_IndexCellsRadif++] = tmp2;
                    }
                    cpuDef_sum++;
                    if (cpuDef_sum >= chandTaCell)
                        cpuDef_RadifOK = true;
                }
                else
                    cpuDef_sum = cpuDef_IndexCellsRadif = 0;
            else//cpu moving :
                if (FrmMain.blnArrPlayer2Selection[i, j])
                {
                    if (cpuDef_IndexCellsRadif < chandTaCell && !cpuDef_RadifOK)
                    {
                        string tmp1 = FrmMain.lblCells[i, j].Tag.ToString();
                        string tmp2 = tmp1.Substring(0, tmp1.LastIndexOf(','));
                        cpuDef_strCellsRadif[cpuDef_IndexCellsRadif++] = tmp2;
                    }
                    cpuDef_sum++;
                    if (cpuDef_sum >= chandTaCell)
                        cpuDef_RadifOK = true;
                }
                else
                    cpuDef_sum = cpuDef_IndexCellsRadif = 0;


            //agar k 4-tayi peida kard bayad> Cell-haye ghabl az avvalin khoone va Bad az akharin khoone ro begiram Index-esho...yani bayad in 2 ta khoone k migiram ro Priority shoono ++ konam
            if (cpuDef_RadifOK)
            {
                return cpuDef_F_Get_Cells_For_Bala_2_Payin ();
            }
            else
            {
                return null;
            }
        }

        private byte[] cpuDef_F_Get_Cells_For_Bala_2_Payin()
        {
            //baraye khooneye Samt-e Bala //yani bayad bebine k ghabl az avvalin khoone aya khali hast :                byte[] iTmp=new byte[0];
            byte[] iTmp = new byte[0];
            byte iTmpIndex = 0;
            string[] strArrTmp = cpuDef_strCellsRadif[cpuDef_strCellsRadif.Length - 1].Split(',');
            byte bIndex1 = byte.Parse(strArrTmp[0]);
            byte bIndex2 = byte.Parse(strArrTmp[1]);
            if (bIndex1 - 1 >= 0 && FrmMain.lblCells[bIndex1 - 1, bIndex2].Tag.ToString().Split(',').Length < 3) // && entekhab nashoe bashe)
            {
                byte iCellIndexFirst = (byte)giveMe_Cell_Index_From_This_Index_String(cpuDef_strCellsRadif[cpuDef_strCellsRadif.Length - 1]);
                iCellIndexFirst -= 13;
                Array.Resize(ref iTmp, iTmpIndex + 1);
                iTmp[iTmpIndex++] = iCellIndexFirst;
            }

            //baraye khooneye Samt-e Payin //yani bayad bebine k bad az akharin khoone aya khali hast :
            strArrTmp = cpuDef_strCellsRadif[0].Split(',');
            bIndex1 = byte.Parse(strArrTmp[0]);
            bIndex2 = byte.Parse(strArrTmp[1]);
            if (bIndex1 + 1 <= 12  && FrmMain.lblCells[bIndex1 + 1, bIndex2].Tag.ToString().Split(',').Length < 3) // && entekhab nashoe bashe)
            {
                byte iCellIndexLast = (byte)giveMe_Cell_Index_From_This_Index_String(cpuDef_strCellsRadif[0]);
                iCellIndexLast += 13;
                Array.Resize(ref iTmp, iTmpIndex + 1);
                iTmp[iTmpIndex] = iCellIndexLast;
            }
            return iTmp;
        }

        private byte[] cpuDef_Check_Ghotre_Asli(int i, int j, bool blnArrPlayer1OR2, byte chandTaCell)
        {
            if ((i <= j && j > 12) || ((i > j && i > 12)))
                return null;
            else
                cpuDef_Check_Ghotre_Asli(i + 1, j + 1, blnArrPlayer1OR2,chandTaCell );

            if (blnArrPlayer1OR2)        //blnArrPlayer1OR2 = True => player1 else player2
                if (FrmMain.blnArrPlayer1Selection[i, j])
                {
                    if (cpuDef_IndexCellsRadif < chandTaCell && !cpuDef_RadifOK)
                    {
                        string tmp1 = FrmMain.lblCells[i, j].Tag.ToString();
                        string tmp2 = tmp1.Substring(0, tmp1.LastIndexOf(','));
                        cpuDef_strCellsRadif[cpuDef_IndexCellsRadif++] = tmp2;
                    }
                    cpuDef_sum++;
                    if (cpuDef_sum >= chandTaCell)
                        cpuDef_RadifOK = true;
                }
                else
                    cpuDef_sum = cpuDef_IndexCellsRadif = 0;
            else//cpu moving :
                if (FrmMain.blnArrPlayer2Selection[i, j])
                {
                    if (cpuDef_IndexCellsRadif < chandTaCell && !cpuDef_RadifOK)
                    {
                        string tmp1 = FrmMain.lblCells[i, j].Tag.ToString();
                        string tmp2 = tmp1.Substring(0, tmp1.LastIndexOf(','));
                        cpuDef_strCellsRadif[cpuDef_IndexCellsRadif++] = tmp2;
                    }
                    cpuDef_sum++;
                    if (cpuDef_sum >= chandTaCell)
                        cpuDef_RadifOK = true;
                }
                else
                    cpuDef_sum = cpuDef_IndexCellsRadif = 0;


            //agar k 4-tayi peida kard bayad> Cell-haye ghabl az avvalin khoone va Bad az akharin khoone ro begiram Index-esho...yani bayad in 2 ta khoone k migiram ro Priority shoono ++ konam
            if (cpuDef_RadifOK)
            {
                return cpuDef_F_Get_Cells_For_Ghotre_Asli();
            }
            else
            {
                return null;
            }
        }

        private byte[] cpuDef_F_Get_Cells_For_Ghotre_Asli()
        {
            byte[] iTmp = new byte[0];
            byte iTmpIndex = 0;
            string[] strArrTmp = cpuDef_strCellsRadif[cpuDef_strCellsRadif.Length - 1].Split(',');
            byte bIndex1 = byte.Parse(strArrTmp[0]);
            byte bIndex2 = byte.Parse(strArrTmp[1]);
            if (bIndex1 - 1 >= 0 && bIndex2 - 1 >= 0  && FrmMain.lblCells[bIndex1 - 1, bIndex2 - 1].Tag.ToString().Split(',').Length < 3) // && entekhab nashoe bashe)
            {
                byte iCellIndexFirst = (byte)giveMe_Cell_Index_From_This_Index_String(cpuDef_strCellsRadif[cpuDef_strCellsRadif.Length - 1]);
                iCellIndexFirst -= 14;
                Array.Resize(ref iTmp, iTmpIndex + 1);
                iTmp[iTmpIndex++] = iCellIndexFirst;
            }

            //baraye khooneye Samt-e Rasti //yani bayad bebine k bad az akharin khoone aya khali hast :
            strArrTmp = cpuDef_strCellsRadif[0].Split(',');
            bIndex1 = byte.Parse(strArrTmp[0]);
            bIndex2 = byte.Parse(strArrTmp[1]);
            if (bIndex1 + 1 <= 12 && bIndex2 + 1 <= 12 && FrmMain.lblCells[bIndex1 + 1 , bIndex2 + 1].Tag.ToString().Split(',').Length < 3) // && entekhab nashoe bashe)
            {
                byte iCellIndexLast = (byte)giveMe_Cell_Index_From_This_Index_String(cpuDef_strCellsRadif[0]);
                iCellIndexLast += 14;
                Array.Resize(ref iTmp, iTmpIndex + 1);
                iTmp[iTmpIndex] = iCellIndexLast;
            }
            return iTmp;
        }

        private byte[] cpuDef_Check_Ghotre_Farei(int i, int j, bool blnArrPlayer1OR2, byte chandTaCell)
        {
            if ((i > j && j < 0) || (i > j && i > 12))
                return null;
            else
                cpuDef_Check_Ghotre_Farei(i + 1, j - 1, blnArrPlayer1OR2, chandTaCell);

            if (blnArrPlayer1OR2)        //blnArrPlayer1OR2 = True => player1 else player2
                if (FrmMain.blnArrPlayer1Selection[i, j])
                {
                    if (cpuDef_IndexCellsRadif < chandTaCell && !cpuDef_RadifOK)
                    {
                        string tmp1 = FrmMain.lblCells[i, j].Tag.ToString();
                        string tmp2 = tmp1.Substring(0, tmp1.LastIndexOf(','));
                        cpuDef_strCellsRadif[cpuDef_IndexCellsRadif++] = tmp2;
                    }
                    cpuDef_sum++;
                    if (cpuDef_sum >= chandTaCell)
                        cpuDef_RadifOK = true;
                }
                else
                    cpuDef_sum = cpuDef_IndexCellsRadif = 0;
            else//cpu moving :
                if (FrmMain.blnArrPlayer2Selection[i, j])
                {
                    if (cpuDef_IndexCellsRadif < chandTaCell && !cpuDef_RadifOK)
                    {
                        string tmp1 = FrmMain.lblCells[i, j].Tag.ToString();
                        string tmp2 = tmp1.Substring(0, tmp1.LastIndexOf(','));
                        cpuDef_strCellsRadif[cpuDef_IndexCellsRadif++] = tmp2;
                    }
                    cpuDef_sum++;
                    if (cpuDef_sum >= chandTaCell)
                        cpuDef_RadifOK = true;
                }
                else
                    cpuDef_sum = cpuDef_IndexCellsRadif = 0;


            //agar k 4-tayi peida kard bayad> Cell-haye ghabl az avvalin khoone va Bad az akharin khoone ro begiram Index-esho...yani bayad in 2 ta khoone k migiram ro Priority shoono ++ konam
            if (cpuDef_RadifOK)
            {
                return cpuDef_F_Get_Cells_For_Ghotre_Farei();
            }
            else
            {
                return null;
            }
        }

        private byte[] cpuDef_F_Get_Cells_For_Ghotre_Farei()
        {
            byte[] iTmp = new byte[0];
            byte iTmpIndex = 0;
            string[] strArrTmp = cpuDef_strCellsRadif[cpuDef_strCellsRadif.Length - 1].Split(',');
            byte bIndex1 = byte.Parse(strArrTmp[0]);
            byte bIndex2 = byte.Parse(strArrTmp[1]);
            if (bIndex1 - 1 >= 0 && bIndex2 + 1 <=12 && FrmMain.lblCells[bIndex1 - 1, bIndex2 + 1].Tag.ToString().Split(',').Length < 3) // && entekhab nashoe bashe)
            {
                byte iCellIndexFirst = (byte)giveMe_Cell_Index_From_This_Index_String(cpuDef_strCellsRadif[cpuDef_strCellsRadif.Length - 1]);
                iCellIndexFirst -= 12;
                Array.Resize(ref iTmp, iTmpIndex + 1);
                iTmp[iTmpIndex++] = iCellIndexFirst;
            }

            //baraye khooneye Samt-e Rasti //yani bayad bebine k bad az akharin khoone aya khali hast :
            strArrTmp = cpuDef_strCellsRadif[0].Split(',');
            bIndex1 = byte.Parse(strArrTmp[0]);
            bIndex2 = byte.Parse(strArrTmp[1]);
            if (bIndex1 + 1 <= 12 && bIndex2 - 1 >= 0 && FrmMain.lblCells[bIndex1 + 1, bIndex2 - 1].Tag.ToString().Split(',').Length < 3) // && entekhab nashoe bashe)
            {
                byte iCellIndexLast = (byte)giveMe_Cell_Index_From_This_Index_String(cpuDef_strCellsRadif[0]);
                iCellIndexLast += 12;
                Array.Resize(ref iTmp, iTmpIndex + 1);
                iTmp[iTmpIndex] = iCellIndexLast;
            }
            return iTmp;
        }


        #endregion checking chap_2_rast o bala_2_payin,.../

        #endregion cpu defence/


        #endregion icpu members

    }
}
