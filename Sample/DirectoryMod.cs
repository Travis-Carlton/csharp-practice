using System.IO;

namespace myApp.Sample
{
    public class DirectoryMod
    {
        DirectoryInfo directoryInfo;
        DirectoryMod()
        {
            this.directoryInfo = new DirectoryInfo();
        }

        public static void createDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }

        public static void getFiles(string path)
        {
            if (Directory.Exists(path))
                Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
        }


    }
}