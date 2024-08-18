int[] result = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
Console.WriteLine($"[{result[0]}, {result[1]}]");

int[] result2 = TwoSum(new int[] { 3, 2, 4 }, 6);
Console.WriteLine($"[{result2[0]}, {result2[1]}]");

int[] result3 = TwoSum(new int[] { 3, 3 }, 6);
Console.WriteLine($"[{result3[0]}, {result3[1]}]");

int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> dictCom = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        int result = target - nums[i];

        if (dictCom.ContainsKey(result))
            return new int[] { dictCom[result], i };

        if (!dictCom.ContainsKey(result))
            dictCom[nums[i]] = i;
    }

    return new int[0];
}
