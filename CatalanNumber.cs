using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class CatalanNumber
    {
        int result = 0;

        public void Run()
        {
            Console.WriteLine(Catalan(3, 0));
        }

        public int Catalan(int n, int i)
        {
            if (n == 1 || n == 0)
                return 1;          

            result += i * Catalan(n - 1, i+1);
            
            //for (int i = 1; i < n; i++)
            //{

            //}
            //

            return result;
        }

        public void CountSort()
        {

        }

    }
}
