using System;

namespace CSharp.LabExercise7.Model
{
    class Student
    {
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GradeLevel { get; set; }
        public int Section { get; set; }

        public override string ToString()
        {
            return $"{StudentID} \t\t {FirstName} \t\t {LastName} \t\t {GradeLevel} \t\t {Section}";
        }
    }
}
