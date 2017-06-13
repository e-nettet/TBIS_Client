using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FEgne6;

namespace HentRestgaeld
{
    public class Egne_Utils:RKNet_Utils
    {
        private DateTime gyldigFraDato;
        private FEgne6.Kodeliste4 institut;

        public DateTime GyldigFraDato { get => gyldigFraDato; set => gyldigFraDato = value; }
        public Kodeliste4 Institut { get => institut; set => institut = value; }

        public Egne_Utils(Miljoe miljoe, string afsender_partid, string jnummer)
        {
            this.Miljoe = miljoe;
            this.Afsender_partid = afsender_partid;
            this.Jnummer = jnummer;
            this.Datatype = DataType.EgnePapirer;
        }

        public FEgne6.FEgne6 GetFEgne6()
        {
            FEgne6.FEgne6 fEgne6 = new FEgne6.FEgne6()
            {

                DOCINF = new FEgne6.DOCINF()
                {
                    Sender_version = "061",
                    Meddelelsens_nummer = "123456", // Tilsyneladende uden betydning
                    Meddelelsens_funktion = FEgne6.Kodeliste5.Item9,
                    Dato = GetDateAs_YYYYMMDD(gyldigFraDato),
                    Afsender_partid = Afsender_partid,
                    IDkode = Jnummer,
                    Modtager_partid = GetModtagerPart(Miljoe),
                    Informationsstromsnavn = GetInfoFlowName(),
                    Meddelelsens_navn = FEgne6.Meddelelsens_navn.Z01,
                    Meddelelsens_navnSpecified = true,
                    Meddelelsens_type = FEgne6.Meddelelsens_type.REQDOC,
                    Meddelelsens_typeSpecified = true,
                    Modtager_version = "061",
                    Onsket_version = "061",
                },
                INSTIT = new FEgne6.INSTIT()
                {
                    Institut = institut,
                }
            };
            return (fEgne6);
        }

        public static string GetModtagerPart(Miljoe miljoe)
        {
            string s;
            switch (miljoe)
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

        public override string GetQuery()
        {
            FEgne6.FEgne6 f = GetFEgne6();
            string s = GetClassAsXMLString(f);
            return (s);
        }

        public override string GetModtagerpart()
        {
            string s = GetModtagerPart(Miljoe);
            return (s);
        }
    }
}
