using System;

class Program
{
    private double side1;
    private double side2;
    private double side3;

    public void InquireSides()
    {
        Console.WriteLine("Please enter the lengths of the three sides of the triangle:");

        side1 = GetSideLength("Side 1:");
        side2 = GetSideLength("Side 2:");
        side3 = GetSideLength("Side 3:");
    }

    private double GetSideLength(string prompt)
    {
        Console.WriteLine(prompt);
        string input = Console.ReadLine();

        // Validate the input
        if (double.TryParse(input, out double sideLength) && sideLength > 0)
        {
            return sideLength;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
            return GetSideLength(prompt); // Retry if the input is invalid
        }
    }

    public string DetermineTriangleType()
    {
        if (side1 == side2 && side2 == side3)
        {
            return "Equilateral";
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            return "Isosceles";
        }
        else
        {
            return "Scalene";
        }
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.InquireSides();
        string triangleType = program.DetermineTriangleType();
        Console.WriteLine($"The type of the triangle is: {triangleType}");
    }
}