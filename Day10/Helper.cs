using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day10
{
    
    
    internal class Helper
    {
        bool Flag = false;
        
        public void PrintMsg()
        {
            lock (this) // to make one thread for the section of code
            {
                if (!Flag)
                {
                    Thread.Sleep(2000);

                    Console.WriteLine($"{Flag}:Helper...........");
                    Flag = true;
                    Console.WriteLine("*****");
                }
            }
            Thread.Sleep( 500 );
            Console.WriteLine($"{Flag}:Helping...........");
        }
    }
}
