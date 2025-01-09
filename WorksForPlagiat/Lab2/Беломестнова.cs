
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Net;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
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
        //program.Task_2_6(3);
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
        double s = x * x + y * y - r * r;
        if (Math.Abs(s) <= Math.Pow(10, -3))
            answer = true;
        else
            answer = false;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && y + Math.Abs(x) <= 1)
            answer = true;
        else
            answer = false;
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
                answer = a;
            else
                answer = b;
        }
        else
        {
            if (a < b)
                answer = a;
            else
                answer = b;
        }

        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here

        if (a < b)
        {

            if (a > c)
            {
                answer = a;
            }
            else
            {
                answer = c;
            }
        }
        else
        {

            if (b > c)
            {
                answer = b;
            }
            else
            {
                answer = c;
            }
        }


        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double a = Math.Sqrt(s);
        double d = Math.Sqrt(2) * a;
        double y = Math.Sqrt(r / Math.PI);
        if (d <= 2 * y)
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
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double a = Math.Sqrt(s);
        double y = Math.Sqrt(r / Math.PI);
        if (a >= 2 * y)
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
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if ((Math.Abs(x)) > 1)
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
        if (-1 < x && x <= 1)
        {
            answer = -1 * x;
        }
        if (x > 1)
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
        int i = 1;
        double s = 0;
        double d = 0;
        double r = 0;
        while (i <= n)
        {
            double.TryParse(Console.ReadLine(), out r);
            s += r;
            i++;
        }
        d = s / n;
        answer = d;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x = 0, y = 0;

        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (Math.Sqrt((x - a) * (x - a) + (y - b) * (y - b)) <= r)
            {
                answer++;
            }

        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double m = 0;
        double v = 0;
        for (int i = 1; i <= n; i++)
        {
            v = double.Parse(Console.ReadLine());
            if (v < 30)
            {
                m += 0.2;
            }

        }

        answer = m;
        Console.WriteLine(answer);
        // end


        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double y = 0;
        double x = 0;
        for (int i = 0; i < n; i++)
        {
            x = double.Parse((Console.ReadLine()));
            y = double.Parse((Console.ReadLine()));
            if ((x * x + y * y >= r1 * r1) && (x * x + y * y <= r2 * r2))
            {
                answer++;
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
        double sport = 0;

        for (int i = 0; i < n; i++)
        {
            sport = double.Parse(Console.ReadLine());
            if (sport <= norm)
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
        double x = 0;
        double y = 0;
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse((Console.ReadLine()));
            if (y >= 0 && x >= 0 && x <= Math.PI && Math.Sin(x) >= y)
            {
                answer++;
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
        double x = 0;
        double y = 0;
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse((Console.ReadLine()));
            if (x > 0 && y > 0)
            {
                answer1++;
                //Console.WriteLine($"{i} точка в I квадранте");
            }
            /* if (x < 0 && y > 0)
                Console.WriteLine($"{i} точка в II квадранте");*/

            if (x < 0 && y < 0)
            {
                //Console.WriteLine($"{i} точка в III квадранте");
                answer3++;
            }
            /* if ( x > 0 && y < 0)
                 //Console.WriteLine($"{i} точка в IV квадранте");*/

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
        double m = double.MaxValue;
        double x = 0;
        double y = 0;
        int z = 0;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            double d = Math.Sqrt(x * x + y * y);
            if (d < m)
            {
                m = d;
                z = i;
            }
        }
        answer = z;
        answerLength = Math.Round(m, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double sport = 0;
        double rast = 100000;

        for (int i = 0; i < n; i++)
        {
            sport = double.Parse(Console.ReadLine());
            if (sport < rast)
            {
                rast = sport;
            }
        }
        answer = rast;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        double m1 = 0;
        double m2 = 0;
        double m3 = 0;
        double m4 = 0;
        for (int i = 0; i < n; i++)
        {
            m1 = double.Parse(Console.ReadLine());
            m2 = double.Parse(Console.ReadLine());
            m3 = double.Parse(Console.ReadLine());
            m4 = double.Parse(Console.ReadLine());
            if (m1 == 2 || m1 == 3 || m2 == 2 || m2 == 3 || m3 == 2 || m3 == 3 || m4 == 2 || m4 == 3)
            {
                continue;
            }
            else
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
        int m1 = 0;
        int m2 = 0;
        int m3 = 0;
        int m4 = 0;
        for (int i = 0; i < n; i++)
        {
            m1 = int.Parse(Console.ReadLine());
            m2 = int.Parse(Console.ReadLine());
            m3 = int.Parse(Console.ReadLine());
            m4 = int.Parse(Console.ReadLine());
            if (m1 == 2 || m2 == 2 || m3 == 2 || m4 == 2)
            {
                answer++;
            }
            avg += m4 + m1 + m3 + m2;
        }
        avg = avg / (n * 4);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r < 0) return 0;
        switch (type)
        {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = Math.PI * r * r;
                break;
            case 2:
                answer = (r * r * Math.Sqrt(3)) / 4;
                break;
            default:
                break;
        }
        answer = Math.Round(answer, 2);
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
                    answer = A * B;
                    break;
                case 1:
                    answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                    break;
                case 2:
                    answer = (A * Math.Sqrt(B * B - A * A / 4)) / 2;
                    break;
                default:
                    break;
            }
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
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
        double x = 0;
        double y = 0;
        while (true)
        {
            string f = Console.ReadLine();
            if (f == "-")
            {
                break;
            }
            else
            {
                double.TryParse(f, out x);
                y = double.Parse(Console.ReadLine());
                if (Math.Sqrt((x - a) * (x - a) + (y - b) * (y - b)) <= r)
                {
                    answer++;
                }
            }
        }
        Console.WriteLine(answer);
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
        double sport = 0;
        while (true)
        {
            string f = Console.ReadLine();
            if (f == "-")
            {
                break;
            }
            else
            {
                double.TryParse(f, out sport);
                if (sport <= norm)
                {
                    answer++;
                }
            }
        }
        Console.WriteLine(answer);


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
        double m = double.MaxValue;
        double x = 0;
        double y = 0;
        int z = 0;
        int i = 0;
        while (true)
        {
            string f = Console.ReadLine();
            if (f == "-")
            {
                if (i == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    m = Math.Round(m, 2);
                    answerLength = m;
                    answer = i;
                    Console.WriteLine(answer);
                    Console.WriteLine(answerLength);
                }
                break;
            }
            else
            {
                double.TryParse(f, out x);
                f = Console.ReadLine();
                double.TryParse(f, out y);

                double d = Math.Sqrt(x * x + y * y);
                i++;
                if (d < m)
                {
                    m = d;
                    z = i;
                }
            }
        }
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
        double m1 = 0;
        double m2 = 0;
        double m3 = 0;
        double m4 = 0;
        while (true)
        {
            string f = Console.ReadLine();
            if (f == "-")
            {
                if (n > 0)
                {
                    avg = avg / (n * 4);
                    Console.WriteLine(answer);
                    Console.WriteLine(avg);
                    break;
                }
            }
            m1 = double.Parse(f);
            m2 = double.Parse(Console.ReadLine());
            m3 = double.Parse(Console.ReadLine());
            m4 = double.Parse(Console.ReadLine());

            n++;

            if (m1 == 2 || m2 == 2 || m3 == 2 || m4 == 2)
            {
                answer++;
            }
            avg += m4 + m1 + m3 + m2;
        }



        // end

        return (answer, avg);
    }
    #endregion
}
