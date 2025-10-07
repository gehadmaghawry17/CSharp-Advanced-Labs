using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class MyResource : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Resources cleaned up!");
        }
    }
}
