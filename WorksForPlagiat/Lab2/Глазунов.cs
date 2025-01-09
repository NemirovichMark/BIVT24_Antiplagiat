using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.IO;
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
        //program.Task_2_5(6, 25.2);
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
        if (Math.Abs(x*x+y*y-r*r) <= Math.Pow(10, -3))
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
        if (y >= 0 && y+Math.Abs(x)<=1)
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
        if (a > 0){
            if (a > b) answer = a;
            else answer = b;
        }
        else
        {
            if (a < b) answer = a;
            else answer = b;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        answer = a;
        if (b<a) answer = b;
        if (c > answer) answer = c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double smax = 2 * (r / Math.PI);
        if (s<=smax)
        {
            answer = true; 
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double rmax = 2 * Math.Sqrt((r / Math.PI));
        double smax = Math.Sqrt(s);
        if (rmax<=smax) 
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
        answer = Math.Abs(x);
        if (Math.Abs(x) > 1) answer = 1;
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        answer = x * x - 1;
        if (Math.Abs(x) >= 1) answer = 0;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        answer = 1 + x;
        if (x>0) answer = 1;
        if (x<=-1) answer = 0;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        answer =  -x;
        if (x <= -1) answer = 1;
        if (x >1) answer = -1;
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
        for (int i = 0; i < n; i++)
        {
            double k = double.Parse(Console.ReadLine());
            s += k;
        }
        answer = s / n;
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
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r) answer++;
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
            double x = double.Parse((Console.ReadLine()));
            if (x < 30) answer += 0.2;
        }
        Console.WriteLine(answer);
            // end

            return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x * x+ y * y <= r2 * r2 && x * x + y * y >= r1 * r1) answer++;
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
            double x = double.Parse(Console.ReadLine());
            if (x <= norm) answer++;
        }
        Console.WriteLine(answer);
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
            if (x >= 0  && y <= Math.Sin(x) && x <= Math.PI) answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        int k = 0;
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
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        // end

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
            if (answerLength > Math.Sqrt((a*a)+(b*b)))
            {
                answerLength = Math.Sqrt((a*a)+(b*b));
                answer = i+1;
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
        double a;
        for (int i = 0; i<n; i++)
        {
            a = double.Parse(Console.ReadLine());
            if (a < answer)
            {
                answer = a;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 0; i < n; i++)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            if (a > 3 && b > 3 && c > 3 && d > 3)
            {
                answer += 1;
            }
            Console.WriteLine(answer);

        }
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

            // code here;
            answer = n;
            for (int i = 0; i < n; i++)
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                double d = double.Parse(Console.ReadLine());
                if (a > 2 && b > 2 && c > 2 && d > 2)
                {
                    answer -= 1;
                }
                avg += a + b + c + d;
            }
            Console.WriteLine(answer);
            Console.WriteLine(avg / (n*4));
            // end

            return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r <= 0) return 0;
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
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
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
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs(Math.PI * ((A * A) - (B * B)));
                break;
            case 2:
                answer = Math.Sqrt(B * B - (A * A / 4)) * 0.5 * A;
                break;
        }
        answer = Math.Round(answer, 2);
        System.Console.WriteLine(answer);
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
        string k;
        double x;
        Console.WriteLine("Напишите G, чтобы остановить программу.");
        while (true) 
        {
            k = Console.ReadLine();
            if (k == "G") break;
            x = double.Parse(k);
            if (x < 30) answer += 0.2;
        }
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
        string k;
        double x, y ;
        Console.WriteLine("Напишите G, чтобы остановить программу.");
        while (true)
        {
            k = Console.ReadLine();
            if (k == "G") break;
            x = double.Parse(k);
            k = Console.ReadLine();
            if (k == "G") break;
            y = double.Parse(k);
            if (x >= 0 && y <= Math.Sin(x) && x <= Math.PI) answer++;
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
        double a;
        string k;
        Console.WriteLine("Напишите G, чтобы остановить программу.");
        while (true)
        {
            k = Console.ReadLine();
            if (k == "G") break;
            a = double.Parse(k);
            if (a < answer)
            {
                answer = a;
            }
        }
        Console.WriteLine(answer);
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