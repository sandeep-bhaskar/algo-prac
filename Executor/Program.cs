using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Executer
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<Type> executors;

            if (args.Any(_ => _ == "dev"))
            {
                executors = AppDomain.CurrentDomain.GetAssemblies()
               .SelectMany(s => s.GetTypes())
               .Where(p => typeof(IPracticeExecutor).IsAssignableFrom(p));
            }
            else
            {
                executors = AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(s => s.GetTypes())
                    .Where(p => typeof(IExecutor).IsAssignableFrom(p));
            }

            foreach (var item in executors)
            {
                if (item.Name != "IExecutor" && item.Name != "IPracticeExecutor")
                {
                    Stopwatch stopWatch = new Stopwatch();
                    stopWatch.Start();

                    try
                    {
                        (Activator.CreateInstance(item) as IExecutor).Execute();
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    stopWatch.Stop();
                    TimeSpan ts = stopWatch.Elapsed;
                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                        ts.Hours, ts.Minutes, ts.Seconds,
                        ts.Milliseconds / 10);

                    Console.WriteLine("RunTime " + elapsedTime);
                }
            }

            Console.ReadKey();
        }

    }
}
