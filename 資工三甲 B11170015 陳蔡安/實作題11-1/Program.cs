class MyMath()
{
    static public int Cube(int value)
    {
        return value * value;
    }
    static public double Cube(double value)
    {
        return value * value;
    }
    static public int MinElement(int a, int b, int c)
    {
        int min = a;
        if (min > b)
        {
            min = b;
            if(min > c)
            {
                min = c;
            }
        }
        return min;
    }
    static public int MinElement(int a, int b, int c, int d)
    {
        int min = a;
        if (min > b)
        {
            min = b;
            if (min > c)
            {
                min = c;
                if(min > d)
                {
                    min = d;
                }
            }
        }
        return min;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        double b = 4.5;
        Console.WriteLine(a + "的平方為" + MyMath.Cube(a));
        Console.WriteLine(b + "的平方為" + MyMath.Cube(b));
        Console.WriteLine("最小值：" + MyMath.MinElement(14, 12, 32));
        Console.WriteLine("最小值：" + MyMath.MinElement(10, 21, 34, 4));
    }
}