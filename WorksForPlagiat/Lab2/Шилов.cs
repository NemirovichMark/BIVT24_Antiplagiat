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
        //program.Task_2_2(5, 2, 1, 2);
        //program.Task_2_3(10);
        //program.Task_2_4(5, 1, 3);
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
        //program.Task_3_2(2);
        //program.Task_3_3();
        //program.Task_3_4(1, 3);
        //program.Task_3_5(30);
        //program.Task_3_6();
        //program.Task_3_7();
        //program.Task_3_8();
        //program.Task_3_9();
        //program.Task_3_10();
        //program.Task_3_11();
        //program.Task_3_12( 10, 0);
        program.Task_3_13( 10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;
        int r = 2;
        if (Math.Abs(x * x + y * y - r * r) <= 0.001)
        {
            answer = true;
        }

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        if (y >= 0 && y + Math.Abs(x) <= 1)
        {
            answer = true;
        }

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;
        double mx = a, mn = b;

        if (a < b)
        {
            mx = b; mn = a;
        }
        double c = a > 0 ? mx : mn;
        answer = c;

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        double mn = a < b ? a : b;
        answer = mn > c ? mn : c;

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;
        double di, d;
        di = 2 * Math.Sqrt(r / Math.PI);
        d = Math.Sqrt(2 * s);
        answer = di >= d ? true : false;

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;
        double di, d;

        di = 2 * Math.Sqrt(r / Math.PI);
        d = Math.Sqrt(s);
        answer = di < d ? true : false;

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;
        double mx = Math.Abs(x);

        answer = mx > 1 ? 1 : mx;

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;
        double mx = Math.Abs(x);

        answer = mx >= 1 ? 0 : x * x - 1;

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        if (x <= -1) answer = 0;
        else if (x > 0) answer = 1;
        else answer = x + 1;

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        if (x <= -1) answer = 1;
        else if (x > 1) answer = -1;
        else answer = -x;

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0, s = 0, buf = 0;

        for (int i = 0; i < n; i++)
        {
            Double.TryParse(Console.ReadLine(), out buf);
            s += buf;
        }
        answer = s / n;

        Console.WriteLine(answer);

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x, y;
        string[] st;

        for (int i = 0; i < n; i++)
        {
            st = Console.ReadLine().Split(' ');
            Double.TryParse(st[0], out x);
            Double.TryParse(st[1], out y);

            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0, s = 0, buf = 0;

        for (int i = 0; i < n; i++)
        {
            Double.TryParse(Console.ReadLine(), out buf);
            s += buf < 30 ? 200: 0;
        }
        answer = s / 1000;
        Console.WriteLine(answer);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        double x, y;
        string[] st;

        for (int i = 0; i < n; i++)
        {
            st = Console.ReadLine().Split(' ');
            Double.TryParse(st[0], out x);
            Double.TryParse(st[1], out y);

            if ((x * x + y * y >= r1 * r1) && (x * x + y * y <= r2 * r2))
            {
                answer++;
            }
        }

        Console.WriteLine(answer);

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        double res = 0;

        for (int i = 0; i < n; i++)
        {
            Double.TryParse(Console.ReadLine(), out res);
            answer += res <= norm ? 1 : 0;
        }
        Console.WriteLine(answer);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        double x, y;
        string[] st;

        for (int i = 0; i < n; i++)
        {
            st = Console.ReadLine().Split(' ');
            Double.TryParse(st[0], out x);
            Double.TryParse(st[1], out y);

            if (y >= 0 && y <= Math.Sin(x) && x >= 0 && x <= Math.PI) answer++;
        }

        Console.WriteLine(answer);

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        double x, y;
        string[] st;

        for (int i = 0; i < n; i++)
        {
            st = Console.ReadLine().Split(' ');
            Double.TryParse(st[0], out x);
            Double.TryParse(st[1], out y);

            answer1 += x > 0 && y > 0 ? 1 : 0;
            answer3 += x < 0 && y < 0 ? 1 : 0;

        }

        Console.WriteLine($"{answer1:d} {answer3:d}");
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue,l = 0;
        double x, y;
        string[] st;

        for (int i = 0; i < n; i++)
        {
            st = Console.ReadLine().Split(' ');
            Double.TryParse(st[0], out x);
            Double.TryParse(st[1], out y);

            l = Math.Sqrt(x * x + y * y);
            if (answerLength > l)
            {
                answerLength = l;
                answer = i + 1;
            }

        }
        answer = n == 0 ? 0 : answer;
        Console.WriteLine($"{answer:d} {answerLength:f2}");

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue, time = 0;

        for (int i = 0; i < n; i++)
        {
            Double.TryParse(Console.ReadLine(), out time);

            answer = time < answer ? time : answer;
        }
        answer = n == 0 ? 0 : answer;

        Console.WriteLine(answer);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0, p,cnt = 0;

        for (int i = 1; i <= n * 4; i++)
        {
            Int32.TryParse(Console.ReadLine(), out p);
            cnt += p > 3 ? 1 : 0;
            if (i % 4 == 0)
            {
                answer += cnt == 4 ? 1 : 0;
                cnt = 0;
            }
        }
        Console.WriteLine(answer);

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0, p, cnt = 0;
        double avg = 0.0;

        for (int i = 1; i <= n * 4; i++)
        {
            Int32.TryParse(Console.ReadLine(), out p);
            cnt += p == 2 ? 1 : 0;
            avg += p;
            if (i % 4 == 0)
            {
                answer += cnt >= 1? 1 : 0;
                cnt = 0;
            }
        }
        avg /= 4 * n;
        Console.WriteLine(answer);
        Console.WriteLine(avg);

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12( double r, int type)
    {
        double answer = 0;

        if (r > 0)
        {
            switch (type){
                case 0:
                answer = r*r;
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
    public double Task_2_13( double A, double B, int type)
    {
        double answer = 0;

        if (A > 0 && B > 0)
        {
            switch (type){
                case 0:
                answer = A * B;
                break;
                case 1:
                answer = B > A ? Math.PI * (B * B - A * A) : 0;
                break;
                case 2:
                double p = (A+B+B)/2;
                answer = Math.Sqrt(p*(p-A)*(p-B)*(p-B));
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
        double answer = 0, buf;
        int cnt = 0;

        while (true)
        {
            Double.TryParse(Console.ReadLine(), out buf);
            if (buf == 0){
                break;
            }
            cnt++;
            answer += buf;
        }
        answer = cnt != 0 ? answer/cnt : 0;

        Console.WriteLine(answer);

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161, -50
        // answer should be equal to the task_2_1 answer

        return answer;
    }
    public int Task_3_2(double r)
    {
        int answer = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_3 answer

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0;


        double x, y;
        string[] st;

        while (true)
        {
            {
                st = Console.ReadLine().Split(' ');
                Double.TryParse(st[0], out x);
                Double.TryParse(st[1], out y);
                if (x == 0 && y == 0) break;
                if ((x * x + y * y >= r1 * r1) && (x * x + y * y <= r2 * r2))
                {
                    answer++;
                }
            }
            // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5, 0 0
            // answer should be equal to the task_2_4 answer
            
        }
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1
        // answer should be equal to the task_2_6 answer

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0;
        int answer3 = 0;

        double x, y;
        string[] st;

        while (true)
        {
                st = Console.ReadLine().Split(' ');
                Double.TryParse(st[0], out x);
                Double.TryParse(st[1], out y);
                if (x == 0 || y == 0) break;
                answer1 += x > 0 && y > 0 ? 1 : 0;
                answer3 += x < 0 && y < 0 ? 1 : 0;
        }
        Console.WriteLine($"{answer1:d} {answer3:d}");

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5, 1 0
        // answer should be equal to the task_2_7 answer

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_8 answer

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_9 answer

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, p, cnt = 0, cnt1 = 0;

        while (true)
        {
            {
                Int32.TryParse(Console.ReadLine(), out p);
                if (p == 0) break;
                cnt1++;
                cnt += p > 3 ? 1 : 0;
                if (cnt1 % 4 == 0)
                {
                    answer += cnt == 4 ? 1 : 0;
                    cnt = 0;
                }
            }

            // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4, 0
            // answer should be equal to the task_2_10 answer
        }
        Console.WriteLine(answer);
        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0;
        double avg = 0.0;

        // code here;

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
        
        string[] st;

        while (true)
        {
            st = Console.ReadLine().Split(' ');
            Double.TryParse(st[0], out A);
            Double.TryParse(st[1], out B);
            Int32.TryParse(st[2], out type);
            if (type == -1) break;
            if (A > 0 && B > 0)
             {
                switch (type){
                case 0:
                answer = A * B;
                break;
                case 1:
                answer = B > A ? Math.PI * (B * B - A * A) : 0;
                break;
                case 2:
                double p = (A+B+B)/2;
                answer = Math.Sqrt(p*(p-A)*(p-B)*(p-B));
                break;
                }
            }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        }
        return answer;
    }
    #endregion
}
