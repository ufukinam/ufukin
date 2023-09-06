public interface IUser
{
    void Login();
    void Logout();
    void ReadPost();
}

public interface IAuthor
{
    void WritePost();
}

public class Author : IUser, IAuthor
{
    public void Login()
    {
        // Login kodu
    }

    public void Logout()
    {
        // Logout kodu
    }

    public void ReadPost()
    {
        // Readpost kodu
    }

    public void WritePost()
    {
        // WritePost kodu
    }
}

public class Reader : IUser
{
    public void Login()
    {
        // Login kodu
    }

    public void Logout()
    {
        // Logout kodu
    }

    public void ReadPost()
    {
        // Readpost kodu
    }
}