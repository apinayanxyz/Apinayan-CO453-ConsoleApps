﻿using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// A converter for diferent distances
    /// </summary>
    /// <author>
    /// Apinayan Version 1.4
    /// </author>
    public class DistanceConverter
    {
        double initialValue;
        double convertedValue;
        string initialUnit;
        string convertedUnit;
        const double MILEFEETCONST = 5280;
        const double MILEMETERCONST = 1609.35;
        const double FEETMETERCONST = 0.3048;
        public void Run()
        {
            OpenConverterMenu();
        }

        //
        //Serves as the main method of this app
        //Opens a method that will call in methods to allow the user to input the units they would like to use, and provides the conversion
        //
        public void OpenConverterMenu()
        {
            Console.WriteLine("This is a Distance converter");
            Console.WriteLine("Please select which Unit you would like to convert from");
            Console.WriteLine("");
            ShowMenuOptions();
            initialUnit = getValue();
            if (initialUnit == "error")
            {
                OpenConverterMenu();
            }

            Console.WriteLine("");
            Console.WriteLine("Please select which Unit you would like to convert to");
            Console.WriteLine("");

            ShowMenuOptions();
            convertedUnit = getValue();
            if (convertedUnit == "error")
            {
                OpenConverterMenu();
            }

            initialValue =InputValue();
            ConvertValue();

        }

        //
        //Outputs a list of options for the user
        //
        public void ShowMenuOptions()
        {
            Console.WriteLine("1. Feet");
            Console.WriteLine("2. Miles");
            Console.WriteLine("3. Meters");
        }

        //
        //Takes the input from the user and determines which unit will be used
        //
        public string getValue()
        {
            string option = Console.ReadLine();
            if (option == "1")
            {
                return "Feet";
            }
            else if (option == "2")
            {
                return "Miles";
            }
            else if (option == "3")
            {
                return "Meters";
            }
            else
            {
                return ("Error");
            }
        }

        //
        //Allows the user to input a value
        //
        public double InputValue()
        {
            Console.WriteLine("Enter your value for " + initialUnit);
            return Convert.ToInt32(Console.ReadLine());
        }

        //
        //Calls on different methods based on the type of unit the original value is in
        //
        public void ConvertValue()
        {
            if (initialUnit == "Feet")
            {
                ConvertFeet();
            }
            else if (initialUnit == "Miles")
            {
                ConvertMiles();
            }
            else if (initialUnit == "Meters")
            {
                ConvertMeters();
            }
            PrintConversion();
        }

        //
        //Converts the value to another unit if it is in feet
        //
        public void ConvertFeet()
        {
            if (convertedUnit == "Miles")
            {
                convertedValue = initialValue / MILEFEETCONST;
            }
            else if (convertedUnit == "Meters")
            {
                convertedValue = initialValue * FEETMETERCONST;
            }
        }

        //
        //Converts the value to another unit if it is in miles
        //
        public void ConvertMiles()
        {
            if (convertedUnit == "Feet")
            {
                convertedValue = initialValue * MILEFEETCONST;
            }
            else if (convertedUnit == "Meters")
            {
                convertedValue = initialValue * MILEMETERCONST;
            }
        }

        //
        //Converts the value to another unit if it is in metres
        //
        public void ConvertMeters()
        {
            if (convertedUnit == "Feet")
            {
                convertedValue = initialValue / FEETMETERCONST;
            }
            else if (convertedUnit == "Miles")
            {
                convertedValue = initialValue / MILEMETERCONST;
            }
        }

        //
        //Prints the complete conversion
        //Shows the inital value and unit aswell as the final value and unit.
        //
        public void PrintConversion()
        {
            Console.WriteLine(initialUnit + " " + initialValue + " is " + convertedValue + " " + convertedUnit);
        }
    }
}
