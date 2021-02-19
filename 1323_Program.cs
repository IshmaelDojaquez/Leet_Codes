public class Solution 
{
    public int Maximum69Number (int num) 
    {
    //Turning int n into a string
    string numberstring = num.ToString();
    StringBuilder numberstringbuild = new StringBuilder(numberstring);
            
    //Find the first "6" and change it to a "9"
    int firstsix = numberstring.IndexOf('6');
        
        if (firstsix >= 0)
        {
            //replace 6 with 9
            numberstringbuild[firstsix] = '9'; //stringbuilderformat
            string newnumberstring = numberstringbuild.ToString();
            int newnumber = int.Parse(newnumberstring);
            return newnumber;
        }
        else 
        {
            //keep the number the same
            return num;
        }
    }
}
