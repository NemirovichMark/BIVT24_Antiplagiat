using System;
using System.Threading.Tasks;

namespace LabsPlagiatTester
{
    public class Lab5 : Lab
    {
        public Lab5(string folderPath, string reportName) : 
            base(folderPath, reportName, new int[] { 3, 28, 6, 1 }, 4,
                new string[] { "{", "}", "// code here", "// end", "return", "// create ", "// use " }) { }

        protected override string[] GetMatchedLines(string[] text1, string[] text2, int start1, int end1, int start2, int end2)
        {
            List<string> matched = new List<string>(0);
            int norms = 0;
            for (int i = start1 + 1; i < end1; i++)
            {
                bool baseLine = text1[i].Distinct().Count() <= 2;
                for (int k = 0; !baseLine && k < BaseLines.Length; k++)
                {
                    if (text1[i].Contains(BaseLines[k]))
                    {
                        baseLine = true;
                    }
                }
                if (baseLine) continue;
                norms++;
                for (int j = start2+1; j < end2; j++)
                {
                    if (text2[j].Distinct().Count() <= 2)
                        continue;
                    if (text1[i] == text2[j])
                    {
                        matched.Add(text1[i]);
                        break;
                    }
                }
            }
            int counter = matched.Distinct().Count();
            if (counter > 3 && (double)counter / norms >= 0.8)
            {
            }
            else
                matched.Clear();
            return matched.ToArray();
        }
    }
}
