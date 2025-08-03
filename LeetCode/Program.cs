// See https://aka.ms/new-console-template for more information

using LeetCode;

// int[] nums = new []{1,1,1,2,2,3};
// int k = 2;
//
// Dictionary<int, int> top = new Dictionary<int, int>();
//
// for(int i=0; i<nums.Length;i++)
// {
//     if (top.ContainsKey(nums[i]))
//     {
//         top[nums[i]] += 1;
//     }
//     else
//     {
//         top.Add(nums[i], 1);
//     }
// }

// GreatestCommonDivisorOfStrings ex1071 = new GreatestCommonDivisorOfStrings();
// ReverseVowelsOfAString ex345 = new ReverseVowelsOfAString();
ReverseWordsInAString ex151 = new ReverseWordsInAString();

// string answer = ex1071.gcdOfStrings("ABABAB", "ABAB");

// string answer = ex345.ReverseVowels("IceCreAm");

string answer = ex151.ReverseWords("  hello world  ");
Console.Write("resposta: " + answer);
