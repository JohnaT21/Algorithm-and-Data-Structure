



List<int> candles = new List<int> { 3  , 2, 1, 3 };

int temp;
for (int i = 0; i < candles.Count - 1; i++)
{
    for (int j = i + 1; j < candles.Count; j++)
    {
        if (candles[i] < candles[j])
        {
            temp = candles[i];
            candles[i] = candles[j];
            candles[j] = temp;
        }
    }
}
int num = candles.FirstOrDefault();
int count = candles.Count(x => x == num);
Console.WriteLine(count);

List<int> list = new List<int> { 5, 7, 3 };
list.Sort();
foreach (int x in list)
{
    Console.WriteLine(x);
}
