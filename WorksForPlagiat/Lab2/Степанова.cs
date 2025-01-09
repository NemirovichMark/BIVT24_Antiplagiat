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
        double a = 0;
        while (true)
        {
            Console.WriteLine("¬ведите пароль");
            if (double.TryParse(Console.ReadLine(), out a))
            {
                if (a >= 10000000)
                {
                    Console.WriteLine("¬аш пароль успешно установлен");
                    break;
                }
            }
        }
            
            

        


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
        double r = 2;
        if (Math.Abs(x * x + y * y - r * r) <= 1/(1000))
            answer = true;
        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;
        if (y >= 0 && ((y + Math.Abs(x)) <= 1))
        {
            answer = true;
        }
        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;
        if (a > 0.0)
        {
            if (a > b)
                answer = a;
            else
                answer = b;
        }
        else
        {
            if (a < b)
                answer = a;
            else
                answer = b;
        }

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        if (a < b)
            answer = a;
        else
            answer = b;
        if (answer < c)
            answer = c;
        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;
        if (Math.Sqrt(2 * s) <= 2 * Math.Sqrt(r/Math.PI))
            answer = true;
        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;
        if (Math.Sqrt(s) >= 2 * Math.Sqrt(r/Math.PI))
            answer = true;

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;
        if (Math.Abs(x) > 1.0)
            answer = 1;
        else
            answer = Math.Abs(x);

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;
        if (Math.Abs(x) >= 1.0)
            answer = 0;
        else
            answer = x*x - 1;

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;
        if (x <= -1)
            answer = 0;
        else if (-1 < x  && x <= 0)
            answer = x + 1;
        else
            answer = 1;
        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;
        if (x <= -1)
            answer = 1;
        else if (-1 < x  && x <= 1)
            answer = -x;
        else
            answer = -1;
        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        double x = 0;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            answer += x;
        }
        answer /= n * 1.0;
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x = 0;
        double y = 0;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (Math.Sqrt((x - a) * (x - a) + (y - b) * (y - b)) <= r)
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
        double a = 0;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            if (a < 30.0)
            {
                answer += 200;
            }

        }
        answer /= 1000;
        Console.WriteLine(answer);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        double x = 0;
        double y = 0;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (Math.Sqrt(x*x + y * y) >= r1 && Math.Sqrt(x*x + y * y) <= r2)
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
        double a = 0;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            if (a <= norm)
            {
                answer += 1;
            }
        }
        Console.WriteLine(answer);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        double x = 0;
        double y = 0;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (Math.Sin(x) >= y && y >= 0 && x >= 0 && x <= Math.PI)
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
        double a = 0, b = 0;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out b);
            if (a > 0 && b > 0)
            {
                answer1 += 1;
                Console.WriteLine(1);
            }
            else if (a > 0 && b < 0)
            {
                Console.WriteLine(4);
            }
            else if (a < 0 && b > 0)
            {
                Console.WriteLine(2);
            }
            else if (a < 0 && b < 0)
            {
                answer3 += 1;
                Console.WriteLine(3);
            }
        }
        Console.WriteLine(answer1 + " " +  answer3);
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        double x = 0;
        double y = 0;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (Math.Sqrt(x*x + y * y) < answerLength)
            {
                answerLength = Math.Sqrt(x * x + y * y);
                answer = i + 1;
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double a;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            if (a < answer)
            {
                answer = a;
            }
        }
        Console.WriteLine(answer);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        double a, b, c, d;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out b);
            double.TryParse(Console.ReadLine(), out c);
            double.TryParse(Console.ReadLine(), out d);
            if (a!= 2 && a != 3 && b!= 2 && b!= 3 && c!= 2 && c != 3 && d!= 2 && d!= 3)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        double a, b, c, d;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out b);
            double.TryParse(Console.ReadLine(), out c);
            double.TryParse(Console.ReadLine(), out d);
            if (a <= 2.0 || b <= 2.0 || c <= 2.0 || d <= 2.0)
            {
                answer++;
            }
            avg += (a + b + c + d);
        }
        avg = avg/(n* 4);
        Console.WriteLine(answer);
        Console.WriteLine(avg);

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        switch (type)
        {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = Math.PI * r * r;
                break;
            case 2:
                answer = Math.Sqrt(3)/4 * r * r;
                break;
            default:
                answer = 0;
                break;
        }
        if (r < 0)
            return 0;
        else
            return Math.Round(answer, 2);
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.PI*(Math.Abs(A * A - B * B));
                break;
            case 2:
                answer = Math.Sqrt(B*B - A*A/4) * A/2;
                if (B + B <= A)
                    answer = 0;
                break;
            default:
                answer = 0;
                break;
        }
        if (A < 0 || B < 0)
            answer = 0;
        return Math.Round(answer, 2);
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;
        double a = 0;
        while (double.TryParse(Console.ReadLine(), out a))
        {
            answer += a;
            n += 1;
        }
        answer /= n;
        Console.WriteLine(answer);
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

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_3 answer

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0;
        double x;
        double y;
        while (double.TryParse(Console.ReadLine(), out x))
        {
            double.TryParse(Console.ReadLine(), out y);
            if (Math.Sqrt(x*x + y * y) >= r1 && Math.Sqrt(x*x + y * y) <= r2)
            {
                answer += 1;
            }
        }
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;
        double a = 0;
        while (double.TryParse(Console.ReadLine(), out a))
        {
            if (a <= norm)
                answer += 1;
        }
        Console.WriteLine(answer);

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1
        // answer should be equal to the task_2_6 answer

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0;
        double a = 0, b = 0;
        while (double.TryParse(Console.ReadLine(), out a))
        {
            double.TryParse(Console.ReadLine(), out b);
            if (a > 0 && b > 0)
            {
                answer1 += 1;
                Console.WriteLine(1);
            }
            else if (a > 0 && b < 0)
            {
                Console.WriteLine(4);
            }
            else if (a < 0 && b > 0)
            {
                Console.WriteLine(2);
            }
            else if (a < 0 && b < 0)
            {
                answer3 += 1;
                Console.WriteLine(3);
            }
        }
        Console.WriteLine(answer1 + " " + answer3);
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }

    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;



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
        int answer = 0;
        double a, b, c, d;
        while(double.TryParse(Console.ReadLine(), out a))
        {
            double.TryParse(Console.ReadLine(), out b);
            double.TryParse(Console.ReadLine(), out c);
            double.TryParse(Console.ReadLine(), out d);
            if (a!= 2 && a != 3 && b!= 2 && b!= 3 && c!= 2 && c != 3 && d!= 2 && d!= 3)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);

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
