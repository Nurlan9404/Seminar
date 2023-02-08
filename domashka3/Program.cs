/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

/*Console.WriteLine("введите число");
string x = Console.ReadLine();
char[] arr = x.ToCharArray();
Array.Reverse(arr);
string x2 = new String(arr);
 
if (x == x2) Console.WriteLine("Палиндром");
else Console.WriteLine("Не палиндром");*/

/*Задача 21: Напишите программу, которая принимает 
на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A(3,6,8); B(2,1,-7),-> 15.84
A(7,-5,0); B(1,-1,9),-> 11.53*/

/*Console.WriteLine("Entre number X1 ");
double numX1 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre number Y1 ");
double numY1 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre number Z1 ");
double numZ1 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre number X2 ");
double numX2 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre number Y2 ");
double numY2 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre number Z2 ");
double numZ2 = double.Parse(Console.ReadLine());

double numSQRT = Math.Sqrt(Math.Pow((numX1-numX2),2)+Math.Pow((numY1-numY2),2)+Math.Pow((numZ1-numZ2),2));

System.Console.WriteLine(numSQRT);*/
/*Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9. 
5 -> 1, 8, 27, 64, 125*/

/*System.Console.WriteLine("Enter number: ");

int Number = int.Parse(Console.ReadLine());

int I = 1;

while(I  <= Number)
{
    Console.Write(I*Math.Pow(I, 2)+ " ");
    I+=1;
}*/