using System;
using System.Threading.Tasks;

namespace LabsPlagiatTester
{
    public class CW : Lab
    {
        public CW(string folderPath, string reportName) : 
            base(folderPath, reportName, new int[] { 5 }, 1,
                new string[] { "{", "}", "// code here", "// end", "return" }) { }

        protected override string[] WorksComparer(string work1, string work2, out int count)
        {
            List<string> matchedTasks = new List<string>(0);
            string text1 = File.ReadAllText(work1);
            string text2 = File.ReadAllText(work2);
            string[] lines1 = text1.Split('\n');
            string[] lines2 = text2.Split('\n');
            int start1 = 0;
            int start2 = 0;
            int end1 = 1;
            int end2 = 1;
            count = 0;
                for (int task = 1; task <= Tasks.Length; task++)
                {
                    string startPhrase = $" Task_{task}";
                    string endPhrase = string.Empty;
                    if (task <= Tasks[0]) endPhrase = $" Task_{task + 1}";
                    while (start1 < lines1.Length && !lines1[start1].Contains(startPhrase))
                        start1++;
                    while (start2 < lines2.Length && !lines2[start2].Contains(startPhrase))
                        start2++;
                    end1 = start1 + 1;
                    end2 = start2 + 1;
                    while (end1 < lines1.Length && !lines1[end1].Contains(endPhrase))
                        end1++;
                    while (end2 < lines2.Length && !lines2[end2].Contains(endPhrase))
                        end2++;
                    string[] method = new string[0];
                //Console.Write(start1 + " " + (end1 - start1) + " ");
                //Console.WriteLine(start2 + " " + (end2 - start2) + " ");
                try
                    {
                        method = GetMatchedLines(lines1, lines2, start1, end1, start2, end2);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(work1);
                        Console.WriteLine(work2);
                        Console.WriteLine(ex.Message);
                        Console.WriteLine(ex.StackTrace);
                    }
                    if (method.Count() > 0)
                    {
                        count++;
                        matchedTasks.Add(lines1[start1]);
                        matchedTasks.AddRange(method);
                    }
                }
            return matchedTasks.ToArray();
        }
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
                for (int j = start2 + 1; j < end2; j++)
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
