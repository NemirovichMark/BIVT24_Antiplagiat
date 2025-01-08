﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Formats.Asn1;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        //program.Task_1_1();
        // program.Task_1_2();
        // program.Task_1_3();
        // program.Task_1_4(0.5);
        // program.Task_1_5(0, 2);
        // for (double x = -4; x <=4; x+=0.5) {
            // WriteLine(program.Task_1_6(x));
        // }
        // program.Task_1_7();
        // program.Task_1_8();
        // program.Task_1_9(); 
        // program.Task_1_10();s
        // program.Task_1_11();
        // program.Task_1_12(0.9);
        // for (double x = -1.5; x<= 1.5; x+=0.1) {
            // WriteLine(program.Task_1_13(x));
        // }
        // program.Task_1_14();
        // program.Task_1_15();
        // program.Task_1_16();
        // for (double height = 1; height <11; height++ ) {
            // program.Task_1_17(height);
        // }
        // program.Task_1_18(24);
        //program.Task_2_1(0);
        // program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        // program.Task_2_4(0.8);
        //program.Task_2_5(11, 5);
        // program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        // program.Task_2_8();
        //program.Task_2_9();
        // program.Task_2_10();
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        //program.Task_3_3(0.1);
        //program.Task_3_4(0.1);
        //program.Task_3_5(double.Pi/5);
        for (double x =0.1; x<= 1; x+=0.1) {
            program.Task_3_6(x);
        }
        //program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;
        for (int i = 2; i<36; i+=3) {
            answer += i;
        }
        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;
            for (double j = 1; j<11; j++) {
                answer += 1/j;
            }
        return Math.Round(answer,2);
    }
    public double Task_1_3()
    {
        double answer = 0;
        for (double k = 2; k<113; k+=2) {
            answer += k/(k+1);
        }
        return Math.Round(answer,2);
    }
    public double Task_1_4(double x)
    {
        double answer = Math.Cos(x);
        if (x == 0) {
            return 0;
        }
        double a = x;
        for (double l = 2; l<10; l++) {
            answer += Math.Cos(x*l)/a;
            a *=x;
        }
        return Math.Round(answer,2);
    }
    public double Task_1_5(double p, double h)
    {
        double answer = Math.Pow(p,2);
        for (double c = 1; c<10; c++ ) {
            answer += Math.Pow(p + c * h, 2);
        }
        return Math.Round(answer,2);
    }
    public double Task_1_6(double x)
    {
        double answer = 0;
        answer = Math.Round(0.5*x*x - 7*x,2);
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;
        for (int l = 2; l<7; l++) {
            answer *= l;
        }
        return answer;
    }
    public int Task_1_8()
    {
        int answer = 1;
        int factorial = 1;
        for (int y = 2; y<7; y++) {
            factorial *= y;
            answer += factorial;
        }
        return answer;
    }
    public double Task_1_9()
    {
        double answer = -5;
        double factorial = 1;
        int five = 5;
        for (int k = 2; k<7; k++) {
            factorial *= k;
            five *= 5;
            if (k % 2 == 0){
                answer += five / factorial;
            }
            else {
                answer += (-1) * five / factorial;
            }
        }
        return Math.Round(answer,2);
    }
    public int Task_1_10()
    {
        int answer = 3;
        for (int n = 1; n<7; n++) {
            answer *= 3;
        }
        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int a = 1; a<7; a++) {
            Console.Write($"{a} ");
        }
        WriteLine(' ');
        for (int b = 1; b<7; b++) {
            Console.Write("5 ");
        }
    }
    public double Task_1_12(double x)
    {
        double answer = 1;
        double znam = x;
        if (x == 0) {
            return 0;
        } 
        for (double s = 1; s<11; s++) {
            answer += 1/znam;
            znam *= x;
        }
        return Math.Round(answer,2);
    }
    public double Task_1_13(double x)
    {
        double answer = 0;
        if (x<=-1) {
            answer = 1;
        }
        else if (x > 1) {
            answer = -1;
        }
        else {
            answer = Math.Round(-x,2);
        }
        return answer;
    }
    public void Task_1_14()
    {
        int num1 = 1, num2 = 1;
        Console.Write($"{num1} {num2} ");
        for (int y = 1; y<7; y++) {
            int num3 = num1 + num2;
            Console.Write($"{num3} ");
            num1 = num2;
            num2 = num3;
        }
    }
    public double Task_1_15()
    {
        double answer = 0;
        double ch1 = 1, zn1 = 1, ch2 = 2, zn2 = 1;
        for (int y = 1; y<4; y++) {
            double ch3 = ch1 + ch2;
            double zn3 = zn1 + zn2;
            ch1 = ch2;
            zn1 = zn2;
            ch2 = ch3;
            zn2 = zn3;
        }
        answer = ch2/zn2;
        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 1;
        int power = 0;
        double zerno = 1;
        for (int i = 1; i<64; i++) {
            zerno *= 2;
            answer += zerno;
        }
        answer /= 15;
        while (answer >= 10) {
            power++;
            answer /= 10;
        }
        return (Math.Round(answer,2), power);
    }
    public double Task_1_17(double height)
    {
        double answer = 0;
        answer = Math.Round(Math.Sqrt(Math.Pow(6350+height,2) - Math.Pow(6350,2)),2);
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;
        for (int o = 3; o <= x; o+=3) {
            answer *= 2;
        }
        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;
        return answer;
    }
    public int Task_2_2()
    {
        int answer = 1; 
        int nums = 1;
        do {
            answer += 3;
            nums *=answer;
        }
        while(nums<=30000);

        return (answer-3);
    }
    public int Task_2_3(double a, double h, double p)
    {
        int answer = 0;

        return answer;
    }
    public double Task_2_4(double x)
    {
        double answer = 1;
        double num = x*x;
        if (Math.Abs(x)>=1) 
        { 
            return 0; 
        } 
        while (num >= 0.0001) {
            answer += num;
            num = num*x*x;
        }
        return Math.Round(answer,2);
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
        int amount = 10;
        for (int time = 3; amount < 100000 ;time += 3) {
            amount *= 2;
            if (amount >= 100000) {
                answer = time;
                break;
            }
        }

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
        double money = 10000;
        int time = 0;
        while (money < 20000) {
            time += 1;
            money *= 1.08;
        }
        answer = time;
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
        double ch1 = 1, ch2 = 2, zn1 = 1, zn2 = 1;
        while (Math.Abs(ch2/zn2 - ch1/zn1) > 0.001) {
            double ch3 = ch2+ch1, zn3 = zn2+zn1;
            ch1 = ch2; zn1 = zn2;
            ch2 = ch3; zn2 = zn3;
            answer++;
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
        double power = x*x;
        for (double i = 1; ; i+=1) {
            double num = x*power/(4*i*i-1);
            power *= x*x;
            if (i % 2 == 0) {
                num = -num;
            }
            if (Math.Abs(num) < 0.0001) {
                break;
            }
            else {
                S += num;
            }
        }
        y = (1+x*x)*Math.Atan(x)/2 - x/2;
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