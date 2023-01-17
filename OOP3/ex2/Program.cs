using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
namespace Lab01_Bai_so_2
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
        public int getSID()
        {
            return this.SID;
        }
        public void setSID(int id)
        {
            this.SID = id;
        }
        public string getTenSV()
        {
            return this.TenSV;
        }
        public void setTenSV(string tensv)
        {
            this.TenSV = tensv;
        }
        public string getKhoa()
        {
            return this.Khoa;
        }
        public void setKhoa(string khoa)
        {
            this.Khoa = khoa;
        }
        public float getDiemTB()
        {
            return this.DiemTB;
        }
        public void setDiemTB(float diem)
        {
            this.DiemTB = diem;
        }
        public void Nhap1SV()
        {

            Console.WriteLine("Nhap Ma sinh vien:");
            this.setSID(int.Parse(Console.ReadLine()));
            Console.WriteLine("Nhap Ten sinh vien:");
            this.setTenSV(Console.ReadLine());
            Console.WriteLine("Nhap Khoa sinh vien:");
            this.setKhoa(Console.ReadLine());
            Console.WriteLine("Nhap Diem TB sinh vien:");
            this.setDiemTB(float.Parse(Console.ReadLine()));
        }
        public void NhapDS(Student[] DSSV, int n)
        {
            Console.WriteLine("\n ==========**Nhap danh sach sinh vien**==========");
            for (int i = 0; i < n; i++)
            {
                DSSV[i] = new Student();
                Console.WriteLine("\n ========== Sinh vien thu {0}========== ", i + 1);
                DSSV[i].Nhap1SV();
            }
        }
        public void XuatDS(Student[] DSSV, int n)
        {
            Console.WriteLine("\n ==========**Xuat danh sach sinh vien**==========");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n=======Sinh vien thu ={0}============", i+1);
                DSSV[i].Show();
            }
            Console.ReadLine();
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
            Student student = new Student();
            student.NhapDS(DSSV, n);
            student.XuatDS(DSSV, n);
        }
    }
}