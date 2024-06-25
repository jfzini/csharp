public class Program
{
    public static void Main()
    {
        // long someLongNumber = 51614;
        // // int intNumber = Convert.ToInt32(someLongNumber);
        // int intNumber = (int)someLongNumber;

        // Console.WriteLine(intNumber);
        // string str = "123";
        // // int num = Convert.ToInt32(str);
        // int num = int.Parse(str);
        // Console.WriteLine(num);

        // const int num = 123;
        // string str = num.ToString();
        // Console.WriteLine(str);

        bool canConvert = int.TryParse("123M", out int number);
        if (canConvert)
        {
            Console.WriteLine(number);
        }
        else
        {
            Console.WriteLine("Conversion failed");
        }
    }
}