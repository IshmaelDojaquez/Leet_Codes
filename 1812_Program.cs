//bool for answer
        bool answer = true;
        //change to char[]
        char[] coords = coordinates.ToCharArray();
        //iterare through
        for(int i = 0; i < coordinates.Length; i++)
        {
            if(coords[i] == 'a' || coords[i] == 'c' || coords[i] == 'e' || coords[i] == 'g')
            {
                i++;
                if(coords[i] == '2' || coords[i] == '4' || coords[i] == '6' || coords[i] == '8')
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            else if (coords[i] == 'b' || coords[i] == 'd' || coords[i] == 'f' || coords[i] == 'h')
            {
                i++;
                if(coords[i] == '1' || coords[i] == '3' || coords[i] == '5' || coords[i] == '7')
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            else
            {
                answer = false;
            }
        }
        return answer;
