using System;

public class UpperAndLower
{
    public string solution(string my_string)
    {
        string answer = "";
        var sbLetter = new StringBuilder();
        foreach (var c in my_string)
        {
            if (Char.IsLower(c))
            {
                ;
                sbLetter.Append(Char.ToUpper(c));
            }
            else
            {
                ;
                sbLetter.Append(Char.ToLower(c));
            }
        }
        answer = sbLetter.ToString();


        return answer;
    }
}
