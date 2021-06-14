using EmployeeNavigatorDataStructures.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeNavigatorDataStructures.HelperMethods
{
    public interface IRetrieveData
    {
        IEnumerable<SimpleRecord> GetItems();
    }
}
