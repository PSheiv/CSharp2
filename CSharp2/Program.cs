
{
    Console.WriteLine("Task 10");
    Console.WriteLine("введите трехзначное число: ");

    int number = Convert.ToInt32(Console.ReadLine());
    int number2 = (number % 100) / 10;

    Console.WriteLine(number2);
    Console.WriteLine(" ");

}
/*{
    Console.WriteLine("Task 13");
    Console.WriteLine("введите любое число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 99)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {

        while (number > 999)
        {
            number = number / 10;
        }
        number = number % 100;
        if (number > 10)
        {
            number = number % 10;
        }
        Console.WriteLine(number);
        Console.WriteLine(" ");
    }
}*/
{
    Console.WriteLine("Task 13");
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет.");
    }
    else
    {
        while (number > 999)
        {
            number /= 10;
        }
        Console.WriteLine("Третья цифра: " + number % 10);
    }

}

{
    Console.WriteLine("Task 15");
    Console.WriteLine("введите любое число: ");
    int dayNumber = Convert.ToInt32(Console.ReadLine());

    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Ура, выходной!");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("В недели всего 7 дней");
    }
    else
    {
        Console.WriteLine("Сегодня будни :(");
    }
}
