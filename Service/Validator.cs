using System;
using CSharp.LabExercise7.Exceptions;

namespace CSharp.LabExercise7.Service
{
    static class Validator
    {
        static public bool IsValidInput(string input, int min, int max)
        {
            try
            {
                int intInput = Convert.ToInt32(input);
                if(intInput >= min && intInput <= max)
                {
                    return true;
                }
                else
                {
                    throw new InvalidInputException($"Invalid input. Input must be between {min}-{max}");
                }
            }
            catch (InvalidInputException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Invalid Input. Input must be a number between {min}-{max}");
                return false;
            }
            catch(Exception e)
            {
                Console.WriteLine("Unknown Exception occur. Please try again");
                return false;
            }
        }
    }
}
