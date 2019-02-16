using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some string, and I'll check if it's prime:\n");

            string inputstr = Console.ReadLine();

            System.IO.File.WriteAllText(@"C:\KBTU study\2nd semester\PP2\Week 2\Task2\input.txt", inputstr);
            //приравниваю строки в файле в новую строку str через функцию ReadAllText
            string str = System.IO.File.ReadAllText(@"C:\KBTU study\2nd semester\PP2\Week 2\Task2\input.txt");
            //создаю массив строк и делю их по умолчанию на пробелы через функцию split:
            string[] sArr = str.Split();
            int[] intArr = new int[sArr.Length]; //создаю массив чисел
            for (int i = 0; i < sArr.Length; i++) 
            {
                intArr[i] = int.Parse(sArr[i]); //через цикл передаю массив строк в массив чисел конвертируя их
            }

            int numPr = 0;
            //считаю prime numbers
            for (int i = 0; i < intArr.Length; i++)
            {
                int x = 0;
                if (intArr[i] > 1)
                {
                    for (int j = 2; j < intArr[i]; j++)
                    {
                        if (intArr[i] % j == 0)
                        {
                            x = 1; //делю число на все числа до самого данного числа
                            break; //если делится без остатка то это не прайм , приравниваем х к 0 и выходим с цикла
                        }
                    }
                    if (x == 0)
                    {
                        intArr[numPr] = intArr[i];  //если в цикле все таки до самого числа не поделилось ни на что без остатка
                        numPr++;                    //приравниваю все прайм числа к началу массива и считаю их количество
                    }
                }
            }

            string[] strOutput = new string[numPr];

            for (int i = 0; i < numPr; i++)
            {
                int b = intArr[i];
                strOutput[i] = Convert.ToString(b); //передаю прайм числа которые находились в начале массива в массив строк
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\KBTU study\2nd semester\PP2\Week 2\Task2\output.txt"))
            {
                // создаю новый файл и передаю туда весь массив строк из прайм чисел через цикл
				foreach(string line in strOutput)
					file.Write(line + " ");  
            }
        }
    }
}
