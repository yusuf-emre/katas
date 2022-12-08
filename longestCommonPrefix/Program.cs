public class Program
{
    static void Main(string[] args)
    {
        var solution = new Solution();

        string[] strArr = {"flower","flow","flight"};
        Console.WriteLine(solution.LongestCommonPrefix(strArr));
    }
}

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string longestCommonPrefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(longestCommonPrefix) != 0)
            {
                longestCommonPrefix = longestCommonPrefix.Substring(0, longestCommonPrefix.Length - 1);

                if (string.IsNullOrEmpty(longestCommonPrefix))
                {
                    return "";
                }
            }
        }
        return longestCommonPrefix;
    }

}