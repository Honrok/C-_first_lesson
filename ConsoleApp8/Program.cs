//class Animal {
//	public string name = "";
//	public void Eat() {
//		Console.WriteLine($"{name} eats");
//	}
//}

//class Dog : Animal {
//	public void Bark() {
//		Console.WriteLine($"{name} barks");
//	}
//}


//class Program {
//	public static void Main()
//	{
//		Dog dog1 = new Dog();


//		dog1.name = "Rex";
//		dog1.Eat();
//		dog1.Bark();
//	}
//}

class Animal {
	public string name = "";
	public virtual void MakeSound() {
		Console.WriteLine("Animal makes sound");
	}
}

class Dog : Animal
{
	public override void MakeSound()
	{
		Console.WriteLine("GAV GAV");
	}
}

class Cat : Animal
{
    public override void MakeSound()
    {
		Console.WriteLine("Miu Miu");
    }
}

	class Program {
	public static void Main() {

		Dog dog1 = new Dog();
		Cat cat1 = new Cat();

		dog1.MakeSound();
		cat1.MakeSound();

	}
		
	}
