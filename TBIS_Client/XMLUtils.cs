using System;
using System.IO;
using System.Xml.Serialization;

namespace HentRestgaeld
{
    public static class XMLUtils
    {

        public static string WriteXML(object o, string filename)
        {
            string fullpath = WriteXML(o, filename, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            return (fullpath);
        }

        public static string WriteXML(object o, string filename, string path)
        {
            string fullpath = Path.Combine(path, filename);
            XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(o.GetType());
            System.IO.StreamWriter file = new System.IO.StreamWriter(fullpath);
            writer.Serialize(file, o);
            file.Close();
            return (fullpath);
        }

        public static void ReadXML(object o, string path)
        {
            XmlSerializer serializer = new XmlSerializer(o.GetType());
            FileStream loadStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            o = serializer.Deserialize(loadStream);
            loadStream.Close();
        }

        public static string SerializeToString(object o)
        {
            XmlSerializer serializer = new XmlSerializer(o.GetType());

            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, o);

                return writer.ToString();
            }
        }
    }
}
