using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HentRestgaeld
{
    public static class Omregningstabller_Utils
    {
        public static string GetQueryString(Miljoe miljoe, string afsenderpartid, DateTime gyldigFraDato)
        {
            FOmregningstabeller6.FOmregningstabeller6 f = GetFOmregningstabeller6(miljoe, afsenderpartid, gyldigFraDato);
            string s = RKNetUtils.GetClassAsXMLString(f);
            return (s);
        }

        public static FOmregningstabeller6.FOmregningstabeller6 GetFOmregningstabeller6(Miljoe miljoe, string afsenderpartid, DateTime gyldigFraDato)
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
                Informationsstromsnavn = "F [rkn] Tabeller 6 XML",
                Meddelelsens_nummer = "123456", // Tilsyneladende uden betydning
                Meddelelsens_funktion = FOmregningstabeller6.Kodeliste5.Item53,
                Dato = RKNetUtils.GetDateAs_YYYYMMDD(),
                Afsender_partid = afsenderpartid,
                IDkode = "",
                VirksomhedsID = "",
                Afdelingsid = "",
                Personid = "",
                Modtager_partid = GetModtagerPart(miljoe),
            };
            fOmregningstabeller6.GYLDAT = new FOmregningstabeller6.GYLDAT()
            {
                Gyldig_fra_dato = RKNetUtils.GetDateAs_YYYYMMDD(gyldigFraDato)
            };
            fOmregningstabeller6.TABEL = new FOmregningstabeller6.TABEL[1];
            fOmregningstabeller6.TABEL[0] = new FOmregningstabeller6.TABEL()
            {
                Tabelnavn = FOmregningstabeller6.Kodeliste24.ALLE
            }; 
            

            return (fOmregningstabeller6);
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
    }
}
