//Application can create students from age 19-55

using College_Project;


College college = new College("WSB");

Random random = new Random();

college.studentCreator(college);
college.randomStudnetGenerator(college);


Console.WriteLine("-----------------");
Console.WriteLine("ALL STUDENTS");
foreach (Student st in college.studentList) {
    Console.WriteLine(st);
}
Console.WriteLine("-----------------");
Console.WriteLine("Semester1");
foreach (Student st in college.semester1)
{
    Console.WriteLine(st);
}
Console.WriteLine("-----------------");
Console.WriteLine("3 Semester");
foreach (Student st in college.semester3)
{
    Console.WriteLine(st);
}
Console.WriteLine("-----------------");
Console.WriteLine("Women");
foreach (Student st in college.womenList)
{
    Console.WriteLine(st);
}
Console.WriteLine("-----------------");
Console.WriteLine("Men");
foreach (Student st in college.menList)
{
    Console.WriteLine(st);
}
Console.WriteLine("-----------------");
Console.WriteLine("S1Group 1");
foreach (Student st in college.s1Group1)
{
    Console.WriteLine(st);
}
Console.WriteLine("-----------------");
Console.WriteLine("S5 GROUP 5");
foreach (Student st in college.s5Group2)
{
    Console.WriteLine(st);
}









//foreach (Student st in college.studentList)
//{
//    college.semesterAndGropuSegregator(st,);
//}
//Console.WriteLine("-----------");
//Console.WriteLine("Semester 1:");
//foreach (Student st in college.semester1)
//{
//    Console.WriteLine(st);
//}
//Console.WriteLine("-----------");
//Console.WriteLine("Grp1:");
//foreach (Student st in college.s1Group1)
//{
//    Console.WriteLine(st);
//}
//Console.WriteLine("-----------");
//Console.WriteLine("Grp2:");
//foreach (Student st in college.s1Group2)
//{
//    Console.WriteLine(st);
//}




//foreach (Student st in college.studentList)
//{
//    Console.WriteLine(st);
//}

//int abc = 0;
//foreach (Student st in college.studentList)
//{
//    if (abc < 25)
//    {
//        college.group1.Add(st);
//        st.group = "11111";
//        abc++;
//    }
//    else if (abc >= 25 && abc < 50)
//    {
//        college.group2.Add(st);
//        abc++;
//        st.group = "22222";
//    }
//    else if (abc >= 50 && abc < 75)
//    {
//        college.group3.Add(st);
//        st.group = "33333";
//        abc++;
//    }
//}

//Console.WriteLine();
//Console.WriteLine("-------------------");
//Console.WriteLine("men");

//foreach (Student st in college.menList)
//{
//    Console.WriteLine(st);
//}

//Console.WriteLine();
//Console.WriteLine("-------------------");
//Console.WriteLine("Women");

//foreach (Student st in college.womenList)
//{
//    Console.WriteLine(st);
//}
//Console.WriteLine("-------------------");
//Console.WriteLine("ALLLLLLLLLLLLLL");

//foreach (Student st in college.studentList)
//{
//    Console.WriteLine(st);
//}
//Console.WriteLine("-------------------");
//Console.WriteLine("Grp1");
//int o = 1;
//foreach (Student st in college.group1)
//{
//    Console.WriteLine(o+ " " +st);
//    o++;
//}
//Console.WriteLine("-------------------");
//Console.WriteLine("Grp2");
//int p = 1;
//foreach (Student st in college.group2)
//{
//    Console.WriteLine(p + " " + st);
//    p++;
//}
//Console.WriteLine("-------------------");
//Console.WriteLine("Grp3");
//int u = 1;
//foreach (Student st in college.group3)
//{
//    Console.WriteLine(u + " " + st);
//    u++;
//}
//Console.WriteLine("-------------------");
//Console.WriteLine("NOT ASSINGED");
//int r = 1;
//foreach (Student st in college.studentList)
//{
//    if (st.group == "") {
//        Console.WriteLine(r + " " + st);
//        u++;
//    }

//}
//Console.WriteLine("-------------------");
//Console.WriteLine("Average grades of the " + nameof(college.group1) + " is " + college.averageGrades(college.group1));
//Console.WriteLine("-------------------");
//Console.WriteLine("-------------------");
//Console.WriteLine("Average grades of the " + nameof(college.group2) + " is " + college.averageGrades(college.group2));
//Console.WriteLine("-------------------");
//Console.WriteLine("-------------------");
//Console.WriteLine("-------------------");
//Console.WriteLine("Average grades of the " + nameof(college.group3) + " is " + college.averageGrades(college.group3));
//Console.WriteLine("-------------------");


//Console.WriteLine("Add new student");
//college.studentList.Add();





