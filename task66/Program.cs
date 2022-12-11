// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



Console.WriteLine("Введите M:");
int m =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N:");
int n =  Convert.ToInt32(Console.ReadLine());

if (n < m)
{
    Console.WriteLine("Введите число n бОльшее чем m");
    n =  Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine($"Сумма элементов от {m} до {n} = {Sum(m, n)}");

int Sum(int m, int n)
{
    if (m == n)
        return n;
    return n + Sum(m, n - 1);
}

