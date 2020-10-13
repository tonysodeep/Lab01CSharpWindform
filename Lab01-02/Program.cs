using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var listPerson = inputListPerson();
            outputListPerson(listPerson);
            listSinhVienCNTT(listPerson);
            listSinhVienCNTTScore(listPerson);
            listTeacherQuan9(listPerson);
            if (findGVID(listPerson) == 0)
            {
                System.Console.WriteLine("Can not found");
            }
            else
            {
                listPerson[findGVID(listPerson)].Show();
            }
            listStudentCNTTMax(listPerson);
        }
        private static List<Person> inputListPerson()
        {
            System.Console.WriteLine("Nhap tong so nguoi = ");
            int N = Convert.ToInt32(Console.ReadLine());
            List<Person> listPerson = new List<Person>();
            System.Console.WriteLine("\n ===Nhap danh sach nguoi===");
            for (int i = 0; i < N; i++)
            {
                System.Console.WriteLine("\n - 1.Sinh Vien 2. Giao vien \nNhap nguoi thu {0}", i + 1);
                int choice = Convert.ToInt32(Console.ReadLine());
                Person person;
                switch (choice)
                {
                    case 1:
                        person = new Student();
                        person.Input();
                        listPerson.Add(person);
                        break;
                    case 2:
                        person = new Teacher();
                        person.Input();
                        listPerson.Add(person);
                        break;
                    default:
                        System.Console.WriteLine("ko hieu");
                        break;
                }
            }
            return listPerson;
        }
        private static void outputListPerson(List<Person> listPerson)
        {
            System.Console.WriteLine("\nDanh Sach so nguoi yeu cau");
            foreach (Person person in listPerson)
            {
                person.Show();
            }
        }
        private static void listSinhVienCNTT(List<Person> listPerson)
        {
            System.Console.WriteLine("\nDanh sach Sinh vien hoc CNTT");
            foreach (Person person in listPerson)
            {
                if (person.Kind() == 1 && ((Student)person).Faculty == "CNTT")
                {
                    person.Show();
                }
                else
                {
                    System.Console.WriteLine("Empty List");
                }
            }
        }
        private static void listSinhVienCNTTScore(List<Person> listPerson)
        {
            System.Console.WriteLine("\nDanh sach Sinh vien hoc CNTT diem tb nho hon 5");
            foreach (Person person in listPerson)
            {
                if (person.Kind() == 1 && ((Student)person).Faculty == "CNTT" && ((Student)person).AverageScore < 5)
                {
                    person.Show();
                }
                else
                {
                    System.Console.WriteLine("Empty List");
                }
            }
        }
        private static void listTeacherQuan9(List<Person> listPerson)
        {
            System.Console.WriteLine("\nDanh sach Giao vien Quan 9: ");
            foreach (Person person in listPerson)
            {
                if (person.Kind() == 2 && ((Teacher)person).Address == "Quan 9")
                {
                    person.Show();
                }
                else
                {
                    System.Console.WriteLine("Empty List");
                }
            }
        }
        private static int findGVID(List<Person> listPerson)
        {
            for (int i = 0; i < listPerson.Count; i++)
            {
                if (listPerson[i].Kind() == 2 && listPerson[i].PersonID == "CHN060286")
                {
                    return i;
                }
            }
            return 0;
        }
        private static void listStudentCNTTMax(List<Person> listPerson)
        {
            System.Console.WriteLine("\n=>Xuat ra ds sv cntt diem cao nhat");
            float maxScore = float.MinValue;
            foreach (Person person in listPerson)
            {
                if (person.Kind() == 1 && ((Student)person).AverageScore > maxScore)
                {
                    maxScore = ((Student)person).AverageScore;
                }
            }
            foreach (Person person1 in listPerson)
            {
                if (person1.Kind() == 1 && ((Student)person1).AverageScore == maxScore)
                {
                    person1.Show();
                }
            }
        }
    }
}
