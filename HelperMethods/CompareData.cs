namespace EmployeeNavigatorDataStructures.HelperMethods
{
    public class CompareData : ICompareData
    {
        /// <summary>
        /// Compare two strings and return whether or not they match exactly
        /// </summary>
        /// <param name="first">First String</param>
        /// <param name="second">Second String</param>
        /// <returns></returns>
        public bool CompareStrings(string first, string second)
        {
            return first == second;
        }
    }
}
