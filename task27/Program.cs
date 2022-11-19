// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Задача #27 ");

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
if(A<=0){
    Console.Write("Введите число БОЛЬШЕ 0: ");
    A = Convert.ToInt32(Console.ReadLine());
}

 int Sum(int A){
    int count= Convert.ToString(A).Length;
    int result = 0;

    for (int i = 0; i < count; i++){
      result = result + (A - (A - A % 10));
      A = A/ 10;
    }
   return result;
  }

  int res=Sum(A);

  Console.WriteLine("{0}-> {1}",A, res);









