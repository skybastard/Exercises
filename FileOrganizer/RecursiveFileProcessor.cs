using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileOrganizer
{
    public class RecursiveFileProcessor
    {

        // Process all files in the directory passed in, recurse on any directories 
        // that are found, and process the files they contain.
        public static void ProcessDirectory(string targetDirectory)
        {
            
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
            {
                Console.WriteLine(fileName);
                ProcessFile(fileName);
            }
                

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
            {
                
                ProcessDirectory(subdirectory);
            }
                
            
        }
        // some change

        // Insert logic for processing found files here.
        public static void ProcessFile(string fileName)
        {
            FileInfo f = new FileInfo(fileName);
            if (f.Name.ToLower().Contains("grand") && f.Name.ToLower().Contains("tour") && f.Name.ToLower().Contains("s03") && f.Length > 50000000)
            {
                
                string destinationFolder = $"D:/Download/Top Gear/the grand tour season 3/";
                string purefileName = Path.GetFileName(fileName);
                try {
                    File.Move(fileName, Path.Combine(fileName, destinationFolder + purefileName));
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                
                
            }




        }







    }
}
