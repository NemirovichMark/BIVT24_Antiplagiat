using System;

namespace LabsPlagiatTester
{
    public class Lab2 : Lab
    {
        public Lab2(string folderPath, string reportName) : 
            base(folderPath, reportName, new int[] { 10, 13, 11 }, 6,
                new string[] { "{", "}", "// code here", "// end", "return", "// for test input in console", "// answer should be equal to the task" }) { }
    }
}
