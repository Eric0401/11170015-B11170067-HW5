using System.Diagnostics;

interface IPrice
{
    double GetPrice();
}
class Car : IPrice
{
    public double Price;
    public string Name;
    public Car (double price, string name)
    {
        Price = price;
        Name = name;
    }
    public double GetPrice()
    {
        return Price;
    }
    public string GetName()
    {
        return Name;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car car = new Car(880000, "Bus");
        Console.WriteLine($"車輛價格：{car.GetPrice()}");
        //Console.WriteLine($"車輛名稱：{car.GetName()}");
        Console.ReadLine();

        /*Console.Write("請輸入車輛名稱：");
        string name = Console.ReadLine();
        Console.Write("請輸入車輛價格：");
        double price;
        while (!double.TryParse(Console.ReadLine(), out price))
        {
            Console.Write("輸入無效，請輸入數字格式的價格：");
        }
        Car car = new Car(price, name);
        Console.WriteLine($"車輛名稱：{car.GetName()}");
        Console.WriteLine($"車輛價格：{car.GetPrice():C}");*/
    }
}