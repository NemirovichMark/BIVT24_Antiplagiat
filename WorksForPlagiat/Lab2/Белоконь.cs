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
        program.Task_3_3();
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
        int r = 2;
        answer = Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -3);
        // code here

        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;
        answer = y >= 0 && y + Math.Abs(x) <= 1;
        // code here

        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;
        if (a > 0) answer = a > b ? a : b;
        else answer = a < b ? a : b;
        // code here

        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        double minab = a < b ? a : b;
        answer = minab > c ? minab : c;
        // code here

        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;
        answer = 2 * (Math.Sqrt(r / Math.PI)) >= Math.Sqrt(s * 2);

        // code here

        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;
        answer = 2 * (Math.Sqrt(r / Math.PI)) <= Math.Sqrt(s);
        // code here

        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;
        answer = Math.Abs(x) > 1 ? 1 : Math.Abs(x);
        // code here

        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;
        answer = Math.Abs(x) >= 1 ? 0 : x * x - 1;
        // code here

        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;
        if (x <= -1) answer = 0;
        else if (-1 < x && x <= 0) answer = 1 + x;
        else answer = 1;
        // code here

        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;
        if (x <= -1) answer = 1;
        else if (-1 < x && x <= 1) answer = -x;
        else answer = -1;
        // code here

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        for (int i = 1; i <= n; i++) answer += double.Parse(Console.ReadLine());
        answer /= n;
        Console.WriteLine(answer);
        // code here

        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        for(int i = 1; i <= n; i++)
        {
            double cor1 = double.Parse(Console.ReadLine());
            double cor2 = double.Parse(Console.ReadLine());
            if ((cor1 - a) * (cor1 - a) + (cor2 - b) * (cor2 - b) <= r * r) answer++;
        }
        Console.WriteLine(answer);
        // code here

        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        for(int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            if (x < 30) answer += 0.2;
        }
        Console.WriteLine(answer);
        // code here

        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (((x * x + y * y) >= r1 * r1) && (x * x + y * y) <= r2 * r2) answer++;
        }
        Console.WriteLine(answer);

        // code here

        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            if (x <= norm) answer++;
        }
        Console.WriteLine(answer);

        // code here

        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x)) answer++;

        }
        Console.WriteLine(answer);

        // code here

        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
        int kv = 0;
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x>0 && y > 0)
            {
                kv = 1;
                answer1++;
            }
            else if(x<0 && y > 0)
            {
                kv = 2;
            }
            else if (x<0 && y < 0)
            {
                kv = 3;
                answer3++;
            }
            if (x>0 && y < 0)
            {
                kv = 4;
            }
            Console.WriteLine(kv);

        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);


        // code here

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        for(int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double ln = Math.Sqrt(x*x+y*y);
            if (ln < answerLength)
            {
                answer = i;
                answerLength = ln;
            }  
        }
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength, 2));

        // code here

        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            if (x < answer) answer = x;

        }
        Console.WriteLine(answer);

        // code here

        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        for(int i = 1; i <= n; i++)
        {
            bool flg = true;
            for(int j = 1; j <= 4; j++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x < 4) flg = false;
            }
            if (flg) answer++;
        }
        Console.WriteLine(answer);
        // code here;

        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        for (int i = 1; i <= n; i++)
        {
            bool flg = false;
            for (int j = 1; j <= 4; j++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == 2) flg = true;
                avg += x;
            }
            if (flg) answer++;
        }
        avg = avg / (n * 4);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // code here;

        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        if (r <= 0) return 0;
        switch (type)
        {
            case 0: answer = r * r;break;
            case 1: answer = Math.PI * r * r; break;
            case 2: answer = r * r * Math.Sqrt(3) / 4;break;
            default: answer = 0;break;
        }
        answer = Math.Round(answer, 2);
        // code here;

        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        if (A <= 0) return 0;
        else if (B <= 0) return 0;
        switch (type)
        {
            case 0: answer = A * B; break;
            case 1: answer = Math.Abs(Math.PI * A * A - Math.PI * B * B); break;
            case 2: double xeops = (A + B + B) / 2; answer = Math.Sqrt(xeops * (xeops - A) * (xeops - B) * (xeops - B)); break;
            default: answer = 0; break;
        }
        answer = Math.Round(answer, 2);
        // code here;

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
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out double a);
            if (a != 0)
            {
                if (a < 30 && a > 0)
                {
                    answer += 0.2;
                }
                else if (a ==0)
                {
                    break;
                }                              
            }
        }
        // end
        Console.WriteLine(answer);
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

        // end

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;
        for (int i = 1; ; i++)
        {
            string input_x = Console.ReadLine();
            if (input_x == "stop")
            {
                break;
            }
            double.TryParse(input_x, out double x);
            double.TryParse(Console.ReadLine(), out double y);
            if (x >= 0 && x <= Math.PI && Math.Sin(x) >= y)
            {
                answer += 1;
            }

        }
        Console.WriteLine(answer);
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

        // end

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;
        for (int i = 1; ; i++)
        {
            string input = Console.ReadLine();
            if (input == "stop") break;
            double.TryParse(input, out double res);
            if (res < answer) answer = res;         
        }
        Console.WriteLine(answer);
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

        // end

        return (answer, avg);
    }
    #endregion
}