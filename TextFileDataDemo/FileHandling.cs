using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFileDataDemo
{
    public class FileHandling
    {
        // remove file from disk
        public void removeFile(string fileName)
        {

            // create a file
            fileName = "D:/myDeleteFile.txt";
            try
            {
                using (FileStream fileStream = File.Create(fileName)) ;
            }
            catch(Exception MyException)
            {
                Console.WriteLine(MyException.ToString());
            }

            // remove the file
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            else
            {
                Console.WriteLine("no such file");
                
            }
        }

        // write some lines to file
        public void writeLinesToFile()
        {

            string fileName = "D:/myDeleteFile.txt";
            try
            {
                using (FileStream fileStream = File.Create(fileName));
            }
            catch (Exception MyException)
            {
                Console.WriteLine(MyException.ToString());
            }
            using (StreamWriter streamWriter = File.CreateText(fileName))
            {
                streamWriter.WriteLine("My first line");
                streamWriter.WriteLine("My second line");
            }

            
        }

        // append text to a existing file
        public void addToExistingFile()
        {
            string fileName = "D:/myDeleteFile.txt";
            using(StreamWriter writer = File.AppendText(fileName))
            {
                writer.WriteLine("from c# program");
            }
            
            
        }

        // 9 

    }
}
