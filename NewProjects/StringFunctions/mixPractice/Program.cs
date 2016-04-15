using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mixPractice
{
    class student
    {
        int nn = 4;
        //int no1,no2;
        public void returnByRef(ref int no1,ref int no2)
        {
            if (no1 > 3)
            {
                no1 = no1 + 1;
                
            }
            else
                no1 = no1 - 1; ;
        }
        public static explicit operator int(object obj)
        {
           //s
            
        }
        public void ParametrizdArray(params int[] a)
        {
            foreach (int item in a)
            {
                Console.WriteLine(item);
            }
        }
       
    }

    class Program
    {
        public static void Main()
        {
            int v1 = 4;
	        int v2 = 5;
	        int v3 = 6;
                
            
            student std = new student();
            std.returnByRef(ref v1,ref v2);
            Console.WriteLine(v1);

            //int[] AR = { 1, 2, 3, 4, 5, 6, 7, 8 };

            std.ParametrizdArray(1, 2, 3, 4, 5, 6, 7, 8);
            

            byte b = 255;
            unchecked
            {
                b++;

            }
            Console.WriteLine(b);

            
            Console.ReadKey();
        }
    }

    
}