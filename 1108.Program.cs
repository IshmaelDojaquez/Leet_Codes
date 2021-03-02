public class Solution 
{
    public string DefangIPaddr(string address) 
    {
        //create a char array to seperate all characters
        char [] IP = address.ToCharArray();
        
        //create List in order to use Add and recreate the address
        List<char> DefangedIP = new List <char>();
        
        //iterate through every character
        foreach (char character in IP)
        {
            if(character == '.')
            {
                DefangedIP.Add('[');
                DefangedIP.Add('.');
                DefangedIP.Add(']');
            }
            else
            {
                DefangedIP.Add(character);
            }
        }
            //change List to a char []
            char [] DefangedIPChar = DefangedIP.ToArray();
            //change array to a string
            string answer = new string(DefangedIPChar);
            return answer;
        
    }
}
