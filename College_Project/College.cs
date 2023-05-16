using System;
using System.Collections;
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
            Console.WriteLine("Student email and pesel will be generated automatically!");
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
        public void menu(College college) {
            string userChoose = "";
            do {
                userChoose = "";
                try
                {
                    Console.WriteLine("Welcome in WSB College Menu. Choose Your action:");
                    Console.WriteLine("'1' to print all students of College - All students > Semesters Segregation > Group segregation > Gender Segregation");
                    Console.WriteLine("'2' to print Average Grade of all students of College - All students AVG > Semesters Segregation AVG > Group segregation AVG > Gender Segregation AVG");
                    Console.WriteLine("'3' to add new student");
                    Console.WriteLine("'4' to add automatically choosen number  of students");
                    Console.WriteLine("Enter 'q' to close app.");

                    userChoose = Console.ReadLine();
                    if (userChoose == "q" || userChoose == "Q")
                    {
                        userChoose.ToLower();
                    }
                    switch (userChoose)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("ALL STUDENTS: ");
                            counter(college.studentList);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("SEMESTER 1: ");
                            counter(college.semester1);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("SEMESTER 2: ");
                            counter(college.semester2);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("SEMESTER 3: ");
                            counter(college.semester3);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("SEMESTER 4: ");
                            counter(college.semester4);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("SEMESTER 5: ");
                            counter(college.semester5);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("SEMESTER 6: ");
                            counter(college.semester6);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("SEMESTER 7: ");
                            counter(college.semester7);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 1 Semester 1: ");
                            counter(college.s1Group1);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 2 Semester 1: ");
                            counter(college.s1Group2);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 1 Semester 2: ");
                            counter(college.s2Group1);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 2 Semester 2: ");
                            counter(college.s2Group2);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 1 Semester 3: ");
                            counter(college.s3Group1);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 2 Semester 3: ");
                            counter(college.s3Group2);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 1 Semester 4: ");
                            counter(college.s4Group1);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 2 Semester 4: ");
                            counter(college.s4Group2);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 1 Semester 5: ");
                            counter(college.s5Group1);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 2 Semester 5: ");
                            counter(college.s5Group2);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 1 Semester 6: ");
                            counter(college.s6Group1);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 2 Semester 6: ");
                            counter(college.s6Group2);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 1 Semester 8: ");
                            counter(college.s7Group1);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 2 Semester 7: ");
                            counter(college.s7Group2);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Women: ");
                            counter(college.womenList);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Men: ");
                            counter(college.menList);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            college.menu(college);

                            break;
                        case "2":
                            {
                                Console.Clear();
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Semester 1: ");
                                counter(college.semester1);
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Semester 2: ");
                                counter(college.semester2);
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Semester 3: ");
                                counter(college.semester3);
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Semester 4: ");
                                counter(college.semester4);
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Semester 5: ");
                                counter(college.semester5);
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Semester 6: ");
                                counter(college.semester6);
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Semester 7: ");
                                counter(college.semester7);
                                Console.WriteLine(":::::::::::::::::::::::::");
                                college.menu(college);
                            }
                            break;
                        case "3":
                            {
                                studentCreator(college);
                                foreach (Student st in college.studentList)
                                {
                                    semesterAndGropuSegregator(st, college);
                                    genderStudentSegregator(college);
                                }
                            }
                            break;
                        case "4":
                            randomStudentGenerator(college);
                            break;
                        case "q":
                            Console.WriteLine("App is closed"); ;
                            break;
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex); }
            } while (userChoose != "q");


        }

        public void groupPrinter(List<Student> stList) {
            foreach (Student st in stList) {
                Console.WriteLine(st);
            }
        }
        public void semesterMenu(College college) {
            string userSemChoose = "";

            try
            {
                Console.Clear();
                Console.WriteLine("Welcome in WSB College Menu.");
                Console.WriteLine("Enter '1' to check students number in Semester 1");
                Console.WriteLine("Enter '2' to check students number in Semester 2");
                Console.WriteLine("Enter '3' to check students number in Semester 3");
                Console.WriteLine("Enter '4' to check students number in Semester 4");
                Console.WriteLine("Enter '5' to check students number in Semester 5");
                Console.WriteLine("Enter '6' to check students number in Semester 6");
                Console.WriteLine("Enter '7' to check students number in Semester 7");
                userSemChoose = Console.ReadLine();
                switch (userSemChoose)
                {
                    case "1":
                        {
                            counter(college.semester1);
                        }
                        break;
                    case "2":
                        {
                            counter(college.semester2);
                        }
                        break;
                    case "3":
                        {
                            counter(college.semester3);
                        }
                        break;
                    case "4":
                        {
                            counter(college.semester4);
                        }
                        break;
                    case "5":
                        {
                            counter(college.semester5);
                        }
                        break;
                    case "6":
                        {
                            counter(college.semester6);
                        }
                        break;
                    case "7":
                        {
                            counter(college.semester7);
                        }
                        break;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        
        public void groupMenu(College college)
        {
            try {
                string userGrpChoose = "";

                Console.WriteLine("Group Menu");
                Console.WriteLine("Enter '1' to check students number of Semester 1 - group1");
                Console.WriteLine("Enter '2' to check students number of Semester 1 - group2");
                Console.WriteLine("Enter '3' to check students number of Semester 2 - group1");
                Console.WriteLine("Enter '4' to check students number of Semester 2 - group2");
                Console.WriteLine("Enter '5' to check students number of Semester 3 - group1");
                Console.WriteLine("Enter '6' to check students number of Semester 3 - group2");
                Console.WriteLine("Enter '7' to check students number of Semester 4 - group1");
                Console.WriteLine("Enter '8' to check students number of Semester 4 - group2");
                Console.WriteLine("Enter '9' to check students number of Semester 5 - group1");
                Console.WriteLine("Enter '10' to check students number of Semester 5 - group2");
                Console.WriteLine("Enter '11' to check students number of Semester 6 - group1");
                Console.WriteLine("Enter '12' to check students number of Semester 6 - group2");
                Console.WriteLine("Enter '13' to check students number of Semester 7 - group1");
                Console.WriteLine("Enter '14' to check students number of Semester 7 - group2");

                userGrpChoose = Console.ReadLine();
                switch (userGrpChoose)
                {
                    case "1":
                        {
                            counter(college.s1Group1);                           
                        }
                        break;
                    case "2":
                        {
                            counter(college.s1Group2);                           
                        }
                        break;
                    case "3":
                        {
                            counter(college.s2Group1);                            
                        }
                        break;
                    case "4":
                        {                            
                            counter(college.s2Group2);                        
                        }
                        break;
                    case "5":
                        {
                            counter(college.s3Group1);                            
                        }
                        break;
                    case "6":
                        {
                            counter(college.s3Group2);                           
                        }
                        break;
                    case "7":
                        {
                            counter(college.s4Group1);                           
                        }
                        break;
                    case "8":
                        {
                            counter(college.s4Group2);
                        }
                        break;
                    case "9":
                        {
                            counter(college.s5Group1);
                        }
                        break;
                    case "10":
                        {
                            counter(college.s5Group2);
                        }
                        break;
                    case "11":
                        {
                            counter(college.s6Group1);
                        }
                        break;
                    case "12":
                        {
                            counter(college.s6Group2);
                        }
                        break;
                    case "13":
                        {
                            counter(college.s7Group1);
                        }
                        break;
                    case "14":
                        {
                            counter(college.s7Group2);
                        }
                        break;                   
                 }
            } catch(Exception ex) { Console.WriteLine(ex); }
   
            
        }

        public void counter(List<Student> stList) {
            int i = 0;
            foreach (Student st in stList)
            {
                i++;
            };
            Console.WriteLine("Students number in choosen 'group' = " + i);
        }

        public void randomStudentGenerator(College college) {
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
                    foreach (Student st2 in college.womenList) {
                        if (st == st2) {
                            break;
                        }
                    }
                    college.womenList.Add(st);
                }
                else
                {
                    foreach (Student st2 in college.womenList)
                    {
                        if (st == st2)
                        {
                            break;
                        }
                    }
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
