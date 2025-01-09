namespace LabsPlagiatTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var current = Directory.GetCurrentDirectory();
            var parent = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(current).FullName).FullName).FullName).FullName;
            parent = Path.Combine(parent, "WorksForPlagiat");
            var lab1 = new Lab1(Path.Combine(parent, "Lab1"), "Lab1_report.txt");
            var lab2 = new Lab2(Path.Combine(parent, "Lab2"), "Lab2_report.txt");
            var lab3 = new Lab3(Path.Combine(parent, "Lab3"), "Lab3_report.txt");
            var lab4 = new Lab4(Path.Combine(parent, "Lab4"), "Lab4_report.txt");
            var lab5 = new Lab5(Path.Combine(parent, "Lab5"), "Lab5_report.txt");
        }
    }
}
