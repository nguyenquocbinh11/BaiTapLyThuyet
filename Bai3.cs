using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLyThuyet
{
    public class Bai3
    {
        public void while_loop()
        {
            int i = 1;

            Console.Write("Vi du vong lap While: ");
            while(i<=5)
            {
                Console.Write(i + " ");
                i++;
            }
            Console.Read();
        }

        public void do_while()
        {
            int n;
            Console.WriteLine("Vi du vong lap do while: ");
            do
            {
                Console.Write("Enter number: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n <= 0);
            Console.Write("Alright");
            Console.Read();
        }

        public  void for_loop()
        {
            Console.Write("Vi du vong lap for: ");
            for(int i=10; i>0; i--)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        }

        public void foreach_loop()
        {
            Console.WriteLine("Vi du vong lap foreach: ");
            int[] array = new int[10];
            Random rnd = new Random();

            for (int i=0; i<10; i++)
            {
                array[i] = rnd.Next(10);
            }

            Console.WriteLine("This is result: ");
            foreach(int i in array)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        }

        public void break_example()
        {
            Console.WriteLine("Vi du vong lap foreach: ");
            int[] array = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(1, 20);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\nThis is result: "  );
            
            foreach(int i in array)
            {
                if(i%2==0)
                {
                    break;
                }
                Console.Write(i + " ");
            }
            Console.Read();
        }

        public void continue_example()
        {
            Console.WriteLine("Vi du vong lap foreach: ");
            int[] array = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(1, 20);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\nThis is result: ");

            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
            Console.Read();
        }
    }
}
