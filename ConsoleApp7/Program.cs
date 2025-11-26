


public class Person(string name, int age) { 
	private string personName = name;
	private int personAge = age;

	public void SayHello() {
		Console.WriteLine($"Hello {personName} and your age is {personAge}");
	}
}

class Program
{
	static void Main(string[] args)
	{
		Person first = new Person("Rost", 28);
		first.SayHello();
	}
}



