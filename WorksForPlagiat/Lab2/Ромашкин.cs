using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        //program.Task_2_3(6);
        //program.Task_2_4(3, 1, 3);
        //program.Task_2_5(6, 25.2);
        //program.Task_2_6(3);
        //program.Task_2_7(4);
        //program.Task_2_8(5);
        //program.Task_2_9(0);
        //program.Task_2_10(10);
        //program.Task_2_11(0);
        //program.Task_2_12(1.5, 0);
        program.Task_2_13(1.2, 0.2, -4);
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
        if (Math.Abs(x * x + y*y - 4)<= Math.Pow(10,-3))
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if ((y >= 0) && (y + Math.Abs(x) <= 1))
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
        if (a > b)
        {
            a = b;
            if (a > c)
                answer = a;
            else
                answer = c;
        }
        else
            if (a > c)
            answer = a;
        else
            answer = c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double R = Math.Sqrt(r / Math.PI);
        double S = Math.Sqrt(s);
        double sm = Math.Sqrt(R * R + R * R);
        if (S < sm)
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double R = Math.Sqrt(r / Math.PI);
        double S = Math.Sqrt(s);
        if (R * 2 < S)
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
            answer = x * x - 1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 0;
        else if ((x > -1) && (x <= 0))
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
        else if ((x > -1) && (x <= 1))
            answer = -x;
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
        double s = 0;
        for (int i = 1; i <= n; i++)
        {
            s += double.Parse(Console.ReadLine());
        }
        answer = s / n;
        Console.WriteLine(answer);
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int i = 1; i<= n; i++)
        {
            string[] xy = Console.ReadLine().Split(' ');
            double x = double.Parse(xy[0]);
            double y = double.Parse(xy[1]);
            if ((a - x) * (a - x) + (b - y) * (b - y) <= r * r)
                answer += 1;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double mass = double.Parse(Console.ReadLine());
            if (mass < 30)
                answer += 0.2;
        }
        Console.WriteLine(Math.Round(answer,1));
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i= 1; i <= n; i++)
        {
            string[] xy = Console.ReadLine().Split(' ');
            double x = double.Parse(xy[0]);
            double y = double.Parse(xy[1]);
            if (((x * x) + (y * y) >= r1*r1) && ((x * x) + (y * y) <= r2*r2))
                answer += 1;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double time = double.Parse(Console.ReadLine());
            if (time < norm)
                answer++;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            string[] xy = Console.ReadLine().Split(' ');
            double x = double.Parse(xy[0]);
            double y = double.Parse(xy[1]);
            if ((y >= 0) && (x >= 0) && (x <= Math.PI) && (y <= Math.Sin(x)))
                answer++;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for (int i= 1; i <= n; i++)
        {
            string[] xy = Console.ReadLine().Split(' ');
            double x = double.Parse(xy[0]);
            double y = double.Parse(xy[1]);
            if (x >= 0)
            {
                if (y >= 0)
                {
                    Console.WriteLine('1');
                    answer1++;
                }
                else
                    Console.WriteLine('4');
            }
            else
            {
                if (y >= 0)
                    Console.WriteLine('2');
                else
                {
                    Console.WriteLine('3');
                    answer3++;
                }
            }
        }
        Console.Write(answer1+" ");
        Console.Write(answer3);
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                string[] xy = Console.ReadLine().Split(' ');
                double x = double.Parse(xy[0]);
                double y = double.Parse(xy[1]);
                if (Math.Sqrt(x * x + y * y) < answerLength)
                {
                    answer = i;
                    answerLength = Math.Sqrt(x * x + y * y);
                }
            }
        }
        else
            answerLength = 0;
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength,2));
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                double res = double.Parse(Console.ReadLine());
                if (res < answer)
                    answer = res;
            }
        }
        else
            answer = 0;
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 1; i <=n; i++)
        {
            int t = 1;
            for (int j = 1; j <= 4; j++)
            {
                string s = Console.ReadLine();
                if ((s == "2") || (s == "3"))
                {
                    t = 0;
                    
                }
            }
            answer += t;
        }
        Console.WriteLine("!!!"+answer);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double sum = 0; 
        for (int i = 1; i <= n; i++)
        {
            int t = 0;
            for (int j = 1; j <= 4; j++)
            {
                string s = Console.ReadLine();
                sum += double.Parse(s);
                if ((s == "2"))
                {
                    t = 1;

                }
            }
            answer += t;
        }
        if (n != 0)
            avg = sum/(n*4);
        Console.WriteLine(Math.Round(avg,2));
        Console.WriteLine(answer);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if ((r <= 0) || (type > 2) || (type <0))
        {
            return 0;
        }
        switch (type)
        {
            case 0:
                answer = Math.Round(r * r, 2);
                break;
            case 1:
                answer = Math.Round(Math.PI * r * r, 2);
                break;
            case 2:
                answer = Math.Round(Math.Sqrt(3) * r * r / 4, 2);
                break;
        }

        Console.WriteLine(answer.ToString());
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if ((A<=0) || (B<=0) || (type <0) || (type > 2))
        {
            return 0;
        }
        switch (type)
        {
            case 0:
                answer = Math.Round(A * B, 2);
                break;
            case 1:
                if (A > B)
                    return 0;
                answer = Math.Round(Math.PI * (B*B - A*A), 2);
                break;
            case 2:
                answer = Math.Round(Math.Sqrt(B * B - A * A / 4) * A / 2, 2);
                break;
        }

        // end
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
        
        double s = 0;
        for (int i = 1; i <= int.MaxValue; i++)
        {
            double h = double.Parse(Console.ReadLine());
            if (h == -1)
                break;
            s += h;
            n++;
        }
        answer = s / n;
        Console.WriteLine(answer);
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

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
        int answer = 0, n = 0;

        // code here
        for (int i = 1; i <= int.MaxValue; i++)
        {
            string[] xy = Console.ReadLine().Split(' ');
            if (xy[0] == "a")
                break;
            double x = double.Parse(xy[0]);
            double y = double.Parse(xy[1]);
            if (((x * x) + (y * y) >= r1 * r1) && ((x * x) + (y * y) <= r2 * r2))
                answer += 1;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_4 answer

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer

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
        for (int i = 1; i <= int.MaxValue; i++)
        {
            string[] xy = Console.ReadLine().Split(' ');
            if (xy[0] == "a")
                break;
            double x = double.Parse(xy[0]);
            double y = double.Parse(xy[1]);
            if (x >= 0)
            {
                if (y >= 0)
                {
                    Console.WriteLine('1');
                    answer1++;
                }
                else
                    Console.WriteLine('4');
            }
            else
            {
                if (y >= 0)
                    Console.WriteLine('2');
                else
                {
                    Console.WriteLine('3');
                    answer3++;
                }
            }
        }
        Console.Write(answer1 + " ");
        Console.Write(answer3);
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

        // end

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
        int flag = 0;
        for (int i = 1; i <= int.MaxValue; i++)
        {
            int t = 1;
            for (int j = 1; j <= 4; j++)
            {
                string s = Console.ReadLine();
                if (s == "a")
                {
                    flag = 1;
                    break;
                }

                if ((s == "2") || (s == "3"))
                {
                    t = 0;

                }
            }
            if (flag == 1)
                break;
            answer += t;
        }
        Console.WriteLine("!!!" + answer);
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