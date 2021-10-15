using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DictionaryFromHamze.Core
{
    public class DicEnt : WorkingWithXML.XMLSerializable
    {
        public String W_M;
        //public int Word_ID;
        /*public override string ToString()
        {
            return (this.E_W + " :: " + this.P_W).ToString();
        }*/
    }
}
