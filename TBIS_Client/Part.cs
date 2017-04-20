using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HentRestgaeld
{
    public class Part
    {
        public string partid;
        public string beskrivelse;
        public Part(string partid, string beskrivelse)
        {
            this.partid = partid;
            this.beskrivelse = beskrivelse;
        }


        public static List<Part> getPartList(Miljoe miljoe)
        {
            List<Part> p = new List<Part>();
            switch (miljoe)
            {
                case Miljoe.Produktion:
                    {
                        p.Add(new Part("5790000633494:14", "BRF"));
                        p.Add(new Part("5790000621156:14", "DLR"));
                        p.Add(new Part("5790000636099:14", "LRF"));
                        p.Add(new Part("5790000633593:14", "N"));
                        p.Add(new Part("5790000626328:14", "RD"));
                        p.Add(new Part("5790000635702:14", "TOT"));
                        p.Add(new Part("5790000614608:14", "NOR"));
                        break;
                    }
                case Miljoe.Test:
                    {
                        p.Add(new Part("5790000611300:14", "BRF"));
                        p.Add(new Part("5790000660889:14", "DLR"));
                        p.Add(new Part("5790000660605:14", "LRF"));
                        p.Add(new Part("5790000661015:14", "N"));
                        p.Add(new Part("5790000660926:14", "RD"));
                        p.Add(new Part("5790000611522:14", "TOT"));
                        p.Add(new Part("5790000611386:14", "NOR"));
                        break;
                    }
                default: break;
            }
            return (p);
        }
    }
}
