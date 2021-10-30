using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;

            Patient p1 = new Patient("Alex", "Mitchel", 21, "critical");
            Patient p2 = new Patient("Kate", "Pupsvel", 18, "critical");
            Patient p3 = new Patient("Georgy", "Robbinson", 42, "normal");
            Patient p4 = new Patient("LG", "Company", 120, "normal");
            Patient p5 = new Patient("Mikky", "Mouse", 30, "critical");

            var list = new List<Patient>() { p1, p2, p3, p4, p5 };

            while (flag != true)
            {
                Console.WriteLine();
                Console.WriteLine("1 - Все пациенты critical/normal\n" +
                    "2 - Поиск пациентов по возрасту less/more\n" +
                    "3 - Поиск по имени\n" +
                    "4 - Поиск по фамилии\n" +
                    "5 - Закончить поиск");
                Console.Write("Выберите дальнейшее действие:");
                string a = Console.ReadLine();
                switch (a)
                {
                    case "1":                        
                        Patient.SearchByStatus(list);
                        break;
                    case "2":                        
                        Patient.SearchByAge(list);
                        break;
                    case "3":                                               
                        Patient.SearchByName(list);
                        break;
                    case "4":                        
                        Patient.SearchBySurname(list);
                        break;
                    case "5":
                        flag = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Выберете вариант действия");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }

            }
        }
    }
}
