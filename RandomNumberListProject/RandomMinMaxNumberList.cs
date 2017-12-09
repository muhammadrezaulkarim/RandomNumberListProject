/* Author: Muhammad Rezaul Karim
 * Date: December 07, 2017
 */
using System;
using System.Collections;

namespace RandomNumberListProject
{
    public class RandomMinMaxNumberList
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("Please enter lower limit (press 'enter' to use the default value 1):");
            string input = Console.ReadLine();

            int lowerLimit = 0;
          //read lower limit
            if (!input.Trim().Equals(""))
                lowerLimit = int.Parse(input);   // if user entered a number, parse it
            else
                lowerLimit = 1; // if user did not enter a number, set lower limit to the default value

            Console.Write("Please enter upper limit (press 'enter' to use the default value 10000):");
            input = Console.ReadLine();
            
            //read upper limit
            int upperLimit = 0;
            if (!input.Trim().Equals(""))
               upperLimit = int.Parse(input);  // if user entered a number, parse it
            else
               upperLimit = 10000; // if user did not enter a number, set upper limit to the default value

            Console.Write("Please enter total numbers to be generated (press 'enter' to use the default value 10000):");
            //read total numbers to be generated
            input = Console.ReadLine();
            int totalNumbers = 0;
            if (!input.Trim().Equals(""))   // if user entered a number, parse it
                totalNumbers = int.Parse(input);
            else
                totalNumbers = 10000;  // if user did not enter a number, set total numbers to the default value

            Console.WriteLine();
            //check whether upperLimit greater than lowerLimit
            if (lowerLimit >= upperLimit)
            {
                Console.WriteLine("Error: Lower limit must be less than upper limit.");
                Console.WriteLine("Press any key to quit...");
                Console.ReadKey();
                return;
            }

            //check whether total numbers less than equal to upper limit
            if (totalNumbers > upperLimit)
            {
                Console.WriteLine("Error: Total numbers must be less than or equal to upperLimit.");
                Console.WriteLine("Press any key to quit...");
                Console.ReadKey();
                return;
            }

            int[] finalNumberArray = null;
            // keep track when the number generation started
            DateTime startTime = DateTime.Now;
           finalNumberArray=GenerateRandomListHashTableBased(lowerLimit, upperLimit, totalNumbers);
          // finalNumberArray=GenerateRandomListArrayListBased(lowerLimit, upperLimit, totalNumbers);

            // keep track when the number generation finished. 
            DateTime endTime = DateTime.Now;
            TimeSpan elapsedTime = endTime.Subtract(startTime);

            printListOfNumbers(finalNumberArray);

            Console.WriteLine();
            Console.WriteLine("Time taken to generate (in seconds):" + elapsedTime.TotalSeconds);

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

      public static int [] GenerateRandomListHashTableBased(int lowerLimit, int upperLimit, int totalNumbers)
        {
            // store generated numbers
            Hashtable alreadyGeneratedNumbers = new Hashtable();
            //using a time-dependent default seed value to produce different sequences of random numbers
            Random rnd = new Random();
            int[] finalNumberArray = new int[totalNumbers];
            int tempNum = -1;

            for (int count = 0; count < totalNumbers;)
            {
                //generate a random number between the lower and upper limit (inclusive)
                tempNum = rnd.Next(lowerLimit, upperLimit + 1);

                // If already not generated, consider the generated number for storing
                if (!alreadyGeneratedNumbers.Contains(tempNum))
                {
                    // store in the hash table
                    alreadyGeneratedNumbers.Add(tempNum, 1);
                    // store in the static array
                    finalNumberArray[count] = tempNum;
                    count++;
                }

            }

            return finalNumberArray;
         

        }
        
     /*  public static int [] GenerateRandomListArrayListBased(int minLimit, int maxLimit, int totalNumbers)
        {
   
            ArrayList alreadyGeneratedNumbers = new ArrayList();
            //using a time-dependent default seed value to produce different sequences of random numbers
            Random rnd = new Random();

            int tempNum = -1;
            int[] finalNumberArray = new int[totalNumbers];

            for (int count = 0; count < totalNumbers;)
            {
                //generate a random number between the lower and upper limit (inclusive)
                tempNum = rnd.Next(minLimit, maxLimit + 1);
                
                // If already not generated, consider the generated number for storing
                if (!alreadyGeneratedNumbers.Contains(tempNum))
                {
                    // store in a array list object
                    alreadyGeneratedNumbers.Add(tempNum);
                    // store in a static array
                    finalNumberArray[count] = tempNum;
                    count++;
                }

            }

            return finalNumberArray; 

        } */

        public static void printListOfNumbers(int[] finalNumberArray)
        {
            for (int i = 0; i < finalNumberArray.Length; i++)
            {
                Console.Write(finalNumberArray[i] + " ");
                // display 15 numbers per line
                if (i>0 && (i % 15 == 0))
                    Console.WriteLine();
            }

            Array.Sort(finalNumberArray); // sort the numbers in ascending order
            Console.WriteLine();
            Console.WriteLine();
            // Check the output
            //Minimum among the generated numbers
            Console.WriteLine("Minimum value(among generated numbers): " + finalNumberArray[0]);
            //Maximum among the generated numbers
            Console.WriteLine("Maximum value(among generated numbers): " + finalNumberArray[finalNumberArray.Length-1]);
            //Total generated numbers
            Console.Write("Total generated numbers: " + finalNumberArray.Length);
        }
    }
}
