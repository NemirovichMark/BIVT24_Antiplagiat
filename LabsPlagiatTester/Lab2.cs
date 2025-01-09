using System;

namespace LabsPlagiatTester
{
    public class Lab2 : Lab
    {
        public Lab2(string folderPath, string reportName) : 
            base(folderPath, reportName, new int[] { 10, 13, 13 }, 5) { }
    }
}
