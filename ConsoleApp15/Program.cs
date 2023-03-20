using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 7, 4, 8 };
            int[] arr2 = { 2, 3, 10, 11 };

            CommonArr(arr, arr2);
            //        int[] test = TwoSum(arr, 6);

            string check = "gafabcd";
          string result =  LongestPanlin(check);
            Console.WriteLine(result);
            //  string result =  LongestPalindrome(check);
            // Console.WriteLine(result);
            //PrintsInt();
            //  Console.WriteLine(ISPanagram(check));
            //CountOccurency("HHello World",'l');

            // array => natural num
            // find the missing num from arr 
            // arr no duplicate
            // 1 to 10 find num 
            // OWords("welcome to code decode and code decode welcome you");

            int[] arrs = {6,4,16,14,22,15,2,42,55,42,24 };
            //  int resultss = FindMissingNumInArr(arrs);
            // Console.WriteLine($"ANS : {resultss}");
            string s = "";
            int n = 5;
            RemoveStr("CloudTech");
            // ReverseInt(12345);
            // FindIntF(arrs);
            //UpperAndLower("This is Catalis This is Catalis");
           // FindLargest(arrs);
            Console.ReadLine();

        }
        public static void RemoveStr(string s)
        {
            string result = "";
            foreach(char c in s)
            {
                if (c == 'c' || c == 'C')
                    continue;
                result += c;

                        
            }
            Console.WriteLine(result);
        }
        
        public static void FindLargest2(int[] arr)
        {
            int max = 0;
            for(int i =0; i<arr.Length; i++)
            {
                max = Math.Max(arr[i], max);
            }
            Console.WriteLine(max);
        }
        public static void FindLargest(int[] arr)
        {
            // Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++) 
            {
                for(int j = i+1; j<arr.Length; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            
            }

            Console.WriteLine(arr[arr.Length-1]);

        }
        public static void checkStr(string s)
        {
            string result = "";
            for(int i =0; i<s.Length; i++)
            {
                if (i % 2 != 1)
                   result += Char.ToUpper(s[i]);
                else
                {
                  result +=  Char.ToLower(s[i]);
                }

            }
            Console.WriteLine(result);
        }
        public static void TrimsString(string s)
        {
            string[] str = s.Split(' ');
            string result = "";
            for(int i =str.Length -1 ; i>=0; i--)
            {
                result += str[i]+ " " ;
            }

            Console.WriteLine(result);
        }
        public static void ReverseInt(int n)
        {
            int result = 0;
            int value = n;
          

            while (value > 0)
            {
                result = result * 10 + value % 10;
                value /= 10;
            }
            Console.WriteLine(result);
        }
        public static void FindIntF(int[] arr)
        {
            List<string> list = new List<string>();
            List<int> result = new List<int>();
         
            for(int i=0; i<arr.Length; i++)
            {
                list.Add(Convert.ToString(arr[i]));
            }
            for(int i =0; i<list.Count(); i++)
            {
                if (list[i].StartsWith("1"))
                {

                result.Add(Convert.ToInt32(list[i]));
                }
            }
            foreach(int a in result)
            {
                Console.WriteLine(a);
            }
        }
        public static void UpperAndLower(string s)
        {
            int mid = s.Length / 2;
            string lowerCase = "";
            string uppCase = "";
            for(int i =0; i<s.Length; i++)
            {
                if(i<mid)
                lowerCase += s[i];
                else
                {
                    uppCase += s[i];
                }
            }
           
            Console.WriteLine($"{lowerCase.ToLower()} {uppCase.ToUpper()} ");
        }
        public static int FindMissingNumInArr(int[] arr)
        {
            int result = 0;
            int last = arr[arr.Length-1];
            int secondResult;
            for (int i = 0; i < arr.Length - 1; i++)
            {

                if (arr[i + 1] - arr[i] != 1)
                {
                    result = arr[i] +1;
                   
                }
               
            }
            return result;
        }
        public static void OWords(string s)
        {
            string[] str = s.Split(' ');
            Dictionary<string, int> map = new Dictionary<string, int>();

            for(int i =0; i<str.Length; i++)
            {
                if (!map.ContainsKey(str[i]))
                    map.Add(str[i], 1);
                else
                    map[str[i]]++;

            }
            foreach(var result in map)
            {
                Console.Write($"{result.Key} = {result.Value} ");
            }
            
        }

        public static bool IsIsogram(string s)
        {
            //bool result = true;

            Dictionary<char, int> map = new Dictionary<char, int>();

            for(int i =0; i<s.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                    map.Add(s[i], 1);
                else
                    map[s[i]]++;
            }

            foreach(var result in map)
            {
                if (result.Value > 1)
                    return false;
            }

            return true;
            
        }
        public static void CountOccurency(string s,char a)
        {
            // char[] cArr = s.ToCharArray();
       Dictionary<char, int> map = new Dictionary<char, int>();
                    int count = 0;
                    for(int i =0; i<s.Length; i++)
                    {
                        if (!map.ContainsKey(s[i]))
                            map.Add(s[i], 1);
                        else
                            map[s[i]]++;

                    }
            int cnt = 0;
                    foreach (var result in map)
                    {
                        if(result.Value >1)
                        {
                            continue;
                        }
                cnt += result.Value;
                        Console.WriteLine($"{result.Key} {result.Value}   ");
                    }

            Console.WriteLine(cnt);





            //   Console.WriteLine($"Result Count : {s.Length - count}");

        }
        public static string LongestPanlin(string s)
        {

            if (s.Length < 2 || s == null)
                return "";

            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                string lPandindomre = ExpandCenterStr(s, i, i);
                if (lPandindomre.Length > result.Length)
                    result = lPandindomre;
                lPandindomre = ExpandCenterStr(s, i, i + 1);
                if (lPandindomre.Length > result.Length)
                    result = lPandindomre;

            }

            return result;
        }
        public static string ExpandCenterStr(string s, int begin, int end)
        {
            while (begin >= 0 && end < s.Length &&s[begin] == s[end])
            {
                begin--;
                end++;
            }
            return s.Substring(begin + 1, end - begin - 1);
        }


    public static bool ISPanagram(string s)
        {
            string result = s.ToLower();
            foreach(char c in result)
            {
                Console.WriteLine($"Result : {c}:{s.IndexOf(c)}");
            }
            if (s.Length < 26)
                return false;
            else {
                for(char c ='a'; c<='e'; c++)
                {
                    if(result.IndexOf(c)<0)
                    {
                        return false;
                    }
                }

            }
            return true;
        }
        public static void KMPSearch(string text, string pattern)
        {
            // base case 1: pattern is null or empty
            if (pattern == null || pattern.Length == 0)
            {
                Console.WriteLine("The pattern occurs with shift 0");
                return;
            }

            // base case 2: text is NULL, or text's length is less than that of pattern's
            if (text == null || pattern.Length > text.Length)
            {
                Console.WriteLine("Pattern not found");
                return;
            }

            char[] chars = pattern.ToCharArray();

            // next[i] stores the index of the next best partial match
            int[] next = new int[pattern.Length + 1];
            for (int i = 1; i < pattern.Length; i++)
            {
                int j = next[i];

                while (j > 0 && chars[j] != chars[i])
                {
                    j = next[j];
                }

                if (j > 0 || chars[j] == chars[i])
                {
                    next[i + 1] = j + 1;
                }
            }

            for (int i = 0, j = 0; i < text.Length; i++)
            {
                if (j < pattern.Length && text[i] == pattern[j])
                {
                    if (++j == pattern.Length)
                    {
                        Console.WriteLine("The pattern occurs with shift " + (i - j + 1));
                    }
                }
                else if (j > 0)
                {
                    j = next[j];
                    i--;    // since `i` will be incremented in the next iteration
                }
            }
        }
        public static string LongestPalindrome(string s)
        {
            string bbb = "";
            if (s is null)
                return "";
            if (s.Length < 2)
                return s;

            string result = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                string palindromeString = ExpandAroundCenter(s, i, i);
                if (palindromeString.Length > result.Length)
                      result = palindromeString;
            
                palindromeString = ExpandAroundCenter(s, i, i + 1);
                if (palindromeString.Length > result.Length)
                result = palindromeString;


            }

            Console.WriteLine(result);

            return result;

        }
        public static string ExpandAroundCenter(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;

            }
            return s.Substring(left + 1, right - left - 1);
        }
        public static void ReverseStr(string s)
        {
            for(int i = s.Length-1; i>=0; i--)
            {
                Console.Write(s[i]);
            }
        }
        public static int[] TwoSum(int[] arr, int n)
        {
            int[] arr2 = new int[2];
            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == n)
                    {
                        arr2[0] = i;
                        arr2[1] = j;
                    }

                }
            }
            return arr2;
        }
        public static void PrintsInt()
        {
            for(int i = 17; i<=53; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("Foo");
                else if (i % 5 == 0)
                    Console.WriteLine("Bar");
                else if (i % 2 == 0 && i % 5 == 0)
                    Console.WriteLine("FooBar");
                else
                    Console.WriteLine(i);
            }
        }
        public static void CommonArr(int[] arr, int[] arrTwo)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for(int i =0; i<arr.Length; i++)
            {
                if (!map.ContainsKey(arr[i]))
                    map.Add(arr[i], 1);
                else
                    map[arr[i]]++;
            }

    for (int i = 0; i < arrTwo.Length; i++)
            {
                if (!map.ContainsKey(arrTwo[i]))
                    map.Add(arrTwo[i],1 );
                else
                    map[arrTwo[i]]++;
            }

            foreach(var result in map)
            {
                if (result.Value>1)
                    Console.WriteLine($"{result.Key} : {result.Value} ");
            }
           
        }
    }
}
