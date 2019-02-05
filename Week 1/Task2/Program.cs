using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace myapp{
    public class Student //создаю класс
    {
        public string name;  //делаю паблик переменные определенных типов
        public string id;
        public int course;

        public Student(string name, string id, int course) //здесь приравниваю переданные данные к новым перемнным в этом классе 
        {
            this.name = name; //this - показывает что перепенная находится в этом классе
            this.id = id;
            this.course = course;
        }
        public void print()
        {
            Console.WriteLine();
            if(course >= 1 && course <= 4){
                Console.WriteLine("name: {0}", name);
                Console.WriteLine("id: {0}", id);
                Console.WriteLine("You're studying for a bachalor's\nThx for your attention");
            }
            else if(course >= 5 && course <= 6){
                Console.WriteLine("name: {0}", name);
                Console.WriteLine("id: {0}", id);
                Console.WriteLine("You're studying for a master's\nThx for your attention");
            }
            else if(course > 6){
                Console.WriteLine("name: {0}", name);
                Console.WriteLine("id: {0}", id);
                Console.WriteLine("You're studying or you're PhD\nThx for your attention");
            }
            else Console.WriteLine("Write the really number of your course.\nPlease go again.");
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name, ID, и course"); 
            //отправляем вводные данные в фкнкцию Student в классе Student
            Student s = new Student(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine())); 
            s.print();
            Console.ReadKey();
        }
    }
}