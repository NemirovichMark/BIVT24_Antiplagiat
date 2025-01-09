using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
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
        //program.Task_2_3(10);
        //program.Task_2_4(5, 1, 2);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(5);
        //program.Task_2_7(5);
        //program.Task_2_8(10);
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
        if (Math.Abs(x * x + y * y - 4) <= 0.001)
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && (y + Math.Abs(x) <= 1))
            answer = true;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if ((a > 0 && a > b) || (a <= 0 && a < b))
            answer = a;
        else
            answer = b;
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        if (a < b && a > c)
            answer = a;
        else if (a > b && b > c)
            answer = b;
        else
            answer = c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (Math.Sqrt(2 * s) < (r / Math.PI))
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if ((2 * Math.Sqrt(r / Math.PI)) < Math.Sqrt(s))
            answer = true;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1)
            answer = 1;
        else
            answer = Math.Abs(x);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) < 1)
            answer = x * x - 1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 0;
        else if (x > 0)
            answer = 1;
        else
            answer = 1 + x;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 1;
        else if (x > 1)
            answer = -1;
        else
            answer = -x;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            answer += double.Parse(Console.ReadLine());
        }
        answer /= n;
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (Math.Sqrt((x - a) * (x - a) + (y - b) * (y - b)) <= r)
                answer++;
        }
        // end
        
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double sm = 0;
        for (int i = 1; i <= n; i++)
        {
            sm = double.Parse(Console.ReadLine());
            if (sm < 30)
                answer += 0.2;
        }
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            double chs = Math.Sqrt(x * x + y * y);
            if (chs >= r1 && chs <= r2)
                answer++;
        }
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double rs;
        for (int i = 1; i <= n; i++)
        {
            rs = double.Parse(Console.ReadLine());
            if (rs <= norm)
                answer++;
        }
        
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ((x >= 0 && x <= Math.PI) && (y >= 0 && y <= 1) && Math.Sin(x) >= y)
                answer++;
        }
        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        double x, y;
        int k;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse((Console.ReadLine()));
            y = double.Parse((Console.ReadLine()));
            if (x > 0)
            {
                if (y > 0) k = 1;
                else k = 4;
            }
            else
            {
                if (y > 0) k = 2;
                else k = 3;
            }
            Console.WriteLine("Точка находится в {0} квадранте", k);
            switch (k)
            {
                case 1:
                    answer1++;
                    break;
                case 3:
                    answer3++;
                    break;
            }
        }
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x, y, ln;
        for (int i = 1; i <= (n / 2); i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            ln = Math.Sqrt(x * x + y * y);
            if (ln <= answerLength)
            {
                answerLength = ln;
                answer = i;
            }
        }
        
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double x;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            if (x < answer)
                answer = x;
        }
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int m1, m2, m3, m4;
        for (int i = 1; i <= n; i++)
        {
            m1 = int.Parse(Console.ReadLine());
            m2 = int.Parse(Console.ReadLine());
            m3 = int.Parse(Console.ReadLine());
            m4 = int.Parse(Console.ReadLine());
            if (m1 > 3 && m2 > 3 && m3 > 3 && m4 > 3)
                answer++;
        }
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double m1, m2, m3, m4;
        for (int i = 1; i <= n; i++)
        {
            m1 = double.Parse(Console.ReadLine());
            m2 = double.Parse(Console.ReadLine());
            m3 = double.Parse(Console.ReadLine());
            m4 = double.Parse(Console.ReadLine());
            if (m1 == 2 || m2 == 2 || m3 == 2 || m4 == 2)
                answer++;
            avg += (m1 + m2 + m3 + m4) / 4;
        }
        avg /= n;
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

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
                case 0:
                    answer = Math.Round(r * r, 2);
                    break;
                case 1:
                    answer = Math.Round(Math.PI * (r * r), 2);
                    break;
                case 2:
                    answer = Math.Round((r * r * Math.Sqrt(3)) / 4, 2);
                    break;
                default:
                    break;
            }
        }
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
                    answer = Math.Round(A * B, 2);
                    break;
                case 1:
                    if (B > A)
                        answer = Math.Round(Math.PI * (B * B - A * A), 2);
                    else
                        answer = Math.Round(Math.PI * (A * A - B * B), 2);
                    break;
                case 2:
                    answer = Math.Round(0.5 * Math.Sqrt(B * B - 0.25 * A * A) * A, 2);
                    break;
            }
        }
        // end

        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;
        
        // code here

        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here
        double x, y; string s1, s2;
        while (true)
        {
            s1 = Console.ReadLine();
            if (s1 == "end") break;
            s2 = Console.ReadLine();
            if (s2 == "end") break;
            x = double.Parse(s1); y = double.Parse(s2);
            if (Math.Sqrt((x - a) * (x - a) + (y - b) * (y - b)) <= r)
                answer++;
        }
        // end
        
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_3 answer

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_4 answer

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here
        double rs; string srs;
        while (true)
        {
            srs = Console.ReadLine();
            if (srs == "end") break;
            rs = double.Parse(srs);
            if (rs <= norm)
                answer++;
        }
        // end
        
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1
        // answer should be equal to the task_2_6 answer

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_7 answer

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here
        double x, y, ln; string s1, s2;
        for (int i = 1; ; i++)
        {
            s1 = Console.ReadLine();
            if (s1 == "end") break;
            s2 = Console.ReadLine();
            if (s2 == "end") break;
            x = double.Parse(s1); y = double.Parse(s2);
            ln = Math.Sqrt(x * x + y * y);
            if (ln <= answerLength)
            {
                answerLength = ln;
                answer = i;
            }
        }
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_8 answer

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_9 answer

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_10 answer

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;
        double m1, m2, m3, m4, i = 0; string s1, s2, s3, s4;
        while (true)
        {
            s1 = Console.ReadLine(); if (s1 == "end") break;
            s2 = Console.ReadLine(); if (s2 == "end") break;
            s3 = Console.ReadLine(); if (s3 == "end") break;
            s4 = Console.ReadLine(); if (s4 == "end") break;
            m1 = double.Parse(s1); m2 = double.Parse(s2); m3 = double.Parse(s3); m4 = double.Parse(s4);
            if (m1 == 2 || m2 == 2 || m3 == 2 || m4 == 2)
                answer++;
            avg += (m1 + m2 + m3 + m4) / 4;
            i++;
        }
        if (i != 0)
            avg /= i;
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_11 answer

        return (answer, avg);
    }
    public double Task_3_12(double r, int type)
    {
        double answer = 0;

        // code here;

        // end
        // answer should be equal to the task_2_12 answer

        return answer;
    }
    public double Task_3_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;

        // end
        // answer should be equal to the task_2_13 answer

        return answer;
    }
    #endregion
}
