public class Solution 
{
    public int FindPeakElement(int[] nums)
    {
        //find the largest value
        int peak = nums.Max();
        //convert to a list and find the index of the largest value
        int index = nums.ToList().IndexOf(peak);
        return index;
    }
}
