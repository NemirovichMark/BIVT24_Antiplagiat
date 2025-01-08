﻿using Microsoft.Win32.SafeHandles;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using System.Xml;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        //program.Task_1_1();
        //program.Task_1_2();
        //program.Task_1_3();
        //program.Task_1_4(0.9);
        //program.Task_1_5(0, 2);
        //for(double x = -4; x <= 4; x += 0.5)
        //{
        //    Console.WriteLine(program.Task_1_6(x));
        //}
        //program.Task_1_6(4);
        //program.Task_1_7();
        //program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        program.Task_1_11();
        //program.Task_1_12(0.9);
        //for(double x = -1.5; x <= 1.5; x += 0.1)
        //{
        //    Console.WriteLine(program.Task_1_13(x));
        //}
        //program.Task_1_13(-1.5);
        //program.Task_1_14();
        //program.Task_1_15();
        program.Task_1_16();
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
        //for (double x = 0.1; x <= 0.8001; x += 0.1)
        //{
        //    Console.WriteLine(program.Task_3_2(x));
        //}
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
        int x = 2;
        while (x <= 35)
        {
            answer += x;
            x += 3;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double x = 1;
        double a = 1;
        while (a <= 10)
        {
            answer += x / a;
            a += 1;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double x = 2;
        double a = 3;
        while (x <= 112 && a <= 113)
        {
            answer += x / a;
            x += 2;
            a += 2;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double znam = 1;
        for (double k = 1; k <= 9; k++)
        {
            if (x == 0)
            {
                answer = 0;
                break;
            }
            answer += Math.Cos(k * x) / znam;
            znam *= x;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (double i = 0; i <= 9; i++)
        {
            answer += (p + i * h) * (p + i * h);
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x * x - 7 * x;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for(int i = 1; i <= 6; i++)
        {
            answer = answer * i;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        int fct = 1;
        // code here;
        for(int i = 1; i <= 6; i++)
        {
            fct *= i;
            answer += fct;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double a = -1*5/1;
        // code here;
        for(int i = 2; i<=7; i++)
        {
            answer += a;
            a = a * (-1) * 5 / i;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        int st = 3;
        for(int i = 1; i <= 7; i++)
        {
            answer *= 3;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for(int i = 1; i <= 6; i++)
        {
            Console.Write(i);
            Console.Write(" ");
        }
        Console.WriteLine();
        for(int a = 1; a <= 6; a++)
        {
            Console.Write("5 ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        double a = 1.0;
        // code here
        for (int i = 0; i <= 10; i++)
        {
            answer += a;
            if (x != 0)
            {
                a = a / x;
            }
            else
            {
                answer = 0;
                break;
            }
            
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if(x <= -1)
        {
            answer = 1;
        }
        if(-1 < x && x <= 1)
        {
            answer = -x;
        }
        if(x > 1)
        {
            answer = -1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int ch1 = 1;
        int ch2 = 1;
        for(int i = 0; i < 4; i++)
        {
            Console.WriteLine(ch1);
            Console.WriteLine(ch2);
            ch1 = ch1 + ch2;
            ch2 = ch1 + ch2;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double ch1 = 1;
        double zn1 = 1;
        double ch2 = 2;
        double zn2 = 1;
        for(int i = 0; i < 3 ; i++)
        {
            double tch = ch1 + ch2;
            double tzn = zn1 + zn2;
            answer = tch / tzn;
            ch1 = ch2;
            zn1 = zn2;
            ch2 = tch;
            zn2 = tzn;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        double zern = 1;
        double t = 1;
        for (int i = 0; i < 64; i++)
        {
            if (answer > t * 10)
            {
                t *= 10;
                power += 1;
            }
            answer += zern;
            zern *= 2;
        }
        answer = answer / (t * 15);
        answer = Math.Round(answer, 2);
        // code here

        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        double r = 6350;
        // code here
        for(double i = 1; i <= x; i++)
        {
            answer = Math.Round(Math.Sqrt(i * (2 * r + i)), 2);
        }
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        for (int i = 3; i <= x; i += 3)
        {
            answer *= 2;
            Console.WriteLine(answer);
        }
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
        int p = 1;
        int n = 1;
        // code here
        while(p <= 30000)
        {
            answer = n;
            n += 3;
            p *= n;
            
        }
        Console.WriteLine(answer);
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
        double start = 1;
        // code here
        while(start >= 0.0001)
        {
            answer += start;
            start *= x * x;
            if(Math.Abs(x)>=1)
            {
                answer = 0;
                break;
            }
        }
        answer = Math.Round(answer, 2);
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
        int kletki = 10;
        // code here
        while(kletki <= Math.Pow(10, 5))
        {
            answer += 3;
            kletki *= 2;
        }
        Console.WriteLine(answer);
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
        double s = 10000;
        // code here;
        do
        {
            answer += 1;
            s *= 1.08;
        } while (s <= 20000);
        Console.WriteLine(answer);
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
        int answer = 2;
        double ch1 = 1;
        double ch2 = 2;
        double zn1 = 1; 
        double zn2 = 1;
        // code here;
        while(Math.Abs((ch2 / zn2) - (ch1 / zn1)) > 0.001)
        {
            double tch = ch2 + ch1;
            double tzn = zn2 + zn1;
            answer += 1;
            zn1 = zn2;
            ch1 = ch2;
            zn2 = tzn;
            ch2 = tch;
        }
        Console.WriteLine(answer);
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
        double tch = 1;
        double mn1 = x;
        int i = 1;
        // code here
        while(Math.Abs(mn1) >= 0.0001)
        {
            tch = mn1 * Math.Sin(i * Math.PI / 4);
            S += tch;
            mn1 *= x;
            i++;
            
        }
        y =(x * Math.Sin(Math.PI / 4)) / (1 - 2 * x * Math.Cos(Math.PI / 4) + x * x);
        Console.WriteLine(S);
        Console.WriteLine(y);

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