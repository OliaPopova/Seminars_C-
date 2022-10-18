// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine();
Console.WriteLine("Задача № 6");

Console.Write("Введи число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 1) {
   Console.WriteLine("Введенное число " + a + " - нечётное");
}
else {
  Console.WriteLine("Введенное число " + a + " - чётное"); 
}

