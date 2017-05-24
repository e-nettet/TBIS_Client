using System;
using System.Text;
using System.IO;
using System.Xml.Serialization;
<<<<<<< HEAD
=======
using System.Threading.Tasks;
using SRestgaeld63;
using FRestgaeld6;
>>>>>>> 9032b84ebd9601e660563dc6e5b4e654211c4e44

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

        public static FRestgaeld6.FRestgaeld6_Type GetFRestgaeld6_Type(string modtager_partid, string ejendomsident, string kontrolkode, FRestgaeld6.Kodeliste4 institut, string laaneidentifikation)
        {
<<<<<<< HEAD
            FRestgaeld6.FRestgaeld6_Type f = new FRestgaeld6.FRestgaeld6_Type();
            f.DOCINF = new FRestgaeld6.DOCINF_Type()
=======
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

        public static FRestgaeld6_Type GetFRestgaeld6_Type(string modtager_partid, string ejendomsident, string kontrolkode, FRestgaeld6.Kodeliste4 institut, string laaneidentifikation)
        {
            FRestgaeld6_Type f = new FRestgaeld6_Type();
            f.DOCINF = new DOCINF_Type()
>>>>>>> 9032b84ebd9601e660563dc6e5b4e654211c4e44
            {
                Afsender_partid = "mangler",
                Dato = RKNetUtils.GetDateAs_YYYYMMDD(),
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

        public static string GetPart(FRestgaeld6.Kodeliste4 institut, Miljoe miljoe)
        {
            string s = "";
            switch (miljoe)
            {
                case Miljoe.Produktion:
                    {
                        switch (institut)
                        {
                            case FRestgaeld6.Kodeliste4.BRF:
                                s = "5790000633494:14";
                                break;
                            case FRestgaeld6.Kodeliste4.DLR:
                                s = "5790000633494:14";
                                break;
                            case FRestgaeld6.Kodeliste4.N:
                                s = "5790000633593:14";
                                break;
                            case FRestgaeld6.Kodeliste4.NOR:
                                s = "5790000614608:14";
                                break;
                            case FRestgaeld6.Kodeliste4.RD:
                                s = "5790000626328:14";
                                break;
                            case FRestgaeld6.Kodeliste4.TOT:
                                s = "5790000635702:14";
                                break;
                            default: break;
                        }
                        break;
                    }
                case Miljoe.Test:
                    {
                        switch (institut)
                        {
                            case FRestgaeld6.Kodeliste4.BRF:
                                s = "5790000611300:14";
                                break;
                            case FRestgaeld6.Kodeliste4.DLR:
                                s = "5790000660889:14";
                                break;
                            case FRestgaeld6.Kodeliste4.N:
                                s = "5790000661015:14";
                                break;
                            case FRestgaeld6.Kodeliste4.NOR:
                                s = "5790000611386:14";
                                break;
                            case FRestgaeld6.Kodeliste4.RD:
                                s = "5790000660926:14";
                                break;
                            case FRestgaeld6.Kodeliste4.TOT:
                                s = "5790000611522:14";
                                break;
                            default: break;
                        }
                        break;
                    }
                default: break;
            }
            return (s);
        }

<<<<<<< HEAD
=======
        public static FRestgaeld6.Kodeliste4 PartToKodeliste4(Part part)
        {
            switch (part.beskrivelse)
            {
                case "BRF":
                    return FRestgaeld6.Kodeliste4.BRF;
                case "DLR":
                    return FRestgaeld6.Kodeliste4.DLR;
                case "LRF":
                    return FRestgaeld6.Kodeliste4.LRF;
                case "N":
                    return FRestgaeld6.Kodeliste4.N;
                case "RD":
                    return FRestgaeld6.Kodeliste4.RD;
                case "TOT":
                    return FRestgaeld6.Kodeliste4.TOT;
                case "NOR":
                default:
                    return FRestgaeld6.Kodeliste4.NOR;
            }
        }


>>>>>>> 9032b84ebd9601e660563dc6e5b4e654211c4e44
    }
}
