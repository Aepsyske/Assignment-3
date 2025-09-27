using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        public static void SWAP1(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void SWAP2(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void Modify1(int num)
        { 
            num = num + 10; 
        }
        public static void Modify2(ref int num)
        {
            num = num + 10;
        }
        public static void Calc(int x, int y, int z, int v)
        {
            Console.WriteLine($"Result = {x + y}");
            Console.WriteLine($"Result = {z - v}");
        }
        public static int SDigits(int num)
        {
            int sum = 0;
            string s = num.ToString();
            for(int i = 0; i < s.Length; i++)
            {
                int.TryParse(s[i].ToString(), out int d);
                sum += d;
            }

            return sum;
        }
        public static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void MinMaxArray(ref int[] a)
        {
            int max = a[0], min = a[0];
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] > max)
                {
                    max = a[i];
                }

                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
        }
        public static int Factorial(int num)
        {
            int res = 1;
            for(int i = 1; i <= num; i++)
            {
                res *= i;
            }
            return res;
        }
        public static void ChangeChar(string s, int n, char c)
        {
            char[] chars = s.ToCharArray();
            chars[n - 1] = c;
            s = new string(chars);
            Console.WriteLine($"New String : {s}");
        }
        public static void SumArray(params int[] a)
        {
            int sum = 0;
            for(int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            Console.WriteLine($"Sum = {sum}");
        }
        static void Main(string[] args)
        {
            // Assignment 4

            #region Q1
            // Call By Value : The Values Get Stored In The Function Only, Then The Stack Frame Gets Deleted, Hence No Changes Happens In The Main.
            // Call By Reference : The Values Are Stored In The Main By Going To Its Address And Retrieving The Values.
            //int x = 5, y = 10;
            //SWAP1(x, y);
            //Console.WriteLine($"X BY VALUE : {x}\nY BY VALUE : {y}");
            //SWAP2(ref x, ref y);
            //Console.WriteLine($"X BY REFERENCE : {x}\nY BY REFERENCE : {y}");
            #endregion

            #region Q2
            // Passing By Value : The Variable's Value Is Sent To The Function As A Copy, Hence Doesn't Change In The Main.
            // Passing By Reference : The Variable's Value Is Sent To The Function While Linking Its Address, So The Value Is Saved In The Memory And Will Change In The Main.
            //int x = 5;
            //Modify1(x);
            //Console.WriteLine($"X PASSED BY VALUE : {x}");
            //Modify2(ref x);
            //Console.WriteLine($"X PASSED BY REFERENCE : {x}");
            #endregion

            #region Q3
            //int x, y, z, v;
            //Console.Write("Enter First Num : ");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Second Num : ");
            //y = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Third Num : ");
            //z = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Fourth Num : ");
            //v = Convert.ToInt32(Console.ReadLine());
            //Calc(x, y, z, v);
            #endregion

            #region Q4
            //int x;
            //Console.Write("Enter A Number : ");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"The Sum Of Digits Of The Number {x} Is : {SDigits(x)}");
            #endregion

            #region Q5
            //Console.WriteLine(IsPrime(4));
            #endregion

            #region Q6
            //int[] a = new int[]{ 5, 6, 7, 10, 21, 50, 2 };
            //MinMaxArray(ref a);
            #endregion

            #region Q7
            //Console.Write("Enter Number : ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Factorial Of The Number {x} Is : {Factorial(x)}");
            #endregion

            #region Q8
            //Console.Write("Enter String : ");
            //string s = Console.ReadLine();
            //Console.Write("Enter Position : ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter New Letter : ");
            //char c = Convert.ToChar(Console.ReadLine());
            //ChangeChar(s, n, c);
            #endregion

            #region Q9
            //SumArray(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            #endregion

            #region Q10
            //int[] n = new int[5] { 1, 2, 3, 4, 5 };
            //int[] m = new int[5] { 6, 7, 8, 9, 10 };
            //int[] c = new int[10];
            //for (int i = 0; i < n.Length; i++)
            //{
            //    c[i] = n[i];
            //}

            //for (int i = 0; i < m.Length; i++)
            //{
            //    c[i + 5] = m[i];
            //}

            //Console.Write("[");
            //for (int i = 0; i < c.Length; i++)
            //{
            //    if(i != c.Length - 1)
            //    {
            //        Console.Write(c[i] + ", ");
            //    }
            //    else
            //    {
            //        Console.Write(c[i]);
            //    }
            //}
            //Console.Write("]");
            #endregion

            #region Q11
            //Console.Write("Enter Size Of Array: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] arr = new int[n];
            //int[] freq = new int[n];
            //int visited = -1;

            //Console.WriteLine("Enter Elements Of Array: ");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //    freq[i] = 1;
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    if (freq[i] != visited) 
            //    {
            //        for (int j = i + 1; j < n; j++)
            //        {
            //            if (arr[i] == arr[j])
            //            {
            //                freq[i]++;
            //                freq[j] = visited; 
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine("\nElement | Frequency");
            //Console.WriteLine("-------------------");
            //for (int i = 0; i < n; i++)
            //{
            //    if (freq[i] != visited)
            //        Console.WriteLine("   " + arr[i] + "   |   " + freq[i]);
            //}
            #endregion

            #region Q12
            //int[] n = new int[5]{ 1, 5, 2, 3, 4 };
            //int max = n[0], min = n[0];
            //for(int i = 0; i < n.Length; i++)
            //{
            //    if(n[i] > max)
            //    {
            //        max = n[i];
            //    }

            //    if (n[i] < min)
            //    {
            //        min = n[i];
            //    }
            //}
            //Console.WriteLine($"Max = {max}\nMin = {min}");
            #endregion

            #region Q13
            //int[] n = new int[5] { 4, 1, 3, 2, 5 };
            //int Max = n[0], sMax = n[0];
            //for(int i = 0; i < n.Length; i++)
            //{
            //    if (n[i] > Max)
            //    {
            //        Max = n[i];
            //    }

            //    if (n[i] > sMax && n[i] < Max)
            //    {
            //        sMax = n[i];
            //    }
            //}
            //Console.WriteLine($"Max = {Max}\nSecond Max = {sMax}");
            #endregion

            #region Q14
            //int[] n = new int[12];
            //Console.WriteLine("Enter Array Elements: ");
            //for(int i = 0; i < n.Length; i++)
            //{
            //    n[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int m = 0;
            //for (int i = 0; i < n.Length; i++)
            //{
            //    for (int j = n.Length - 1; j > i; j--)
            //    {
            //        if (n[i] == n[j])
            //        {
            //            int distance = j - i - 1; 
            //            if (distance > m)
            //            {
            //                m = distance;
            //            }
            //            break; 
            //        }
            //    }
            //}
            //Console.WriteLine("\n" + m + " Cells");
            #endregion

            #region Q15
            //Console.Write("Enter String : ");
            //string s = Console.ReadLine();
            //Console.WriteLine("Reversed String : " + string.Join(" ", s.Split(' ').Reverse()));
            #endregion

            #region Q16
            //Console.Write("Enter Row : ");
            //int r = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Column : ");
            //int c = Convert.ToInt32(Console.ReadLine());

            //int[,] a = new int[r, c];
            //int[,] b = new int[r, c];

            //for(int i = 0; i < a.GetLength(0); i++)
            //{
            //    Console.WriteLine($"\nEnter Row {i+1}'s Elements : \n");
            //    for(int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.Write($"Element {j + 1} : ");
            //        if (!int.TryParse(Console.ReadLine(), out a[i, j]))
            //        {
            //            Console.WriteLine("Enter Proper Values.");
            //            Console.Write($"Element {j + 1} : ");
            //            while (!int.TryParse(Console.ReadLine(), out a[i, j]))
            //            {
            //                Console.WriteLine("Enter Proper Values.");
            //                Console.Write($"Element {j + 1 } : ");
            //            }
            //        } 
            //    }
            //}

            //Array.Copy(a, b, r * c);

            //for(int i = 0; i < b.GetLength(0); i++)
            //{
            //    Console.Write($"\nRow {i + 1} Elements\n");
            //    for(int j = 0; j < b.GetLength(1); j++)
            //    {
            //        Console.Write($"Element {j + 1} : {b[i,j]} ");
            //    }
            //}
            //Console.WriteLine("\n\nIn Matrix : ");
            //for (int i = 0; i < b.GetLength(0); i++)
            //{    
            //    for (int j = 0; j < b.GetLength(1); j++)
            //    {
            //        Console.Write($"{b[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q17
            //int[] n = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.Write("[");
            //for(int i = n.Length - 1; i >= 0; i--)
            //{
            //    if (i != 0)
            //    {
            //        Console.Write(n[i] + ", ");
            //    }
            //    else
            //    {
            //        Console.Write(n[i]);
            //    }
            //}
            //Console.Write("]");
            #endregion
        }
    }
}
