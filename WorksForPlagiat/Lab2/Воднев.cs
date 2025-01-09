using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO.Compression;
using System.Runtime.InteropServices;

public class Program
{
    private const int V = 0;

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

        // code here
        int r = 2;
        answer = (Math.Abs(x*x + y*y - r*r) <= 0.001);
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        answer = (y >= 0 && y + Math.Abs(x) <= 1);
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        switch (a){
            case > 0:
            if (a >= b) answer = a; else answer = b;
            break;
            case <= 0:
            if (a <= b) answer = a; else answer = b;
            break;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0, tmp = 0;

        // code here
        if (a <= b) tmp = a; else tmp = b;
        if (tmp >= c) answer = tmp; else answer = c;

        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        answer = 2*r / Math.PI >= s;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        answer = r / Math.PI <= s / 4;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        switch (Math.Abs(x)) {

        case > 1: answer = 1; break;
        case <= 1: answer = Math.Abs(x); break;
        }
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        switch (Math.Abs(x)) {

        case >= 1: answer = 0; break;
        case < 1: answer = x*x - 1; break;
        }
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        switch (x) {
        case <= -1: answer = 0; break;
        case > 0: answer = 1; break;
        default: answer = 1 + x; break;
        }
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        switch (x) {
        case <= -1: answer = 1; break;
        case > 1: answer = -1; break;
        default: answer = -x; break;
        }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        int k = n;
        while (k > 0) {
            k--;
            System.Console.WriteLine($"Write age of pupil");
            answer += double.Parse(Console.ReadLine());

        }
        answer /= n;
        System.Console.WriteLine(answer);
  
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x, y;
        while (n > 0) {
            n--;
            System.Console.WriteLine("Write coordinates: x = ");
            x = double.Parse(Console.ReadLine());
            System.Console.WriteLine("y = ");
            y = double.Parse(Console.ReadLine());
            if (Math.Sqrt((x-a)*(x-a) + (y-b)*(y-b)) <= r) answer++;
        }
        System.Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double w;
         while (n > 0) {
            n--;
            System.Console.WriteLine("Write weight ");
            w = double.Parse(Console.ReadLine());
  
            if (w < 30) answer += 0.2;

        }
        System.Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x, y;
            while (n > 0) {
            n--;
            System.Console.WriteLine("Write coordinates: x = ");
            x = double.Parse(Console.ReadLine());
            System.Console.WriteLine("y = ");
            y = double.Parse(Console.ReadLine());
            if ((x*x + y*y >= r1*r1) && (x*x + y*y >= r2*r2)) answer++;
        }
        System.Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
    
        // code here
        double resRunner;
        while (n > 0) {
            n--;
            System.Console.WriteLine("Write result ");
            resRunner = double.Parse(Console.ReadLine());
            if (resRunner <= norm) answer++;
        }
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x, y;
            while (n > 0) {
            n--;
            System.Console.WriteLine("Write coordinates: x = ");
            x = double.Parse(Console.ReadLine());
            System.Console.WriteLine("y = ");
            y = double.Parse(Console.ReadLine());
            if ((x >= 0) && (x <= Math.PI) && (Math.Sin(x) >= y)) answer++;
            }
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        double x, y;
        while (n > 0) {
            n--;
            System.Console.WriteLine("Write coordinates: x = ");
            x = double.Parse(Console.ReadLine());
            System.Console.WriteLine("y = ");
            y = double.Parse(Console.ReadLine());
            if (x * y > 0) {
                if (x > 0 && y > 0) {
                    System.Console.WriteLine("I quadrant");
                    answer1++;
                }
                else {
                    System.Console.WriteLine("III quadrant");
                    answer3++;
                }
            }
            
            else {
                if (x > 0 && y < 0) System.Console.WriteLine("IV quadrant"); else System.Console.WriteLine("II quadrant");
            }
        }

            
        
        System.Console.WriteLine(answer1);
        System.Console.WriteLine(answer3);

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x, y, d;
        for (int i = 1; i <= n; i++) {
            System.Console.WriteLine("Write coordinates: x = ");
            x = double.Parse(Console.ReadLine());
            System.Console.WriteLine("y = ");
            y = double.Parse(Console.ReadLine());
            d = Math.Sqrt(x*x + y*y);

            if (d < answerLength) {
                answerLength = d;
                answer = i;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        System.Console.WriteLine(answer);
        System.Console.WriteLine(answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double res;
        while (n > 0) {
            n--;
            System.Console.WriteLine("Write result ");
            res = double.Parse(Console.ReadLine());
            if (res < answer) answer = res;
            
        }
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        // code here;
        double mark;
        int nkeei, yepyani;
        while (n > 0) {
            n--;
            nkeei = 0;
            yepyani = 0;
            while (nkeei < 4) {
                nkeei++;
                System.Console.WriteLine("Write mark ");
                mark = double.Parse(Console.ReadLine());
                if (mark > 3) yepyani++;
            }
            if (yepyani == 4) answer++;
            
        }
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        // code here;
        double mark, d;
        int nkeei, yepyani;
        d = n;
        while (n > 0) {
            n--;
            nkeei = 0;
            yepyani = 0;
            while (nkeei < 4) {
                nkeei++;
                System.Console.WriteLine("Write mark ");
                mark = double.Parse(Console.ReadLine());
                avg += mark;
                if (mark == 2) yepyani++;
            }
            if (yepyani > 0) answer++;
            
        }
        avg /= d*4;
        System.Console.WriteLine(answer);
        System.Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here
        if (r <= 0) return 0;
        switch (type) {
        case 0: answer = Math.Round(r*r, 2); break;
        case 1: answer = Math.Round(Math.PI * r*r, 2); break;
        case 2: answer = Math.Round((r*r * Math.Sqrt(3) / 4), 2); break;
        default: answer = 0; break;
        }
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A <= 0 || B <= 0) return 0;
        switch (type) {
        case 0: answer = Math.Round(A*B, 2); break;
        case 1: answer = Math.Round(Math.Abs(Math.PI * (A*A - B*B)), 2); break;
        case 2: answer = Math.Round(A/4 * Math.Sqrt(4*B*B - A*A), 2); break;
        default: answer = 0; break;
        }
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
        double w;
        System.Console.WriteLine("Write weight, for exit '-1' ");

        w = double.Parse(Console.ReadLine());
        while (w != -1) {
            System.Console.WriteLine("Write weight, for exit '-1' ");
            if (w < 30) answer += 0.2;
            w = double.Parse(Console.ReadLine());
        }
        System.Console.WriteLine(answer);
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
        double x, y;
        System.Console.WriteLine("Write x, for exit make y = 1000");
        x = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Write y, for exit make y = 1000");
        y = double.Parse(Console.ReadLine());
        while (y != 1000) {
            if ((x >= 0) && (x <= Math.PI) && (Math.Sin(x) >= y)) answer++;
            System.Console.WriteLine("Write x, for exit make y = 1000");
            x = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Write y, for exit make y = 1000");
            y = double.Parse(Console.ReadLine());   
        }
        System.Console.WriteLine(answer);
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
        double res;
        System.Console.WriteLine("Write result, for exit '-1' ");
        res = double.Parse(Console.ReadLine());
        while (res != -1) {
            if (res < answer) answer = res;
            System.Console.WriteLine("Write result, for exit '-1' ");
            res = double.Parse(Console.ReadLine());
        }
        System.Console.WriteLine(answer);

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