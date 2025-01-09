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
        program.Task_2_8(5);
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
        if (x * x + y * y == r * r && Math.Abs(x * x + y * y - r * r) <= 0.001)
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
        if (y >= 0 && Math.Abs(x) + y <= 1)
        {
            answer = true;
        }
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
            {
                answer = a;
            }
            else
            {
                answer = b;
            }
        }
        else
        {
            if (a > b)
            {
                answer = b;
            }
            else
            {
                answer = a;
            }
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        if (a > b)
        {
            answer = b;
        }
        else
        {
            answer = a;
        }
        if (answer < c) 
        {
            answer = c;
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double a;
        double d;
        double d2;
        a = Math.Sqrt(s);
        d = a * Math.Sqrt(2);
        d2 = 2 * Math.Sqrt(r / Math.PI);
        if (d <= d2)
        {
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double a;
        double d2;
        a = Math.Sqrt(s);
        d2 = 2 * Math.Sqrt(r / Math.PI);
        if (d2 <= a)
        {
            answer = true;
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
        else if (Math.Abs(x) <= 1)
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
        else if (Math.Abs(x) < 1)
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
        else if (x <= 0)
        {
            answer = x + 1;
        }
        else
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
        else if (x <= 1)
        {
            answer = -x;
        }
        else
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
        double r, s = 0;
        for (int i = 0; i < n; i++)
        {
            r = double.Parse(Console.ReadLine());
            s = s + r;
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
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
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
        double r, ml = 0;
        for (int i = 0; i < n; i++)
        {
            r = double.Parse(Console.ReadLine());
            if (r < 30)
            {
                ml += 200;
            }
        }
        answer = ml / 1000;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x, y, x0, y0;
        x0 = double.Parse(Console.ReadLine());
        y0 = double.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ((x - x0) * (x - x0) + (y - y0) * (y - y0) > r1 * r1 && (x - x0) * (x - x0) + (y - y0) * (y - y0) < r2 * r2)
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
        double a;
        for (int i = 1; i <= n; i++)
        {
            a = double.Parse(Console.ReadLine());
            if (a <= norm)
            {
                answer++;
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
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x >= 0 && x <= Math.PI && y >= 0 & y <= Math.Sin(x))
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
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                answer1++;
                Console.WriteLine(1);
            }
            if (x < 0 && y < 0)
            {
                answer3++;
                Console.WriteLine(3);
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine(2);
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine(4);
            }
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
        double x, y, h = 10000000000000;
        int r = 0;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            r += 1;
            if (Math.Sqrt(x * x + y * y) < h)
            {
                answerLength = Math.Sqrt(x * x + y * y);
                answer = r;
                h = answerLength;
            }
            h = answerLength;
        }
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double a, h = 1000000;
        for (int i = 1; i <= n; i++)
        {
            a = double.Parse(Console.ReadLine());
            if (a < h)
            {
                answer = a;
                h = a;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        double a, h = 0;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                a = double.Parse(Console.ReadLine());
                if (a >= 4)
                {
                    h += 1;
                }
            }
            if (h == 4)
            {
                answer++;
            }
            h = 0;
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
        double a, a1, a2, a3;
        for (int i = 1; i <= n; i++)
        {
            a = double.Parse(Console.ReadLine());
            a1 = double.Parse(Console.ReadLine());
            a2 = double.Parse(Console.ReadLine());
            a3 = double.Parse(Console.ReadLine());
            avg = avg + a + a1 + a2 + a3;
            if (a < 3)
            {
                answer += 1;
            }
            else if (a1 < 3)
            {
                answer += 1;
            }
            else if (a2 < 3)
            {
                answer += 1;
            }
            else if (a3 < 3)
            {
                answer += 1;
            }
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
        if (r > 0)
        {
            switch (type)
            {
                case 0: answer = r * r;
                    break;
                case 1: answer = Math.PI * r * r; 
                    break;
                case 2: answer = r * r * Math.Sqrt(3) / 4.0; 
                    break;
            }
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        double p = (A + B + B) / 2;
        if (A > 0 && B > 0)
        {
            switch (type)
            {
                case 0: answer = A * B;
                    break;
                case 1: answer = Math.PI * (B * B - A * A); 
                    break;
                case 2: answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B)); 
                    break;
            }
        }
        answer = Math.Round(Math.Abs(answer), 2);
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
        double s = 0, h = 0;
        string r = "1";
        while (r != "стоп")
        {
            r = Console.ReadLine();
            if (r != "стоп")
            { 
                h = double.Parse(r);
                s = s + h;
                n++;
            }
        } 
        answer = s / n;
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

        // code here
        double x0, y0, x, y;
        x0 = double.Parse(Console.ReadLine());
        y0 = double.Parse(Console.ReadLine());
        string x1 = "1";
        string y1 = "1";
        while (x1 != "стоп")
        {
            x1 = Console.ReadLine();
            if (x1 != "стоп")
            {
                y1 = Console.ReadLine();
                x = double.Parse(x1);
                y = double.Parse(y1);
                if ((x - x0) * (x - x0) + (y - y0) * (y - y0) > r1 * r1 && (x - x0) * (x - x0) + (y - y0) * (y - y0) < r2 * r2)
                {
                    answer++;
                }
            }
        }
        Console.WriteLine(answer);
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
        string x1 = "1";
        string y1 = "1";
        while (x1 != "стоп")
        {
            x1 = Console.ReadLine();
            if (x1 != "стоп")
            {
                y1 = Console.ReadLine();
                x = double.Parse(x1);
                y = double.Parse(y1);
                if (x > 0 && y > 0)
                {
                    answer1++;
                    Console.WriteLine(1);
                }
                if (x < 0 && y < 0)
                {
                    answer3++;
                    Console.WriteLine(3);
                }
                if (x < 0 && y > 0)
                {
                    Console.WriteLine(2);
                }
                if (x > 0 && y < 0)
                {
                    Console.WriteLine(4);
                }
            }
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
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
        double h = 0, a = 0;
        string a1 = "1";
        while (a1 != "стоп")
        {
            for (int j = 1; j <= 4; j++)
            {
                a1 = Console.ReadLine();
                if (a1 != "стоп")
                {
                    a = double.Parse(a1);
                    if (a >= 4)
                    {
                        h += 1;
                    }
                }
                else
                {
                    break;
                }
            }
            if (h == 4)
            {
                answer++;
            }
            h = 0;
        }
        Console.WriteLine(answer);
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