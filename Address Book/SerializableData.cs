using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace Address_Book
{
    public class SerializableData
    {
        public void Save(string filename)
        {
            String tempFilename;
            tempFilename = filename + ".tmp";
            FileInfo tempFileInfo = new FileInfo(tempFilename);
            if (tempFileInfo.Exists)
                tempFileInfo.Delete();
            FileStream stream = new FileStream(tempFilename, FileMode.Create);
            Save(stream);
            stream.Close();
            tempFileInfo.CopyTo(filename,true);
            tempFileInfo.Delete();

        }
        public void Save(Stream stream)
        {
            XmlSerializer serializer = new XmlSerializer(this.GetType());
            serializer.Serialize(stream, this);

        }
        public static Object Load(Stream stream, Type newType)
        {
            // create a serializer and load the object....
            XmlSerializer serializer = new XmlSerializer(newType);
            Object newObject = serializer.Deserialize(stream);
            // return the new object...
            return newObject;
        }
        public static Object Load(String filename, Type newType)
        {
            // does the file exist?
            FileInfo fileInfo = new FileInfo(filename);
            if (!fileInfo.Exists)
            {
                // create a blank version of the object and return that...
                return System.Activator.CreateInstance(newType);
            }
            // open the file...
            FileStream stream = new FileStream(filename, FileMode.Open);
            // load the object from the stream...
            Object newObject = Load(stream, newType);
            // close the stream...
            stream.Close();
            // return the object...
            return newObject;
        }
        
    }
}
