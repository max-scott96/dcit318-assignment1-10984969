using System;

class TicketPriceCalculator
{
    private int age;
    private const decimal RegularTicketPrice = 10m;
    private const decimal DiscountedTicketPrice = 7m;

    public void AskAge()
    {
        Console.WriteLine("Please enter your age:");
        string input = Console.ReadLine();

        // Validate the input
        if (int.TryParse(input, out int inputAge) && inputAge >= 0)
        {
            age = inputAge;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
            AskAge(); // Retry if the input is invalid
        }
    }

    public decimal CalculateTicketPrice()
    {
        if (age >= 65 || age <= 12)
        {
            return DiscountedTicketPrice;
        }
        else
        {
            return RegularTicketPrice;
        }
    }

    static void Main(string[] args)
    {
        TicketPriceCalculator program = new TicketPriceCalculator();
        program.AskAge();
        decimal ticketPrice = program.CalculateTicketPrice();
        Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
    }
}
