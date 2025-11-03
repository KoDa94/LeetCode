public class Solution13Easy
{
    public int RomanToInt(string s)
    {
        int number = 0;
        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case 'I':
                    if (i + 1 == s.Length)
                    {
                        number += 1;
                        break;
                    }
                    if (s[i + 1] == 'V')
                    {
                        number += 4;
                        i++;
                        break;
                    }
                    if (s[i + 1] == 'X')
                    {
                        number += 9;
                        i++;
                        break;
                    }
                    number += 1;
                    break;
                case 'V':
                    number += 5;
                    break;
                case 'X':
                    if (i + 1 == s.Length)
                    {
                        number += 10;
                        break;
                    }
                    if (s[i + 1] == 'L')
                    {
                        number += 40;
                        i++;
                        break;
                    }
                    if (s[i + 1] == 'C')
                    {
                        number += 90;
                        i++;
                        break;
                    }
                    number += 10;
                    break;
                case 'L':
                    number += 50;
                    break;
                case 'C':
                    if (i + 1 == s.Length)
                    {
                        number += 100;
                        break;
                    }
                    if (s[i + 1] == 'D')
                    {
                        number += 400;
                        i++;
                        break;
                    }
                    if (s[i + 1] == 'M')
                    {
                        number += 900;
                        i++;
                        break;
                    }
                    number += 100;
                    break;
                case 'D':
                    number += 500;
                    break;
                case 'M':
                    number += 1000;
                    break;
                default: break;
            }
        }

        return number;

    }
}