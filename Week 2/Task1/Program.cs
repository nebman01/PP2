using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some string, and I'll check if it's polindrome:\n");

            string inputstr = Console.ReadLine();

            System.IO.File.WriteAllText(@"C:\KBTU study\2nd semester\PP2\Week 2\Task1\input.txt", inputstr);

            string ifpol = System.IO.File.ReadAllText(@"C:\KBTU study\2nd semester\PP2\Week 2\Task1\input.txt");

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
