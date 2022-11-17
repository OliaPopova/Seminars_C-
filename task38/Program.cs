// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
for(int i = 0; i < size; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int j = 0; j <size; j++)
{
    if (numbers[j] > max)
        {
            max = numbers[j];
        }
    if (numbers[j] < min)
        {
            min = numbers[j];
        }
}


for (int i = 0; i < size; i++)
    {
        Console.Write("{0}; ", numbers[i]);
    }
double raznica=max - min;
Console.Write("->{0}",raznica);






