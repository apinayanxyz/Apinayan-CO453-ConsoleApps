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
        double weightUnit;
        double BMIValue;

        public void Run()
        {
            
        }

        //
        //Outputs a list of options for the user
        //
        public void ShowMenuOptions()
        {
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
                return ("Error");
            }
        
        }
        
        //
        //Allows the user to input a value 
        //
        public double InputValue(string givenUnit)
        {
            Console.WriteLine("Enter your value for " + gievnUnit);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}


