using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace Tests
{
    class FileManager
    {
        public IDataAccessObject dataAccessObject; 
        public FileManager()
        {}

        public FileManager(IDataAccessObject dataAccessObject)
        {
            this.dataAccessObject = dataAccessObject;
        }

        public bool FindLogFile(string fileName)
        {
            if (dataAccessObject == null)
            {
                throw new ArgumentNullException("DataAccessObkect","this arg is null");
            }
            List<string> files = dataAccessObject.GetFiles();

            foreach (var file in files)
            {
                if (file.Contains(fileName))
                    return true;
            }

            return false;
        }
    }
}
