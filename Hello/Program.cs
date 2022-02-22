using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "assaf";
            String s2 = "assaf";

            string s3 = "assaf";
            string s4 = "assaf";
            Console.WriteLine(s==s3);
            Console.WriteLine(s3 == s4);
        }
    }


    namespace hw1 {
        public class Searcher {
            public void GetInt() {
                System.Console.WriteLine("insert text: ");
                String text = Console.ReadLine(); string number = "";
                for (int i = 0; i < text.Length; i++) { if (text[i] >= 48 && text[i] <= 57)
                    { number = number + text[i].ToString(); while (i + 1 < text.Length && text[i + 1] >= 48 && text[i + 1] <= 57)
                        { number += text[i + 1].ToString(); i++; } break; } }
                Console.WriteLine("number is :" + number);
            } } }

}
