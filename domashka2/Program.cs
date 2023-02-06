/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

/*System.Console.WriteLine("Введите трёхзначное число: ");

int numberAAA;

if (! int.TryParse(Console.ReadLine(), out numberAAA)) 
{
    System.Console.WriteLine("Ошибка! Вы ввели не цифру!");
    return;
    
}

int result = (numberAAA / 10) % 10;

if (numberAAA / 100 < 1 || numberAAA / 100 > 10)
{
    System.Console.WriteLine("Ошибка! Вы вели не трёхзначное число!");
}
else
{
    System.Console.Write("Второе число " + result);
}
/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

/*System.Console.WriteLine("Введите число: ");

int number;

if (!int.TryParse(Console.ReadLine(), out number))
{
    System.Console.WriteLine("Ошибка! Вы ввели не цифру!");
    return;
}
int result = Math.Abs(number);

if (result < 100)
{
    System.Console.WriteLine("Третьей цифры нет!");
}
while (result > 999)
{
    if (result > 999) result /= 10;
}
System.Console.WriteLine("Третья цифра " + result % 10);
/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

/*System.Console.WriteLine("Введите день недели: ");

int dayoftheweek;
if (!int.TryParse(Console.ReadLine(), out dayoftheweek))
{
    System.Console.WriteLine("Ошибка! Вы ввели не цифру!");
    return;
}
if (dayoftheweek < 0 || dayoftheweek > 7)
{
    System.Console.WriteLine("Нет такой день недели!");
}
if (dayoftheweek == 6 || dayoftheweek == 7)
{
    System.Console.WriteLine("Сегодня выходной.");
}
if (dayoftheweek == 1 || dayoftheweek == 2)
{
    System.Console.WriteLine("Трудис работяга до выходных еще далеко.");
}
if (dayoftheweek == 3 || dayoftheweek == 4)
{
    System.Console.WriteLine("Трудис работяга до выходных осталось немного.");
}
if (dayoftheweek == 5)
{
    System.Console.WriteLine("Завтра уже выходной.");*/
}