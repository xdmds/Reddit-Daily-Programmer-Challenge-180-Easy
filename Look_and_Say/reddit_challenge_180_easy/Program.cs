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

            Generator g = new Generator(6, 1);
            g.generate();
            Console.Read();
        }
    }
}
