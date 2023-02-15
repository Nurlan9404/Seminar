/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/
/*Console.WriteLine("Задайте массив положительными трёхзначными числами.");
double EnterNumber(string number)
{
    Console.Write($"Enter {number}: ");
    double num = Convert.Todouble32(Console.ReadLine());
    return num;
}


double [] CreateArray(double size, double minValue, double maxValue)
{
    double [] res = new double[size];

    for (double i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

double ArraySize = EnterNumber("Enter array size");
double minValue = EnterNumber("Enter minValue for array");
double maxValue = EnterNumber("Enter maxValue for array");


double [] numbers = CreateArray(ArraySize, minValue, maxValue);
Console.WriteLine(String.Join(" ", numbers));

double result = 0;
for (double i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0) 
{
    result ++;
}
Console.WriteLine("Количество чётных чисел " + result );*/



/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

/*double EnterNumber(string number)
{
    Console.Write($"Enter {number}: ");
    double num = Convert.Todouble32(Console.ReadLine());
    return num;
}


double [] CreateArray(double size, double minValue, double maxValue)
{
    double [] res = new double[size];

    for (double i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

double ArraySize = EnterNumber("Enter array size");
double minValue = EnterNumber("Enter minValue for array");
double maxValue = EnterNumber("Enter maxValue for array");


double [] numbers = CreateArray(ArraySize, minValue, maxValue);
Console.WriteLine(String.Join(" ", numbers));
double sum = 0;
for (double i = 0; i < numbers.Length; i++)
if (i % 2 != 0)
{
    sum += numbers[i];
}
Console.WriteLine("Сумма стоящих на нечётных позициях чисел " + sum);*/

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}