public interface IShape
{
    int CalculateArea();
}

class Rectangle : IShape
{
    private int Width { get; set; }
    private int Height { get; set; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int CalculateArea()
    {
        return Width * Height;
    }
}

class Square : IShape
{
    private int Side { get; set; }

    public Square(int side)
    {
        Side = side;
    }

    public int CalculateArea()
    {
        return Side * Side;
    }
}

class Program
{
    static void Main()
    {
        IShape rectangle = new Rectangle(5, 10);
        Console.WriteLine($"Dikdörtgen alanı: {rectangle.CalculateArea()}");

        IShape square = new Square(5);
        Console.WriteLine($"Kare alanı: {square.CalculateArea()}");
    }
}