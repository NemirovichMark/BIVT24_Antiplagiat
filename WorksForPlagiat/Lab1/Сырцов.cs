﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

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
        program.Task_3_1(0.1);
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
        for (int i = 2; i <= 35; i = i + 3)
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
            answer = answer + 1 / i;
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i <= 112; i+=2)
        {
            answer = answer + (i / (i + 1));
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
        double donominator = 1;
        if (x > 0)
        {
            for (int i = 1; i <= 9; i++)
            {
                answer = answer + Math.Cos(i * x) / donominator;
                donominator *= x;
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
        for ( int i = 0; i<=9; i++)
        {
            answer += (p + i * h) * (p + i * h);
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        
        answer = Math.Round(0.5 * x * x - 7 * x, 2);
        
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int i = 2; i <= 6; i++)
        {
            answer *=  i;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int factorial = 1, i = 2, j =0 ;
        while (j < 6)
        {
            answer += factorial;
            factorial *= i;
            i++;
            j++;
        }


        //int another_answer = 1;
        //for (int i = 1; i <= 6; i++)
        //{
        //    for (int j = 2; j <= i; j++)
        //    {
        //        another_answer *= j;
        //    }
        //    answer += another_answer;
        //    another_answer = 1;
        //}
        Console.WriteLine(answer);
        // end


        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        int i = 1;
        double  minus_one = -1, up_num=5, down_num =1;
        double part = minus_one * up_num / down_num;
        while (i <= 6)
        {
            answer += part;
            i++;
            minus_one *= -1;
            up_num *= 5;
            down_num *= (i);
            part = minus_one * up_num / down_num;
        }


        //double number_five = 1;
        //int factorial = 1, p = 1;
        //for (int i = 1; i <= 6; i++)
        //{
        //    p = -p;
        //    for (int j = 2; j <= i; j++)
        //    {
        //        factorial *= j;
        //    }
        //    number_five *= 5;
        //    answer += (p*number_five) / factorial;
        //    factorial = 1;
        //}
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 3;
        for (int i = 1; i<=6; i++)
            answer *= 3;
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i =1; i<7; i++)
        {
            Console.Write(i);
            Console.Write(" ");
        }
        Console.WriteLine();
        for (int i = 1; i<7; i++)
        {
            Console.Write(5);
            Console.Write(" ");
        }
        Console.WriteLine();

        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double donominator = 1;
        if (x > 0)
        {
            for (int i = 0; i <= 10; i++)
            {
                answer += 1 / donominator;
                donominator *= x;
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
        if (x <= -1)
        {
            answer = 1;
        }
        else if ( -1 < x && x<=1)
        {
            answer = -x;
        }
        else
        {
            answer = -1;
        }

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int number_1 = 1, number_2 = 1, number_3 = 0;
        Console.Write(number_1);
        Console.Write(number_2);
        for (int i = 1; i <= 6; i++)
        {
            number_3 = number_1 + number_2;
            Console.Write(number_3);
            number_1 = number_2;
            number_2 = number_3;
        }

        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double number_1=1, number_2=1, number_3=0;
        for (int i = 1; i<5; i++)
        {
            number_3 = number_1 + number_2;
            answer = number_3 / number_2;
            number_1 = number_2;
            number_2 = number_3;
        }
        Console.WriteLine(answer);



        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double summa = 1, ten_power=1;
        for (int i = 0; i < 64; i++)
        {
            if (answer >  ten_power * 10)
            {
                ten_power *= 10;
                power += 1;
            }
            answer += summa;
            summa *= 2;
        }
        answer /= ten_power * 15;
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        
        //answer = answer / 15;
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int R = 6350;
        for (int h =1; h <= x; h++)
        {
            answer = Math.Round(Math.Sqrt((R + h) * (R + h) - R * R), 2);
        }

        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = 10;
        for (int i=3; i <=x; i += 3)
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
        int i = 1;
        while (Math.Abs(Math.Cos(x * i) / (i * i)) >= 0.0001)
        {
            answer += Math.Cos(x * i) / Math.Pow(i, 2);
            i++;

        }
        //answer = Math.Round(answer, 2);
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
        double summa = a;

        if (h > 0)
        {
            while (summa <= p)
            {
                answer++;
                summa += a + h * answer;
            }
        }
        Console.WriteLine(answer);
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
        if ( M != 0) 
        { 
            while (Math.Abs(N)>=Math.Abs(M))
            {
                N -= M;
                quotient++;
            }
            remainder = Math.Abs(N);
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
        for (double i = 1, path = 10; i <= 7; i++)
        {
            answer += path;
            path = path + path * 0.1;
            
        }
        answer = Math.Round(answer, 2);
        

        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double summa = 0, path = 10;
        while (summa <= 100)
        {
            
            summa += path;
            path = path + path * 0.1;
            answer++;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double path = 10;
        while (path < 20)
        {
            path = path * 1.1;
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
        double atom = 0, denominator = 1;
        for (int i=0; i<=10; i++)
        {

            atom = 1 / denominator;
            denominator *= 10;
        }
        Console.WriteLine(atom);
        double cutted_rope = 0.1;
        while (cutted_rope >= atom)
        {
            cutted_rope /= 2;
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
        double S = 0, y = 0;

        // code here
        
        int i = 1;
        S = 1;
        double minus_one = -1, up_number = x*x, down_number = 2;
        double part = minus_one * up_number / down_number;
        while (Math.Abs(part) >= 0.0001)
        {
            S += part;
            i++;
            minus_one *= -1;
            up_number *= x * x;
            down_number *= (i*2) * (i*2 - 1);
            
            part = minus_one * up_number / down_number;

        }
        y = Math.Cos(x);
        //S = Math.Round(S, 2);
        //y = Math.Round(y, 2);

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