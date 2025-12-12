//try
//{
//	int x = int.Parse("hello");
//}
//catch (FormatException ex)
//{
//	Console.WriteLine("Невірний формат числа!");
//}
//finally
//{
//	Console.WriteLine("Кінець операції.");
//}

//int number;

//while (true)
//{
//	Console.Write("Введіть число: ");
//	string input = Console.ReadLine();

//	try
//	{
//		number = int.Parse(input);
//		break; // якщо все добре → вихід з циклу
//	}
//	catch (FormatException)
//	{
//		Console.WriteLine("Помилка: ви повинні ввести число. Спробуйте ще раз.");
//	}
//	catch (OverflowException)
//	{
//		Console.WriteLine("Помилка: число занадто велике або мале. Спробуйте ще раз.");
//	}
//}

//Console.WriteLine($"Ви успішно ввели число: {number}");

//class User{
//	public int Age { get; }
//	public User(int age) {
//		if (age < 0)
//		{
//			throw new ArgumentException("Age cannot be negative");

//		}
//		else {
//			Age = age;
//		}
//	}
//}
//class Program {
//	public static void Main(String[] args) {
//		User user = new(2);

//	}
//}
