using System.Text;

namespace Practice
{
	public class Afanasiev
	{
		static void Main(string[] args)
		{

		}

		public static string Bullet_and_dragons(int bullets, int dragons)
		{/**Герой направляется в замок, чтобы выполнить свою миссию. 
		 Однако ему сообщили, что замок окружен парой мощных драконов! 
		 Для победы над каждым драконом требуется 2 пули, и наш герой не знает, сколько пуль он должен иметь при себе.
		 Выживет ли герой, есди возьмёт заданное количество пуль?
		 Написать ответ "да" или "нет".
		 **/
			if (bullets >= dragons * 2)
				return "да";
			else
				return "нет";
		}

		public static string Empty(int a, int b)
		{/**
		  Даны 2 целых числа, где a < b,
		  Выведите через запятую все числа, которые расположены в этом промежутке.
			Если таких нет вывести "empty"
		  **/
			if(a + 1 == b) 
				return "empty";
			StringBuilder result = new StringBuilder();
			for(a++;a < b;a++)
			{
				result.Append($"{a}, ");
			}
			result.Remove(result.Length - 2,2);
			return result.ToString();
		}

		public static double Red_square(double a)
		{
			/**
			 * Завершить функцию расчета площади красного квадрата через длину дуги окружности А.
			 * Полученный результат округлить до 2 знаков после запятой
			 * **/
			double cyrcleLength = a * 4;
			double cyrcleRadius = cyrcleLength / (2 * Math.PI);
			return Math.Round(Math.Pow(cyrcleRadius, 2),2);
		}

		public static bool Anagram(string test, string origins)
		{
			/**
			 * Напишите код, который проверяет являются ли 2 строки анаграммами друг друга.
			 * Анаграмма - результат перестановки букв слова для получения нового слова.
			 * **/
			if(test.Length != origins.Length) 
				return false;
			test = test.ToLower();
			char[] charsInOrigins = origins.ToLower().ToCharArray();
			foreach (char c in charsInOrigins)
			{
				if (!test.Contains(c))
					return false;
			}
			return true;
		}
	}
}