using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assq2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("enter the size of arr");
            N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];

            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine($"enter the {i+1}th element");
                arr[i] = int.Parse(Console.ReadLine());
                
            }
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            for(int i=0;i<arr.Length;i++)
            {
                int count = 0;
                int n = arr[i];
                while(n != 0)
                {
                    n = n / 10;
                    ++count;
                }
                if(count == 1)
                {
                    count1 += 1;
                }
                else if(count == 2)
                {
                    count2 += 1;
                }
                else if(count == 3)
                {
                    count3 += 1;
                }
            }

            Console.WriteLine($"count of 1-digit number is {count1}");
            Console.WriteLine($"count of 2-digit number is {count2}");
            Console.WriteLine($"count of 3-digit number is {count3}");
        }
    }
}
