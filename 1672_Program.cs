public class Solution 
{
    public int MaximumWealth(int[][] accounts) 
    {
        {
            //counter for the current largest wealth
            int wealthsum = 0;
            //counter for each accounts sum of wealth
            int savedwealth = 0;
        
            //iterate through all the jth indexes
            for(int i = 0; i <accounts.Length; i++)
            {
                //place the counter here so that it gets tested against other accounts
                savedwealth = 0;
                //go through each ith index
                foreach(int wealth in accounts[i])
                {
                    savedwealth += wealth;
                }
                
                //see if the current account wealth is larger the the previous accounts wealth
                if(savedwealth > wealthsum)
                {
                    wealthsum = savedwealth;
                }
            }
            return wealthsum;
        }
    }
    
}
