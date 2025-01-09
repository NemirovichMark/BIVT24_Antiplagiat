using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

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
        if (Math.Abs(x * x + y * y - 2 * 2) <= 0.001)
        {
            answer = true;
        }

        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 & (y + Math.Abs(x)) <= 1) answer = true; 
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0) { answer = a > b ? a:b; }
        else { answer = a > b ? b:a; }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        answer = (a > b ? b : a) > c ? (a > b ? b : a):c ;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double R = Math.Sqrt(r/Math.PI);
        double d = Math.Sqrt(2 * s) / 2;
        if (R >= d) {  answer = true; }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double R = Math.Sqrt(r / Math.PI);
        double d = Math.Sqrt(s) / 2;
        if (d >= R) { answer = true; }
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1) {  answer = 1; }
        else { answer = Math.Abs(x); }
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1) { answer = 0; }
        else { answer = x*x - 1; }
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) { answer = 0; }
        else if (-1 < x & x <=0) { answer = 1 + x; }
        else { answer = 1; }
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) { answer = 1; }
        else if (-1 < x & x <= 1) { answer = -x; }
        else { answer = -1; }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0, s = 0, buf = 0;

        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out buf);
            s += buf;
        }
        answer = s / n;

        Console.WriteLine(answer);

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x, y;
        for (int i = 0; i < n; i++)
        {
        double.TryParse(Console.ReadLine(), out x);
        double.TryParse(Console.ReadLine(), out y);
        if (((x - a) * (x - a) + (y - b) * (y - b)) <= r * r) { answer++; }
        }
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0, s = 0, buf = 0;

        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out buf);
            s += buf < 30 ? 200 : 0;
        }
        answer = s / 1000;
        Console.WriteLine(answer);

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        double x, y;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x * x + y * y <= r2 * r2 && (x * x + y * y >= r1 * r1)) { answer++; }
        }
        Console.WriteLine(answer);

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        double res = 0;

        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out res);
            answer += res < norm ? 1 : 0;
        }
        Console.WriteLine(answer);

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        double x, y;

        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);

            if (y >= 0 && y <= Math.Sin(x) && x >= 0 && x <= Math.PI) answer++;
        }

        Console.WriteLine(answer);


        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        double x, y;

        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);

            answer1 += x > 0 && y > 0 ? 1 : 0;
            answer3 += x < 0 && y < 0 ? 1 : 0;

        }

        Console.WriteLine(answer1);
        Console.WriteLine(answer3);

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue, l = 0;
        double x, y;

        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);

            l = Math.Sqrt(x * x + y * y);
            if (answerLength > l)
            {
                answerLength = l;
                answer = i + 1;
            }

        }
        answer = n == 0 ? 0 : answer;
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue, time = 0;

        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out time);

            answer = time < answer ? time : answer;
        }
        answer = n == 0 ? 0 : answer;

        Console.WriteLine(answer);

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0, p, cnt = 0;

        for (int i = 1; i <= n * 4; i++)
        {
            int.TryParse(Console.ReadLine(), out p);
            cnt += p > 3 ? 1 : 0;
            if (i % 4 == 0)
            {
                answer += cnt == 4 ? 1 : 0;
                cnt = 0;
            }
        }
        Console.WriteLine(answer);

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0, p = 0, cnt = 0;
        double avg = 0.0;

        for (int i = 1; i <= n * 4; i++)
        {
            int.TryParse(Console.ReadLine(), out p);
            cnt += p == 2 ? 1 : 0;
            avg += p;
            if (i % 4 == 0)
            {
                answer += cnt >= 1 ? 1 : 0;
                cnt = 0;
            }
        }
        avg /= 4 * n;
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(avg, 2));


        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        if (r > 0)
        {
            switch (type)
            {
                case 0:
                    answer = r * r;
                    break;
                case 1:
                    answer = r * r * Math.PI;
                    break;
                case 2:
                    answer = r * r * Math.Sqrt(3) / 4;
                    break;
            }
        }
        answer = Math.Round(answer, 2);

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        if (A > 0 && B > 0)
        {
            switch (type)
            {
                case 0:
                    answer = A * B;
                    break;
                case 1:
                    answer = Math.PI * Math.Abs(B * B - A * A);
                    break;
                case 2:
                    double p = (A + B + B) / 2;
                    answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B));
                    break;
            }

        }
        answer = Math.Round(answer, 2);

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

        // answer should be equal to the task_2_1 answer
        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0, s = 0, buf = 0;
        while (true)
        {
            double.TryParse(Console.ReadLine(), out buf);
            if (buf == 0) { break; }
            s += buf < 30 ? 200 : 0;
        }
        answer = s / 1000;
        Console.WriteLine(answer);

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

        // end

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0;
        double x, y;
        do
        {
            bool f_check = double.TryParse(Console.ReadLine(), out x);
            if (!f_check) { break; }
            bool s_check = double.TryParse(Console.ReadLine(), out y);
            if (!s_check) { break; }
            if (x >= 0 && y >= 0)
            {
                if (x <= Math.PI && y <= Math.Sin(x)) { answer++; }
            }

        } while (true);
        Console.WriteLine(answer);


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

        // end

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue, time = 0;
        int n = 0;
        while (true)
        {
            double.TryParse(Console.ReadLine(), out time);
            if (time == 0) { break ; }
            answer = time < answer ? time : answer;
            n++;
        }
        answer = n == 0 ? 0 : answer;

        Console.WriteLine(answer);

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

        // end

        return (answer, avg);
    }
    #endregion
}