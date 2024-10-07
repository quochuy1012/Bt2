using System;
using System.Collections.Generic;
using System.Linq;

namespace Bt2
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Tao danh sach hoc sinh
            List<Student> students = new List<Student>()
            {
                new Student { Id = 1, Name = "An", Age = 16 },
                new Student { Id = 2, Name = "Binh", Age = 17 },
                new Student { Id = 3, Name = "Anh", Age = 15 },
                new Student { Id = 4, Name = "Cuong", Age = 19 },
                new Student { Id = 5, Name = "Dung", Age = 18 }
            };

            // Menu lua chon
            int choice;
            do
            {
                // Hien thi menu
                Console.WriteLine("*----------------------------------------------------*");
                Console.WriteLine("|                    MENU LUA CHON                   |");
                Console.WriteLine("*----------------------------------------------------*");
                Console.WriteLine("| 1. In danh sach toan bo hoc sinh                   |");
                Console.WriteLine("| 2. Tim hoc sinh co tuoi tu 15 den 18               |");
                Console.WriteLine("| 3. Tim hoc sinh co ten bat dau bang chu 'A'        |");
                Console.WriteLine("| 4. Tinh tong tuoi cua tat ca hoc sinh              |");
                Console.WriteLine("| 5. Tim hoc sinh co tuoi lon nhat                   |");
                Console.WriteLine("| 6. Sap xep danh sach hoc sinh theo tuoi tang dan   |");
                Console.WriteLine("| 0. Thoat chuong trinh                              |");
                Console.WriteLine("**----------------------------------------------------*");
                Console.Write("Chon mot muc (0-6): ");

                // Doc lua chon tu nguoi dung
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine(); // Xuong dong cho dep

                switch (choice)
                {
                    case 1:
                        // In danh sach toan bo hoc sinh
                        Console.WriteLine("Danh sach toan bo hoc sinh:");
                        foreach (var student in students)
                        {
                            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
                        }
                        break;

                    case 2:
                        // Tim hoc sinh co tuoi tu 15 den 18
                        var age15to18 = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
                        Console.WriteLine("Hoc sinh co tuoi tu 15 den 18:");
                        foreach (var student in age15to18)
                        {
                            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
                        }
                        break;

                    case 3:
                        // Tim hoc sinh co ten bat dau bang chu 'A'
                        var nameStartsWithA = students.Where(s => s.Name.StartsWith("A")).ToList();
                        Console.WriteLine("Hoc sinh co ten bat dau bang chu 'A':");
                        foreach (var student in nameStartsWithA)
                        {
                            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
                        }
                        break;

                    case 4:
                        // Tinh tong tuoi cua tat ca hoc sinh
                        var totalAge = students.Sum(s => s.Age);
                        Console.WriteLine($"Tong tuoi cua tat ca hoc sinh: {totalAge}");
                        break;

                    case 5:
                        // Tim hoc sinh co tuoi lon nhat
                        var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
                        Console.WriteLine($"Hoc sinh co tuoi lon nhat: ID: {oldestStudent.Id}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");
                        break;

                    case 6:
                        // Sap xep danh sach hoc sinh theo tuoi tang dan
                        var sortedByAge = students.OrderBy(s => s.Age).ToList();
                        Console.WriteLine("Danh sach hoc sinh sau khi sap xep theo tuoi tang dan:");
                        foreach (var student in sortedByAge)
                        {
                            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
                        }
                        break;

                    case 0:
                        // Thoat chuong trinh
                        Console.WriteLine("Thoat chuong trinh.");
                        break;

                    default:
                        // Lua chon khong hop le
                        Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                        break;
                }
            } while (choice != 0);
            Console.ReadKey();
        }
    }
}
