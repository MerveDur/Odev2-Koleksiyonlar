// See https://aka.ms/new-console-template for more information
using System.Collections;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrL=new ArrayList();
            Console.WriteLine("Enter a sentence : ");
            string? text=Console.ReadLine();
            if(text!=null)
            {
                foreach(var ch in text)
                {
                    if(ch=='a')
                        arrL.Add(ch);
                    if(ch=='e')
                        arrL.Add(ch);
                    if(ch=='ı')
                        arrL.Add(ch);
                    if(ch=='i')
                        arrL.Add(ch);
                    if(ch=='o')
                        arrL.Add(ch);
                    if(ch=='ö')
                        arrL.Add(ch);
                    if(ch=='u')
                        arrL.Add(ch);
                    if(ch=='ü')
                        arrL.Add(ch);
                    if(ch=='A')
                        arrL.Add(ch);
                    if(ch=='E')
                        arrL.Add(ch);
                    if(ch=='I')
                        arrL.Add(ch);
                    if(ch=='İ')
                        arrL.Add(ch);
                    if(ch=='O')
                        arrL.Add(ch);
                    if(ch=='Ö')
                        arrL.Add(ch);
                    if(ch=='U')
                        arrL.Add(ch);
                    if(ch=='Ü')
                        arrL.Add(ch);
                }
                arrL.Sort();
                Console.WriteLine("Vowels in Text: ");
                foreach(var value in arrL)
                {
                    Console.Write( value+" " );
                }
            } 
        }
    }
}
