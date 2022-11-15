using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stack_DataType
{
    internal class FindStringIsvalid
    {
        public void Run()
        {
            string input = "()[{}";

            Console.WriteLine("Is Input Valid: " + IsValid(input));
        }

        public bool IsValid(string input)
        {
            Stack<char> stack = new Stack<char>();           

            Dictionary<char, char> bracketMapping = new Dictionary<char, char>();
            bracketMapping.Add('{', '}');
            bracketMapping.Add('(', ')');
            bracketMapping.Add('[', ']');

            List<char> openParams = new List<char>() { '(', '{', '[' };


            foreach (char s in input)
            {
                if (openParams.Contains(s))
                    stack.Push(s);
                else if (stack.Count != 0 && s == bracketMapping[stack.Peek()])
                    stack.Pop();
                else
                    return false;

            }

            return stack.Count == 0;
        }
    }
}
