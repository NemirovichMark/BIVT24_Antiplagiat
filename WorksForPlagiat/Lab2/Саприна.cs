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
        //program.Task_2_8(10);
        //program.Task_2_9(10);
        //program.Task_2_10(10);
        //program.Task_2_11(10);
        //program.Task_2_12(10, 0);
        program.Task_2_13(10, 5, 2);
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
        int r = 2;
        if (Math.Abs(x * x + y * y - r * r) <= 0.001) answer = true;
        else answer = false;

        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here

        if ((y >= 0) && (y + Math.Abs(x) <= 1)) answer = true;
        else answer = false;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here

        if (a > 0)
        {
            if (a > b) answer = a;
            else answer = b;
        }
        else
        {
            if (a < b) answer = a;
            else answer = b;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here

        double min = 0, max = 0;
        if (a < b) min = a;
        else min = b;
        if (min > c) max = min;
        else
        {
            max = c;
        }
        answer = max;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here

        if (2 * Math.Sqrt(r / Math.PI) >= Math.Sqrt(2 * s)) answer = true;
        else answer = false;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here

        if (2 * Math.Sqrt(r / Math.PI) <= Math.Sqrt(s)) answer = true;
        else answer = false;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here

        double y = 0;
        if (Math.Abs(x) > 1) y = 1;
        else y = Math.Abs(x);
        // end
        answer = y;
        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here

        if (Math.Abs(x) >= 1) answer = 0;
        else answer = x * x - 1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here

        if (x <= -1) answer = 0;
        if (-1 < x && x <= 0) answer = 1 + x;
        if (x > 0) answer = 1;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here

        if (x <= -1) answer = 1;
        if (-1 < x && x <= 1) answer = -x;
        if (x > 1) answer = -1;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here

        double r, s = 0;
        for (int i = 0; i < 10; i++)
        {
            r = double.Parse(Console.ReadLine());
            s += r;
        }
        answer = s / 10;
        answer = Math.Round(answer, 1);
        Console.WriteLine(answer);
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here

        double x, y;
        int k = 0;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ((a - x) * (a - x) + (b - y) * (b - y) < r * r) k++;
        }
        Console.WriteLine(k);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return k;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here

        double x;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            if (x < 30) answer += 0.2;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here

        double x, y, f;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            f = Math.Sqrt(x * x + y * y);
            if (r1 < f && f < r2) answer++;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here

        double x;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            if (x < norm) answer++;
        }
        Console.WriteLine(answer);
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
            if (0 <= x && x <= Math.PI && 0 <= y && y <= Math.Sin(x)) answer++;
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here

        double x, y;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine(1);
                answer1++;
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine(3);
                answer3++;
            }
            if (x > 0 && y < 0) Console.WriteLine(4);
            if (x < 0 && y > 0) Console.WriteLine(2);
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here

        double x, y, m = 1000;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (Math.Sqrt(x * x + y * y) < m)
            {
                m = Math.Sqrt(x * x + y * y);
                answer = i;
                answerLength = Math.Sqrt(x * x + y * y);
            }
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here

        double x, m = 10000;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            if (x < m) m = x;
        }
        answer = m;
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;

        double x1, x2, x3, x4;
        for (int i = 1; i <= n; i++)
        {
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            x3 = double.Parse(Console.ReadLine());
            x4 = double.Parse(Console.ReadLine());
            if (x1 != 2 && x2 != 2 && x3 != 2 && x4 != 2 && x1 != 3 && x2 != 3 && x3 != 3 && x4 != 3) answer++;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;

        double x1, x2, x3, x4;
        for (int i = 1; i <= n; i++)
        {
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            x3 = double.Parse(Console.ReadLine());
            x4 = double.Parse(Console.ReadLine());
            if (x1 == 2 && x2 == 2 && x3 == 2 && x4 == 2) answer++;
            avg += (x1 + x2 + x3 + x4);
        }
        avg /= (n * 4);
        avg = Math.Round(avg, 2);
        Console.WriteLine(avg);
        Console.WriteLine(answer);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r <= 0) return 0;
        
        switch (type)
        {
            case 0:
                answer = r * r;
                Console.WriteLine("площадь квадрата", answer);
                break;
            case 1:
                answer = Math.PI * r * r;
                Console.WriteLine("площадь круга", answer);
                break;
            case 2:
                answer = (r * r * Math.Sqrt(3)) / 4;
                Console.WriteLine("площадь равностороннего треугольника", answer);
                break;
            default:
                answer = 0;
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

        if (A <= 0 || B <= 0) return 0;
        switch (type)
        {
            case 0:
                answer = A * B;
                Console.WriteLine("площадь прямоугольника", answer);
                break;
            case 1:
                answer = Math.Abs(Math.PI * (B * B - A * A));
                Console.WriteLine("площаль кольца", answer);
                break;
            case 2:
                if (B + B < A) return 0;
                answer = (A * Math.Sqrt(4*B*B - A*A)) / 4;
                Console.WriteLine("площадь равнобедренного треугольника", answer);
                break;
            default:
                answer = 0;
                break;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
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

        while (true)
        {
            double v;
            string input = Console.ReadLine();
            bool success = double.TryParse(input, out v);
            if (success)
            {
                if (v < 30) answer += 0.2;
            }
            else break;
        }
        Console.WriteLine(answer);
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

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here

        while (true)
        {
            double x, y;
            string input = Console.ReadLine();
            bool success = double.TryParse(input, out x);
            string inpu = Console.ReadLine();
            bool succes = double.TryParse(inpu, out y);
            if (success && succes)
            {
                if (0 <= x && x <= Math.PI && 0 <= y && y <= Math.Sin(x)) answer++;
            }
            else break;
        }
        Console.WriteLine(answer);

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

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_8 answer

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here

        double m = 1000;
        while (true)
        {
            double rez;
            string input = Console.ReadLine();
            bool success = double.TryParse(input, out rez);
            if (success)
            {
                if (rez < m) m = rez;
            }
            else break;
        }
        Console.WriteLine(m);

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
