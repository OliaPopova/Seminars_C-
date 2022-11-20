// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.Write("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
if(m<=0){
    Console.Write("Введите число БОЛЬШЕ 0: ");
    m = Convert.ToInt32(Console.ReadLine());
}
int[] numbers = new int[m];

for(int i = 0; i < m; i++)
    {
        Console.Write("Введите число: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }


void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write("]");
}

int CountArray(int[] array)
{
int count = 0;
for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
            {
                count++;
            }
    }
return count;
}

PrintArray(numbers);
int count=CountArray(numbers);

Console.WriteLine();
Console.WriteLine($"количество значений больше 0 : {count}");
