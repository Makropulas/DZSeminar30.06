// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

namespace DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Введите пятизначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string str = number.ToString();

            Console.WriteLine("--------------------------------");

            if (number < 0)
            {
                Console.WriteLine("Число не должно быть отрицательным");
            }
            else if (str.Length < 5 || str.Length > 5)
            {
                Console.WriteLine("Начните сначала и введите ПЯТИЗНАЧНОЕ число");
            }
            else if (str.Length == 5) 
            {
                if (str[0] == str[4])
                {
                    if (str[1] == str[3]) Console.WriteLine("Ваше число - палиндром");
                }
                else Console.WriteLine("Ваше число не является палиндромом");
            }
            else
            {
                Console.WriteLine("Вы неверно ввели число. Пожалуйста, начните сначала");
            }
        }
    }
}
