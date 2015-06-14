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
           MockLogService mockLogService = new MockLogService();
           FileManager mgr = new FileManager(mockLogService);
           mgr.Analize("SomeFile.log");
           Assert.AreEqual("FileExtension error:SomeFile.log", mockLogService.lastError);
        }
    }
}
