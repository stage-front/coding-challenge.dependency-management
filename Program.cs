using System;
using System.Collections.Generic;

namespace dependency_management
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static IEnumerable<string> ResolveDependencies(IEnumerable<Component> components)
        {
            throw new NotImplementedException();
        }

        public static void DisplayDependencyLoadOrder(IEnumerable<string> components)
        {
            foreach (var name in components)
            {
                Console.WriteLine(name);
            }
        }
    }
}
