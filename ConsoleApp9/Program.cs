class Person { 
	private int _age;
	public int Age{
		get { return _age; }
		set {
			if (value >= 0)
			{
				_age = value;
			}
			else {
				Console.WriteLine("This is imposible");
			}
		}
	}
}

class Program {
	public static void Main(string[] args) {
		Person pers1 = new Person();
		pers1.Age = -2;
		pers1.Age = 10;
		Console.WriteLine(pers1.Age);
	}
}