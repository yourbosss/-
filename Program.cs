/***********************************************
 * Автор: Копытова К. К.                       *
 * Дата: 05.06.2022                            *
 * Название: Базовые понятия языка С# (1 лаба) *
***********************************************/

using System;

namespace namspaceOne
{

	class Program
	{

		static void Main(string[] args) // передача массива в программу
		{

			Console.WriteLine("Введите а:");
			var NumberStr = Console.ReadLine(); //ввод строки с переменной string

			Console.WriteLine("ВВедите n:");
			var ExponentStr = Console.ReadLine();

			int Number, Exponent; 

			if (!int.TryParse(NumberStr, out Number) || !int.TryParse(ExponentStr, out Exponent)) // parse возвразает преобразованное число и происходит сравнение
			{

				Console.WriteLine("\n" + "Неправильное число");

				return;
			}

			bool Negative = false;

			if (Exponent < 0)
			{

				Negative = true;
				Exponent *= -1;
			}

			int Result = 1;

			for (int ExponentIndex = 1; ExponentIndex <= Exponent; ++ExponentIndex)
			{

				Result *= Number;
			}

			if (Negative)
			{

				Console.WriteLine("\n" + "Result: 1/" + Result);
			}
			else
			{

				Console.WriteLine("\n" + "Result: " + Result);
			}

			Console.ReadKey(); //считывание с клавиатуры
		}
	}
}