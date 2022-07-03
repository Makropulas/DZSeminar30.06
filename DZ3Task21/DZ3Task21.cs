/*
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.

Пример:
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

namespace DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Введите координаты первой точки: ");
            Console.Write("Координата X = ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Координата Y = ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Координата Z = ");
            int z1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Введите координаты второй точки: ");
            Console.Write("Координата X = ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Координата Y = ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Координата Z = ");
            int z2 = Convert.ToInt32(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));

            Console.WriteLine("--------------------------------");

            Console.Write($"Расстояние от первой точки до второй: {distance}");
        }
    }
}


