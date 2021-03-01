public class Solution 
{
    public int[] Shuffle(int[] nums, int n) 
    {
        //counter to determine index
        int count = 0;
        //new array the size of nums.length
            int[] answer = new int[nums.Length];
        //iterate through i [index 0] and j [index n [halway point]] until i reaches n [the halway point]
            for (int i = 0, j = n; i<n;  i++, j++)
            {
                answer[count++] = nums[i];
                answer[count++] = nums[j];
            }
        //return answer
            return answer;
    }
}
