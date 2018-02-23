using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_10_RegularExpressionMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "aaab";
            string p = "a*b";
            Solution s1 = new Solution();
            Console.Write(s1.IsMatch(s, p));
            var a = Console.ReadKey();
        }
    }
    public class Solution
    {
        public bool IsMatch(string s, string p)
        {
            if (String.IsNullOrEmpty(p))
                return String.IsNullOrEmpty(s);
            if (p.Length >= 2 && p[1] == '*')
                //x* matches empty string or at least one character: x* -> xx*
                //*s is to ensure s is non empty
                return (IsMatch(s, p.Substring(2)) || !String.IsNullOrEmpty(s) && (s[0] == p[0] || p[0] == '.') && IsMatch(s.Substring(1), p));
            else
                return !String.IsNullOrEmpty(s) && (s[0] == p[0]||p[0]=='.') && IsMatch(s.Substring(1), p.Substring(1));
        }
    }
}
