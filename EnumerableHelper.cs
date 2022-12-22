using System;
using System.Collections.Generic;

namespace SteelSeries.GameSense.Generic
{
    internal static class EnumerableHelpers
    {
        internal static T[] ToArray<T>(IEnumerable<T> source, out int length)
        {
            ICollection<T> collection = source as ICollection<T>;
            if (collection != null)
            {
                int count = collection.Count;
                if (count != 0)
                {
                    T[] array = new T[count];
                    collection.CopyTo(array, 0);
                    length = count;
                    return array;
                }
            }
            else
            {
                using (IEnumerator<T> enumerator = source.GetEnumerator())
                {
                    if (enumerator.MoveNext())
                    {
                        T[] array2 = new T[4];
                        array2[0] = enumerator.Current;
                        int num = 1;
                        while (enumerator.MoveNext())
                        {
                            if (num == array2.Length)
                            {
                                int num2 = num << 1;
                                if (num2 > 2146435071)
                                {
                                    num2 = ((2146435071 <= num) ? (num + 1) : 2146435071);
                                }
                                Array.Resize<T>(ref array2, num2);
                            }
                            array2[num++] = enumerator.Current;
                        }
                        length = num;
                        return array2;
                    }
                }
            }
            length = 0;
            return Array.Empty<T>();
        }
    }
}
