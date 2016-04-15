using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class practice
    {
        public int factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }


        public string[] StringCombinations(string str, int strings)
        {
            char[] chAry = str.ToCharArray();
            string[] strAry=new string[strings];
            int length2=(chAry.Length-1)*2;
            int maxLngth = (chAry.Length)-1;
            

            for (int i = 0; i < str.Length; i++)
            {
                if (i != 0 || chAry[i+1]!='\0')
                {
                    char tempr = chAry[i];
                    chAry[i] = chAry[i + 1];
                    chAry[i + 1] = tempr;
                }
                for (int j = 0; j <length2 ; j++)
                {
                    if (maxLngth != 1)
                    {
                        char temp = chAry[maxLngth];
                        chAry[maxLngth] = chAry[maxLngth - 1];
                        chAry[maxLngth - 1] = temp;
                        maxLngth--;
                    }
                    else
                        maxLngth = (str.Length)-1;
                    string name = null;
                    for (int e = 0; e < chAry.Length; e++)
                    {
                        if (chAry[e] != '\0')
                        {
                            name += chAry[e];
                        }
                    }
                    strAry[j] = name;
                }
            }

            return strAry;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            practice pr = new practice();
            Console.WriteLine( pr.factorial(4));
            string[] ary=pr.StringCombinations("Aamir",120);
            
            foreach (string item in ary)
            {
                Console.WriteLine(item);
            }
	
            
            
            //string a = "Aamir Suhail";
            ////to character arry
            //char[] ch = a.ToCharArray();
            //char[] nw=new char[15];
            //int index = 0;
            //for (int i = 0; i < ch.Length; i++)
            //{
            //    if (ch[i] != ' ')
            //    {
            //        nw[index] = ch[i];
            //        index++;
            //    }
            //    else
            //        continue;
                
            //}
            //for (int i = 0; i < nw.Length; i++)
            //{
                
            //}
            ////Console.WriteLine(nw.ToString());



            ////picking a substring 
            //string sub=a.Substring(6, 3);
            //Console.WriteLine(sub);
            

            ////triming
            //string aamir = "aamir abc ddlj";
            ////char[] ary = { ' ', 's' };
            //Console.WriteLine(aamir.Trim());
            //Array.Reverse(ch);
            //new string(ch);
            ////string hh = ch.Reverse<char>().ToString();
            //Console.WriteLine(ch);


            Console.ReadKey();
        }
    }
}
