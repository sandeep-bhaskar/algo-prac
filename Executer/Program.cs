using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Executer
{
    class Program
    {
        static void Main(string[] args)
        {
            var executers = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => typeof(IExecutor).IsAssignableFrom(p));

            foreach (var item in executers)
            {
                if (item.Name != "IExecutor")
                    (Activator.CreateInstance(item) as IExecutor).Execute();
            }

            Console.ReadKey();
        }

    }
}
