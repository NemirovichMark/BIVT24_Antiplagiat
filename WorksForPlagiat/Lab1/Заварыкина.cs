﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
// dotnet test --filter Tests.ProgramTests.Task_1_1Test
public class Program
{
    public static void Main()
    {
        Program program = new Program();

        //program.Task_1_1();
        //program.Task_1_2();
        // program.Task_1_3();
        // program.Task_1_4(0.5);
        // program.Task_1_5(0, 2);
        // program.Task_1_6(-3.5);
        //program.Task_1_7();
        // program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        //program.Task_1_11();
        //program.Task_1_12(0.9);
        //program.Task_1_13(-1.5);
        // program.Task_1_14();
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
        // program.Task_2_10();
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        //program.Task_3_3(0.1);
        // program.Task_3_4(0.1);
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
        for (int i=2; i<36; i+=3)
        {
            answer += i;
        }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;
        // code here
        for (int i=1; i<11; i++)
        {
            answer += 1.0/i;
        }
        answer = Math.Round(answer, 2);
        // end
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (int i=2, j=3; i<113; i+=2, j+=2)
        {
            answer += (double)i/j;
        }
        answer = Math.Round(answer, 2);
        // end
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        // code here
        double pow = 1;
        for (int i=1; i<10; i++)
        {
            answer += Math.Cos(i*x)/pow;
            pow *= x;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double result = 0;
        for (int i=0; i<10; i++)
        {
            result = p+(h*i);
            result *= result;
            answer += result;
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5*x*x-7*x;
        answer = Math.Round(answer, 2);
        // end
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i=1; i<=6; i++)
        {
            answer *= i;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int factorial_count = 1;
        for (int i=1; i<=6; i++)
        {
            factorial_count *= i;
            answer += factorial_count;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double five = 5;
        double one = -1;
        double fact = 1;
        for (int i=1; i<7; i++)
        {
            fact *= i;
            answer += one * five / fact;
            one *= -1;
            five *= 5;
        }

        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for (int i=1; i<8; i++)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i=1; i<7; i++)
        {
            Console.WriteLine(i);
        }
        for (int i=1; i<6; i++)
        {
            Console.WriteLine(5);
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        double pow_x = 1;
        // code here
        for (int i=0; i<11; i++)
        {
            answer += 1/pow_x;
            pow_x *= x;
            
        }
        if (Double.IsInfinity(answer))
        {
            answer = 0;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) {
            answer = 1;
        }
        else if (x > 1)
        {
            answer = -1;
        }
        else {
            answer = -x;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int pastNum = 1;
        int pastPastNum = 0;
        for (int i=1; i<8; i++)
        {
            int fbnch = pastNum + pastPastNum;
            pastPastNum = pastNum;
            pastNum = fbnch;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        int num = 1, den = 1;
        for (int i=1; i<5; i++)
        {
            int lstNum = num;
            num += den;
            den = lstNum;
        }
        answer = Math.Round((double) num/den, 2);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double mainNumOfCorn = 0; // в граммах
        double numOfCorn = 1; // dotnet test --filter Tests.ProgramTests.Task_1_16Test
        for (int i=1; i<65; i++)
        {
            mainNumOfCorn += numOfCorn / 15;
            numOfCorn *= 2;
        }

        while (mainNumOfCorn >= 10)
        {
            mainNumOfCorn /= 10;        
            power += 1;
        }
        answer = Math.Round(mainNumOfCorn, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Round(Math.Sqrt(x*(x+2*6350)), 2);
        // end

        return answer;
    }
    public int Task_1_18(int x) // dotnet test --filter Tests.ProgramTests.Task_1_18Test
    {
        int answer = 10;

        // code here
        for (int i=3; i<=x; i+=3)
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
        // ⛔
        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 1;

        // code here
        int NumL = 1;
        for (int i=1; (NumL * i)<=30000; i+=3)
        {
            NumL *= i;
            answer = i;
        }
        // end

        return answer;
    }
    public int Task_2_3(double a, double h, double p)
    {
        int answer = 0;

        // code here
        // ⛔
        // end

        return answer;
    }
    public double Task_2_4(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) < 1)
        {
            double epsilon = 0.0001;
            double chlen = 1;
            while (chlen >= epsilon)
            {
                answer += chlen;
                chlen *= x * x;
            }
        } 
        else answer = 0;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public (int, int) Task_2_5(int N, int M)
    {
        int quotient = 0, remainder = 0;

        // code here
        // ⛔
        // end

        return (quotient, remainder);
    }
    public int Task_2_6()
    {
        int answer = 0;

        // code here
        int numberOfCells = 10;
        while (numberOfCells < 100000)
        {
            answer += 3;
            numberOfCells *= 2;
        }
        // end

        return answer;
    }
    public double Task_2_7a()
    {
        double answer = 0;

        // code here
        // ⛔
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        // ⛔
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        // ⛔
        // end

        return answer;
    }
    public int Task_2_8()
    {
        int answer = 0;

        // code here;
        double babki = 10000;
        while (babki < 20000)
        {
            answer += 1;
            babki += babki * 0.08;
        }

        // end

        return answer;
    }
    public int Task_2_9()
    {
        int answer = 0;

        // code here;
        // ⛔
        // end

        return answer;
    }
    public int Task_2_10()
    {
        int answer = 1;

        // code here;
        int num = 1, den = 1, lstNum = 1;
        double epsilon = 0.001, number = 0, secNumber = num/den;
        while (Math.Abs(secNumber-number) > epsilon) {
            lstNum = num;
            num += den;
            den = lstNum;
            number = secNumber;
            secNumber = (double) num/den;
            answer += 1;
        }

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
    public (double, double) Task_3_4(double x) // dotnet test --filter Tests.ProgramTests.Task_3_4Test
    {
        double S = 0, y = 0;

        // code here
        for (double a = 0.1; a < 1; a += 0.1)
        {
            y = (1 + 2 * x * x) * Math.Exp(x * x);
            S = 1;
            double i = 1;
            double num = 3 * x * x;
            double den = 1;
            double part = num / den;
            double x2i = x * x;

            while (Math.Abs(part) >= 0.0001)
            {
                S += part;
                i++;
                x2i *= x*x;
                num = (2 * i + 1) * x2i;
                den *= i;

                part = num / den;
            }
        }

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