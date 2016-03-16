using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vpAssgDate
{
    class DateCal
    {
        public void getDOB(int Sib, int[] dayArry, int[] monthArry, int[] YearArry)
        {
            for (int i = 0; i < Sib; i++)
            {
            retake:
                DateTime objDt = DateTime.Today;
                Console.WriteLine(objDt.Month);
                Console.Write("Please enter DOB of sibling " + (i + 1) + ": ");
                Console.ForegroundColor = System.ConsoleColor.White;
                String Date = Console.ReadLine();

                String[] ary = Date.Split('-');
                String strDay = ary[0];
                String strMnth = ary[1];
                String strYear = ary[2];

                int intDay = int.Parse(strDay);
                int intmnth = int.Parse(strMnth);
                int intyr = int.Parse(strYear);

                while (intDay < 1 || intDay > 31 || intmnth < 1 || intmnth > 12 || intyr < 1960 || intyr > 2015)
                {
                    Console.ForegroundColor = System.ConsoleColor.Red;
                    Console.Write("Please enter valid values\n");
                    Console.ForegroundColor = System.ConsoleColor.White;
                    goto retake;
                }

                DateTime dat = new DateTime(intyr, intmnth, intDay);

                //DateTime objDt = DateTime.Today;
                TimeSpan rs = objDt - dat;
               
                int rsw = rs.Days;


                int yrss = rsw / 365;
                int Leapyrs = yrss / 4;
                //Console.WriteLine("years: "+yrss);

                int remaindays = rsw % 365;
                remaindays = remaindays - Leapyrs;
                ////Console.WriteLine(remaindays);

                int monthss = remaindays / 30;
                //Console.WriteLine("months: " + monthss);

                int dayss = remaindays % 30;
                //Console.WriteLine("days: " + dayss);

                dayArry[i] = dayss;
                monthArry[i] = monthss;
                YearArry[i] = yrss;

            }//End For

        }

        public void DisplayAge(int Sib, int[] dayArry, int[] monthArry, int[] YearArry)
        {
            for (int i = 0; i < Sib; i++)
            {
                Console.WriteLine("Age of sibling " + (i + 1) + " is: {0} years, {1} months, {2} days", YearArry[i], monthArry[i], dayArry[i]);
            }
        }

        public void DisplayDifference(int Sib, int[] dayArry, int[] monthArry, int[] YearArry)
        {
            int compareDay, compareMnth, compareYrs;
            for (int i = 0; i < Sib; i++)
            {
                if ((i + 1) < dayArry.Length || (i + 1) < monthArry.Length || (i + 1) < YearArry.Length)
                {
                    compareDay = (dayArry[i + 1] - dayArry[i]);
                    compareMnth = (monthArry[i + 1] - monthArry[i]);
                    compareYrs = (YearArry[i + 1] - YearArry[i]);

                    if (compareDay < 1)
                    {
                        compareDay += compareDay * (-2);
                    }
                    else if (compareMnth < 1)
                    {
                        compareMnth += compareMnth * (-2);
                    }
                    else if (compareYrs < 1)
                    {
                        compareYrs += compareYrs * (-2);
                    }


                    Console.WriteLine("Difference between Sibling " + (i + 1) + " and " + (i + 2) + " is {0} years,{1} months,{2} days", compareYrs, compareMnth, compareDay);
                }

            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DateCal CalObj = new DateCal();

            Console.ForegroundColor = System.ConsoleColor.Green;

            Console.WriteLine("||=========================================||");
            Console.WriteLine("||             AGE CALCULATOR              ||");
            Console.WriteLine("||=========================================||\n");

            Console.ForegroundColor = System.ConsoleColor.White;

            Console.Write("Please enter the number of siblings: ");
            int Sib = int.Parse(Console.ReadLine());

            Console.WriteLine("\n<===DOBs should be in dd-mm-yyyy format===>");
            
            int[] dayArry = new int[Sib];
            int[] monthArry = new int[Sib];
            int[] YearArry = new int[Sib];

            CalObj.getDOB(Sib, dayArry, monthArry, YearArry);
            
            Console.WriteLine();

            CalObj.DisplayAge(Sib, dayArry, monthArry, YearArry);

            Console.WriteLine();

            CalObj.DisplayDifference(Sib, dayArry, monthArry, YearArry);
           
            Console.ReadKey();
        }//End Mian
    }
}
