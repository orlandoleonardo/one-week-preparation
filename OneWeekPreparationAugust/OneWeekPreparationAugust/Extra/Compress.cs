using System;
using System.Text;

namespace ConsoleApp1
{
    class Program2
    {
        static void Main2(string[] args)
        {
            string cadena = "dddd";
            Console.WriteLine(Compress(cadena));
        }

        //public static string Compress(string str)
        //{
        //    StringBuilder sb = new StringBuilder(str.Length + 1);
        //    char currChar = str.ToCharArray()[0];

        //    int currCount = 1;

        //    for (int i = 1; i< str.Length; i++)
        //    {
        //        if (str.ToCharArray()[i] == currChar)
        //        {
        //            currCount++;
        //        } else
        //        {
        //            sb.Append(currChar);
        //            sb.Append(currCount);
        //            if(sb.Length > str.Length)
        //            {
        //                return str;
        //            }

        //            currChar = str.ToCharArray()[i];
        //            currCount = 1;
        //        }
        //    }

        //    sb.Append(currChar);
        //    sb.Append(currCount);
        //    return sb.ToString();
        //}

        //public static string Compress(string str)
        //{
        //    string compressed = "";
        //    int countConsecutive = 0;

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        countConsecutive++;

        //        if (i + 1 >= str.Length || str.ToCharArray()[i] != str.ToCharArray()[i + 1])
        //        {
        //            compressed += "" + str.ToCharArray()[i] + countConsecutive;
        //            countConsecutive = 0;
        //        }
        //    }

        //    if (compressed.Length < str.Length)
        //    {
        //        return compressed;
        //    }

        //    return str;
        //}

        //public static string Compress(string str)
        //{
        //    int finalLength = CountCompression(str);

        //    if (finalLength >= str.Length) return str;

        //    StringBuilder compressed = new StringBuilder(finalLength);

        //    int countConsecutive = 0;

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        countConsecutive++;
        //        if (i + 1 >= str.Length || str.ToCharArray()[i] != str.ToCharArray()[i + 1])
        //        {
        //            compressed.Append(str.ToCharArray()[i]);
        //            compressed.Append(countConsecutive);
        //            countConsecutive = 0;
        //        }
        //    }

        //    return compressed.ToString();
        //}

        //public static int CountCompression(string str)
        //{
        //    int compressedLength = 0;
        //    int countConsecutive = 0;

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        countConsecutive++;

        //        if (i + 1 >= str.Length || str.ToCharArray()[i] != str.ToCharArray()[i + 1])
        //        {
        //            compressedLength += 1 + countConsecutive;
        //            countConsecutive = 0;
        //        }
        //    }

        //    return compressedLength;
        //}

        public static string Compress(string cadena)
        {
            var cadenaArray = cadena.ToCharArray();
            string cadenaFinal = "";
            int repeticionesContiguas = 1;
            char caracterActual = cadenaArray[0];

            for (int i = 0; i < cadena.Length; i++)
            {

                if (i == cadena.Length - 1)
                {
                    cadenaFinal += cadenaArray[i].ToString();
                }

                else
                {
                    if (cadenaArray[i] == caracterActual)
                    {
                        repeticionesContiguas++;
                    }
                    else
                    {
                        cadenaFinal += cadenaArray[i].ToString();
                        if (repeticionesContiguas > 1) cadenaFinal += repeticionesContiguas.ToString();
                        caracterActual = cadenaArray[i];
                        repeticionesContiguas = 1;
                    }
                }

            }

            if (cadenaFinal.Length < cadena.Length)
                return cadenaFinal;
            else return cadena;
        }
    }
}
