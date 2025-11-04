public class Solution28Easy
{
    public int StrStr(string haystack, string needle)
    {
        return haystack.IndexOf(needle); //Complexity O(m*n), better solution with KMP algorithm O(m+n)
    }
}