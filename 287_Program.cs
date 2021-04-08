public class Solution 
{
    public int FindDuplicate(int[] nums) 
    {
        int value = 0;
        int answer = 0;
        Array.Sort(nums);
        
        foreach(int number in nums)
        {
            if (value < number)
            {
                value = number;
            }
            
            else if(value == number)
            {
                answer = value;
            }
            else 
            {
                break;
            }
        }
        return answer;
    }
}
