using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void FindLogFIleTest()
        {
            FactoryClass.SetDataAccessObject(new StubFIleDataObject());
            FileManager mgr = new FileManager();
          
            Assert.IsTrue(mgr.FindLogFile("file2.log"));
        }
    }
}
