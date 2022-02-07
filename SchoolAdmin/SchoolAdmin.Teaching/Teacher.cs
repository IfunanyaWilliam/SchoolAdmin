using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Teaching
{   /// <summary>
/// Provides a set of properties and methods typical of a school teacher.
/// </summary>
    public class Teacher
    {   //Readonly properties have only getters


        private int _StaffId;
        private string _name;

        /// <summary>
        /// Enables instantiation of a Teacher object given a staff ID and a name.
        /// </summary
        /// <param name="staffId">The staff ID number of the teacher.</param>
        /// <param name="name">The school name of the teacher</param>

        public Teacher(int staffId, string name)
        {
            _StaffId = staffId;
            _name = name;
        }

        public int StaffId  {  get { return _StaffId; } }

        public string Name { get { return _name; } }

        //The above can be shortened as follows
        // public int StaffId => _staffId;
        //public string Name => _name; 


        public string Subject { get; set; }
        
        
        /// <summary>
        /// An array of student names assigned to this teacher.
        /// </summary>
        public string[] Learners { get; set; }

        public void Teach()
        {
            Console.WriteLine("I am teaching a class now");
        }

    }
}





/*
 * 
 *
A Teacher class with the following features:
○ Properties: StaffId (int, readonly), Name (string, readonly), Subject (string), Learners (string array)
○ Methods: Teach()
○ It should have a constructor that takes in the teacher’s ID number and full name as parameters.
○ It should store both values in private fields, hidden from other classes.
○ It should expose these values via the public properties, in readonly form.
2. Put the Teacher class in a SchoolAdmin.Teaching namespace.


3. A Student class with the following features:
○ Properties: RegNumber (int, readonly), Name (string, readonly), Level (string)
○ Methods: Learn()
○ It should have a constructor that takes in the student’s registration number and full name as parameters.
○ It should store both values in private fields, hidden from other classes.
○ It should expose these values via the public properties, in readonly form.
4. Put the Student class in a SchoolAdmin.Learning namespace.

*
*/