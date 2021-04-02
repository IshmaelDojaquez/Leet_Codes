public class Solution 
{
    public bool IsPerfectSquare(int num) 
    {
        
        //create bool variable for unreachable code
        bool answer = true;
        //loop through every num between 0 and 53000 
        //which is the approximate square root of 2.8 billion
        for (int i = 1; i < 53000; i++)
        {
            //square root is the number * itself
            if ( i * i == num)
            {
                answer = true;
                break;
            }
            else 
            {
                answer = false;                
            }
        }
        return answer;
    }
}
