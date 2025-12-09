class Program {
	public static void Main(string[] args) {
		Action<string> delAct = msg => Console.WriteLine($"Hello {msg}");
		delAct("Rost");
	}
}