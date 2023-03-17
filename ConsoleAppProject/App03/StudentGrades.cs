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

        const int STUDENTNUM = 10;
        const int NAMEINDEX = 0;
        const int MARKINDEX = 1;
        const int GRADEINDEX = 2;
        const int MAXMARK = 100;
        const int MINMARK = 0;
        String[,] StudentGrade = new String[STUDENTNUM, 3];

        /*
        * Main method for this program
        */
        public void run()
        {
            Boolean running = true;
            while (running)
            {
                ShowOptions();
                String TemVariable= ChooseOption();
                if(TemVariable=="stop")
                {
                    running=false;
                }
            }
            Console.WriteLine("");
        }
        /*
        * Shows the user a list of options they can do 
        */
        public void ShowOptions()
        {
            Console.WriteLine("Please select which option you would like to use");
            Console.WriteLine("1. Enter Scores");
            Console.WriteLine("2. Print Scores");
            Console.WriteLine("3. Find min,max and median");
            Console.WriteLine("4. Exit");
        }

       /*
        * Takes an input from the user and converts in into a variable 
        */
        public int GetUserInput()
        {
            Console.WriteLine(">");
            return Convert.ToInt32(Console.ReadLine());
        }

        /*
        * Takes the input from the user and chooses which method to start based on input
        * If the input is 4, returns to run method
        * If the input is not listed, allows the user to input a value again
        */
        public String ChooseOption()
        {
            int UserOption = GetUserInput();
            if (UserOption == 1)
            {
                FindGrades();
                return null;
            }
            else if(UserOption == 2)
            {
                PrintGrade();
                return null;
            }
            else if(UserOption == 3)
            {
                PrintValues();
                return null;
            }
            else if(UserOption == 4)
            {
                return "stop";
            }
            else
            {   
                GetUserInput();
                return null;
            }
        }

        /*
        * Method for getting adding data to the studentmarks array
        * Checks value of mark and if it does not fit inside the accepted range, get user to input again
        */
        public void GetMarksByInput()
        {
            for (int i = 0; i < STUDENTNUM; i++)
            {
                Boolean validchecker = false;
                do
                {
                    Console.WriteLine("Student " + (i + 1) + " >");
                    StudentGrade[i, NAMEINDEX] = UserInput("Name");
                    StudentGrade[i, MARKINDEX] = UserInput("Mark");
                    if (Convert.ToInt32(StudentGrade[i, MARKINDEX]) > 100 || Convert.ToInt32(StudentGrade[i, MARKINDEX]) < 0)
                    {
                        Console.WriteLine("This value has not been accepted");
                        validchecker = false;
                    }
                    else
                    {
                        validchecker = true;
                    }
                } while (!validchecker);
            }
        }

        /*
        *method used to get Score and mark inputs from user
        */
        public String UserInput(String prompt)
        {
            Console.WriteLine(prompt + " > ");
            return Console.ReadLine();
        }

        /*
        * Method used to call methods for inputting score and applying grades
        * Allows for both methods to be called by caling this one
        */
        public void FindGrades()
        {
            GetMarksByInput();
            ApplyGrades();
        }

        /*
        * Applies grades based on marks scored in array
        * Scored grades into the array
        */
        public void ApplyGrades()
        {
            for (int i = 0; i < STUDENTNUM; i++)
            {
                if (Convert.ToInt32(StudentGrade[i, MARKINDEX]) > 100)
                {
                    StudentGrade[i, GRADEINDEX] = "Invalid Mark";
                }
                else if (Convert.ToInt32(StudentGrade[i, MARKINDEX]) > 69)
                {
                    StudentGrade[i, GRADEINDEX] = "A";
                }
                else if (Convert.ToInt32(StudentGrade[i, MARKINDEX]) > 59)
                {
                    StudentGrade[i, GRADEINDEX] = "B";
                }
                else if (Convert.ToInt32(StudentGrade[i, MARKINDEX]) > 49)
                {
                    StudentGrade[i, GRADEINDEX] = "C";
                }
                else if (Convert.ToInt32(StudentGrade[i, MARKINDEX]) > 39)
                {
                    StudentGrade[i, GRADEINDEX] = "D";
                }
                else
                {
                    StudentGrade[i, GRADEINDEX] = "Fail";
                }
            }
        }

        /*
        * Prints the maximum, minimum and median values from the cores collected
        */
        public void PrintValues()
        {
            Console.WriteLine("The median of all the scores is " + CalculateMedian());
            Console.WriteLine("The highest value is " + FindValue("max"));
            Console.WriteLine("The lowest value is " + FindValue("min"));
        }

        /*
        * Calculates the median from the scores stored in array
        */
        public double CalculateMedian()
        {
            double total = 0;
            for (int i = 0; i < STUDENTNUM; i++)
            {
                total = total + Convert.ToInt32(StudentGrade[i, MARKINDEX]);
            }
            return total / STUDENTNUM;
        }

        /*
        * Finds the minimum or maximum score based on which the user wants
        */
        public int FindValue(String option)
        {
            int value = Convert.ToInt32(StudentGrade[0, MARKINDEX]);

            for (int i = 0; i < STUDENTNUM; i++)
            {
                if (option == "max")
                {
                    value = FindIfGreater(value, Convert.ToInt32(StudentGrade[i, MARKINDEX]));
                }
                else if (option == "min")
                {
                    value = FindIfLesser(value, Convert.ToInt32(StudentGrade[i, MARKINDEX]));
                }
            }
            return value;
        }

        /*
        *Checks if the new value is greater than the current stored value
        */
        public int FindIfGreater(int value1, int value2)
        {
            if (value2 >= value1)
            {
                return value2;
            }
            else
            {
                return value1;
            }
        }
        /*
        *Checks if the new value is less than the current stored value
        */
        public int FindIfLesser(int value1, int value2)
        {
            if (value2 <= value1)
            {
                return value2;
            }
            else
            {
                return value1;
            }
        }

        /*
        *Prints the name of the student, their score and their grade
        */
        public void PrintGrade()
        {
            Console.WriteLine("");
            for (int i = 0; i < STUDENTNUM; i++)
            {
                Console.WriteLine("Name>" + StudentGrade[i, NAMEINDEX] + " - Score>" + StudentGrade[i, MARKINDEX] + " - Grade>" + StudentGrade[i, GRADEINDEX]);
            }
            Console.WriteLine("");
        }
    }
}
