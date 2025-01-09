using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

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
        //program.Task_2_3(10);
        //program.Task_2_4(5, 1, 2);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(5);
        //program.Task_2_7(5);
        //program.Task_2_8(5);
        //program.Task_2_9(10);
        //program.Task_2_10(10);
        //program.Task_2_11(10);
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
        //program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        double r = 2;
        if ( Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -3) )
        {
            answer = true;
        }
        else 
        { 
            answer = false; 
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if ((y >= 0) && (y + Math.Abs(x)) <= 1)
        {
            answer = true;
        }
        else { answer = false; }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)
        {
            if (a > b)
                answer = a; 
            else 
                answer = b;
        }
        else 
        { 
            if (a < b) 
                answer = a;
            else 
                answer = b;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        if (a < b)
        {
            if (a > c)
                answer = a;
            else
                answer = c;
        }
        else
        {
            if (b > c)
                answer = b;
            else 
                answer = c;
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double diag = Math.Sqrt(2 * s);
        double diam = 2 * Math.Sqrt(r / Math.PI);
        if (diag <= diam)
            answer = true;
        else
            answer = false;

        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double a = Math.Sqrt(s);
        double d = 2 * Math.Sqrt(r / Math.PI);
        if (d <= a)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1)
        {
            answer = 1;
        }
        else
        {
            answer = Math.Abs(x);
        }
        // end

            return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1)
        {
            answer = 0;
        }
        else
        {
            answer = x * x - 1;
        }
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
        {
            answer = 0;
        }
        else if (x > -1 && x <= 0)
        {
            answer = x + 1;
        }
        else if (x > 0)
        {
            answer = 1;
        }
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
        {
            answer = 1;
        }
        else if (x > -1 && x <= 1)
        {
            answer = -x;
        }
        else if (x > 1)
        {
            answer = -1;
        }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double s = 0, h;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out h);
            s += h;
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
        double x, y;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (((x - a) * (x - a) + (y - b) * (y - b)) <= r * r)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double w;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out w);
            if (w < 30)
            {
                answer += 0.2;
            }
        }
        answer = Math.Round(answer, 1);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((x * x + y * y >= r1 * r1) && (x * x + y * y <= r2 * r2))
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double rez;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out rez);
            if (rez <= norm)
            {
                answer += 1;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (y >= 0 && x >= 0 && x <= Math.PI && Math.Sin(x) >= y)
            {
                answer++;
            }
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
        double x, y;
        int i = 1, f1 = 0, f3 = 0;
        while (i <= n)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x > 0 && y > 0)
            {
                f1++;
                Console.WriteLine($"{i} точка находится в I квадранте");
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine($"{i} точка находится в II квадранте");
            }
            if (x < 0 && y < 0)
            {
                f3++;
                Console.WriteLine($"{i} точка находится в III квадранте");
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine($"{i} точка находится в IV квадранте");
            }
            i++;
        }
        answer1 = f1;
        answer3 = f3;
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
        double m = double.MaxValue;
        double x, y;
        int k = 0;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            double d = Math.Sqrt(x * x + y * y);
            if (d < m)
            {
                m = d;
                k = i;
            }
        }
        answer = k;
        answerLength = Math.Round(m, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double best = 0, k;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out k);
            if (best == 0)
            {
                best = k;
            }
            else if (k < best)
            {
                best = k;
            }
        }
        Console.WriteLine(best);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        double x, y, z, v;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            double.TryParse(Console.ReadLine(), out z);
            double.TryParse(Console.ReadLine(), out v);
            if (x == 2 || x == 3 || y == 2 || y == 3 || z == 2 || z == 3 || v == 2 || v == 3)
            {
                continue;
            }
            else
            {
                answer++;
            }
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
        double x, y, z, v;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            double.TryParse(Console.ReadLine(), out z);
            double.TryParse(Console.ReadLine(), out v);
            if (x == 2 || y == 2 || z == 2 || v == 2)
            {
                answer++;
            }
            avg += x + y + z + v;
        }
        avg = avg / (n * 4);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r < 0) return 0;
        switch (type)
        {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = Math.PI * r * r;
                break;
            case 2:
                answer = (r * r * Math.Sqrt(3)) / 4;
                break;
            default:
                break;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A > 0 && B > 0)
        {
            switch (type)
            {
                case 0:
                    answer = A * B;
                    break;
                case 1:
                    answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                    break;
                case 2:
                    answer = (A * Math.Sqrt(B * B - A * A / 4)) / 2;
                    break;
                default:
                    break;
            }
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    #endregion

    #region Level 3
    // 2, 5, 8, 11
    public double Task_3_1()
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
        double x, y;
        while (true)
        {
            string f = Console.ReadLine();
            if (f == "?")
            {
                break;
            }
            else
            {
                double.TryParse(f, out x);
                double.TryParse(Console.ReadLine(), out y);
                if (Math.Sqrt((x - a) * (x - a) + (y - b) * (y - b)) <= r)
                {
                    answer++;
                }
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
        int answer = 0;
        double n = 0;

        // code here
        while (true)
        {
            string f = Console.ReadLine();
            if (f == "?")
            {
                break;
            }
            else
            {
                double.TryParse(f, out n);
                if (n <= norm)
                {
                    answer++;
                }
            }
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
        double x = 0;
        double y = 0;
        double d = 0;
        int i = 0;
        while (true)
        {
            string f = Console.ReadLine();
            if (f == "?")
            {
                break;
            }
            else
            {
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());
                d = Math.Sqrt(y * y + x * x);
                i++;
                if (d <= answerLength)
                {
                    answerLength = d;
                    answer = i;
                }
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength, 2));
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
        double x, y, z, v;
        while (true)
        {
            string f = Console.ReadLine();
            if (f == "-")
            {
                if (n > 0)
                {
                    avg = avg / (n * 4);
                    Console.WriteLine(answer);
                    Console.WriteLine(avg);
                    break;
                }
            }
            double.TryParse(f, out x);
            double.TryParse(Console.ReadLine(), out y);
            double.TryParse(Console.ReadLine(), out z);
            double.TryParse(Console.ReadLine(), out v);

            n++;

            if (x == 2 || y == 2 || z == 2 || v == 2)
            {
                answer++;
            }
            avg += x + y + z + v;
        }
            // end

            return (answer, avg);
    }
    #endregion
}