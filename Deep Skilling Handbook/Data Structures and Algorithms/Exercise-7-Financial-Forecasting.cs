using System;

class FinancialForecast
{
    // Recursive method to calculate future value
    static double FutureValue(double presentValue, double growthRate, int years)
    {
        if (years == 0)
            return presentValue;

        return (1 + growthRate) * FutureValue(presentValue, growthRate, years - 1);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter Present Value: ");
        double presentValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Annual Growth Rate (%): ");
        double growthRate = Convert.ToDouble(Console.ReadLine()) / 100;

        Console.Write("Enter Number of Years: ");
        int years = Convert.ToInt32(Console.ReadLine());

        double futureValue = FutureValue(presentValue, growthRate, years);

        Console.WriteLine($"\nFuture Value after {years} years = {futureValue:F2}");
    }
}