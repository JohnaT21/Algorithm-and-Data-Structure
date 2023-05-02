// merged of two sorted Arrays

internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums1 =new int[] {};
        int[] nums2 = new int[] { 1, 2, 3, 4, 5 };
        List<int> listNums1 = new List<int>();
        List<int> listNums2 = new List<int>();

        listNums1 = nums1.ToList();
        listNums2 = nums2.ToList();
        listNums1.AddRange(listNums2);
        listNums1.Sort();
        double sum = 0;
        double length = listNums1.Count;
        double sum2 = 0.00;
        double i = length / 2;
        if(length%2 == 0)
        {
            int j = (int)i;  
            sum = listNums1[j - 1] + listNums1[j];
            sum2 = sum / 2;

        }
        else
        {
            int j = (int)(i);
            Console.WriteLine(j);
            if(j > 0)
            {
                sum2 = listNums1[j];
            }
            else
            {
                sum2 = listNums1[j];
            }
            //sum2 = listNums1[j - 1];

        }
        
        /* Consol/*e.WriteLine(sum);
        Console.WriteLine(length);
        */
        
        Console.WriteLine($"{sum2}");
    }
}