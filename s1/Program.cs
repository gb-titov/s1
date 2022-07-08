using System;
using System.Linq;

namespace s1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нахождение максимального из двух чисел:");
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Максимальное число: {NumberMethods.GetMax(a,b)}" );


            Console.WriteLine("Нахождение максимального из трех чисел:");
            Console.Write("Введите первое число: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int c = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Максимальное число: {NumberMethods.GetMax(a, b, c)}");


            Console.WriteLine("Проверка на четность:");
            Console.Write("Введите число: ");
            a = int.Parse(Console.ReadLine());
            string isEven = NumberMethods.IsEven(a) ? "четное" : "нечетное";

            Console.WriteLine($"Число {a} {isEven}");


            Console.WriteLine("Нахождение всех четных чисел до указанного числа:");
            Console.Write("Введите число: ");
            a = int.Parse(Console.ReadLine());

            foreach (var i in NumberMethods.GetAllEvenTillNumber(a))
            {
                Console.Write(i + " ");
            }
            
        }
    }
}
