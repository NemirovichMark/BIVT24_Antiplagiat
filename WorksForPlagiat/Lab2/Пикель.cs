using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

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
        int r = 2;
        if (Math.Abs(Math.Pow(x, 2) + Math.Pow(y, 2) - Math.Pow(2, 2)) < Math.Pow(10, -3)) {
            answer = true;
        }
        
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && y <= (x + 1) && y <= ((-1) * x + 1)) {
            answer = true;
        }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
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
        } else
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
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double mini = 0;
        if (a > b) { mini = b; } else { mini = a; }
        if (c > mini) { answer = c; } else { answer = mini; }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double rad = Math.Sqrt(s) * Math.Sqrt(2) / 2;
        if (rad <= Math.Sqrt(r / Math.PI)) { answer = true;  }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double d = Math.Sqrt(r / Math.PI) * 2;
        double a = Math.Sqrt(s);
        if (d <= a) { answer = true; }  
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
        else { answer = Math.Abs(x); }
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if ((Math.Abs(x) > 1)) { answer = 0; }
        else { answer = x * x - 1; }
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) {  answer = 0; }
        else if ( -1 < x && x <= 0) { answer = 1 + x; }
        else { answer = 1; }
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) { answer = 1; }
        else if (-1 < x && x <= 1) { answer = (-1) * x; }
        else { answer = -1; }
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
            answer += Convert.ToSingle(Console.ReadLine(), new CultureInfo("en-US"));
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
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            y = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if ((a - x) * (a - x) + (b - y) * (b - y) <= r * r) {  answer++; }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double w;
        for (int i = 0; i < n; i++)
        {
            w = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if (w < 30) { answer += 0.2; }
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
            x = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            y = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if ((x * x + y * y <= r2 * r2) && (x * x + y * y >= r1 * r1)) {  answer++; }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double res;
        for (int i = 0; i < n; i++)
        {
            res = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if (res <= norm) { answer++; }
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
        for (int i = 0; i < n; i++) {
            x = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            y = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if (y >= 0 && x >= 0 && x <= Math.PI && y <= Math.Sin(x)) { answer++; }
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
            x = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            y = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if (x > 0 && y >= 0) { answer1++; }
            if (x < 0 && y < 0) { answer3++; }
            Console.WriteLine(answer1);
            Console.WriteLine(answer3);
        }
        // end

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
            x = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            y = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if (Math.Sqrt(x * x + y * y) < answerLength) { answer = i + 1; answerLength = Math.Sqrt(x * x + y * y); }
            answerLength = Math.Round(answerLength, 2);
            Console.WriteLine(answer);
            Console.WriteLine(answerLength);
        }
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double res;
        for (int i = 0; i < n; i++)
        {
            res = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if (res < answer) { answer = res; }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        double m1, m2, m3, m4;
        for (int i = 0; i < n; i++) {
            m1 = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            m2 = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            m3 = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            m4 = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if (!(m1 == 2 || m1 == 3 || m2 == 2 || m2 == 3 || m3 == 2 || m3 == 3 || m4 == 2 || m4 == 3)) {
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

        // code here;
        double m1, m2, m3, m4;
        for (int i = 0; i < n; i++)
        {
            m1 = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            m2 = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            m3 = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            m4 = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            if ((m1 == 2 || m2 == 2|| m3 == 2 || m4 == 2)) 
            { 
                answer++;
            }
            avg += (m1 + m2 + m3 + m4);
        }
        avg /= 4 * n;
        avg = Math.Round(avg, 2);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end
        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r <= 0) { return 0; }
        switch (type)
        {
            case (0):
                answer = r * r;
                break;
            case (1):
                answer = r * r * Math.PI;
                break;
            case (2):
                answer = r * r * Math.Sqrt(3) / 4;
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
            case (0):
                answer = A * B;
                break;
            case (1):
                answer = Math.Abs(A * A - B * B) * Math.PI;
                break;
            case (2):
                double p = (A + B + B) / 2;
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
        double x, y;
        while (double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out x) && double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out y))
        {
            if ((a - x) * (a - x) + (b - y) * (b - y) <= r * r) {
                answer++;
            }
        }
        Console.WriteLine(answer);
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

        // end

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here
        double res;
        while (double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out res))
        {
            if (res <= norm) { answer++; }
        }
        Console.WriteLine(answer);
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

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here
        double x, y;
        while (double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out x) && (double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out y))) {
            answer++;
            if (Math.Sqrt(x * x + y * y) < answerLength)
            {
                answerLength = Math.Sqrt(x * x + y * y);
            }
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
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
        // для корректной работы программы на вход должно подаваться 4*k чисел
        double m1, m2, m3, m4;
        while (double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out m1) &&
            double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out m2) &&
            double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out m3) &&
            double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out m4)) 
            {
            n++;
            avg += (m1 + m2 + m3 + m4);
            if (m1 == 2 || m2 == 2 || m3 == 2 || m4 == 2)
                {
                    answer++;
                }
            }
        avg /= (n * 4);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    #endregion
}