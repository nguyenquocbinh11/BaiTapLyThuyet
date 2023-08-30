using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLyThuyet
{
    public class Bai6_NhanVien : Bai6_Nguoi
    {
        private string bangcap;

        public Bai6_NhanVien(string maso, string hoten, string gioitinh) : base(maso, hoten, gioitinh)
        { this.bangcap = bangcap; }

        public sealed override void Input()
        {
            base.Input();
            Console.Write("Nhap bang cap: ");
            bangcap = Console.ReadLine();
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Bang cap: {0}", bangcap);
        }

        

    }
}
