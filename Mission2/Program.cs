using System;


namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random roll = new Random();

            // Game Setup
            Console.WriteLine("Welcome to the dice rolling simulator!\n ");
            Console.WriteLine("How many times would you like to roll the dice? ");
            string answer = Console.ReadLine();

            
            int numOfRolls = Convert.ToInt32(answer);


            int[] rolls = new int[numOfRolls];
            int outcome = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;
            int count7 = 0;
            int count8 = 0;
            int count9 = 0;
            int count10 = 0;
            int count11 = 0;
            int count12 = 0;

            // Roll the dice
            for (int iCount = 0; iCount < numOfRolls; iCount++)
            {
                
                //Roll the die
                outcome = roll.Next(1, 7) + roll.Next(1, 7);

                //Console.WriteLine("Roll number: " + (iCount + 1) + " Outcome: " + outcome);


                //Keep track of the rolls
                if (outcome == 2)
                {
                    count2++;
                }
                else if (outcome == 3)
                {
                    count3++;
                }
                else if (outcome == 4)
                {
                    count4++;
                }
                else if (outcome == 5)
                {
                    count5++;
                }
                else if (outcome == 6)
                {
                    count6++;
                }
                else if (outcome == 7)
                {
                    count7++;
                }
                else if (outcome == 8)
                {
                    count8++;
                }
                else if (outcome == 9)
                {
                    count9++;
                }
                else if (outcome == 10)
                {
                    count10++;
                }
                else if (outcome == 11)
                {
                    count11++;
                }
                else
                {
                    count12++;
                }
            }

            // Explain results
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each ' * ' represents 1 % of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numOfRolls +". \n");
            //Use the integers to calculate the percent of times rolled.


            Console.WriteLine("2:  " + new string('*', (count2 * 100/numOfRolls) ));
            Console.WriteLine("3:  " + new string('*', (count3 * 100 / numOfRolls)));
            Console.WriteLine("4:  " + new string('*', (count4 * 100 / numOfRolls)));
            Console.WriteLine("5:  " + new string('*', (count5 * 100 / numOfRolls)));
            Console.WriteLine("6:  " + new string('*', (count6 * 100 / numOfRolls)));
            Console.WriteLine("7:  " + new string('*', (count7 * 100 / numOfRolls)));
            Console.WriteLine("8:  " + new string('*', (count8 * 100 / numOfRolls)));
            Console.WriteLine("9:  " + new string('*', (count9 * 100 / numOfRolls)));
            Console.WriteLine("10: " + new string('*', (count10 * 100 / numOfRolls)));
            Console.WriteLine("11: " + new string('*', (count11 * 100 / numOfRolls)));
            Console.WriteLine("12: " + new string('*', (count12 * 100 / numOfRolls)));

            Console.WriteLine("Thanks for useing the dice simulator today, have a nice day!");
        }
    }
}
