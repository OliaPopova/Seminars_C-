// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53



Console.WriteLine("Задача № 21");
int x1 = Coordinate("x1", "A");
int y1 = Coordinate("y1", "A");
int z1 = Coordinate("z1", "A");
int x2 = Coordinate("x2", "B");
int y2 = Coordinate("y2", "B");
int z2 = Coordinate("z2", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"А ({x1},{y1},{z1}) ; B ({x2},{y2},{z2}) -> {segmentLength}");
