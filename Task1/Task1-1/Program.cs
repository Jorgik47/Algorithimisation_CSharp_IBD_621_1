namespace Task1_1;

class Program
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    
    static void Main(string[] args)
    {
        const double a = 2;
        const double b = 3;
        const double c = 4;

        double x = GetNumber("Введите значение x: ");

        double y = GetResult(a, b, c, x);

        Console.WriteLine($"Ответ: {y}");


    }
    /// <summary>
    /// Расчет заданной функции
    /// </summary>
    /// <param name="a">Константа a</param>
    /// <param name="b">Константа b</param>
    /// <param name="c">Константа c</param>
    /// <param name="x">Переменная x</param>
    /// <returns>Результат расчета</returns>

    private static double GetResult(double a, double b, double c, double x)
    {
        return a * Math.Abs(Math.Pow(x, 3) - b) / Math.Sqrt(Math.Pow(x, 2) + c) + (3.0 / 4.0 * Math.Pow(Math.Sin(x), 2));
    }

    /// <summary>
    /// Получение числа от пользователя
    /// </summary>
    /// <param name="message">Сообщение для пользователя</param>
    /// <returns>Введенное пользователем число</returns>

    private static double GetNumber(string message)
    {
        Console.WriteLine(message);
        string input = Console.ReadLine();
        return double.Parse(input);
    }
}

//23