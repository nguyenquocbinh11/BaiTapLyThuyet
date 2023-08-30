using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLyThuyet
{
    public class Bai2
    {
        public void ifelse()
        {
            float avgScore;
            Console.Write("Enter Average Score: ");
            avgScore = float.Parse(Console.ReadLine());

            if (avgScore < 5)
            {
                Console.Write("bellow");
            }
            else if (avgScore < 6.5)
            {
                Console.Write("Average");
            }
            else if (avgScore < 8)
            {
                Console.Write("Good");
            }

            else
                Console.Write("Excellent");
            Console.Read();
        }

        public void switchcase()
        {
            string capability;
            Console.Write("Enter Capability: ");
            capability = Console.ReadLine();

            switch(capability.ToUpper()) {
                case "A":
                    Console.Write("Android");
                    break;
                case "B":
                    Console.Write("Basic");
                    break;
                default:
                    Console.Write("none");
                    break;
            }
            Console.Read();
        }
    }
}
