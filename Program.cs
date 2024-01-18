internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Mission #2 Dice Rolling");
        Console.Write("Enter the number of roles: ");
        int rollCount = int.Parse(Console.ReadLine());


        int[] diceArray = DiceRoll(rollCount);
        // this one will keep track of the number of rolls for a specific number
        int[] histArray = new int[11];
        // this one will keep track of the percentages
        int[] histArray2 = new int[11];

        for (int iCount = 0; iCount < rollCount; iCount++)
        {
            if (diceArray[iCount] == 2)
            {
                histArray[0]++;
            }
            else if (diceArray[iCount] == 3)
            {
                histArray[1]++;
            }
            else if (diceArray[iCount] == 4)
            {
                histArray[2]++;
            }
            else if (diceArray[iCount] == 5)
            {
                histArray[3]++;
            }
            else if (diceArray[iCount] == 6)
            {
                histArray[4]++;
            }
            else if (diceArray[iCount] == 7)
            {
                histArray[5]++;
            }
            else if (diceArray[iCount] == 8)
            {
                histArray[6]++;
            }
            else if (diceArray[iCount] == 9)
            {
                histArray[7]++;
            }
            else if (diceArray[iCount] == 10)
            {
                histArray[8]++;
            }
            else if (diceArray[iCount] == 11)
            {
                histArray[9]++;
            }
            else
            {
                histArray[10]++;
            }
        }

        for (int iCount = 0; iCount < 11; iCount ++)
        {
            histArray2[iCount] = (int)(((double)histArray[iCount] / rollCount) * 100);
        }

        char histChar = '*';

        for (int iCount = 0; iCount < 11; iCount++)
        {
            string histString = new string(histChar, histArray2[iCount]);
            Console.WriteLine($"{iCount + 2}: {histString}");
        }
    }


    private static int[] DiceRoll(int rollCount)
    {
        Random random = new Random();
        
        int[] diceArray = new int[rollCount];

        for (int iCount = 0; iCount < rollCount; iCount++)
        {
            int die0 = random.Next(1, 7);
            int die1 = random.Next(1, 7);

            diceArray[iCount] = die0 + die1;
        }

        return diceArray;
    }
}