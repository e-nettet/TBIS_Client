using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HentRestgaeld
{
    public class TBGW_Utils : RKNet_Utils
    {
        private string cadastralDistrictIdentifier;
        private string matrikelnummer;
        private string dokumentIdentifikator;
        private string dokumentFilnavn;

        public string CadastralDistrictIdentifier { get => cadastralDistrictIdentifier; set => cadastralDistrictIdentifier = value; }
        public string Matrikelnummer { get => matrikelnummer; set => matrikelnummer = value; }
        public string DokumentIdentifikator { get => dokumentIdentifikator; set => dokumentIdentifikator = value; }
        public string DokumentFilnavn { get => dokumentFilnavn; set => dokumentFilnavn = value; }

        public TBGW_Utils(Miljoe miljoe, string afsender_partid, string jnummer, DataType datatype)
        {
            this.Miljoe = miljoe;
            this.Afsender_partid = afsender_partid;
            this.Jnummer = jnummer;
            this.Datatype = datatype;
        }

        public override string GetModtagerpart()
        {
            string s = "";
            if (Miljoe.Equals(Miljoe.Produktion)) { s = "5790002084485:14"; }
            else if (Miljoe.Equals(Miljoe.Test)) { s = "5790001093075:14"; }
            return (s);
        }

        public override string GetQuery()
        {
            string s = "";
            switch (Datatype)
            {
                case DataType.EjendomSummarisk:
                    {
                        s = GetEjendomSummariskHentBody();
                        break;
                    }
                case DataType.DokumentAktuel:
                    {
                        s = GetDokumentAktuelHentBody();
                        break;
                    }
                case DataType.IndskannetAkt:
                    {
                        s = GetIndskannetAktBody();
                        break;
                    }
                default: break;
            }
            s = s.Replace(System.Environment.NewLine, s);
            s = GetRequestBesked("101", "101", false, s);
            return s;
        }

        private static string GetRequestBesked(string kommunenummer, string ejendomsnummer, Boolean base64Encoded, string bodyContent)
        {
            string s = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>";
            s += "<tns:Besked xmlns:tns=\"http://e-nettet.dk/ToolboxGateway/2011/04/01/\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:schemaLocation=\"http://e-nettet.dk/ToolboxGateway/2011/04/01/ Besked.xsd\">";
            s += "<tns:Header>";
            s += "<tns:Sagsreference>123456789</tns:Sagsreference><tns:Kommunenummer>" +
                kommunenummer +
                "</tns:Kommunenummer><tns:Ejendomsnummer>" +
                ejendomsnummer +
                "</tns:Ejendomsnummer>";
            if (base64Encoded)
            {
                s += "<tns:AnvendBase64Encode>true</tns:AnvendBase64Encode>";
                bodyContent = Base64Utils.Base64Encode(bodyContent);

            }
            s += "</tns:Header>";
            s += "<tns:Body>" + bodyContent + "</tns:Body>";
            s += "</tns:Besked>";
            return (s);
        }


        private string GetEjendomSummariskHentBody()
        {
            string s =
                "<ns:EjendomSummariskHent xsi:schemaLocation=\"http://rep.oio.dk/tinglysning.dk/service/message/elektroniskakt/1/ http://rep.oio.dk/tinglysning.dk/service/message/elektroniskakt/1/EjendomSummariskHent.xsd\" xmlns:ns=\"http://rep.oio.dk/tinglysning.dk/service/message/elektroniskakt/1/\" xmlns:ns1=\"http://rep.oio.dk/tinglysning.dk/schema/model/1/\" xmlns:ns2=\"http://rep.oio.dk/kms.dk/xml/schemas/2005/03/11/\" xmlns:xd=\"http://www.w3.org/2000/09/xmldsig#\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">" +
                "<ns1:EjendomIdentifikator>" +
                "<ns1:Matrikel><ns2:CadastralDistrictIdentifier>" +
                cadastralDistrictIdentifier +
                "</ns2:CadastralDistrictIdentifier><ns1:Matrikelnummer>" +
                GeteTLMatrikelnummer() +
                "</ns1:Matrikelnummer></ns1:Matrikel>" +
                "</ns1:EjendomIdentifikator></ns:EjendomSummariskHent>";
            return (s);
        }

        private string GeteTLMatrikelnummer()
        {
            string nummerisk = "";
            string alfanummerisk = "";
            for (int i = 0; i < matrikelnummer.Length; i++)
            {
                string substring = matrikelnummer.Substring(i, 1);
                int j;
                if (int.TryParse(substring, out j)) { nummerisk += j.ToString(); }
                else { alfanummerisk += substring; }
            }
            while (nummerisk.Length < 4) { nummerisk = "0" + nummerisk; }
            return (nummerisk + alfanummerisk);
        }

        private string GetDokumentAktuelHentBody()
        {
            string s = "<eamsg:DokumentAktuelHent xsi:schemaLocation=\"http://rep.oio.dk/tinglysning.dk/service/message/elektroniskakt/1/ http://rep.oio.dk/tinglysning.dk/service/message/elektroniskakt/1/DokumentAktuelHent.xsd\" xmlns:eamsg=\"http://rep.oio.dk/tinglysning.dk/service/message/elektroniskakt/1/\" xmlns:model=\"http://rep.oio.dk/tinglysning.dk/schema/model/1/\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"><model:DokumentIdentifikator>" + dokumentIdentifikator + "</model:DokumentIdentifikator></eamsg:DokumentAktuelHent>";
            return (s);
        }

        private string GetEjendomskortQuery()
        {
            string s = "<anv:GetMap xmlns:anv=\"http://kms.dk/anv\"><anv:matrnr>" + Matrikelnummer + "</anv:matrnr><anv:ejerlavskode>" + CadastralDistrictIdentifier + "</anv:ejerlavskode></anv:GetMap>";
            return (s);
        }
        private string GetIndskannetAktBody()
        {
            // Dette virker i produktion 18_I_414
            string s = "<ns:EjendomIndskannetAktHent xsi:schemaLocation=\"http://rep.oio.dk/tinglysning.dk/service/message/elektroniskakt/1/ http://rep.oio.dk/tinglysning.dk/service/message/elektroniskakt/1/EjendomIndskannetAktHent.xsd\" xmlns:ns=\"http://rep.oio.dk/tinglysning.dk/service/message/elektroniskakt/1/\" xmlns:ns1=\"http://rep.oio.dk/tinglysning.dk/schema/elektroniskakt/1/\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"><ns1:DokumentFilnavnTekst>" + DokumentFilnavn + "</ns1:DokumentFilnavnTekst></ns:EjendomIndskannetAktHent>";
            return (s);
        }




    }
}
