using System;
using SchoolAdmin.Learning;
using SchoolAdmin.Teaching;


namespace SchoolAdmin
{
    class Program
    {
        static void Main()
        {
            Teacher teacher1 = new Teacher(1, "Mr. Philip Amadi");
            teacher1.Subject = "C# &n.NET Programming";
            teacher1.Learners = new string[]
            {
                "Ifunanya",
                "Uzor",
                "Raphael",
                "Henry",
                "Emeka"
            };

            Student student1 = new Student(1001,"Ifunanya");
            student1.Level = "Beginner";

            Console.WriteLine($"Staff NO: {teacher1.StaffId}\tName: {teacher1.Name}"); //using interpolation
                                                                                       // Console.WriteLine("Staff ID: {0}\tName: {1}", teacher1.StaffId,teacher1.Name);
            Console.WriteLine($"Subject: {teacher1.Subject}\n");

            Console.WriteLine($"No. of Learners: {teacher1.Learners.Length}");
            Console.WriteLine("Names of Learners");
            foreach(string leaner in teacher1.Learners)
            {
                Console.WriteLine(leaner);
            }

            //Display some properties of the student on the console
            Console.WriteLine($"Reg NO: {student1.RegNumber}\tName: {student1.Name}");
            Console.WriteLine($"Level: {student1.Level}");

            //Check if student1 is one of those assigned to teacher1
            if (Array.IndexOf(teacher1.Learners,student1.Name) > -1)
            {
                Console.WriteLine($"{student1.Name} is a student of { teacher1.Name}");
            }
            else { Console.WriteLine($"{student1.Name} is not a student of { teacher1.Name}"); }
        }
    }
}

/*
 * 
  
 Import the SchoolAdmin.Teaching namespace.
2. Import the SchoolAdmin.Learning namespace. 
3. Declare a variable of type Teacher then assign it an instance of the Teacher class.
○ Set the Subject property to a suitable value.
○ Set the Learners property to an array of learner names.
4. Declare a variable of type Student then assign it an instance of the Student class.
○ Set the Level property to a suitable value.
5. Write the following to the console, for the teacher you created in task 3:
○ Their staff number and name
○ The subject they teach
○ The number of learners they were assigned
○ The names of their assigned learners, one per line.
6. Write the following to the console, for the student you created in task 4:
○ Their registration number and name
○ Their current level
7. Check if the student created in task 4 is one of those assigned to the teacher created in task 3. Display the result on the console

*/