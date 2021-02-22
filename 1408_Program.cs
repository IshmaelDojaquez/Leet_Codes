

public class Solution 
{
    public IList<string> StringMatching(string[] words) 
    {
        //Create new hashset
    HashSet<string> substring = new HashSet<string>();
        
        //Iterate through substring i
    for(int i = 0; i != words.Length; i++)
    {            
        //Iterate through string j
        for(int j = 0; j != words.Length; j++)
        {               
            //The words in i dont match the words in J AND the words in J contain the words from I
            if(words[i] != words[j] && words[j].Contains(words[i]))
            { 
                //Add to the new list
                substring.Add(words[i]);                      
            }                
        }
        
    }
        //turn into list
    List<string> answer = substring.ToList();
    return answer;
    }
}
