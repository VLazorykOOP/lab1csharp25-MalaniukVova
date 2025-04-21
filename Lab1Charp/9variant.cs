using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Виберіть задачу:");
        Console.WriteLine("1. Довжина ребра куба");
        Console.WriteLine("2. Сума цифр двозначного числа");
        Console.WriteLine("3. Координатна перевірка");
        Console.WriteLine("4. Дата m місяців тому");
        Console.WriteLine("5. Квадрат числа");
        Console.WriteLine("6. Обчислення виразу");
        Console.Write("Ваш вибір: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: Task2(); break;
            case 2: Task3(); break;
            case 3: Task4(); break;
            case 4: Task5(); break;
            case 5: Task6(); break;
            case 6: Task7(); break;
            default: Console.WriteLine("Невірний вибір"); break;
        }
    }

    static void Task2()
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

    static void Task3()
    {
        Console.Write("Введіть двозначне число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number < 10 || number > 99)
        {
            Console.WriteLine("Це не двозначне число!");
            return;
        }
        int digit1 = number / 10;
        int digit2 = number % 10;
        int sum = digit1 + digit2;
        Console.WriteLine("Сума цифр: " + sum);
        Console.WriteLine(sum % 2 == 0 ? "Сума цифр парна." : "Сума цифр непарна.");
    }

    static void Task4()
    {
        Console.Write("Введiть координату x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введiть координату y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        double absX = Math.Abs(x);
        if (y > absX && y < 12)
            Console.WriteLine("Так");
        else if (Math.Abs(y - absX) < 1e-6 || Math.Abs(y - 12) < 1e-6)
            Console.WriteLine("На межi");
        else
            Console.WriteLine("Нi");
    }

    static void Task5()
    {
        Console.Write("Введіть кількість місяців m: ");
        int m = int.Parse(Console.ReadLine());
        DateTime currentDate = DateTime.Now;
        DateTime resultDate = currentDate.AddMonths(-m);
        Console.WriteLine("Дата, що була " + m + " місяців тому: " + resultDate.ToString("dd-MM-yyyy"));
    }

    static void Task6()
    {
        Console.Write("Введіть ціле число: ");
        int num = int.Parse(Console.ReadLine());
        int result = Square(num);
        Console.WriteLine("Квадрат числа " + num + " дорівнює: " + result);
    }

    static int Square(int number)
    {
        return number * number;
    }

    static void Task7()
    {
        Console.Write("Введіть значення x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть значення y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        double numerator = 5 * x + Math.Pow(y, 2);
        double denominator = Math.Pow(y, 2) + 1;
        double firstPart = Math.Pow(x * y, 2);
        double secondPart = numerator / denominator;
        double result = firstPart - secondPart;

        Console.WriteLine($"Результат: {result}");
    }
}
