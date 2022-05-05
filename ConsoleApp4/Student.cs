using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancetraining
{

    //Class Course -> id,name & fees
    //Student -> rollno, name,percentage, branch

    // 5 diff LINQ queries for each

    class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int Fees { get; set; }
        public List<Student> Stulist = new List<Student>();
    }
    internal class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public float Percentage { get; set; }
        public string Branch { get; set; }


    }
    class Testcourse
    {
        static void Main(string[] args)
        {
            List<Course> Courselist = new List<Course>() {
                new Course{Id=101,CourseName="c#",Fees=40000,Stulist={new Student { RollNo=1,Name="Ruchita",Percentage=70,Branch="Entc"},
                                                                    new Student { RollNo=1,Name="ajay",Percentage=75,Branch="Entc"},
                                                                    new Student { RollNo=1,Name="Gaurav",Percentage=78,Branch="Entc"},
                                                                    new Student { RollNo=1,Name="Kamal",Percentage=82,Branch="civil"},
                                                                    new Student { RollNo=1,Name="Ruchi",Percentage=67,Branch="civil"}

                } },

                 new Course{Id=102,CourseName="Java",Fees=50000,Stulist={new Student { RollNo=1,Name="Rucha",Percentage=88,Branch="cse"},
                                                                    new Student { RollNo=1,Name="Gauri",Percentage=98,Branch="Entc"},
                                                                    new Student { RollNo=1,Name="Kimaya",Percentage=77,Branch="cse"},
                                                                    new Student { RollNo=1,Name="Manu",Percentage=78,Branch="Entc"},
                                                                    new Student { RollNo=1,Name="Mansi",Percentage=90,Branch="cse"}


            } } 
            };
            //IEnumerable<List<Student>> res = from c in Courselist select c.Stulist;
            //var result = from s in res
            //             where s.
            //             select s;
                       
            var res=Courselist.Where(x=>x.Id==102)

            foreach (Course course in result)
            {
                
                {
                    Console.WriteLine($"{course.CourseName},{course.Fees}");

                }

            }
           var result2= from e in Stulist
            where e.Name.StartWith("A")
            foreach (Student stu in Stulist)
            {
                Console.WriteLine($"{stu.Name}");

            }
        }
    }
}
