using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// An app that calculates the BMI of the user 
    /// </summary>
    /// <author>
    /// Apinayan Kanenthirarasa version 0.1
    /// </author>
    public class BMICalculator
    {
        double heightValue;
        double weightValue;
        string heightUnit;
        string weightUnit;
        double BMIValue;
        const double FeetPoundConst=703;
        public void Run()
        {   
            Console.WriteLine("This is a BMI Calculator");
            ShowMenuOptions();
            GetValue();
            heightValue = InputValue(heightUnit);
            weightValue = InputValue(weightUnit);
            CalculateBMI();
            PrintValue();
        }

        //
        //Outputs a list of options for the user
        //
        public void ShowMenuOptions()
        {
            Console.WriteLine("Please select which values you would like to use");
            Console.WriteLine("1. Cm and Kg");
            Console.WriteLine("2. Feet and pounds");
        }

        //
        //Takes the input from the user and determines which units will be used
        //
        public void GetValue()
        {
            string option = Console.ReadLine();
            if (option == "1")
            {
                heightUnit = "Centimetre";
                weightUnit = "Kilogram";
            }
            else if (option == "2")
            {
                heightUnit = "Feet";
                weightUnit = "Pounds";
            }
            else
            {   
                Console.WriteLine("Please enter a valid value");
                GetValue();
            }
        
        }
        
        //
        //Allows the user to input a value 
        //
        public double InputValue(string givenUnit)
        {
            Console.WriteLine("Enter your value for " + givenUnit);
            return Convert.ToInt32(Console.ReadLine());
        }

        public void CalculateBMI()
        {
            if(heightUnit == "Feet" || weightUnit == "Pounds")
            {
                BMIValue=(weightValue / (heightValue * heightValue) ) * FeetPoundConst;
            }
            else 
            {
                BMIValue=(weightValue / (heightValue * heightValue) );
            }
        }

        public void PrintValue()
        {
            Console.WriteLine("From " +  heightValue + " " + heightUnit + " and "+  weightValue + " " + weightUnit);
            Console.WriteLine("Your BMI Score is " + BMIValue);
        }
    }
}


