using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// A converter for diferent distances
    /// </summary>
    /// <author>
    /// Apinayan Version 1.1
    /// </author>
    public class DistanceConverter
    {
        double initialValue;
        double convertedValue;
        string initialUnit;
        string convertedUnit;
        const double MILEFEETCONST = 5280;
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
            OpenInitialUnitMenu();
            OpenConvertedUnitMenu();
            InputValue();

        }
        public void OpenInitialUnitMenu()
        {
            Console.WriteLine("Please select which Unit you would like to convert from");
            Console.WriteLine("1. Feet");
            Console.WriteLine("2. Miles");
            Console.WriteLine("3. Meters");
            ChooseInitialValue();
        }
        public void OpenConvertedUnitMenu()
        {
            Console.WriteLine("Please select which Unit you would like to convert to");
            Console.WriteLine("1. Feet");
            Console.WriteLine("2. Miles");
            Console.WriteLine("3. Meters");
            ChooseConvertedValue();
        }
        public void ChooseInitialValue()
        {
            string option = Console.ReadLine();
            if (option == "1")
            {
                initialUnit = "Feet";
            }
            else if (option == "2")
            {
                initialUnit = "Miles";
            }
            else if (option == "3")
            {
                initialUnit = "Meters";
            }
            else
            {
                Console.WriteLine("Error");
                OpenConverterMenu();
            }
        }
        public void ChooseConvertedValue()
        {
            string option = Console.ReadLine();
            if (option == "1")
            {
                convertedUnit = "Feet";
            }
            else if (option == "2")
            {
                convertedUnit = "Miles";
            }
            else if (option == "3")
            {
                convertedUnit = "Meters";
            }
            else
            {
                Console.WriteLine("Error");
                OpenConverterMenu();
            }
        }
        public int InputValue()
        {
            Console.WriteLine("Enter your value for " + initialUnit);
            return Convert.ToInt32(Console.ReadLine());
        }
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
        public void ConvertFeet()
        {
            if (convertedUnit == "Miles")
            {
                convertedValue = initialValue / MILEFEETCONST;
            }
            else if (convertedUnit == "Meters")
            { }
        }
        public void ConvertMiles()
        {
            if (convertedUnit == "Feet")
            {
                convertedValue = initialValue * MILEFEETCONST;
            }
            else if (convertedUnit == "Meters")
            { }
        }
        public void ConvertMeters()
        {
            if (convertedUnit == "Feet")
            { }
            else if (convertedUnit == "Miles")
            { }
        }
        public void PrintConversion()
        {
            Console.WriteLine(initialUnit + " " + initialValue + " is " + convertedValue + " " + convertedUnit);
        }
    }
}
