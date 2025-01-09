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
        program.Task_2_7(5);
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
        if (Math.Abs(x * x + y * y - r * r) <= 0.001)
        {
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && y + Math.Abs(x) <= 1)
        {
            answer |= true;
        }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)
        {
            if (a > b)
            {
                answer = a;
            }
            else
            {
                answer = b;
            }
        }
        else
        {
            if (a <= b)
            {
                answer = a;
            }
            else
            {
                answer = b;
            }
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        if (a > b)
        {
            answer = b;
        }
        else
        {
            answer = a;
        }
        if (c > answer)
        {
            answer = c;
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double d1, d2;
        d1 = Math.Sqrt(s) * Math.Sqrt(2);
        d2 = 2 * Math.Sqrt(r / Math.PI);
        if (d2 - d1 > 0)
        {
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double d1, d2;
        d1 = Math.Sqrt(s);
        d2 = 2 * Math.Sqrt(r / Math.PI);
        if (d1 - d2 > 0)
        {
            answer = true;
        }
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1)
        {
            answer = 1;
        }
        else
        {
            answer = Math.Abs(x);
        }
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) < 1)
        {
            answer = x * x - 1;
        }
        else
        {
            answer = 0;
        }
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x > 0)
        {
            answer = 1;
        }
        else if (x <= -1)
        {
            answer = 0;
        }
        else answer = 1 + x;
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
        else if (x > 1)
        {
            answer = -1;
        }
        else answer = -x;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double sred = 0;
        for (int i = 1; i <= n; i++)
        {
            double dx = Convert.ToDouble(Console.ReadLine());
            sred += dx;
        }
        answer = sred / n;
        answer = Math.Round(answer, 4);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if ((a - x) * (a - x) + (b - y) * (b - y) <= r * r)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double ves = Convert.ToDouble(Console.ReadLine());
            if (ves < 30)
            {
                answer += 0.2;
            }
        }
        Console.WriteLine(answer);
            // end

            return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for(int i = 1; i <= n; i ++)
        {
            double x = Convert.ToDouble(Console.ReadLine()), y = Convert.ToDouble(Console.ReadLine());
            if (x*x + y*y > r1 * r1)
            {
                if (x*x + y*y < r2 * r2) { answer++; }
            }
        }
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for(int i = 1; i <= n; i++)
        {
            double atlet = Convert.ToDouble(Console.ReadLine());
            if (atlet <= norm)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for(int i = 1; i <= n; i++)
        {
            double x = Convert.ToDouble((Console.ReadLine())), y = Convert.ToDouble((Console.ReadLine()));
            if (x >= 0 && x <= Math.PI && y >= 0)
            {
                if (Math.Sin(x) >= y) { answer++; }
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for (int i = 1; i <= n; i ++)
        {
            double x = Convert.ToDouble(Console.ReadLine()), y = Convert.ToDouble(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine(1);
                answer1++;
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine(3);
                answer3++;
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine(4);
            }
            else { Console.WriteLine(2); }
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        for (int i = 1; i <= n; i ++)
        {
            double x = Convert.ToDouble(Console.ReadLine()), y = Convert.ToDouble(Console.ReadLine());
            if (Math.Sqrt(x * x + y * y) < answerLength)
            {
                answerLength = Math.Sqrt(x * x + y * y);
                answer = i;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for(int i = 1; i <= n; i ++)
        {
            double sport = Convert.ToDouble(Console.ReadLine());
            if (sport < answer)
            {
                answer = sport;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 1; i <= n; i++)
        {
            double exam1 = Convert.ToDouble(Console.ReadLine()), exam2 = Convert.ToDouble(Console.ReadLine()), exam3 = Convert.ToDouble(Console.ReadLine()), exam4 = Convert.ToDouble(Console.ReadLine());
            if(exam1 > 3 &&  exam2 > 3 && exam3 > 3 && exam4 > 3)
            {
                answer++;
            }
           
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        for (int i = 1; i <= n; i++)
        {
            double exam1 = Convert.ToDouble(Console.ReadLine()), exam2 = Convert.ToDouble(Console.ReadLine()), exam3 = Convert.ToDouble(Console.ReadLine()), exam4 = Convert.ToDouble(Console.ReadLine());
            if (exam1 > 3 && exam2 > 3 && exam3 > 3 && exam4 > 3)
            {
                answer++;
            }
            avg += exam1 + exam2 + exam3 + exam4;

        }
        avg /= n * 4;
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if ((type != 1 && type != 0 && type != 2) || r <= 0) return 0;
        switch (type)
        {
            case 0:
                answer = r * r;
                answer = Math.Round(answer, 2); break;
            case 1:
                answer = r * r * Math.PI;
                answer = Math.Round(answer, 2); break;
                
            case 2:
                answer = r * r / 4 * Math.Sqrt(3);
                answer = Math.Round(answer, 2); break;
        }
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if ((type != 1 && type != 0 && type != 2) || (A <= 0 || B <= 0)) return 0;
        switch (type)
        { 
            case 0:
                answer = A * B; answer = Math.Round(answer, 2); break;
            case 1:
                answer = Math.PI * Math.Abs( A * A - B * B ); answer = Math.Round(answer, 2); break;
            case 2:
                answer = Math.Sqrt(B * B - A * A / 4) * A / 2; answer = Math.Round(answer, 2); break;
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
        while(true)
        {
            double x, y;
            bool chek1 = double.TryParse(Console.ReadLine(), out x); if (chek1 == false) break;
            bool chek2 = double.TryParse(Console.ReadLine(), out y); if (chek2 == false) break;
            n++;
                if ((a - x) * (a - x) + (b - y) * (b - y) <= r * r)
                {
                    answer++;
                }
        }
        Console.WriteLine(answer);
        Console.WriteLine(n);
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
        while(true)
        {
            double atlet;
            bool check = double.TryParse(Console.ReadLine(), out atlet); if (check == false) break;
            n++;
            if (atlet <= norm)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(n);
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
        int k = 0;
        while(true)
        {
            double x, y;
            bool check1 = double.TryParse(Console.ReadLine(), out x); if (check1 == false) break;
            bool check2 = double.TryParse(Console.ReadLine(), out y); if (check2 == false) break;
            n++;
            if (Math.Sqrt(x * x + y * y) < answerLength)
            {
                answerLength = Math.Sqrt(x * x + y * y);
                answer = n;
            }
            
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        Console.WriteLine(n);

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
        while(true)
        {
            double exam1, exam2, exam3, exam4;
            bool check1 = double.TryParse(Console.ReadLine(), out exam1); if (check1 == false) break;
            bool check2 = double.TryParse(Console.ReadLine(), out exam2); if (check2 == false) break;
            bool check3 = double.TryParse(Console.ReadLine(), out exam3); if (check1 == false) break;
            bool check4 = double.TryParse(Console.ReadLine(), out exam4); if (check2 == false) break;
            n++;

            if (exam1 > 3 && exam2 > 3 && exam3 > 3 && exam4 > 3)
            {
                answer++;
            }
            avg += exam1 + exam2 + exam3 + exam4;
        }
        avg /= n * 4;
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        Console.WriteLine(n);
        // end

        return (answer, avg);
    }
    #endregion
}