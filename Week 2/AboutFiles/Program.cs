using System;

namespace AboutFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "First line", "Second line", "Third line" };
            System.IO.File.WriteAllLines(@"C:\KBTU study\2nd semester\PP2\Week 2\AboutFiles\WriteLines2.txt", lines);

            // using (System.IO.StreamWriter file =
            //     new System.IO.StreamWriter(@"C:\KBTU study\2nd semester\PP2\Week 2\AboutFiles\WriteLines2.txt", true))
            // //true - оставляет все что есть в файле и дает что то поделать после всех строк
            // {
            //     // foreach(string line in lines)
            //     // {
            //     //      if(line.Contains("e"))
            //     //      {
            //                 file.WriteLine("Fourth line");
            //     //      }
            //     // }
            // }

            //приравнять файл в новому массиву типа string и вывести на терминал
            string[] lines2 = System.IO.File.ReadAllLines(@"C:\KBTU study\2nd semester\PP2\Week 2\AboutFiles\WriteLines2.txt");
            // foreach(string line2 in lines2)
            //     Console.WriteLine(line2);

            //вывод всех строк в тексте
            // foreach(string line3 in lines)
            //     System.Console.WriteLine("Contents of WriteLines2.txt = {0}", line3);

            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines2)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }
        }
    }
}
