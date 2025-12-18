class Box<T>
{
	public required T Value
	{
		get; set;
	}
	public void Display()
	{
		Console.WriteLine($"Value is: {Value}");
	}


}
class Pair<T, U> {
	public required T Value {get; set;}
	public required U Value2 {get; set;}

	public void Display() {
		Console.WriteLine($"Value is: {Value} and Value2 is: {Value2}");
	}

	
}



class Program
{
	public static void PrintArray<T>(T[] array)
	{
		foreach (T item in array)
		{
			Console.WriteLine("elem");
			Console.WriteLine(item);

		}
	}
	public static void Main(string[] args)
	{
		Box<int> box1 = new() { Value = 1 };
		box1.Display();

		Box<string> strBox = new() { Value = "I'm Rostyslav" };
		strBox.Display();

		void Swap<T>(ref T a, ref T b)
		{
			T temp = a;
			a = b;
			b = temp;
		}

		int x = 3, y = 4;

		Swap(ref x, ref y);

		Console.WriteLine($"{x}, {y}");

		Pair<int, string> val1 = new() { Value = 1, Value2 = "My name is Rostyslav" };
		val1.Display();

		Console.WriteLine("Now we will use our new method");

		int[] arr1 = { 1, 2, 3, 4 };
		string[] arr2 = { "1", "2", "3", "4" };

        PrintArray(arr1);
		PrintArray(arr2);

	}

	
		

	}
