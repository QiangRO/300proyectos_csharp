using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace DictionaryFromHamze.WorkingWithXML
{
    public class XMLSerializable
    {

        #region XML Serialization Methods
        public void SaveAsXML(String XMLSavePath)
        {
            FileStream FileStr;
            if (!File.Exists(XMLSavePath))
            {
                FileStr = new FileStream(XMLSavePath, FileMode.Create);
            }
            else
            {
                File.Delete(XMLSavePath);
                FileStr = new FileStream(XMLSavePath, FileMode.Create);
            }
            Save(FileStr);
            FileStr.Close();
        }
        private void Save(Stream Str)
        {
            XmlSerializer XMLS = new XmlSerializer(this.GetType());
            XMLS.Serialize(Str, this);
        } 
        #endregion

        #region XML DeSerialization Methods
        public Object Load(String XMLSourcePath, Type typeofObj)
        {
            Object Ret;
            FileInfo FileInfo = new FileInfo(XMLSourcePath);
            if (!FileInfo.Exists)
            {
                Ret = System.Activator.CreateInstance(typeofObj);
                return Ret;
            }
            FileStream Read = new FileStream(XMLSourcePath, FileMode.Open);
            Ret = Load(Read, typeofObj);
            return Ret;
        }
        public Object Load(Stream Str, Type typeofObj)
        {
            XmlSerializer XMLS = new XmlSerializer(typeofObj);
            return (Object)XMLS.Deserialize(Str);
        } 
        #endregion
    }
}
