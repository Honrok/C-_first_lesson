class Animal {
	public string name = "";
	public void Eat() {
		Console.WriteLine($"{name} eats");
	}
}

class Dog : Animal {
	public void Bark() {
		Console.WriteLine($"{name} barks");
	}
}


class Program {
	public static void Main()
	{
		Dog dog1 = new Dog();


		dog1.name = "Rex";
		dog1.Eat();
		dog1.Bark();
	}
}
