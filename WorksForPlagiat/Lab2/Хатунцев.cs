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
        //program.Task_1_5(6, 9);
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
        //program.Task_2_10(5);
        //program.Task_2_11(2);
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
        program.Task_3_7();
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

        double r = 2.0;
        answer = Math.Abs(Math.Sqrt(x) + Math.Sqrt(y) - Math.Sqrt(r)) <= Math.Pow(10.0, -3);

        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here

        answer = y >= 0 && y + Math.Abs(x) <= 1;

        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here

        if (a > 0)
        {
            if (a >= b)
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
            if (a >= b)
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

        double mn;

        if (a < b)
        {
            mn = a;
        }
        else
        {
            mn = b;
        }

        if (mn > c)
        {
            answer = mn;
        }
        else
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

        double a, b;

        b = Math.Pow(r / Math.PI, 0.5);
        a = Math.Pow(s, 0.5);

        answer = a <= b * Math.Pow(2, 0.5);

        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here

        double a, b;

        b = Math.Pow(r / Math.PI, 0.5) * 2;
        a = Math.Pow(s, 0.5);

        answer = b <= a;

        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here

        if (Math.Abs(x) > 1)
        {
            answer = 1.0;
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
            answer = Math.Pow(x, 2) - 1;
        }

        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here

        if (x <= -1.0)
        {
            answer = 0.0;
        }
        else if (x > 0)
        {
            answer = 1.0;
        }
        else
        {
            answer = 1.0 + x;
        }

        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here

        if (x <= -1.0)
        {
            answer = 1.0;
        }
        else if (x > 1.0)
        {
            answer = -1.0;
        }
        else
        {
            answer = -1.0 * x;
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

        double ch, fh;
        fh = 0.0;

        for (int i = 0; i < n; i++)
        {
            ch = double.Parse(Console.ReadLine());
            fh += ch;
        }

        answer = fh / n;
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
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
            {
                answer ++;
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

        double cw;

        for (int i = 0; i < n; i++)
        {
            cw = double.Parse(Console.ReadLine());
            if (cw < 30) 
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

        double x, y;

        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            if (((x * x + y * y) >= (r1 * r1)) && ((x * x + y * y) <= (r2 * r2)))
            {
                answer ++;
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

        for (int i = 0; i < n; i++)
        {
            if (double.Parse(Console.ReadLine()) <= norm)
            {
                answer ++;
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

        double x, y;

        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            if ((x >= 0) && (y >= 0) && (x <= Math.PI) && (y <= Math.Sin(x)))
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

        double x, y;
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
            else if(x < 0 && y < 0)
            {
                Console.WriteLine("3");
                answer3++;
            }
            else
            {
                Console.WriteLine("4");
            }
        }

        Console.Write(answer1 + " ");
        Console.Write(answer3);

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here

        double x, y;

        for (int i = 1; i < n + 1; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            double cl;
            cl = Math.Sqrt(x * x + y * y);

            if (cl < answerLength)
            {
                answerLength = cl;
                answer = i;
            }
        }

        Console.Write(answer + " ");
        Console.Write(answerLength);

        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here

        double cs;

        for (int i = 0; i < n; i++)
        {
            cs = double.Parse(Console.ReadLine());

            if (cs < answer)
            {
                answer = cs;
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

        int o1, o2, o3, o4;
        bool f = true;

        for (int i = 0; i < n; i++)
        {
            o1 = int.Parse(Console.ReadLine());
            if (o1 == 2 || o1 == 3)
            {
                f = false;
            }
            o2 = int.Parse(Console.ReadLine());
            if (o2 == 2 || o2 == 3)
            {
                f = false;
            }
            o3 = int.Parse(Console.ReadLine());
            if (o3 == 2 || o3 == 3)
            {
                f = false;
            }
            o4 = int.Parse(Console.ReadLine());
            if (o4 == 2 || o4 == 3)
            {
                f = false;
            }

            if (f)
            {
                answer++;
            }

            f = true;
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

        int o1, o2, o3, o4;
        double cs = 0.0;
        bool f = false;

        for (int i = 0; i < n; i++)
        {
            o1 = int.Parse(Console.ReadLine());
            if (o1 == 2)
            {
                f = true;
            }
            o2 = int.Parse(Console.ReadLine());
            if (o2 == 2)
            {
                f = true;
            }
            o3 = int.Parse(Console.ReadLine());
            if (o3 == 2)
            {
                f = true;
            }
            o4 = int.Parse(Console.ReadLine());
            if (o4 == 2)
            {
                f = true;
            }

            cs += o1 + o2 + o3 + o4;

            if (f)
            {
                answer++;
            }

            f = false;
        }

        avg = (double)cs / ((double)n * 4.0);

        Console.Write(answer + " ");
        Console.Write(avg);

        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;

        if (r <= 0)
        {
            return 0;
        }

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

        if (A <= 0 || B <= 0)
        {
            return 0;
        }

        switch (type)
        {
            case 0: 
                answer = A * B; 
                break;
            case 1: 
                answer = Math.Abs(A * A * Math.PI - B * B * Math.PI); 
                break;
            case 2:
                answer = Math.Sqrt(B * B - Math.Pow(A / 2, 2)) * A / 2;
                break;
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

        // code here

        string cl;

        while (true)
        {
            cl = Console.ReadLine();

            if (cl == "")
            {
                break;
            }
            else
            {
                n++;
                answer += Convert.ToDouble(cl);
            }
            
        }

        answer = answer / (double)n;

        Console.WriteLine(answer);

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

        string cl;
        double x, y;

        while (true)
        {
            cl = Console.ReadLine();
            if (cl == "")
            {
                break;
            }
            else
            {
                x = Convert.ToDouble(cl);
                y = double.Parse(Console.ReadLine());
                if (((x * x + y * y) >= (r1 * r1)) && ((x * x + y * y) <= (r2 * r2)))
                {
                    answer ++;
                }
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

        string cl;
        double x, y;

        while (true)
        {
            cl = Console.ReadLine();
            if (cl == "")
            {
                break;
            }
            else
            {
                x = Convert.ToDouble(cl);
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
                else
                {
                    Console.WriteLine("4");
                }
            }
        }

        Console.Write(answer1 + " ");
        Console.Write(answer3);

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