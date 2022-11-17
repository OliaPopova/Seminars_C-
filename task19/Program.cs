
// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.WriteLine("Задача № 19");
Console.Write("Введите ПЯТИЗНАЧНОЕ число: ");
int num =Convert.ToInt32(Console.ReadLine());

static bool IsPalindrom (int number)
    {
        int temp = number;
        int value;
        int numberRevers = 0;

        while (temp > 0)
        {
            value = temp % 10;
            numberRevers = numberRevers * 10 + value;
            temp /= 10;
        }

        if (numberRevers == number)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

if (num > 9999 & num<=99999){
  bool answer=IsPalindrom(num);
  if(answer){
    Console.WriteLine($"Палиндром!");
  }
  else{
    Console.WriteLine($"НЕ палиндром!");
  }

}
else Console.WriteLine($"Вы ввели НЕ ПЯТИЗНАЧНОЕ число!");





