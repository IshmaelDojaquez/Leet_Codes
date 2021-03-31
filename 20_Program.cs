public class Solution 
{
    public bool IsValid(string s) 
    {
        //Fast Fail
        if (s.Length % 2 != 0)
        {
            return false;
        }
        
        //Create a stack
        Stack<int> test = new Stack<int>();
        
        //iterate through s
        foreach(char character in s)
        {
            if(character == '{' || character == '[' || character == '(')
            {
                test.Push(character);
            }
            else if(character == '}')
            {
                if(test.Count() == 0)
                {
                    return false;
                }
                else if (test.Peek() != '{')
                {
                    return false;
                }
                else
                {
                    test.Pop();
                }
            }
            else if(character == ']')
            {
                if(test.Count() == 0)
                {
                    return false;
                }
                else if (test.Peek() != '[')
                {
                    return false;
                }
                else
                {
                    test.Pop();
                }
            }
            else if(character == ')')
            {
                if(test.Count() == 0)
                {
                    return false;
                }
                else if (test.Peek() != '(')
                {
                    return false;
                }
                else
                {
                    test.Pop();
                }
            }
            else
            {
                return false;
            }
        }

        //check for count
        if(test.Count() == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
