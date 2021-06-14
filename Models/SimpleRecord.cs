using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeNavigatorDataStructures.DataModels
{
	// A class representing a simple record
	public class SimpleRecord
	{
		public string Key { get; private set; }
		public string Timestamp { get; private set; }
		public string Guid { get; private set; }
		public SimpleRecord(string key, string timestamp, string guid)
		{
			Key = key;
			Timestamp = timestamp;
			Guid = guid;
		}
	}
}
