public class MyMath
{
    static public int Cube(int value) //Cube 立方體
    {
        return (value * value * value);
    }
    static public double Cube(double value) //Cube 立方體
    {
        return (value * value * value);
    }
    static public int Square(int value) //Square 平方
    {
        return (value * value);
    }
    static public double Square(double value) //Square 平方
    {
        return (value * value);
    }

    // 傳回三個整數中的最小值
    public static int MinElement(int a, int b, int c)
    {
        return Math.Min(a, Math.Min(b, c));
    }
    // 傳回四個整數中的最小值（過載）
    public static int MinElement(int a, int b, int c, int d)
    {
        return Math.Min(a, Math.Min(b, Math.Min(c, d)));
    }
}
class Program
{
    static void Main(string[] args)
    {
        int value1 = 10;
        double value2 = 10.5;
        int value3 = 20;
        int value4 = 25;
        int value5 = 5;
        Console.WriteLine("立方（int）：" + MyMath.Cube(value1));
        Console.WriteLine("立方（double）：" + MyMath.Cube(value2));
        Console.WriteLine("平方（int）：" + MyMath.Square(value1));
        Console.WriteLine("平方（double）：" + MyMath.Square(value2));
        Console.WriteLine("最小值（三個參數）：" + MyMath.MinElement(value1,value3,value4));
        Console.WriteLine("最小值（四個參數）：" + MyMath.MinElement(value1, value3, value4, value5));
    }
}
