using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    partial class Array : IOutput
    {
        int[] Arr { get; set; }
        public Array()
        {
            Arr = new int[5];
            Arr[0] = 0;
            Arr[1] = 4;
            Arr[2] = 3;
            Arr[3] = 5;
            Arr[4] = 6;
        }
        public void Show()
        {
            foreach (var item in Arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public void Show(string info)
        {
            Console.WriteLine(info);
            Show();
        }
    }
    partial class Array : IMath
    {
        public int Max()
        {
            int max = Arr[0];
            foreach(var item in Arr)
            {
                if(item > max)
                {
                    max = item;
                }
            }
            return max;
        }
        public int Min()
        {
            int min = Arr[0];
            foreach (var item in Arr)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }
        public float Avg()
        {
            float sum = 0.0f;
            foreach (var item in Arr)
            {
                sum += item;
            }
            return sum / (Arr.Length);
        }
        public bool Search(int valueToSearch)
        {
            bool search = false;
            foreach (var item in Arr)
            {
                if(item == valueToSearch)
                {
                    search = true;
                }
            }
            return search;
        }
    }
    partial class Array : ISort
    {
        public void SortAsc()
        {
            System.Array.Sort(Arr);
        }
        public void SortDesc()
        {
            System.Array.Sort(Arr);
            System.Array.Reverse(Arr);
        }
        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }
    }
}
