using System.IO;

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
