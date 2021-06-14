using EmployeeNavigatorDataStructures.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeNavigatorDataStructures.HelperMethods
{
    public class ManipulateData : IManipulateData
    {
        /// <summary>
        /// Converts a list of IEnumerable<SimpleRecord> to a list, selects one by key, and returns the timestamp.
        /// </summary>
        /// <param name="data">List of simple records</param>
        /// <returns>Returns the matched timestamp</returns>
        public string ConvertToListSelectOneByKeyAndReturnTimeStampOrDefault(IEnumerable<SimpleRecord> data)
        {
            return data.ToList() // data structure 2
                .Where(x => x.Key == "M")
                .Select(x => x.Timestamp)
                .SingleOrDefault();
        }

        /// <summary>
        /// Converts a list of IEnumerable<SimpleRecord> to a dictionary, selects a time stamp by key and returns it.
        /// </summary>
        /// <param name="data">List of simple records</param>
        /// <returns>Returns the matched timestamp</returns>
        public string ConvertToDictionarySelectOneByKeyAndReturnTimeStamp(IEnumerable<SimpleRecord> data)
        {
            return data.ToDictionary(k => k.Key, v => v.Timestamp)["M"];
        }

        public string ConvertToListSelectOneByKeyandReturnGuidOrDefault(IEnumerable<SimpleRecord> data)
        {
            return data.ToList()
                .Where(x => x.Key == "M")
                .Select(x => x.Guid)
                .SingleOrDefault();
        }

        public string ConvertToDictionarySelectOneByKeyAndReturnGuid(IEnumerable<SimpleRecord> data)
        {
            return data.ToDictionary(k => k.Key, v => v.Guid)["M"];
        }
    }
}
