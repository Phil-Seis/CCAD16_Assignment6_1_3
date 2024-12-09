//Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
//Note that you must do this in-place without making a copy of the array.
//LeetCode 283 (Move Zeroes)

namespace CCAD16_Assignment6_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0, 3, 12 }; //array of integers declared
            Console.WriteLine($" Your original array is: {string.Join(", ", nums)}");

            Program program = new Program(); //instance created
            program.MoveZeroes(nums); //calling method MoveZeroes

            Console.WriteLine($"\n Your corrected array is: {string.Join(", ", nums)}"); //print out corrected array
        }

        public void MoveZeroes(int[] nums)
        {
            int count = 0; // Pointer initialized to place the next non-zero element (count)

            // Iterate through the array
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0) // If current element is NOT a '0' 
                {
                    nums[count] = nums[i]; // Current element is moved to nums[j] pointer location
                    count++; // Increment index of J
                }
            }

            // Fill the rest of the array with 0's
            for (int i = count; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
