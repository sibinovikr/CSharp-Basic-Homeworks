using System;
using System.Text.RegularExpressions;

namespace SEDC.CSHarp.Homework04._2
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = new String("The&nbsp;&nbsp;&nbsp; best &nbsp;Lorem&nbsp; Ipsum&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" +
                " Generator in all the&nbsp; sea!&nbsp;&nbsp; Heave this &nbsp; scurvy copyfiller fer yar&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" +
                " next&nbsp;&nbsp; adventure&nbsp; and cajol yar clients&nbsp;&nbsp; into walking  the plank with  ev'ry layout!&nbsp;&nbsp;&nbsp; " +
                "Configure&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  above, then get yer pirate ipsum...own the high seas,&nbsp;&nbsp;&nbsp; argh!");
            string s = Regex.Replace(str, @"<(.|\n)*?>", string.Empty);
            s = s.Replace("&nbsp;", " ");
            s = Regex.Replace(s, @"\s+", " ");
            s = Regex.Replace(s, @"\r\n", "\n");
            s = Regex.Replace(s, @"\n+", "\n");
            Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}
