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

        long password;
        while (true) {
            bool r = long.TryParse(Console.ReadLine(), out password);
            if (!r)
            {
                continue;
            }
            if (password < 10000000)
            {
                continue;
            }
            break;
        }
        Console.WriteLine($"Ваш пароль {password} успешно установлен");


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
        const int r = 2;
        answer = Math.Abs(x * x + y * y - r * r) <= 0.001;
        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;
        answer = y >= 0 && y + Math.Abs(x) <= 1;
        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;
        if (a > 0)
        {
            answer = Math.Max(a, b);
        } else
        {
            answer = Math.Min(a, b);
        }
        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        double temp;
        if (a > b) temp = b;
        else temp = a;

        if (temp > c) answer = temp;
        else answer = c;

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;
        double radius = Math.Pow(r / Math.PI, 0.5);
        double diag = Math.Pow(2 * s, 0.5);
        answer = diag / 2 < radius;
        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;
        double radius = Math.Pow(r / Math.PI, 0.5);
        double side = Math.Pow(s, 0.5);
        answer = radius < side / 2;
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
        else answer = -x;
        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            int height = int.Parse(Console.ReadLine());
            sum += height;
        }
        answer = sum / n;
        Console.WriteLine(answer);
        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        for (int i = 0; i < n; i++)
        {
            double x, y;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (Math.Pow(x - a, 2) + Math.Pow(y - b, 2) < r * r) answer++;
        }
        Console.WriteLine(answer);

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        for ( int i = 0; i < n; i++)
        {
            double weight = double.Parse(Console.ReadLine());
            if (weight < 30) answer += 200;
        }
        answer /= 1000;
        Console.WriteLine(answer);

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        for (int i = 0; i < n; i++)
        {
            double x, y, distSq;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            distSq = x * x + y * y;
            if (r1 * r1 <= distSq && distSq <= r2 * r2) answer++;
        }
        Console.WriteLine(answer);
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        for (int i = 0; i < n; i++)
        {
            double res = double.Parse(Console.ReadLine());
            if (res < norm) answer++;
        }
        Console.WriteLine(answer);

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        for (int i = 0; i < n; i++)
        {
            double x, y;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (0 <= x && x <= Math.PI && 0 <= y && y <= Math.Sin(x)) answer++;
        }
        Console.WriteLine(answer);
        // for test input in console: -1.2 0.7, 2 2, 0.5 0.9, -1 1.5, 0.5 1.5

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
        for (int i = 0; i < n; i++)
        {
            double x, y;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x >= 0 && y >= 0)
            {
                answer1++;
                Console.WriteLine(1);
            }
            else if (x < 0 && y >= 0) Console.WriteLine(2);
            else if (x < 0 && y < 0)
            {
                answer3++;
                Console.WriteLine(3);
            } else Console.WriteLine(4);
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        for (int i = 0; i < n; i++)
        {
            double x, y;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            double dist = Math.Pow(x * x + y * y, 0.5);
            if (dist < answerLength)
            {
                answer = i + 1;
                answerLength = dist;
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        for (int i = 0; i < n; i++)
        {
            double time = double.Parse((Console.ReadLine()));
            if (time < answer) answer = time;
        }
        Console.WriteLine(answer);

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        for (int i = 0; i < n; i++)
        {
            bool have2or3 = false;
            for (int j = 0; j < 4; j++)
            {
                int mark = int.Parse((Console.ReadLine()));
                if (mark == 2 || mark == 3) have2or3 = true;
            }
            if (!have2or3) answer++;
        }
        Console.WriteLine(answer);
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        double sum = 0.0;
        for (int i = 0; i < n; i++)
        {
            bool have2 = false;
            for (int j = 0; j < 4; j++)
            {
                int mark = int.Parse((Console.ReadLine()));
                if (mark == 2) have2 = true;
                sum += mark;
            }
            if (have2) answer++;
        }
        avg = sum / n / 4;
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        if (r < 0)
        {
            return 0;
        }
        switch (type)
        {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = Math.PI * r * r;
                break;
            case 2:
                answer = r * r * Math.Pow(3, 0.5) / 4;
                break;

        }
        answer = Math.Round(answer, 2);
        int a = -1;
        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        if (A < 0 || B < 0) return 0;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                if (B < A) return 0;
                answer = Math.PI * (B * B - A * A);
                break;
            case 2:
                if (2 * B < A) return 0;
                answer = Math.Pow(B * B - A * A / 4, 0.5) * A / 2;
                break;
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

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        for (; ;n++)
        {
            double x, y;
            x = double.Parse(Console.ReadLine());
            if (x > 1000)
            {
                break;
            }
            y = double.Parse(Console.ReadLine());
            if (Math.Pow(x - a, 2) + Math.Pow(y - b, 2) < r * r) answer++;
        }
        Console.WriteLine(answer);

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here

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
        for (; ;n++ )
        {
            double res = double.Parse(Console.ReadLine());
            if (res < 0)
            {
                break;
            }
            if (res < norm) answer++;
        }
        Console.WriteLine(answer);

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 2, 0.5 0.9, -1 1.5, 0.5 1.5
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
        for (; ;n++ )
        {
            double x, y;
            x = double.Parse(Console.ReadLine());
            if (x > 1000)
            {
                break;
            }
            y = double.Parse(Console.ReadLine());
            double dist = Math.Pow(x * x + y * y, 0.5);
            if (dist < answerLength)
            {
                answer = n + 1;
                answerLength = dist;
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_8 answer

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here

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
        double sum = 0.0;
        for (; ;n++ )
        {
            bool have2 = false;
            for (int j = 0; j < 4; j++)
            {
                int mark = int.Parse((Console.ReadLine()));
                if (mark < 0)
                {
                    goto LoopEnd;
                }
                if (mark == 2) have2 = true;
                sum += mark;
            }
            if (have2) answer++;
        }
        LoopEnd:
        avg = sum / n / 4;
        Console.WriteLine(answer);
        Console.WriteLine(avg);

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
