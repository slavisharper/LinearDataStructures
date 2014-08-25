namespace NumbersOccurenceCount
{
    using System.Collections.Generic;

    /// <summary>
    /// Class that counts how many times an object is met in 
    /// a given collection. 
    /// </summary>
    public static class OccurancesCounter
    {
        /// <summary>
        /// Counts how many times an object is met in a given collection. 
        /// </summary>
        /// <typeparam name="T">Type contained in the collection</typeparam>
        /// <param name="collection">Collection for counting</param>
        /// <returns>Dictionary with the object as key and occurance count as value</returns>
        public static Dictionary<T, int> GetCounts<T>(ICollection<T> collection)
        {
            Dictionary<T, int> counts = new Dictionary<T, int>();

            foreach (var item in collection)
            {
                if (counts.ContainsKey(item))
                {
                    counts[item]++;
                }
                else
                {
                    counts.Add(item, 1);
                }
            }

            return counts;
        }
    }
}
