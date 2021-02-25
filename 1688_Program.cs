public class Solution
{
    public int NumberOfMatches(int n)
    {
        //Create counter
        int totalMatches = 0;

        while (n > 1)
        {
            //If matches is an even number
            if (n % 2 == 0)
            {
                n = n / 2;
                totalMatches += n;
            }
            //If matches is an odd number
            else
            {
                n = (n - 1) / 2 + 1;  // Removes player who automatically moves forward and then replaces them inside tournament
                totalMatches += (n - 1); // -1 because there was one player who automatically moved forward
            }
        }
        return totalMatches;
    }
}
