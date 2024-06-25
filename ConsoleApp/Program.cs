public class Program
{
    public static void Main()
    {
        long someLongNumber = 51614;
        // int intNumber = Convert.ToInt32(someLongNumber);
        int intNumber = (int)someLongNumber;

        Console.WriteLine(intNumber);
    }
}