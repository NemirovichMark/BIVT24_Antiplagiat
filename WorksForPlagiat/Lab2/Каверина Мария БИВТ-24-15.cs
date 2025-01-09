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
        if (Math.Abs(x * x + y * y - 4) <= 0.001)
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 & y + Math.Abs(x) <= 1)
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
        answer = a;
        if (a > 0)
        {
            if (a < b)
                answer = b;
        }
        else
        {
            if (a > b)
                answer = b;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        answer = a;
        if (a > b)
            answer = b;
        if (c > answer)
            answer = c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (Math.Sqrt(s / 2) <= Math.Sqrt(r / Math.PI))
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (Math.Sqrt(s / 4) >= Math.Sqrt(r / Math.PI))
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
        else if (-1 < x & x < 0)
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
        else if (-1 < x & x <= 1)
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
        for (int i = 1; i <= n; i++)
        {
            answer += double.Parse(Console.ReadLine());
        }
        answer /= n;
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((a - x) * (a - x) + (b - y) * (b - y) < r * r)
            {
                answer++;
            }
        }
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double weight = double.Parse(Console.ReadLine());
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
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double p = Math.Sqrt(x * x + y * y);
            if (p >= r1 && p <= r2)
                answer++;
        }
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double res = double.Parse(Console.ReadLine());
            if (res <= norm)
                answer++;
        }
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((x >= 0 && x <= Math.PI) && (y >= 0 && y <= 1) &&  y <= Math.Sin(x))
                answer++;
        }
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                answer1++;
                Console.WriteLine("Точка находится в 1 квадранте");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Точка находится во 2 квадранте");
            }
            else if (x < 0 && y < 0)
            {
                answer3++;
                Console.WriteLine("Точка находится в 3 квадранте");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Точка находится в 4 квадранте");
            }
        }

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double length = Math.Sqrt(x * x + y * y);
            if (length <= answerLength)
            {
                answerLength = length;
                answer = i;
            }
        }
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double res = double.Parse(Console.ReadLine());
            if (res < answer)
                answer = res;
        }
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 1; i <= n; i++)
        {
            double m1 = double.Parse(Console.ReadLine());
            double m2 = double.Parse(Console.ReadLine());
            double m3 = double.Parse(Console.ReadLine());
            double m4 = double.Parse(Console.ReadLine());
            if (m1 > 3 && m2 > 3 && m3 > 3 && m4 > 3)
                answer++;
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
            double e1 = double.Parse(Console.ReadLine());
            double e2 = double.Parse(Console.ReadLine());
            double e3 = double.Parse(Console.ReadLine());
            double e4 = double.Parse(Console.ReadLine());
            if (e1 == 2 || e2 == 2 || e3 == 2 || e4 == 2)
                answer++;
            avg += (e1 + e2 + e3 + e4)/4;
        }
        avg /= n;
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r > 0)
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
                default: 
                    break;
            }
            answer = Math.Round(answer, 2);
            // end

            return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A > 0 && B > 0)
            switch (type)
            {
                case 0:
                     answer = A * B; 
                     break;
                case 1:
                     answer = Math.Abs(Math.PI * A * A - Math.PI * B * B); 
                     break;
                case 2:
                     answer = (A * Math.Sqrt(B * B - A * A / 4)) / 2; 
                     break;
                default:
                      break;
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
        string input = Console.ReadLine();
        while (input != "end")
        {
            double x = double.Parse(input);
            input = Console.ReadLine();
            double y = double.Parse(input);
            if ((a - x) * (a - x) + (b - y) * (b - y) < r * r)
            {
                answer++;
            }
            input = Console.ReadLine();
            if (input == "end") break;
        }
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
        string input = Console.ReadLine();
        while (input != "end")
        {
            double res = double.Parse(input);
            if (res <= norm)
                answer++;
            input = Console.ReadLine();
        }
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
        string input = Console.ReadLine();
        while (input != "end")
        {
            double x = double.Parse(input);
            input = Console.ReadLine();
            double y = double.Parse(input);
            double length = Math.Sqrt(x * x + y * y);
            n++;
            if (length <= answerLength)
            {
                answerLength = length;
                answer = n;
            }
            input = Console.ReadLine();
        }
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
        string input = Console.ReadLine();
        while (input != "end")
        {
            double e1 = double.Parse(input);
            input = Console.ReadLine();
            double e2 = double.Parse(input);
            input = Console.ReadLine();
            double e3 = double.Parse(input);
            input = Console.ReadLine();
            double e4 = double.Parse(input);
            if (e1 == 2 || e2 == 2 || e3 == 2 || e4 == 2)
                answer++;
            avg += (e1 + e2 + e3 + e4) / 4;
            n++;
            input = Console.ReadLine();
        }
        if (n > 0)
            avg /= n;
        // end

        return (answer, avg);
    }
    #endregion
}
