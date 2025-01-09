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
        program.Task_3_10();
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
        if (Math.Abs(x*x + y*y - r*r) <= 0.001) { answer = true; }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && y + Math.Abs(x) <= 1) { answer = true; }
        // end

        return answer;
    }
    
    public double Max(double x, double y)
    {
        if (x > y) { return x; }
        return y;
    }
    public double Min(double x, double y)
    {
        if (x < y) { return x; }
        return y;
    }

    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0) answer = Max(a, b);
        else answer = Min(a, b);
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        answer  = Max(Min(a, b),c);
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here

        if (Math.Sqrt(s*2) <= Math.Sqrt(r / Math.PI)*2) { answer = true; }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (Math.Sqrt(s) >= Math.Sqrt(r / Math.PI) * 2) { answer = true; }
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) <= 1) answer = Math.Abs(x);
        else answer = 1;
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) < 1) answer = x*x - 1;
        else answer = 0;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) { answer = 0; }
        else if (x <= 0) { answer = 1 + x; }
        else answer = 1;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) { answer = 1; }
        else if (x <= 1) { answer = -x; }
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
        for (int i = 1; i <= n; i++)
        {
            answer += int.Parse(Console.ReadLine());
        }
        answer /= n;
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x, y;
        // code here
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ( (x-a)*(x-a) + (y-b)*(y-b) <= r*r) { answer++; }
        }
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            if (double.Parse(Console.ReadLine()) < 30) { answer += 0.2; }
        }
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        double x, y;
        // code here
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ((x * x + y * y >= r1*r1) && (x * x + y * y <= r2*r2)) { answer++; }
        }
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            if (double.Parse(Console.ReadLine()) < norm) { answer ++; }
        }
        // end

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
            if (x>=0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x)) { answer++; }
        }
        // end

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
            if (x > 0)
                if (y > 0)
                {
                    Console.WriteLine(1);
                    answer1 ++;
                }
                else Console.WriteLine(4);
            else
                if (y > 0) Console.WriteLine(2);
            else
            {
                Console.WriteLine(3);
                answer3++;
            }
        }
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x, y;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            double l = x * x + y * y;
            if (l < answerLength)
            {
                answer = i;
                answerLength = l;
            }
        }
        answerLength = Math.Sqrt(answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            if (x < answer) { answer = x; }
        }
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 1; i <= n*4; i++)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            if (a >= 4)
                if (b >= 4)
                    if (c >= 4)
                        if (d >= 4)
                            answer += 1;
        }
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        for (int i = 1; i <= n*4; i++)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            avg += a + b + c + d;
            if (a <= 2)
                if (b <= 2)
                    if (c <=2)
                        if (d <= 2)
                            answer += 1;

        }
        avg /= 4 * n;
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r <= 0)
            return 0;
        switch (type)
        {
            case 0:
                answer = Math.Round(r * r,2); break;
            case 1:
                answer = Math.Round(r *r*Math.PI,2); break;
            case 2:
                answer = Math.Round(r *r*Math.Sqrt(3)/4,2); break;
            default:
                return 0;
        }
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A <= 0 || B <= 0)
            return 0;
        switch (type)
        {
            case 0:
                answer = Math.Round(A * B, 2); break;
            case 1:
                answer = Math.Round(Math.Abs(A*A-B*B)* Math.PI, 2); break;
            case 2:
                answer = Math.Round(Math.Sqrt(B*B-A*A/4)*A/2, 2); break;
            default:
                return 0;
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
        string s = "";
        // code here
        for (n = 1; true; n++)
        {

            s = Console.ReadLine();
            if (s == "") { break; }
            answer += double.Parse(s);

            Console.WriteLine(n);
        }
        answer /= n-1;
        Console.WriteLine(answer);
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
        double answer = 0;
        int n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;
        double x, y;
        // code here
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out x) == false ||
                double.TryParse(Console.ReadLine(), out y) == false) { break; }
            if ((x * x + y * y >= r1*r1) && (x * x + y * y <= r2*r2)) { answer++; }
        }
        // end
        Console.WriteLine(answer);
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
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here
        double x, y;
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out x) == false ||
                double.TryParse(Console.ReadLine(), out y) == false) { break; }
            if (x > 0)
                if (y > 0)
                {
                    Console.WriteLine(1);
                    answer1++;
                }
                else Console.WriteLine(4);
            else
                if (y > 0) Console.WriteLine(2);
            else
            {
                Console.WriteLine(3);
                answer3++;
            }
        }
        // end
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
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
        double a,b , c,d;
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out a) == false ||
                double.TryParse(Console.ReadLine(), out b) == false ||
                double.TryParse(Console.ReadLine(), out c) == false ||
                double.TryParse(Console.ReadLine(), out d) == false) { break; }
            if (a >= 4)
                if (b >= 4)
                    if (c >= 4)
                        if (d >= 4)
                            answer++;

        }
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
