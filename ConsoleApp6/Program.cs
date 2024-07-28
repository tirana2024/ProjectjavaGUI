using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Dictionary<string,string> dict = new Dictionary<string,string>();
            dict.Add("Artion", "23");
            dict.Add("ani", "23");
            dict.Add("eriselda", "23");
            dict.Add("kei", "20");

            string keyValue = dict["ani"];
            Console.WriteLine(keyValue);


        }
    }
