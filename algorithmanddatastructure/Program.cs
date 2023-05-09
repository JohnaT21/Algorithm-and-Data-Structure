// merged of two sorted Arrays

internal class Program
{
    private static void Main(string[] args)
    {
        string originalString = "cbbd";
        string s = "cbbd";
        int length = s.Length;
        int totlength = originalString.Length;
        string resultOne = "";
        string resultTwo = "";
        string resultThree=  "";


        for ( int i = s.Length; i>0; i--)
        {
            s = s.Substring(0, length);
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string result = new string(charArray);
            result = result.Substring(0, length);
           
            /*if (length == 1)
            {
                originalString = originalString.Substring(1);
                s = originalString;
                length = s.Length;

            }
            else
            {*/
                if (result == s)
                {
                resultOne = result;

                   // break;

                }
                else
                {
                    length--;
                }

            //}


          
        }
        for (int i = 0; i < originalString.Length-1; i++)
        {
        
            s = originalString.Substring(i);
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string result = new string(charArray);
            result = result.Substring(i);

            /*if (length == 1)
            {
                originalString = originalString.Substring(1);
                s = originalString;
                length = s.Length;

            }
            else
            {*/
            if (result == s)
            {
                resultTwo = result;

                break;

            }
            else
            {
                length--;
            }

            //}



        }
        for (int i = 0; i < originalString.Length - 1; i++)
        {

            s = originalString.Substring(i,totlength-i);
            char[] charArray = originalString.ToCharArray();
            Array.Reverse(charArray);
            string result = new string(charArray);
            result = result.Substring(i,totlength-i);

            /*if (length == 1)
            {
                originalString = originalString.Substring(1);
                s = originalString;
                length = s.Length;

            }
            else
            {*/
            if (result == s)
            {
                resultThree = result;

                break;

            }
            else
            {
                totlength--;
            }

            //}



        }
        if (resultTwo.Length > resultOne.Length)
        {
            if (resultTwo.Length < resultThree.Length)
            {
                Console.WriteLine("this is two three");
                Console.WriteLine(resultThree);
            }
            else
            {

                Console.WriteLine("this is two");
                Console.WriteLine(resultTwo);
            }

        }
        else
        {
            if(resultOne.Length>resultThree.Length){
                Console.WriteLine("this is one");
            Console.WriteLine(resultOne);
            }
            else
            {
                Console.WriteLine("this is one three");
                Console.WriteLine(resultThree);
            }

        }


    }
}