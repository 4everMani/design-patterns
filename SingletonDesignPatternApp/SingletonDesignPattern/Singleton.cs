using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class Singleton
    {
        private static int instanceCount = 0;

        private static Singleton instance;

        private static object lockObject = new Object();

        private Singleton() { }

        public static Singleton GetInstance()
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instanceCount += 1;
                    Console.WriteLine(instanceCount);
                    instance = new Singleton();
                }
            }
            return instance;
           
        }
    }
}
