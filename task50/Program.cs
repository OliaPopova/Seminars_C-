// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет


Console.WriteLine("Введите номер строки : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца : ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [4,5];
Fill_array(array);
PrintArray(array);


void Fill_array(int[,] array)
{
    for (int i = 0; i < 4; i++)
        {        
            for (int j = 0; j < 5; j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
       
        Console.WriteLine(""); 
    }
}


if (n > 4 || m > 5)
{
    Console.WriteLine($"{n}, {m} -> такого элемента в массиве нет");
}
else
{
    Console.WriteLine($"{n}, {m} -> {array[n-1,m-1]}");
}
