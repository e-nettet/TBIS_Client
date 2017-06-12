using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HentRestgaeld
{
    public class Omregningstabller_Utils:RKNet_Utils
    {
        private DateTime gyldigFraDato;

        public DateTime GyldigFraDato { get => gyldigFraDato; set => gyldigFraDato = value; }

        public Omregningstabller_Utils(Miljoe miljoe, string afsender_partid, string jnummer)
        {
            this.Miljoe = miljoe;
            this.Afsender_partid = afsender_partid;
            this.Jnummer = jnummer;
            this.Datatype = DataType.Omregningskurstabller;
        }

        public FOmregningstabeller6.FOmregningstabeller6 GetFOmregningstabeller6()
        {
            FOmregningstabeller6.FOmregningstabeller6 fOmregningstabeller6 = new FOmregningstabeller6.FOmregningstabeller6();
            fOmregningstabeller6.DOCINF = new FOmregningstabeller6.DOCINF()
            {
                Meddelelsens_navn = FOmregningstabeller6.Meddelelsens_navn.Z03,
                Meddelelsens_navnSpecified = true, 
                Meddelelsens_type = FOmregningstabeller6.Meddelelsens_type.REQDOC,
                Meddelelsens_typeSpecified = true,
                Sender_version = "060",
                Modtager_version = "060",
                Onsket_version = "060",
                Informationsstromsnavn = GetInfoFlowName(),
                Meddelelsens_nummer = "123456", // Tilsyneladende uden betydning
                Meddelelsens_funktion = FOmregningstabeller6.Kodeliste5.Item53,
                Dato = GetDateAs_YYYYMMDD(),
                Afsender_partid = Afsender_partid,
                IDkode = "",
                VirksomhedsID = "",
                Afdelingsid = "",
                Personid = "",
                Modtager_partid = GetModtagerpart()
            };
            fOmregningstabeller6.GYLDAT = new FOmregningstabeller6.GYLDAT()
            {
                Gyldig_fra_dato = GetDateAs_YYYYMMDD(gyldigFraDato)
            };
            fOmregningstabeller6.TABEL = new FOmregningstabeller6.TABEL[1];
            fOmregningstabeller6.TABEL[0] = new FOmregningstabeller6.TABEL()
            {
                Tabelnavn = FOmregningstabeller6.Kodeliste24.ALLE
            }; 
            

            return (fOmregningstabeller6);
        }

        public override string GetQuery()
        {
            FOmregningstabeller6.FOmregningstabeller6 f = GetFOmregningstabeller6();
            string s = GetClassAsXMLString(f);
            return (s);
        }

        public override string GetModtagerpart()
        {
            return (GetDSPartid());
        }
    }
}
