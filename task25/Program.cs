// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Задача #25 ");

Console.Write("Введите число для возведения в степень: ");
int A = Convert.ToInt32(Console.ReadLine());
if(A<=0){
    Console.Write("Введите число БОЛЬШЕ 0: ");
    A = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введите степень (натуральное число): ");
int B = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int numberA, int numberB){
  
    int result = Convert.ToInt32(Math.Pow(numberA, numberB));
    return result;
} 
 int exponentiation = Exponentiation(A,B);
  Console.WriteLine("{0}, {1}-> {2}",A,B, exponentiation);
