using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OneWeekPreparationAugust
{
    class DayTwo
    {
        public static int lonelyInteger(List<int> a)
        {

            List<int> alreadyChecked = new List<int>();
            
            for (int i = 0; i < a.Count; i++)
            {
                int valorActual = a[i];

                if (!alreadyChecked.Contains(valorActual))
                {
                    bool found = false;
                    for (int j = i + 1; j < a.Count; j++)
                    {
                        if (a[i] == a[j])
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        return valorActual;
                    }
                    else
                    {
                        alreadyChecked.Add(valorActual);
                    }
                }
            }

            return -1;
        }

        public static int lonelyIntegerOptimized (List<int> a)
        {
            Dictionary<int, int> freq = new Dictionary<int, int> ();

            for (int i = 0; i < a.Count; i++)
            {
                if (freq.ContainsKey(a[i]))
                {
                    var previousFrequency = freq.GetValueOrDefault(a[i]);
                    previousFrequency++;
                    freq.Remove(a[i]);
                    freq.Add(a[i], previousFrequency);
                }
                else
                {
                    freq.Add(a[i], 1);
                }
            }

            var lonelyIntegerKeyValue = freq.First(e => e.Value.Equals(1));

            return lonelyIntegerKeyValue.Key;
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int leftToRight = 0; int rightToLeft = 0;

            int rows = arr.Count;
            int columns = arr[0].Count;

            int i = 0;
            int j = 0;
            int k = 0;
            int l = arr.Count - 1;

            while (i < rows && j < columns && k < rows && l >= 0)
            {
                leftToRight += arr[i][j];
                rightToLeft += arr[k][l];
                i++; j++; k++; l--;
            }

            return Math.Abs(leftToRight - rightToLeft);
        }


        //Counting Sort 1
        public static List<int> countingSort(List<int> arr)
        {
            SortedDictionary<int, int> dict = new SortedDictionary<int, int>();
            
            for (int i = 0; i < arr.Count; i++)
            {
                var k = arr[i];
                if (dict.ContainsKey(k))
                {
                    dict[k] += 1;
                }
                else
                {
                    dict.Add(k, 1);
                }
            }

            for (int j = 0; j < 100; j++)
            {
                if (!dict.ContainsKey(j)) dict.Add(j, 0);
            }

            return dict.Values.ToList();
        }

        //mock test
        public static int flippingMatrix(List<List<int>> matrix) //https://medium.com/@mlgerardvla/hackerrank-flipping-the-matrix-javascript-7f945220ca1b
        {
            //i rows //j columns
            var n = matrix.Count / 2;
            var max = 0; var total = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    max = 0;
                    max = Math.Max(matrix[i][j], max);
                    max = Math.Max(matrix[i][2 * n - j - 1], max);
                    max = Math.Max(matrix[2 * n - i - 1][j], max);
                    max = Math.Max(matrix[2 * n - i - 1][2 * n - j - 1], max);

                    total += max;
                }
            }
            return total;
        }

    }
}