//class Player {
//	string Name;
//	static int PlayersCount = 0;

//	public Player(){
//		PlayersCount++;
//		Console.WriteLine(PlayersCount);
//	}
//}

//class Program {

//	public static void Main(string[] args) {
//		Player pl1 = new();
//		Player pl2 = new();
//		Player pl3 = new();
//	}
//}

//using System.Numerics;

//static class MathUtils {
//	public static int Multiply(int a, int b) {
//		return (a * b);
//	}
//}

//class Program {
//	public static void Main(string[] args) {
//		//MathUtils m1 = new();
//		int sum = MathUtils.Multiply(3, 5);
//		Console.WriteLine(sum);
//	}
//}

//class Car {
//	private static int _countOfCars = 0;
//	public static int CountOfCars {
//		get {
//			return _countOfCars;
//		}
//	}
//	public Car()
//	{
//		_countOfCars++;
//		Console.WriteLine(_countOfCars);

//	}
//}
//class Program {
//	public static void Main(string[] args) {
//		Car car1 = new();
//		Car car2 = new();
//		Car car3 = new();
//		Car car4 = new();
//		Console.WriteLine(Car.CountOfCars);
//	}
//}