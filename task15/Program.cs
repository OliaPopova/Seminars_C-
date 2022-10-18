// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Задача #15 ");

Console.Write("Введи цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

void Check (int day) {
  if (day == 6 || day == 7) {
  Console.WriteLine("да");
  }
  else if (day < 1 || day > 7) {
    Console.WriteLine("это не день недели");
  }
  else Console.WriteLine("нет");
}

Check(day);
