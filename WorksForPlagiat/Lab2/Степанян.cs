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
        program.Task_1_1(0.9, 1.23);
        program.Task_1_2(0.9, 1.23);
        program.Task_1_3(0.9, 1.23);
        program.Task_1_4(0.9, 1.23, -0.1);
        program.Task_1_5(0.9, 1.23);
        program.Task_1_6(0.9, 1.23);
        program.Task_1_7(0.9);
        program.Task_1_8(0.9);
        program.Task_1_9(0.9);
        program.Task_1_10(0.9);
        program.Task_2_1(10);
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
        if ((Math.Abs((x*x) + (y*y) - (r*r))) <= (1/1000))
        {
            answer = true;
        }
        // code here

        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        if ((y >= 0) & ((Math.Abs(x) + y) <= 1) ){ 
            answer = true;
        }


        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        double mi = 0;
        double ma = 0;
        if (a > b)
        {
            ma = a;
            mi = b;
        }
        else
        {
            ma = b;
            mi = a;
        }
        if (a > 0)
        {
            answer = ma;
        }
        else
        {
            answer = mi;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        double mi, ma;
        if (a < b)
        {
            mi = a;

        }
        else
        {
            mi = b;
        }
        if (mi < c)
        {
            ma = c;

        }
        else
        {
            ma = mi;
        }
        // code here
        answer = ma;

        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double core = Math.Pow(2, 0.5);
        double rs = Math.Pow(s, 0.5) / core;
        double p = Math.PI;
        r = Math.Pow(r / p, 0.5);
        if (rs <= r)
        {
            answer = true;
        }

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        double core = Math.Pow(2, 0.5);
        double rs = Math.Pow(s, 0.5) / core;
        double p = Math.PI;
        r = Math.Pow(r / p, 0.5);
        rs = rs / core;
        if (rs >= r)
        {
            answer = true;
        }

        return answer;

    }
    public double Task_1_7(double x)
    {
        double answer = 0;
        double xabs = Math.Abs(x);
        if (xabs > 1)
        {
            answer = 1;
        }
        else
        {
            answer = xabs;
        }
        // code here

        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;
        double xabs = Math.Abs(x);
        // code here
        if (xabs >= 1)
        {
            answer = 0;
        }
        else
        {
            answer = xabs * xabs - 1;
        }
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;
        double y = 0;
        if (x <= -1)
        {
            y = 0;
        }
         if (x > 0)
        {
            y = 1;
        }
        if ((x > -1) && (x <= 0))
        {
            y = 1 + x;
        }
        // code here
        answer = y;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
        {
            answer = 1;
        }
        if ( x > 1)
        {
            answer = -1;
        }
        else
        {
            answer = -x;
        }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        string r;
        for (int i = 0; i < n; i++)
        {
            r = Console.ReadLine();
            Console.ReadKey();
            answer = answer + Convert.ToDouble(r);
           
        }
        // code here
        answer /= n;
        // end
        Console.WriteLine(answer);
        
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here

        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here

        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;

        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;

        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;

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