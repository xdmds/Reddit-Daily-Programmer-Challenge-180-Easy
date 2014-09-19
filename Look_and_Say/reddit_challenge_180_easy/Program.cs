/*
 * Author: Derek Leung
 * Description: http://www.reddit.com/r/dailyprogrammer/comments/2ggy30/9152014_challenge180_easy_looknsay/
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reddit_challenge_180_easy
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                int terms = Convert.ToInt32(args[0]);
                int seed = Convert.ToInt32(args[1]);
                Generator g = new Generator(terms, seed);
                g.generate();
                Console.Read();
            }
            else
            {
                Console.WriteLine("Invalid Arguments");
                Console.WriteLine("Usage: Program.cs [number of terms] [seed]");
                Console.ReadLine();
            }
        }
    }
}
