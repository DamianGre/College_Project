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
               
        public List<Student> semester1 = new List<Student>();
        public List<Student> s1Group1 = new List<Student>();
        public List<Student> s1Group2 = new List<Student>();

        public List<Student> semester2 = new List<Student>();
        public List<Student> s2Group1 = new List<Student>();
        public List<Student> s2Group2 = new List<Student>();

        public List<Student> semester3 = new List<Student>();
        public List<Student> s3Group1 = new List<Student>();
        public List<Student> s3Group2 = new List<Student>();

        public List<Student> semester4 = new List<Student>(); 
        public List<Student> s4Group1 = new List<Student>();
        public List<Student> s4Group2 = new List<Student>();

        public List<Student> semester5 = new List<Student>();
        public List<Student> s5Group1 = new List<Student>();
        public List<Student> s5Group2 = new List<Student>();

        public List<Student> semester6 = new List<Student>();
        public List<Student> s6Group1 = new List<Student>();
        public List<Student> s6Group2 = new List<Student>();

        public List<Student> semester7 = new List<Student>();
        public List<Student> s7Group1 = new List<Student>();
        public List<Student> s7Group2 = new List<Student>();


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

        public void studentCreator(College college)
        {
            string name;
            string lastName;
            string email;
            string group;
            int age;
            int semester;
            double averageGrade;
            Console.Write("Student email and pesel will be generated automatically!");
            Console.Write("Enter student name: ");
            name = Console.ReadLine();
            Console.Write("\nEnter student last name: ");
            lastName = Console.ReadLine();
            Console.Write("\nEnter student age(from 19 or 54): ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter student averageGrade: ");
            averageGrade = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nEnter student semester(from 1 or 7): ");
            semester = Convert.ToInt32(Console.ReadLine());            
            Console.Write("\nEnter student group(from 1 or 2): ");
            group = Console.ReadLine();

            college.studentList.Add(new Student(name, lastName, age, averageGrade, group, semester, college.studentList, college.studentList));
        }
        public void menu() {
            Console.WriteLine("Welcome in WSB College.");
            Console.WriteLine("Welcome in WSB College.");
        }

        public void randomStudnetGenerator(College college) {
            int numberToCreate = 0;
            try
            {
                do
                {
                    Console.Write("Enter number of students to create(from 1 to 250):");
                    numberToCreate = Convert.ToInt32(Console.ReadLine());
                    if (numberToCreate <= 0 || numberToCreate > 250)
                    {
                        Console.WriteLine("Wrong number");
                    }
                } while (numberToCreate <= 0 || numberToCreate > 250);

                for (int i = 0; i < numberToCreate; i++)
                {
                    college.studentList.Add(new Student(college.studentList, college.studentList));
                }
                foreach (Student st in college.studentList) {
                    semesterAndGropuSegregator(st, college);                    
                }
                genderStudentSegregator(college);
            }
            catch (Exception e) { Console.WriteLine(e); }
        }
        public void genderStudentSegregator(College college) {           

            foreach (Student st in college.studentList)
            {
                if (st.semester == 1)
                {
                    st.averageGrade = 0.0;
                }

                if (st.name[st.name.Length - 1].Equals('a'))
                {
                    college.womenList.Add(st);
                }
                else
                {
                    college.menList.Add(st);
                }
            }
        }
        public void semesterAndGropuSegregator(Student st, College college){
                switch (st.semester)
                {
                    case 1:
                        college.semester1.Add(st);
                        if (college.s1Group1.Count < 25)
                        {
                            college.s1Group1.Add(st);
                            st.group = "1";
                        }
                        else if (college.s1Group1.Count == 25 && college.s1Group2.Count <= 25)
                        {
                            college.s1Group2.Add(st);
                            st.group = "2";
                        }
                        else
                        {
                            Console.WriteLine("Semester 1 groups are full");
                            st.group = "-";
                            st.semester = 0;
                        }
                        break;
                    case 2:
                        college.semester2.Add(st);
                        if (college.s2Group1.Count < 25)
                        {
                            college.s2Group1.Add(st);
                            st.group = "1";
                        }
                        else if (college.s2Group2.Count == 25 && college.s2Group2.Count <= 25)
                        {
                            college.s2Group2.Add(st);
                            st.group = "2";
                        }
                        else
                        {
                            Console.WriteLine("Semester 2 groups are full");
                            st.group = "-";
                            st.semester = 0;
                        }
                            break;
                    case 3:
                        college.semester3.Add(st);
                        if (college.s3Group1.Count < 25)
                        {
                            college.s3Group1.Add(st);
                            st.group = "1";
                        }
                        else if (college.s3Group1.Count == 25 && college.s3Group2.Count <= 25)
                        {
                            college.s3Group2.Add(st);
                            st.group = "2";
                        }
                        else
                        {
                            Console.WriteLine("Semester 3 groups are full");
                            st.group = "-";
                            st.semester = 0;
                        }
                        break;
                    case 4:
                        college.semester4.Add(st);
                        if (college.s4Group1.Count < 25)
                        {
                            college.s4Group1.Add(st);
                            st.group = "1";
                        }
                        else if (college.s4Group1.Count == 25 && college.s4Group2.Count <= 25)
                        {
                            college.s4Group2.Add(st);
                            st.group = "2";
                        }
                        else
                        {
                            Console.WriteLine("Semester 4 groups are full");
                            st.group = "-";
                            st.semester = 0;
                        }
                        break;
                    case 5:
                        college.semester5.Add(st);
                        if (college.s5Group1.Count < 25)
                        {
                            college.s5Group1.Add(st);
                            st.group = "1";
                        }
                        else if (college.s5Group1.Count == 25 && college.s5Group2.Count <= 25)
                        {
                            college.s5Group2.Add(st);
                            st.group = "2";
                        }
                        else
                        {
                            Console.WriteLine("Semester 5 groups are full");
                            st.group = "-";
                            st.semester = 0;
                        }
                        break;
                    case 6:
                        college.semester6.Add(st);
                        if (college.s6Group1.Count < 25)
                        {
                            college.s6Group1.Add(st);
                            st.group = "1";
                        }
                        else if (college.s6Group1.Count == 25 && college.s6Group2.Count <= 25)
                        {
                            college.s6Group2.Add(st);
                            st.group = "2";
                        }
                        else
                        {
                            Console.WriteLine("Semester 6 groups are full");
                            st.group = "-";
                            st.semester = 0;
                    }
                        break;
                    case 7:
                        college.semester7.Add(st);
                        if (college.s7Group1.Count < 25)
                        {
                            college.s7Group1.Add(st);
                            st.group = "1";
                        }
                        else if (college.s7Group1.Count == 25 && college.s7Group2.Count <= 25)
                        {
                            college.s7Group2.Add(st);
                            st.group = "2";
                        }
                        else
                        {
                            Console.WriteLine("Semester 7 groups are full");
                        }
                        break;
            }
        }       

        public override string ToString()
        {
            return "College " + this.name;
        }
    }
}
