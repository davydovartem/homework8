using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8_task3
{
    class Program
    {
        static void Main()
        {
            var set = new HashSet<int>();
            while (true)
            {
                Console.Write("\nВведите число: ");
                int number = GetIntegerFromConsole();
                if (TryToAdd(set,number))
                {
                    Console.WriteLine("Число добавлено. (Escape - выход)");
                }
                else
                {
                    Console.WriteLine("Число не добавлено, такое число уже есть в множестве:");
                    PrintSet(set);
                    Console.WriteLine("Нажмите Escape чтобы выйти.");
                }
                if (Console.ReadKey().Key == ConsoleKey.Escape) break;
            }

        }
        private static void PrintSet(HashSet<int> set)
        {
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
        private static bool TryToAdd(HashSet<int> set, int value)
        {
            return set.Add(value);
        }
        public static int GetIntegerFromConsole()
        {
            int consoleInt;
            while (!int.TryParse(Console.ReadLine(), out consoleInt))
                Console.WriteLine("Некорректный ввод, введите целое число!");
            return consoleInt;
        }

    }
}
