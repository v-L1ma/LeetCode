namespace LeetCode;
// LeetCode 1071. Greatest Common Divisor of Strings

public class GreatestCommonDivisorOfStrings
{
    public string gcdOfStrings(string str1, string str2)
    {
        if (!(str1 + str2).Equals(str2+str1))
        {
            return "";
        }

        int lenGcd = Gcd(str1.Length, str2.Length);
        return str1.Substring(0, lenGcd);
    }

    private int Gcd(int size1, int size2)
    {
        while (size2!=0)
        {
            int temp = size1 % size2;
            size1 = size2;
            size2 = temp;
        }

        return size1;
    }
}