using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace myapp{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //создаю переменную которая будет означать количество элементов в массиве
            //и вводим строку. через метод Parse конвертируем строку в тип данных int
			int[] a = new int[n]; //создаю массив int
			for(int i=0; i<n; i++){
				a[i] = int.Parse(Console.ReadLine()); //через цикл ввожу в массив цифры конвертируя в int
			}

			for(int i=0; i<n; i++){ //пробегаемся по массиву
				Console.Write(a[i] + " " + a[i] + " "); //вывожу каждый элемент два раза через пробелы
			}

			Console.ReadKey (); //остаюсь в консоли
        }
    }
}