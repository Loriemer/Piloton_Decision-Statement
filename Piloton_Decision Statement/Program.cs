public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number 1: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter Number 2: ");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 == num2) Console.WriteLine("{0}=={1}", num1, num2);
        if (num1 > num2) Console.WriteLine($"{num1}>{num2}");
        if (num1 < num2) Console.WriteLine($"{num1}<{num2}");
    }
}