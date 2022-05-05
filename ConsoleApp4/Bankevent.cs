using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancetraining
{
    public delegate void Mydelegate(); 
    internal class Bankevent
    {
        public event Mydelegate WithEvent;
        public void Withdraw(int amt)
        {
            if (amt < 5000)
              WithEvent();
            Console.WriteLine("your acc balance is "+amt);

        }
    }
}
