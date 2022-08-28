using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace OneWeekPreparationAugust
{
    class DayThree
    {
        /* Java solution, 
        public static void findZigZagSequence(int[] a, int n)
        {
            Arrays.sort(a);
            int mid = (n + 1) / 2 - 1;
            int temp = a[mid];
            a[mid] = a[n - 1];
            a[n - 1] = temp;

            int st = mid + 1;
            int ed = n - 2;
            while (st <= ed)
            {
                temp = a[st];
                a[st] = a[ed];
                a[ed] = temp;
                st = st + 1;
                ed = ed - 1;
            }
            for (int i = 0; i < n; i++)
            {
                if (i > 0) System.out.print(" ");
                System.out.print(a[i]);
            }
            System.out.println();
        }
        */

        public static int towerBreakers(int n, int m)
        {
            if (m == 1 || n % 2 == 0) return 2;
            return 1;

        }

        //public static bool esUnaLetra(char c)
        //{
        //    StringBuilder cadena = new StringBuilder();
        //    cadena.Append(c);
        //    return Regex.IsMatch(cadena.ToString(), @"^[a-zA-Z]+$");
        //}

        /*MI solucion, funciona para casos donde el imput no tiene mayusculas*/
        public static string caesarCipherLeo(string s, int k)
        {
            StringBuilder resultado = new StringBuilder();
            var originalAlphabet = "abcdefghijklmnopqrstuvwxyz"; //26 caracteres

            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if (originalAlphabet.Contains(c))
                {
                    var pos = originalAlphabet.IndexOf(c);
                    if(pos + k <= originalAlphabet.Length - 1)
                    {
                        c = originalAlphabet[pos + k];
                    } 
                    else
                    {
                        var dif = pos + k - originalAlphabet.Length;
                        while(dif > originalAlphabet.Length - 1)
                        {
                            dif = dif - originalAlphabet.Length - 1;
                        }
                        c = originalAlphabet[dif];
                    }
                }
                resultado.Append(c);
            }

            return resultado.ToString();
        }

        public static string caesarCipher(string s, int k)
        {
            StringBuilder resultado = new StringBuilder();

            for (int i =0; i < s.Length; i++)
            {
                char c = s[i];
                bool isUpperCase = Char.IsUpper(c);
                if (Char.IsLetter(c))
                {
                    c = (char) ((int)c + (k % 26)); //26 letras en el alfabeto que consideramos para este problema
                    if (!Char.IsLetter(c) || (isUpperCase && !Char.IsUpper(c)))
                    {
                        c = (char) ((int)c - 26);
                    }
                }
                resultado.Append(c);
            }

            return resultado.ToString();
        }

        //Mock Test
        //Palindrome Index
        //Solution explanation
        /*
        By first checking whether the original string is a palindrome you can find the spot where it fails, which leaves you with just 2 possibilities for deletion. 
        So you would only need to try those two. 
        Moreover, you don't actually have to perform the deletion. 
        You can just skip the concerned character and continue the palindrome check by skipping the corresponding index.
         */
        public static int palindromeIndex(String s)
        {
            int start = 0;
            int end = s.Length - 1;
            while (start < end && s[start] == s[end])
            {
                start++;
                end--;
            }
            if (start >= end) return -1; // already a palindrome
            // We need to delete here
            if (isPalindrome(s, start + 1, end)) return start;
            if (isPalindrome(s, start, end - 1)) return end;
            return -1;
        }

        public static bool isPalindrome(String s, int start, int end)
        {
            while (start < end && s[start] == s[end])
            {
                start++;
                end--;
            }
            return start >= end;
        }
    }
}
