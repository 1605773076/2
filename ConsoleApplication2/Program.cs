using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            char c;
            Class1 d=new Class1();
           a = Convert.ToInt32(Console.ReadLine());
           c = Convert.ToChar(Console.ReadLine());
           b = Convert.ToInt32(Console.ReadLine());
            if (c == '+') {
                d.equals(a, b);
                Console.WriteLine(d.jiafa(a, b));

            }

            if (c == '-') { 
                d.equals(a, b); 
                Console.WriteLine( d.jianfa(a, b));
            }

            if (c == '*') { 
                Console.WriteLine(d.chenfa(a, b));
                d.equals(a, b);
            
            }

            if (c == '/') {
                d.chufa(a, b);
                d.equals(a, b);
            
            }
            Console.ReadKey();
        }
        
    }

}
