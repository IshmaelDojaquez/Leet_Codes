public class Solution 
{
    public int DistributeCandies(int[] candyType) 
    {
        //create hashset so nothing in candyType will repeat. This will get us the unique candies
        HashSet<int> candiesList = new HashSet<int>();
        //iterate through candyType
        for (int i = 0; i < candyType.Length; i++)
        {
            candiesList.Add(candyType[i]);
        }
        
        int uniqueCandies = candiesList.Count;
        
        //the maximum number of candies she can eat if  they are all unique
        int maxCandies = candyType.Length / 2;
                
        //if there is more unique candies then total eaten candies she can eat one of each.
        if (uniqueCandies >= maxCandies)
        {
            return maxCandies;
        }
        else
        {
            //else she can only eat one of each unique candy
            return uniqueCandies;  
        }
        
    }
}
