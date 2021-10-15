using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Collections;

namespace DictionaryFromHamze.Core
{
    public class Dic : WorkingWithXML.XMLSerializable
    {
        [XmlIgnore]
        public ArrayList Words = new ArrayList();
        /*
         public String DictionaryTitle
         {
             get
             {
                 return this.DictionaryTitle;
             }
             set
             {
                 this.DictionaryTitle = value;
             }
         }
         * */

        public Core.DicEnt[] AllWords
        {
            get
            {
                Core.DicEnt[] All = new Core.DicEnt[Words.Count];
                int counter = 0;
                foreach (Core.DicEnt DE in Words)
                {
                    All[counter++] = DE;
                }
                return All;
            }
            set
            {
                Words.Clear();
                if (value != null)
                    foreach (Core.DicEnt DE in value)
                        Words.Add(DE);
            }
        }
        public void AddWord(String WordAndMean)
        {

            Core.DicEnt DE = new DicEnt();
            DE.W_M = WordAndMean;
            //DE.Word_ID = count;
            Words.Add(DE);
        }
    }
}
