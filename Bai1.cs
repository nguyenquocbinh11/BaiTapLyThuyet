﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLyThuyet
{
    public class Bai1
    {
        public void information()
        {
            string name; int age; double salary;

            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter salary: ");
            salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your Information: ");
            Console.Write("name: {0}, age: {1}, salary: {2}", name, age, salary);
            Console.Read();
        }

       
    }
}
