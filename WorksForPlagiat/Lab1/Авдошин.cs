﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

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
        program.Task_1_7();
        program.Task_1_8();
        program.Task_1_9();
        program.Task_1_10();
        program.Task_1_11();
        program.Task_1_12(0.9);
        program.Task_1_13(-1.5);
        program.Task_1_14();
        program.Task_1_15();
        program.Task_1_16();
        program.Task_1_17(10);
        program.Task_1_18(24);
        program.Task_2_1(0);
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
        for(int s = 2;s<=35;s+=3)
            answer=answer+s;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double t = 0;
        for(int n = 1;n<=10;n++)
            {
                double s = 1.0/n;
                t = t + s;
            }
        answer = Math.Round(t, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i <= 112; i += 2)
        {
            answer += i / (i + 1);
        }
        // end

        return Math.Round(answer, 0);
    }
    public double Task_1_4(double x)
    {
         double answer = 0;
        if (x == 0)
        {
            return 0;
        }
        // code here
        double n = 1;
        for (int i = 1; i <= 9; i++)
        {
            answer += Math.Cos(x * i) / n;
            n *= x;
        }
        // end

        return Math.Round(answer, 2);
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;
        double s = 0;

        // code here
        for (int i = 0; i <= 9; i++)
        {
            s = p + (h * i);
            answer += s * s;
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
         double answer = 0;

        // code here
        for (double i = -4; i <= 4; i += 0.5)
        {
            answer = 0.5 * x * x - 7 * x;
        }
        // end

        return Math.Round(answer, 2);
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i = 1; i <= 6; i++)
        {
            answer *= i;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        int a = 1;
        // code here;
        for (int i = 1; i <= 6; i++)
        {
            a = a * i;
            answer += a;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double zn = 1, ch = 1;
        // code here;
        for (int i = 1; i <= 6; i++)
        {
            ch *= -1 * 5;

            zn = zn * i;

            answer = answer + ch / zn;
        }
        // end

        return Math.Round(answer, 2);
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for (int i = 1; i <= 7; i++)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        // code here
        Console.WriteLine("1 2 3 4 5 6");
        Console.WriteLine("5 5 5 5 5 5");
    }
    public double Task_1_12(double x)
    {
        double answer = 1;
        double st = 1;
        if (x == 0)
        {
            return 0;
        }
        // code here
        for (int i = 0; i < 10; i++)
        {
            st = st * x;
            answer = answer + (1 / st);
        }
        // end

        return Math.Round(answer, 2);
    }
    public double Task_1_13(double x)
    {
       double answer = 0;

        // code here
            if (x <= -1)
            {
                return 1;
            }

            if (x <= 1 && x >= -1)
            {
                return -x;
            }
            if (x > 1)
            {
                return -1;
            }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        // code here
        int n1 = 1, n2 = 1, n3 = 0;
        Console.Write(n1 + " ");
        Console.Write(n2 + " ");
        for (int i = 1; i <= 6; i++)
        {
            n3 = n1 + n2;
            Console.Write(n3 + " ");
            n1 = n2;
            n2 = n3;
        }
        Console.WriteLine();
    }
    public double Task_1_15()
    {
       double answer = 0;
        // code here
        double ch1 = 1, zn1 = 1, ch2, zn2;
        for (int i = 1; i <= 4; i++)
        {
            zn2 = ch1;
            ch2 = ch1 + zn1;
            answer = ch2 / zn2;
            ch1 = ch2;
            zn1 = zn2;
        }
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 1;
        int power = 0;

        // code here
        for (int i = 1; i <= 64; i++)
        {
            answer *= 2;
        }
        // end
        answer = answer / 15;
        power = 18;
        answer = answer / Math.Pow(10, power);
        answer = Math.Round(answer, 2);
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        double R = 6350;
        // code here
        answer = Math.Sqrt((R + x) * (R + x) - R * R);
        // end

        return Math.Round(answer, 2);
    }
    public int Task_1_18(int x)
    {
         int answer = 10;

        // code here
        for (int i = 1; i <= x; i += 3)
        {
            answer *= 2;
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
        double e = 0.0001, cs;
        int n = 1;
        for (int j = 1; j <= Math.Pow(10,10);j ++)
        {        
            cs = Math.Cos(n * x) / (n*n);            
            n++;            
            if (Math.Abs(cs) < e) break;
            answer += cs;
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
        double s = 0;
        if (a > p) return 0;
        while (s <= p)
        {
            answer++;
            s += a + answer * h;
            if (s < 0) return 0;
        }
         //end

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
        N = Math.Abs(N);
        M = Math.Abs(M);
        if (M == 0) return (0,0);
        remainder = N;
        while (remainder >= M)
        {
            remainder -= M;
            quotient++;
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
        int c = 1;
        answer += 10;
        double b = 10;
        double pr;
        while (c <= 6)
        {
            pr = (b / 100) * 10;
            b = b + pr;
            answer += b;
            c++;
        }
        // end

        return Math.Round(answer,2);
    }
    public int Task_2_7b()
    {
        int answer = 0;

        //code here
        answer = 1;
        double b = 10;
        double pr;
        double sum = 10;
        while (sum <= 100)
        {
            pr = (b / 100) * 10;
            b = b + pr;
            sum += b;
            answer++;
        }
        //end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double b = 10;
        double pr ;
        double sum = 10;
        while (b <= 20)
        {
            pr = (b / 100) * 10;
            b = b + pr;
            sum += b;
            answer++;
        }
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
        double atom = 1;
        for (int i = 0; i < 10; i++)
        {
            atom *= 1.0 / 10;
        }
        double nit = 0.1;
        while (nit >= atom)
        {
            nit = nit / 2;
            answer++;
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
         double a =1,s = 0,y = Math.Cos(x);
        int i = 1;
        // code here
       // for( x = a; x <= b; x+=h)
     //   {
          while(Math.Abs(a) >= 0.0001)
          {
            s += a;
            a *= -x*x/(2*i*(2*i-1));
            i++;
          }  
    //    }
        // end

        return (s, y);
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