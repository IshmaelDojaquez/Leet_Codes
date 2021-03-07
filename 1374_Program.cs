public class Solution 
{
    public string GenerateTheString(int n) 
    {
        //if n is even
        if(n % 2 == 0)
        {
            return new String('a', n-1) + 'b';
        }
        //if n is odd
        else
        {
            return new String('a', n);
        }
    }
}
