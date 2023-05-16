using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Project
{
    internal class College
    {
        public List<Student> studentList = new List<Student>();
        public List<Student> menList = new List<Student>();
        public List<Student> womenList = new List<Student>();
        public List<Student> group1 = new List<Student>();
        public List<Student> group2 = new List<Student>();
        public List<Student> group3 = new List<Student>();

        public string name;
        public College(string name)
        {
            this.name = name;           
        }

        public double averageGrades(List<Student> klass) {
            double sum = 0;
            foreach(Student st in klass)
            {
                sum += st.averageGrade;
            }
            double avg = sum / klass.Count;
            return avg;
        }
        public void printAverageGrades(List<Student> klass)
        {
            double sum = 0;
            foreach (Student st in klass)
            {
                sum += st.averageGrade;
            }
            double avg = sum / klass.Count;
            Console.WriteLine("Average Grade of the group is Equal to: " + avg);
        }

        public override string ToString()
        {
            return "College " + this.name;
        }
    }
}
