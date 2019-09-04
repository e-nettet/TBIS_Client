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
    public enum DataType { Restgaeld, Omregningskurstabller, EgnePapirer, AllePapirer, Satser, Priser, EjendomSummarisk, IndskannetAkt, DokumentAktuel }

    public abstract class RKNet_Utils
    {
        private DataType datatype;
        private Miljoe miljoe;
        private string afsender_partid;
        private string modtager_partid;
        private string jnummer;

        public Miljoe Miljoe { get => miljoe; set => miljoe = value; }
        public string Afsender_partid { get => afsender_partid; set => afsender_partid = value; }
        public string Jnummer { get => jnummer; set => jnummer = value; }
        public string Modtager_partid { get => modtager_partid; set => modtager_partid = value; }
        public DataType Datatype { get => datatype; set => datatype = value; }

        public abstract string GetQuery();
        public abstract string GetModtagerpart();

        public string GetClassAsXMLString(object o)
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

        public string GetDateAs_YYYYMMDD(DateTime dt)
        {
            string m = ("0" + dt.Month.ToString());
            m = m.Substring(m.Length - 2, 2);
            string d = ("0" + dt.Day.ToString());
            d = d.Substring(d.Length - 2, 2);
            string y = dt.Year.ToString();
            string s = y + m + d;
            return (s);
        }

        public string GetDateAs_YYYYMMDD()
        {
            string s = GetDateAs_YYYYMMDD(DateTime.Now);
            return (s);
        }

        public string GetInfoFlowName()
        {
            string s = "";
            switch (datatype)
            {
                case DataType.AllePapirer:
                    s = "F [rkn] AllePapirer 6 XML";
                    break;
                case DataType.EgnePapirer:
                    s = "F [rkn] EgnePapirer 6 XML";
                    break;
                case DataType.Omregningskurstabller:
                    s = "F [rkn] Tabeller 6 XML";
                    break;
                case DataType.Priser:
                    s = "F [rkn] Priser 6 XML";
                    break;
                case DataType.Restgaeld:
                    s = "F [rkn] Restgaeld 6 XML";
                    break;
                case DataType.Satser:
                    s = "F [rkn] Satser 6 XML";
                    break;

                case DataType.EjendomSummarisk:
                    s = "F [eTL] EjendomSummariskHent XML";
                    break;
                case DataType.IndskannetAkt:
                    s = "F [eTL] EjdIndskanAktHent XML";
                    break;
                case DataType.DokumentAktuel:
                    s = "F [eTL] DokumentAktuelHent XML";
                    break;
                default: break;
            }
            return (s);
        }

        public string GetDSPartid()
        {
            string s;
            switch (Miljoe)
            {
                case (Miljoe.Produktion):
                    s = "5790000611072:14";
                    break;
                case (Miljoe.Test):
                    s = "5790000611072:14";
                    break;
                default:
                    s = "";
                    break;
            }
            return (s);

        }
    }

}
