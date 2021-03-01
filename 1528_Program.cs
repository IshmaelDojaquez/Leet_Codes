public class Solution 
{
    public string RestoreString(string s, int[] indices) 
    {
        //change s into char []
        char[] word = s.ToCharArray(); // 'c' 'o' 'd' 'e' 'l' 'e' 'e' 't'
        //create char array to length of s
        char [] newword = new char[s.Length]; 
        //fill the new char [] with the index of indices [and the character in the same index of s]
        for (int i =0; i < s.Length; i++)
        {
            newword[indices[i]] = word[i]; //indices index is '4' '5' '6' '7' '0'... making newword index '4' '5' '6' '7' '0'... however the character in that index is from char [] word
        }
        string answer = new string(newword);
        return answer;
    }
}
