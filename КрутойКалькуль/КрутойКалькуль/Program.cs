using System;

namespace КрутойКалькуль
{
    class Program
    {
        static void Main(string[] args)
        {
            string number, number1;
            float b, a;

            Console.WriteLine("Введите первое число: ");
            //a = Convert.ToInt32(Console.ReadLine());
            number = Console.ReadLine();
            bool result = float.TryParse(number, out a);
            if (result)
            {
                //do someth
                // Console.Write("я молодец");
            }
            else
            {
                //error
                Console.WriteLine("Вводить число! а не символы(((");
            }
            Console.WriteLine("Введите второе число: ");
            number1 = Console.ReadLine();
            bool result1 = float.TryParse(number1, out b);
            if (result1)
            {
                //do someth
              Console.Write("я молодец");
            }
            else
            {
                //error
                Console.WriteLine("Вводить число! а не символы(((");
            }
            Console.Write("Результат сложения: "); Console.WriteLine(a + b);
            Console.Write("Результат вычитания: "); Console.WriteLine(a - b);
            Console.Write("Результат умножения: "); Console.WriteLine(a * b);
            Console.Write("Результат деления: ");
            if (b == 0) Console.WriteLine("Ошибка! Деление на 0");
            else
                Console.WriteLine(a / b);
        }
    }
}
