using System;


public class StandardDeviation
{
    static void Main()
    {
        Console.WriteLine("Calculate the Standard Deviation of a set of numbers");
        Console.WriteLine("Enter the numbers separated by a space");
        Console.WriteLine("Like this -> 52 23 48 95");
        string numInput = Console.ReadLine();
        string[] numStrings = numInput.Split();
        double[] numbers = new double[numStrings.Length];
        for(var i = 0; i < numStrings.Length; i++)
        {
            numbers[i] = Convert.ToDouble(numStrings[i]);
        }
        Console.Write(calcStandardDeviation(numbers));
    }

    static string calcStandardDeviation(double[] numberArray) 
    {
        double sum = 0;
        double numberOfItems = numberArray.Length;
        double sumOfDifferencesSquared = 0;
        double average = 0;

        for (var i = 0; i < numberOfItems; i++)
        {
            sum += numberArray[i];
        }

        average = sum / numberOfItems;

        for(var i = 0; i < numberOfItems; i++)
        {
            double differenceNumberAverage = numberArray[i] - average;
            double differenceSquared = differenceNumberAverage * differenceNumberAverage;
            sumOfDifferencesSquared += differenceSquared;
        }

        double variance = sumOfDifferencesSquared / numberOfItems;
        double standardDeviation = Math.Sqrt(variance);

        return standardDeviation.ToString("n4");
    }
}

