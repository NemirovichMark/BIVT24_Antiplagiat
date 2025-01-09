using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
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
        //program.Task_2_2(5, 1, 3, 1);
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
        program.Task_2_12(10, 2);
        program.Task_2_13(5, 10, 2);
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
        int r = 2;
        if (Math.Abs(x*x + y*y - r*r) <= 0.01)
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 & y + Math.Abs(x) <= 1)
            answer = true;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0, max = 0, min = 0;

        // code here
        if (a > b)
        {
            max = a;
            min = b;
        }
        else
        {
            max = b;
            min = a;
        }
        if (a > 0)
            answer = max;
        else
            answer = min;
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0, max = 0, min = 0;

        // code here
        if (a > b)
        {
            min = b;
        }
        else
        {
            min = a;
        }
        if (min > c)
        {
            max = min;
        }
        else
        {
            max = c;
        }
        answer = max;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (Math.Pow(r/Math.PI, 0.5) * 2 >= Math.Pow(2*s, 0.5))
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (Math.Pow(r / Math.PI, 0.5) * 2 < Math.Pow(s, 0.5))
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
        else if (x > -1 & x <= 0)
            answer = x + 1;
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
        else if (x > -1 & x <= 1)
            answer = -1 * x;
        else
            answer = -1;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    // ÇÀÄÀ×À
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            answer += double.Parse(Console.ReadLine());
        }
        answer /= n;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (Math.Pow((x - a), 2) + Math.Pow((y - b), 2) <= Math.Pow(r, 2))
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double weigth = double.Parse(Console.ReadLine());
            if (weigth < 30)
                answer += 0.2;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    // ÇÀÄÀ×À
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double distance = Math.Sqrt(x * x + y * y);

            if (distance >= r1 && distance <= r2)
                answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double result = double.Parse(Console.ReadLine());
            if (result <= norm)
                answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (y >= 0 && y <= Math.Sin(x) && x >= 0 && x <= Math.PI)
                answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    // ÇÀÄÀ×À
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        int k;
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x > 0)
            {
                if (y > 0)
                    k = 1;
                else
                    k = 4;
            }
            else
            {
                if (y > 0)
                    k = 2;
                else
                    k = 3;
            }
            Console.WriteLine(k);
            switch (k)
            {
                case 1:
                    answer1++;
                    break;
                case 3:
                    answer3++;
                    break;
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
        double[] distances = new double[n];
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            distances[i] = Math.Sqrt(x * x + y * y);
            if (distances[i] < answerLength)
            {
                answerLength = distances[i];
                answer = i + 1;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double[] results = new double[n];
        for (int i = 0; i < n; i++)
        {
            double res = double.Parse(Console.ReadLine());
            results[i] = res;
            if (results[i] < answer)
                answer = results[i];
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    // ÇÀÄÀ×À
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 0; i < n; i++)
        {
            double m1 = double.Parse(Console.ReadLine());
            double m2 = double.Parse(Console.ReadLine());
            double m3 = double.Parse(Console.ReadLine());
            double m4 = double.Parse(Console.ReadLine());
            if ((m1 > 3) && (m2 > 3) && (m3 > 3) && (m4 > 3))
                answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        for (int i = 0; i < n; i++)
        {
            double m1 = double.Parse(Console.ReadLine());
            double m2 = double.Parse(Console.ReadLine());
            double m3 = double.Parse(Console.ReadLine());
            double m4 = double.Parse(Console.ReadLine());
            avg += (m1 + m2 + m3 + m4) / 4;
            if ((m1 < 3) || (m2 < 3) || (m3 < 3) || (m4 < 3))
                answer++;
        }
        avg = Math.Round(avg / n, 9);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r < 0)
            return 0;
        switch (type)
        {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = Math.PI * r * r;
                break;
            case 2:
                answer = (r * r * Math.Sqrt(3)) / 4;
                break;
            default: return 0;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A < 0 || B < 0)
            return 0;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs(Math.PI * (A * A - B * B));
                break;
            case 2:
                answer = (Math.Sqrt(B * B - (0.5 * A) * (0.5 * A)) * A) / 2;
                break;
            default: return 0;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0, x = 0;
        int n = 0;

        // code here
        do
        {
            x = double.Parse(Console.ReadLine());
            if (x == 666)
                break;
            answer += x;
            n += 1;
        } while (x != 666);
        answer /= n;
        Console.WriteLine(answer);
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

        // end

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0;

        // code here
        while (true)
        {
            string k1 = Console.ReadLine();
            if (string.IsNullOrEmpty(k1))
                break;
            string k2 = Console.ReadLine();
            if (string.IsNullOrEmpty(k2))
                break;
            double x = Convert.ToDouble(k1);
            double y = Convert.ToDouble(k2);
            double distance = Math.Sqrt(x * x + y * y);
            if (distance >= r1 && distance <= r2)
                answer++;
        }
        Console.WriteLine(answer);
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

        // end

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0;

        // code here
        while (true)
        {
            string k1 = Console.ReadLine();
            if (string.IsNullOrEmpty(k1))
                break;
            string k2 = Console.ReadLine();
            if (string.IsNullOrEmpty(k2))
                break;
            double x = Convert.ToDouble(k1);
            double y = Convert.ToDouble(k2);
            if (x > 0 && y > 0)
                answer1++;
            else if (x < 0 && y < 0)
                answer3++;
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
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

        // end

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0;

        // code here;
        while (true)
        {
            string k1 = Console.ReadLine();
            if (string.IsNullOrEmpty(k1))
                break;
            string k2 = Console.ReadLine();
            if (string.IsNullOrEmpty(k2))
                break;
            string k3 = Console.ReadLine();
            if (string.IsNullOrEmpty(k3))
                break;
            string k4 = Console.ReadLine();
            if (string.IsNullOrEmpty(k4))
                break;
            double m1 = Convert.ToDouble(k1);
            double m2 = Convert.ToDouble(k2);
            double m3 = Convert.ToDouble(k1);
            double m4 = Convert.ToDouble(k2);
            if ((m1 > 3) && (m2 > 3) && (m3 > 3) && (m4 > 3))
                answer++;
        }
        Console.WriteLine(answer);
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