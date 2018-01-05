using System;

namespace SkeletonConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoProcessing();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unhandled exception: {ex}");
                Console.Read(); // give us a chance to read exception
            }
        }

        private static void DoProcessing()
        {
            throw new NotImplementedException();
        }
    }
}
