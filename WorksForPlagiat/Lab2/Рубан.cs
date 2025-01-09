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
        //program.Task_2_3(8);
        //program.Task_2_3(6);
        //program.Task_2_4(5, 1, 2);
        //program.Task_2_4(5, 1, 3);
        //program.Task_2_4(4, 1, 2);
        //program.Task_2_4(4, 1, 3);
        //program.Task_2_4(3, 1, 2);
        //program.Task_2_4(3, 1, 3);
        //program.Task_2_5(10, 30);
        //program.Task_2_5(10, 25.2);
        //program.Task_2_5(8, 30);
        //program.Task_2_5(8, 25.2);
        //program.Task_2_5(6, 30);
        //program.Task_2_5(6, 25.2);
        //program.Task_2_6(5);
        //program.Task_2_6(4);
        //program.Task_2_6(3);
        //program.Task_2_7(5);
        //program.Task_2_7(4);
        //program.Task_2_7(3);
        //program.Task_2_8(5);
        //program.Task_2_8(4);
        //program.Task_2_8(3);
        //program.Task_2_9(10);
        //program.Task_2_9(8);
        //program.Task_2_9(6);
        //program.Task_2_10(10);
        //program.Task_2_10(8);
        //program.Task_2_10(6);
        //program.Task_2_11(10);
        //program.Task_2_11(8);
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
        if (Math.Abs(x * x + y * y - 4) <= 0.001) answer = true;
        // end
        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if ((y >= 0) && ((y + Math.Abs(x)) < 1)) answer = true;
        // end
        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)
        {
            answer = b;
            if (a > b) answer = a;
        }
        else
        {
            answer = b;
            if (a < b) answer = a;
        }
        // end
        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double d = b;
        if (a < b) d = a;
        answer = d;
        if (c > d) answer = c;
        // end
        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (2 * Math.Sqrt(r / Math.PI) >= Math.Sqrt(2 * s)) answer = true;
        // end
        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (2 * Math.Sqrt(r / Math.PI) <= Math.Sqrt(s)) answer = true;
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
            answer = x * x - 1;
        }
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x > 0)
        {
            answer = 1;
        }
        else if (x > -1)
        {
            answer = 1 + x;
        }
        else
        {
            answer = 0;
        }
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x > 1)
        {
            answer = -1;
        }
        else if (x > -1)
        {
            answer = -x;
        }
        else
        {
            answer = 1;
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
        for (int i = 0; i < n; i++) answer += int.Parse(Console.ReadLine());
        answer /= n;
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r) answer++;
        }
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for (int i = 0; i < n; i++) if (double.Parse(Console.ReadLine()) < 30) answer += 0.2;
        answer = Math.Round(answer, 1);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double a, b;
        for (int i = 0; i < n; i++)
        {
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            if ((a * a + b * b <= r2 * r2) && (a * a + b * b > r1 * r1)) answer++;
        }
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++) if (double.Parse(Console.ReadLine()) < norm) answer++;
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double a, b;
        for (int i = 0; i < n; i++)
        {
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            if ((b <= Math.Sin(a)) && (a >= 0) && (a <= Math.PI) && (b >= 0)) answer++;
        }
        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1
        Console.WriteLine(answer);
        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        double a, b;
        for (int i = 0; i < n; i++)
        {
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            if ((a > 0) && (b > 0))
            {
                Console.WriteLine(1);
                answer1++;
            }
            else if ((a < 0) && (b > 0))
            {
                Console.WriteLine(2);
            }
            else if ((a < 0) && (b < 0))
            {
                Console.WriteLine(3);
                answer3++;
            }
            else if ((a > 0) && (b < 0))
            {
                Console.WriteLine(4);
            }
        }
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double a, b;
        for (int i = 0; i < n; i++)
        {
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            if (answerLength > Math.Sqrt((a * a) + (b * b)))
            {
                answerLength = Math.Sqrt((a * a) + (b * b));
                answer = i + 1;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double a;
        for (int i = 0; i < n; i++)
        {
            a = double.Parse(Console.ReadLine());
            if (answer > a) answer = a;
        }
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int a, b, c, d;
        for (int i = 0; i < n; i++)
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            if ((a > 3) && (b > 3) && (c > 3) && (d > 3))
            {
                answer++;
            }
        }
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        Console.WriteLine(answer);
        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        int a, b, c, d;
        for (int i = 0; i < n; i++)
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            avg += (a + b + c + d);
            if (!((a > 2) && (b > 2) && (c > 2) && (d > 2)))
            {
                answer++;
            }
        }
        avg /= (n * 4);
        avg = Math.Round(avg, 1);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        Console.WriteLine(answer);
        Console.WriteLine(avg);
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
                case 0:
                    answer = r * r;
                    break;
                case 1:
                    answer = Math.PI * r * r;
                    break;
                case 2:
                    answer = r * r * Math.Sqrt(3) / 4;
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
        if ((A > 0) && (B > 0))
        {
            switch (type)
            {
                case 0:
                    answer = A * B;
                    break;
                case 1:
                    answer = Math.PI * Math.Abs(B * B - A * A);
                    break;
                case 2:
                    answer = 0.5 * A * Math.Sqrt(B * B - 0.25 * A * A);
                    break;
            }
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

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here
        string lain;
        double x, y;
        Console.WriteLine("Напишите \"!\", чтобы остановить программу.");
        while (true)
        {
            lain = Console.ReadLine();
            if (lain == "!") break;
            x = double.Parse(lain);
            lain = Console.ReadLine();
            if (lain == "!") break;
            y = double.Parse(lain);
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r) answer++;
        }
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer
        Console.WriteLine(answer);
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

        // code here
        string lain;
        Console.WriteLine("Напишите \"!\", чтобы остановить программу.");
        while (true)
        {
            lain = Console.ReadLine();
            if (lain == "!") break;
            if (double.Parse(lain) < norm) answer++;
        }
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer
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

        // code here
        string lain;
        double a, b;
        int i = 0;
        Console.WriteLine("Напишите \"!\", чтобы остановить программу.");
        while (true)
        {
            lain = Console.ReadLine();
            if (lain == "!") break;
            a = double.Parse(lain);
            lain = Console.ReadLine();
            if (lain == "!") break;
            b = double.Parse(lain);
            i++;
            if (answerLength > Math.Sqrt((a * a) + (b * b)))
            {
                answerLength = Math.Sqrt((a * a) + (b * b));
                answer = i;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_8 answer
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
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

        // code here;
        int a, b, c, d;
        string lain;
        Console.WriteLine("Напишите \"!\", чтобы остановить программу. Учтены будут только полные четвёрки чисел.");
        while (true)
        {
            lain = Console.ReadLine();
            if (lain == "!")
            {
                break;
            }
            else
            {
                a = int.Parse(lain);
            }
            lain = Console.ReadLine();
            if (lain == "!")
            {
                break;
            }
            else
            {
                b = int.Parse(lain);
            }
            lain = Console.ReadLine();
            if (lain == "!")
            {
                break;
            }
            else
            {
                c = int.Parse(lain);
            }
            lain = Console.ReadLine();
            if (lain == "!")
            {
                break;
            }
            else
            {
                d = int.Parse(lain);
            }
            n++;
            avg += (a + b + c + d);
            if (!((a > 3) && (b > 3) && (c > 3) && (d > 3)))
            {
                answer++;
            }
        }
        avg /= (n * 4);
        avg = Math.Round(avg, 1);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_11 answer
        Console.WriteLine(answer);
        Console.WriteLine(avg);
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
