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
        for (int i = 2; i<=35; i+=3){
            answer += i;
        }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (int i = 1; i<= 10; i++){
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
        for (double i = 2; i<=112; i+=2){
            answer += i/(i+1);
        }
        answer = Math.Round(answer, 2);
        // end
        
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        
        // code here
        double n = 1;
        if (x>0){
        for (int i = 1; i<= 9; i++){
            answer += Math.Cos(x*i)/n;
            n *= x;
        }
        }
        answer = Math.Round(answer, 2);
        // end


        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i <= 9; i++){
            answer += (p+i*h)*(p+i*h);
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        for (double i = -4; i<4; i+=0.5){
            answer = Math.Round(0.5*x*x - 7*x, 2);
        }
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int i = 2; i<=6; i++){
            answer *= i;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int f = 1;
        for (int i=1; i<=6; i++){
            answer += f;
            f *= i+1;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double f = 1;
        double p = 5;
        int n = -1;
        for (int i=1; i<=6; i++){
            answer += p/f*n;
            n = -n;
            p *= 5;
            f *= i+1;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 3;
        for (int i = 1; i<=6; i++){
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i<=6; i++){
            Console.Write(i);
            Console.Write(" ");
        }
        Console.WriteLine();
        for (int i =1; i<=6; i++){
            Console.Write(5);
            Console.Write(" ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double n = 1;
        if (x > 0){
        for (int i = 0; i <=10; i++){
            answer += 1/n;
            n *= x;
        }
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if(x <= -1){
            answer = 1;
        }
        else if(x > -1 && x <= 1){
            answer = -x;
        }
        else{
            answer = -1;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        
        int n1 = 1, n2 = 1, n = 0;
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        for (int i=3; i<=8; i++){
            n = n1 + n2;
            Console.WriteLine(n);
            n1 = n2;
            n2 = n;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        int n1 = 1, n2 = 1, n = 0;
        for (int i=3; i<=5; i++){
            n = n1 + n2;
            n1 = n2;
            n2 = n;
        }
        n = n1 + n2;
        answer = n/Convert.ToDouble(n2);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        // code here
        double ten = 1;
        double n = 1;
        for (int i = 0; i<64; i++){
            if (answer > ten*10){
                ten *= 10;
                power++;
            }
            answer += n;
            n *= 2;
        }
        answer /= 15*ten;
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int R = 6350;
        for (int h = 1; h<=x; h++){
            answer = Math.Round(Math.Sqrt((R+h)*(R+h) - R*R), 2);
        }
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = 10;
        for (int i = 3; i <= x; i+=3){
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
        
        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here
        int p = 1;
        int n = 4;
        answer = 1;
        while (p <= 30_000){
            if (p*(answer+3) < 30_000){
                answer += 3;
            }
            else{
                break;
            }
            p *= n;
            n += 3;
        }
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
        int i = 1;
        double n = 1;
        if (Math.Abs(x) < 1){
            while (n >= 0.0001){
                n *= x*x;
                answer += n;
                i++;
            }
            answer++;
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

        // code here
        int n = 10;
        while (n < 100_000){
            answer += 3;
            n *= 2;
        }
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
        double s = 10_000;
        while (s < 20_000){
            s *= 1.08;
            answer += 1;
        }
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
        answer = 2;
        int n1 = 1, n2 = 1;
        int n = n1 + n2;
        double d1 = 1, d2 = 0;
        while (Math.Abs(d1-d2) >= 0.001){
            answer++;
            n1 = n2;
            n2 = n;
            n = n1 + n2;
            d1 = Convert.ToDouble(n2)/n1;
            d2 = Convert.ToDouble(n)/n2;
        }
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
        int i = 0;
        int f = 1;
        double X = 1;

        double N = (2*i+1)*X/f;
        while (Math.Abs(N) >= 0.0001){
            S += N;

            i++;
            X *= x*x;
            f *= i;
            N = (2*i+1)*X/f;
        }
        y = (1+2*x*x)*Math.Exp(x*x);
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