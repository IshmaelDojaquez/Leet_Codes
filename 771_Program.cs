public class Solution 
{

    public int NumJewelsInStones(string jewels, string stones) 
    {
        
    //create arrays
        char [] charjewels = jewels.ToCharArray();
        char [] charstones = stones.ToCharArray();
        
        //Counter
        int answer  = 0;
        
        //iterate through stones
        for (int i = 0; i < charstones.Length; i++)
        {
            //iterate through jewels
            for (int j = 0; j < charjewels.Length; j++)
            {
                //match any matching indexes
                if (charjewels[j] == charstones[i])
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}
