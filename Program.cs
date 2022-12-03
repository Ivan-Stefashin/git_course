using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] nums = new int[9]{6,7,54,4,3,20,753,2,4};
int temp;
for (int i = 0; i < nums.Length - 1; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] > nums[j])
        {
            temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
foreach (int i in nums)
    Console.WriteLine(i);
