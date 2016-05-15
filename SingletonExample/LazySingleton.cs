using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    public class LazySingleton
    {
        private static readonly Lazy<LazySingleton> lazy = new Lazy<LazySingleton>(() => new LazySingleton(), true );

        private LazySingleton() { }

        public static LazySingleton Instace { get { return lazy.Value; } }

        public void DoSomething()
        {
            Console.WriteLine("DoSomething is writeline");
        }
    }
}
