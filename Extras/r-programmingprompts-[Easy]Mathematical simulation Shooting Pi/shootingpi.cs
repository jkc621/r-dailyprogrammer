using System;

public class ShootingPi
{
	static void Main()
	{
		Console.WriteLine("Enter the length of the square");
		double lengthOfSquare = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the number of times to repeat the experiment");
		int reps = Convert.ToInt32(Console.ReadLine());
		int hitCounter = 0;

		double shotXCoord = 0;
		double shotYCoord = 0;

		Random r = new Random();

		for (int i = 0; i < reps; i++)
		{
			double lengthFromCorner = 0;
			shotXCoord = generateRandomNoFromZero(r, lengthOfSquare);
			shotYCoord = generateRandomNoFromZero(r, lengthOfSquare);
            lengthFromCorner = Math.Pow((Math.Pow(shotXCoord, 2) + Math.Pow(shotYCoord, 2)), 0.5); //Pythagoras Theorem

            if(lengthFromCorner < lengthOfSquare)
            {
            	hitCounter++;
            }
		}

		double result = (hitCounter*4);
		result = result/reps;
		string strResult = result.ToString("R");
		Console.WriteLine("-----------------------------");
		Console.WriteLine("Over {1} reps, Pi was estimated as {2}", hitCounter, reps, strResult);
	}

	public static double generateRandomNoFromZero(Random rand, double upperLimit)
	{
		int upperLim = Convert.ToInt32(upperLimit)*100000000;
		int intRandNo = rand.Next(0,(upperLim+1));
		double dblRandomNo = (Convert.ToDouble(intRandNo))/100000000;
		return dblRandomNo;
	}
}