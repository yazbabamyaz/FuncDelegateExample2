internal class Program
{
    private static void Main(string[] args)
    {
        Func<double, double> squareFunc = Square;
        Console.WriteLine($"Karesi = {squareFunc(4)}");

        Func<double, double> cubicFunc = Cubic;
        Console.WriteLine($"Küpü = {cubicFunc(4)}");

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