using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            { // Implementing the algorithm to find missing numbers in an array
                int n = nums.Length;
                List<int> result = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    int index = Math.Abs(nums[i]) - 1;
                    if (nums[index] > 0)
                    {
                        nums[index] = -nums[index];
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    if (nums[i] > 0)
                    {
                        result.Add(i + 1);
                    }
                }
                return result; // Returning the list of missing numbers
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            { // Implementing the algorithm to sort an array by parity
                List<int> EvenList = new List<int>();
            List<int> OddList = new List<int>();

            foreach (var num in nums)
            {
                if (num % 2 == 0)
                {
                    EvenList.Add(num);
                }
                else
                {
                    OddList.Add(num);
                }
            }

            EvenList.AddRange(OddList);
            return EvenList.ToArray(); // Returning the sorted array
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            { // Implementing the algorithm to find two sum
                Dictionary<int, int> map = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    int complement = target - nums[i];
                    if (map.ContainsKey(complement))
                    {
                        return new int[] { map[complement], i }; // Returning the indices of two sum
                    }
                    map[nums[i]] = i;
                }
                return new int[0]; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            { // Implementing the algorithm to find maximum product of three numbers
                Array.Sort(nums);
                int n = nums.Length;
                return Math.Max(nums[n - 1] * nums[n - 2] * nums[n - 3], nums[0] * nums[1] * nums[n - 1]); // Returning the maximum product
                return 0; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            { // Implementing the algorithm to convert decimal to binary
                if (decimalNumber == 0) return "0";
                string binary = "";
                while (decimalNumber > 0)
                {
                    binary = (decimalNumber % 2) + binary;
                    decimalNumber /= 2;
                }
                return binary; // Returning the binary number 
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            { // Implementing the algorithm to find minimum in rotated sorted array
                int left = 0, right = nums.Length - 1;
                while (left < right)
                {
                    int mid = left + (right - left) / 2;
                    if (nums[mid] > nums[right]) left = mid + 1;
                    else right = mid;
                }
                return nums[left]; // Returning the minimum element
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            { // Implementing the algorithm to check if a number is palindrome
                if (x < 0 || (x != 0 && x % 10 == 0)) return false;
                int revertedNumber = 0;
                while (x > revertedNumber)
                {
                    revertedNumber = revertedNumber * 10 + x % 10;
                    x /= 10;
                }
                return x == revertedNumber || x == revertedNumber / 10; // Returning if the number is palindrome
                return false; // Placeholder

            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            { // Implementing the algorithm to find fibonacci number
                if (n <= 1) return n;
                int a = 0, b = 1;
                for (int i = 2; i <= n; i++)
                {
                    int c = a + b;
                    a = b;
                    b = c;
                }
                return b; // Returning the fibonacci number
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
