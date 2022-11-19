// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] array = new int[8];

Random rnd = new Random();

void Func(){
    for (int i = 0; i < 8; i++)
    {
        Console.Write("Введите число: ");
        int A = Convert.ToInt32(Console.ReadLine());
        array[i]=A;
    }
    for (int i = 0; i < 8; i++)
    {
        Console.Write("{0}, ", array[i]);
    }

    Console.WriteLine("->[{0}]", string.Join(", ", array));
}

Func();

