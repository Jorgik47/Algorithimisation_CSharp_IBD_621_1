namespace Task1_1;

class Program
{
    static void Main(string[] args)
    {
        const double a = 2;
        const double b = 3;
        const double c = 4;
        
        Console.WriteLine("Введите значение x: ");
        string input = Console.ReadLine();
        double x = double.Parse(input);
        
        double y = a * Math.Abs(Math.Pow(x, 3)-b) / Math.Sqrt(Math.Pow(x,2)+c) +((3/4) * Math.Pow(Math.Sin(x),2));
        Console.WriteLine($"Ответ: {y}");


    }
}

//23