using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FPriser6;

namespace HentRestgaeld
{
    public class Priser_Utils:RKNet_Utils
    {
        private DateTime dato;
        private Kodeliste12 forretningsomraade;
        private Kodeliste4 institut;

        public DateTime Dato { get => dato; set => dato = value; }
        public Kodeliste12 Forretningsomraade { get => forretningsomraade; set => forretningsomraade = value; }
        public Kodeliste4 Institut { get => institut; set => institut = value; }

        public Priser_Utils(Miljoe miljoe, string afsender_partid, string jnummer)
        {
            this.Miljoe = miljoe;
            this.Afsender_partid = afsender_partid;
            this.Jnummer = jnummer;
            this.Datatype = DataType.Priser;
        }

        public FPriser6.FPriser6 GetFPriser6()
        {
            FPriser6.FPriser6 f = new FPriser6.FPriser6()
            {

                DOCINF = new FPriser6.DOCINF()
                {
                    Sender_version = "061",
                    Meddelelsens_nummer = "123456", // Tilsyneladende uden betydning
                    //Meddelelsens_funktion = FPriser6.k.Item9,
                    Dato = GetDateAs_YYYYMMDD(dato),
                    Afsender_partid = Afsender_partid,
                    IDkode = Jnummer,
                    Modtager_partid = GetModtagerPart(Miljoe),
                    Informationsstromsnavn = GetInfoFlowName(),
                    //Meddelelsens_navn = FPriser6. Meddelelsens_navn.Z01,
                    Meddelelsens_navnSpecified = true,
                    //Meddelelsens_type = FPriser6. Meddelelsens_type.REQDOC,
                    Meddelelsens_typeSpecified = true,
                    Modtager_version = "060",
                    Onsket_version = "060",
                }

            };
            f.INSTIT = new FPriser6.INSTIT[1];
            f.INSTIT[0] = new INSTIT()
            {
                FOROMR = new FPriser6.FOROMR()
                {
                    Forretningsomraade = this.forretningsomraade
                },
                Institut = this.institut
            };
            return (f);
        }

        public string GetModtagerPart(Miljoe miljoe)
        {
            return (GetDSPartid());
        }

        public override string GetQuery()
        {
            FPriser6.FPriser6 f = GetFPriser6();
            string s = GetClassAsXMLString(f);
            return (s);
        }

        public override string GetModtagerpart()
        {
            return (GetDSPartid());
        }
    }
}
