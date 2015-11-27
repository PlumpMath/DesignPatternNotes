using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternNotes
{
    [TestClass]
    public class SingletonTest
    {
        [TestMethod]
        public void UseSingleton()
        {
            Singleton.SayHi();
            Console.WriteLine("Start of test");
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;

            Assert.AreSame(s1, s2);
        }
        
    }
}
