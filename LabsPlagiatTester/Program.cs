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
        }
    }
}
