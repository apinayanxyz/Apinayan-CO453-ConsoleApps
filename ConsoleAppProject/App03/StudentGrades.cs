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
            for (int i = 0; i < StudentGrades.length; i++)
            {
                String StudentGrade[i,0] = UserInput("Name");
                String StudentGrade[i,1] = UserInput("Mark");
            }
        }

        public String UserInput(String prompt)
        {
            Console.WriteLine(prompt + " > ");
            return Console.ReadLine();
        }

        public FindGrades()
        {

        }

        public int CalculateMedian()
        {   
            int total=0;
            for (int i = 0; i < StudentGrades.length; i++)
            {
                total=Convert.ToInt32(StudentGrades[i,1]);
            }
            
            return total / StudentGrades.length;
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
