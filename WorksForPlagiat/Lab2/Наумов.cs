using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

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

        answer = ((x * x) + (y * y) == 4);

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

        if (a > 0)
        {
            if (a > b) answer = a;
            else answer = b;
        } else
        {
            if (a < b) answer = a;
            else answer = b;
        }

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        double mini;

        if (a < b) mini = a;
        else mini = b;

        if (c > mini) answer = c;
        else answer = mini;

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        r = Math.Sqrt(r / Math.PI);
        s = Math.Sqrt(s);

        answer = (s <= r * Math.Sqrt(2));

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        r = Math.Sqrt(r / Math.PI);
        s = Math.Sqrt(s);

        answer = ((2 * r) <= s);

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        if (Math.Abs(x) > 1) answer = 1;
        else if (Math.Abs(x) <= 1) answer = Math.Abs(x);

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        if (Math.Abs(x) >= 1) answer = 0;
        else if (Math.Abs(x) < 1) answer = (x * x) - 1;

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        if (x <= -1) answer = 0;
        else if (x <= 0) answer = 1 + x;
        else answer = 1;

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        if (x <= -1) answer = 1;
        else if (x <= 1) answer = -x;
        else answer = -1;

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        for (int i = 0; i < n; i++)
        {
            double weight;
            double.TryParse(Console.ReadLine(), out weight);
            answer += weight;
        }

        return answer / n;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            double x, y;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (((x - a) * (x - a)) + ((y - b) * (y - b)) <= r * r) answer++;
        }

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        for (int i = 0; i < n; i++)
        {
            double weight;
            double.TryParse(Console.ReadLine(), out weight);
            if (weight < 30) answer += 0.2;
        }

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            double x, y;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (((x * x) + (y * y) <= r2 * r2) && !((x * x) + (y * y) <= r1 * r1)) answer++;
        }

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            double x;
            double.TryParse(Console.ReadLine(), out x);
            if (x >= norm) answer++;
        }

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            double x, y;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (0 <= x && x <= Math.PI && y >= 0 && y <= Math.Sin(x)) answer++;
        }

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        for (int i = 0; i < n; i++)
        {
            double x, y;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x > 0 && y > 0) { answer1++; Console.WriteLine("I"); }
            if (x < 0 && y > 0) { Console.WriteLine("II"); }
            if (x < 0 && y < 0) { answer3++; Console.WriteLine("III"); }
            if (x > 0 && y < 0) { Console.WriteLine("IV"); }
        }

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        for (int i = 0; i < n; i++)
        {
            double x, y;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (Math.Sqrt((x * x) + (y * y)) < answerLength) answerLength = Math.Sqrt((x * x) + (y * y)); answer = i + 1;
        }

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        for (int i = 0; i < n; i++)
        {
            double speed;
            double.TryParse(Console.ReadLine(), out speed);
            if (speed < answer) answer = speed;
        }

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            bool IsGood = true;
            for (int j = 0; j < 4; j++)
            {
                double mark;
                double.TryParse((Console.ReadLine()), out mark);
                if (mark == 2 || mark == 3) IsGood = false;
            }
            if (IsGood) answer++;
        }

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        for (int i = 0; i < n; i++)
        {
            bool IsGood = true;
            for (int j = 0; j < 4; j++)
            {
                double mark;
                double.TryParse((Console.ReadLine()), out mark);
                if (mark >= 3) IsGood = false;
                avg += mark;
            }
            if (!IsGood) answer++;
        }

        return (answer, avg / (n * 4));
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        if (type < 0 || type > 2 || r <= 0) return 0;

        if (type == 0) answer = r * r;
        else if (type == 1) answer = Math.PI * (r * r);
        else if (type == 2) answer = (r * r) * Math.Sqrt(3) / 4;

        return Math.Round(answer, 2);
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0, P = 0;

        if (type < 0 || type > 2 || A <= 0 || B <= 0) return 0;

        if (type == 0) answer = (A * B);
        else if (type == 1) answer = Math.Abs((Math.PI * (A * A)) - (Math.PI * (B * B)));
        else if (type == 2) { P = (A + B + B) / 2; answer = Math.Sqrt(P * (P - A) * (P - B) * (P - B)); }

        return Math.Round(answer, 2);
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int amount = 0;

        while (true)
        {
            double weight;
            double.TryParse(Console.ReadLine(), out weight);
            if(weight <= 0) break;
            answer += weight;
            amount++;
        }

        return answer / amount;
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
        int answer = 0;

        while(true)
        {
            double x, y;
            if (!double.TryParse(Console.ReadLine(), out x)) break;
            if (!double.TryParse(Console.ReadLine(), out y)) break;

            if (((x * x) + (y * y) <= r2 * r2) && !((x * x) + (y * y) <= r1 * r1)) answer++;
        }

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

        for (int i = 0; i < n; i++)
        {
            double x, y;
            if (!double.TryParse(Console.ReadLine(), out x)) break;
            if (!double.TryParse(Console.ReadLine(), out y)) break;
            if (x > 0 && y > 0) { answer1++; Console.WriteLine("I"); }
            if (x < 0 && y > 0) { Console.WriteLine("II"); }
            if (x < 0 && y < 0) { answer3++; Console.WriteLine("III"); }
            if (x > 0 && y < 0) { Console.WriteLine("IV"); }
        }

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

        for (int i = 0; i < n; i++)
        {
            bool IsGood = true;
            for (int j = 0; j < 4; j++)
            {
                double mark;
                double.TryParse((Console.ReadLine()), out mark);
                if (mark < 0 || mark > 5) return answer;
                if (mark == 2 || mark == 3) IsGood = false;
            }
            if (IsGood) answer++;
        }

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