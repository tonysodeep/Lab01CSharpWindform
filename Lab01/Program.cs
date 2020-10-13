using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listStudent = inputListStudent();
            outputListStudent(listStudent);
            Console.ReadKey();
            //1.1
            System.Console.WriteLine("\n=>Xuat ra sinh vien cntt");
            List<Student> listStudentCNTT = listStudent.Where(p => p.Faculty == "CNTT").ToList();
            if (listStudent.Count == 0)
            {
                System.Console.WriteLine("Khong co sinh vien CNTT");
            }
            else
            {
                outputListStudent(listStudentCNTT);
            }
            //1.2
            System.Console.WriteLine("\n=>xuat ra sv diem tb >= 5");
            List<Student> listStudentTB = listStudent.Where(p => p.AverageScore >= 5).ToList();
            if (listStudentTB.Count == 0)
            {
                System.Console.WriteLine("khong co sv thap hon 5");
            }
            else
            {
                outputListStudent(listStudentTB);
            }
            //1.3
            System.Console.WriteLine("\n=>Xuat ra sv diem tb tang dan");
            List<Student> listStudentTBTangDan = listStudent.OrderBy(p => p.AverageScore).ToList();
            outputListStudent(listStudentTBTangDan);
            //1.4
            System.Console.WriteLine("\n=>xuat ra sv co diem lon hon 5 vs khoa cntt");
            List<Student> listStudentCNTTTB5 = listStudent.Where(p => p.Faculty == "CNTT" && p.AverageScore >= 5).ToList();
            if (listStudentCNTTTB5.Count == 0)
            {
                System.Console.WriteLine("khong co sv cntt thap hon 5");
            }
            else
            {
                outputListStudent(listStudentCNTTTB5);
            }
            //1.5
            System.Console.WriteLine("\n=>Xuat ra ds sv cntt diem cao nhat");
            var maxScroe = listStudent.Max(p => p.AverageScore);
            var listStudentCNTTMax = listStudent.Where(p => p.Faculty == "CNTT" && p.AverageScore == maxScroe).ToList();
            outputListStudent(listStudentCNTTMax);
        }
        private static List<Student> inputListStudent()
        {
            System.Console.WriteLine("Nahp tong so sinh vien N = ");
            int N = Convert.ToInt32(Console.ReadLine());
            List<Student> listStudent = new List<Student>();
            System.Console.WriteLine("\n ===Nhap danh sach sinh vien===");
            for (int i = 0; i < N; i++)
            {
                System.Console.WriteLine("\n - Nhap sinh vien thu {0}", i + 1);
                Student temp = new Student();
                temp.Input();
                listStudent.Add(temp);
            }
            return listStudent;
        }
        private static void outputListStudent(List<Student> list)
        {
            Console.WriteLine("\n ===Xuat Danh Sach sinh vien===");
            foreach (Student sv in list)
            {
                sv.Show();
            }
        }
    }
}
