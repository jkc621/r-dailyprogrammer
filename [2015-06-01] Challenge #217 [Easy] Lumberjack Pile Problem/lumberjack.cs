using System;

public class Lumberjack
{
	static void Main()
	{
		Console.WriteLine("Enter the size of the pile");
		int storageSize = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the number of available logs");
		int availableLogs = Convert.ToInt32(Console.ReadLine());
		int storageSizeSquared = storageSize*storageSize;
		
		string testInput = Console.ReadLine();
		string currentPile = "";

		while (testInput!=null)
		{
			currentPile += testInput;
			currentPile += " ";
			testInput = Console.ReadLine();
		}

		currentPile = currentPile.TrimEnd();
		string[] currentPileArrayString = currentPile.Split();
		int[] pileArray = new int[currentPileArrayString.Length];

		for(var i=0; i < currentPileArrayString.Length; i++)
		{
			pileArray[i] = Convert.ToInt32(currentPileArrayString[i]);
		}

		int[] sortedPileArray = pileArray;
		Array.Sort(sortedPileArray);
		int smallestPile = sortedPileArray[0];
		int counter = 1;

		while(counter <= availableLogs)
		{
			Console.WriteLine("Top of While Loop");

			for(var i =0; i < storageSizeSquared; i++)
			{
				Console.WriteLine("Top of for loop");
				// Console.WriteLine("Pass No.{0}", i);

				if (pileArray[i] == smallestPile)
				{
					pileArray[i] = pileArray[i]+1;
					counter = counter + 1;
					Console.WriteLine(counter);
				}
			}

			// Console.WriteLine("Counter- {0}", counter);

			if (counter < availableLogs)
			{
				// Console.WriteLine("Top of if");
				sortedPileArray = pileArray;
				Array.Sort(sortedPileArray);
				smallestPile = sortedPileArray[0];
			}
		}

		for (var i = 0; i<(pileArray.Length+1); i++)
		{
			if(i%storageSize==0)
			{
				Console.WriteLine("{0}", pileArray.Length);
			}
			else
			{
				Console.Write("{0} ", pileArray.Length);
			}
		}

	}
}
