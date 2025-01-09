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
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_3(10);
        //program.Task_2_4(3, 1, 3);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(3);
        //program.Task_2_7(3);
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
        double a = Math.Abs(x * x + y * y - r * r);
        if (a <= 1 / 1000)
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && y + Math.Abs(x) <= 1)
            answer = true;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)
            if (a > b)
                answer = a;
            else 
                answer = b;
        else 
            if (a < b)
                answer = a;
            else 
                answer = b;
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double z = 0;
        double mn_ab = 0;
        if (a < b)
            mn_ab = a;
        else
            mn_ab = b;
            if (mn_ab > c)
                answer = mn_ab;
            else
                answer = c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (2 * Math.Sqrt(r/Math.PI) > Math.Sqrt(s) * Math.Sqrt(2))
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (2 * Math.Sqrt(r / Math.PI) <= Math.Sqrt(s))
            answer = true;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1)
            answer = 1;
        else
            answer = Math.Abs(x);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1)
            answer = 0;
        else
            answer = x*x - 1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if ( x <= -1)
            answer = 0;
        if (x > -1 && x <= 0)
            answer = 1 + x;
        if (x > 0)
            answer = 1;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 1;
        if (x > -1 && x <= 1)
            answer = -x;
        if (x > 1)
            answer = -1;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double sm_rost = 0;
        if (n == 0)
            return 0;
        for (int step = 0; step < n; step++)
        {
            sm_rost += int.Parse(Console.ReadLine());
            answer = sm_rost / n * 1.0;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double rast_ot_ab = 0;
        double x, y;
        for (int step = 0; step < n; step++)
        {
            
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            rast_ot_ab = Math.Sqrt(((x - a) * (x - a)) + ((y - b) * (y - b)));
            
            if (rast_ot_ab < r)
                answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double ves;
        for (int step = 0; step < n; step++)
        {
            ves = double.Parse(Console.ReadLine());
            if (ves < 30)
                answer += 0.2;
                answer = Math.Round(answer, 2);
        }
        
        Console.WriteLine(answer);
        
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x, y, R;

        for (int step = 0; step < n; step++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            R = Math.Sqrt((x * x) + (y * y));
            if (R > r1 && R < r2)
                answer++;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double rez;
        for (int step = 0; step < n; step++)
        {
            rez = double.Parse(Console.ReadLine());
            if (rez <= norm)
                answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int step = 0; step < n; step++)
        {
            x = double.Parse((Console.ReadLine()));
            y = double.Parse((Console.ReadLine()));
            if (x >= 0 && x <= Math.PI && Math.Sin(x) >= y)
                answer++;
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
        double x, y;
        for (int step = 0; step < n; step++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine(1);
                answer1++;
            }
            else if (x < 0 && y > 0)
                Console.WriteLine(2);
            else if (x < 0 && y < 0)
            {
                Console.WriteLine(3);
                answer3++;
            }
            else if (x > 0 && y < 0)
                Console.WriteLine(4);
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
        double x, y;
        double proverka;
        for (int step = 1; step <= n; step++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            proverka = Math.Sqrt(x * x + y * y);
            proverka = Math.Round(proverka, 2);
            if (proverka < answerLength)
            {
                answer = step;
                answerLength = proverka;
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double v;
        for (int step = 0; step < n; step++)
        {
            v = double.Parse(Console.ReadLine());
            if (v < answer)
                answer = v;
        }
        Console.WriteLine(answer);
        // end

            return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        
        // code here;
        int g1, g2, g3, g4;
        for (int step = 0; step < n; step++)
        {
            g1 = int.Parse(Console.ReadLine());
            g2 = int.Parse(Console.ReadLine());
            g3 = int.Parse(Console.ReadLine());
            g4 = int.Parse(Console.ReadLine());
            if (g1 > 3 && g2 > 3 && g3 > 3 && g4 > 3)
                answer++;
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
        int g1, g2, g3, g4;
        int sm_g = 0;
        
        for (int step = 0; step < n; step++)
        {
            g1 = int.Parse(Console.ReadLine());
            g2 = int.Parse(Console.ReadLine());
            g3 = int.Parse(Console.ReadLine());
            g4 = int.Parse(Console.ReadLine());
            sm_g += (g1 + g2 + g3 + g4);
            if (g1 < 3 || g2 < 3 || g3 < 3 || g4 < 3)
                answer++;
        }
        avg = sm_g / (n * 4.0);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
            // end

            return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        if (r < 0)
            return 0;

        // code here;
        
        switch (type)
        {
            case 0:
                answer = Math.Round((r * r), 2);
                break;
            case 1:
                answer = Math.Round((Math.PI * r * r), 2);
                break;
            case 2:
                answer = Math.Round(((r * r * Math.Sqrt(3)) / 4), 2);
                break;
            default:
                break;
        }

        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        double p;
        if (A <= 0 || B <= 0)
            return answer = 0;
        switch (type)
        {
            case 0:
                answer = Math.Round(A * B, 2);
                break;

            case 1:
                if (A > B)
                    answer = Math.Round(Math.PI * (A * A - B * B), 2);
                else if (B > A) 
                    answer = Math.Round(Math.PI * (B * B - A * A), 2);
                if (answer < 0)
                    return answer = 0;
                break;

            case 2:
                p = (A + B + B) / 2;
                answer = Math.Round((Math.Sqrt(p * (p - A) * (p - B) * (p - B))), 2);
                if (answer < 0) return answer = 0;
                
                break;

            default:
                break;
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
        double ves;
        while (true)
        {
            ves = double.Parse(Console.ReadLine());
            if (ves <= 0)
                break;
            n++;
            if (ves < 30)
                answer += 0.2;
            answer = Math.Round(answer, 2);
        }

        Console.WriteLine(answer);
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

        while (true)
        {
            x = double.Parse((Console.ReadLine()));
            if (x == 1000)
                break;
            n++;
            y = double.Parse((Console.ReadLine()));
            if (x >= 0 && x <= Math.PI && Math.Sin(x) >= y)
                answer++;
        }   
        Console.WriteLine(answer);
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
        double v;
        while (true)
        {
            v = double.Parse(Console.ReadLine());
            if (v == -1)
                break;
            n++;
            if (v < answer)
                answer = v;
        }
        Console.WriteLine(answer);
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