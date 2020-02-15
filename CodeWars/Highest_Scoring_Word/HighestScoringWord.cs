using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Highest_Scoring_Word
{
    public static class HighestScoringWord
    {
        public static string High(string s)
        {
            var words = s.Split(' ');
            var highestword = "";
            var highestscore = 0;

            foreach(var word in words)
            {
                var score = 0;
                foreach(var c in word)
                {
                    score += (Convert.ToSByte(c) - 96);
                }
                Console.WriteLine($"{word} : {score}");
                if(highestscore < score)
                {
                    highestscore = score;
                    highestword = word;
                }
            }

            return highestword;
        }
    }
}
