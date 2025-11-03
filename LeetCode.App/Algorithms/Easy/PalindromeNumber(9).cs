public class Solution9Easy
{
    public bool IsPalindrome(int x)
    {

        if (x < 0) { return false; }
        if (x == 0) { return true; }

        int inputNumber = x;
        int modSum = x % 10;
        x /= 10;
        
        while (x > 0)
        {
            modSum = modSum * 10 + x % 10;
            x /= 10;
        }

        if (modSum == inputNumber) { return true; }
        else { return false; }
    }
}