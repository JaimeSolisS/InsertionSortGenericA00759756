using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortGenericA00759756
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = { 2222.2f, 3.33f, 30, 1, 5 };
            int n = 5;
            insertionSortG.insertionSort(arr,n);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0 }", arr[i]);
            }
        }
    }
}
