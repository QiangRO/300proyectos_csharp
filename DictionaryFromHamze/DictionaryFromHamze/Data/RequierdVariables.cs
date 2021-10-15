using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DictionaryFromHamze.Data
{
    public static class RequierdVariables
    {
        public static int AMinRang = 0, AMaxRang = 3851,
            BMinRang = 3852, BMaxRang = 6749,
            CMinRang = 6750, CMaxRang = 12156,
            DMinRang = 12157, DMaxRang = 15803,
            EMinRang = 15804, EMaxRang = 18301,
            FMinRang = 18302, FMaxRang = 20999,
            GMinRang = 21000, GMaxRang = 22849,
            HMinRang = 22850, HMaxRang = 24927,
            IMinRang = 24928, IMaxRang = 27480,
            JMinRang = 27481, JMaxRang = 27942,
            KMinRang = 27943, KMaxRang = 28404,
            LMinRang = 28405, LMaxRang = 30650,
            MMinRang = 30651, MMaxRang = 33998,
            NMinRang = 33999, NMaxRang = 35108,
            OMinRang = 35109, OMaxRang = 36454,
            PMinRang = 36455, PMaxRang = 41736,
            QMinRang = 41737, QMaxRang = 42046,
            RMinRang = 42047, RMaxRang = 45090,
            SMinRang = 45091, SMaxRang = 52621,
            TMinRang = 52622, TMaxRang = 56244,
            UMinRang = 56245, UMaxRang = 57386,
            VMinRang = 57387, VMaxRang = 58579,
            WMinRang = 58580, WMaxRang = 60080,
            XMinRang = 60081, XMaxRang = 60139,
            YMinRang = 60140, YMaxRang = 60282,
            ZMinRang = 60283, ZMaxRang = 60393;
        public static String[] Separator1 = { "--" };
        public static String[] Separator2 = { "::" };
        public static String[] Separator3 = { "،", "," };
        public static String errFindTxt = "متاسفانه کلمه مورد نظر شما در این بانک اطلاعاتی یافت نشد";
        //I CAN ADD DETAILS FOR ADDED DICTIONARIES TO THIS PROGRAM
        public static String GetRange(String Char)
        {
            if (Char.ToUpper().Equals("A"))
                return (AMinRang + "--" + AMaxRang).ToString();
            else if (Char.ToUpper().Equals("B"))
                return (BMinRang + "--" + BMaxRang).ToString();
            else if (Char.ToUpper().Equals("C"))
                return (CMinRang + "--" + CMaxRang).ToString();
            else if (Char.ToUpper().Equals("D"))
                return (DMinRang + "--" + DMaxRang).ToString();
            else if (Char.ToUpper().Equals("E"))
                return (EMinRang + "--" + EMaxRang).ToString();
            else if (Char.ToUpper().Equals("F"))
                return (FMinRang + "--" + FMaxRang).ToString();
            else if (Char.ToUpper().Equals("G"))
                return (GMinRang + "--" + GMaxRang).ToString();
            else if (Char.ToUpper().Equals("H"))
                return (HMinRang + "--" + HMaxRang).ToString();
            else if (Char.ToUpper().Equals("I"))
                return (IMinRang + "--" + IMaxRang).ToString();
            else if (Char.ToUpper().Equals("J"))
                return (JMinRang + "--" + JMaxRang).ToString();
            else if (Char.ToUpper().Equals("K"))
                return (KMinRang + "--" + KMaxRang).ToString();
            else if (Char.ToUpper().Equals("L"))
                return (LMinRang + "--" + LMaxRang).ToString();
            else if (Char.ToUpper().Equals("M"))
                return (MMinRang + "--" + MMaxRang).ToString();
            else if (Char.ToUpper().Equals("N"))
                return (NMinRang + "--" + NMaxRang).ToString();
            else if (Char.ToUpper().Equals("O"))
                return (OMinRang + "--" + OMaxRang).ToString();
            else if (Char.ToUpper().Equals("P"))
                return (PMinRang + "--" + PMaxRang).ToString();
            else if (Char.ToUpper().Equals("Q"))
                return (QMinRang + "--" + QMaxRang).ToString();
            else if (Char.ToUpper().Equals("R"))
                return (RMinRang + "--" + RMaxRang).ToString();
            else if (Char.ToUpper().Equals("S"))
                return (SMinRang + "--" + SMaxRang).ToString();
            else if (Char.ToUpper().Equals("T"))
                return (TMinRang + "--" + TMaxRang).ToString();
            else if (Char.ToUpper().Equals("U"))
                return (UMinRang + "--" + UMaxRang).ToString();
            else if (Char.ToUpper().Equals("V"))
                return (VMinRang + "--" + VMaxRang).ToString();
            else if (Char.ToUpper().Equals("W"))
                return (WMinRang + "--" + WMaxRang).ToString();
            else if (Char.ToUpper().Equals("X"))
                return (XMinRang + "--" + XMaxRang).ToString();
            else if (Char.ToUpper().Equals("Y"))
                return (YMinRang + "--" + YMaxRang).ToString();
            else if (Char.ToUpper().Equals("Z"))
                return (ZMinRang + "--" + ZMaxRang).ToString();


            return null;
        }
    }
}
