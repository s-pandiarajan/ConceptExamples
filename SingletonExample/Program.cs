using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton instance = Singleton.Instance;
            Singleton instance2 = Singleton.Instance;

            bool isEqual = instance.Equals(instance2);
            Console.WriteLine("Singleton instance are equal? {0}", isEqual);

            LazySingleton lInstance = LazySingleton.Instace;
            LazySingleton lInstance1 = LazySingleton.Instace;

            bool isEqualLazy = lInstance.Equals(lInstance1);
            Console.WriteLine("LazySingleton instance are equal? {0}", isEqualLazy);

        }
    }
}
