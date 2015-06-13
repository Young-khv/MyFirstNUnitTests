using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class FactoryClass
    {
        static IDataAccessObject dataAccessObject;

        internal static IDataAccessObject CreateDataAccessObject()
        {
            if (dataAccessObject != null)
            {
                return dataAccessObject;
            }

            return new FIleDataObject();
        }

        public static void SetDataAccessObject(IDataAccessObject customDataObject)
        {
            dataAccessObject = customDataObject;
        }
    }
}
