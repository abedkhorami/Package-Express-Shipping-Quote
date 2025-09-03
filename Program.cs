using System;

class Program
{
    static void Main()
    {
        // Step 1: Display welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Step 2: Prompt user for package weight
        Console.Write("Please enter the package weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Step 3: Check if the weight is greater than 50
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
        }
        else
        {
            // Step 4: Prompt user for package width
            Console.Write("Please enter the package width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            // Step 5: Prompt user for package height
            Console.Write("Please enter the package height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            // Step 6: Prompt user for package length
            Console.Write("Please enter the package length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            // Step 7: Check if the total dimensions exceed 50
            if ((width + height + length) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                // Step 8: Multiply dimensions together to get volume
                double volume = width * height * length;

                // Step 9: Multiply volume by weight and divide by 100
                double total = (volume * weight) / 100;

                // Step 10: Display the shipping quote formatted as currency
                Console.WriteLine($"Your estimated total for shipping this package is: ${total:F2}");

                // End message
                Console.WriteLine("Thank you!");
            }
        }
    }
}
