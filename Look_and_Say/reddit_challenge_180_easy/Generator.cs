/*
 * Author: Derek Leung
 * Description: Generates the sequence of Look and Say terms up to the 
 *              Nth term
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reddit_challenge_180_easy
{
    class Generator
    {
        private int N; //number of terms
        private String seed; //the number to start with
        private Dictionary<Char, int> dict;
        private List<String> sequence;

        /*
         * Creates a Generator object
         * 
         * Parameters:
         *  N (int) - the number of terms to generate
         *  seed (int) - the starting number to generate the sequence off of
         */ 
        public Generator(int N, int seed){
            this.N = N;
            this.seed = seed + "";
            this.dict = new Dictionary<char, int>();
            this.sequence = new List<String>();
            this.sequence.Add(this.seed);
        }

        /*
         * Generate the N number of terms of the Look and Say sequence and 
         * print them to the console.
         */ 
        public void generate()
        {
            for (int num = 0; num < N; num++)
            {
                String last_term = sequence[num];
                String term = "";
                if (last_term.Length == 1)
                {
                    sequence.Add("1" + last_term);
                }
                else
                {
                    
                    char prev = last_term[0];
                    dict[prev] = 1;
                    for (int c = 1; c < last_term.Length; c++)
                    {
                        if (last_term[c] == prev)
                        {
                            dict[prev] += 1;
                            prev = last_term[c];
                            if (c == last_term.Length - 1)
                            {
                                term += dict[prev] + Char.ToString(prev);
                                dict.Clear();
                            }
                        }
                        else
                        {
                            term += dict[prev] + Char.ToString(prev);
                            prev = last_term[c];
                            dict.Clear();
                            dict[prev] = 1;
                            if (c == last_term.Length - 1)
                            {
                                term += dict[prev] + Char.ToString(prev);
                                dict.Clear();
                            }
                        }

                    }
                    sequence.Add(term);
                }
                Console.WriteLine(sequence[num]);
            }
        }
    }
}
