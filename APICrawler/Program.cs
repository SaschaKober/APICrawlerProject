using System;
using APICrawlerCall.Calls;


namespace APICrawlerCall
{
    class Program
    {       
        static void Main(string[] args)
        {
            try
            {
                ExecuteCalls.Start();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }

        }
    }
}
