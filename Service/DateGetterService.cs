using System;
using System.Globalization;

namespace CSharp.LabExercise7.Service
{
    class DateGetterService
    {
        public string GetCurrentDate(string pattern)
        {
            DateTime currentDate = DateTime.Now;
            string date = currentDate.ToString(pattern);

            return date;
        }
    }
}
