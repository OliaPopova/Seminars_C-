// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Задача № 23");
Console.WriteLine("Введите число : ");
int cube = Convert.ToInt32(Console.ReadLine());

void Table(int cube){
  if(cube>0){
    int index=1;
    while(index<=cube){
      Console.WriteLine($"{index} | {index*index*index}");
      index++;
    }
  }
  else Console.WriteLine("Некорректное число");
}

Table(cube);


