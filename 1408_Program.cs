
public class Solution 
{
    public IList<string> StringMatching(string[] words) 
    {
        //Create new list
    List<string> substringList = new List<string>();
        
        //Iterate through substring i
    for(int i = 0; i != words.Length; i++)
    {            
        //Iterate through string j
        for(int j = 0; j != words.Length; j++)
        {               
            //The words in i dont match the words in J AND the words in J contain the words from I
            if(words[i] != words[j] && words[j].Contains(words[i]))
            { 
                //The substring does not contain the words from substring i
                if(!substringList.Contains(words[i]))
                {
                    //Add to the new list
                    substringList.Add(words[i]);
                }                        
            }                
        }
        
    }
    return substringList;
    }
}
