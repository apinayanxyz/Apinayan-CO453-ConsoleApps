using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {

        String[,] StudentGrades = new int[10,3];

        public void run()
        {
            FindGrades();
            PrintGrade();
            CalculateMedian();
            FindValue("max");
            FindValue("min");
        }   

        public void GetMarksByInput()
        {

        }

        public String UserInput()
        {
            Console.WriteLine("Enter your value for " + initialUnit);
            return Console.ReadLine();
        }

        public FindGrades()
        {

        }

        public int CalculateMedian()
        {

        }

        public int FindValue(String option)
        {

        }

        public boolean FindIf(String option)
        {

        }

        public void PrintGrade()
        {

        }
    }
}
