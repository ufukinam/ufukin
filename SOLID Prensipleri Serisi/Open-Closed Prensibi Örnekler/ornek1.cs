// Önce, temel görev olan kahve hazırlama işlevselliğini soyut şekilde temsil eden bir interface oluşturalım.
public interface IPrepareCoffee
{
	void Prepare();
}

// Daha sonra bu arayüzü kullanan ve kahve hazırlama işlevini içeren sınıflar oluşturalım.
// Filtre kahve sınıfı
public class FilterCoffee : IPrepareCoffee
{
	public void Prepare()
	{
		Console.WriteLine("Filtre kahve yapılıyor...");
	}
}

// Amerikano sınıfı
public class Americano : IPrepareCoffee
{
	public void Prepare()
	{
		Console.WriteLine("Amerikano yapılıyor...");
	}
}

// Latte Sınıfı
public class Latte : IPrepareCoffee
{
	public void Prepare()
	{
		Console.WriteLine("Latte yapılıyor...");
	}
}

// Son olarak da bu sınıfları kullanarak istediğimiz kahveyi hazırlayacak sınıfı oluşturabiliriz.
public class CoffeeMachine
{
	public void PrepareCoffee(IPrepareCoffee coffee)
	{
		coffee.Prepare();
	}
}

class Program
{
	static void Main()
	{
		CoffeeMachine machine = new CoffeeMachine();
		machine.PrepareCoffee(new FilterCoffee()); // Filtre kahve yapılıyor...
		machine.PrepareCoffee(new Americano());   // Amerikano yapılıyor...
		machine.PrepareCoffee(new Latte());   // Latte yapılıyor...
	}
}