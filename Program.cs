// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[n, m];
Fill_array(array);
Print_array(array);

void Fill_array(double[,] array)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void Print_array(double[,] array)
{
    for (int i = 0; i < n; i++)
    {
        
        for (int j = 0; j < m; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}




