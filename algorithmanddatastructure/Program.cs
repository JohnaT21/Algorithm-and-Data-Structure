// See https://aka.ms/new-console-template for more information
List<int> arr = new List<int> { 769082435, 210437958, 673982045, 375809214, 380564127 };

long maxSum = 0;
long minSum = 0;

int temp;

// traverse 0 to array length
/*for (int i = 0; i < arr.Count - 1; i++)

    // traverse i+1 to array length
    for (int j = i + 1; j < arr.Count; j++)

        // compare array element with
        // all next element
        if (arr[i] < arr[j])
        {

            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }*/

arr.Sort();


// print all element of array


for (int j = 0; j < arr.Count-1; j++)
{
    minSum = minSum + arr[j];
}
for (int j = 1; j < arr.Count; j++)
{
    maxSum = maxSum + arr[j];
}

Console.Out.Write(minSum + " " + maxSum);



List<int> candles = new List<int> { 3  , 2, 1, 3 };

/*int temp;
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
int count = candles.Count(x=>x==num);
Console.WriteLine(count);

List<int> list = new List<int> { 5, 7, 3 };
list.Sort();
foreach (int x in list)
{
    Console.WriteLine(x);
}*/
