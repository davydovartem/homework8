using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = FillPhoneBook();
            Console.WriteLine("Введите номер телефона искомого человека: ");
            string name = FindByName(dict, Console.ReadLine(), out bool found);
            Console.WriteLine(found? "Его имя: " + name : "Человек с таким номером не найден." );
            Console.ReadKey();
        }
        private static Dictionary<string, string> FillPhoneBook()
        {
            var dict = new Dictionary<string, string>();
            while (true)
            {
                Console.Write("\nВведите имя: ");
                string name = Console.ReadLine();
                if (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name)) break;
                Console.Write("\nВведите номер телефона: ");
                string number = Console.ReadLine();
                if (String.IsNullOrEmpty(number) || String.IsNullOrWhiteSpace(number)) break;
                dict.Add(number, name);
            }
            Console.WriteLine();
            return dict;
        }
        private static string FindByName(Dictionary<string, string> dict, string phoneNumber, out bool found)
        {
            found = dict.TryGetValue(phoneNumber, out string name);
            return name;
        }
    }
}
