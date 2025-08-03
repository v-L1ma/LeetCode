namespace LeetCode;

public class ReverseWordsInAString
{
    public string ReverseWords(string s)
    {
        s = s.Trim();

        string[] palavras = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        
        Array.Reverse(palavras);

        return string.Join(" ", palavras);
    }
    
    // Esse foi a primeira tentativa mas ficou com um runtime de 59MS
    
    // public string ReverseWords(string s)
    // { 
    //    string answer = "";
    //
    //    char[] palavras = s.ToCharArray();
    //
    //    int i = palavras.Length-1;
    //    
    //    string palavraAtual = "";
    //
    //    while (i>=0)
    //    {
    //        
    //        if (palavras[i].Equals(' ') && !palavraAtual.Equals(""))
    //        {
    //            answer += Reverse(palavraAtual) + " ";
    //            palavraAtual = "";
    //        }
    //        if (!palavras[i].Equals(' '))
    //        {
    //            palavraAtual += palavras[i];
    //            Console.WriteLine(palavraAtual);
    //        }
    //
    //        if (i==0)
    //        {
    //            answer += Reverse(palavraAtual);
    //            palavraAtual = "";
    //        }
    //        i--;
    //    }
    //
    //    if (answer.EndsWith(" "))
    //    {
    //        return answer.Remove(answer.Length - 1);
    //    }
    //
    //    return answer;
    // }
    //
    // private string Reverse(string s)
    // {
    //     int i = 0;
    //     int j = s.Length-1;
    //
    //     char[] array = s.ToCharArray();
    //
    //     while (i<j)
    //     {
    //         char temp = array[i];
    //         array[i] = array[j];
    //         array[j] = temp;
    //
    //         i++;
    //         j--;
    //     }
    //
    //     return new string(array);
    // }
}