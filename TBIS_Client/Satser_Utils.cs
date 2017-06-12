using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSatser6;

namespace HentRestgaeld
{
    public class Satser_Utils : RKNet_Utils
    {
        private FSatser6.Kodeliste12 forretningsomraade;
        private FSatser6.Kodeliste4 institut;

        public Kodeliste12 Forretningsomraade { get => forretningsomraade; set => forretningsomraade = value; }
        public Kodeliste4 Institut { get => institut; set => institut = value; }

        public Satser_Utils(Miljoe miljoe, string afsender_partid, string jnummer)
        {
            this.Miljoe = miljoe;
            this.Afsender_partid = afsender_partid;
            this.Jnummer = jnummer;
            this.Datatype = DataType.Satser;
        }

        public override string GetModtagerpart()
        {
            return (GetDSPartid());
        }

        public override string GetQuery()
        {
            FSatser6.FSatser6 f = GetFSatser();
            string s = GetClassAsXMLString(f);
            return (s);

        }

        public FSatser6.FSatser6 GetFSatser()
        {
            FSatser6.FSatser6 f = new FSatser6.FSatser6()
            {
                DOCINF = new FSatser6.DOCINF()
                {
                    Sender_version = "061",
                    Meddelelsens_nummer = "123456", // Tilsyneladende uden betydning
                    Dato = GetDateAs_YYYYMMDD(),
                    Afsender_partid = Afsender_partid,
                    IDkode = Jnummer,
                    Modtager_partid = GetModtagerpart(),
                    Informationsstromsnavn = GetInfoFlowName(),
                    Meddelelsens_navnSpecified = true,
                    Meddelelsens_typeSpecified = true,
                    Modtager_version = "060",
                    Onsket_version = "060",
                },
                FOROMR = new FSatser6.FOROMR()
                {
                    Forretningsomraade = this.forretningsomraade
                },
                INSTIT = new INSTIT()
                {
                    Institut = this.institut
                }
            };

            return (f);
        }
    }
}
