

int[] nums = new int [] { 1, 2, 3, 4 };
bool result = false;
List<int> list = new List<int>();
list = nums.ToList();
/*foreach (var item in nums)

{*/
if (list.Count != list.Distinct().Count())
{
    result = true;
}

Console.WriteLine(result);
