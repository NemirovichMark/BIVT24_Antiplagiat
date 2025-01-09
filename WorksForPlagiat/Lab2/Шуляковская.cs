using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(0.9, 1.23);
        //program.Task_1_2(0.9, 1.23);
        //program.Task_1_3(0.9, 1.23);
        //program.Task_1_4(0.9, 1.23, -0.1);
        //program.Task_1_5(0.9, 1.23);
        //program.Task_1_6(0.9, 1.23);
        //program.Task_1_7(0.9);
        //program.Task_1_8(0.9);
        //program.Task_1_9(0.9);
        //program.Task_1_10(0.9);
        //program.Task_2_1(10);
        //program.Task_2_2(5, 3, 2, 1);
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(6);
        //program.Task_2_4(3, 1, 3);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(3);
        //program.Task_2_7(3);
        //program.Task_2_8(4);
        //program.Task_2_9(10);
        //program.Task_2_10(6);
        program.Task_2_11(10);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 2);
        //program.Task_3_5(30);
        //program.Task_3_6();
        //program.Task_3_7();
        //program.Task_3_8();
        //program.Task_3_9();
        //program.Task_3_10();
        program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        int r = 2;
        if (Math.Abs(x * x + y * y - r * r) <= 0.001) answer = true;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && Math.Abs(x) + y <= 1) answer = true;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        double c = a;
        if (a > 0)
        {
            if (b > a) c = b;
        }
        else if (b < a) c = b;
        answer = c;
        
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double pr;
        pr = a < b ? a : b;
        answer = pr > c ? pr : c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (2 * s <= 4 * r / Math.PI && r!=0) answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (4 * r / Math.PI <= s && s > 0)  answer = true;
        

        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (x > 1 || x < -1) answer = 1;
        else answer = Math.Abs(x);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (x >= 1 || x <= -1) answer = 0;
        else answer = x * x - 1;
        
       
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 0;
        else if (x <= 0) answer = 1 + x;
        else answer = 1;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        else if (x <= 1) answer = -x;
        else answer = -1;
        
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double s = 0;
        for (int i = 1; i<=n; i++)
        {
            if (double.TryParse(Console.ReadLine(), out double r) && r>0) s += r;
            else i -= 1;
            
        }
        answer = s / n;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int i = 1; i<=n; i++)
        {
            if (double.TryParse(Console.ReadLine(), out double x) && double.TryParse(Console.ReadLine(), out double y))
            {
                if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r) answer++;
            }
            else i--;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for (int i = 1; i<=n; i++)
        {
            if (double.TryParse(Console.ReadLine(), out double w))
            {
                if (w < 30) answer += 0.2;

            }
            else i--;

        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 1; i<=n; i++)
        {
            if (double.TryParse(Console.ReadLine(), out double x) && double.TryParse(Console.ReadLine(), out double y))
            {
                if (x*x+y*y>=r1*r1 && x*x+y*y<=r2*r2) answer++;
            }
            else i--;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i = 1; i<=n; i++)
        {
            if (double.TryParse(Console.ReadLine(), out double res) && res > 0)
            {
                if (res <= norm) answer++;
            }
            else i--;
        }
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = 1;i<=n; i++)
        {
            if (double.TryParse(Console.ReadLine(), out double x)&&  double.TryParse(Console.ReadLine(),out double y))
            {
                if (y >= 0 && x >= 0 && x <= Math.PI & y <= Math.Sin(x)) answer++;
            }
            else i--;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for (int i = 1; i<=n; i++)
        {
            if (double.TryParse(Console.ReadLine(), out double x) && double.TryParse(Console.ReadLine(), out double y))
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine('1');
                    answer1++;
                }
                else if (x < 0 && y > 0) Console.WriteLine('2');
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine('3');
                    answer3++;
                }
                else if (x > 0 && y < 0) Console.WriteLine('4'); ;
            }
            else i--;
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        for (int i = 1;i<=n; i++)
        {
            if (double.TryParse(Console.ReadLine(), out double x) && double.TryParse(Console.ReadLine(), out double y))
            {
                double dist = Math.Pow(x * x + y * y, 0.5);
                if (dist < answerLength)
                {
                    answerLength = dist;
                    answer = i;
                }
            }
            else i--;
        }
        answerLength=Math.Round(answerLength, 2);
        Console.WriteLine($"{answer}, {answerLength}");
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        
        for (int i = 1; i<=n; i++)
        {
            if (double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out double res))
            {
                if (res < answer) answer = res;
            }
            else i--;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 1; i<=n; i++)
        {
            int good = 0;
            for (int j = 1; j<=4; j++)
            {
                
                int mark=int.Parse(Console.ReadLine());
                if (mark >= 4) good++;
            }
            if (good == 4) answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double sum = 0;
        for( int i = 1; i <= n; i++)
        {
            int bad = 0;
            for (int j = 1; j<=4; j++)
            {
                int mark = int.Parse(Console.ReadLine());
                if (mark < 3) bad++;
                sum += mark;
            }
            if (bad > 0) answer++;
        }
        avg = sum / (n * 4);
        Console.WriteLine($"{answer}, {avg}");
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r > 0)
        {
            switch (type)
            {
                case 0: answer = r * r; break;
                case 1: answer = Math.PI * r * r; break;
                case 2: answer = r * r * Math.Sqrt(3) / 4; break;
                default: break;
            }
            answer = Math.Round(answer, 2);
        }
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A>0 && B > 0)
        {
            switch (type)
            {
                case 0: answer = A * B; break;
                case 1: answer = Math.Abs(Math.PI * (A * A - B * B)); break;
                case 2: double h = Math.Sqrt(B*B-A*A/4); answer = A / 2 * h; break;
                default: break;
            }
            answer=Math.Round(answer, 2);
        }
        // end

        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()   // 2; 5; 8; 11
    {
        double answer = 0;
        int n = 0;

        // code here

        // end

        // answer should be equal to the task_2_1 answer
        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here
        Console.WriteLine("¬ведите stop дл€ окончани€ программы:");
        while (true)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            if (s1 == "stop" || s2 == "stop") break;
            if (double.TryParse(s1, out double x) && double.TryParse(s2, out double y))
            {
                if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r) answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here
        Console.WriteLine("¬ведите stop дл€ окончани€ программы:");
        while (true)
        {
            string s = Console.ReadLine();
            if (s == "stop") break;
            if (double.TryParse(s, out double x) && x <= norm) answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here
        Console.WriteLine("¬ведите stop дл€ окончани€ программы:");
        while (true)
        {
            string s1= Console.ReadLine();
            string s2 = Console.ReadLine();
            if (s1 == "stop" || s2 == "stop") break;
            if (double.TryParse(s1, out double x) && double.TryParse(s2, out double y))
            {
                n++;
                double dist = Math.Pow(x * x + y * y, 0.5);
                if (dist < answerLength)
                {
                    answerLength = dist;
                    answer = n;
                }
            }
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine($"{answer}, {answerLength}");
        // end

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;

        // end

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;
        Console.WriteLine("¬ведите stop дл€ окончани€ программы:");
        double sum = 0;
        bool Flag = false;
        while (true)
        {
            int bad = 0;
            for (int j = 1; j <= 4; j++)
            {
                string s = Console.ReadLine();
                if (s == "stop") 
                {
                    Flag = true;
                    break; 
                }
                if (int.TryParse(s, out int mark))
                {
                    if (mark < 3) bad++;
                    sum += mark;
                }
                else j--;
            }
            if (Flag) break;
            if (bad > 0) answer++;
            n++;
        }
        avg = sum / n / 4;
        Console.WriteLine($"{answer}, {avg}");
        // end

        return (answer, avg);
    }
    #endregion
}
