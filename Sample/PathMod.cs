using System.IO;

namespace myApp.Sample
{
    public class PathMod
    {
        private string path;
        PathMod(string path)
        {
            this.path = path;
        }

        public static void getFileName(string path)
        {
            Path.GetFileName(path);
        }

        public static void getFileExtension(string path)
        {
            Path.GetExtension(path);
        }
    }
}