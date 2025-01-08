﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Xml.Linq;

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
        //program.Task_1_6(4);
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
        program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        int i;
        for (i = 2; i <= 35; i = i + 3)
            answer = answer + i;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        
        for (double i = 1; i <= 10; i = i + 1)
            answer = answer + 1/i;
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i <= 113; i = i + 2)
            answer = answer + i/ (i+1);
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
        if (x == 0)
        { answer = 0; }
        else
        {
            for (double i = 1; i <= 9; i = i + 1)
            {
                answer = answer + Math.Cos(x * i) / znam;
                znam *= x;
            }   
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
        for (double i = 1; i <= 10; i = i + 1)
            answer = answer + (p + h*(i-1))* (p + h * (i - 1));
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Round((0.5 * x * x - 7 * x), 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i = 1; i <= 6; i++)
        {
            answer = answer * i;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int fact = 1;
        for (int i = 1; i <= 6; i++)
        {
            answer = answer + fact;
            fact *= i + 1;
            
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double x = -5, fact = 1;
        for (int i = 1;i <= 6; i++)
        {
            answer = answer + x/fact;
            x = x * (-5);
            fact *= i + 1;
            
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for (int i = 1; i <= 7; i++)
        {
            answer = answer * 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for(int i = 1; i <=6; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine(" ");
        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine("5");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0)
        {
            answer = 0;
        }
        else
        {
            double znam = 1;
            
            for (int i = 1; i <= 11; i++)
            {
                answer += 1 / znam;
                znam *= x;
            }
            answer = Math.Round(answer, 2);
        }
        
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
        { answer = 1; }
        else
            if (x <= 1)
        { answer = -x; }
        else { answer = -1; }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int first = 1, second = 1, next;
        Console.Write($"{first} {second} ");
        for (int i = 0; i <=5; i++)
        {
            next = first + second;
            first = second;
            second = next;
            Console.Write($"{next} ");
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double ch = 1, zn = 1, x = 0;
        for (int i = 1; i < 5; i++)
        {
            x = ch;
            ch += zn;
            zn = x;
        }
        answer = Math.Round((ch / zn), 2);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double zerno = 1, x = 1;
        
        for (int i = 0; i < 64; i++)
        {
            if (answer > x * 10)
            { x *= 10; power += 1; }
            answer += zerno;
            zerno *= 2;
            
        }
        answer /= x*15;
        answer = Math.Round(answer, 2);

        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        answer = (R + x) * (R + x) - R * R;
        answer = Math.Round((Math.Sqrt(answer)), 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = 10;
        for (int i = 3; i <= x; i += 3)
        { answer *= 2; }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        int i = 1;
        double n = 1, e = 0.0001;
        while (Math.Abs(n) >= e)
        {
            n = Math.Cos(i * x) / (i * i);
            if (Math.Abs(n) >= e)
            { answer += n; }
            i += 1;
        }
        
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
        double s = a;
        int n = 0;
        if (h > 0)
        {
            
            while (s <= p)
            {
                n++;
                s += a + n * h;
            }
        }
        answer = n;
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
        if (M != 0)
        {
            while (Math.Abs(N) >= Math.Abs(M))
            {
                N -= M;
                quotient++;
            }
            remainder = N;
        }
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
        double way = 10, day = 10;
        for (int i = 2; i <= 7; i++)
        {
            day *= 1.1;
            way += day;
        }
        answer = Math.Round(way, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double way = 10, day = 10;
        int n = 1;
        while (way <= 100)
        {
            day *= 1.1;
            way += day;
            n++;
        }
        answer = n;
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double day = 10;
        int n = 1;
        while (day <= 20)
        {
            n++;
            day *= 1.1;
        }
        answer = n-1;
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
        double l = 0.1;
        while (l >= 1e-10)
        {
            l /= 2;
            answer ++;
        }
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
        double a = 1;

        for (int i = 0; Math.Abs(a) >= 0.0001; ++i)
        {
            S += a;

            a *= (x * x) / ((2 * i + 1) * (2 * i + 2));
        }

        y = (Math.Exp(x) + Math.Exp(-x)) / 2;

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