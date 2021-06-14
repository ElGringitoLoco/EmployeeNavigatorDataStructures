using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeNavigatorDataStructures.HelperMethods
{
    public class DisplayData : IDisplayData
    {
		// Q. what this type of function is this? A bad one, it writes code to the console and evaluates code.
		// Single responsibility principle dictates you should not be doing both in the same method.
		// Consider putting the comparison in a logic class and the method to display the data in another. Better for testing and readability. Also more sustainable.

		/// <summary>
		/// A method that displays where data is equal to the user.
		/// </summary>		
		public void DisplayStringComparison(string s1, string s2, bool dataIsEqual)
		{
			Console.WriteLine("s1 == s2 ... true or false? {0}", dataIsEqual);
			Console.WriteLine("s1 = {0}", s1);
			Console.WriteLine("s2 = {0}", s2);
		}
	}
}
