using static Practice.Afanasiev;

namespace UnitTests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Bulet_and_dragons_10_5()
		{
			int bulletsCount = 10;
			int dragonsCount = 5;
			string expected = "да";

			string result = Bullet_and_dragons(bulletsCount, dragonsCount);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Bulet_and_dragons_100_40()
		{
			int bulletsCount = 100;
			int dragonsCount = 40;
			string expected = "да";

			string result = Bullet_and_dragons(bulletsCount, dragonsCount);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Bulet_and_dragons_4_5()
		{
			int bulletsCount = 4;
			int dragonsCount = 5;
			string expected = "нет";

			string result = Bullet_and_dragons(bulletsCount, dragonsCount);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Bulet_and_dragons_1500_751()
		{
			int bulletsCount = 1500;
			int dragonsCount = 751;
			string expected = "нет";

			string result = Bullet_and_dragons(bulletsCount, dragonsCount);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Empty_1_5()
		{
			int a = 1;
			int b = 5;
			string expected = "2, 3, 4";

			string result = Empty(a, b);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Empty_10_11()
		{
			int a = 10;
			int b = 11;
			string expected = "empty";

			string result = Empty(a, b);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Red_square_2_1dot62()
		{
			double a = 2;
			double expected = 1.62;

			double result = Red_square(a);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Red_square_0_0()
		{
			double a = 0;
			double expected = 0;

			double result = Red_square(a);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Red_square_14dot05_80()
		{
			double a = 14.05;
			double expected = 80;

			double result = Red_square(a);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Anagram_mama_amam()
		{
			string test = "mama";
			string origin = "amam";
			bool expected = true;

			bool result = Anagram(test,origin);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Anagram_jock_lock()
		{
			string test = "jock";
			string origin = "lock";

			bool expected = false;

			bool result = Anagram(test, origin);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Anagram_Twoo_Woot()
		{
			string test = "Twoo";
			string origin = "Woot";
			bool expected = true;

			bool result = Anagram(test, origin);

			Assert.AreEqual(expected, result);
		}
	}
}