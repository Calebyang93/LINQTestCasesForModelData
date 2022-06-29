using System.Collections.Generic;
using System.IO;

namespace WebAPIClient
{
    public static class ExtensionsBase
    {
        public static IEnumerable<T> InterleaveSequenceWith<T>(this IEnumerable<T> first, IEnumerable<T> second)
        {
            var firstIter = first.GetEnumerator();
            var secondIter = second.GetEnumerator();
            while (firstIter.MoveNext() && secondIter.MoveNext())
            {
                yield return firstIter.Current;
                yield return secondIter.Current;

            }
        }
        public static IEnumerable<T> LogQuery<T>
        (this IEnumerable<T> sequence, string tag)
            {
                // File.AppendText creates a new file if the file doesn't exist.
                using (var writer = File.AppendText("debug.log"))
                {
                    writer.WriteLine($"Executing Query {tag}");
                }

                return sequence;
            }
    }
}