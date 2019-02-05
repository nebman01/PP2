using System;

namespace Task1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse(Console.ReadLine());		 //создаю переменную которая будет означать количество элементов в массиве и вводим строку. через метод Parse конвертируем строку в тип данных int
			double[] a = new double[n]; 				 //создаю массив double, хотя можно было бы и int
			for(int i=0; i<n; i++){ 
				a[i] = int.Parse(Console.ReadLine());	 //через цикл ввожу в массив цифры конвертируя в int
			}

			int numPr = 0;								//создаю переменную которая будет показывать кол-во прайм

			for(int i=0; i<n; i++){ 					 //пробегаемся по массиву
				int x = 0;								 //создаем переменную, которя поможет проверить через условие Prime или нет
				if (a [i] > 1) {
					for (int j=2; j<a[i]; j++) { 
						if (a [i] % j == 0) {			 // через условие в цикле проверяем делится ли на числа до самого числа в массиве без остатка
							x = 1;						 //если делится приравниваем к 1
							break;						 //и выходим из цикла . а если нет, ...
						}
					}	
					if(x == 0){
						a[numPr] = a[i];				//через условие проверяем если оно равно 0, это значит что число Prime
						numPr++;						//прибавляем +1 к количеству прайм
					}										 
				}
				
			}
			Console.WriteLine();
			Console.WriteLine(numPr);					//вывод количества prime num

			for(int i=0; i<numPr; i++){ 			    //пробегаемся по массиву и выводим prime numbers
				Console.Write(a[i] + " ");
			}
			Console.WriteLine();
			Console.ReadKey();
		}
	}
}