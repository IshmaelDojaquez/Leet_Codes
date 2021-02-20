public class Solution 
{
public int UniqueMorseRepresentations(string[] words) 
{
    //string of morseletters
            string[] morsecodeletters = new string[]
            {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."};

    //char for letters
            char[] lettersinalphabet = new char[]
            {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

    // No doubles allowed in Hashset
            HashSet<string> morsestring = new HashSet<string>();

    
            foreach (string word in words)
            {
                char[] wordtochar = word.ToCharArray(); //Turns the word into individual characters
                string morse = "";
                
                foreach (char letter in wordtochar)
                {
                    int index = letter - 'a'; 
                    morse += morsecodeletters[index];
                }
                    morsestring.Add(morse);
            }
    return morsestring.Count();
    }
}
