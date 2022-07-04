using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIClient
{
    public class Dmodeltests
    {

        public string s { get; set; }
        public string r { get; set; } 

        private static IEnumerable<string> Ranks()
        {
            yield return "two";
            yield return "three";
            yield return "four";
            yield return "five";
            yield return "six";
            yield return "seven";
            yield return "eight";
            yield return "nine";
            yield return "ten";
            yield return "jack";
            yield return "queen";
            yield return "king";
            yield return "ace";

        }

        public static void Main(string[] arg)
        {
            var startingDeck = (from s in Suits().LogQuery("Suit Generation")
                               from r in Ranks().LogQuery("Rank Generation")
                               select new { Suits = s, Rank = r }).LogQuery("Starting Deck")
                               .ToArray();

            foreach (var card in startingDeck)
            {
                Console.WriteLine(card);
            }
            
            Console.WriteLine();
            var top = startingDeck.Take(26);
            var bottom = startingDeck.Skip(26);
            var shuffle = top.InterleaveSequenceWith(bottom);
            foreach (var c in shuffle)
            {
                Console.WriteLine(c);
            }
            var times = 0;
            shuffle = startingDeck;
            do
            {
                shuffle = shuffle.Take(26).InterleaveSequenceWith(shuffle.Skip(26));
                shuffle = shuffle.Skip(26).LogQuery("Bottom Half").InterleaveSequenceWith(shuffle.Take(26).LogQuery("Top Half")).LogQuery("Shuffle").ToArray();
                foreach (var card in shuffle)
                {
                    Console.WriteLine(card);
                }
                Console.WriteLine();
                times++;

                // In shuffle 
                //shuffle = shuffle.Skip(26).LogQuery("Bottom Half").InterleaveSequenceWith(shuffle.Take(26).LogQuery("Top Half")).LogQuery("Shuffle");
                //foreach (var c in shuffle)
                //{
                //    Console.WriteLine(c);
                //}
                //times++;
            } while (!startingDeck.SequenceEqual(shuffle));
            Console.WriteLine(times);
        }

        public static bool SequenceEquals<T> (this IEnumerable<T> first, IEnumerable<T> second) {
            var firstIter = first.GetEnumerator();
            var secondIter = second.GetEnumerator();
            while (firstIter.MoveNext() && secondIter.MoveNext())
            {
                if (!firstIter.Current.Equals(secondIter.Current))
                {
                    return false;
                }
            }
            return true;
        }
        private static object Suits()
        {
            throw new NotImplementedException();
        }
    }



    
}
