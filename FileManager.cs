using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Islamic_app
{
    public static class FileManager
    {
        public static string AppPath => Path.GetDirectoryName(Application.ExecutablePath);

        public static string[] ReadAllLines(string fileName)
        {
            string filePath = Path.Combine(AppPath, fileName);
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"File not found: {filePath}");
            }
            return File.ReadAllLines(filePath);
        }

        public static string GetResourcePath(string folder, string fileName)
        {
            string directoryPath = Path.Combine(AppPath, folder);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            return Path.Combine(directoryPath, fileName);
        }

        public static void ExtractEmbeddedResources()
        {
            string[] folders = { "Surahs", "Data" };

            foreach (var folder in folders)
            {
                string folderPath = Path.Combine(AppPath, folder);
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
            }
        }

        public static bool ResourceExists(string folder, string fileName)
        {
            string filePath = Path.Combine(AppPath, folder, fileName);
            return File.Exists(filePath);
        }
    }
}