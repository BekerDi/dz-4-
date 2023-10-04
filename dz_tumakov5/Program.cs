using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    internal class Program
    {
        /// Для задания 1
        static int FindMax(int num1, int num2)
        {
            int find = Math.Max(num1, num2);
            return find;
        }
        static int Zamena(ref int n1, ref int n2)
        {
            int n3 = n1;
            n1 = n2;
            n2 = n3;
            return n1;
            return n2;

        }
        static bool FindFactorial(int numb, out int result)
        {
            try
            {
                checked
                {
                    int factorial = 1;


                    for (int i = 1; i < numb; i++)
                    {
                        factorial *= i;

                    }
                    result = factorial;
                    return true;
                }
            }
            catch (OverflowException)
            {
                result = 0;
                return false;
            }
        }
        static int Factorial(int i)
        {
            if (i == 1)
            {
                return 1;
            }
            else
            {
                return i * Factorial(i - 1);
            }
        }
        static int NOD(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }
        static int NODfor3(int a, int b, int c)
        {
            {
                return NOD(NOD(a, b), c);
            }


        }
        static int Fibonacci(int f)
        {
            if (f <= 1)
            {
                return f;
            }
            return Fibonacci(f - 1) + Fibonacci(f - 2);
        }



        static void Main(string[] args)

        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите первое число");
            bool a = Int32.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("Введите второе число и нажмите ENTER, чтобы увидеть результат");
            bool b = Int32.TryParse(Console.ReadLine(), out int num2);
            int num = FindMax(num1, num2);
            Console.WriteLine("Большее число " + num);

            Console.WriteLine("Задание 2");


            Console.WriteLine("ведите значение первого параметра");
            bool p1 = Int32.TryParse(Console.ReadLine(), out int n1);
            Console.WriteLine("Введите значение второго параметра и нажмите ENTER, чтобы увидеть результат");
            bool p2 = Int32.TryParse(Console.ReadLine(), out int n2);
            Console.WriteLine("Вы ввели параметры: x = " + n1 + ", y=  " + n2);
            Zamena(ref n1, ref n2);
            Console.WriteLine("Значение после обмена: х= " + n1 + " , y= " + n2);



            Console.WriteLine("Вы ввели нечисловое значение");


            Console.WriteLine("Задание 5.3");
            bool fl = true;


            Console.WriteLine("Введите целое число");
            bool suc = Int32.TryParse(Console.ReadLine(), out int number);
            if (suc)
            {
                bool result = FindFactorial(number, out int factorial);
                if (result)
                {
                    Console.WriteLine(number + "!" + " = " + factorial);
                }
                else
                {
                    Console.WriteLine("Переполнение при вычислении  " + number + "!");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели нечисловое или нецелочисленное значение.");
            }



            Console.WriteLine("Задание 5.4");

            Console.WriteLine("Введите целое число");
            bool c = int.TryParse(Console.ReadLine(), out int fact);
            int znach = Factorial(fact);
            Console.WriteLine(fact + "!" + " = " + znach);

            Console.WriteLine("Задание 5.1");
            Console.WriteLine("Введите два числа для вычисления НОДа");
            bool ch1 = Int32.TryParse(Console.ReadLine(), out int x);
            bool ch2 = Int32.TryParse(Console.ReadLine(), out int y);
            bool ch3 = Int32.TryParse(Console.ReadLine(), out int u);
            Console.WriteLine("НОД чисел {0}, {1} = {2}", x, y, NOD(x, y));
            Console.WriteLine("НОД чисел {0}, {1}, {2}= {3}", x, y, u, NOD(NOD(x, y), u));

            Console.WriteLine("Задание 5.2");
            Console.WriteLine("Введите номер числа ряда Фибоначчи");
            int numf = int.Parse(Console.ReadLine());
            int itog = Fibonacci(numf);
            Console.WriteLine("Значение " + numf + " числа ряда Фибоначчи: " + itog);



            Console.ReadKey();















        }
    }
}
