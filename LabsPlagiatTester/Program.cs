namespace LabsPlagiatTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var current = Directory.GetCurrentDirectory();
            var parent = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(current).FullName).FullName).FullName).FullName;
            parent = Path.Combine(parent, "WorksForPlagiat");
            //var lab1 = new Lab1(Path.Combine(parent, "Lab1"), "Lab1_report.txt");
            //var lab2 = new Lab2(Path.Combine(parent, "Lab2"), "Lab2_report.txt");
            //var lab3 = new Lab3(Path.Combine(parent, "Lab3"), "Lab3_report.txt");
            //var lab4 = new Lab4(Path.Combine(parent, "Lab4"), "Lab4_report.txt");
            //var lab5 = new Lab5(Path.Combine(parent, "Lab5"), "Lab5_report.txt");
            var cw1 = new CW(Path.Combine(parent, "CW1"), "CW1_report.txt");
            var cw2 = new CW(Path.Combine(parent, "CW2"), "CW2_report.txt");
            var recw1 = new CW(Path.Combine(parent, "ReCW1"), "ReCW1_report.txt");
            var recw2 = new CW(Path.Combine(parent, "ReCW2"), "ReCW2_report.txt");
        }
    }
}
