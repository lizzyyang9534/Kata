using NUnit.Framework;

namespace CarParkEscape
{
	[TestFixture]
	public class CarParkEscapeTest
	{
		[TestCase]
		public void BasicTest1()
		{
			Car car = new Car();
			int[,] carpark = new int[,] { { 1, 0, 0, 0, 2 },
										  { 0, 0, 0, 0, 0 } };
			string[] result = new string[] { "L4", "D1", "R4" };
			Assert.AreEqual(result, car.Escape(carpark));
		}

		[TestCase]
		public void BasicTest2()
		{
			Car car = new Car();
			int[,] carpark = new int[,] { { 2, 0, 0, 1, 0 },
										  { 0, 0, 0, 1, 0 },
										  { 0, 0, 0, 0, 0 } };
			string[] result = new string[] { "R3", "D2", "R1" };
			Assert.AreEqual(result, car.Escape(carpark));
		}

		[TestCase]
		public void BasicTest3()
		{
			Car car = new Car();
			int[,] carpark = new int[,] { { 0, 2, 0, 0, 1 },
										  { 0, 0, 0, 0, 1 },
										  { 0, 0, 0, 0, 1 },
										  { 0, 0, 0, 0, 0 } };
			string[] result = new string[] { "R3", "D3" };
			Assert.AreEqual(result, car.Escape(carpark));
		}

		[TestCase]
		public void BasicTest4()
		{
			Car car = new Car();
			int[,] carpark = new int[,] { { 1, 0, 0, 0, 2 },
										  { 0, 0, 0, 0, 1 },
										  { 1, 0, 0, 0, 0 },
										  { 0, 0, 0, 0, 0 } };
			string[] result = new string[] { "L4", "D1", "R4", "D1", "L4", "D1", "R4" };
			Assert.AreEqual(result, car.Escape(carpark));
		}

		[TestCase]
		public void BasicTest5()
		{
			Car car = new Car();
			int[,] carpark = new int[,] { { 1, 0, 0, 0, 0 },
										  { 0, 1, 0, 0, 2 },
										  { 1, 0, 0, 0, 0 },
										  { 0, 0, 0, 0, 0 } };
			string[] result = new string[] { "L3", "D1", "L1", "D1", "R4" };
			Assert.AreEqual(result, car.Escape(carpark));
		}

		[TestCase]
		public void BasicTest6()
		{
			Car car = new Car();
			int[,] carpark = new int[,] { { 0, 0, 0, 0, 2 } };
			string[] result = new string[] { };
			Assert.AreEqual(result, car.Escape(carpark));
		}
	}
}
