//int[] numbers = new	int[10];

//Console.WriteLine(numbers[2]);


//int[] numbers = {1, 2, 3, 4, 5};

using System.Collections.Generic;

// List<string> names = new List<string>();
//names.Add("Rost");
//names.Add("Ania");

//foreach (string name in names) { 
//	Console.WriteLine(name);
//}

//List<int> numbers = new List<int>();

//numbers.Add(5);
//numbers.Add(10);
//numbers.Add(15);
//numbers.Add(20);

//foreach (int i in numbers) { 
//	Console.WriteLine(i);
//}



//bool val = false;
//Console.WriteLine("Ввели число");
//while (!val){
//	string input = Console.ReadLine();

//	if (int.TryParse(input, out int num)) {

//		numbers.Add(num);
//		numbers.Remove(10);
//		val = true;
//	}
//	else {
//		Console.WriteLine("Це не число, спробуй ввести ще раз");
//	}
//}
//foreach (int i in numbers)
//{
//	Console.WriteLine(i);
//}

//List<string> names = new List<string>();
//names.Add("Oleg");
//names.Add("Ira");
//names.Add("Rost");
//names.Add("Putch");

//Console.WriteLine("яке твоє ім'я");
//bool val = false;
//while (!val) {
//	string input = Console.ReadLine();
//	if (names.Contains(input))
//	{
//		Console.WriteLine("Таке є в списку");
//		val = true;
//	}
//	else {
//		Console.WriteLine("Не знайшов таке, попробуй ще раз вгадати");
//	}

//}

//int[] arr = {1, 23, 2342, 0, 78, 33};
//int sum = 0, lower = arr[0], highest = arr[0];
//for (int i = 0; i < arr.Length; i++)
//{
//	sum = sum + arr[i];
//	if (arr[i] < lower) {
//		lower = arr[i];
//	}
//	if (arr[i] > highest) {
//		highest = arr[i];
//	}
//}
//Console.WriteLine(sum);
//Console.WriteLine(lower);
//Console.WriteLine(highest);

//Dictionary<string, int> namesAndRate = new Dictionary<string, int>();

//namesAndRate.Add("Ivan", 12);
//namesAndRate.Add("Olya", 10);
//namesAndRate.Add("Marta", 8);

//bool val = false;
//Console.WriteLine("Tell me your name");
//while (!val)
//{
//	string name = Console.ReadLine();
//	if (namesAndRate.ContainsKey(name))
//	{
//		Console.WriteLine("Yes, you are in the List, your rate is " + namesAndRate[name]);
//		val = true;
//	}
//	else {
//		Console.WriteLine("I can't find yout, try one more time");
//	}
//}
//List<string> listOfProducts = new List<string>();
//bool val = false;

//while (!val) {
//	Console.WriteLine("1 — Додати продукт\r\n2 — Видалити продукт\r\n3 — Показати список\r\n4 — Вийти\r\n");
//	string input = Console.ReadLine();
//	if (input == "1")
//	{
//		Console.WriteLine("Let me know what you want to add");
//		string newProduct = Console.ReadLine();
//		listOfProducts.Add(newProduct);
//	}
//	else if (input == "2") {
//		Console.WriteLine("Let me know what you want to delete");
//		bool localVal = false;
//		while (!localVal) {
//			string deleteProduct = Console.ReadLine();
//			if (listOfProducts.Contains(deleteProduct))
//			{
//				listOfProducts.Remove(deleteProduct);
//				Console.WriteLine("We removed it");
//				localVal = true;
//			}
//			else {
//				Console.WriteLine("We don't have this product in our list, pls try again");
//			}
//		}

//	} else if (input == "3") {
//		foreach (string i in listOfProducts) {
//			Console.WriteLine(i);
//		}
//	} else if (input == "4") {
//		val = true;
//	}
//}