using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> testList = new List<int>();
            testList.Add(9);
            int testInt = testList[0];
            testList[0] = 7;
        }
    }
}
