public class Solution58Easy
{
    public int LengthOfLastWord(string s)
    {
        s = s.TrimEnd();
        int i = 0;
        int j = s.Length - 1;

        while (s[j] != ' ')
        {
            i++;
            if (j == 0)
            {
                return i;
            }
            j--;
        }

        return i;
    }
}