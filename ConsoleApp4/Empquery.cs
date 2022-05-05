using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancetraining
{
    internal class Empquery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }
    }
    class Testemp
    {
        static void Main(string[] args)
        {
            List<Empquery> emplist = new List<Empquery>() { 

                new Empquery{Id=1,Name="Abhay",City="Pune",Salary=30000,Department="Maintainance"},
                new Empquery{Id=2,Name="yash",City="Pune",Salary=35000,Department="Maintainance"},
                new Empquery{Id=3,Name="Rani",City="Pune",Salary=30000,Department="Maintainance"},
                new Empquery{Id=4,Name="Surbhi",City="Bangloar",Salary=30000,Department="Devlopment"},
                new Empquery{Id=4,Name="Gaurav",City="Pune",Salary=30000,Department="Maintainance"},
                new Empquery{Id=5,Name="Ruchi",City="Mumbai",Salary=38000,Department="Devlopment"},
                new Empquery{Id=6,Name="khushi",City="Pune",Salary=30000,Department="HR"},
                new Empquery{Id=7,Name="Sunita",City="Pune",Salary=37000,Department="Maintainance"},
                new Empquery{Id=8,Name="Nikhil",City="Khamgaon",Salary=33000,Department="Devlopment"},
                new Empquery{Id=9,Name="Ulka",City="Pune",Salary=30000,Department="Maintainance"},
                new Empquery{Id=10,Name="Shyam",City="Mumbai",Salary=38000,Department="HR"}
            };

            //var result = from e in emplist
            // where e.Salary > 32000
            //select e;

            //var result1 = from e in emplist
            // orderby e.Name
            //select e;

            // var result2 = from e in emplist
            // where e.City.Contains("Mumbai")
            // select e;

            //var result2 = from e in emplist
            //              where e.Department.Contains("HR")
            //              select e;

            //var result2 = from e in emplist
            //              orderby e.Salary descending
            //              select e;

            //var result2 = from e in emplist
            //              where e.Name.StartsWith('A')  //&&   e.Name.StartsWith('S')

            //              select e;


            var result2 = from e in emplist
                          where e.City.Contains("Pune")  && e.Salary<32000
                          select e;




            foreach (Empquery emp in result2)
            {
                Console.WriteLine($"{emp.Id},{emp.Name},{emp.Salary},{emp.City},{emp.Department}");

            }
        }
    }
}
