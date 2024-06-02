using System;

class MoveEstimator
{
    static void Main()
    {
        Console.WriteLine("Enter the number of hours for the job:");
        double hours = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of miles involved in the move:");
        double miles = double.Parse(Console.ReadLine());

        double baseRate = 200;
        double perHourRate = 150;
        double perMileRate = 2;

        double totalFee = baseRate + (perHourRate * hours) + (perMileRate * miles);

        Console.WriteLine("Total moving fee: $" + totalFee.ToString("0.00"));
    }
}
