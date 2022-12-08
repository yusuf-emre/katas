public class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            var solution = new Solution();

            Console.WriteLine("Please enter the steps to reach the top..");
            var input = Console.ReadLine();
            if (input == "") break;
            var n = Convert.ToInt32(input);

            Console.WriteLine(solution.ClimbStairs(n));
        }
    }
}

public class Solution
{
    public int ClimbStairs(int n)
    {
        // If there are 0 or 1 steps, there is only 1 way to climb the staircase.

        if (n <= 1)
        {
            return 1;
        }

        // The number of ways to climb the staircase with n steps is equal to the
        // sum of the number of ways to climb the staircase with n - 1 steps
        // and the number of ways to climb the staircase with n - 2 steps (Fibonacci numbers)

        return ClimbStairs(n - 1) + ClimbStairs(n - 2);
    }


    public int ClimbStairsAlternative(int n)
    {
        // Create an array to store the number of ways to climb the staircase for each number of steps.
        int[] ways = new int[n + 1];

        // If there are 1 step, there is only 1 way to climb the staircase.
        // Initialize the array with the base cases (0 and 1 steps).
        ways[0] = 1;
        ways[1] = 1;

        // Loop through the remaining number of steps (from 2 to n).
        for (int i = 2; i <= n; i++)
        {
            // The number of ways to climb the staircase with i steps is equal to the
            // sum of the number of ways to climb the staircase with i - 1 steps (using one step)
            // and the number of ways to climb the staircase with i - 2 steps (using two steps).
            ways[i] = ways[i - 1] + ways[i - 2];
        }

        // Return the number of ways to climb the staircase with n steps.
        return ways[n];
    }

}