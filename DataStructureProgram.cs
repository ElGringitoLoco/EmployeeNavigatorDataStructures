using EmployeeNavigatorDataStructures;
using EmployeeNavigatorDataStructures.HelperMethods;

public class DataStructureProgram
{
	public static void Main()
	{
		var analyzeData = new AnalyzeData(
			new DisplayData(),
			new RetrieveData(),
			new CompareData(),
			new ManipulateData()
			);

		analyzeData.Analyze();		
	}
}