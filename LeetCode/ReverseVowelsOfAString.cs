namespace LeetCode;

public class ReverseVowelsOfAString
{
    public string ReverseVowels(string s) {
        // "IceCreAm"
        // "AceCreIm"
        char[] array = s.ToCharArray();
        int cont = 0;
        int size = array.Length-1;
        HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        
        while (cont<size)
        {
            while (cont<size && vowels.Contains(array[cont])==false)
            {
                cont++;
            }
            
            while (cont<size && vowels.Contains(array[size])==false)
            {
                size--;
            }
            
            var temp = array[cont];
            array[cont] = array[size];
            array[size] = temp;
            cont++;
            size--;
        }

        return new string(array);
    }
}