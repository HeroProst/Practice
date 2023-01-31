using System.Text;

namespace Practice
{
	public class Afanasiev
	{
		static void Main(string[] args)
		{

		}

		public static string Bullet_and_dragons(int bullets, int dragons)
		{
			if (bullets >= dragons * 2)
				return "да";
			else
				return "нет";
		}

		public static string Empty(int a, int b)
		{
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
			double cyrcleLength = a * 4;
			double cyrcleRadius = cyrcleLength / (2 * Math.PI);
			return Math.Round(Math.Pow(cyrcleRadius, 2),2);
		}

		public static bool Anagram(string test, string origins)
		{
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