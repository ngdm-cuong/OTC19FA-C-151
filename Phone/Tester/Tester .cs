﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project5
{
    class Tester
    {
        static void Main(string[] args)
        {
            Phone iPhone5 = new Phone("i5",
                "iPhone 5 16Gb, White",
                5, 40m, 50m);
            WriteLine(iPhone5);

            Phone samsungGS9 = new Phone("S9",
                "Samsung Galaxy S9 64GB, Black",
                4, 55m, 65m);
            WriteLine(samsungGS9);
            //ReadKey();

        }
    }
}
