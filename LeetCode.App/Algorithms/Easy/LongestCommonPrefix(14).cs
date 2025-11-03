using System.Security.Cryptography.X509Certificates;

public class Solution14Easy
{
    public string LongestCommonPrefix(string[] strs)
    {
        int minLength = strs.Min(y => y.Length); //using Lambda expression
        int allSubstring = 0;
        string substring = "";

        for (int i = 0; i < minLength; i++)
        {
            for (int j = 1; j < strs.Length; j++)
            {
                if (strs[0][i] == strs[j][i])
                {
                    allSubstring++;
                }
            }

            if (allSubstring + 1 == strs.Length)
            {
                substring += strs[0][i];
            }
            else
            {
                break;
            }

            allSubstring = 0;
        }

        return substring;
    }
}