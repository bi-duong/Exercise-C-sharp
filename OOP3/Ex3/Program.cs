using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Lap1_Bai_So_3_ListPeople;
namespace Lap1_Bai_So_3_Tester
{
    internal class Tester
    {
        public static void Main()
        {
            ArrayList arrayList = new ArrayList();
            ListPeople list = new ListPeople();
            int n;
            Console.Write("==========**Chuong trinh quan ly sinh vien**==========\n");
            Console.Write("Nhap so luong sinh vien:");
            n = int.Parse(Console.ReadLine());
            list.NhapDS(arrayList, n);
            list.XuatDS(arrayList, n);
        }
    }
}
