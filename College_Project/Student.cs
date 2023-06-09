﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace College_Project
{    
    internal class Student
    {
        Random random = new Random();

        string[] names = { "Adam", "Tomek", "Piotr", "Łukasz", "Damian", "Darek", "Filip", "Ola", "Ewa", "Marta", "Kasia", "Nadia", "Magda", "Beata", "Zofia" };
        string[] lastNames = { "Kowal", "Niski", "Starszuk", "Nowak", "Filińczu", "Pinkowski", "Sabczak", "Soboliński", "Walczak", "Miksiński", "Powalczuk", "Opański" };


        public string name;
        public string lastName;
        public string email;
        public int age;  
        public double averageGrade;
        public string pesel;
        public int group;
        public int semester;
        public bool sorted = false;
        public bool genderSorted = false;

        public Student(List<Student> studentList, List<Student> studentListInt)
        {
            this.name = names[random.Next(0, names.Length)];
            this.lastName = lastNames[random.Next(0, lastNames.Length)];
            this.email = emailGenerator(studentList);
            this.age = random.Next(19, 55);
            this.averageGrade = Math.Round(random.NextDouble() * (5.0 - 2.0) + 2.0, 2);
            this.pesel = peselGenerator(studentListInt);
            this.semester = random.Next(1, 8);
            this.group = random.Next(1, 3);
        }

        public Student(string name, string lastName, int age, double averageGrade, int group, int semester, string pesel, List<Student> studentListInt, List<Student> studentList)
        {
            this.name = name;
            this.lastName = lastName;
            this.email = emailGenerator(studentList);
            this.age = age;
            this.averageGrade = averageGrade;
            this.group = group;
            this.semester = semester;
            this.pesel = pesel;
        }

        public string peselGenerator(List<Student> studentList) {
            bool peselDuplicate = true;
            bool peselCheck = true;
            string pesel = "";
            do
            {               
                do {
                    pesel = "";                    
                    Random random = new Random();
                    for (int i = 0; i < 11; i++)
                    {
                        pesel += Convert.ToString(random.Next(1, 10));
                    }
                    int[] forumlaDigits = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1 };
                    int cheking = 0;
                    for (int i = 0; i < forumlaDigits.Length; i++)
                    {                        
                        cheking += Convert.ToInt32(pesel[i]) * forumlaDigits[i];
                    }                    
                    cheking = cheking % 10;
                    if (cheking == 0){
                        return pesel;
                    }else {
                        peselCheck = false;
                    }                    
                } while(!peselCheck);

                if (studentList.Count != 0){
                    foreach (Student st in studentList){
                        if (pesel == st.pesel){
                            peselDuplicate = true;
                            break;
                        }else{
                            peselDuplicate = false;
                        }
                    }
                }else{
                    peselDuplicate = false;
                }
                if (!peselDuplicate){
                    return pesel;
                }
            } while (peselDuplicate);
            return pesel;
        }       
        
        public string emailGenerator(List<Student> studentList)
        {   
            bool emailDuplicate = true;
            string email= "";
            do {
                Random random = new Random();
                string[] emailEndings = { "example.com", "gnail.com", "vp.pl", "onteria.pl" };
                email = this.name.ToLower() + "." + char.ToLower(lastName[0]) + Convert.ToString(random.Next(1, 1000)) + "@" + emailEndings[random.Next(0, emailEndings.Length)];

                if (studentList.Count != 0) {                    
                    foreach (Student st in studentList)
                    {
                        if (email == st.email)
                        {                            
                            emailDuplicate = true;
                            break;
                        }else {
                            emailDuplicate = false;
                        }
                    }
                }else {
                    emailDuplicate = false;                    
                }
                if (!emailDuplicate){                   
                    return email;                    
                } 
            } while (emailDuplicate);
            return email;
        }
        public override string ToString()
        {
            return $"Name:{this.name}, Lastname:{this.lastName}, Age:{this.age}, mail:{this.email}, Semestr:{this.semester}, Avg:{this.averageGrade}, Grp:{this.group}, Pesel:{this.pesel}";
        }
    }
}
