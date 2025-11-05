using System.Globalization;

public class Solution66Easy
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] != 9)
            {
                digits[i] += 1;

                return digits;
            }
            else
            {
                digits[i] = 0;
            }
        }

        int[] newDigits = new int[digits.Length + 1];
        newDigits[0] = 1;

        for (int i = 1; i < newDigits.Length; i++)
        {
            newDigits[i] = digits[i - 1];
        }

        return newDigits;  
    }
}