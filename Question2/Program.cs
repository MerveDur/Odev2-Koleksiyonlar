// See https://aka.ms/new-console-template for more information

using System.Collections;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new ArrayList();
            var min = new ArrayList();
            var max = new ArrayList();
            int num=0,totalMin=0,totalMax=0;
            double total=0;

            Console.WriteLine("Enter 20 positive number : ");
            
            for(int i=0;i<20;i++)
            {
                num=Convert.ToInt32(Console.ReadLine());
                if(num>0)
                {
                    nums.Add(num);
                }
                else
                    i--;
            }
            nums.Sort();
            for(int i=0;i<3;i++)
            {
                min.Add(nums[i]);
            }
            nums.Reverse();
            for(int i=0;i<3;i++)
            {
                max.Add(nums[i]);
            }
            Console.WriteLine("Min Numbers : ");
            foreach(var item in min)
            {
                
                Console.Write(item+" ");
                totalMin+=(int)item;
            }
            Console.WriteLine();
            Console.WriteLine("Average of Min Number: " +(double)totalMin/min.Count);
            Console.WriteLine();

            Console.WriteLine("Max Numbers : ");
            foreach(var item in max)
            {
                
                Console.Write(item+" ");
                totalMax+=(int)item;
            }
            Console.WriteLine();
            Console.WriteLine("Average of Max Number: " +(double)totalMax/max.Count);
            Console.WriteLine();
            total=(double)totalMax/max.Count +(double)totalMin/min.Count;
            Console.WriteLine("Total Average (max+min): " +total);

        }
    }
}