using System;
using System.Collections.Generic;

namespace CSharp.LabExercise7.Model
{
    class StudentDb
    {
        public List<Student> Students { get; set; }

        public StudentDb()
        {
            Students = new List<Student>();
        }
    }
}
