// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine();
Console.WriteLine("Задача № 4");

Console.Write("Введи первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a; 

if (max < b) {
  max = b;
}
if (max < c) {
  max = c;
}
Console.WriteLine("MAX= " + max);

