using System;

namespace Whiteboard_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running sum of a 1D array:");             //running sum of a 1D array
            int[] numbers1 = { 1, 2, 3, 4 }; //should return 10
            RunningSum(numbers1);
            int[] numbers2 = { 19, 34, 12, -70 }; //should return -5
            RunningSum(numbers2);
            int[] numbers3 = { 40, 30, 20, 9 }; //should return 99
            RunningSum(numbers3);
            Console.WriteLine("");
            Console.WriteLine("From a given array, find the three largest values and sort them without array.sort()"); //print three largest array values without array.sort()
            int[] random1 = { 7, -14, 12, 0, -1, 49, -17, 25000 }; //should return 12, 49, 25000
            largestThree(random1);
            int[] random2 = { 7, 7, 8, 8 }; //should return 7, 8, 8
            largestThree(random2);
            int[] random3 = { 7 }; //should return "Insufficient array length"
            largestThree(random3);
            int[] random4 = { -2, 7, -94 }; //should return -94, -2, 7
            largestThree(random4);
            int[] random5 = { -5, -7, -19, -4}; //should return -7, -5, -4
            largestThree(random5);
        }

        static int RunningSum(int[] nums)
        {
            int total = nums[0];
            int[] runningSum = new int[nums.Length];
            runningSum[0] = nums[0];
            Console.WriteLine($"Starting sum = {total}");
            for (int i = 1; i < nums.Length; i++)
            {
                runningSum[i] = runningSum[i - 1] + nums[i];
                Console.WriteLine($"runningSum[i] = runningSum[i - 1]({runningSum[i - 1]}) + nums[i]({nums[i]}) = {runningSum[i]}");
                total += nums[i];
            }
            Console.WriteLine($"Final total: {total}");
            Console.WriteLine("");
            return total;
        }

        static int[] largestThree(int[] three)
        {
            //Array.Sort(three);
            if (three.Length < 3)
            {
                Console.WriteLine("Insufficient array length.");
                return three;
            }
            //int[] largestThree = new int[3];
            int[] largestThree = new int[] { Int32.MinValue, Int32.MinValue,  Int32.MinValue, };
            //largestThree[2] = three[0];
            for (int i = 0; i < three.Length; i++)
            {
                if (largestThree[2] < three[i])
                {
                    largestThree[0] = largestThree[1];
                    largestThree[1] = largestThree[2];
                    largestThree[2] = three[i];
                }
                else if (largestThree[1] < three[i])
                {
                    largestThree[0] = largestThree[1];
                    largestThree[1] = three[i];
                }
                else if (largestThree[0] < three[i])
                {
                    largestThree[0] = three[i];
                }
            }
            Console.WriteLine($"Largest three values from array: {largestThree[0]}, {largestThree[1]}, {largestThree[2]}");
            return largestThree;
        }
    }
}