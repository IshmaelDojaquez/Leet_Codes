public class Solution 
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) 
    {
        //Grabbing the largest number out of the array
        int max =candies.Max();
        //The question requires a boolean list answer
        List<bool> answer = new List<bool>();
        //variable to set true or false
        bool listanswer;
        //iterate through candies
        foreach(int kid in candies)
        {
            //if the kids number of candies plus the extra candies is greater or equal to the max largest number
            if(kid + extraCandies >= max )
            {
                listanswer = true;
            }
            else
            {
                listanswer = false;
            }
            answer.Add(listanswer);
        }
        return answer;
    }
}
