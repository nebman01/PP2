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

            string str = System.IO.File.ReadAllText(@"C:\KBTU study\2nd semester\PP2\Week 2\Task2\input.txt");

            string[] sArr = str.Split();
            int[] intArr = new int[sArr.Length];
            for (int i = 0; i < sArr.Length; i++)
            {
                intArr[i] = int.Parse(sArr[i]);
            }

            int numPr = 0;

            for (int i = 0; i < intArr.Length; i++)
            {
                int x = 0;
                if (intArr[i] > 1)
                {
                    for (int j = 2; j < intArr[i]; j++)
                    {
                        if (intArr[i] % j == 0)
                        {
                            x = 1;
                            break;
                        }
                    }
                    if (x == 0)
                    {
                        intArr[numPr] = intArr[i];
                        numPr++;
                    }
                }
            }

            string[] strOutput = new string[numPr];

            for (int i = 0; i < numPr; i++)
            {
                int b = intArr[i];
                strOutput[i] = Convert.ToString(b);
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\KBTU study\2nd semester\PP2\Week 2\Task2\output.txt"))
            {
				foreach(string line in strOutput)
					file.Write(line + " ");
            }
        }
    }
}
