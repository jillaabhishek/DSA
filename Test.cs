using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class Test
    {
        public void a()
        {
            Dictionary<int, int[,]> keyValues = new Dictionary<int, int[,]>();

            keyValues.Add(1, new[,] { { 3, 3 } });
            keyValues.Add(2, new[,] { { 5, -1 } });
            keyValues.Add(3, new[,] { { -2, 4 } });

            B(1, keyValues);

            Console.ReadKey();
        }

        public void B<T>(int i, Dictionary<int, T> dic)
        {

        }
    }
}
