//Виводимо числа від 1 до 10

//for (int i = 0; i < 10; i++) {
//	Console.WriteLine(i + 1);
//}

//Console.WriteLine("Write numbers and I will sum all the numbers before you send me 0");

//int sum = 0;
//int res = 0;
//int counter = 1;

//while (counter != 0){
//	string input = Console.ReadLine();
//	if (input != null && int.TryParse(input, out int number))
//	{
//		res = int.Parse(input);
//		sum += res;
//		counter++;
//		Console.WriteLine(sum);
//	}
//	else {
//		counter = 0;
//	}
//}

bool exit = false;

while (!exit)
{
	Console.WriteLine("Вибери пункт меню:");
	Console.WriteLine("1. Привітання");
	Console.WriteLine("2. Показати дату");
	Console.WriteLine("3. Вийти");

	string choice = Console.ReadLine();

	if (choice == "1")
	{
		Console.WriteLine("Привіт!");
	}
	else if (choice == "2")
	{
		Console.WriteLine("Сьогодні: " + DateTime.Now.ToShortDateString());
	}
	else if (choice == "3")
	{
		Console.WriteLine("Вихід...");
		exit = true; // вихід з циклу
	}
	else
	{
		Console.WriteLine("Невірний вибір, спробуй ще раз.");
	}

	Console.WriteLine(); // пустий рядок для краси
}

