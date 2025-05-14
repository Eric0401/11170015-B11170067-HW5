delegate int Mydelegate(int opd1);

class Conversion
{
    public static int FeetToInches(int opd1)
    {
        return opd1 = opd1 * 12; // 英尺轉英吋
    }

    public static int YardsToInches(int opd1)
    {
        return opd1 = opd1 * 3 * 12; // 英碼轉英吋
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("請輸入一長度數值：");
        string input = Console.ReadLine();
        int value;

        while (!int.TryParse(input, out value))
        {
            Console.Write("輸入無效，請重新輸入整數數值：");
            input = Console.ReadLine();
        }

        Console.Write("請選擇單位 (1 = 英尺, 2 = 英碼)：");
        string choice = Console.ReadLine();

        Mydelegate convert;

        if (choice == "1")
        {
            convert = new Mydelegate(Conversion.FeetToInches);
        }
        else if (choice == "2")
        {
            convert = new Mydelegate(Conversion.YardsToInches);
        }
        else
        {
            Console.WriteLine("無效的選擇，程式結束。");
            return;
        }

        int result = convert(value);
        Console.WriteLine($"\n轉換結果：{value} {(choice == "1" ? "英尺" : "英碼")} = {result} 英吋");
    }
}
