using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace dz_4_
{
    internal class Program
    {
        enum GrumpinessLevel
        {
            Low,
            Medium,
            High
        }

        struct Grandpa
        {
            public string Name;
            public GrumpinessLevel Level;
            public string[] GrumpyPhrases;
            public int Bruises;

            public Grandpa(string name, GrumpinessLevel level, string[] grumpyPhrases)
            {
                Name = name;
                Level = level;
                GrumpyPhrases = grumpyPhrases;
                Bruises = 0;
            }

            public int CountBruises(params string[] swearWords)
            {
                int count = 0;

                foreach (string word in swearWords)
                {
                    foreach (string phrase in GrumpyPhrases)
                    {
                        if (phrase.Contains(word))
                        {
                            count++;
                            break;
                        }
                    }
                }

                Bruises += count;
                return count;
            }
        }
        static int Calculate(ref int product, out double srznc, params int[] numbers)
        {
            int sum = 0;
            product = 1;
            srznc = 0;
            foreach (int number in numbers)
            {
                sum += number;
                product *= number;
            }
            srznc = (double)sum / numbers.Length;
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            int[] numbers = new int[20];
            Random rm = new Random();
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rm.Next(1, 1000);


                Console.WriteLine(numbers[i] + " ");
            }
            Console.WriteLine("Введите индекс первого числа");
            bool fl = int.TryParse(Console.ReadLine(), out int index1);
            Console.WriteLine("Введите индекс второго числа");
            bool fl1 = int.TryParse(Console.ReadLine(), out int index2);
            if (index1 < 0 || index1 > numbers.Length || index2 < 0 || index2 > numbers.Length)
            {
                Console.WriteLine("Вы ввели значение находящееся вне интервала от 0 до 20");

            }
            else
            {
                int temp;
                temp = numbers[index1];
                numbers[index1] = numbers[index2];
                numbers[index2] = temp;
                Console.WriteLine("Итоговый массив");
                for (int i = 0; i < numbers.Length; i++)
                {


                    Console.WriteLine(numbers[i] + "");
                }


            }
            Console.WriteLine("Задание 2");


            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите число от 0 до 9");
            bool fl2 = int.TryParse(Console.ReadLine(), out int num);
            if (num < 0 || num > 9)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка!");
                Thread.Sleep(3000);
                Console.ForegroundColor = ConsoleColor.Black;

            }
            else
            {
                Console.WriteLine();
                if (num == 0)
                {
                    Console.WriteLine(" ### ");
                    Console.WriteLine(" # # ");
                    Console.WriteLine(" # # ");
                    Console.WriteLine(" ### ");
                }
                if (num == 1)
                {
                    Console.WriteLine("  #  ");
                    Console.WriteLine(" ##  ");
                    Console.WriteLine("  #  ");
                    Console.WriteLine(" ### ");
                }
                if (num == 2)
                {
                    Console.WriteLine("  ### ");
                    Console.WriteLine(" #  # ");
                    Console.WriteLine("   #  ");
                    Console.WriteLine("  ### ");
                }
                if (num == 3)
                {
                    Console.WriteLine(" ### ");
                    Console.WriteLine(" #   ");
                    Console.WriteLine(" ###  ");
                    Console.WriteLine(" #   ");
                    Console.WriteLine(" ### ");
                }
                if (num == 4)
                {
                    Console.WriteLine(" # # ");
                    Console.WriteLine(" ### ");
                    Console.WriteLine("   # ");
                    Console.WriteLine("   # ");
                }
                if (num == 5)
                {
                    Console.WriteLine(" ### ");
                    Console.WriteLine(" #   ");
                    Console.WriteLine(" ### ");
                    Console.WriteLine("   # ");
                    Console.WriteLine(" ### ");
                }
                if (num == 6)
                {
                    Console.WriteLine(" ### ");
                    Console.WriteLine(" #   ");
                    Console.WriteLine(" ### ");
                    Console.WriteLine(" # # ");
                    Console.WriteLine(" ### ");
                }
                if (num == 7)
                {
                    Console.WriteLine(" ### ");
                    Console.WriteLine("   # ");
                    Console.WriteLine("   # ");
                    Console.WriteLine("   # ");
                }
                if (num == 8)
                {
                    Console.WriteLine(" ### ");
                    Console.WriteLine(" # # ");
                    Console.WriteLine(" ### ");
                    Console.WriteLine(" # # ");
                    Console.WriteLine(" ### ");
                }
                if (num == 9)
                {
                    Console.WriteLine(" ### ");
                    Console.WriteLine(" # # ");
                    Console.WriteLine(" ### ");
                    Console.WriteLine("   # ");
                    Console.WriteLine(" ### ");
                }

            }
            Console.WriteLine("Задание 4");
            Grandpa grandpa1 = new Grandpa("Денис", GrumpinessLevel.Low, new string[] { "Черт", "Дурак", "Простофиля",  });
            Grandpa grandpa2 = new Grandpa("Леша", GrumpinessLevel.Medium, new string[] { "Черт", "Лентяй" });
            Grandpa grandpa3 = new Grandpa("Игорь", GrumpinessLevel.High, new string[] { "Дурак", "Глупец", "Дура", "Хобяка", "Чудак!", "Насупа"  });
            Grandpa grandpa4 = new Grandpa("Саша", GrumpinessLevel.Medium, new string[] { "Черт веревочный", "Туес", "Пресноплюй", "Насупа", "Ендовочник" });
            Grandpa grandpa5 = new Grandpa("Герман", GrumpinessLevel.Low, new string[] { "Лентяй" });

            List<Grandpa> grandpas = new List<Grandpa> { grandpa1, grandpa2, grandpa3, grandpa4, grandpa5 };

            List<string> swearWords = new List<string> { "Черт", "Чудак", "Дура", "Дурак", "Простофиля", "Лентяй", "Глупец", "Хобяка", "Туес", "Пресноплюй", "Насупа", "Ендовочник" };

            foreach (Grandpa grandpa in grandpas)
            {
                int bruises = grandpa.CountBruises(swearWords.ToArray());
                Console.WriteLine($"{grandpa.Name} получил {bruises} фингал.");
            }





            Console.ReadKey();
        }

    }
}
    

