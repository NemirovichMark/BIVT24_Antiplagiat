using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
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
        if (Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -3))
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

        if (y >= 0 && (y + Math.Abs(x)) <= 1)
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

        answer = a;
        if (a > 0)
        {
            if (b > a)
            {
                answer = b;
            }
        }
        else
        {
            if (b < a)
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

        double j = 0;
        // code here

        if (a <= b)
        {
            j = a;
        }
        else { j = b; }
        if (j >= c)
        {
            answer = j;
        }
        else { answer = c; }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here

        double x = Math.Pow(2 * s, 0.5);
        double y = 2 * Math.Pow(Math.PI * r, 0.5) / Math.PI;
        if (x <= y)
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
        double x, y;
        double pi = 3.14;
        x = Math.Sqrt(r / pi);
        y = Math.Sqrt(s) / 2;
        if (x <= y)
            answer = true;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        x = Math.Abs(x);
        if (x > 1)
        {
            answer = 1;
        }
        else
        {
            answer = x;
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
        else { answer = x * x - 1; }
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here

        if (x <= -1)
            answer = 0;
        else if (x <= 0)
            answer = 1 + x;
        else
            answer = 1;
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
        else { answer = -1; }
        // end

        return answer;
    }
    #endregion
    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here

        double x = 0;
        for (int i = 0; i <= n - 1; i++)
        {
            x += double.Parse(Console.ReadLine());
        }
        answer = x / n;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here

        double x, y;
        for (int i = 0; i < n; i++)
        {
            y = double.Parse(Console.ReadLine());
            x = double.Parse(Console.ReadLine());
            if (Math.Pow((x - a), 2) + Math.Pow((y - b), 2) <= r * r)
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

        double weig;
        for (int i = 0; i < n; i++)
        {
            weig = double.Parse(Console.ReadLine());
            if (weig < 30.0)
            {
                answer += 0.2;
            }
        }
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here

        for (int i = 0; i <= n - 1; i++)
        {
            if (r1 > r2)
            {
                Console.WriteLine("r1 > r2; it is not correct");
                break;
            }
            if (r1 == r2)
            {
                Console.WriteLine("r1 == r2; it is not correct");
                break;
            }
            if (r1 < r2)
            {
                double x, y;
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());
                if (x * x + y * y >= r1 * r1 && x * x + y * y <= r2 * r2)
                {
                    answer++;
                }
            }
        }
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here

        for (int i = 0; i < n; i++)
        {
            double a = double.Parse(Console.ReadLine());
            if (a <= norm)
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

        for (int i = 0; i <= n - 1; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (0 <= x && x <= Math.PI && 0 <= y && y <= Math.Sin(x))
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

        for (int i = 0; i <= (n - 1); i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("1");
                answer1++;
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("2");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("3");
                answer3++;
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("4");
            }
            if (x * y == 0)
            {
                Console.WriteLine("в начале координат");
            }
        }
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here

        if (n > 0)
        {
            for (int i = 0; i <= (n - 1); i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double l = Math.Pow(x * x + y * y, 0.5);
                if (l <= answerLength)
                {
                    answerLength = l;
                    answer = i;
                }
            }
            answer += 1;
        }
        if (n <= 0)
        {
            answerLength = 0;
            answer = 0;
        }

        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here

        if (n > 0)
        {
            for (int i = 0; i <= n - 1; i++)
            {
                double a = double.Parse(Console.ReadLine());
                if (a <= answer)
                {
                    answer = a;
                }
            }
        }
        else { Console.WriteLine("pls no jokes"); }
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        double a1 = double.Parse(Console.ReadLine());
        double a2 = double.Parse(Console.ReadLine());
        double a3 = double.Parse(Console.ReadLine());
        double a4 = double.Parse(Console.ReadLine());
        if (a1 > 3 && a2 > 3 && a3 > 3 && a4 > 3)
            answer++;
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double a = 0.0;

        // code here;

        for (int i = 0; i <= n - 1; i++)
        {
            int b = 0;
            for (int j = 1; j <= 4; i++)
            {
                int oc = int.Parse(Console.ReadLine());
                if (oc == 2)
                {
                    b += 1;
                }
                a += oc;
            }
            if (b != 0)
            {
                answer += 1;
            }
        }
        a = a / n;
        // end

        return (answer, a);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r > 0)
            switch (type)
            {
                case 0:
                    answer = r * r;
                    break;
                case 1:
                    answer = Math.PI * r * r;
                    break;
                case 2:
                    answer = r * r * Math.Sqrt(3) / 4;
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

        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.PI * Math.Abs(A * A - B * B);
                break;
            case 2:
                answer = A * Math.Sqrt(4 * B * B - A * A) / 4.0;
                break;
        }
        if (type < 0 || type > 2 || A * B <= 0 || A + B <= 0)
        {
            answer = 0;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    #endregion
    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;
        int a = 0;
        // code here
        double x, s = 0;
        do
        {
            double.TryParse(Console.ReadLine(), out x);
            if (x == 0) break;
            s += x;
            n += 1;
        } while (x > 0);
        answer = s / n;
        Console.WriteLine($"{answer}");
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
        double x, y, s;
        string stop1, stop2;
        while (true)
        {
            stop1 = Console.ReadLine();
            if (stop1 == "stop") break;
            stop2 = Console.ReadLine();
            if (stop2 == "stop") break;
            double.TryParse(stop1, out x);
            double.TryParse(stop2, out y);
            s = x * x + y * y;
            if (s >= r1 * r1 && s <= r2 * r2) answer++;
        }

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
        double x, y;
        string stop1, stop2;
        string X1, Y1;
        while (true)
        {
            stop1 = Console.ReadLine();
            if (stop1 == "stop") break;
            stop2 = Console.ReadLine();
            if (stop2 == "stop") break;
            double.TryParse(stop1, out x);
            double.TryParse(stop2, out y);

            X1 = Console.ReadLine();
            if (X1 == "stop") break;
            Y1 = Console.ReadLine();
            if (Y1 == "stop") break;
            double.TryParse(X1, out x);
            double.TryParse(Y1, out y);
            if (x > 0 && y > 0) answer1++;
            else if (x < 0 && y < 0) answer3++;
        }

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
        for (int i = 0; i < n; i++)
        {
            bool yes = true;
            for (int j = 0; j < 4; j++)
            {
                double oc;
                double.TryParse((Console.ReadLine()), out oc);
                if (oc < 0 || oc > 5) return answer;
                if (oc == 2 || oc == 3) yes = false;
            }
            if (yes) answer++;
        }
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
