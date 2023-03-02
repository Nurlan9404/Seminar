/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
/*int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}


void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}



string LineGenRec(int num)
{
    if (num == 0)
    {
        return string.Empty;
    }
    else
    {
        
        return num + ", " + LineGenRec (num - 1);
    }
}

int number = ReadData("Введите число N: ");
string resultLine = LineGenRec(number);
PrintResult(resultLine);*/
/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
/*int GetSum(int m, int n)
{
    if (n > m)
        return n + GetSum(m, n - 1);
    return m;
}


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}


void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}


int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");


int sum = GetSum(m,n);

PrintData("Сумма элементов от М до N равна: ",sum);*/

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
int Ackerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Ackerman(n - 1, 1);
    else
      return Ackerman(n - 1, Ackerman(n, m - 1));
}


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}


void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}


int n = ReadData("Введите число N: ");
int m = ReadData("Введите число M: ");


int sumAckerman = Ackerman(n, m);


PrintData("значение функции Аккермана равно: ", sumAckerman);