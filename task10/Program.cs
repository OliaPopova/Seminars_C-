// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Clear();
Console.WriteLine("Задача #10 ");
Console.Write("Введи трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string string_a = Convert.ToString(a);
Console.WriteLine("Ответ:"+string_a[1]);