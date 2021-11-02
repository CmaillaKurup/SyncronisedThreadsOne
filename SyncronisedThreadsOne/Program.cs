using System;                                                                                             
using System.Threading;                                                                                   
                                                                                                          
namespace TavleThread                                                                                     
{                                                                                                         
    class Program                                                                                         
    {                                                                                                     
        static int sum = 0;                                                                               
                                                                                                          
        static void Main(string[] args)                                                                   
        {                                                                                                 
            Thread[] threads = new Thread[10000];                                                         
                                                                                                          
            for (int n = 0; n < threads.Length; n++)                                                      
            {                                                                                             
                threads[n] = new Thread(AddOne);                                                          
                threads[n].Start();                                                                       
            }                                                                                             
                                                                                                          
            for (int n = 0; n < threads.Length; n++)                                                      
            {                                                                                             
                threads[n].Join();                                                                      
            }                                                                                             
            Console.WriteLine(sum);                                                                       
        }                                                                                                 
                                                                                                          
        static void AddOne()                                                                              
        {                                                                                                 
            //using Interlocked.Increment(ref sum) only used if its an int, float or double (atomar)      
            Interlocked.Increment(ref sum);                                                               
            //sum++;                                                                                      
        }                                                                                                 
    }                                                                                                     
}                                                                                                         