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
        double r = 2;

        if (Math.Abs(x * x + y * y - r * r) <= 0.001)
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
        if (y >= 0 && y + Math.Abs(x) <= 1)
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
                answer = a;
            else
                answer = b;
        }
        else
        {
            if (a > b)
                answer = b;
            else
                answer = a;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double min_a_b;

        if (a < b) min_a_b = a;
        else min_a_b = b;

        if (min_a_b > c) answer = min_a_b;
        else answer = c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        r = Math.Sqrt(r / Math.PI);
        s = Math.Sqrt(s);
        s = Math.Sqrt(2) * s;
        if (s <= r * 2)
            answer = true;
        else
            answer = false; 
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double R = Math.Sqrt(r / Math.PI);
        double a = Math.Sqrt(s);
        // code here
        if (2 * R < a)
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
        else
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
        else
        {
            answer = Math.Pow(x, 2) - 1;
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
        else if (x > -1 && x <= 0)
        {
            answer = 1 + x;
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
        else if (x > -1 && x <= 1)
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
        double h, s = 0;
        for (int i = 0; i < n; i++)
        {
            h = double.Parse(Console.ReadLine());
            s += h;
        }
        answer = s / n;
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i += 1)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double distance = Math.Sqrt(Math.Pow(x - a, 2) + Math.Pow(y - b, 2));
            if (distance <= r)
            {
                answer += 1;
            }
        }
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double weight;

        for (int i = 0; i < n; i++)
        {
            weight = double.Parse(Console.ReadLine());

            if (weight < 30)
            {
                answer += 0.2;
            }
        }
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x = 0;
        double y = 0;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x * x + y * y - r1 * r1 >= 0 && x * x + y * y - r2 * r2 <= 0)
            {
                answer = answer + 1;
            }
        }
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double res = double.Parse(Console.ReadLine());
            if (res <= norm)
            {
                answer += 1;
            }
        }
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
            if ((x >= 0) && (x <= Math.PI) && (Math.Sin(x) >= y))
            {
                answer++;
            }
        }
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for (int i = 0; i < n; i++)
{
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    if (x > 0 && y > 0)
    {
        Console.WriteLine($"({x}, {y}) - принадлежат 1 четверти");
        answer1 += 1;
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine($"({x}, {y}) - принадлежат 2 четверти");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine($"({x}, {y}) - принадлежат 3 четверти");
        answer3 += 1;
    }
    else if (x > 0 && y < 0);
    {
        Console.WriteLine($"({x}, {y}) - принадлежат 4 четверти");
    }
    else
    {
        Console.WriteLine($"({x}, {y}) - принадлежат оси координат");
    }
}
Console.WriteLine($"точек в 1 четверти: {answer1}");
Console.WriteLine($"точек в 3 четверти: {answer3}");
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x, y;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            double length = Math.Pow(x * x + y * y, 0.5);
            if (i == 0)
            {
                answerLength = length;
            }
            else if (length < answerLength)
            {
                answerLength = length;
                answer = i + 1;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double prom = 10000, res = 0;
        for (int i = 0; i < n; i++)
        {
            res = double.Parse(Console.ReadLine());
            if (res < prom)
            {
                prom = res;
            }
        }
        answer = prom;
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 0; i < n; i++)
        {
            int m1 = int.Parse(Console.ReadLine());
            int m2 = int.Parse(Console.ReadLine());
            int m3 = int.Parse(Console.ReadLine());
            int m4 = int.Parse(Console.ReadLine());
            if (m1 > 3 && m2 > 3 && m3 > 3 && m4 > 3)
            {
                answer += 1;
            }
        }
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        for (int i = 1; i <= n; i++)
        {
            bool correct = false;
            for (int c = 1; c <= 4; c++)
            {
                double exam = Convert.ToDouble(Console.ReadLine());
                avg += exam;
                if (exam < 3) correct = true;
            }
            if (correct)
            {
                answer++;
            }
        }
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r >= 0)
        {
            switch (type)
            {
                case 0:
                    answer = r * r;
                    break;
                case 1:
                    answer = Math.PI * r * r;
                    break;
                case 2:
                    answer = r * r * Math.Sqrt(3) / 2 / 2;
                    break;
                default:
                    answer = 0;
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
        if (A <= 0 || B <= 0) return 0;
        switch (type)
        {
            case 0:
                answer = A * B; break;
            case 1:
                answer = Math.Abs(Math.PI * A * A - Math.PI * B * B); break;
            case 2:
                answer = Math.Sqrt(B * B - A * A / 4) * A / 2; break;
        }
        answer = Math.Round(answer, 2);
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
        double weight;
        bool stop = false;
        for (int i = 0; ; i++)
        {
            stop = !double.TryParse(Console.ReadLine(), out weight);
            if (stop) break;
            if (weight < 30) answer += 0.2;
        }
        answer = Math.Round(answer, 1); 
        Console.WriteLine(answer);
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

        // end

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here
        bool stop = false;
        double x, y;
        for (int i = 0; ; i++)
        {
            Console.WriteLine($"Input {i + 1} point:");
            stop = !double.TryParse(Console.ReadLine(), out x);
            if (stop) break;
            stop = !double.TryParse(Console.ReadLine(), out y);
            if (stop) break;
            if (y >= 0 && x >= 0 && x <= Math.PI && y <= Math.Sin(x)) answer += 1;
        }
        Console.WriteLine(answer);
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

        // end

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here
        bool stop = false;
        double best = -1, current;
        for (int i = 0; i < n; i++)
        {
            stop = !double.TryParse(Console.ReadLine(), out current);
            if (stop) break;
            if (best == -1) best = current;
            else if (current < best) best = current;
        }
        Console.WriteLine(best);
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
