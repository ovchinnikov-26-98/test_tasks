using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task_2
{
    class Patient
    {
        private string name;
        private string surname;
        private int age;
        private string status;

        /// <summary>
        /// Свойства
        /// </summary>
        public string Name { get { return this.name; } set { this.name = value; } }
        public string Surname { get { return this.surname; } set { this.surname = value; } }
        public int Age { get { return this.age; } set { this.age = value; } }
        public string Status { get { return this.status; } set { this.status = value; } }

        /// <summary>
        /// Конструктор 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="status"></param>
        public Patient(string name, string surname, int age, string status)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.status = status;
        }


        /// <summary>
        /// Метод поиска по фамилии
        /// </summary>
        /// <param name="Lastname"></param>
        /// <param name="list"></param>
        public static void SearchBySurname(List<Patient> list)
        {
            Console.WriteLine("Введите имя фамилию");
            string lastname = Console.ReadLine().ToUpper();
            var resultat = list.Where(e => e.Surname.ToUpper().Equals(lastname));
            if (resultat.Count() != 0)
            {
                foreach (var item in resultat)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Пациент : {item.Name} {item.Surname}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Нет такого пациента");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        /// <summary>
        /// Метод поиска по имени
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="list"></param>
        public static void SearchByName(List<Patient> list)
        {
            Console.WriteLine("Введите имя пациента");
            string name = Console.ReadLine().ToUpper();
            var resultat = list.Where(e => e.Name.ToUpper().Equals(name));
            if (resultat.Count() != 0)
            {
                foreach (var item in resultat)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Пациент : {item.Name} {item.Surname}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Нет такого пациента");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public static void SearchByAge(List<Patient> list)
        {
            Console.WriteLine("1 - less\n" +
                            "2 - more");
            Console.Write("Выберите дальнейшее действие:");
            string w = Console.ReadLine();
            bool prov = false;
            int b = 1;
            if (w == "1")
            {
                Console.WriteLine("Введите возраст");
                while (prov != true)
                {
                    prov = int.TryParse(Console.ReadLine(), out b);
                    if (prov == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Некорректный ввод. Должно быть число!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                var result = list.Where(e => e.Age <= b);
                foreach (var item in result)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Пациент : {item.Name} {item.Surname}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else if (w == "2")
            {
                Console.WriteLine("Введите возраст");
                while (prov != true)
                {
                    prov = int.TryParse(Console.ReadLine(), out b);
                    if (prov == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Некорректный ввод. Должно быть число!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                var results = list.Where(e => e.Age >= b);
                foreach (var item in results)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Пациент : {item.Name} {item.Surname}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        public static void SearchByStatus(List<Patient> list)
        {
            Console.WriteLine("1 - critical\n" +
                            "2 - normal");
            Console.Write("Выберите дальнейшее действие:");
            string w = Console.ReadLine();
            if (w == "1")
            {
                var res = list.Where(e => e.Status.Equals("critical"));
                foreach (var item in res)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Пациент : {item.Name} {item.Surname}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else if (w == "2")
            {
                var ress = list.Where(e => e.Status.Equals("normal"));
                foreach (var item in ress)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Пациент : {item.Name} {item.Surname}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
