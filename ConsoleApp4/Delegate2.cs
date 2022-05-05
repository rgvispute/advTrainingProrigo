using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancetraining
{
    public delegate void mydel(string n1);
    internal class Delegate2
    {
        public void Upper1(string n1)
        {
           // string a = n1.ToUpper();
            Console.WriteLine(n1.ToUpper());

        }
        public void Lower1(string n1)
        {
           // string b = n1.ToLower();
            Console.WriteLine(n1.ToLower());
        }
    }
    class Testdele
    {
        static void Main(string[] args)
        {
            Delegate2 del = new Delegate2();
             mydel m =new mydel (del.Upper1);
            m +=new mydel (del.Lower1);
            Delegate [] List=m.GetInvocationList();
            foreach ( Delegate item in List)
            {
                Console.WriteLine(item.Method);
                item.DynamicInvoke("Delegate");

            }

        }
    }
}
