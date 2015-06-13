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
        
        public FileManager()
        {}

        [Dependency]
        public IDataAccessObject DataAccessObject { get; set; }

        public bool FindLogFile(string fileName)
        {
            if (DataAccessObject == null)
            {
                throw new ArgumentNullException("DataAccessObkect","this arg is null");
            }
            List<string> files = DataAccessObject.GetFiles();

            foreach (var file in files)
            {
                if (file.Contains(fileName))
                    return true;
            }

            return false;
        }
    }
}
