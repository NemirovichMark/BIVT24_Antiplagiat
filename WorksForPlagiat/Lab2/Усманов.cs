using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
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
        program.Task_2_4(5, 1, 2);
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
        double r = 2;
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
        if (a > 0)
        {
            if (a > b)
                answer = a;
            else answer = b;
        }
        else
            if (a < b)
            answer = a;
        else answer = b;
        // code here

        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        double min_a_b, max_value;
        if (a < b)
            min_a_b = a;
        else
        {
            min_a_b = b;
        }
        if (min_a_b > c)
            answer = min_a_b;
        else
            answer = c;
        // code here
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;
        double a, diag;
        // code here
        a = Math.Sqrt(s);
        diag = (a * Math.Sqrt(2)) / 2;
        double Rad = Math.Sqrt(r / Math.PI);
        if (diag <= Rad)
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double a;
        // code here
        a = Math.Sqrt(s);
        double diam = Math.Sqrt(r / Math.PI) * 2;
        if (diam <= a)
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
            answer = x * x - 1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 0;
        else if (x >= -1 && x <= 0)
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
            answer = 1;
        else if (x > -1 && x <= 1)
            answer = -x;
        else
            answer = -1;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        double height = 0;
        // code here
        if (n == 0) return answer;
        for (int i = 0; i < n; i++)
        {
            height = double.Parse(Console.ReadLine());
            answer += height;
        }
        answer /= n;
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x, y;
        // code here
        if (n == 0) return 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());
            x = x - a; y = y - b;
            if (x * x + y * y <= r * r)
                answer += 1;
        }//n5 r3 a2 b1

        // end
        Console.WriteLine(answer);
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        double weight;
        // code here
        if (n == 0) return answer;
        for (int i = 0; i < n; i++)
        {
            weight = double.Parse(Console.ReadLine());
            if (weight < 30)
                answer += 0.2;
        }
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        double x, y;
        // code here
        if (n == 0) return answer;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите x:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y:");
            y = double.Parse(Console.ReadLine());
            if ((x*x + y*y >= r1*r1) && (x*x + y*y <= r2*r2))
                answer += 1;

        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        double runner;
        // code here
        if (n == 0) return answer;
        for (int i = 0; i < n; i++)
        {
            runner = double.Parse(Console.ReadLine());
            if (runner <= norm)
                answer += 1;

        }
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        double x, y;
        // code here
        if (n == 0) return 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите x:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y:");
            y = double.Parse(Console.ReadLine());
            if ((x >= 0 & x <= Math.PI) && (y >= 0 & y <= Math.Sin(x)))
                answer++;
        }
        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1
        Console.WriteLine(answer);
        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
        double x, y;
        // code here
        int max_n = 0;
        double S, max_S = 0;
        if (n == 0) return (answer1, answer3);
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Номер точки: {n}");
                n++;
                Console.WriteLine("Введите X");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите Y");
                y = double.Parse(Console.ReadLine());
                S = Math.Sqrt(x * x + y * y);
            if (x > 0 && y > 0)
            {
                answer1++;
                Console.WriteLine("1 квадрант");
            }
            if (x < 0 && y > 0)
            {

                Console.WriteLine("2 квадрант");
            }
            if (x < 0 && y < 0)
            {
                answer3++;
                Console.WriteLine("3 квадрант");
            }
            if (x > 0 && y < 0)
            {

                Console.WriteLine("4 квадрант");
            }

        }
        // end
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        double length;
        // code here
        if (n == 0) return (answer, 0);
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            length = Math.Sqrt((x * x) + y * y);
            if (length < answerLength)
            {
                answerLength = length;
                answer = i;
            }

        }
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        if (n == 0) return 0;
        // code here
        for (int i = 1; i <= n; i++)
        {
            double value = double.Parse(Console.ReadLine());
            if (value < answer)
                answer = value;
        }
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 1; i <= n; i++)
        {
            bool value = true;
            for (int j = 0; j < 4; j++)
            {
                double marks = double.Parse(Console.ReadLine());
                if (marks == 2 || marks == 3)
                    value = false;

            }
            if (value) answer++;


        }
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        if (n == 0) return (answer, avg);
        // code here;
        for (int i = 0; i < n; i++)
        {
            bool flag = false;

            for (int j = 0; j < 4; j++)
            {
                int mark = int.Parse(Console.ReadLine());
                avg += mark;
                if (mark == 2) flag = true;
            }
            if (flag) answer++;
        }

        avg /= 4 * n;

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        if (r == 0) return answer;
        // code here;
        if (r > 0)
        {
            switch (type)
            {
                case 0:
                    answer = r * r;
                    break;
                case 1:
                    answer = Math.PI * r * r;
                    break;
                case 2:
                    answer = Math.Sqrt(3) * r * r / 4;
                    break;
            }
        }

        // end

        return Math.Round(answer, 2);
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        if (A <= 0 || B <= 0) return answer;
        // code here;
        if (A > 0 || B > 0)
        {
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
            }

        }
        // end

        return Math.Round(answer, 2);
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;

        // code here
        Console.WriteLine("/");
        while (true)
        {
            string stop_word = Console.ReadLine();
            if (stop_word == "/")
                break;
            else
            {
                int value = int.Parse(stop_word);
                n++;
                answer += value;
            }
        }
        // code here

        answer /= n;
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        return answer;
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here

        // end

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
        Console.WriteLine("для остановки введите любой текст вместо переменной x");
        double x, y;
        while (true)
        {
            try
            {
                Console.WriteLine("Введите x:");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите y:");
                y = double.Parse(Console.ReadLine());
                if ((x * x + y * y >= r1*r1) && (x * x + y * y <= r2*r2))
                    answer += 1;
            }
            catch
            {
                Console.WriteLine(answer);
                return answer;
            }
            //1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        }
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_4 answer

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here

        // end

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
        int answer1 = 0, answer3 = 0, n = 1;
        double x, y;
        double S;
        // code here
        Console.WriteLine("/");
        while (true)
        {
            try
            {

                Console.WriteLine($"Номер точки: {n}");
                n++;
                Console.WriteLine("Введите X");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите Y");
                y = double.Parse(Console.ReadLine());
                S = Math.Sqrt(x * x + y * y);
                if (x > 0 & y > 0)
                {
                   
                    Console.WriteLine("1 квадрант");

                    answer1++;
                }
                if (x < 0 && y > 0)
                {

                    Console.WriteLine("2 квадрант");
                }
                if (x < 0 && y < 0)
                {
                    
                    Console.WriteLine("3 квадрант");

                    answer3++;
                }
                if (x > 0 && y < 0)
                {

                    Console.WriteLine("4 квадрант");
                }

            }

            catch
            {
                Console.WriteLine(answer1 + " " + answer3);
                return (answer1, answer3);
            }
        }
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_7 answer

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here

        // end

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
        Console.WriteLine("/");
        while (true)
        {
            try
            {
                bool value = true;
                for (int j = 0; j < 4; j++)
                {
                    double marks = double.Parse(Console.ReadLine());
                    if (marks == 2 | marks == 3)
                        value = false;

                }
                if (value) answer++;
            }
            catch
            {
                return answer;
            }
        }
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_10 answer

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;

        // end

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