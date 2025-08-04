namespace LeetCode;

public class ProductOfArrayExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] answer = new int[n];

        int prefix = 1;
        for (int i = 0; i < n; i++)
        {
            answer[i] = prefix;
            prefix *= nums[i];
            Console.WriteLine(answer[i]);
        }

        int suffix = 1;
        for (int i = n-1; i >= 0; i--)
        {
            answer[i] *= suffix;
            suffix *= nums[i];
            Console.WriteLine(answer[i]);
        }

        return answer;
    }
}