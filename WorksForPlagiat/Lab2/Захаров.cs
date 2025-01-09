using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
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
        //program.Task_2_4(4, 1, 2);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(5);
        //program.Task_2_7(5);
        //program.Task_2_8(10);
        //program.Task_2_9(10);
        //program.Task_2_10(8);
        //program.Task_2_11(6);
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
        if (Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -3)) answer = !answer;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && y + Math.Abs(x) <= 1) answer = !answer;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0) answer = a > b ? a : b;
        else answer = a < b ? a : b;
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double minz;
        minz = (a < b) ? a : b;
        answer = (minz < c) ? c : minz;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double diam, storona, diag;
        diam = Math.Sqrt(r / Math.PI) * 2;
        storona = Math.Sqrt(s);
        diag = storona * Math.Sqrt(2);

        if (diam >= diag) answer = !answer;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double diam, storona;
        diam = Math.Sqrt(r / Math.PI) * 2;
        storona = Math.Sqrt(s);
        if (diam <= storona) answer = !answer;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1) answer = 1;
        else answer = Math.Abs(x);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1) answer = 0;
        else answer = x * x - 1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 0;
        else if (x > -1 && x <= 0) answer = 1 + x;
        else answer = 1;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        else if (x > -1 && x <= 1) answer = -x;
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
        double height, sum = 0;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out height);
            sum += height;
        }
        answer = sum / n;
        Console.WriteLine(answer);
        // end

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
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r) answer++;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double weight;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out weight);
            if (weight < 30) answer += 0.2;
        }
        answer = Math.Round(answer, 1);
        Console.WriteLine(answer);
        // end

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
            if (x * x + y * y > r1 * r1 && x * x + y * y < r2 * r2) answer++;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double rezult;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out rezult);
            if (rezult <= norm) answer++;
        }
        Console.WriteLine(answer);
        // end

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
            if (x >= 0 && y >= 0 && x <= Math.PI && y <= Math.Sin(x)) answer++;
        }
        Console.WriteLine(answer);
        // end

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
            if (x >= 0 && y >= 0)
            {
                answer1++;
                Console.WriteLine("1 квадрант");
            }
            else if (x < 0 && y >= 0) Console.WriteLine("2 квадрант");
            else if (x < 0 && y < 0)
            {
                answer3++;
                Console.WriteLine("3 квадрант");
            }
            else Console.WriteLine("4 квадрант");
        }
        Console.WriteLine($"В 1 квадранте: {answer1}. В третьем квадранте: {answer3}");
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x, y;
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            double length = Math.Sqrt(x * x + y * y);
            if (length < answerLength)
            {
                answerLength = length;
                answer = i + 1;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine($"{answer}, {answerLength}");
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double result;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out result);
            if (result < answer) answer = result;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int grade1, grade2, grade3, grade4;
        for (int i = 0; i < n; i++)
        {
            int.TryParse(Console.ReadLine(), out grade1);
            int.TryParse(Console.ReadLine(), out grade2);
            int.TryParse(Console.ReadLine(), out grade3);
            int.TryParse(Console.ReadLine(), out grade4);

            if (grade1 != 2 && grade1 != 3 &&
                grade2 != 2 && grade2 != 3 &&
                grade3 != 2 && grade3 != 3 &&
                grade4 != 2 && grade4 != 3) answer++;
        }
        Console.WriteLine("answer:" + answer);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double sum = 0, totalsum = 0;
        int grade1, grade2, grade3, grade4;
        for (int i = 0; i < n; i++)
        {
            int.TryParse(Console.ReadLine(), out grade1);
            int.TryParse(Console.ReadLine(), out grade2);
            int.TryParse(Console.ReadLine(), out grade3);
            int.TryParse(Console.ReadLine(), out grade4);
            sum = grade1 + grade2 + grade3 + grade4;
            if (grade1 == 2 || grade2 == 2 || grade3 == 2 || grade4 == 2) answer++;
            totalsum += sum;
        }
        avg = totalsum / (n * 4);
        Console.WriteLine($"answer: {answer}\navg: {avg}");
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r <= 0) return 0;
        switch (type)
        {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = r * r * Math.PI;
                break;
            case 2:
                answer = r * r * Math.Sqrt(3) / 4;
                break;
        }
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        double p;
        if (A <= 0 || B <= 0 || !(type >= 0 && type <= 2)) return 0;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                if (A > B)
                {
                    answer = A * A * Math.PI - B * B * Math.PI;
                }
                else
                {
                    answer = B * B * Math.PI - A * A * Math.PI;
                }
                break;
            case 2:
                p = (A + B + B) / 2;
                answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B));
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

        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here

        while (true)
        {
            double x, y;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x == 0) break;
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r) answer++;
        }
        Console.WriteLine(answer);
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

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_4 answer

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here
        while (true)
        {
            double rezult;
            double.TryParse(Console.ReadLine(), out rezult);
            if (rezult == 0) break;
            if (rezult <= norm) answer++;
        }
        Console.WriteLine(answer);
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

        // code here
        while (true)
        {
            double x, y;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x == 0) break;
            double length = Math.Sqrt(x * x + y * y);
            if (length < answerLength)
            {
                answerLength = length;
                answer++;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine($"{answer}, {answerLength}");
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
        double sum = 0, totalsum = 0;
        int i;
        for (i = 0; ; i++)
        {
            int grade1, grade2, grade3, grade4;
            int.TryParse(Console.ReadLine(), out grade1);
            int.TryParse(Console.ReadLine(), out grade2);
            int.TryParse(Console.ReadLine(), out grade3);
            int.TryParse(Console.ReadLine(), out grade4);
            if (grade1 == 0) break;
            sum = grade1 + grade2 + grade3 + grade4;
            if (grade1 == 2 || grade2 == 2 || grade3 == 2 || grade4 == 2) answer++;
            totalsum += sum;
        }
        avg = totalsum / (i * 4);
        Console.WriteLine($"answer: {answer}\navg: {avg}");
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
