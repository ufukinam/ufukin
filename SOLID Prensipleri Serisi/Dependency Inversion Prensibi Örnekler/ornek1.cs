// Mesaj gönderme soyutlaması
public interface IMessageSender
{
	void Send(string recipient, string message);
}

// Eposta gönderme fonksiyonunu içeren alt seviye modül
public class EmailService : IMessageSender
{
	public void Send(string recipient, string message)
	{
		Console.WriteLine($"Mail gönderiliyor: {recipient}: {message}");
	}
}

// SMS gönderme fonksiyonunu içeren alt seviye modül
public class SmsService : IMessageSender
{
	public void Send(string recipient, string message)
	{
		Console.WriteLine($"Sms gönderiliyor: {recipient}: {message}");
	}
}


// IMessageSender kullanarak mesaj gönderen üst seviye modül
public class MessageSender
{
	private IMessageSender sender;
	public MessageSender(IMessageSender sender)
	{
		this.sender = sender;
	}

	public void Send(string recipient, string message)
	{
		this.sender.Send(recipient, message);
	}
}

class Program
{
	static void Main()
	{

		// MessageSender objeleri oluşturuyoruz email ve sms göndermek için
		MessageSender emailMessageSender = new MessageSender(new EmailService());
		MessageSender smsSender = new MessageSender(new SmsService());

		// email ve sms gönderme kodları
		emailMessageSender.Send("ornek@example.com", "Bu bir eposta mesajı.");
		smsSender.Send("0505*******", "Bu bir SMS mesajı");

	}
}