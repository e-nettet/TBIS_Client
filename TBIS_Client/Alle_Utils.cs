using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HentRestgaeld
{
    public class Alle_Utils : RKNet_Utils
    {
        private DateTime udtraeksdato;

        public DateTime Udtraeksdato { get => udtraeksdato; set => udtraeksdato = value; }

        public Alle_Utils(Miljoe miljoe, string afsender_partid, string jnummer)
        {
            this.Miljoe = miljoe;
            this.Afsender_partid = afsender_partid;
            this.Jnummer = jnummer;
            this.Datatype = DataType.AllePapirer;
        }

        public override string GetModtagerpart()
        {
            return (GetDSPartid());
        }

        public override string GetQuery()
        {
            FAlle6.FAlle6 f = GetFAlle6();
            string s = GetClassAsXMLString(f);
            return (s);
        }

        public FAlle6.FAlle6 GetFAlle6()
        {
            FAlle6.FAlle6 f = new FAlle6.FAlle6();
            f.DOCINF = new FAlle6.DOCINF()
            {
                Meddelelsens_navn = FAlle6.Meddelelsens_navn.Z02,
                Meddelelsens_navnSpecified = true,
                Meddelelsens_type = FAlle6.Meddelelsens_type.REQDOC,
                Meddelelsens_typeSpecified = true,
                Sender_version = "060",
                Modtager_version = "060",
                Onsket_version = "060",
                Informationsstromsnavn = GetInfoFlowName(),
                Meddelelsens_nummer = "123456", // Tilsyneladende uden betydning
                Meddelelsens_funktion = FAlle6.Kodeliste5.Item53,
                Dato = GetDateAs_YYYYMMDD(),
                Afsender_partid = Afsender_partid,
                IDkode = "",
                VirksomhedsID = "",
                Afdelingsid = "",
                Personid = "",
                Modtager_partid = GetModtagerpart()

            };
            f.UDDATO = new FAlle6.UDDATO()
            {
                Udtraeksdato = GetDateAs_YYYYMMDD(this.Udtraeksdato)
            };
            return (f);

        }
    }
}
