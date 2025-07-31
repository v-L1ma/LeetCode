// See https://aka.ms/new-console-template for more information

int[] nums = new []{1,1,1,2,2,3};
int k = 2;

Dictionary<int, int> top = new Dictionary<int, int>();

for(int i=0; i<nums.Length;i++)
{
    if (top.ContainsKey(nums[i]))
    {
        top[nums[i]] += 1;
    }
    else
    {
        top.Add(nums[i], 1);
    }
}

var freq = 

nums = freq.ToArray();
