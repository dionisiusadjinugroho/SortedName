using System;
using System.Collections.Generic;
using System.IO;

namespace SortedName
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "";
            if (args.Length > 0)
            {
                filename = args[0];
            }
            else
            {
                Console.WriteLine("Please Fill the FileName");
                return;
            }
            //Check File unsorted-names-list.txt Exist or Not inside executable dir file
            if (!File.Exists(filename))
            {
                File.Create(filename).Dispose();
                Console.WriteLine("File Not Found, Created New Empty File with desired name.");
                return;
            }

            //Read File line by line
            string[] unsortedNames = File.ReadAllLines(filename);

            if (unsortedNames.Length == 0)
            {
                Console.WriteLine("Names inside Txt File Empty");
                return;
            }

            List<string> sortedNames = new List<string>();
            foreach (var unsortedName in unsortedNames)
            {
                string sortedName = SortFunction.Sorter(unsortedName);
                Console.WriteLine(sortedName);
                sortedNames.Add(sortedName);
            }

            // Write array of strings to a file using WriteAllLines.  
            // If the file does not exists, it will create a new file.  
            // This method automatically opens the file, writes to it, and closes file  
            File.WriteAllLines("./sorted-names-list.txt", sortedNames);
            Console.ReadLine();
        }
    }
}
