using System;
using System.Collections.Generic;
using CSharp.LabExercise7.Model;

namespace CSharp.LabExercise7.Service
{
    class SearchService
    {
        public int GetIndexByStudentID(List<Student> students, string studentID)
        {
            for (int index = 0; index < students.Count; index++)
            {
                if (studentID == students[index].StudentID)
                {
                    return index;
                }
            }
            return -1; // throw something
        }
    }
}
