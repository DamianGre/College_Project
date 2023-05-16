//Application can create students from age 19-55

using College_Project;


College college = new College("WSB");

Random random = new Random();
int numberToCreate=0;
try {
    do
    {
        Console.Write("Enter number of students to create(from 1 to 250):");
        numberToCreate = Convert.ToInt32(Console.ReadLine());
        if (numberToCreate <= 0 || numberToCreate > 250) {
            Console.WriteLine("Wrong number");
        }
    } while (numberToCreate <= 0 || numberToCreate > 250);
} catch (Exception e) { Console.WriteLine(e); }

for (int i = 0; i < numberToCreate; i++)
{
    college.studentList.Add(new Student(college.studentList, college.studentList));
}

foreach (Student st in college.studentList)
{
    if (st.name[st.name.Length - 1].Equals('a'))
    {
        college.womenList.Add(st);
    }
    else
    {
        college.menList.Add(st);
    }
}
int abc = 0;
foreach (Student st in college.studentList)
{
    if (abc < 25)
    {
        college.group1.Add(st);
        st.group = "1";
        abc++;
    }
    else if (abc >= 25 && abc < 50)
    {
        college.group2.Add(st);
        abc++;
        st.group = "2";
    }
    else if (abc >= 50 && abc < 75)
    {
        college.group3.Add(st);
        st.group = "3";
        abc++;
    }
}

Console.WriteLine();
Console.WriteLine("-------------------");
Console.WriteLine("men");

foreach (Student st in college.menList)
{
    Console.WriteLine(st);
}

Console.WriteLine();
Console.WriteLine("-------------------");
Console.WriteLine("Women");

foreach (Student st in college.womenList)
{
    Console.WriteLine(st);
}
Console.WriteLine("-------------------");
Console.WriteLine("ALLLLLLLLLLLLLL");

foreach (Student st in college.studentList)
{
    Console.WriteLine(st);
}
Console.WriteLine("-------------------");
Console.WriteLine("Grp1");
int o = 1;
foreach (Student st in college.group1)
{
    Console.WriteLine(o+ " " +st);
    o++;
}
Console.WriteLine("-------------------");
Console.WriteLine("Grp2");
int p = 1;
foreach (Student st in college.group2)
{
    Console.WriteLine(p + " " + st);
    p++;
}
Console.WriteLine("-------------------");
Console.WriteLine("Grp3");
int u = 1;
foreach (Student st in college.group3)
{
    Console.WriteLine(u + " " + st);
    u++;
}
Console.WriteLine("-------------------");
Console.WriteLine("NOT ASSINGED");
int r = 1;
foreach (Student st in college.studentList)
{
    if (st.group == "") {
        Console.WriteLine(r + " " + st);
        u++;
    }
    
}
Console.WriteLine("-------------------");
Console.WriteLine("Average grades of the " + nameof(college.group1) + " is " + college.averageGrades(college.group1));
Console.WriteLine("-------------------");
Console.WriteLine("-------------------");
Console.WriteLine("Average grades of the " + nameof(college.group2) + " is " + college.averageGrades(college.group2));
Console.WriteLine("-------------------");

Console.WriteLine("Add new student");
//college.studentList.Add();





