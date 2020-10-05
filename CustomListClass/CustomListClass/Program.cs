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

            //List<int> testList = new List<int>();
            //testList.Add(9);
            //int testInt = testList[0];
            //testList[0] = 7;

            BridgetsList<int> addList = new BridgetsList<int>();
            addList.Add(1);
            addList.Add(3);
            addList.Add(5);

            BridgetsList<int> addList2 = new BridgetsList<int>();
            addList.Add(2);
            addList.Add(4);
            addList.Add(6);
            
                //BridgetsList<int> result = addList + addList2;
                //Console.WriteLine("result is " addlist + "addlist2);
            
               







        }
    }
}
