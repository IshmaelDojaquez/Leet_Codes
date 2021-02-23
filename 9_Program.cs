public class Solution 
{
    public bool IsPalindrome(int x) 
    {
        string origin = x.ToString();
        char [] reverse = origin.ToCharArray();
        Array.Reverse(reverse);
        string palindrone = new string(reverse);

        if (palindrone == origin)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}
