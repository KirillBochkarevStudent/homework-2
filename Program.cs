//Функция для ввода:
int Input()
{
    int rezult = Convert.ToInt32(Console.ReadLine());
    return rezult;
}
//Задача №10: Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void Task10()
{
    Console.Write("Введите число: ");
    int number = Input();
    int f_digit = number / 100;
    int s_digit = (number - f_digit * 100) / 10;
    Console.Write("Вторая цифра: ");
    Console.Write(s_digit);
}
//Задача №13: Программа, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void Task13()
{
    Console.Write("Введите число: ");
    int number = Input();
    int l = 0;
    int b = 3;
    int a = 10;
    int number1 = number;
    while (number1 > 0)
    {
        number1 = number1 / 10;
        l = l + 1;
    }
    if (l > 2)
    {
        while (b <= l)
        {
            a = a * 10;
            b = b + 1;
        }
        int c = a / 100;
        int d = number / c;
        int t_digit = d - (d / 10) * 10;
        Console.Write("Третья цифра: ");
        Console.WriteLine(t_digit);
    }
    else
    {
        Console.Write("Третьей цифры нет");
    }
}
//Задача №15: Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void Task15()
{
    Console.Write("Введите день недели: ");
    int digit = Input();
    if (digit > 0 & digit < 8)
    {
        if (digit > 5)
        {
            Console.WriteLine($"День {digit} является выходным");
        }
        else
        {
            Console.WriteLine($"День {digit} не является выходным");
        }
    }
    else
    {
        Console.WriteLine($"Цифра {digit} не обозначает ни один из дней недели");
    }
}


Console.Write("Введите номер задачи: ");
int task = Input();
if (task == 10)
{
    Task10();
}
else if (task == 13)
{
    Task13();
}
else if (task == 15)
{
    Task15();
}