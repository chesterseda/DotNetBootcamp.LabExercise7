using System;
using System.Collections.Generic;
using CSharp.LabExercise7.Service;
using CSharp.LabExercise7.Model;
using CSharp.LabExercise7.Renderer;

namespace CSharp.LabExercise7
{
    static class DateTmePattern
    {
        public static string CurrentDate { get => "yyyy-MM-dd"; }
        public static string CurrentTime { get => "HH-mm-ss"; }
        public static string FullDate { get => CurrentDate + "-" + CurrentTime  ; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentDBManagementSystem studentSystem = new StudentDBManagementSystem();
            DBService dBService = new DBService();
            GeneralRenderer generalRenderer = new GeneralRenderer();

            studentSystem.LogFile();
            
            while (true)
            {
                generalRenderer.OptionRenderer();
                Console.Write("Enter your desired transaction: ");
                string input = Console.ReadLine();
                int choice = 1;
                if (Validator.IsValidInput(input, 1, 5))
                {
                    choice = Convert.ToInt32(input);
                }
                else
                {
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        studentSystem.AddStudent(dBService);
                        break;
                    case 2:
                        studentSystem.ListStudents(dBService);
                        break;
                    case 3:
                        studentSystem.ModifyStudent(dBService);
                        break;
                    case 4:
                        studentSystem.DeleteStudent(dBService);
                        break;
                    case 5:
                        studentSystem.WriteToFile(dBService);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
