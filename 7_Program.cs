public class Solution 
{
    public int Reverse(int x) 
    {
       {
           //Positive numbers
            if (x >= 0)
            {
                int reverse = ProblemSolver(x);
                return reverse;
            }
            else
                //Negative numbers get turned positive... used in method... turned negative again
            {
                x *= -1;
                int reverse = ProblemSolver(x);
                reverse *= -1;
                return reverse;
            }
        }

         static int ProblemSolver(int x)
        {
            //Change int to string
            string InttoString = x.ToString();
            //Change string to char []
            char[] StringtoChar = InttoString.ToCharArray();
            //Reverse array
            Array.Reverse(StringtoChar);
            //String to int
            if (int.TryParse(StringtoChar, out int reverse))
            {
                return reverse;
            }
            else
            {
                return 0;
            }
        }
    }
}
