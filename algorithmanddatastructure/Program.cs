

int[] nums = new int [] {3,2,3};
int target = 6;
int[] result = new int[2];
List<int> termsList = new List<int>();
for (int i = 0; i < nums.Count() - 1; i++)
{
   for (int j = i+1; j < nums.Count(); j++)
    {
        if (nums[i] + nums[j] == target)
        {
            termsList.Add(i);
            termsList.Add(j);
        }
        result = termsList.ToArray();
    }
}
Console.WriteLine(result[0]);
Console.WriteLine(result[1]);
