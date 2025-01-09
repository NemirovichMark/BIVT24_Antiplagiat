using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

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
        //program.Task_2_3(6);
        //program.Task_2_4(3,1,3);
        //program.Task_2_5(6,25.2);
        //program.Task_2_6(3);
        //program.Task_2_7(3);
        //program.Task_2_8(3);
        //program.Task_2_9(6);
        //program.Task_2_10(6);
        //program.Task_2_11(6);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(3, 2.5, 0);
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
        if (Math.Abs(x * x + y * y - 4) <= 0.001) answer = true;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && y + Math.Abs(x) <= 1) answer = true;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        double min, max;
        if (a > b) { min = b; max = a; }
        else { min = a; max = b; }

        if (a > 0) answer = max;
        else answer = min;
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double min;
        if (a > b) min = b; else min = a;
        if (min > c) answer = min; else answer = c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (2 * s <= 4 * r / Math.PI) answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (s >= 4 * r / Math.PI) answer = true;
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
        if (Math.Abs(x) < 1) answer = x * x - 1;
        else answer = 0;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 0;
        else if (x > 0) answer = 1;
        else answer = 1 + x;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        else if (x > 1) answer = -1;
        else answer = -x;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        for (int i = n; i > 0; i--) answer += Convert.ToDouble(Console.ReadLine());
        answer /= n;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int i = n; i > 0; i--)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(x - a, 2) + Math.Pow(y - b, 2));
            if (c <= r) answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for (int i = n; i > 0; i--)
        {
            double weight = Convert.ToDouble(Console.ReadLine());
            if (weight < 30) answer += 0.2;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = n; i > 0; i--)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt(x * x + y * y);
            if (c >= r1 && c <= r2) answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i = n; i > 0; i--)
        {
            double result = Convert.ToDouble(Console.ReadLine());
            if (result <= norm) answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = n; i > 0; i--)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (0<=x && x<=Math.PI && 0<=y && y<=Math.Sin(x)) answer++;
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
        for (int i = n; i > 0; i--)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                answer1++;
                Console.WriteLine("1 quadrant\n");
            }
            else if (x < 0 && y < 0)
            {
                answer3++;
                Console.WriteLine("3 quadrant\n");
            }
            else if (x > 0 && y < 0)
            {
                answer3++;
                Console.WriteLine("4 quadrant\n");
            }
            else if (x < 0 && y > 0)
            {
                answer3++;
                Console.WriteLine("2 quadrant\n");
            }
        }
        Console.WriteLine($"\nin quadrant 1: {answer1} \nin quadrant 3: {answer3}");
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            double l = Math.Sqrt(x * x + y * y);
            if (l < answerLength)
            {
                answer = i;
                answerLength = l;
            }
        }
        Console.WriteLine($"number: {answer}\nlength: {Math.Round(answerLength,2)}");
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = n; i >0; i--)
        {
            double res = Convert.ToDouble(Console.ReadLine());
            if (res < answer) answer = res;
        }
        Console.WriteLine(answer);
        // end

        return answer; 
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = n; i > 0; i--)
        {
            bool suitable = true;
            for (int k = 4; k > 0; k--)
            {
                double r = Convert.ToDouble(Console.ReadLine());
                if (r < 4) suitable=false;
            }
            if (suitable) answer++;
        }
        Console.WriteLine($"answer: {answer}");
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        for (int i = n; i > 0; i--)
        {
            bool check = false;
            for (int k = 4; k > 0; k--)
            {
                double r = Convert.ToDouble(Console.ReadLine());
                avg += r;
                if (r == 2) check = true;
            }
            if (check) answer++;
        }
        Console.WriteLine($"answer: {answer}\naverage: {avg/(4*n)}");
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (type < 0 || type > 2 || r <= 0) answer = 0;
        else if (type==0) answer = r * r;
        else if (type==1) answer = Math.PI * r * r;
        else if (type==2) answer = r * r * Math.Sqrt(3) / 4;

        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (type < 0 || type > 2 || A <= 0 || B<=0) answer = 0;
        else if (type == 0) answer = A*B;
        else if (type == 1) answer = Math.Abs(Math.PI*A*A-Math.PI*B*B);
        else if (type == 2) answer = Math.Sqrt(B*B-A*A/4)*A/2;

        answer = Math.Round(answer, 2);
        Console.WriteLine($"A:{A} B:{B} type:{type} answer - {answer}");
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

        // code here
        for (;;)
        {
            string input = Console.ReadLine();
            if (input!="stop")
            { 
                double weight = Convert.ToDouble(input);
                if (weight < 30) answer += 0.2;
            }
            else break; 
        }
        Console.WriteLine(answer);
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

        // code here
        for (; ; )
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            if (input1 != "stop" && input2 != "stop")
            {
                double x = Convert.ToDouble(input1);
                double y = Convert.ToDouble(input2);
                if (0 <= x && x <= Math.PI && 0 <= y && y <= Math.Sin(x)) answer++;
            }
            else break;
        }
        Console.WriteLine(answer);
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

        // code here
        for (; ; )
        {
            string input = Console.ReadLine();

            if (input != "stop")
            {
                double res = Convert.ToDouble(input);
                if (res < answer) answer = res;
            }
            else break;
        }
        Console.WriteLine(answer);
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