// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53



Console.WriteLine("Задача № 21");
Console.WriteLine("Введите координату точки Х1 :");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки Х2 :");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки Y1 :");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки Y2 :");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки Z1 :");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки Z2 :");
int z2 = Convert.ToInt32(Console.ReadLine());


double distance=Distance(x1, x2, y1, y2, z1, z2);
distance  =  Math.Round (distance , 2);

double Distance(int x1, int x2, int y1, int y2, int z1, int z2){
      double dist=Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
     return dist;
}

Console.WriteLine($"А ({x1},{y1},{z1}) ; B ({x2},{y2},{z2}) -> {distance}");
