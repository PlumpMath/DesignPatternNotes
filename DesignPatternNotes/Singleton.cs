using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternNotes
{
    // Class is not threadsafe (due to timing)
    // Instance methods generally aren't threadsafe
    public class Singleton
    {
        private static class SingletonHolder
        {
            internal static readonly Singleton instance = new Singleton();
            // Empty static constructor - forces laziness
            static SingletonHolder() { }
        }

        public static Singleton Instance { get { return SingletonHolder.instance; } }

        private Singleton()
        {
            // Stuff that must only happen once
            Console.WriteLine("Singleton Constructor");
        }

        public static void SayHi()
        {
            Console.WriteLine("Hi There");
        }

        // Raison d'etre for the class
        public void DoSomething()
        {
            // This must be thread-safe!
            Console.WriteLine("Do something");
        }
    }
}
