// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.WriteLine("Введите размерность матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = new int[n, n];
int[,] matrixB = new int[n, n];


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5); 
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("|");
        Console.WriteLine("");
    }
}


FillArray(matrixA);
FillArray(matrixB);
int[,] matrixC = new int[n, n];

void Multiplication(int[,] matrixA, int[,] matrixB)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int z = 0; z < n; z++)
            {
                matrixC[i, j] = matrixC[i, j] + (matrixA[i, z] * matrixB[z, j]);
            }
        }
    }
    Console.WriteLine("Произведение матриц А*В");
    PrintArray(matrixC);

}
Console.WriteLine("Матрица - А");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В");
PrintArray(matrixB);
Console.WriteLine();

Multiplication(matrixA, matrixB);
