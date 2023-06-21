/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

/*
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int MappingNum(int number)
{
    int tempNum = 0;
    for (int i = 1; i <= 5; i++)
    {
        tempNum = tempNum * 10 + number % 10;
        number /= 10;
    }
    return tempNum;
}

int num = InputNum("Введите пятизначное число: ");
int backNum = MappingNum(num);
if (num == backNum)
    Console.WriteLine($"Число {num} - полиндром");
else
    Console.WriteLine($"Число {num} не является полиндромом");
*/

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

System.Console.Write("Введите координату xa: ");
double xa = double.Parse(Console.ReadLine()!);
System.Console.Write("Введите координату ya: ");
double ya = double.Parse(Console.ReadLine()!);
System.Console.Write("Введите координату za: ");
double za = double.Parse(Console.ReadLine()!);
System.Console.Write("Введите координату x: ");
double xb = double.Parse(Console.ReadLine()!);
System.Console.Write("Введите координату yb: ");
double yb = double.Parse(Console.ReadLine()!);
System.Console.Write("Введите координату zb: ");
double zb = double.Parse(Console.ReadLine()!);

double dist = Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2)), 2);
Console.WriteLine($"Расстояние между точками: {dist}");


/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

