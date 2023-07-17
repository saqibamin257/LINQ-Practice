using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    public class QueryExpressionBasics
    {
        public int[] Scores = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        
        public void Highscores_DescendingOrder() 
        {
            IEnumerable<int> highScore = from score in Scores
                                         where score > 80
                                         orderby score descending
                                         select score;
            foreach(var s in highScore)
            {
                Console.WriteLine(s);
            }
        }
    }
}
