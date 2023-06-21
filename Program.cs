/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
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


/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

