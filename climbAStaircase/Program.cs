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
        if (n <= 1)
        {
            return 1;
        }
        return ClimbStairs(n - 1) + ClimbStairs(n - 2);
    }


    public int ClimbStairsAlternative(int n)
    {
        int[] ways = new int[n + 1];
     
        ways[0] = 1;
        ways[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            ways[i] = ways[i - 1] + ways[i - 2];
        }
        return ways[n];
    }

}