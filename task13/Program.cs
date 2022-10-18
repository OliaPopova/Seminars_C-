// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Задача #13");

Console.Write("Введи число: ");
int N = Convert.ToInt32(Console.ReadLine());
string string_N = Convert.ToString(N);
if (string_N.Length > 2){
  Console.WriteLine("Ответ: " + string_N[2]);
}
else {
  Console.WriteLine("Ответ: третьей цифры нет");
}
