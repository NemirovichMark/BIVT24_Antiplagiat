using System;

namespace LabsPlagiatTester
{
    public class Lab3 : Lab
    {
        public Lab3(string folderPath, string reportName) : 
            base(folderPath, reportName, new int[] { 15, 20, 14 }, 5,
                new string[] { "{", "}", "// code here", "// end", "return" }) { }
    }
}
