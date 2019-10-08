using System.IO;

namespace myApp.Sample
{
    public class FileMod
    {
        private FileInfo fileInfo;

        public FileMod()
        {
            this.fileInfo = new FileInfo();
        }

        public static void copyFile(string path, string dest)
        {
            if (File.Exists(path))
                File.Copy(path, dest);
        }
        public static void deleteFile(string path)
        {
            File.Delete(path);
        }

        public static void readText(string path)
        {
            File.ReadAllText(path);
        }
    }
}