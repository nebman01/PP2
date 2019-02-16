using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some string, and I'll check if it's polindrome:\n"); 

            string inputstr = Console.ReadLine(); //создаю стринг и ввожу строку через консоль
            //создаю файл и вывожу в нем строку inputstr:
            System.IO.File.WriteAllText(@"C:\KBTU study\2nd semester\PP2\Week 2\Task1\input.txt", inputstr);
            //через функцию readAllText приравниваю строку в файле в другую строку:
            string ifpol = System.IO.File.ReadAllText(@"C:\KBTU study\2nd semester\PP2\Week 2\Task1\input.txt");
            //проверяю на полиндромность(?):
            int n = ifpol.Length;
            int a = 0;
            for(int i = 0; i < n/2; i++){
                if(ifpol[i] == ifpol[n-i-1]){
                    a++;
                }
            }
            if(a == n/2)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
