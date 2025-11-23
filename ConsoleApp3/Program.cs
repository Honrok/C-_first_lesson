int age;


Console.WriteLine("Tell me your age");
string input = Console.ReadLine();

if (input != null && int.TryParse(input, out int number))
{
	age = int.Parse(input);
	if (age >= 18)
	{
		Console.WriteLine("Повнолітній");
	}
	else
	{
		Console.WriteLine("fuck " + age);
	}
}
else
{
	Console.WriteLine("Ти ввів якусь хуйню");
}


