using System.Globalization;

string txt;
double x;
double y;

do
{
    Console.WriteLine("Выбирете действия, которые вы хотите выполнить со своими числами");
    Console.WriteLine("1. Сложение (x + y)");
    Console.WriteLine("2. Вычитание (x - y)");
    Console.WriteLine("3. Умножение (x * y)");
    Console.WriteLine("4. Деление (x : y )");
    Console.WriteLine("5. Возведение в степень (x**y)");
    Console.WriteLine("6. Корень числа x ");
    Console.WriteLine("7. Найти 1 процент от числа x ");
    Console.WriteLine("8. Найти факториал из числа x");
    Console.WriteLine("9. Завершить сеанс");


    txt = Console.ReadLine();

    int number;
    if (int.TryParse(txt, out number))
    {
        if (number >= 1 && number <= 9)
        {

        }
        else
        {
            Console.WriteLine("Пожалуйста, укажи чилсла ОТ 1 ДО 9 (ну ты что? Глупинкай? 0_о)");
        }
    }
    else
    {
        Console.WriteLine("инвалид намбер. НАПИШИ ЧИСЛО!");
    }
    if (txt == "1")
    {
        Console.WriteLine("Введите 1 число X");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите 2 число Y");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("И ваш ответ..");
        Console.WriteLine(x + y);
        Console.WriteLine(" Что то ещё?");
    }
    else if (txt == "2")
    {
        Console.WriteLine("Введите 1 число X");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите 2 число Y");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("И ваш ответ..");
        Console.WriteLine(x - y);
        Console.WriteLine(" Что то ещё?");
    }
    else if (txt == "3")
    {
        Console.WriteLine("Введите 1 число X");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите 2 число Y");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("И ваш ответ..");
        Console.WriteLine(x * y);
        Console.WriteLine(" Что то ещё?");
    }
    else if (txt == "4")
    {
        Console.WriteLine("Введите 1 число X");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите 2 число Y");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("И ваш ответ..");
        Console.WriteLine(x / y);
        Console.WriteLine(" Что то ещё?");
    }
    else if (txt == "5")
    {
        Console.WriteLine("Введите 1 число X");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите 2 число Y");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("И ваш ответ..");
        Console.WriteLine(Math.Pow(x, y));
        Console.WriteLine(" Что то ещё?");
    }
    else if (txt == "6")
    {
        Console.WriteLine("Введите 1 число X");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("И ваш ответ..");
        Console.WriteLine(Math.Sqrt(x));
        Console.WriteLine(" Что то ещё?");
    }
    else if (txt == "7")
    {
        Console.WriteLine("Введите 1 число X");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("И ваш ответ..");
        Console.WriteLine(x / 100);
        Console.WriteLine(" Что то ещё?");
    }
    else if (txt == "8")
    {
        Console.WriteLine("Введите 1 число X");
        x = Convert.ToDouble(Console.ReadLine());
        long factorial = 1;
        for (int i = 1; i <= x; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("И ваш ответ..");
        Console.WriteLine(factorial);
        Console.WriteLine(" Что то ещё?");
    }

} while (txt != "9");