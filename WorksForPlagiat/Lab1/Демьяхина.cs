﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        program.Task_1_1();
        program.Task_1_2();
        program.Task_1_3();
        program.Task_1_4(0.9);
        program.Task_1_5(0, 2);
        program.Task_1_6(4);
        //program.Task_1_7();
        //program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        //program.Task_1_11();
        //program.Task_1_12(0.9);
        //program.Task_1_13(-1.5);
        //program.Task_1_14();
        //program.Task_1_15();
        //program.Task_1_16();
        //program.Task_1_17(10);
        //program.Task_1_18(24);
        //program.Task_2_1(0);
        //program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        //program.Task_2_4(0.8);
        //program.Task_2_5(11, 5);
        //program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        //program.Task_2_8();
        //program.Task_2_9();
        //program.Task_2_10();
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        //program.Task_3_3(0.1);
        //program.Task_3_4(0.1);
        //program.Task_3_5(double.Pi/5);
        //program.Task_3_6(0.1);
        //program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        int i, s = 0;
        for (i = 2; i <= 35; i = i + 3)
            s = s + i;
        answer = s;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double s = 0;
        for (double i=1; i<=10; i=i+1)
            s = s + 1.0/i;
        answer = (Math.Round(s,3));
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double s = 0;
        for (double i = 2; i <= 112; i = i + 2)
            s = s + i / (i + 1.0);
        answer = (Math.Round(s,3));
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double s = Math.Cos(x);
        double x1 = 1;
        if (x == 0) return 0;
        if (x != 0)
        {
            for (int i = 2; i <= 9; i++)
            {
                x1 = x1 * x;
                s = s + Math.Cos(x * i) / x1;
            }
            if (s >= 0) answer = (Math.Round(s, 4));
            if (s < 0) answer = (-1 * Math.Round(Math.Abs(s), 4));
        }
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double s = 0;
        for (int i = 0; i<=9; i++)
        {
            s = s + (p + i * h) * (p + i * h);
        }
        answer = (Math.Round(s,3));
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here   
        double y = 0;
        for (x = -4; x <= 4; x = x + 0.5)
            {
            y = (0.5 * x * x) + (7.0 * x);
            answer = y;
            return answer;
            }
        // end

       
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;

        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here

        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_3(double a, double h, double p)
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public double Task_2_4(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public (int, int) Task_2_5(int N, int M)
    {
        int quotient = 0, remainder = 0;

        // code here

        // end

        return (quotient, remainder);
    }
    public int Task_2_6()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public double Task_2_7a()
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_8()
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    public int Task_2_9()
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    public int Task_2_10()
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    #endregion

    #region Level 3
    public (double, double) Task_3_1(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_2(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_3(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_4(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_5(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_6(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_7(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_8(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_9(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    #endregion
}