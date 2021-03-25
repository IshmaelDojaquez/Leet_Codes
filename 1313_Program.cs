public class Solution 
{
    public int[] DecompressRLElist(int[] nums)
    {
        //Create list to add values too
        List<int> answer = new List<int>();
        //Iterate through nums
        for (int i = 0; i < nums.Length - 1; i++)
        {
            //Only if the value is a val [even numbers]
            if (i % 2 == 0)
            {
                //Iterate through nums [one index shorter] but only to the length wherever the                     val is even [0,2,4,6..]
                for (int j = 1; j <= nums[i]; j++)
                {
                    //Add the even number to the list
                    answer.Add(nums[i+1]);
                }
            }
        }
        //change list to int[]
        return answer.ToArray();
    }
}
