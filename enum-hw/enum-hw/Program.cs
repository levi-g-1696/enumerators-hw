using System;
using System.Collections;
using System.Collections.Generic;

namespace enum_hw
{
    // HW - levi gink
    class Program
    {
        static void Main(string[] args)
        {

            foreach (var item in new First10Pow(2.0))
            {
                Console.WriteLine(item);
            }

            List<Student> students = new List<Student>();
            students.Add(new Student(2001,8));
            students.Add(new Student(2002,8));
            students.Add(new Student(2003,11));
            students.Add(new Student(2004,10));
            students.Add(new Student(2005,9));
            students.Add(new Student(2007,8));

            foreach (var item in new StudentsWhoParcticeALot(students))
            {
                Console.WriteLine(item.Grade+" - " + item.ID);
            }
            Console.ReadLine();


        }

        public class First10Pow : IEnumerable<double>
        {
            double num;
            public IEnumerator<double> GetEnumerator()
            {
                for (int i = 1; i <= 10; i++)
                {
                    yield return Math.Pow(num, i);
                }
            }

            public First10Pow(double num)
            {
                this.num = num;
            }



            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }



        }


    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(int iD, int grade)
        {
            ID = iD;
            Grade = grade;
        }
    }

    public class StudentsWhoParcticeALot : IEnumerable<Student>
    {
        public List<Student> studentList { get; set; }

        public StudentsWhoParcticeALot(List<Student> studentList)
        {
            this.studentList = studentList;
        }

        public IEnumerator<Student> GetEnumerator()
        {
            foreach (var item in studentList)
            {
                if (item.Grade >= 10) yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}




