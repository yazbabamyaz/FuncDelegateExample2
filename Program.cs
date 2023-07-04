internal class Program
{
    private static void Main(string[] args)
    {
        Func<double, double> square = Square;
        Console.WriteLine($"Karesi = {square(4)}");

        Func<double, double> cubic = Cubic;
        Console.WriteLine($"Küpü = {cubic(4)}");

        Func<string> goster= Show;
        goster.Invoke();
    }

    static double Square(double number)=>Math.Pow(number,2);
    static double Cubic(double number) => Math.Pow(number, 3);

    static string Show()
    { Console.WriteLine("Test Message..."); 
        return "";
    }
}