using EmployeeNavigatorDataStructures.DataModels;
using System.Collections.Generic;

namespace EmployeeNavigatorDataStructures.HelperMethods
{
    public interface IManipulateData
    {
        string ConvertToListSelectOneByKeyAndReturnTimeStampOrDefault(IEnumerable<SimpleRecord> data);
        string ConvertToDictionarySelectOneByKeyAndReturnTimeStamp(IEnumerable<SimpleRecord> data);
        string ConvertToListSelectOneByKeyandReturnGuidOrDefault(IEnumerable<SimpleRecord> data);
        string ConvertToDictionarySelectOneByKeyAndReturnGuid(IEnumerable<SimpleRecord> data);
    }
}
