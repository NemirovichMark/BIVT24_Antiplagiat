using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        program.Task_2_7(5);
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
        if (x*x+y*y==4)
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && y + Math.Abs(x) <= 1)
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
                if (a<b)
                    answer = b;

            }
            else
            {
                if (a < b)
                    answer = a;
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
        if (a<b)
            {
                if (a>c)
                answer = a;
                if (a<c)
                answer = c;
            }
        else
        {
            if (b > c)
                answer = b;
            if (b < c)
                answer = c;
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (Math.Sqrt(2*s)/2 <= Math.Sqrt(r/Math.PI))
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
        if (2*Math.Sqrt(r / Math.PI) <= Math.Sqrt(s))
            answer = true;
        else
            answer = false;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x)>1)
            answer = 1;
        if (Math.Abs(x) <= 1)
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
        if (Math.Abs(x) < 1)
            answer = x*x-1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 0;
        if (x>-1 && x<=0)
            answer = 1+x;
        if (x > 0)
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
        if (x >-1 && x <= 1)
            answer = -x;
        if (x > 1)
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
        int i = 0;
        double s = 0, rost;
        while (i <= n)
        {
            i = i + 1;
            double.TryParse(Console.ReadLine(), out rost);
            s = s + rost;
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
        double x, y;
        int i = 1, k=0;
        while (i <= n)
        {
            
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
                k = k + 1;
             i = i + 1;
        }
        answer = k;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        int i = 0;
        double x, m=0;
        while (i <= n)
        {
            i = i + 1;
            double.TryParse(Console.ReadLine(), out x);
            if (x<30 && x>0)
                m = m + 200;
        }
        answer = m/1000;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x, y;
        int i = 1, k = 0;
        while (i <= n)
        {

            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x*x + y*y <= r2 * r2 && x * x + y * y >= r1 * r1)
                k = k + 1;
            i = i + 1;
        }
        answer = k;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double t;
        int i = 1, k = 0;
        while (i <= n)
        {

            double.TryParse(Console.ReadLine(), out t);
            if (t<=norm)
                k = k + 1;
            i = i + 1;
        }
        answer = k;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x, y;
        int i = 1, k = 0;
        while (i <= n)
        {

            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x>=0 && x<Math.PI && Math.Sin (x)>y && y>0)
                k = k + 1;
            i = i + 1;
        }
        answer = k;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        double x, y;
        int i = 1, k = 0;
        while (i <= n)
        {

            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x>0 && y>0)
            {
                Console.WriteLine("1 квадрант");
                answer1 = answer1 + 1;
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("2 квадрант");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("3 квадрант");
                answer3 = answer3 + 1;
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("4 квадрант");
            }
            i = i + 1;
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
        double x, y;
        int i = 1;
        while (i <= n)
        {

            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (Math.Sqrt(x * x + y * y) <= answerLength)
            {
                answerLength = Math.Round(Math.Sqrt(x * x + y * y), 2);
                answer = i;
            }
            i = i + 1;
        }
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double t;
        int i = 1;
        while (i <= n)
        {

            double.TryParse(Console.ReadLine(), out t);
            if (t <= answer)
                answer=t;
            i = i + 1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here
        int x1, x2, x3, x4;
        int i = 1, k = 0;
        while (i <= n)
        {

            int.TryParse(Console.ReadLine(), out x1);
            int.TryParse(Console.ReadLine(), out x2);
            int.TryParse(Console.ReadLine(), out x3);
            int.TryParse(Console.ReadLine(), out x4);
            if (x1!=2 && x1!=3 && x2 != 2 && x2 != 3 && x3 != 2 && x3 != 3 && x4 != 2 && x4 != 3)
                k = k + 1;
            i = i + 1;
        }
        answer = k;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        int x1, x2, x3, x4;
        int i = 1, k = 0;
        double s = 0;
        while (i <= n)
        {

            int.TryParse(Console.ReadLine(), out x1);
            int.TryParse(Console.ReadLine(), out x2);
            int.TryParse(Console.ReadLine(), out x3);
            int.TryParse(Console.ReadLine(), out x4);
            if (x1 == 2 || x2 == 2 || x3 == 2 || x4 == 2)
                k = k + 1;
            i = i + 1;
            s = s + x1 + x2 + x3 + x4;
        }
        answer = k;
        avg = s / n / 4;
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here
        if (r <= 0)
            answer = 0;
        else
        {
            switch (type)
            {
                case 0:
                    answer = r * r;
                    Console.WriteLine("Площадь квадрата ", Math.Round(answer, 2));
                    break;
                case 1:
                    answer = Math.PI * r * r;
                    Console.WriteLine("Площадь круга ", Math.Round(answer, 2));
                    break;
                case 2:
                    answer = r * r * Math.Sqrt(3) / 4;
                    Console.WriteLine("Площадь равностороннего треугольника ", Math.Round(answer, 2));
                    break;
                default:
                    answer = 0;
                    Console.WriteLine(answer);
                    break;
            }
            answer = Math.Round(answer, 2);
        }
            
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here
        double p = 0;
        if (A <= 0 || B<=0)
            answer = 0;
        else
        {
            switch (type)
            {
                case 0:
                    answer = A * B;
                    Console.WriteLine("Площадь прямоугольника ", Math.Round(answer, 2));
                    break;
                case 1:
                    answer =Math.Abs( Math.PI * A * A - Math.PI * B * B);
                    Console.WriteLine("Площадь кольца ", Math.Round(answer, 2));
                    break;
                case 2:
                    if (B+B>A && A+B>B)
                    {
                        p = (A + B + B) / 2;
                        answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B));
                        Console.WriteLine("Площадь равнобедренного треугольника ", Math.Round(answer, 2));
                    }
                    else answer = 0;
                    break;
                default:
                    answer = 0;
                    Console.WriteLine(answer);
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
        int i = 0;
        double x, m = 0;
        for (; ;n=n+1)
        {
            i = i + 1;
            double.TryParse(Console.ReadLine(), out x);
            if (x < 0) break;
            if (x < 30 && x > 0)
                m = m + 200;
        }
        answer = m / 1000;
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
        double x, y;
        int i = 1, k = 0;
        for (; ; n = n + 1)
        {

            double.TryParse(Console.ReadLine(), out x);
            if (x == 1000) break;
            double.TryParse(Console.ReadLine(), out y);
            if (x >= 0 && x < Math.PI && Math.Sin(x) > y)
                k = k + 1;
            i = i + 1;
        }
        answer = k;
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
        double t;
        int i = 1;
        for (; ; n = n + 1)
        {

            double.TryParse(Console.ReadLine(), out t);
                if (t<0) break;
            if (t <= answer)
                answer = t;
            i = i + 1;
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