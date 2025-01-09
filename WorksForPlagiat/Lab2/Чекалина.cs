using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        //program.Task_2_8(10);
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
        double a = x * x + y * y - 4;
        if (Math.Abs(a) < 0.001)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        Console.WriteLine(22 % 3 + 1);
        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        if (y >= 0 && (y + Math.Abs(x)) <= 1)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

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
        else if (a < 0)
        {
            if (a < b)
            {
                answer = a;
            }
            else
            {
                answer = b;
            }
        }

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        double d = 0;

        if (a > b)
        {
            d = b;
        }
        else
        {
            d = a;
        }

        if (d > c)
        {
            answer = d;
        }
        else
        {
            answer = c;
        }

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        double d1 = 2*Math.Sqrt(r / Math.PI);
        double d2 = Math.Sqrt(s) * Math.Sqrt(2);

        if (d2 <= d1)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;
        double d1 = 2 * Math.Sqrt(r / Math.PI);
        double d2 = Math.Sqrt(s);

        if (d1 <= d2)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        if (Math.Abs(x) > 1)
        {
            answer = 1;
        }
        else
        {
            answer = Math.Abs(x);
        }
        return answer;

    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        if (Math.Abs(x) >= 1)
        {
            answer = 0;
        }
        else
        {
            answer = x * x - 1;
        }

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        if (x <= -1)
        {
            answer = 0;
        }
        else if (-1 < x && x <= 0)
        {
            answer = x + 1;
        }
        else
        {
            answer = 1;
        }
        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        if (x <= -1)
        {
            answer = 1;
        }
        else if (-1 < x && x <= 1)
        {
            answer = -x;
        }
        else
        {
            answer = -1;
        }

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        double s = 0;
        int k = 0;

        while (n > 0)
        {
            double a = double.Parse(Console.ReadLine());
            s += a;
            n -= 1;
            k += 1;
        }
        answer = s / k;
        Console.WriteLine(answer);
        
        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        
        while (n > 0)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (((x - a) * (x - a) + (y - b) * (y - b)) <= r * r)
            {
                answer += 1;
            }
                n -= 1;
        }

        Console.WriteLine(answer);
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        while (n > 0)
        {
            double a = double.Parse(Console.ReadLine());
            if (a < 30)
            {
                answer += 1;
            }
            n -= 1;
        }
        answer *= 0.2;

        Console.WriteLine(answer);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        while (n > 0)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (r1*r1 <= (x*x + y*y) && (x*x + y*y) <= r2*r2)
            {
                answer += 1;
            }
            n -= 1;
        }

        Console.WriteLine(answer);

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        while (n > 0)
        {
            double a = double.Parse(Console.ReadLine());
            if (a <= 30)
            {
                answer += 1;
            }
            n -= 1;
        }
        Console.WriteLine(answer);

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        while (n > 0)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((x >= 0) && (x <= Math.PI) && (y >= 0) && (y <= Math.Sin(x)))
            {
                answer += 1;
            }
            n -= 1;
        }

        Console.WriteLine(answer);
        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        while (n > 0)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x >= 0 && y >= 0)
            {
                answer1 += 1;
                Console.WriteLine(1);
            }
            else if (x <= 0 && y >= 0)
            {
                Console.WriteLine(2);
            }
            else if (x <= 0 && y <= 0)
            {
                answer3 += 1;
                Console.WriteLine(3);
            }
            else if (x >= 0 && y <= 0)
            {
                Console.WriteLine(4);
            }
            n -= 1;
        }

        Console.WriteLine(answer1);
        Console.WriteLine(answer3);

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        int a = 0;

        while (n > 0)
        {
            a += 1;
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (Math.Sqrt(x*x + y*y) < answerLength)
            {

                answer = a;
                answerLength = Math.Sqrt(x * x + y * y);
            }
            n -= 1;
        }

        Console.WriteLine("{0}, {1}", a, answerLength);

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        while (n > 0 )
        {
            double a = double.Parse(Console.ReadLine());
            if (a < answer)
            {
                answer = a;
            }
            n -= 1;
        }

        Console.WriteLine(answer);

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        while (n > 0)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            if (((a != 3) && (a != 2)) && ((b != 3) && (b != 2)) && ((c != 3) && (c != 2)) && ((d != 3) && (d != 2)))
            {
                answer += 1;
            }
            n -= 1;
        }

        Console.WriteLine(answer);
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        int y = 0;

        while (n > 0)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            if (a == 2 || b == 2 || c == 2 || d == 2)
            {
                answer += 1;
            }
            avg += (a + b + c + d) / 4;
            y += 1;
            n -= 1;
        }

        avg = avg / y;
        Console.WriteLine(answer);
        Console.WriteLine(avg);

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

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
                answer = 0.5 * r * r * Math.Sin(Math.PI / 3);
                break;
            default:
                answer = 0;
                break;
        }
        answer = Math.Round(answer, 2);

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        if ((A <= 0) || (B <= 0)) return 0;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs(Math.PI * (A * A - B * B));
                break;
            case 2:
                double p = (A + B + B) / 2;
                answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B));
                break;
            default:
                answer = 0;
                break;
        }
        answer = Math.Round(answer, 2);
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

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0;
        string line;

        while (!string.IsNullOrEmpty(line = Console.ReadLine()))
        {
            var el = line.Split(' ');
            double x = double.Parse(el[0]);
            double y = double.Parse(el[1]);
            if (((x - a) * (x - a) + (y - b) * (y - b)) <= r * r)
                {
                    answer += 1;
                }
        }

    Console.WriteLine(answer);


        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

        return answer;
    }
public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_3 answer

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_4 answer

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;
        
        string line;

        while (!string.IsNullOrEmpty(line = Console.ReadLine()))
        {
            double a = double.Parse(line);
            if (a <= norm)
            {
                answer += 1;
            }
        }
        Console.WriteLine(answer);

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1
        // answer should be equal to the task_2_6 answer

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_7 answer

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;
        string line;
        
        int a = 0;

        while (!string.IsNullOrEmpty(line = Console.ReadLine()))
        {
            a += 1;
            var el = line.Split(' ');
            double x = double.Parse(el[0]);
            double y = double.Parse(el[1]);
            if (Math.Sqrt(x * x + y * y) < answerLength)
            {

                answer = a;
                answerLength = Math.Sqrt(x * x + y * y);
            }
        }

        Console.WriteLine("{0}, {1}", a, answerLength);

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_8 answer

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_9 answer

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_10 answer

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0;
        double avg = 0.0;
        string line;
        int y = 0;
        

        while (!string.IsNullOrEmpty(line = Console.ReadLine()))
        {
            var el = line.Split(' ');
            
            double a = double.Parse(el[0]);
            double b = double.Parse(el[1]);
            double c = double.Parse(el[2]);
            double d = double.Parse(el[3]);

            if (a == 2 || b == 2 || c == 2 || d == 2)
            {
                answer += 1;
            }
            avg += (a + b + c + d) / 4;
            y += 1;
        }


        avg = avg / y;
        Console.WriteLine(answer);
        Console.WriteLine(avg);

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_11 answer

        return (answer, avg);
    }
    public double Task_3_12(double r, int type)
    {
        double answer = 0;

        // code here;

        // end
        // answer should be equal to the task_2_12 answer

        return answer;
    }
    public double Task_3_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;

        // end
        // answer should be equal to the task_2_13 answer

        return answer;
    }
    #endregion
}
