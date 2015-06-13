using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Ninject;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void FindLogFIleTest()
        {
            IKernel ninjectKernel = new StandardKernel(new ConfigureFileObjectData());
            FileManager mgr = ninjectKernel.Get<FileManager>();
            Assert.IsTrue(mgr.FindLogFile("file2.log"));
        }
    }
}
