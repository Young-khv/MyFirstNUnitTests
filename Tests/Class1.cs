using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void FindLogFIleTest()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IDataAccessObject, StubFIleDataObject>();
            FileManager mgr = container.Resolve<FileManager>();
            Assert.IsTrue(mgr.FindLogFile("file2.log"));
        }
    }
}
