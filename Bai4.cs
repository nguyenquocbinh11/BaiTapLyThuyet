using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLyThuyet
{
    public class Bai4
    {
        public void array_example()
        {
            Random rnd = new Random();
            int[] array = new int[10];
            int[] temp = array;
            Console.WriteLine("Vi du ve Mang: ");

            for(int i=0; i<array.GetLength(0); i++)
            {
                array[i] = rnd.Next(1, 20);
            }

            foreach(int i in temp)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Array.Sort(temp);
            Console.Write("Mang sau khi sap xep: ");
            foreach(int i in temp)
            {
                Console.Write(i + " ");
            }

            Console.Read();
        }
    }
}
