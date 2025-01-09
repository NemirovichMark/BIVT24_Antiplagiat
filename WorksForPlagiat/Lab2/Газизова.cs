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
        program.Task_1_1(0.9, 1.23);
        program.Task_1_2(0.9, 1.23);
        program.Task_1_3(0.9, 1.23);
        program.Task_1_4(0.9, 1.23, -0.1);
        program.Task_1_5(0.9, 1.23);
        program.Task_1_6(0.9, 1.23);
        program.Task_1_7(0.9);
        program.Task_1_8(0.9);
        program.Task_1_9(0.9);
        program.Task_1_10(0.9);
        program.Task_2_1(10);
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
        double r = 2;
        if (Math.Abs((x*x) + (y*y) - (r*r)) <= (1/(10*10*10)))
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
        if ((y >= 0)&&(y + Math.Abs(x) <= 1))
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        double c = 0;
        if (a > 0)
        {
            if (a >= b) { answer = a; }
            else
            {
                answer = b;
            }
        }
        else
        {
            if (a <= b) { answer = a; }
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
        if (a <= b)
        {
            if (c >= a) { answer = c; }
            else { answer = a; }
        }
        else
        {
            if (c >= b) { answer = c; }
            else { answer = b; }
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double d_r = Math.Sqrt((r * 4) / 3.14);
        double d_s = Math.Sqrt(s) * Math.Sqrt(2);
        if (d_s <= d_r)
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
        double d_r = Math.Sqrt((r * 4) / 3.14);
        double d_s = Math.Sqrt(s);
        if (d_s >= d_r)
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
        if (Math.Abs(x) >= 1)
        {
            answer = 0;
        }
        else
        {
            answer = (x*x) - 1;
        }
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
        {
            answer = 0;
        }
        else if (x > -1 && x <= 0)
        {
            answer = 1 + x;
        }
        else
        {
            answer = 1; 
        }
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
        else if (x > -1 && x <= 1)
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
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        //n = 10;
        double sum = 0, x = 0;
        for (int t = 0; t < 10; t++)
        {
            double.TryParse(Console.ReadLine(), out x);
            sum += x;
        }
        sum /= n;
        answer = sum;
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        //int n = 5;
        double x = 0, y = 0;// r = 1.5, a = 1.5, b = 1;
        for (int t = 0; t < n; t++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (((x - a) * (x - a)) + ((y - b) * (y - b)) <= r * r)
            {
                answer++;
            }
        }
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        //int n = 6;
        double weight = 0, col = 0;
        for (int t = 0; t < n; t++)
        {
            double.TryParse(Console.ReadLine(), out weight);

            if (weight < 30)
            {
                col += 200;
            }
        }
        answer = col / 1000;
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x = 0, y = 0;// r1 = 1, r2 = 3;
        for (int t = 0; t < n; t++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (((x * x + y * y) >= r1 * r1) && ((x * x + y * y) <= r2 * r2))
            {
                answer++;
            }
        }
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double x = 0;// norm = 30;
        for (int t = 0; t < n; t++)
        {
            double.TryParse(Console.ReadLine(), out x);

            if (x <= norm)
            {
                answer++;
            }
        }
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x = 0, y = 0;
        for (int t = 0; t < n; t++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);

            if ((x >= 0) && (x <= Math.PI) && (Math.Sin(x) >= y) && (y >= 0))
            {
                answer++;
            }
        }
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here

        double x = 0, y = 0;
        for (int t = 0; t < n; t++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);

            if (x > 0 && y > 0)
            {
                answer1++;
                Console.WriteLine("лежит в 1-ом квадранте");
            }
            else if (x < 0 && y < 0)
            {
                answer3++;
                Console.WriteLine("лежит в 3-ем квадранте");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("лежит во 2-ом квадранте");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("лежит в 4-ом квадранте");
            }
        }
        // end
        Console.WriteLine("лежит в 1-ом квадранте: {0} ", answer1);
        Console.WriteLine("лежит в 3-ем квадранте: {0} ", answer3);
        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double d = 0, x = 0, y = 0;
        for (int t = 1; t <= n; t++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            x = Math.Abs(x);
            y = Math.Abs(y);
            if (Math.Sqrt(x * x + y * y) < answerLength)
            {
                answer = t;
                d = Math.Sqrt(x * x + y * y);
            }
        }

        answerLength = Math.Round(d, 2);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double x = 0;
        for (int t = 0; t < n; t++)
        {
            double.TryParse(Console.ReadLine(), out x);
            if (x < answer)
            {
                answer = x;
            }
        }
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        double x = 0, t = 1, prov = 0;
        while (t <= n * 4)
        {
            double.TryParse(Console.ReadLine(), out x);
            if (x < 4)
            {
                prov++;
            }
            if (t % 4 == 0)
            {
                if (prov == 0)
                {
                    answer++;
                }
                else
                {
                    prov = 0;
                }
            }
            t++;
        }
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double x = 0, t = 0, kol = 0, dvoika = 0;
        while (t < n * 4)
        {

            double.TryParse(Console.ReadLine(), out x);
            kol += x;
            if (x == 2) { dvoika += 1; }
            if (t % 4 == 0)
            {
                if (dvoika > 0)
                {
                    answer++;
                    dvoika = 0;
                }
                else
                {
                    dvoika = 0;
                }
            }
            t++;
        }
        avg = kol / (4 * n);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r > 0)
        {
            switch (type)
            {
                case 0:
                    answer = Math.Round((r * r), 2);
                    break;
                case 1:
                    answer = Math.Round((r * r * Math.PI), 2);
                    break;
                case 2:
                    answer = Math.Round(((Math.Sqrt(3) * (r * r)) / 4), 2);
                    break;
                default:
                    break;
            }
        }
       
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A > 0 && B > 0)
        {
            switch (type)
            {
                case 0:
                    answer = Math.Round((A * B), 2);
                    break;
                case 1:
                    answer = Math.Round(Math.Abs((A * A * Math.PI) - (B * B * Math.PI)), 2);
                    break;
                case 2:
                    answer = Math.Round(((A * (Math.Sqrt(B * B - ((A * A) / 4)))) / 2), 2);
                    break;
                default:
                    break;
            }
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
        double weight = 0, col = 0;

        while (n == 0)
        {
            double.TryParse(Console.ReadLine(), out weight);
            if (weight != 0)
            {
                if (weight < 30 && weight != 0)
                {
                    col += 200;
                }
            }
            else { n++; }
        }

        answer = col / 1000;
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
        double x = 0, y = 0;
        while (n == 0)
        {
            double.TryParse(Console.ReadLine(), out x);
            if (x == 1000)
            {
                n++;
                break;
            }
            double.TryParse(Console.ReadLine(), out y);

            if ((x >= 0) && (x <= Math.PI) && (Math.Sin(x) >= y))
            {
                answer++;
            }
        }
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
        double x = 0;
        while (n == 0)
        {
            double.TryParse(Console.ReadLine(), out x);
            if (x == 1000)
            {
                n++;
                break;
            }
            else
            {
                if (x < answer)
                {
                    answer = x;
                }
            }
        }
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