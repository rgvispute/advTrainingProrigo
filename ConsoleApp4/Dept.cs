using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancetraining
{
    internal class Dept
     {
        public string Dname { get; set; }

        public List<Emp> e = new List<Emp>();
    }
    class Emp
    {
        public string EmpName { get; set; }
        public int Salary { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Dept> d = new List<Dept>() {
                new Dept{Dname="ENTC", e={new Emp {EmpName="ruchita",Salary=30000},
                                         new Emp {EmpName="Gaurav",Salary=30000 },
                                          new Emp {EmpName="Surbhi",Salary=30000 }

            } } };


           



                foreach (Dept a in d)
                {
                    Console.WriteLine(a.Dname);
                    foreach (Emp b in a.e)
                    {
                        Console.WriteLine(b.EmpName + " " + b.Salary);

                    }

                }

            
        }
    }
}


