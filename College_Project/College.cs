using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
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
            avg = (double)Math.Round(avg, 2);
            Console.WriteLine("Average Grade of the group is Equal to: " + avg);
        }
        
        public void menu(College college) {
            string userChoose = "";
            do {
                userChoose = "";
                try
                {
                    Console.WriteLine("Welcome in WSB College Menu. Choose Your action:");
                    Console.WriteLine("'1' to print all students of College - All students > Semesters Segregation > Group segregation > Gender Segregation");
                    Console.WriteLine("'2' to print Number of students of particular gropus");
                    Console.WriteLine("'3' to print Average Grade of all students of College - All students AVG > Semesters Segregation AVG > Group segregation AVG > Gender Segregation AVG");
                    Console.WriteLine("'4' to add new student");
                    Console.WriteLine("'5' to add automatically choosen number  of students");
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
                            groupPrinter(college.studentList);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("SEMESTER 1: ");
                            counter(college.semester1);
                            groupPrinter(college.semester1);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("SEMESTER 2: ");
                            counter(college.semester2);
                            groupPrinter(college.semester2);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("SEMESTER 3: ");
                            counter(college.semester3);
                            groupPrinter(college.semester3);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("SEMESTER 4: ");
                            counter(college.semester4);
                            groupPrinter(college.semester4);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("SEMESTER 5: ");
                            counter(college.semester5);
                            groupPrinter(college.semester5);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("SEMESTER 6: ");
                            counter(college.semester6);
                            groupPrinter(college.semester6);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("SEMESTER 7: ");
                            counter(college.semester7);
                            groupPrinter(college.semester7);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 1 Semester 1: ");
                            counter(college.s1Group1);
                            groupPrinter(college.s1Group1);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 2 Semester 1: ");
                            counter(college.s1Group2);
                            groupPrinter(college.s1Group2);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 1 Semester 2: ");
                            counter(college.s2Group1);
                            groupPrinter(college.s2Group1);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 2 Semester 2: ");
                            counter(college.s2Group2);
                            groupPrinter(college.s2Group2);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 1 Semester 3: ");
                            counter(college.s3Group1);
                            groupPrinter(college.s3Group1);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 2 Semester 3: ");
                            counter(college.s3Group2);
                            groupPrinter(college.s3Group2);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 1 Semester 4: ");
                            counter(college.s4Group1);
                            groupPrinter(college.s4Group1);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 2 Semester 4: ");
                            counter(college.s4Group2);
                            groupPrinter(college.s4Group2);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 1 Semester 5: ");
                            counter(college.s5Group1);
                            groupPrinter(college.s5Group1);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 2 Semester 5: ");
                            counter(college.s5Group2);
                            groupPrinter(college.s5Group2);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 1 Semester 6: ");
                            counter(college.s6Group1);
                            groupPrinter(college.s6Group1);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 2 Semester 6: ");
                            counter(college.s6Group2);
                            groupPrinter(college.s6Group2);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 1 Semester 8: ");
                            counter(college.s7Group1);
                            groupPrinter(college.s7Group1);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Group 2 Semester 7: ");
                            counter(college.s7Group2);
                            groupPrinter(college.s7Group2);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Women: ");
                            counter(college.womenList);
                            groupPrinter(college.womenList);
                            Console.WriteLine(":::::::::::::::::::::::::");
                            Console.Write("Men: ");
                            counter(college.menList);
                            groupPrinter(college.menList);
                            Console.WriteLine(":::::::::::::::::::::::::");                          
                            break;
                        case "2":
                            {
                                Console.Clear();
                                Console.Write("All students Number: ");
                                counter(college.studentList);
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("Number of students in - Semester 1: ");
                                counter(college.semester1);
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("Number of students in - Semester 2: ");
                                counter(college.semester2);
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("Number of students in - Semester 3: ");
                                counter(college.semester3);
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("Number of students in - Semester 4: ");
                                counter(college.semester4);
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("Number of students in - Semester 5: ");
                                counter(college.semester5);
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("Number of students in - Semester 6: ");
                                counter(college.semester6);
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("Number of students in - Semester 7: ");
                                counter(college.semester7);
                                Console.WriteLine(":::::::::::::::::::::::::");
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
                            }
                            break;
                        case "3":
                            {
                                Console.Clear();
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Semester 1: ");
                                printAverageGrades(college.semester1);
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Semester 2: ");
                                printAverageGrades(college.semester2);
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Semester 3: ");
                                printAverageGrades(college.semester3);
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Semester 4: ");
                                printAverageGrades(college.semester4);
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Semester 5: ");
                                printAverageGrades(college.semester5);
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Semester 6: ");
                                printAverageGrades(college.semester6);
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Semester 7: ");
                                printAverageGrades(college.semester7);
                                Console.WriteLine(":::::::::::::::::::::::::");                                
                                Console.Write("AVG - Group 1 Semester 1: ");
                                printAverageGrades(college.s1Group1);                                
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Group 2 Semester 1: ");
                                printAverageGrades(college.s1Group2);                                
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Group 1 Semester 2: ");
                                printAverageGrades(college.s2Group1);                                
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Group 2 Semester 2: ");
                                printAverageGrades(college.s2Group2);                                
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Group 1 Semester 3: ");
                                printAverageGrades(college.s3Group1);                                
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Group 2 Semester 3: ");
                                printAverageGrades(college.s3Group2);                                
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Group 1 Semester 4: ");
                                printAverageGrades(college.s4Group1);                                
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Group 2 Semester 4: ");
                                printAverageGrades(college.s4Group2);                                
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Group 1 Semester 5: ");
                                printAverageGrades(college.s5Group1);                                
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Group 2 Semester 5: ");
                                printAverageGrades(college.s5Group2);                                
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Group 1 Semester 6: ");
                                printAverageGrades(college.s6Group1);                                
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Group 2 Semester 6: ");
                                printAverageGrades(college.s6Group2);                                
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Group 1 Semester 7: ");
                                printAverageGrades(college.s7Group1);                                
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Group 2 Semester 7: ");
                                printAverageGrades(college.s7Group2);                                
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Women: ");
                                printAverageGrades(college.womenList);                                
                                Console.WriteLine(":::::::::::::::::::::::::");
                                Console.Write("AVG - Men: ");
                                printAverageGrades(college.menList);                                
                                Console.WriteLine(":::::::::::::::::::::::::");                                
                            }
                            break;
                        case "4":
                            {
                                studentCreator(college);
                                foreach (Student st in college.studentList)
                                {
                                    semesterAndGropuSegregator(st, college);
                                    genderStudentSegregator(college);
                                }
                            }
                            break;
                        case "5":
                            randomStudentGenerator(college);
                            break;
                        case "q":
                            Console.WriteLine("App is closed");
                            break;
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex); }
            } while (userChoose != "q");
        }

        public void studentCreator(College college)
        {
            if (college.studentList.Count < 250) {
                string name;
                string lastName;
                string email;
                int group;
                int age;
                int semester;
                double averageGrade;
                Console.WriteLine("Student email and pesel will be generated automatically!");

                Console.Write("Enter student name: ");
                name = Console.ReadLine();

                Console.Write("\nEnter student last name: ");
                lastName = Console.ReadLine();

                do
                {
                    Console.Write("\nEnter student age(from 19 or 54 - students belowe 19 and above 54 are forbiden): ");
                    age = Convert.ToInt32(Console.ReadLine());
                } while (age < 19 || age > 54);

                do
                {
                    Console.Write("\nEnter student averageGrade(from 0 to 5,0) enter with coma NOT DOT!: ");
                    averageGrade = Convert.ToDouble(Console.ReadLine());
                } while (averageGrade < 0 || averageGrade > 5.0);
                do
                {
                    Console.Write("\nEnter student semester(from 1 or 7): ");
                    semester = Convert.ToInt32(Console.ReadLine());
                } while (semester < 1 || semester > 7);
                do
                {
                    Console.Write("\nEnter student group(from 1 or 2): ");
                    group = Convert.ToInt32(Console.ReadLine());
                } while (group < 1 || group > 2);

                string pesel = peselChecker(college.studentList);

                college.studentList.Add(new Student(name, lastName, age, averageGrade, group, semester, pesel, college.studentList, college.studentList));
                Console.Clear();
                Console.WriteLine("Student has been created \n");
            }
            else {
                Console.Clear();
                Console.WriteLine("You can't add more students - maximum number of students achieved!\n");
            }            
        }

        public void groupPrinter(List<Student> stList) {
            foreach (Student st in stList) {
                Console.WriteLine(st);
            }
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

            if (college.studentList.Count < 250)
            {
                int numberToCreate = 0;
                try
                {
                    do
                    {
                        numberToCreate = 0;
                        Console.Write("Enter number of students to create(from 1 to 250):");
                        numberToCreate = Convert.ToInt32(Console.ReadLine());
                        if (numberToCreate <= 0 || numberToCreate > 250)
                        {
                            Console.WriteLine("Wrong number");
                        }
                    } while (numberToCreate <= 0 || numberToCreate > 250);
                    if (numberToCreate + college.studentList.Count <= 250) {
                        for (int i = 0; i < numberToCreate; i++)
                        {
                            college.studentList.Add(new Student(college.studentList, college.studentList));
                        }
                        foreach (Student st in college.studentList)
                        {
                            semesterAndGropuSegregator(st, college);
                        }
                        genderStudentSegregator(college);
                        Console.Clear();
                        Console.WriteLine(numberToCreate + " students has been created \n");
                    }
                    else
                    {
                        Console.Clear();                        
                        Console.WriteLine("You can't create that much students - max number of students is 250!\nYou can add:" + (250 - college.studentList.Count)+ " more students\n");
                    }
                }
                catch (Exception e) { Console.WriteLine(e); }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You can't add more students - maximum number of students achieved!\n");
            }
        }
        public void genderStudentSegregator(College college) {           

            foreach (Student st in college.studentList)
            {                
                if (!st.genderSorted) {
                    if (st.name[st.name.Length - 1].Equals('a'))
                    {
                        college.womenList.Add(st);
                        st.genderSorted = true;
                    }
                    else
                    {
                        college.menList.Add(st);
                        st.genderSorted = true;
                    }
                }                
            }
        }
        public void semesterAndGropuSegregator(Student st, College college){
            switch (st.semester)
            {
                case 1:
                    {
                        if (!st.sorted) {
                            college.semester1.Add(st);
                            if (st.group == 1)
                            {
                                college.s1Group1.Add(st);
                                st.sorted = true;
                            }
                            else
                            {
                                college.s1Group2.Add(st);
                                st.sorted = true;
                            }
                        }                        
                    }                    
                        break;
                    case 2:
                    {
                        if (!st.sorted)
                        {
                            college.semester2.Add(st);
                            if (st.group == 1)
                            {
                                college.s2Group1.Add(st);
                                st.sorted = true;
                            }
                            else
                            {
                                college.s2Group2.Add(st);
                                st.sorted = true;
                            }
                        }
                    }
                    break;
                    case 3:
                    {
                        if (!st.sorted)
                        {
                            college.semester3.Add(st);
                            if (st.group == 1)
                            {
                                college.s3Group1.Add(st);
                                st.sorted = true;
                            }
                            else
                            {
                                college.s3Group2.Add(st);
                                st.sorted = true;
                            }
                        }
                    }
                    break;
                    case 4:
                    {
                        if (!st.sorted)
                        {
                            college.semester4.Add(st);
                            if (st.group == 1)
                            {
                                college.s4Group1.Add(st);
                                st.sorted = true;
                            }
                            else
                            {
                                college.s4Group2.Add(st);
                                st.sorted = true;
                            }
                        }
                    }
                    break;               
                    case 5:
                    {
                        if (!st.sorted)
                        {
                            college.semester5.Add(st);
                            if (st.group == 1)
                            {
                                college.s5Group1.Add(st);
                                st.sorted = true;
                            }
                            else
                            {
                                college.s5Group2.Add(st);
                                st.sorted = true;
                            }
                        }
                    }
                    break;
                    case 6:
                    {
                        if (!st.sorted)
                        {
                            college.semester6.Add(st);
                            if (st.group == 1)
                            {
                                college.s6Group1.Add(st);
                                st.sorted = true;
                            }
                            else
                            {
                                college.s6Group2.Add(st);
                                st.sorted = true;
                            }
                        }
                    }
                    break;
                    case 7:
                    {
                        if (!st.sorted)
                        {
                            college.semester7.Add(st);
                            if (st.group == 1)
                            {
                                college.s7Group1.Add(st);
                                st.sorted = true;
                            }
                            else
                            {
                                college.s7Group2.Add(st);
                                st.sorted = true;
                            }
                        }
                    }
                    break;
            }
        }

        public string peselChecker(List<Student> studentList) {
            bool peselCorectness = false;
            string pesel = "";
            int[] forumlaDigits = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1 };
            int cheking = 0;

            do
            {
                cheking = 0;
                Console.WriteLine("Enter pesel number(11 digits(int)):");
                pesel = Console.ReadLine();
                if (pesel.Length != 11)
                {
                    peselCorectness = false;
                    Console.WriteLine("WRONG pesel lenght!");
                    Console.WriteLine(pesel);
                }
                else {                    
                    for (int i = 0; i < forumlaDigits.Length; i++)
                    {
                        cheking += Convert.ToInt32(pesel[i]) * forumlaDigits[i];
                    }
                    cheking = cheking % 10;
                    if (cheking == 0)
                    {
                        peselCorectness = true;
                        foreach (Student st in studentList)
                        {
                            if (Convert.ToString(pesel) == st.pesel)
                            {
                                Console.WriteLine("!Student with that pesel already exist in our base!Enter other pesel");
                                peselCorectness = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        peselCorectness = false;
                        Console.WriteLine("Entered pesel is WRONG!");
                        Console.WriteLine(pesel);
                    }
                }                
            } while (!peselCorectness);
            return pesel;
        }
        public override string ToString()
        {
            return "College " + this.name;
        }
    }
}
