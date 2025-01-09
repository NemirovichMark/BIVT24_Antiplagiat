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
        //program.Task_2_6(3);
        //program.Task_2_7(3);
        //Task_2_8(4);
        //program.Task_2_9(10);
        //program.Task_2_10(6);
        //program.Task_2_11(6);
        //program.Task_2_12(1.2, 3);
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
        if (Math.Abs(x * x + y * y - r * r) <= 1/1000) 
             answer = true; 

        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y>=0 && (y + Math.Abs(x)<=1))
            answer = true;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)
        {
            if (a >= b)
                answer = a;
            else
                answer = b;
        }
        else
        {
            if (a <= b)
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
        if (a <= b)
        {
            if (a >= c)
                answer = a; 
            else
                answer = c;
        }
        else
        {
            if (b >= c)
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
        if (Math.Sqrt(2 * s) <= 2*Math.Sqrt(r / Math.PI))
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (Math.Sqrt(s) >= 2 * Math.Sqrt(r / Math.PI))
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
        if (Math.Abs(x) >= 1)
            answer = 0;
        else
            answer = x*x - 1; 

        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 0;
        else if (x > -1 && x <= 0)
            answer = 1 + x;
        else
            answer = 1;

        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 1;
        else if (x > -1 && x <= 1)
            answer = -1 * x;
        else
            answer = -1;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double r = 0;
        for (int i = 0; i < n; i++)
        {
            r = double.Parse(Console.ReadLine());
            answer += r / n;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x = 0, y = 0;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (Math.Sqrt((a-x) * (a-x) + (b-y) * (b-y)) <= r)
                answer += 1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double m = 0;
        for (int i = 0; i<n; i++)
        {
            m = double.Parse(Console.ReadLine());
            if (m < 30)
                answer += 0.2;
        }
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x = 0, y = 0;
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ((x * x + y * y >= r1 * r1) && (x * x + y * y <= r2 * r2))
                answer += 1;
        }
        Console.WriteLine(answer);
            // end

            return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double x = 0;
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            if (x <= norm)
                answer += 1;
        }
        Console.WriteLine(answer);
        // end

            return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x = 0, y = 0;
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
                answer += 1;
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
        double x = 0, y = 0;
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x>0 && y > 0)
            {
                answer1 += 1;
                Console.WriteLine("1 четверть");
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("2 четверть");
            }
            if (x > 0 && y < 0)
            {
                
                Console.WriteLine("3 четверть");
            }
            if (x < 0 && y < 0)
            {
                answer3 += 1;
                Console.WriteLine("4 четверть");
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
        double x = 0, y = 0;
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        answer = 1;
        answerLength = Math.Sqrt(x*x + y*y);

        for (int i = 2; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (Math.Sqrt(x * x + y * y) <= answerLength)
            {
                answer = i;
                answerLength = Math.Sqrt(x * x + y * y);
            }

        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double result = 0;
        answer = double.Parse(Console.ReadLine());
        for (int i = 2; i <= n; i++)
        {
            result = double.Parse(Console.ReadLine());
            if (result < answer)
                answer = result;
        }
        Console.WriteLine(answer);
        // end

            return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        double m1 = 0, m2 = 0, m3 = 0, m4 = 0;
        for (int i = 0; i < n; i++)
        {
            m1 = double.Parse(Console.ReadLine());
            m2 = double.Parse(Console.ReadLine());
            m3 = double.Parse(Console.ReadLine());
            m4 = double.Parse(Console.ReadLine());
            if (m1 > 3 && m2 > 3 && m3 > 3 && m4 > 3)
                answer += 1;
        }
        Console.WriteLine($"кол-во учеников {answer}");
        // end

            return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double m1 = 0, m2 = 0, m3 = 0, m4 = 0;
        for (int i = 0; i < n; i++)
        {
            m1 = double.Parse(Console.ReadLine());
            m2 = double.Parse(Console.ReadLine());
            m3 = double.Parse(Console.ReadLine());
            m4 = double.Parse(Console.ReadLine());
            if (m1 == 2 || m2 == 2 || m3 == 2 || m4 == 2)
                answer += 1;
            avg += m1 + m2 + m3 + m4;
        }
        avg /= n * 4;
        Console.WriteLine($"кол-во учеников {answer}");
        Console.WriteLine(avg);
        // end

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
                break;
            case 1:
                answer = r * r * Math.PI;
                break;
            case 2:
                answer = r * r * Math.Sqrt(3) / 4;
                break;
            default: 
                answer = 0; 
                break;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine($"{r} {answer} {type}");
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
                break;
            case 1:
                answer = Math.Abs(B * B * Math.PI - A * A * Math.PI);
                break;
            case 2:
                answer = A/4 * Math.Sqrt(4 * B * B - A * A);
                break;
            default: 
                answer = 0; 
                break;
        }
        // end
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
        double x = 0, y = 0;
        do
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (Math.Sqrt((a - x) * (a - x) + (b - y) * (b - y)) <= r)
                answer += 1;
        }
        while (x <= 1000);
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
        double x = 0;
        do
        {
            x = double.Parse(Console.ReadLine());
            if (x <= norm)
                answer += 1;
        }
        while (x <= 1000);
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
        double x = 0, y = 0;
        int i = 0;
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        answer = 1;
        answerLength = Math.Sqrt(x * x + y * y);
        while (x <= 1000)
        {
            i++;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            
            if (Math.Sqrt(x * x + y * y) <= answerLength)
            {
                answer = i;
                answerLength = Math.Sqrt(x * x + y * y);
            }

        }
        
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
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
        double m1 = 0, m2 = 0, m3 = 0, m4 = 0;
        n = 0;
        do
        {
            n++;
            m1 = double.Parse(Console.ReadLine());
            m2 = double.Parse(Console.ReadLine());
            m3 = double.Parse(Console.ReadLine());
            m4 = double.Parse(Console.ReadLine());
            if (m1 < 2 || m2 < 2 || m3 < 2 || m4 < 2)
                break;
            
            if (m1 == 2 || m2 == 2 || m3 == 2 || m4 == 2)
                answer += 1;
            avg += m1 + m2 + m3 + m4;
        }
        while (m1 > 0);
        avg /= (n-1) * 4;
        Console.WriteLine($"кол-во учеников {answer}");
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    #endregion
}