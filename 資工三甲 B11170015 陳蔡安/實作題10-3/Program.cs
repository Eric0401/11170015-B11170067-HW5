interface IPrice
{
    double GetPrice();
}
class Car : IPrice
{
    public double Price;
    public string Name;
    public Car(double price, string name)
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
/*
class Program
{
    static void Main()
    {
        Car myCar = new Car(25000, "Tesla Model 3");
        Console.WriteLine("車名：" + myCar.GetName());
        Console.WriteLine("價格：$" + myCar.GetPrice());
    }
}
*/