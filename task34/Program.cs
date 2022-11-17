// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


Console.WriteLine("Задача #34 ");

Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
if(N<=0){
    Console.Write("Введите число БОЛЬШЕ 0: ");
    N = Convert.ToInt32(Console.ReadLine());
}
int[] array = new int[N];

 Random rnd = new Random();
for (int i = 0; i < N; i++)
    {
        array[i] = rnd.Next(100, 999);
        Console.Write("{0} ", array[i]);
    }
int count=0;
for (int i = 0; i < N; i++)
    {
        if(array[i] %2==0){
            count++;
        }
    }
Console.Write("->{0}",count);







