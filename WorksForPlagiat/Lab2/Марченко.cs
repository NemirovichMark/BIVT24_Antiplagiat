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
        //program.Task_1_6(3.2, 4.5);
        //program.Task_1_7(0.9);
        //program.Task_1_8(0.9);
        //program.Task_1_9(0.9);
        //program.Task_1_10(0.9);
        //program.Task_2_1(10);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(10);
        //program.Task_2_4(4, 1, 2);
        //program.Task_2_5(10,25.2);
        //program.Task_2_6(5);
        //program.Task_2_7(3);
        //program.Task_2_8(3);
        //program.Task_2_9(10);
        //program.Task_2_10(10);
        //program.Task_2_11(10);
        //program.Task_2_12(0.2, 2);
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
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        int r = 2;

        // code here
        if (Math.Abs(x * x + y * y - r * r) <= 0.001)
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && (y + Math.Abs(x) <= 1))
            answer = true;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;
        // code here
        if (a > 0)
            answer = a < b ? b : a;
        else
            answer = a > b ? b : a;
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here     
        answer = (a > b ? b : a) > c ? (a > b ? b : a) : c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;
        double diametr = Math.Sqrt(r / Math.PI) * 2;
        double diagonal = Math.Sqrt(2 * s);
        // code here
        if (diagonal <= diametr)
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;
        double diametr = Math.Sqrt(r / Math.PI) * 2;
        double a = Math.Sqrt(s);
        // code here
        if (diametr <= a)
            answer = true;
        // end
        Console.WriteLine($"{r}  {s}  {answer}");
        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1)
            answer = 1;
        else answer = Math.Abs(x);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1)
            answer = 0;
        else answer = x * x - 1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 0;
        else if (x <= 0) answer = 1 + x;
        else answer = 1;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        else if (x <= 1) answer = -x;
        else answer = -1;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)    // Нужно ли выводить сообщение о неккоректности ввода?
    {
        double answer = 0;
        int c;
        // code here
        for (int i = 0; i < n; i++)
        {
            int.TryParse(Console.ReadLine(), out c);
            answer += c;
        }
        answer /= n;
        // end
        Console.WriteLine(answer);
        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);

            x -= a;
            y -= b;
            if ((x * x + y * y) <= r * r)
            {
                //Console.WriteLine($"{x} {y} {r}");
                answer++;
                //Console.WriteLine("Ok");
            }
            //else { Console.WriteLine("No"); }
            //Console.WriteLine();
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double weight;
            double.TryParse(Console.ReadLine(), out weight);
            if (weight < 30) answer += 0.2;
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);

            if (((x * x + y * y) <= r2 * r2) && ((x * x + y * y) >= r1 * r1))
            {
                answer++;
            }
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double x;
            Double.TryParse(Console.ReadLine(), out x);
            if (x <= norm) answer += 1;
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);

            if (x >= 0 && y <= Math.Sin(x) && y >= 0)
            {
                answer++;
            }
        }
        // end
        Console.WriteLine(answer);
        //y = a + b sin(cx + d)
        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

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
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("1");
                answer1++;
            }
            else if (x > 0 && y < 0)
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
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        Console.WriteLine($"{answer1} {answer3}");
        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x, y;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);

            double lenght = Math.Sqrt(x * x + y * y);
            if (lenght < answerLength)
            {
                answer = i + 1;
                answerLength = lenght;
            }
        }
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5
        Console.WriteLine($"{answer},   {answerLength}");
        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double x;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);

            answer = answer < x ? answer : x;
        }
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int x, y, z, w;
        for (int i = 0; i < n; i++)
        {
            int.TryParse(Console.ReadLine(), out x);
            int.TryParse(Console.ReadLine(), out y);
            int.TryParse(Console.ReadLine(), out z);
            int.TryParse(Console.ReadLine(), out w);

            if (x > 3 && y > 3 && z > 3 && w > 3) answer++;
        }
        // end

        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        int x, y, z, w;
        for (int i = 0; i < n; i++)
        {
            int.TryParse(Console.ReadLine(), out x);
            int.TryParse(Console.ReadLine(), out y);
            int.TryParse(Console.ReadLine(), out z);
            int.TryParse(Console.ReadLine(), out w);

            avg += (x + y + z + w) / 4.0;
            if (x == 2 || y == 2 || z == 2 || w == 2) answer++;
        }
        // end
        avg /= 10;
        Console.WriteLine($"{answer}  {avg}");

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        if (type < 0 || type > 2 || r <= 0)
        {
            return 0;
        }
        // code here;
        switch (type)
        {
            case 0:
                answer = r * r;  //squere
                break;
            case 1:
                answer = Math.PI * r * r;  //circle
                break;
            case 2:
                answer = r * r * Math.Sqrt(3) / 4;  //triangle
                break;
        }
        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        if (type < 0 || type > 2 || A <= 0 || B <= 0)
        {
            return 0;
        }
        // code here;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                break;
            case 2:
                answer = A / 2 * Math.Sqrt(B * B - A * A / 4);
                break;
            default:
                answer = 0;
                break;
        }
        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
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


        double weight;
        // code here
        while (double.TryParse(Console.ReadLine(), out weight))
        {
            n++;
            if (weight < 30) answer += 0.2;
        }
        // end
        Console.WriteLine(answer);

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
        while (double.TryParse(Console.ReadLine(), out x) && double.TryParse(Console.ReadLine(), out y))
        {
            n++;
            if (x >= 0 && y <= Math.Sin(x))
            {
                answer++;
            }
        }
        // end
        Console.WriteLine(answer);

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
        double x;
        while (double.TryParse(Console.ReadLine(), out x))
        {
            answer = answer < x ? answer : x;
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