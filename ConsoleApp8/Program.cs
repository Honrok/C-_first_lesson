//Наслідування, це коли ми можемо створювати класи, які наслідують батьківський клас і всі його меотди. При наявності конструктора, також наслідуємо обовязкові параметри

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



//Поліморфізм, це коли різні обєкти класу реалізують метод цього класу по різному.


//class Animal {
//	public string name = "";
//	public virtual void MakeSound() {
//		Console.WriteLine("Animal makes sound");
//	}
//}

//class Dog : Animal
//{
//	public override void MakeSound()
//	{
//		Console.WriteLine("GAV GAV");
//	}
//}

//class Cat : Animal
//{
//    public override void MakeSound()
//    {
//		Console.WriteLine("Miu Miu");
//    }
//}

//	class Program {
//	public static void Main() {

//		Dog dog1 = new Dog();
//		Cat cat1 = new Cat();

//		dog1.MakeSound();
//		cat1.MakeSound();

//	}

//	}

//Неможливо створити екземпляр абстрактного класу, тільки наслідувати

//abstract class Shape {
//	public abstract double Area();
//}
//class Circle : Shape {

//	public double Radius;
//	public override double Area() {
//		double res = Math.PI* Radius *Radius;
//		return res;
//	}
//}
//class Program {
//	public static void Main(string[] args) {
//		Circle circle1 = new Circle();
//		circle1.Radius = 11.1;
//		Console.WriteLine(circle1.Area());

//	}	

//}


//інтерфейси задають класи, які похідні класи повинні обовязково реалізувати
//interface IFly {
//	void Fly();
//}

//class Bird : IFly {
//	public void Fly() {
//		Console.WriteLine("I'm bird");
//	}
//}