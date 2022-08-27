using System;
using System.Collections.Generic;

namespace OneWeekPreparationAugust
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1,2,1,4,2,5,5 };

            var lonelyIntegerValue = DayTwo.lonelyInteger(numbers);

            Console.WriteLine(lonelyIntegerValue.ToString());
        }
    }
}
