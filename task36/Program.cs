// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Задача #36 ");

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
        array[i] = rnd.Next(-100, 100);
        Console.Write("{0} ", array[i]);
    }
int sum=0;
for (int i = 0; i < N; i++)
    {
        if(i%2==1){
            sum=sum+array[i];
        }
    }
Console.Write("->{0}",sum);


