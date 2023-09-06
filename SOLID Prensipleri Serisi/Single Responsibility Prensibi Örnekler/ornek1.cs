public class EmailService
{
	private readonly EmailLogger emailLogger;

	public EmailService()
	{
		this.emailLogger = new EmailLogger();
	}
	public void SendEmail(string recipient, string subject, string message)
	{
		// Eposta göndermek için çalışacak olan kod
		Console.WriteLine($"{recipient} adresine eposta gönderildi. {subject}: {message}");

		// Log tutmak için gereken metod
		emailLogger.LogEmailActivity(recipient, subject);
	}
}

public class EmailLogger
{
	public void LogEmailActivity(string recipient, string subject)
	{
		Console.WriteLine($"Log kaydı tutuldu: {recipient}: {subject}");
	}
}

class Program
{
	static void Main()
	{
		// EmailServisten bir nesne oluştur
		EmailService emailSender = new EmailService();
		
		// Email gönder
		emailSender.SendEmail("recipient@example.com","Test" ,"Bu bir test maili");
	}
}