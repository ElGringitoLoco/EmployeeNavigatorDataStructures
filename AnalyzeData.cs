using EmployeeNavigatorDataStructures.HelperMethods;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeNavigatorDataStructures
{    
    public class AnalyzeData
    {
        private readonly IDisplayData _DisplayData;
        private readonly IRetrieveData _RetrieveData;
        private readonly ICompareData _CompareData;
        private readonly IManipulateData _ManipulateData;

        public AnalyzeData(IDisplayData displayData,
        IRetrieveData retrieveData,
        ICompareData compareData,
        IManipulateData manipulateData)
        {
            _DisplayData = displayData;
            _RetrieveData = retrieveData;
            _CompareData = compareData;
            _ManipulateData = manipulateData;
        }

        public void Analyze()
        {
            // Ask: Given three differenet data structures that handle the data, describe each data structure
            // Data structure 1: Gets a list of IEnumerable<SimpleRecord> by looping through the alphabet.
            var data = _RetrieveData.GetItems();

            // Data structure 2: Converts a list of IEnumerable<SimpleRecord> to a list, selects one by key, and returns the timestamp.
            var timeStamp1 = _ManipulateData.ConvertToListSelectOneByKeyAndReturnTimeStampOrDefault(data);

            // Data structure 3: Converts a list of IEnumerable<SimpleRecord> to a dictionary, selects a time stamp by key and returns it.
            var timeStamp2 = _ManipulateData.ConvertToDictionarySelectOneByKeyAndReturnTimeStamp(data);

            // Q. What type of function is this?
            // Q. Are the timestamps equal?  Why or why not? 
            // They are now because I removed the yield statement from the comparison code, that was keeping things from working.
            var areTimeStampsEqual = _CompareData.CompareStrings(timeStamp1, timeStamp2);
            _DisplayData.DisplayStringComparison(timeStamp1, timeStamp2, areTimeStampsEqual);

            // now consider guid1 and guid2
            var guid1 = _ManipulateData.ConvertToListSelectOneByKeyandReturnGuidOrDefault(data);
            var guid2 = _ManipulateData.ConvertToDictionarySelectOneByKeyAndReturnGuid(data);

            // Q: what about the guids?
            var areGuidsEqual = _CompareData.CompareStrings(guid1, guid2);
            _DisplayData.DisplayStringComparison(guid1, guid2, areGuidsEqual);
        }
    }
}
