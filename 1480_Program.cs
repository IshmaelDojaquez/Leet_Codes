public class Solution 
{
    public int[] RunningSum(int[] nums) 
    {
        //initiate a spot to add values
        int sum = 0;
        //create a new int array
        int[] sumResult = new int[nums.Length]; 
        //for each index of nums.length
            for (int i = 0; i < nums.Length; i++) 
            {
                //sum = sum + each value in array nums
                sum += nums[i]; 
                // create an int array of each sum
                sumResult[i] = sum;
            }
        //return array
        return sumResult;
    }
}
