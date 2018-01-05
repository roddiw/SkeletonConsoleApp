using System;

namespace SkeletonConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalExceptionHandler);

            DoProcessing();
        }

        private static void DoProcessing()
        {
            throw new NotImplementedException();
        }

        private static void GlobalExceptionHandler(object sender, UnhandledExceptionEventArgs args)
        {
            var ex = (Exception)args.ExceptionObject;
            Console.WriteLine($"Unhandled exception: {ex}");
            Console.Read(); // give us a chance to read exception
        }
    }
}
