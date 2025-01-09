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
        double r = 2;
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
            answer = true;
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
            if (a > b)
            {
                answer = b;
            }
            else
            {
                answer = a;
            }
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double mn = 0;
        if (a < b)
        {
            mn = a;
        }
        else
        {
            mn = b;
        }
        if (c > mn)
        {
            answer = c;
        }
        else
        {
            answer = mn;
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double R = r / (2 * Math.PI);
        double S = Math.Sqrt(s * 2);
        if (R >= S)
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
        double R = Math.Sqrt(r / (Math.PI));
        double S = Math.Sqrt(s) / 2;
        if (R <= S)
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
        for (int i = 0; i < n; i++)
        {
            answer += double.Parse(Console.ReadLine());
        }
        answer /= n;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x, y;

        // code here
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
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
        double m;

        // code here
        for (int i = 0; i < n; i++)
        {
            m = double.Parse(Console.ReadLine());
            if (m < 30.0)
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
        double x, y;
        // code here
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x * x + y * y >= r1 * r1 && x * x + y * y <= r2 * r2)
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
        double res;

        // code here
        for (int i = 0; i < n; i++)
        {
            res = double.Parse(Console.ReadLine());
            if (res <= norm)
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
        double x, y;
        // code here
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
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
        double x, y;
        // code here
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("1");
                answer1++;
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("3");
                answer3++;
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("4");
            }
        }
        Console.WriteLine($"{answer1}, {answer3}");
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        double x, y, r;


        // code here
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            r = Math.Sqrt(x * x + y * y);
            if (r < answerLength)
            {
                answerLength = r;
                answer = i;
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength, 2));
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double time;
        // code here
        for (int i = 1; i <= n; i++)
        {
            time = double.Parse(Console.ReadLine());
            if (time < answer)
            {
                answer = time;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        int k, mark;

        // code here;
        for (int i = 0; i < n; i++)
        {
            k = 0;
            for (int j = 0; j < 4; j++)
            {
                mark = int.Parse((Console.ReadLine()));
                if (mark == 2 || mark == 3)
                {
                    k++;
                }
            }
            if (k == 0)
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
        int k, mark = 0;
        // code here;
        for (int i = 1; i <= n; i++)
        {
            k = 0;
            for (int j = 0; j < 4; j++)
            {
                mark = int.Parse((Console.ReadLine()));
                avg += mark;
                if (mark == 2)
                {
                    k = 1;
                }
            }
            if (k == 1)
            {
                answer++;
            }
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
        if (r > 0)
        {
            switch (type)
            {
                case 0: answer = r * r; break;
                case 1: answer = Math.PI * r * r; break;
                case 2: answer = (r * r * Math.Sqrt(3)) / 4; break;
                default: break;
            }
            answer = Math.Round(answer, 2);
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
                case 0: answer = A * B; break;
                case 1: answer = Math.Abs(Math.PI * A * A - Math.PI * B * B); break;
                case 2:
                    {
                        if (B + B > A)
                        {
                            double h = Math.Sqrt(B * B - A * A / 4);
                            answer = A * h / 2;
                        }
                        break;
                    }
                default: break;
            }
            answer = Math.Round(answer, 2);
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
        string st;
        // code here
        while (true)
        {
            st = Console.ReadLine();
            if (st == "stop")
            {
                break;
            }
            answer += int.Parse(st);
            n++;
        }
        answer /= n;
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
        double x, y, k;
        string strX, strY;
        while (true)
        {
            strX = Console.ReadLine();
            if (strX == "stop")
            {
                break;
            }
            strY = Console.ReadLine();
            if (strY == "stop")
            {
                break;
            }
            double.TryParse(strX, out x);
            double.TryParse(strY, out y);
            k = x * x + y * y;
            if (k >= r1 * r1 && k <= r2 * r2)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
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
        string strX, strY;
        while (true)
        {
            strX = Console.ReadLine();
            if (strX == "stop")
            {
                break;
            }
            strY = Console.ReadLine();
            if (strY == "stop")
            {
                break;
            }
            double.TryParse(strX, out x);
            double.TryParse(strY, out y);
            if (x > 0 && y > 0)
            {
                answer1++;
            }
            else if (x < 0 && y < 0)
            {
                answer3++;
            }
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
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
        int mark;
        bool yes, no;
        string str;
        while (true)
        {
            no = false;
            yes = true;
            for (int j = 0; j < 4; j++)
            {
                str = Console.ReadLine();
                if (str == "stop")
                {
                    no = true;
                    break;
                }
                int.TryParse(str, out mark);
                if (mark == 2 || mark == 3)
                {
                    yes = false;
                }
            }
            if (no)
            {
                break;
            }
            if (yes)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
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