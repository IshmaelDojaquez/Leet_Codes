public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        //create array answer to the length of nums
        int[] answer = nums;
        //iterate through int array nums
         for (int i = 0; i < nums.Length; i++)
        {
             //iterate through the same array but starting at an index ahead of the last array
          for(int j = i + 1; j < nums.Length; j++)
          {
              //if the two numbers from the two different arrays = target number
                 if(nums[i] + nums[j] == target)
                 {
                     //create a new array equal to the values from the first run of array nums and second run of array nums
                     int[] sumValues = new int[]{i, j};
                     answer = sumValues;
                 }
          }
        }
        return answer;
    }
}
