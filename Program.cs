using System;
using System.Diagnostics.Metrics;

namespace LooneyList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> members = new List<string> { "Bugs", "Daffy", "Porky", "Lola", "Speedy" };

            string[] memberArr = new string[] { "Tweety", "Sylvester", "Tina" };
            members.AddRange(memberArr);

            members.Sort();
            Console.WriteLine("-------Ascending--------");
            foreach (string m in members)
                Console.WriteLine(m);

            members.Remove("Sylvester");

            members.Reverse();
            Console.WriteLine("-------Descending--------");
            foreach (string m in members)
                Console.WriteLine(m);


        }
    }
}