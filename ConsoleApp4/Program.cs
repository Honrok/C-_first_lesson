//Виводимо числа від 1 до 10

//for (int i = 0; i < 10; i++) {
//	Console.WriteLine(i + 1);
//}

Console.WriteLine("Write numbers and I will sum all the numbers before you send me 0");
int sum = 0;
int res = 0;
int counter = 1;

while (counter != 0){
	string input = Console.ReadLine();
	if (input != null && int.TryParse(input, out int number))
	{
		res = int.Parse(input);
		sum += res;
		counter++;
		Console.WriteLine(sum);
	}
	else {
		counter = 0;
	}
}