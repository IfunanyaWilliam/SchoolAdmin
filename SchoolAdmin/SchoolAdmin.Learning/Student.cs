

namespace SchoolAdmin.Learning
{
    public class Student
    {
        private int _regNumber;
        private string _name;

        public Student(int regNumber, string name)
        {
            _regNumber = regNumber;
            _name = name; 
        }

        public int RegNumber { get { return _regNumber; } }
        public string Name { get { return _name;} }

        public string Level { get; set; }

        public void Learn()
        {
            Console.WriteLine("A am learning now");
        }
    }
}

/*
 * 
  
3. A Student class with the following features:
○ Properties: RegNumber (int, readonly), Name (string, readonly), Level (string)
○ Methods: Learn()
○ It should have a constructor that takes in the student’s registration number and full name as parameters.
○ It should store both values in private fields, hidden from other classes.
○ It should expose these values via the public properties, in readonly form.
4. Put the Student class in a SchoolAdmin.Learning namespace.

*
*/