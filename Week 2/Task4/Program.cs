using System;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:/KBTU study/2nd semester/PP2/Week 2/Task4/best.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite); //создаю текстовый файл в определенной папке с возможностью менять его
            StreamWriter sr = new StreamWriter(fs); 
            sr.WriteLine("Dina is the best assistant"); //с помощью классса SW передаю строки в файл
            sr.Close(); 
            fs.Close();
            File.Copy(@"C:/KBTU study/2nd semester/PP2/Week 2/Task4/best.txt", @"C:/KBTU study/2nd semester/PP2/Week 2/Task4/asd/uiii.txt");
            //копирую файл с первой папки в другую через функцию File.Copy 
            File.Delete(@"C:/KBTU study/2nd semester/PP2/Week 2/Task4/best.txt");
            //удаляю изначальный файл
        }
    }
}
