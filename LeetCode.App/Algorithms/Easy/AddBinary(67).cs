using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;

public class Solution67Easy
{
    public string AddBinary(string a, string b)
    {
        bool carry = false;
        string sumBin = "";

        if (a.Length < b.Length)
        {
            return AddBinary(b, a);
        }

        int i = a.Length - 1;
        int j = b.Length - 1;

        for (; i >= 0; i--)
        {
            if (j >= 0)
            {
                if (a[i] == '1' && b[j] == '1')
                {
                    if (carry)
                    {
                        sumBin += "1";
                        j--;
                        continue;
                    }
                    carry = true;
                    sumBin += "0";
                    j--;
                    continue;
                }
                if ((a[i] == '1' && b[j] == '0') ||
                    (a[i] == '0' && b[j] == '1'))
                {
                    if (carry)
                    {
                        sumBin += "0";
                        j--;
                        continue;
                    }
                    sumBin += "1";
                    carry = false;
                    j--;
                    continue;
                }
                if (a[i] == '0' && b[j] == '0')
                {
                    if (carry)
                    {
                        sumBin += "1";
                        j--;
                        carry = false;
                        continue;
                    }
                    carry = false;
                    sumBin += "0";
                    j--;
                    continue;
                }
            }
            if ((a[i] == '0' && carry) || (a[i] == '1' && !carry))
            {
                sumBin += "1";
                carry = false;
                continue;
            }
            if (a[i] == '1' && carry)
            {
                sumBin += "0";
                continue;
            }
            if (a[i] == '0' && !carry)
            {
                sumBin += "0";
                carry = false;
                continue;
            }
        }

        StringBuilder reverse = new StringBuilder();

        if (carry) { sumBin += 1; }

        for (int k = sumBin.Length - 1; k >= 0; k--)
        {
            reverse.Append(sumBin[k]);
        }

        return reverse.ToString();
    }
}