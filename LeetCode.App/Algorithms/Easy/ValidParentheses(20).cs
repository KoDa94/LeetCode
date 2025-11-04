using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;


public class Solution20Easy {
    public bool IsValid(string s)
    {
        if (s.Length % 2 != 0)
        {
            return false;
        }

        Dictionary<char, char> mappingChar = new Dictionary<char, char>();

        mappingChar.Add('(', ')');
        mappingChar.Add('{', '}');
        mappingChar.Add('[', ']');

        Stack<char> stack = new Stack<char>();
        int length = s.Length;
        
        for (int i = 0; i < length; i++)
        {
            if (mappingChar.ContainsKey(s[i]))
            {
                stack.Push(s[i]);
                continue;
            }

            if (stack.TryPeek(out char openPar))
            {
                if (s[i] == mappingChar[openPar])
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        return stack.Count == 0 ? true : false;
    }    
}