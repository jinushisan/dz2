//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Задача 10 ");

Console.Write("Введи трёхзначное число: ");

int numb33 = Convert.ToInt32(Console.ReadLine());

string stringNumber = Convert.ToString(numb33);

Console.WriteLine("вторая цифра этого числа -> " + stringNumber[1]);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Задача 13 ");

Console.Write("Введи число: ");
int anynumber = Convert.ToInt32(Console.ReadLine());
string anynumberLine = Convert.ToString(anynumber);
if (anynumberLine.Length > 2)
{
    Console.WriteLine("третья цифра -> " + anynumberLine[2]);
}
else
{
    Console.WriteLine("-> третьей цифры нет");
}

