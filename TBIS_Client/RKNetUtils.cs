using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace HentRestgaeld
{
    static class RKNetUtils
    {
        public static string GetClassAsXMLString(object o)
        {
            Encoding encoding = Encoding.GetEncoding("ISO-8859-1");
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings
            {
                Indent = true,
                OmitXmlDeclaration = false,
                Encoding = encoding
            };
            MemoryStream stream = new MemoryStream();
            XmlWriter xmlWriter = XmlWriter.Create(stream, xmlWriterSettings);
            XmlSerializer serializer = new XmlSerializer(o.GetType()); 
            serializer.Serialize(xmlWriter, o);
            string s = encoding.GetString(stream.ToArray());
            return s;
        }

        public static string GetDateAs_YYYYMMDD(DateTime dt)
        {
            string m = ("0" + dt.Month.ToString());
            m = m.Substring(m.Length - 2, 2);
            string d = ("0" + dt.Day.ToString());
            d = d.Substring(d.Length - 2, 2);
            string y = dt.Year.ToString();
            string s = y + m + d;
            return (s);
        }

        public static string GetDateAs_YYYYMMDD()
        {
            DateTime dt = DateTime.Now;
            string s = GetDateAs_YYYYMMDD(dt);
            return (s);
        }

    }
}
