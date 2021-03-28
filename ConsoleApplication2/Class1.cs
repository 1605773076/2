using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Class1
    {
        public void equals(int a, int b) {
            if (a == b)
                Console.WriteLine("相等");
            else
                Console.WriteLine("不相等");
        }
        public int jiafa( int x,int y){
            return x + y;
        }
        public int jianfa(int x, int y) {
            return x - y;
        }
        public void chufa(int x, int y) {
            try
            {
                Console.WriteLine (x / y);
            }
            catch {
                Console.WriteLine("输入错误");
            }
        }
        public int chenfa(int x, int y) {
            return x * y;
        }
    }
}
