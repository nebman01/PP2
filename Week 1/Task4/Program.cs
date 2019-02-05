using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace myapp{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //создаю переменную которая будет означать количество строк и столбцов
            //и вводим строку. через метод Parse конвертируем строку в тип данных int

			int[,] a = new int[n, n]; //создаю двухмерный массив int
            
            string s = "[*]"; //
            // int a = 0;
            for(int i=0; i<n; i++){ //создаю двухмерный цикл(или как это назвать, ведь не массив)
                for(int j=0; j<i+1; j++){ //второй цикл работает до i+1, таким образом выводит опредделенное количество [*]
                    Console.Write(s); //вывожу
                }
                Console.WriteLine(); //перехожу на след. строку
            }

			Console.ReadKey (); //чтоб не вышел
        }
    }
}