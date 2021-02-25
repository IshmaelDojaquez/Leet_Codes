public class Solution 
{
    public bool IsPalindrome(int x) 
    {
        //int to string
        string origin = x.ToString();
        //string to char []
        char [] reverse = origin.ToCharArray();
        //reverse of char []
        Array.Reverse(reverse);
        //new string from reverse of char []
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
