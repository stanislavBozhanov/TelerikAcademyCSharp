using System;
using System.Threading;
using System.Globalization;

class CoffeMachine
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        decimal[] coins = new decimal[] { 0.05m, 0.10m, 0.20m, 0.50m, 1.00m };
        int[] moneyInMachine = new int[5];
        for (int i = 0; i < 5; i++)
        {
            moneyInMachine[i] = int.Parse(Console.ReadLine());
        }
  
        decimal develeperMoney = decimal.Parse(Console.ReadLine());
        decimal drinkPrice = decimal.Parse(Console.ReadLine());

        if (develeperMoney < drinkPrice)
	    {
		    Console.WriteLine("More {0}", drinkPrice - develeperMoney);
	    }
        else
	    {   
            decimal moneyInTrays = 0;
            for (int i = 0; i < 5; i++)
			{
                moneyInTrays += coins[i] * moneyInMachine[i]; 			 
			}
            decimal change = givenAmount - drinkPrice;
            decimal difference = Math.Abs(moneyInTrays - change);
            if (change <= moneyInTrays)
            {
                Console.WriteLine("Yes {0:F2}", difference);
            }
            else
            {
                Console.WriteLine("No {0:F2}", difference);
            }
	    }
    }

    public static decimal givenAmount { get; set; }
}