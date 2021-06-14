using EmployeeNavigatorDataStructures.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeNavigatorDataStructures.HelperMethods
{
    public class RetrieveData : IRetrieveData
	{
		/// <summary>
		/// A function that gets a list of simple records by looping through the alphabet.
		/// </summary>
		/// <returns>List of simple records</returns>
		public IEnumerable<SimpleRecord> GetItems()
		{
			for (char c = 'A'; c <= 'z'; c++)
			{
				yield return
					new SimpleRecord(c.ToString(),
							 DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff"),
							 Guid.NewGuid().ToString());
			}
		}
	}
}
