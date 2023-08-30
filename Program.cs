using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLyThuyet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bai1 bai1 = new Bai1();
            //bai1.information();

            Bai2 bai2 = new Bai2();
            //bai2.ifelse();
            //bai2.switchcase();

            Bai3 bai3 = new Bai3();
            //bai3.while_loop();
            //bai3.do_while();
            //bai3.for_loop();
            //bai3.foreach_loop();
            //bai3.break_example();
            //bai3.continue_example();

            Bai4 bai4 = new Bai4();
            //bai4.array_example();

            Bai5 bai5 = new Bai5();
            //bai5.input();
            //bai5.display();

            Bai6_NhanVien bai6_NhanVien = new Bai6_NhanVien("", "", "");
            //bai6_NhanVien.Input();
            //bai6_NhanVien.Display();

            Bai8_Property  b = new Bai8_Property();
            //Console.Write("Tittle: " + b.TITTLE);
            //b.TITTLE = "Properties va Indexer trong c#";

            Bai8_Indexers bb = new Bai8_Indexers(0);
            //bb.run();

            

        }
    }
}
