using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace HentRestgaeld
{

    static class RESTGAELD_Utils
    {
        public static SRestgaeld63.SRestgaeld63_Type GetRestgaeldFromString(string s)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SRestgaeld63.SRestgaeld63_Type));
            MemoryStream memStream = new MemoryStream(Encoding.UTF8.GetBytes(s));
            SRestgaeld63.SRestgaeld63_Type srestgaeld = (SRestgaeld63.SRestgaeld63_Type)serializer.Deserialize(memStream);
            return (srestgaeld);
        }

        public static string GetClassAsXMLString(object o) // Anvendes til at udfylde Query elementet korrekt
        {
            StringWriter stringwriter = new System.IO.StringWriter();
            XmlSerializer serializer = new XmlSerializer(o.GetType());
            serializer.Serialize(stringwriter, o);
            string s = GetFormattedQuery( stringwriter.ToString());
            return (s);
        }

        private static string GetFormattedQuery(string s) // Fjerner linjer og tabulatorer, da RKNET ikke kan lide dem
        {
            string t = s;
            t = t.Replace(System.Environment.NewLine, "");
            t = t.Replace(">\n", ">"); // Newline følger åbenbart ikke altid standarden...
            t = t.Replace(">\r\n", ">"); // Newline følger åbenbart ikke altid standarden...
            t = t.Replace(">\t", ">");
            while (t.IndexOf("> ") >= 0) { t = t.Replace("> ", ">"); }
            return (t);
        }

        public static FRestgaeld6.FRestgaeld6_Type GetFRestgaeld6_Type(string modtager_partid, string ejendomsident, string kontrolkode, FRestgaeld6.Kodeliste4 institut, string laaneidentifikation)
        {
            FRestgaeld6.FRestgaeld6_Type f = new FRestgaeld6.FRestgaeld6_Type();
            f.DOCINF = new FRestgaeld6.DOCINF_Type()
            {
                Afsender_partid = "mangler",
                Dato = GetDateAs_YYYYMMDD(),
                IDkode = "J000110",
                informationsstromnavn = "F[rkn] Restgaeld 6 XML",
                Meddelelsens_funktion = FRestgaeld6.Kodeliste5.Item53,
                Meddelelsens_navn = FRestgaeld6.Meddelelsens_navn.Z06,
                Meddelelsens_nummer = "123456", // Tilsyneladende uden betydning
                Meddelelsens_type = FRestgaeld6.Meddelelsens_type.REQDOC,
                Modtager_partid = modtager_partid,
                Modtager_version = "063",
                Onsket_version = "063",
                Sender_version = "060"
            };
            f.EJDMID = new FRestgaeld6.EJDMID_Type()
            {
                Ejendomsident = ejendomsident,
                KTRLKD = new FRestgaeld6.KTRLKD_Type()
                {
                    Reference_nr = kontrolkode
                }
            };
            f.INSTIT = new FRestgaeld6.INSTIT_Type()
            {
                Institut = institut,
                InstitutSpecified = true
            };
            f.LAANID = new FRestgaeld6.LAANID_Type() { Laaneidentifikation = laaneidentifikation };
            f.RESTAN = new FRestgaeld6.RESTAN_Type()
            {
                Onskes_restanceoplysninger = FRestgaeld6.Kodeliste1.Ja,
                Onskes_restanceoplysningerSpecified = true
            };
            f.AMORTF = new FRestgaeld6.AMORTF_Type()
            {
                Onskes_amortoplysninger = FRestgaeld6.Kodeliste1.Ja,
                Onskes_amortoplysningerSpecified = true
            };
            return (f);
        }

        public static string GetDateAs_YYYYMMDD()
        {
            DateTime dt = DateTime.Now;
            string m = ("0" + dt.Month.ToString());
            m = m.Substring(m.Length - 2, 2);
            string d = ("0" + dt.Day.ToString());
            d = d.Substring(d.Length - 2, 2);
            string y = dt.Year.ToString();
            string s = y + m + d;
            return (s);
        }


    }
}
