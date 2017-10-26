using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortGenericA00759756
{
    class insertionSortG
    {
        public static void insertionSort <T>(T [] arr, int n) where T: IComparable
        {
            int i, j;
            for (i = 1; i < n; i++)
            {
                T key = arr[i];
                j = i - 1;

                /* Move elements of arr[0..i-1], that are
                   greater than key, to one position ahead
                   of their current position */
                while (j >= 0 && arr[j].CompareTo(key) <0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

       
            

        }
    }
