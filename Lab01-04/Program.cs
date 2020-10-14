using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab01_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var listDiaOcD = inputListDiaOc();
            outputListDiaOcD(listDiaOcD);
            tongGia(listDiaOcD);
            listTheoYeuCau(listDiaOcD);
        }
        private static List<DiaOcD> inputListDiaOc()
        {
            System.Console.WriteLine("Nhap tong so dia oc D ");
            int N = Convert.ToInt32(Console.ReadLine());
            List<DiaOcD> listDiaOcD = new List<DiaOcD>();
            System.Console.WriteLine("\n ===Nhap danh sach dia oc D===");
            for (int i = 0; i < N; i++)
            {
                System.Console.WriteLine("\n - 1.Khu dat 2. Nha Pho 3.Chung Cu \nNhap dia oc {0}", i + 1);
                int choice = Convert.ToInt32(Console.ReadLine());
                DiaOcD dia;
                switch (choice)
                {
                    case 1:
                        dia = new KhuDat();
                        dia.Input();
                        listDiaOcD.Add(dia);
                        break;
                    case 2:
                        dia = new NhaPho();
                        dia.Input();
                        listDiaOcD.Add(dia);
                        break;
                    case 3:
                        dia = new ChungCu();
                        dia.Input();
                        listDiaOcD.Add(dia);
                        break;
                    default:
                        System.Console.WriteLine("ko hieu");
                        break;
                }
            }
            return listDiaOcD;
        }
        private static void outputListDiaOcD(List<DiaOcD> listDiaOcD)
        {
            System.Console.WriteLine("\nDanh Sach Dia Oc Yeu Cau");
            foreach (DiaOcD dia in listDiaOcD)
            {
                dia.Show();
            }
        }
        private static void tongGia(List<DiaOcD> listDiaOcD)
        {
            double sumKD = 0.0, sumNP = 0.0, sumCC = 0.0;
            foreach (DiaOcD dia in listDiaOcD)
            {
                if (dia.Kind() == 1)
                {
                    sumKD += dia.GiaBan;
                }
                if (dia.Kind() == 2)
                {
                    sumNP += dia.GiaBan;
                }
                if (dia.Kind() == 3)
                {
                    sumCC += dia.GiaBan;
                }
            }
            System.Console.WriteLine("\ntong gia ban khu dat: {0}\ntong gia ban nha pho: {1}\ntong gia ban chung cu: {2}", sumKD, sumNP, sumCC);
        }
        private static void listTheoYeuCau(List<DiaOcD> listDiaOcD)
        {
            List<DiaOcD> listDiaOcTheoYeuCau = listDiaOcD.Where(p => p.DienTich > 100 || (p.Kind() == 2 && ((NhaPho)p).Nam >=2020 && p.DienTich > 60)).ToList();
            if(listDiaOcTheoYeuCau.Count() == 0){
                System.Console.WriteLine("Khong co cai nao theo yeu cau");
            }else{
                outputListDiaOcD(listDiaOcTheoYeuCau);
            }
        }

    }
}
