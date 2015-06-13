using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace Tests
{
    class ConfigureFileObjectData: NinjectModule
    {
        public override void Load()
        {
            this.Bind<IDataAccessObject>().To<StubFIleDataObject>();
            this.Bind<FileManager>().ToSelf();
        }
    }
}
