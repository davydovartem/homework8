using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Homework8_task4
{
    class Program
    {
        static void Main()
        {
            XElement xPersons = new XElement("Persons");
            int i = 1;
            while (true)
            {
                Console.WriteLine($"Введите данные {i++} человека");
                Console.Write("\nВведите имя: ");
                string name = Console.ReadLine();
                if (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name)) break;
                Console.Write("\nВведите адрес.\n\tВведите город: ");
                string city = Console.ReadLine();
                if (String.IsNullOrEmpty(city) || String.IsNullOrWhiteSpace(city)) break;
                Console.Write("\n\tВведите улицу: ");
                string street = Console.ReadLine();
                if (String.IsNullOrEmpty(street) || String.IsNullOrWhiteSpace(street)) break;
                Console.Write("\n\tВведите номер дома: ");
                string house = Console.ReadLine();
                if (String.IsNullOrEmpty(house) || String.IsNullOrWhiteSpace(house)) break;
                Console.Write("\nВведите номер домашнего телефона: ");
                string numberHome = Console.ReadLine();
                if (String.IsNullOrEmpty(numberHome) || String.IsNullOrWhiteSpace(numberHome)) break;
                Console.Write("\nВведите номер мобильного телефона: ");
                string numberMobile = Console.ReadLine();
                if (String.IsNullOrEmpty(numberMobile) || String.IsNullOrWhiteSpace(numberMobile)) break;
                Console.WriteLine();
                //Создаем элементы-контейнеры
                XElement personElement = new XElement("Person", new XAttribute("Name", name));
                XElement addressElement = new XElement("Address");
                XElement phonesElement = new XElement("Phones");
                //Элементы-данные
                XElement cityElement = new XElement("City", city);
                XElement streetElement = new XElement("Street", street);
                XElement houseElement = new XElement("House", house);
                XElement homePhoneNumberElement = new XElement("HomePhoneNumber", numberHome);
                XElement mobileElement = new XElement("Mobile", numberMobile);
                //Заполняем контейнеры
                addressElement.Add(cityElement, streetElement, houseElement);
                phonesElement.Add(homePhoneNumberElement, mobileElement);
                personElement.Add(addressElement, phonesElement);
                xPersons.Add(personElement);
            }
            Console.WriteLine(xPersons);
            xPersons.Save(@"./Contacts.xml");
            Console.ReadKey();
        }
    }
}
