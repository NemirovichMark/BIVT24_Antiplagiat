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
        

        if (Math.Abs(x * x + y * y - 4) <= 1/10*10*10) { answer = true; }

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code 
        if ( (y >= 0) && (y + Math.Abs(x) <= 1)) { answer = true; }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double c = 0;

        // code here
        
        if (a > 0)
        {
            if (a >= b) { c = a; }
            else { c = b; }
        }
        
        else if ( a <= 0)
        {
            if (a >= b) { c = b; }
            else
            {
                c = a;
            }
        }
        
        // end

        return c;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double z = 0;

        // code here
        if (a >= b)
        {
            if (b >= c)
            {
                z = b;
            }
            else { z = c; }
        } 
        else if ( b >= a)
        {
            if (a >= c) { z = a; }
            else { z = c; }
        }
        // end

        return z;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double diam_cir = Math.Sqrt(r * 4 / Math.PI);
        double diag_kv = Math.Sqrt(2*s);
        if (diam_cir >= diag_kv) { answer = true; }
        else {answer = false; }

        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double diam_cir = Math.Sqrt(r * 4 / Math.PI);
        double a = Math.Sqrt(s);
        if ( diam_cir < a ) { answer = true; }
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1) { answer = 1; } else { answer = Math.Abs(x); }
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1) { answer = 0; } else { answer = x*x - 1; }
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) { answer = 0; } 
        else if ( -1 < x && x <= 0) { answer = x + 1; }
        else if ( x > 0) {  answer = 1; }

        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) { answer = 1; }
        else if (-1 < x && x <= 1) { answer = -1*x; }
        else if (x > 1) { answer = -1; }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double length_class = 0;
        for (int i = 0; i < n; i++)
        {
            double length_per = double.Parse(Console.ReadLine());
            length_class += length_per;
        }
        answer = length_class / n;
        //end

        return answer;
    }
    public int Task_2_2(int n, double r, double x, double y)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double x_1 = double.Parse(Console.ReadLine());
            double y1 =  double.Parse(Console.ReadLine());
            if ((x - x_1)*(x - x_1) + (y - y1)*(y - y1) <= r*r) {answer++;}
        }
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        const double milk = 200;
        double amount_milk = 0;
        for (int i = 0; i < n; i++)
        {
            double weight = double.Parse(Console.ReadLine());
            if ( weight < 30)
            {
                amount_milk += milk;
            }
        }
        // end
        answer = amount_milk / 1000;
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
            if (((x * x) + (y * y) >= r1 * r1) && ((x * x) + (y * y) <= r2 * r2)) { answer++; }
                
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
            double running = double.Parse(Console.ReadLine()); 
            if (running <= norm) { answer++; }
        }
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
            if ((x >= 0) && (x <= Math.PI) && (y >= 0) && ( y <= Math.Sin(x))) { answer++; }
        }
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for(int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
            if (x >= 0)
            {
                if (y >= 0) { answer1++; }
            }
            else
            {
                if (y < 0) { answer3++; }
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
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
            if (Math.Sqrt(x * x + y * y) < answerLength)
            {
                answer = i;
                answerLength = Math.Sqrt(x * x + y * y);
            }
        }
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 0; i < n; i++)
        {
            double swim = double.Parse(Console.ReadLine());
            if ( swim <  answer )
            {
                answer = swim;
            }
        }
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 0; i < n; i++)
        {
            int good = 1;
            for (int j = 0; j < 4; j++)
            {
                double mark = double.Parse(Console.ReadLine());
                if (mark == 2 || mark == 3)
                {
                    good = 0;
                }
            }
            answer += good;
        }
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        double sum_st = 0;

        // code here;
        for (int i = 0; i < n; i++)
        {
            int neud = 0;
            for (int j = 0; i < 4; j++) {
                double mark = double.Parse((Console.ReadLine()));
                sum_st += mark;
                if (mark == 2) { neud = 1; }
            }
            answer += neud;
        }
        avg = sum_st / (n*4);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if ( r <= 0) { return 0; }
        switch (type)
        {
            case 0:
                answer =  r * r;
                break;
            case 1:
                answer =  r * r * Math.PI;
                break;
            case 2:
                answer =  Math.Sqrt(3) * r * r / 4;
                break;
        }
        // end

        return Math.Round(answer,2);
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A <= 0 || B <= 0) { return 0; }
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                if (A > B)
                {
                    return 0;
                }
                answer = Math.PI * (B * B - A * A);
                break;
            case 2:
                answer = Math.Sqrt(B * B - A * A / 4) * A / 2;
                break;
        }
        // end

        return Math.Round(answer,2);
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
        double milk = 0;
        // code here
        for ( int i = 0; i < int.MaxValue; i++)
        {
            double weight = double.Parse(Console.ReadLine());
            if (weight < 0) { break; }
            else if (weight > 0 && weight < 30) { milk += 200;}
        }
        // end
        answer = milk / 1000;
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
        int answer = 0;

        // code here
        for (int i = 0; i < int.MaxValue; i++) {
            string x_1 = Console.ReadLine(), y_1 = Console.ReadLine();
            if (x_1 == "zero" || y_1 == "zero") { break; }
            double x_2 = double.Parse(x_1), y_2 = double.Parse(y_1);
            if (x_2 >= 0 && x_2 <= Math.PI && y_2 <= Math.Sin(x_2)) {answer++;}
        }
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
        for ( int i = 0; i < int.MaxValue; i++)
        {
            string res = Console.ReadLine();
            if (res == "no results") { break; }
            double true_res = double.Parse(res);
            if ( true_res < answer) { answer = true_res; }
        }

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
