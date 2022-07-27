// See https://aka.ms/new-console-template for more information
using System.Collections;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList nums = new ArrayList();
            //ArrayList prime = new ArrayList();
            //int prime=new ArrayList();
            var prime = new ArrayList();
            ArrayList notPrimeList = new ArrayList();
            int num=0,isPrime=0,notPrime=0,totalPrime=0,totalNotPrime=0;

            Console.WriteLine("Enter 20 positive number : ");
            
            for(int i=0;i<3;i++)
            {
                num=Convert.ToInt32(Console.ReadLine());
                if(num>1)
                {
                    nums.Add(num);
                }
                else
                    i--;
            } 
            foreach(int number in nums)
            {
                isPrime=0;
                notPrime=0;
                if(number==2)
                   isPrime=1;
                for(int j=2;j<number;j++)
                {
                        
                    if(number%j==0)
                    {
                        notPrime=1;
                    }
                }
                if(notPrime==0 || isPrime==1)
                {
                    prime.Add(number);   
                }
                else
                {
                    notPrimeList.Add(number); 
                }
                    
            }
            prime.Sort(); 
            prime.Reverse();     
            Console.WriteLine("Prime Numbers : ");
            foreach(var item in prime)
            {
                
                Console.Write(item+" ");
                totalPrime+=(int)item;
            }
            Console.WriteLine();
            Console.WriteLine("Count of Prime Number: " + prime.Count);
            Console.WriteLine("Average of Prime Number: " +(double)totalPrime/prime.Count);
            Console.WriteLine();

            prime.Sort(); 
            prime.Reverse();     
            Console.WriteLine("Not Prime Numbers : ");
            foreach(var item in notPrimeList)
            {
                
                Console.Write(item+" ");
                totalNotPrime+=(int)item;
            }
            Console.WriteLine();
            Console.WriteLine("Count of Not Prime Number: " + notPrimeList.Count);
            Console.WriteLine("Average of Not Prime Number: " +(double)totalNotPrime/notPrimeList.Count);
               
        }
    }
}

