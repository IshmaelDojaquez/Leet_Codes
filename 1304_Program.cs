public class Solution 
{
    public int[] SumZero(int n) 
    {
        // all unique so usign hashset
        HashSet<int> setofnumbers = new HashSet<int>();
        
        // if even
        if(n % 2 == 0)
        {
            for (int i = 1; i <= n / 2; i++)
            {
                //add number to hashset
                setofnumbers.Add(i);
                // add the negative of that number to hashset
                setofnumbers.Add(i * -1);
            }

        }
        //if negative
        else
        {
            //immediately add 0
            setofnumbers.Add(0);
            // subtract one from n to make it even now
            for (int i = 0; i <= (n-1)/ 2; i++)
            {
                //add number to hashset
                setofnumbers.Add(i);
                //add the negative of that number to hashset
                setofnumbers.Add(i * -1);
            }  
        }
        
        //change to int []
        int [] answer = setofnumbers.ToArray();
        return answer;
    }
}
