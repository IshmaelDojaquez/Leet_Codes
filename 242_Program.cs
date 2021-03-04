public class Solution 
{
    public bool IsAnagram(string s, string t) 
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        
        //change strings to char [] arrays
        char [] firstword = s.ToCharArray();
        char [] secondword = t.ToCharArray();
        //sort both arrays from 'a' to 'z'
        Array.Sort(firstword);
        Array.Sort(secondword);
        
        bool answer = true;
        //iterate through firstword [i] and secondword [i]
        for(int i = 0; i < firstword.Length; i++)
        {
            if(firstword[i] == secondword[i])
            {
                answer = true;
            }
            else 
            {
                answer = false;
                break;
            }
        }
        return answer;
    }
}
