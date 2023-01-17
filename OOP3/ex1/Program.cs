using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
namespace Lab01_Bai_so_1
{
    class Student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;
        public Student() 
        {
            SID = 1;
            TenSV = "Nguyen Van Nam";
            Khoa = "CNTT";
            DiemTB = 7;
        }
        public Student(Student stu) 
        {
            SID = stu.SID;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }
        public Student(int id, string ten, string kh, float dtb)
        {
            SID = id;
            TenSV = ten;
            Khoa = kh;
            DiemTB = dtb;
        }
        public int StudentID 
        {
            get { return SID; } 
            set { SID = value; } 
        }
        public String Name
        {
            get { return TenSV; }
            set { TenSV = value; }
        }
        public String Faculty
        {
            get { return Khoa; }
            set { Khoa = value; }
        }
        public float Mark
        {
            get { return DiemTB; }
            set { DiemTB = value; }
        }
        public void Show()
        {
            Console.WriteLine("MSSV:{0}", this.SID);
            Console.WriteLine("Ten SV:{0}", this.TenSV);
            Console.WriteLine("Khoa SV:{0}", this.Khoa);
            Console.WriteLine("Diem TB SV:{0}", this.DiemTB);
            
        }
    }
    class Tester
    {
        public static void Main()
        {
            Student[] DSSV;
            int n;
            Console.Write("==========**Chuong trinh quan ly sinh vien**==========\n");
            Console.Write("Nhap so luong sinh vien:");
            n = int.Parse(Console.ReadLine());
            DSSV = new Student[n]; 
            Console.WriteLine("\n ==========**Nhap danh sach sinh vien**==========");
            for (int i = 0; i < n; i++) 
            {
                DSSV[i] = new Student();
                Console.WriteLine("\n ==========Sinh vien thu {0}==========",i+1);
                Console.Write("Nhap MaSV {0}:", i + 1);
                DSSV[i].StudentID = int.Parse(Console.ReadLine());
                Console.Write("Ho ten SV:");
                DSSV[i].Name = Console.ReadLine();
                Console.Write("Nhap khoa:");
                DSSV[i].Faculty = Console.ReadLine();
                Console.Write("Nhap Diem TB:");
                DSSV[i].Mark = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n ==========**Xuat danh sach sinh vien**==========");
            foreach (Student sv in DSSV)
            {
                Console.WriteLine("\n=======Sinh vien co ma ID ={0}============",sv.StudentID);
                sv.Show();
            }
            Console.ReadLine();
        }
    }
}