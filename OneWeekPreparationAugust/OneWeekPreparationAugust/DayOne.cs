using System;
using System.Collections.Generic;
using System.Text;

namespace OneWeekPreparationAugust
{
    class DayOne
    {

        public static void plusMinus(List<int> arr)
        {
            int positives = 0;
            int negatives = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0) positives++;
                else if (arr[i] < 0) negatives++;
            }

            Console.WriteLine(((float)positives / arr.Count));//positive
            Console.WriteLine(((float)negatives / arr.Count));//negatives
            Console.WriteLine(((float)(arr.Count - positives - negatives) / arr.Count));//zeros
        }

        public static void miniMaxSum(List<int> arr)
        {          
            if (arr.Count != 5)
            {
                Console.WriteLine("Size of the array must be 5");
                return;
            }

            var convertedArr = arr.ConvertAll(v => (long)v);
            convertedArr.Sort();
            long min = convertedArr[0] + convertedArr[1] + convertedArr[2] + convertedArr[3];
            long max = convertedArr[1] + convertedArr[2] + convertedArr[3] + convertedArr[4];

            Console.WriteLine(min.ToString() + " " + max.ToString());            
        }

        public static void miniMaxSumImprovement(List<int> arr)
        {
            long sumaTotal = 0;
            arr.ForEach(n => sumaTotal+=n);
            arr.Sort();
            var min = sumaTotal - arr[arr.Count -1];
            var max = sumaTotal - arr[0];
            
            Console.WriteLine(min.ToString() + " " + max.ToString());            
        }

        public static string timeConversion(string s)
        {
            if (s.EndsWith("AM"))
            {
                if (s.StartsWith("12"))
                {
                    return "00" + s.Replace("AM", "").Substring(2);
                }

                return s.Replace("AM", "");
            }

            string horarioSinPM = s.Replace("PM", "");
            var hora = int.Parse(s.Substring(0, 2));

            if (hora != 12)
            {
                hora += 12;
            }

            var horaFormato24 = hora.ToString() + horarioSinPM.Substring(2);

            return horaFormato24;

        }

        //mock test
        public static void fizzBuzz(int n)
        {
            int fizzNumber = 3; int buzzNumber = 5;

            for (int i = 1; i <= n; i++)
            {
                string toPrint = "";
                if (i % fizzNumber == 0) toPrint += "Fizz";
                if (i % buzzNumber == 0) toPrint += "Buzz";
                if (toPrint.Length == 0) toPrint += i.ToString();

                Console.WriteLine(toPrint);
            }
        }

        //test findTheMeridian
        public static int findTheMeridian(List<int> numbers)
        {
            numbers.Sort();
            int n = numbers.Count;
            return numbers[n / 2];
        }

    }
}
