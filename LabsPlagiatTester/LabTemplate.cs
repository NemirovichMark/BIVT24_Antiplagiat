using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LabsPlagiatTester
{
    public class Lab
    {
        private string _folderPath;
        private Dictionary<string, (string, int, string[])> _copies = new Dictionary<string, (string, int, string[])>();
        private string _report;
        private int[] _tasks;
        private int _limit;
        private string[] _baseLines;
        protected int[] Tasks => _tasks;
        protected string[] BaseLines => _baseLines;

        /// <summary>
        /// Create report about plagiarism between works
        /// </summary>
        /// <param name="folderPath"></param>
        /// <param name="reportName"></param>
        /// <param name="tasks"></param>
        /// <param name="limit"></param>
        public Lab(string folderPath, string reportName, int[] tasks, int limit, string[] baseLines)
        {
            _folderPath = folderPath;
            _tasks = tasks;
            _limit = limit;
            _baseLines = baseLines;
            FindCopies();
            string reportPath = Path.Combine(Directory.GetParent(_folderPath).FullName, reportName);
            if (File.Exists(reportPath))
            {
                File.Delete(reportPath);
            }
            using (StreamWriter writter = new StreamWriter(reportPath))
            {
                writter.Write(_report);
            }
        }

        private void FindCopies()
        {
            string[] works = Directory.GetFiles(_folderPath);
            int rogues = 0;
            for (int i = 0; i < works.Length; i++)
            {
                Console.WriteLine(works[i]);
                for (int j = i + 1; j < works.Length; j++)
                {
                    var tasks = WorksComparer(works[i], works[j], out int count);
                    if (count >= _limit)
                    {
                        _copies.TryAdd(works[i], (works[j], count, tasks));
                        rogues++;
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            Console.WriteLine(rogues);
            sb.AppendLine(rogues.ToString());
            foreach (var copy in _copies)
            {
                sb.AppendLine(copy.Key.ToString());
                sb.AppendLine(copy.Value.Item1.ToString());
                sb.AppendLine(copy.Value.Item2.ToString());
                Console.WriteLine(copy.Key);
                Console.WriteLine(copy.Value.Item1);
                Console.WriteLine(copy.Value.Item2);
                foreach (var task in copy.Value.Item3)
                {
                    Console.WriteLine(task);
                    sb.Append(task.ToString());
                }
                sb.AppendLine();
                Console.WriteLine();
            }
            _report = sb.ToString();
        }

        protected virtual string[] WorksComparer(string work1, string work2, out int count)
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
            for (int lvl = 1; lvl <= _tasks.Length; lvl++)
            {
                for (int task = 1; task <= _tasks[lvl - 1]; task++)
                {
                    string startPhrase = $" Task_{lvl}_{task}";
                    string endPhrase;
                    if (task < _tasks[lvl - 1]) endPhrase = $" Task_{lvl}_{task + 1}";
                    else endPhrase = $"#endregion";
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
            }
            return matchedTasks.ToArray();
        }

        protected virtual string[] GetMatchedLines(string[] text1, string[] text2, int start1, int end1, int start2, int end2)
        {
            List<string> matched = new List<string>(0);
            int norms = 0;
            for (int i = start1 + 1; i < end1; i++)
            {
                bool baseLine = text1[i].Distinct().Count() <= 2;
                for (int k = 0; !baseLine && k < _baseLines.Length; k++)
                {
                    if (text1[i].Contains(_baseLines[k]))
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