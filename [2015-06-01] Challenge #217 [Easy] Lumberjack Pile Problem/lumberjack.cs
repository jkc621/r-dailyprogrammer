using System;
using System.IO;

public class Lumberjack
{
	static void Main(string[] args)
	{
		string testInput = "";
		string currentPile = "";
		
		var path = args[0];
		if (File.Exists(path))
		{
			System.IO.StreamReader file = new System.IO.StreamReader(path);
			testInput = file.ReadLine();

			while (testInput!=null)
			{
				currentPile += testInput;
				currentPile += " ";
				testInput = file.ReadLine();
			}
		}

		Console.WriteLine("Enter the size of the pile");
		int storageSize = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the number of available logs");
		int availableLogs = Convert.ToInt32(Console.ReadLine());
		int storageSizeSquared = storageSize*storageSize;

		currentPile = currentPile.TrimEnd();
		char[] delimiters = {' ','\t'};
		string[] currentPileArrayString = currentPile.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
		int[] pileArray = new int[currentPileArrayString.Length];

		for(var i=0; i < currentPileArrayString.Length; i++)
		{
			pileArray[i] = Convert.ToInt32(currentPileArrayString[i]);
		}

		int[] sortedPileArray = new int[storageSizeSquared];
		int smallestPile = 0;
		int counterLogsDropped = 0;


		while(counterLogsDropped < availableLogs)
		{
			smallestPile ++; //smallest pile only grew by 1?

			for(var z =0; z < storageSizeSquared; z++)
			{
				if(counterLogsDropped == availableLogs)
				{
					break;
				}
				if (pileArray[z] == smallestPile)
				{
					pileArray[z] = pileArray[z]+1;
					counterLogsDropped = counterLogsDropped + 1;
				}
			}
		}


		Console.WriteLine(" ");
		Console.WriteLine("--- Output ---");

		for (var i = 0; i<(pileArray.Length); i++)
		{
			int r = i + 1;

			if(r % storageSize == 0)
			{
				Console.WriteLine("{0}", pileArray[i]);
			}
			else
			{
				Console.Write("{0} ", pileArray[i]);
			}
		}

	}
}
