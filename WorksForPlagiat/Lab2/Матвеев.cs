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
        double rav = 1 / 10 * 10 * 10;
        if (Math.Abs(x*x + y*y - r*r) <= rav)
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
            answer = true;
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
            answer = Math.Max(a, b);
        }
        else
        {
            answer = Math.Min(a, b);
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        answer = Math.Max(Math.Min(a, b), c);
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if ((2 * (Math.Sqrt(r / Math.PI))) >= Math.Sqrt(s * 2))
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
        if ((2 * (Math.Sqrt(r / Math.PI))) <= Math.Sqrt(s))
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
            answer = x * x - 1;
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
        if (-1 < x && x <= 0)
        {
            answer = 1 + x;
        }
        if (x > 0)
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
        else if (-1 < x && x <= 1)
        {
            answer = -x;
        }
        else if (x > 1)
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
        n = int.Parse(Console.ReadLine());
        int v = n;
        double sum = 0;

        for (int i = 1; i <= v; i++)
        {
            sum += double.Parse(Console.ReadLine());
        }
        answer = sum / v;
        // end
        Console.WriteLine(answer);
        Console.ReadLine();
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x, y;
        while (n > 0)
        {
            n--;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ((Math.Sqrt((x - a)*(x - a) + (y - b)*(y - b))) <= r)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        Console.ReadLine();
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        n = int.Parse(Console.ReadLine());
        int v = n;
        double sum = 0;

        for (int i = 1; i <= v; i++)
        {
            double ves = double.Parse(Console.ReadLine());
            if (ves < 30)
            {
                sum += 0.2;
            }

        }
        answer = sum;
        Console.WriteLine(answer);
        Console.ReadLine();
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        while (n > 0)
        {
            n--;
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (((x*x + y*y) > r1*r1) && ((x*x + y*y) < r2*r2))
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        Console.ReadLine();
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        while (n > 0)
        {
            n--;
            if (double.Parse(Console.ReadLine()) <= norm) answer++;
        }
        // end
        Console.WriteLine(answer);
        Console.ReadLine();

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        while (n > 0)
        {
            n--;
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((x >= 0) && (x <= Math.PI) && (y >= 0) && (Math.Sin(x) >= y))
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        Console.ReadLine();
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        while (n > 0)
        {
            n--;
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x * y > 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("I quadrant");
                    answer1++;
                }
                else
                {
                    Console.WriteLine("III quadrant");
                    answer3++;
                }
            }
            else
            {
                if (x > 0 && y < 0) Console.WriteLine("IV quadrant");
                else Console.WriteLine("II quadrant");
            }
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        Console.ReadLine();
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here

        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double c = Math.Sqrt(x * x + y * y);
            if (c < answerLength)
            {
                answerLength = c;
                answer = i;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        Console.ReadLine();
        // end

            return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        while (n > 0)
        {
            n--;
            double res = double.Parse(Console.ReadLine());
            if (res < answer) answer = res;
        }
        // end
        Console.WriteLine(answer);
        Console.ReadLine();
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        // code here;

        int kurkuma, i;
        double ocenka;
        while (n > 0)
        {
            n--;
            i = 4;
            kurkuma = 0;
            while (i > 0)
            {
                i--;
                ocenka = double.Parse(Console.ReadLine());
                if (ocenka > 3)
                {
                    kurkuma++;
                }
            if (kurkuma == 4)
                {
                    answer++;
                }
            }
        }
        // end
        Console.WriteLine(answer);
        Console.ReadLine();
        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        int f = n;
        while (n > 0)
        {
            n--;
            int pikmi = 4;
            int kurkuma = 0;
            while (pikmi > 0)
            {
                pikmi--;
                int ocenka = int.Parse(Console.ReadLine());
                avg += ocenka;
                if (ocenka == 2)
                {
                    kurkuma++;
                }
            }
            if (kurkuma > 0)
            {
                answer++;
            }
        }
        avg /= 4 * f;
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        Console.ReadLine();
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r <= 0) return 0;
        switch (type)
        {
            case 0: answer = Math.Round(r * r, 2); break;
            case 1: answer = Math.Round(Math.PI * r * r, 2); break;
            case 2: answer = Math.Round((r * r * Math.Sqrt(3) / 4), 2); break;
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
        switch (type)
        {
            case 0: answer = Math.Round(A * B, 2); break;
            case 1: answer = Math.Round(Math.Abs(Math.PI * (A * A - B * B)), 2); break;
            case 2: answer = Math.Round(A / 4 * Math.Sqrt(4 * B * B - A * A), 2); break;
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
        double q = double.Parse(Console.ReadLine());
        double sum = 0;

        while (q != 0)
        {
            sum += q;
            q = double.Parse(Console.ReadLine());
            n++;

        }
        answer = sum / n;

        Console.WriteLine(answer);
        Console.ReadLine();
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

        // end

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        while (y != 9999)
        {
            if (((x * x + y * y) > r1 * r1) && ((x * x + y * y) < r2 * r2))
            {
                answer++;
            }
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
        }
        Console.WriteLine(answer);
        Console.ReadLine();
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

        // end

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        while (y != 9999)
        {
            if (x * y > 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("I quadrant");
                    answer1++;
                }
                else
                {
                    Console.WriteLine("III quadrant");
                    answer3++;
                }
            }
            else
            {
                if (x > 0 && y < 0) Console.WriteLine("IV quadrant");
                else Console.WriteLine("II quadrant");
            }
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        Console.ReadLine();
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

        // end

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;
        int kurkuma, i;
        double ocenka = double.Parse(Console.ReadLine());
        while (ocenka != 52)
        {
            i = 4;
            kurkuma = 0;
            while (i > 0)
            {
                i--;
                if (ocenka > 3)
                {
                    kurkuma++;
                }
                ocenka = double.Parse(Console.ReadLine());
            }
            if (kurkuma == 4)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        Console.ReadLine();
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