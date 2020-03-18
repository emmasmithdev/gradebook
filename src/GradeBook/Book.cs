using System;
using System.Collections.Generic;

namespace GradeBook{

   public class Book
    {   
        // Properties
        // Default access modifier is private
        private List<double> grades;
        public string Name;

        // Constructor
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        // Methods
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach(var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }
            result.Average /= grades.Count;

            return result;
        }

    }
}