using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancetraining
{
    internal class Productq
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
    class Testproduct
    {
        static void Main(string[] args)
        {
            List<Productq> productlist = new List<Productq>() {
                new Productq{Id=1,Name="HP Laptop",Price=35000},
                new Productq{Id=1,Name="HP Laptop",Price=34000},
                new Productq{Id=1,Name="Lenovo Laptop",Price=35000},
                new Productq{Id=1,Name="HP Laptop",Price=35000},
                new Productq{Id=1,Name="Accer Laptop",Price=37000},
                new Productq{Id=1,Name="HP Laptop",Price=36000},
                new Productq{Id=1,Name="HP Laptop",Price=32000}
            };
            var result = from p in productlist
                         //where p.Price > 35000 && p.Price<37000  
                        // where p.Name.StartsWith('H')  //starts with H
                       // where p.Name.Contains("HP")  //starts with HP
                       //orderby p.Price
                       orderby p.Price descending
                         select p;
            foreach (Productq p in result)
            {
                Console.WriteLine($"{p.Name},{p.Price}");

            }

        }
    }
}
