using System;

namespace SEDC.CSHarp.Homework04._01
{
    class Program
    {
        public static void FunWithStrings(string str)
        {
            char[] chars = str.ToCharArray();
            char[] result = new char[chars.Length];
            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
            {
                result[i] = chars[j];
            }
            Console.WriteLine(result);
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'o' || str[i] == 'e' || str[i] == 'u' || str[i] == 'i' || str[i] == 'A' || str[i] == 'O' || str[i] == 'U' || str[i] == 'E' || str[i] == 'I')
                {
                    counter++;
                }
            }
            Console.WriteLine("The number of vowels is : " + counter);
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            string rev;
            rev = new string(ch);
            bool b = str.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine("The string is palindrome");
            }
            else
            {
                Console.WriteLine("The string is not palindrome");
            }

            string[] words = str.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            int ctr2 = 99999999;
            string word2 = "";
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }
            foreach (String s in words)
            {
                if (s.Length < ctr2)
                {
                    word2 = s;
                    ctr2 = s.Length;
                }
            }
            Console.WriteLine("The largest word in this string is : " + word);
            Console.WriteLine("The smallest word in this string is : " + word2);
            int counterWords = 0;
            foreach (String s in words)
            {
                counterWords++;
            }
            Console.WriteLine("The string have : " + counterWords + " words ");

            int[] ch_fre = new int[255];
            int ii = 0, max = 0;
            int l = str.Length;
            int ascii;
            for (ii = 0; ii < 255; ii++)
            {
                ch_fre[ii] = 0;

            }
            ii = 0;
            while (ii < l)
            {
                ascii = (int)str[ii];
                ch_fre[ascii] += 1;
                ii++;
            }
            max = 0;
            for (ii = 0; ii < 255; ii++)
            {
                if (ii != 32)
                {
                    if (ch_fre[ii] > ch_fre[max])
                    {
                        max = ii;
                    }
                }
            }
            Console.WriteLine("The most used character is : " + (char)max);


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            string str = Console.ReadLine();
            FunWithStrings(str);

            Console.ReadLine();

        }
    }
    
}
