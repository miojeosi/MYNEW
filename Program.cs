Console.WriteLine("Выбрать команду");
Console.WriteLine("1. сложить 2  числа");
Console.WriteLine("2.вычесть первое из второго ");
Console.WriteLine("3. Перемножить два числа");
Console.WriteLine("4. Разделить первое на второе ");
Console.WriteLine("5. возвести в степень N первое число");
Console.WriteLine("6. найти квадратный корень из числа ");
Console.WriteLine("7. найти процент от числа ");
Console.WriteLine("8. найти факториал из числа ");
Console.WriteLine("9. выйти из программы");



int nomer = 0;
while (nomer <= 8)
{
    int zadanie = Convert.ToInt32(Console.ReadLine());
    nomer = zadanie;
    if (zadanie == 1)
    {
        Console.WriteLine("введите первое число ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите второе число ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(a + b);


        Console.WriteLine("введите число еще раз ");
    }

    if (zadanie == 2)
    {
        Console.WriteLine("введите первое число ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите второе число ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(a - b);

        Console.WriteLine("введите число еще раз ");
    }
    if (zadanie == 3)
    {
        Console.WriteLine("введите первое число ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите второе число ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(a * b);

        Console.WriteLine("введите число еще раз ");
    }
    if (zadanie == 4)
    {
        Console.WriteLine("введите первое число ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите второе число ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(a / b);

        Console.WriteLine("введите число еще раз ");
    }

    if (zadanie == 5)
    {
        Console.WriteLine("введите первое число ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите желаемую степень ");
        int b = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < b; i++)
            a <<= 1;
        Console.WriteLine(a);

        Console.WriteLine("введите число еще раз ");
    }

    if (zadanie == 6)
    {
        Console.WriteLine("введите число из которого надо извлечь квадратный корень ");
        int a = Convert.ToInt32(Console.ReadLine());

        double b = Math.Sqrt(a);
        Console.WriteLine(b);

        Console.WriteLine("введите число еще раз ");
    }

    if (zadanie == 7)
    {
        Console.WriteLine("введите число чтобы йузнать его 1 процент ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(a / 100);

        Console.WriteLine("введите число еще раз ");
    }

        if (zadanie == 8)
        {
            Console.WriteLine("введите число чтобы узнать его факториал ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 1;

            for (int i = 2; i <= a; i++)
            {
                b = b * i;
            }

            Console.WriteLine(b);
        }

} 
