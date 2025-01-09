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
        //program.Task_2_3(10);
        //program.Task_2_4(5, 1, 3);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(5);
        //program.Task_2_7(5);
        //program.Task_2_8(5);
        //program.Task_2_9(8);
        //program.Task_2_10(10);
        //program.Task_2_11(8);
        //program.Task_2_12(1.5, 2);
        //program.Task_2_13(3, 2.5, 1);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 3);
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
        double r = 2.0;

        return Math.Abs(x * x + y * y - r * r) <= 0.001;
    }
    public bool Task_1_2(double x, double y)
    {
        return (y >= 0 && y + Math.Abs(x) <= 1);
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        if (a > 0)
        {
            if (a >= b) answer = a;
            else answer = b;
        }
        else if (a <= 0)
        {
            if (a <= b) answer = a;
            else answer = b;
        }

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        double min_ab = 0;

        if (a <= b) min_ab = a;
        else min_ab = b;

        if (min_ab >= c) answer = min_ab;
        else answer = c;

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        double diagonal_squared = 2 * s;
        double diameter_squared = 4 * r / Math.PI;

        return diagonal_squared <= diameter_squared;
    }
    public bool Task_1_6(double r, double s)
    {
        double diameter_squared = 4 * r / Math.PI;

        return diameter_squared <= s;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        if (Math.Abs(x) > 1)
        {
            answer = 1;
        } else
        {
            answer = Math.Abs(x);
        }

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        if (Math.Abs(x) >= 1)
        {
            answer = 0;
        } else
        {
            answer = x * x - 1;
        }
        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        if (x <= -1)
        {
            answer = 0;
        }
        else if (-1 < x && x <= 0)
        {
            answer = 1 + x;
        }
        else answer = 1;

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        if (x <= -1)
        {
            answer = 1;
        } 
        else if (-1 < x && x <= 1)
        {
            answer = -x;
        } 
        else answer = -1;

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        if (n == 0) return answer;

        for (int i = 0; i < n; i++)
        {
            answer += double.Parse(Console.ReadLine());
        }

        answer /= n;

        Console.WriteLine(answer);

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {

        int answer = 0;

        if (n == 0) return answer;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());

            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r) answer++;
        }

        Console.WriteLine(answer);

        return answer;
    }
    public double Task_2_3(int n)
    {

        double answer = 0;

        if (n == 0) return answer;

        for (int i = 0; i < n; i++)
        {
            double w = double.Parse(Console.ReadLine());

            if (w < 30) answer += 0.2;
        }

        Console.WriteLine(answer);

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {

        int answer = 0;

        if (n == 0) return answer;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
            if (x * x + y * y >= r1 * r1 && x * x + y * y <= r2 * r2) answer++;
        }

        Console.WriteLine(answer);

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {

        int answer = 0;

        if (n == 0) return answer;

        for (int i = 0; i < n; i++)
        {
            double current = double.Parse(Console.ReadLine());
            if (current < norm) answer++;
        }

        Console.WriteLine(answer);

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        if (n == 0) return answer;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());

            if (0 <= x && x <= Math.PI && y >= 0 && y <= Math.Sin(x)) answer++;
        }

        Console.WriteLine(answer);

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        if (n == 0) return (answer1, answer3);

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
            if (x >= 0 && y >= 0)
            {
                Console.WriteLine("First quadrant");
                answer1++;
            }
            else if (x <= 0 && y >= 0)
            {
                Console.WriteLine("Second quadrant");
            }
            else if (x <= 0 && y <= 0)
            {
                Console.WriteLine("Third quadrant");
                answer3++;
            }
            else
            {
                Console.WriteLine("Fourth quadrant");
            }
        }

        Console.WriteLine("answer1: {0}, answer3: {1}", answer1, answer3);

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        if (n == 0) return (answer, 0);

        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());

            double len = Math.Sqrt(x * x + y * y);
            if (len < answerLength)
            {
                answerLength = len;
                answer = i;
            }
        }

        Console.WriteLine("answer: {0}, answerLength: {1}", answer, answerLength);

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        if (n == 0) return 0;

        for (int i = 0; i < n; i++)
        {
            double res = double.Parse(Console.ReadLine());
            if (res < answer) answer = res;
        }

        Console.WriteLine(answer);

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            bool flag = true;

            for (int j = 0; j < 4; j++)
            {
                int mark = int.Parse(Console.ReadLine());
                if (mark == 2 || mark == 3) flag = false;
            }

            if (flag) answer++;
        }

        Console.WriteLine(answer);

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        if (n == 0) return (answer, avg);

        for (int i = 0; i < n; i++)
        {
            bool flag = false;

            for (int j = 0; j < 4; j++)
            {
                int mark = int.Parse(Console.ReadLine());

                avg += mark;

                if (mark == 2) flag = true;
            }
            if (flag) answer++;
        }

        avg /= 4 * n;

        Console.WriteLine("answer: {0}, avg: {1}", answer, avg);

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        if (r <= 0) return answer;

        switch(type)
        {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = Math.PI * r * r;
                break;
            case 2:
                answer = Math.Sqrt(3) * r * r / 4;
                break;
        }

        Console.WriteLine(answer);

        return Math.Round(answer, 2);
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        if (A <= 0 || B <= 0) return answer;

        switch(type)
        {
            case 0:
                answer = A * B;
                break; 
            case 1:
                answer = Math.Abs(Math.PI * (A * A - B * B));
                break;
            case 2:
                double p = (A + B + B) / 2;
                answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B));
                break;
        }

        Console.WriteLine(answer);

        return Math.Round(answer, 2);
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;

        // code here

        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }

    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0;
        double x, y;
        if (!double.TryParse(Console.ReadLine(), out x) || !double.TryParse(Console.ReadLine(), out y)) return answer;

        do
        {
            if ((x - a) * (x - a) + (y - b) <= r * r) answer++;
        } while (double.TryParse(Console.ReadLine(), out x) && double.TryParse(Console.ReadLine(), out y));

        Console.WriteLine(answer);

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

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_4 answer

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0;
        double input;
        if (!double.TryParse(Console.ReadLine(), out input)) return answer;

        do
        {
            if (input < norm) answer++;
        } while (double.TryParse(Console.ReadLine(), out input));

        Console.WriteLine(answer);

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 2, 0.5 0.9, -1 1.5, 0.5 1.5
        // answer should be equal to the task_2_6 answer

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_7 answer

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, counter = 0;
        double answerLength = double.MaxValue;
        double x, y;

        if (!double.TryParse(Console.ReadLine(), out x) || !double.TryParse(Console.ReadLine(), out y)) return (answer, 0);

        do
        {
            counter++;
            double len = Math.Sqrt(x * x + y * y);
            if (len < answerLength)
            {
                answerLength = len;
                answer = counter;
            }
        } while (double.TryParse(Console.ReadLine(), out x) && double.TryParse(Console.ReadLine(), out y));

        Console.WriteLine("answer: {0}, answerLength: {1}", answer, answerLength);

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
        int answer = 0;

        // code here;

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_10 answer

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, counter = 0;
        double avg = 0.0;
        double[] marks = new double[4];

        bool flag = false;

        do
        {
            bool bad = false;

            for (int i = 0; i < 4; i++)
            {
                bool res = double.TryParse(Console.ReadLine(), out marks[i]);
                if (!res)
                {
                    flag = true;
                    break;
                }
                else
                {
                    avg += marks[i];
                    if (marks[i] == 2) bad = true;
                }
            }

            if (!flag)
                counter++;

            if (bad) 
                answer++;


        } while (!flag);

        avg /= 4 * counter;

        Console.WriteLine("answer: {0}, avg: {1}", answer, avg);

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
