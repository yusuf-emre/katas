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
        // Initialize the longest common prefix to the first string in the list.
        string longestCommonPrefix = strs[0];

        // Loop through the remaining strings in the list.
        for (int i = 1; i < strs.Length; i++)
        {
            // For each string in the list, find the common prefix with the longest common prefix so far.
            // This is done by starting with the longest common prefix and removing characters from the end
            // until the prefix is a prefix of the current string. Indexof returns -1 => If not found 
            while (strs[i].IndexOf(longestCommonPrefix) != 0)
            {
                longestCommonPrefix = longestCommonPrefix.Substring(0, longestCommonPrefix.Length - 1);

                // If the longest common prefix becomes empty, return an empty string.
                if (string.IsNullOrEmpty(longestCommonPrefix))
                {
                    return "";
                }
            }
        }

        // Return the longest common prefix.
        return longestCommonPrefix;
    }

}