using System;
using System.Data;

public class Recurrence
{
	static void Main()
	{
		Console.WriteLine("Enter the required expression");

		string baseExpression = Console.ReadLine();
		Console.WriteLine("Expression : " + baseExpression);
		Console.WriteLine("Starting value : ??");
		Console.WriteLine("Term Number : ??");
		Console.WriteLine("");

		Console.WriteLine("Good, now enter the starting value");
		int startValue = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Expression : " + baseExpression);
		Console.WriteLine("Starting value : " + startValue.ToString());
		Console.WriteLine("Term Number : ??");
		Console.WriteLine("");

		Console.WriteLine("And finally, enter the term number");
		int termValue = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Expression : " + baseExpression);
		Console.WriteLine("Starting value : " + startValue.ToString());
		Console.WriteLine("Term Number : " + termValue.ToString());
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("");

		string[] operations = baseExpression.Split();
		baseExpression = operations[0];

		int recursionCounter = 0;
		string expression = startValue.ToString()+baseExpression;
        double result = startValue;
		Console.WriteLine("Term {0}: {1}", recursionCounter, result);
		recursionCounter++;

		while(recursionCounter<=termValue)
		{
			for(var i=0; i < operations.Length; i++)
			{
				expression = result.ToString() + operations[i];
				result = Convert.ToDouble(new DataTable().Compute(expression,null));					
			};
			Console.WriteLine("Term {0}: {1}", recursionCounter, result);
			recursionCounter++;
		}
	}

}