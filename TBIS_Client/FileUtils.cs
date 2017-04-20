using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace HentRestgaeld
{
    public static class FileUtils
    {
        public static string SaveToTempAndReturnFilepath(string s)
        {
            string path =  Path.Combine(Path.GetTempFileName());
            path = Path.ChangeExtension(path, "xml");
            File.WriteAllText(path, s);
            return (path);
        }

    }
}
