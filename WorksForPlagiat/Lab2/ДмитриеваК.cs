using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO.Compression;
using System.Runtime.CompilerServices;
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
        //program.Task_2_3(8);
        //program.Task_2_3(6);
        //program.Task_2_4(4, 1, 2);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(5);
        //program.Task_2_7(5);
        //program.Task_2_8(5);
        //program.Task_2_9(10);
        //program.Task_2_10(8);
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
        if (Math.Abs(x*x+y*y-4) <= 0.001) answer = true;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if ((y >= 0) && ((y + Math.Abs(x)) <= 1)) answer = true;
        //end
        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)
        {
            if (a > b) answer = a;
            else answer = b;
        }
        else
        {
            if (a < b) answer = a;
            else answer = b;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = a;

        // code here
        if (answer > b) answer = b;
        if (answer < c) answer = c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (s <= 2*(r/Math.PI)) answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (s >= 4*(r/Math.PI)) answer = true;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1) answer = 1;
        else if (Math.Abs(x) <= 1) answer = Math.Abs(x);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1) answer = 0;
        else if (Math.Abs(x) < 1) answer = x*x - 1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 0;
        else if (-1 < x && x <= 0) answer = 1 + x;
        else answer = 1;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        else if (-1 < x && x <= 1) answer = -x;
        else answer = -1;
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
            double.TryParse(Console.ReadLine(), out double h);
            answer += h;
        }
        answer /= n;
        Console.WriteLine("Task 2_1: " + answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for(int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double x);
            double.TryParse(Console.ReadLine(), out double y);
            if (((x - a)*(x - a) + (y - b)*(y - b)) <= r*r) answer += 1;
        }
        Console.WriteLine("Task 2_2: " + answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double kg);
            if (kg < 30) answer += 0.2;
        }
        Console.WriteLine("Task 2_3: " + answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double a);
            double.TryParse(Console.ReadLine(), out double b);
            if (((a*a + b*b) >= (r1*r1)) && ((a*a + b*b) <= (r2*r2))) answer += 1;
        }
        // end
        Console.WriteLine("Task 2_4: " + answer);
        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double get);
            if (get <= norm) answer += 1;
        }
        Console.WriteLine("Task 2_5:" + answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double x);
            double.TryParse(Console.ReadLine(), out double y);
            if ((x >= 0) && (x <= Math.PI) && (Math.Sin(x) >= y)) answer += 1;
        }
        Console.WriteLine("Task 2_6: " + answer);
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        Console.WriteLine("Task 2_7");
        for(int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double x);
            double.TryParse(Console.ReadLine(), out double y);
            switch (x, y)
            {
                case (> 0, > 0):
                    answer1++;
                    Console.WriteLine("1-ый квадрант");
                    break;
                case (< 0, > 0):
                    Console.WriteLine("2-oй квадрант");
                    break;
                case (< 0, < 0):
                    answer3++;
                    Console.WriteLine("3-ий квадрант");
                    break;
                case (> 0, < 0):
                    Console.WriteLine("4-ый квадрант");
                    break;
                default:
                    Console.WriteLine("Точка или находится на оси OX или OY, или является началoм координат");
                    break;
            }
            /*if ((x > 0) && (y > 0))
            {
                answer1 += 1;
                Console.WriteLine("1-ый квадрант");
            }
            else if ((x < 0) && (y > 0)) Console.WriteLine("2-ой квадрант");
            else if ((x < 0) && (y < 0))
            {
                answer3 += 1;
                Console.WriteLine("3-ий квадрант");
            }
            else if ((x > 0) && (y < 0)) Console.WriteLine("4-ый квадрант");
            else Console.WriteLine("Точка или находится на оси OX или OY, или является началом координат");
            */
        }
        Console.WriteLine($"answers = {answer1} {answer3}");
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        for(int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out double x);
            double.TryParse(Console.ReadLine(), out double y);
            if (Math.Sqrt(x*x + y*y) < answerLength)
                {
                    answer = i;
                    answerLength = Math.Sqrt(x*x + y*y);
                }
        }
        Console.WriteLine($"Task 2_8: {answer, 1} {answerLength, 1}");
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double time);
            if (answer > time) answer = time;
        }
        // end
        Console.WriteLine("Task 2_9: " + answer);
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0, count = 0;

        // code here;
        for (int i = 1; i <= 4*n; i++)
        {
            double.TryParse(Console.ReadLine(), out double grade);
            if ((grade != 3) && (grade != 2)) count += 1;
            if ((i % 4 == 0) && (count == 4))
            {
                answer += 1;
                count = 0;
            }
            else if (i % 4 == 0) count = 0;
        }
        Console.WriteLine("Task 2_10: " + answer);
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0, count = 0;

        // code here;
        for (int i = 1; i <= 4*n; i++)
        {
            double.TryParse(Console.ReadLine(), out double grade);
            avg += grade;
            if (grade == 2) count += 1;
            if ((i % 4 == 0) && (count >= 1))
            {
                answer += 1;
                count = 0;
            }
            else if (i % 4 == 0) count = 0;
        }
        avg /= 4*n;
        Console.WriteLine($"Task 2_11: {answer, 1} {avg, 1}");
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0, n = 3;
        //double.TryParse(Console.ReadLine(), out n);
        // code here;
        for (int i = 0; i < n; i++)
        {
            if (r <= 0) break;
            switch (type)
            {
                case 0:
                    answer = Math.Round(r*r, 2);
                    break;
                case 1:
                    answer = Math.Round(Math.PI*r*r, 2);
                    break;
                case 2: 
                    answer = Math.Round(r*r*Math.Sqrt(3)/4, 2);
                    break;
                default: break;
            }
        }
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0, n = 3;

        // code here;
        for (int i = 0; i < n; i++)
        {
            if ((A <= 0) || (B <= 0)) break;
            switch (type)
            {
                case 0:
                    answer = Math.Round(A*B, 2);
                    break;
                case 1:
                    answer = Math.Round(Math.Abs(A*A*Math.PI - B*B*Math.PI), 2);
                    break;
                case 2:
                    answer = Math.Round(A*Math.Sqrt(B*B - A*A/4)/2, 2);
                    break;
                default: break;
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
        while (true)
        {
            string? s = Console.ReadLine();
            if (s == string.Empty) break;
            else
            {
                n++;
                double.TryParse(s, out double h);
                answer += h;
            }
        }
        answer /= n;
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
    public int Task_3_4(double r1, double r2) ///
    {
        int answer = 0, n = 0;

        // code here
        while(true)
        {
            string? s = Console.ReadLine();
            if (s == string.Empty) break;
            else
            {
                double.TryParse(s, out double a);
                double.TryParse(s, out double b);
                if (((a*a + b*b) >= (r1*r1)) && ((a*a + b*b) <= (r2*r2))) answer += 1;
            }
        }
        Console.WriteLine("Task 3_4: " + answer);
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
        while (true)
        {
            string? s = Console.ReadLine();
            string? s2 = Console.ReadLine();
            if ((s == string.Empty) || (s2 == string.Empty)) break;
            else
            {
                double.TryParse(s, out double x);
                double.TryParse(s2, out double y);
                switch (x, y)
            {
                case (> 0, > 0):
                    answer1++;
                    Console.WriteLine("1-ый квадрант");
                    break;
                case (< 0, > 0):
                    Console.WriteLine("2-oй квадрант");
                    break;
                case (< 0, < 0):
                    answer3++;
                    Console.WriteLine("3-ий квадрант");
                    break;
                case (> 0, < 0):
                    Console.WriteLine("4-ый квадрант");
                    break;
                default:
                    Console.WriteLine("Точка или находится на оси OX или OY, или является началoм координат");
                    break;
            }
                    
            }
        }
        Console.WriteLine($"Task 3_7: {answer1} {answer3}");
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
        int answer = 0, n = 0, count = 0;

        // code here;
        while (true)
        {
            string? s = Console.ReadLine();
            double.TryParse(s, out double grade);
            if (s == string.Empty) break;
            else
            {
                n++;
                if ((grade != 3) && (grade != 2)) count += 1;
                if ((n % 4 == 0) && (count == 4))
                {
                    answer += 1;
                    count = 0;
                }
                else if (n % 4 == 0) count = 0;
            }
        }
        Console.WriteLine("Task 3_10: " + answer);
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