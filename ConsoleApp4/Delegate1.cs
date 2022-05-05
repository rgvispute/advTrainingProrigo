using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancetraining
{
    
    
        public delegate int mydelegate(int a1, int b1);

        public class calculator
        {
            public int Add(int a,int b)
            {
                return a + b;
            }
            public int Sub(int a,int b)
            {
                return a - b;
            }
            public int Mul(int a,int b)
            {
                return a * b;
            }
        }
    
    class Test
    {
        static void Main(string[] args)
        {
           calculator d = new calculator();
            mydelegate mydel = new mydelegate(d.Add);
            mydel += new mydelegate(d.Sub);
            mydel += new mydelegate(d.Mul);
            Delegate[] List = mydel.GetInvocationList();
            foreach (Delegate d1 in List)
            {
                Console.WriteLine(d1.Method);
                Console.WriteLine(d1.DynamicInvoke(2,3));
            }
        }
    }
}
