using System;

namespace LabsPlagiatTester
{
    public class Lab1 : Lab
    {
        public Lab1(string folderPath, string reportName) : 
            base(folderPath, reportName, new int[] { 18, 10, 9 }, 5) { }
    }
}
