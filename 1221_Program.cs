public class Solution 
{
    public int BalancedStringSplit(string s) 
    {
        //Equalizer counter.. Adds the R's and subtracts the L's
        int equalizer = 0;
        //Counter for answer if equalizer is 0
        int answer = 0;
        
        //change to a char []
        char [] word = s.ToCharArray();
        
        foreach(char letter in word)
        {
            if(letter == 'R')
            {
                equalizer++;
            }
            else
            {
                equalizer--;
            }
            
            if(equalizer == 0)
            {
                answer++;
            }
        }
        return answer;
    }
}

//RL    RRLL    RL  RL
//Counter Ls: 5
//Counter Rs: 5
//Equalizer: 4
