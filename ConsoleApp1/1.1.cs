using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть площу повної поверхні куба (S): ");
        double S = Convert.ToDouble(Console.ReadLine());

        if (S <= 0)
        {
            Console.WriteLine("Площа має бути додатнім числом.");
            return;
        }

        double a = Math.Sqrt(S / 6);
        Console.WriteLine("Довжина ребра куба: {0:F2}", a);
    }
}
