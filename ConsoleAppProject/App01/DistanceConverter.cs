using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// A converter for diferent distances
    /// </summary>
    /// <author>
    /// Apinayan Version 1.2
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
            Console.WriteLine("Enter your value for miles");
            //Console.ReadLine;
            Console.WriteLine("text");
            OpenConverterMenu();
        }
        public void OpenConverterMenu()
        {
            Console.WriteLine("This is a Distance converter");
            Console.WriteLine("Please select which Unit you would like to convert from");
            ShowMenuOptions();
            initialUnit = getValue();
            if (initialUnit == "error")
            {
                OpenConverterMenu();
            }
            ShowMenuOptions();
            convertedUnit = getValue();
            if (convertedUnit == "error")
            {
                OpenConverterMenu();
            }
            InputValue();

        }
        public void ShowMenuOptions()
        {
            Console.WriteLine("1. Feet");
            Console.WriteLine("2. Miles");
            Console.WriteLine("3. Meters");
        }
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
        public int InputValue()
        {
            Console.WriteLine("Enter your value for " + initialUnit);
            return Convert.ToInt32(Console.ReadLine());
        }
        public void ConvertValue()
        {
            /*if (initialUnit == "Feet")
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
            }*/
            if (initialUnit == "Feet" || convertedUnit == "Miles")
            {
                convertedValue = initialValue / MILEFEETCONST;
            }
            else if (initialUnit == "Feet" || convertedUnit == "Meters")
            {
                convertedValue = initialValue * FEETMETERCONST;
            }
            else if (initialUnit == "Miles" || convertedUnit == "Feet")
            {
                convertedValue = initialValue * MILEFEETCONST;
            }
            else if (initialUnit == "Miles" || convertedUnit == "Meters")
            {
                convertedValue = initialValue * MILEMETERCONST;
            }
            else if (initialUnit == "Meters" || convertedUnit == "Feet")
            {
                convertedValue = initialValue / FEETMETERCONST;
            }
            else if (initialUnit == "Meters" || convertedUnit == "Miles")
            {
                convertedValue = initialValue / MILEMETERCONST;
            }
            PrintConversion();
        }
        /*public void ConvertFeet()
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
        }*/
        public void PrintConversion()
        {
            Console.WriteLine(initialUnit + " " + initialValue + " is " + convertedValue + " " + convertedUnit);
        }
    }
}
