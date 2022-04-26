using System;
using CSharp.LabExercise7.Model;
using CSharp.LabExercise7.Service;

namespace CSharp.LabExercise7.Renderer
{
    class GeneralRenderer
    {
        public void RenderAddStudent(Student student)
        {
            Console.Write("Enter First Name:");
            student.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            student.LastName = Console.ReadLine();

            student.GradeLevel = GetValidInput("Grade Level", 1, 10);//inputField, min, max
            student.Section = GetValidInput("Section", 1, 5);     //inputField, min, max
        }
        private int GetValidInput(string inputField, int min, int max)
        {
            do
            {
                Console.Write($"Enter {inputField}: ");
                string input = Console.ReadLine();
                bool IsValidInput = Validator.IsValidInput(input, min, max);
                if (IsValidInput)
                {
                    return Convert.ToInt32(input);
                }
            } while (true);
        }

        public void OptionRenderer()
        {
            Console.WriteLine("============= STUDENT DATABASE MANAGEMENT SYSTEM GROUP 3 =============\n");
            Console.WriteLine("1.   Add Records");
            Console.WriteLine("2.   List Records"); 
            Console.WriteLine("3.   Modify Records");
            Console.WriteLine("4.   Delete Records");
            Console.WriteLine("5.   Exit Program");
            Console.WriteLine("\n====================================================================");
        }
    }
}
