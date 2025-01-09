using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.Task_1_1(0.9, 1.23);
        program.Task_1_2(0.9, 1.23);
        program.Task_1_3(0.9, 1.23);
        program.Task_1_4(0.9, 1.23, -0.1);
        program.Task_1_5(0.9, 1.23);
        program.Task_1_6(0.9, 1.23);
        program.Task_1_7(0.9);
        program.Task_1_8(0.9);
        program.Task_1_9(0.9);
        program.Task_1_10(0.9);
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
        ////program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        program.Task_3_3();
        //program.Task_3_4(1, 2);
        //program.Task_3_5(30);
        program.Task_3_6();
        //program.Task_3_7();
        //program.Task_3_8();
        program.Task_3_9();
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
        if (Math.Abs(x * x + y * y - r * r) <= 0.0001)
        {
            answer = true;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && (y + Math.Abs(x)) <= 1)
            answer = true;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)
            if (a > b)
                answer = a;
            else
                answer = b;
        else
            if (a < b)
                answer = a;
            else
                answer = b;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        if (a > b)
            if (b > c)
                answer = b;
            else
                answer = c;
        else
            if (a > c)
                answer = a;
            else
                answer = c;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double d1 = 2 * Math.Sqrt(r / Math.PI);
        double d2 = Math.Sqrt(s + s);
        if (d1 >= d2)
            answer = true;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double d1 = 2 * Math.Sqrt(r / Math.PI);
        double d2 = Math.Sqrt(s);
        if (d1 <= d2)
            answer = true;
        Console.WriteLine(answer);
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
        Console.WriteLine(answer);
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
            answer = (x * x) - 1;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 0;
        if (x > -1 && x <= 0)
            answer = 1 + x;
        if (x > 0)
            answer = 1;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 1;
        if (x > -1 && x <= 1)
            answer = -x;
        if (x > 1)
            answer = -1;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double r = 0;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out r);
            answer += r;
        }
        answer /= n;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((((a - x) * (a - x)) + ((b - y) * (b - y))) <= r * r) 
                answer ++;
        }
        Console.WriteLine(answer);
        // end

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
            if (weight < 30)
                answer += 200;
        }
        answer /= 1000;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((r1 * r1 <= ((x * x) + (y * y))) && (((x * x) + (y * y)) <= r2 * r2))
                answer ++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double result;
        for(int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out result);
            if (result <= norm)
                answer++;
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
        for(int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((x >= 0) && (x <= Math.PI) && (Math.Sin(x) >= y) && (y > 0))
                answer++;
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
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((x > 0) && (y > 0))
            {
                Console.WriteLine("Точка находится во 1-ом квадранте");
                answer1++;
            }
            if ((x < 0) && (y > 0))
                Console.WriteLine("Точка находится во 2-ом квадранте");
            if ((x < 0) && (y < 0))
            {
                Console.WriteLine("Точка находится во 3-ем квадранте");
                answer3++;
            }
            if ((x > 0) && (y < 0))
                Console.WriteLine("Точка находится во 4-ом квадранте");
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x, y;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((x * x) + (y * y) < (answerLength * answerLength))
            {
                answerLength = Math.Sqrt((x * x) + (y * y));
                answer = i;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double result;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out result);
            if (result < answer)
                answer = result;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int mark1, mark2, mark3, mark4;
        for(int i = 1; i <= n; i++)
        {
            int.TryParse(Console.ReadLine(), out mark1);
            int.TryParse(Console.ReadLine(), out mark2);
            int.TryParse(Console.ReadLine(), out mark3);
            int.TryParse(Console.ReadLine(), out mark4);
            if ((mark1 > 3) && (mark2 > 3) && (mark3 > 3) && (mark4 > 3))
                answer++;
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
        int mark1, mark2, mark3, mark4;
        for (int i = 1; i <= n; i++)
        {
            int.TryParse(Console.ReadLine(), out mark1);
            int.TryParse(Console.ReadLine(), out mark2);
            int.TryParse(Console.ReadLine(), out mark3);
            int.TryParse(Console.ReadLine(), out mark4);
            avg += mark1 + mark2 + mark3 + mark4;
            if ((mark1 <= 2) || (mark2 <= 2) || (mark3 <= 2) || (mark4 <= 2))
                answer++;
        }
        avg /= (n * 4);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r < 0)
            return 0;
        switch (type)
        {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = Math.PI * r * r;
                break;
            case 2:
                answer = ((r * r * Math.Sqrt(3)) / 4);
                break;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A <= 0 || B <= 0)
            return 0;
        switch(type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs((Math.PI * B * B) - (Math.PI * A * A));
                break;
            case 2:
                double p = ((A + B + B) / 2);
                answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B));
                break;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
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
        double weight;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out weight);
            if ((weight < 0) || (weight == 1000))
                break;
            if (weight < 30)
                answer += 200;
        }
        answer /= 1000;
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
        double x, y;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((x == 1000) || (y == 1000))
                break;
            if ((x >= 0) && (x <= Math.PI) && (Math.Sin(x) >= y))
                answer++;
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
        double result;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out result);
            if ((result < 0) || (result == 1000))
                break;
            if (result < answer)
                answer = result;
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