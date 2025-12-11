class Button
{
	public delegate void ButtonDelegate(int msg);
	public event ButtonDelegate ButtonClick;

	public void OnButtonClick()
	{
		Console.WriteLine("Button was clicked");
		ButtonClick?.Invoke(3);
	}
}

class Publisher
{
	public delegate void Notify(string message);

	public event Notify OnNotify;

	public void DoSomething()
	{
		Console.WriteLine("something happened");

		OnNotify?.Invoke("Hello subscribers");
	}
}
class Subscriber
{
	public void Respond(string msg)
	{

		Console.WriteLine("Subscriber received: " + msg);
	}
	public void ClickResp(int msg) {
		Console.WriteLine("Subscriber saw button was clicked" + msg);
	}
}

class Program
{
	static void Main()
	{
		Publisher publisher = new();
		Subscriber subscriber = new();
		Button btn = new();

		publisher.OnNotify += subscriber.Respond;
		btn.ButtonClick += subscriber.ClickResp;
		publisher.DoSomething();
		btn.OnButtonClick();
	}
}