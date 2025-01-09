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
        //program.Task_1_3(0, 2);
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
        //program.Task_2_4(3, 1, 3);
        //program.Task_2_5(6, 25.2);
        //program.Task_2_6(3);
        //program.Task_2_7(3);
        //program.Task_2_8(3);
        //program.Task_2_9(6);
        //program.Task_2_10(6);
        //program.Task_2_11(6);
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
        program.Task_3_9();
        //program.Task_3_10();
        //program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;
        double r = 2;
        if ((Math.Abs(x*x+y*y-r*r)) <= 1/1000.0)
                answer = true;
        Console.WriteLine(answer);
        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;
        if (y >= 0 && (y + Math.Abs(x) <= 1)) answer = true;
        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

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
        Console.WriteLine($"{a} {b} --> {answer}");
        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        if (a < b) answer = a; else answer = b;
        if (answer < c) answer = c;
        Console.WriteLine(answer);
        return answer; 
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        double d = 2 * Math.Sqrt(r/Math.PI);
        if (2 * s <= d * d)
        {
            answer = true;
        }
        Console.WriteLine($"{r} --> {d} ? {s} ");
        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        double d = 2 * Math.Sqrt(r / Math.PI);
        if (Math.Sqrt(s) >= d) answer = true;

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;
        if (Math.Abs(x) > 1) answer = 1;
        else answer = Math.Abs(x);
        
        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        if (Math.Abs(x) >= 1) answer = 0;
        else answer = x * x - 1;

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;
        if (x <= -1) answer = 0;
        else if (x > 0) answer = 1;
        else answer = 1 + x;

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        if (x <= -1) answer = 1;
        else if (x > 1) answer = -1;
        else answer = 0 - x;

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double a = 0;
        double answer = 0;
        for (int i = 0; i < n; i++)
        {
            a = double.Parse(Console.ReadLine());
            answer += a;

        }


        answer = answer / n;
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (Math.Sqrt((a-x)*(a-x)+(b-y)*(b-y)) <= r)
            {
                answer += 1;
            }
        }
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            if (x < 30) answer += 0.2;
        }
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (Math.Sqrt(x*x + y*y) <= r2 && Math.Sqrt(x * x + y * y) >= r1)
            {
                answer += 1;
            }
        }
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            if (x <= norm) answer += 1;
        }
        Console.WriteLine(answer);

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((x >= 0 && x <= Math.PI)&&(y >= 0 && Math.Sin(x) >= y))
            {
                answer += 1;
            }
        }
        Console.WriteLine(answer);
        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0) answer1 += 1;
            else if (x < 0 && y < 0) answer3 += 1;
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double r = Math.Sqrt(x * x + y * y);
            if (r < answerLength)
            {
                answerLength = r;
                answer = i;
            
            }
            
        }
        Console.WriteLine(answer);
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answerLength);

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            if (x <= answer) answer = x;
        }
        Console.WriteLine(answer);

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            if (a > 3 && b > 3 && c > 3 && d > 3)
            {
                answer += 1;

            }

        }
        Console.WriteLine(answer);
        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        double obs = 0;

        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            double s = (a + b + c + d);
            obs += s / 4.0;
            if (a == 2 || b == 2 || c == 2 || d ==2)
            {
                answer += 1;

            }
        }
        avg = obs / n;
        Console.WriteLine("-----");
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        if (r <= 0) return 0;

        switch(type)
        {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = r * r* Math.PI;
                break;
            case 2:
                answer = r * r * Math.Sqrt(3) / 4;
                break;
            default:
                break;
            

        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        if (A <= 0 || B <= 0) return 0;

        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs(A * A * Math.PI - B*B*Math.PI);
                break;
            case 2:
                double p = (B + B + A) / 2;
                answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B));
                break;
            default:
                break;


        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);

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
        // онтрольное значение - любое значение меньшее 0 или равное 0
        double answer = 0;
        int n = 0;
        double x;
        x = double.Parse(Console.ReadLine());
        while(x >= 0)
        {
            if (x < 30) answer += 0.200;
            x = double.Parse(Console.ReadLine());
        }
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
        // онтрольное значение - любое буквенное значение
        int answer = 0, n = 0;

        double x;
        double y;
        while(double.TryParse(Console.ReadLine(), out x))
        {
            y = double.Parse(Console.ReadLine());
            if ((x >= 0 && x <= Math.PI) && (y >= 0 && Math.Sin(x) >= y))
            {
                answer += 1;
            }
        }
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
        // онтрольное значение - любое не double значение
        double answer = double.MaxValue;
        int n = 0;
        double x;
        while (double.TryParse(Console.ReadLine(), out x))
        {
            n++;
            if (answer > x)
            {
                answer = x;
            }

        }
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