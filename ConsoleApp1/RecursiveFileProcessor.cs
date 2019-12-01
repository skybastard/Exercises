using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileOrganizer

{
    public static class RecursiveFileProcessor
    {
        public static void goThroughDirectories(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            for (int i = 0; i < subdirectoryEntries.Length; i++)
            {
                string subdirectory = subdirectoryEntries[i];
                Console.WriteLine(subdirectory);
            }
            //goThroughDirectories(subdirectory);

        }

        private static void ProcessFile(string fileName)
        {
            
        }
    }
}
