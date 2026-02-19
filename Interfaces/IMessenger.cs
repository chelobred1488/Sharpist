namespace Interfaces;

public interface IMessenger<out T>
{
    T WriteMessage(string message);
}
class EmailMessenger : IMessenger<EmailMessage>
{
    public EmailMessage WriteMessage(string text)
    {
        return new EmailMessage($"Email: {text}");
    }
}

class Messages
{
    public string Text { get; set; }
    public Messages(string text) => Text = text;
}
class EmailMessage : Messages
{
    public EmailMessage(string text) : base(text) { }
}