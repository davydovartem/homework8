using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8_task1
{
    class Program
    {
        static void Main()
        {
            int listLength = 100;
            int listValuesMax = 100;
            var list = MakeRandomIntsList(listLength, listValuesMax);

            Console.WriteLine($"Список случайных целых чисел от 0 до {listValuesMax}:");
            PrintList(list);
            Console.WriteLine($"Список после удаления {list.RemoveAll(Condition)} чисел, удовлетворяющих заданному условию:");
            PrintList(list);

            Console.ReadKey();
        }
        private static List<int> MakeRandomIntsList(int maxOfElements, int valuesMax)
        {
            Random random = new Random();
            var list = new List<int>();

            for (int i = 0; i < maxOfElements; i++)
            {
                list.Add(random.Next(0, valuesMax + 1));
            }

            return list;
        }
        static void PrintList(List<int> list)
        {
            foreach (var i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static bool Condition(int number)
        {
            return number > 25 && number < 50;
        }
    }
}
