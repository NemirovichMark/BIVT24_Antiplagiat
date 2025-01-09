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
        //program.Task_2_2(5, 3, 2, 1);
        //program.Task_2_3(8);
        //program.Task_2_4(5, 1, 3);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(4);
        //program.Task_2_7(5);
        //program.Task_2_8(5);
        //program.Task_2_9(10);
        //program.Task_2_10(8);
        //program.Task_2_11(8);
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
        program.Task_3_8();
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
        double r = 2;
        if (Math.Abs(x * x + y * y - r * r) <= 0.001)
        {
            answer = true;
        }
        Console.WriteLine(answer);
        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;
        if (y >= 0 && Math.Abs(x) + y <= 1) { answer = true; }
        Console.WriteLine(answer);
        return answer;

    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;
        if (a > 0 && a > b) { answer = a; }
        if (a > 0 && a < b) { answer = b; }
        if (a <= 0 && a > b) { answer = b; }
        if (a <= 0 && a < b) { answer = a; }
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        if (a < b) { a = a; }
        else { a = b; }
        if (a > c) { answer = a; }
        else { answer = c; }
        Console.WriteLine(answer);
        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;
        double radius = Math.Sqrt(r / double.Pi);
        double diagonal = Math.Sqrt(s * 2);
        if (diagonal <= 2 * radius) { answer = true; }
        Console.WriteLine(answer);
        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;
        double radius = Math.Sqrt(r / double.Pi);
        double storona = Math.Sqrt(s);
        if (2 * radius <= storona) { answer = true; }
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;
        if (Math.Abs(x) > 1) { answer = 1; }
        else { answer = Math.Abs(x); }
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;
        if (Math.Abs(x) >= 1) { answer = 0; }
        else { answer = x * x - 1; }
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;
        if (x <= -1) { answer = 0; }
        else if (-1 < x && x <= 0) { answer = 1 + x; }
        else { answer = 1; };
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;
        if (x <= -1) { answer = 1; }
        else if (-1 < x && x <= 1) { answer = -x; }
        else { answer = -1; };
        Console.WriteLine(answer);

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        double pupil = 0;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out pupil);
            answer += pupil;
        }
        answer /= n;
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x = 0, y = 0;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (((x - a) * (x - a)) + ((y - b) * (y - b)) <= r * r) { answer++; }
        }
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        double weight = 0;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out weight);
            if (weight < 30.0) { answer += 0.2; }
        }
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        double x = 0, y = 0;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((x * x + y * y) >= r1 * r1 && (x * x + y * y) <= r2 * r2) { answer++; }
        }
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        double res = 0;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out res);
            if (res <= norm) { answer++; }
        }
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        double x = 0, y = 0;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x >= 0 && x <= double.Pi && Math.Sin(x) >= y) { answer++; }
        }
        Console.WriteLine(answer);
        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
        double x = 0, y = 0;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x > 0 && y > 0) { answer1++; }
            else if (x < 0 && y > 0) { answer3++; }
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        int answer1 = 0;
        double answerLength = double.MaxValue;
        double x = 0, y = 0;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            answer++;
            if (Math.Sqrt(x * x + y * y) < answerLength)
            {
                answer1 = answer;
                answerLength = Math.Sqrt(x * x + y * y);
            }
        }
        Console.WriteLine(answer1);
        Console.WriteLine(Math.Round(answerLength, 2));
        return (answer1, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double res = 0;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out res);
            if (res < answer) { answer = res; }
        }
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        int mark1 = 0, mark2 = 0, mark3 = 0, mark4 = 0;
        for (int i = 1; i <= n; i++)
        {
            int.TryParse(Console.ReadLine(), out mark1);
            int.TryParse(Console.ReadLine(), out mark2);
            int.TryParse(Console.ReadLine(), out mark3);
            int.TryParse(Console.ReadLine(), out mark4);
            if (mark1 == 2 || mark2 == 2 || mark3 == 2 || mark4 == 2) { continue; }
            else if (mark1 == 3 || mark2 == 3 || mark3 == 3 || mark4 == 3) { continue; }
            else { answer++; }
        }
        Console.WriteLine(answer);
        return answer;
    }
    public (int, double) Task_2_11(double n)
    {
        int answer = 0;
        double avg = 0.0;
        int mark1 = 0, mark2 = 0, mark3 = 0, mark4 = 0;
        for (int i = 1; i <= n; i++)
        {
            int.TryParse(Console.ReadLine(), out mark1);
            int.TryParse(Console.ReadLine(), out mark2);
            int.TryParse(Console.ReadLine(), out mark3);
            int.TryParse(Console.ReadLine(), out mark4);
            if (mark1 == 2 || mark2 == 2 || mark3 == 2 || mark4 == 2) { answer++; }
            avg += mark1 + mark2 + mark3 + mark4;
        }
        avg /= (n * 4);
        Console.WriteLine($"{answer}  {avg}");
        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        if (type < 0 || type > 2 || r <= 0) { return 0; }
        switch (type)
        {
            case (0):
                answer = r * r;
                break;
            case (1):
                answer = double.Pi * r * r;
                break;
            case (2):
                answer = answer = (r * r) * 0.5 * Math.Sin(double.Pi / 3);
                break;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        double h = 0;
        if (type < 0 || type > 2 || A <= 0 || B <= 0) { return 0; }
        switch (type)
        {
            case (0):
                answer = A * B;
                break;
            case (1):
                if (A > B) { answer = (double.Pi * A * A) - (double.Pi * B * B); }
                else if (A < B) { answer = (double.Pi * B * B) - (double.Pi * A * A); }
                break;
            case (2):
                h = Math.Sqrt(B * B - (0.5 * A) * (0.5 * A));
                answer = A * h * 0.5;
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
        int answer = 0;
        string x = string.Empty, y = string.Empty;
        double x1 = 0, y1 = 0;
        for (; ; )
        {
            x = Console.ReadLine();
            if (x == "Stop") break;
            y = Console.ReadLine();
            if (y == "Stop") break;
            x1 = Convert.ToDouble(x);
            y1 = Convert.ToDouble(y);
            if (((x1 - a) * (x1 - a)) + ((y1 - b) * (y1 - b)) <= r * r) { answer++; }
        }
        Console.WriteLine(answer);
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
        string res = string.Empty;
        double res1 = 0;
        for (; ; )
        {
            res = Console.ReadLine();
            if (res == "stop") break;
            res1 = Convert.ToDouble(res);
            if (res1 <= norm) answer++;
        }
        Console.WriteLine(answer);
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
        int answer = 0;
        int answer1 = 0;
        double answerLength = double.MaxValue;
        string x = string.Empty, y = string.Empty;
        double x1 = 0, y1 = 0;
        for (; ; )
        {
            x = Console.ReadLine();
            if (x == "stop") break;
            y = Console.ReadLine();
            if (y == "stop") break;
            x1 = Convert.ToDouble(x);
            y1 = Convert.ToDouble(y);
            answer++;
            if (Math.Sqrt(x1 * x1 + y1 * y1) < answerLength)
            {
                answer1 = answer;
                answerLength = Math.Sqrt(x1 * x1 + y1 * y1);
            }
        }
        Console.WriteLine(answer1);
        Console.WriteLine(Math.Round(answerLength, 2));
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

        // end

        return (answer, avg);
    }
    #endregion
}