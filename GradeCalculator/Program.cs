using System;

class GradeCalculator
{
    private int grade;

    public void EnterGrade()
    {
        Console.WriteLine("Please enter a numerical grade between 0 and 100:");
        string input = Console.ReadLine();

        // Validate the input
        if (int.TryParse(input, out int inputGrade) && inputGrade >= 0 && inputGrade <= 100)
        {
            grade = inputGrade;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numerical grade between 0 and 100.");
            EnterGrade(); // Retry if the input is invalid
        }
    }

    public string ComputeGrade()
    {
        if (grade >= 90)
        {
            return "A";
        }
        else if (grade >= 80)
        {
            return "B";
        }
        else if (grade >= 70)
        {
            return "C";
        }
        else if (grade >= 60)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }


    static void Main(string[] args)
    {
        GradeCalculator gradeCalculator = new GradeCalculator();
        gradeCalculator.EnterGrade();
        string letterGrade = gradeCalculator.ComputeGrade();
        Console.WriteLine($"The letter grade is: {letterGrade}");

    }
}