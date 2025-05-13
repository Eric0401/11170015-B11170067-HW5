using System.ComponentModel.DataAnnotations;

public delegate void MyDelegate(double length);
class Conversion
{
    public double value;
    public void InchesToFeet(double length)
    {
        value = length / 12;
        Console.WriteLine("英吋轉換為英尺：" + value);
    }
    public void InchesToYards(double length)
    {
        value = length / 36;
        Console.WriteLine("英吋轉換為英碼：" + value);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.Write("請輸入英吋： ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("選擇轉換方式：");
        Console.WriteLine("1. 轉換為英尺");
        Console.WriteLine("2. 轉換為英碼");
        Console.Write("請輸入選項（1 或 2）：");
        string option = Console.ReadLine();
        Conversion conversion = new Conversion();
        if(option == "1")
        {
            MyDelegate myDelegate = new MyDelegate(conversion.InchesToFeet);
            myDelegate(length);
        }
        else if(option == "2")
        {
            MyDelegate myDelegate = new MyDelegate(conversion.InchesToYards);
            myDelegate(length);
        }
        else
        {
            Console.WriteLine("無效的選項");
        }
    }
}

