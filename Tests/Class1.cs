using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Ninject;
using NUnit.Framework;
using Rhino.Mocks;

namespace Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void FindLogFIleTest()
        {
            MockRepository rhinoEngine = new MockRepository();

            ILogService logService = rhinoEngine.DynamicMock<ILogService>();
            using (rhinoEngine.Record())
            {
                logService.LogError("EEE");
            }
            logService.LogError("EEE");
            rhinoEngine.Verify(logService);
        }

        [Test]
        public static void FileManagerTestMock()
        {
            string fileName = "TestFileName.exe";

            MockRepository rhino = new MockRepository();
            ILogService logService = rhino.DynamicMock<ILogService>();
            using (rhino.Record())
            {
                logService.LogError("FileExtension error:"+fileName);
            }
            FileManager mgr = new FileManager(logService);
            mgr.Analize(fileName);
            rhino.Verify(logService);
        }
    }
}
