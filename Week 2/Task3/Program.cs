using System;
using System.IO;

namespace Task3
{
    class Program
    {
        public static void PrintSpaces(int level)
        {
            for (int i = 0; i < level; i++)
            {
                Console.Write("     "); //чтобы было читабельно делаю табуляцию
            }
        }

        public static void func(DirectoryInfo directory, int level)
        {
            foreach (FileInfo f in directory.GetFiles())  //работаю с файлами в массиве directory
            {
                PrintSpaces(level); //делаю табуляцию 
                Console.WriteLine(f.Name); //вывожу имя файлов
            }
            foreach(DirectoryInfo d in directory.GetDirectories()){ //работаю с папками в массиве directory
                PrintSpaces(level);
                Console.WriteLine(d.Name); //вывожу имя папки в directory
                func(d, level+1); //открываю папку через рекурсию и вывожу все что в этой папке и так пока не закончатся все папки и файлы в папке
            }
        }

        static void Main(string[] args)
        {
            //передаю в функцию дайректори и число для табуляций
            func(new DirectoryInfo("C:/KBTU study/2nd semester/PP2/Week 2/Task3"), 0); 
        }
    }
}
