using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var listKhuDat = InputListKhuDat();
            outputListKhuDat(listKhuDat);
            //
            System.Console.WriteLine("\n=>Xuat ra khu dat dt tang dan");
            List<KhuDat> listKhuDatDienTichTangDan = listKhuDat.OrderBy(p => p.DienTich).ToList();
            outputListKhuDat(listKhuDatDienTichTangDan);
            //
            System.Console.WriteLine("\n=>xuat ra khu dat co gia ban giao dong");
            List<KhuDat> listKhuDatTrongKhoang = listKhuDat.Where(p => p.GiaBan <= Math.Pow(10,9) || p.DienTich>=60).ToList();
            if (listKhuDatTrongKhoang.Count == 0)
            {
                System.Console.WriteLine("khong co khu dat thoa yeu cau");
            }
            else
            {
                outputListKhuDat(listKhuDatTrongKhoang);
            }
        }
        private static List<KhuDat> InputListKhuDat()
        {
            System.Console.WriteLine("Nhap tong so dat ");
            int N = Convert.ToInt32(Console.ReadLine());
            List<KhuDat> listKhuDat = new List<KhuDat>();
            System.Console.WriteLine("\n ===Nhap danh sach dat===");
            for (int i = 0; i < N; i++)
            {
                System.Console.WriteLine("\n - Nhap khu dat thu {0}", i + 1);
                KhuDat temp = new KhuDat();
                temp.Input();
                listKhuDat.Add(temp);
            }
            return listKhuDat;
        }
        private static void outputListKhuDat(List<KhuDat> list)
        {
            Console.WriteLine("\n ===Xuat Danh Sach dat===");
            foreach (KhuDat kd in list)
            {
                kd.Show();
            }
        }
    }
}
