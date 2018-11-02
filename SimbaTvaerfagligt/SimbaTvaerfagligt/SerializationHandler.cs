using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace SimbaTvaerfagligt
{
    public static class SerializationHandler
    {
        public static string SerializeRound(Savanna s)
        {


            // Insert code to set properties and fields of the object.  
            XmlSerializer mySerializer = new XmlSerializer(s.GetType());
            // To write to a file, create a StreamWriter object.  
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            mySerializer.Serialize(sw, s);
            sw.Close();

            return sb.ToString();
        }

        //DeSerialization mangler

        //public static string DeserializeRound( string filename)
        //{


        //    // Construct an instance of the XmlSerializer with the type  
        //    // of object that is being deserialized.  
        //    XmlSerializer mySerializer =
        //    new XmlSerializer(typeof(Savanna));
        //    // To read the file, create a FileStream.  
        //    FileStream fs =
        //    new FileStream(filename, FileMode.Open);
        //    // Call the Deserialize method and cast to the object type.  
        //    myObject = (MySerializableClass)
        //    mySerializer.Deserialize(myFileStream)


        //    return;
        //}

    }
}
