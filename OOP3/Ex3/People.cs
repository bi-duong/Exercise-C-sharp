using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap1_Bai_So_3_People
{
    internal abstract class People
    {
        private int SID;
        private string TenSV;
        private string Khoa;


        public int SID1 { get => SID; set => SID = value; }
        public string TenSV1 { get => TenSV; set => TenSV = value; }
        public string Khoa1 { get => Khoa; set => Khoa = value; }

        public People() 
        {
            SID = 1;
            TenSV = "Nguyen Van Nam";
            Khoa = "CNTT";

        }
        public People(People people) 
        {
            SID = people.SID;
            TenSV = people.TenSV;
            Khoa = people.Khoa;

        }public People(int id, string ten, string kh)
        {
            SID = id;
            TenSV = ten;
            Khoa = kh;

        }
        public virtual void Nhap1SV()
        {

            Console.WriteLine("Nhap Ma sinh vien:");
            this.SID1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Ten sinh vien:");
            this.TenSV1 = Console.ReadLine();
            Console.WriteLine("Nhap Khoa sinh vien:");
            this.Khoa1 = Console.ReadLine();
        }

        public virtual void Show()
        {
            Console.WriteLine("MSSV:{0}", this.SID);
            Console.WriteLine("Ten SV:{0}", this.TenSV);
            Console.WriteLine("Khoa SV:{0}", this.Khoa);
        }
    }
}