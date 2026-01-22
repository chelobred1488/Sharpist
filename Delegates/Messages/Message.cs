namespace Delegates.Messages;

public class Message
{
    public string Text { get; set; }
    public Message(string text) => Text = text;
    public virtual void Print() => Console.WriteLine($"Message: {Text}");
}