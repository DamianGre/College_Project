//Application allow to create 250 students, user can create students by random generator
//or user can create student by himself.
//Random generator is creating valid pesel(unique - duplicates are not allowed = when app created
//pesel that is already in base app will create new one. Appcilation is creating automatically email adress
//which is unique and its made by student name+.+first letter of last name + random number generated
//from 1 to 1000+ @ + random generated ending - emails are uniqe - duplicates are not allowed = when app created
//email that is already in base app will create new one.
//exemplary email - student name: Tomek, last name: Nowak - tomek.n234@gnail.com
//When student is created app will do validation of pesel if its wrong it will request to enter new one
//App can count number of students in groups(app will print number of students of all groups)
//App can count average grades of group(app will print all groups and thier counter avg grades)
//App will automatically segragate students by its gender(to men and women group)
//Automatically created will be segragated randomly into semesters and groups


using College_Project;

College college = new College("WSB");

Random random = new Random();

college.menu(college);


