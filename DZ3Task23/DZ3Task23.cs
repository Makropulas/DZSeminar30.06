// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

namespace DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Введите число: ");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("--------------------------------");

            string result = String.Empty;
            if (number <= 0)
            {
                Console.WriteLine("Число не соответствует условиям этой задачи");
            }
            for (double num = 1; num <= number; num++)
            {
                if (num < number) result = result + $"{Math.Pow(num, 3)}, ";
                else result = result + $"{Math.Pow(num, 3)}";
            }
            Console.WriteLine(result);
        }
    }
}