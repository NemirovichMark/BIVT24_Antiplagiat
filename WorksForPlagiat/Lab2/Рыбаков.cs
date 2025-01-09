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
        //program.Task_1_1(0, 2);
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
        program.Task_2_7(4);
        //program.Task_2_8(3);
        //program.Task_2_9(10);
        //program.Task_2_10(10);
        //program.Task_2_11(8);
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
        if (Math.Abs((x * x) + (y * y) - (r * r)) <= (1 / (10 * 10 * 10)))
        {
            answer = true;
        }
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && (y + Math.Abs(x)) <= 1)
            answer = true;
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
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        if (a < b)
            if (a > c)
                answer = a;
            else
                answer = c;
        else
            if (b > c)
                answer = b;
            else
                answer = c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (Math.Sqrt(s + s) <= 2 * Math.Sqrt(r / Math.PI))
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (Math.Sqrt(s) >= 2 * Math.Sqrt(r / Math.PI))
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
        else if (-1 < x && x <= 0)
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
        else if (-1 < x && x <= 1)
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

        // code here
        double a;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(System.Console.ReadLine(), out a);
            answer += a;
        }
        answer /= 10;
        System.Console.WriteLine(answer);
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
            double.TryParse(System.Console.ReadLine(), out x);
            double.TryParse(System.Console.ReadLine(), out y);
            if (r * r >= ((a - x) * (a - x) + (b - y) * (b - y)))
                answer++;
        }
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double m;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(System.Console.ReadLine(), out m);
            if (m < 30)
                answer += 200;
        }
        answer /= 1000;
        System.Console.WriteLine(answer);
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
            double.TryParse(System.Console.ReadLine(), out x);
            double.TryParse(System.Console.ReadLine(), out y);
            if (r1 * r1 <= x * x + y * y && r2 * r2 >= x * x + y * y)
                answer ++;
        }
        //System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double s;
        for (int i = 0; i < n; i ++)
        {
            double.TryParse(System.Console.ReadLine(), out s);
            if (s <= norm)
                answer++;
        }
        //System.Console.WriteLine(answer);
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
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (y < 0) return 0;
            if (0 <= x && x <= Math.PI && y <= Math.Sin(x))
                answer++;
        }
        System.Console.WriteLine(answer);
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
            if (x > 0)
            {
                if (y > 0)
                {
                    answer1++;
                    System.Console.WriteLine("Квадрант - 1");
                }
                else
                {
                    System.Console.WriteLine("Квадрант - 4");
                }
            }
            else
            {
                if (y > 0)
                {
                    System.Console.WriteLine("Квадрант - 2");
                }
                else
                {
                    answer3++;
                    System.Console.WriteLine("Квадрант - 3");
                }
            }
        }
        System.Console.WriteLine(answer1);
        System.Console.WriteLine(answer3);
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x, y;
        int c = 0;
        for (int i = 0; i < n; i++)
        {
            c++;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y); 
            if (answerLength * answerLength > (x * x + y * y))
            {
                answerLength = Math.Sqrt(x * x + y * y);
                answer = c;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        System.Console.WriteLine(answer);
        System.Console.WriteLine(answerLength);
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
            double.TryParse(Console.ReadLine(), out res);
            if (res < answer)
                answer = res;
        }
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int mark1, mark2, mark3, mark4;
        for (int i = 0; i < n; i++)
        {
            int.TryParse(Console.ReadLine(), out mark1);
            int.TryParse(Console.ReadLine(), out mark2);
            int.TryParse(Console.ReadLine(), out mark3);
            int.TryParse(Console.ReadLine(), out mark4);
            if (mark1 > 3 && mark2 > 3 && mark3 > 3 && mark4 > 3)
                answer++;
        }
        //System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double mark1, mark2, mark3, mark4, c = 0;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out mark1);
            double.TryParse(Console.ReadLine(), out mark2);
            double.TryParse(Console.ReadLine(), out mark3);
            double.TryParse(Console.ReadLine(), out mark4);
            if (mark1 < 3 || mark2 < 3 || mark3 < 3 || mark4 < 3)
                answer++;
            avg += mark1 + mark2 + mark3 + mark4;
            c += 4;
        }
        avg /= c;
        System.Console.WriteLine(answer);
        System.Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r < 0) return 0;
        switch(type)
        {
            case 0: answer = r * r; break;
            case 1: answer = r * r * Math.PI; break;
            case 2: answer = r * r * Math.Sqrt(3) / 4; break;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A < 0 || B < 0 || (B + B) < A) return 0;
        switch(type)
        {
            case 0: answer = A * B; break;
            case 1: answer = Math.Abs(A * A * Math.PI - B * B * Math.PI); break;
            case 2: answer = 0.5 * A * Math.Sqrt(B * B - 0.25 * A * A); break;
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

        // answer should be equal to the task_2_1 answer
        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here
        double x, y;
        string s1, s2;
        while (true)
        {
            s1 = Console.ReadLine();
            if (s1 == "") break;
            s2 = Console.ReadLine();
            double.TryParse(s1, out x);
            double.TryParse(s2, out y);
            if (r * r >= ((a - x) * (a - x) + (b - y) * (b - y)))
                answer++;
        }
        System.Console.WriteLine(answer);
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
        double s;
        string s1;
        while (true)
        {
            s1 = System.Console.ReadLine();
            if (s1 == "") break;
            double.TryParse(s1, out s);
            if (s <= norm)
                answer++;
        }
        System.Console.WriteLine(answer);
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
        string s1, s2;
        int c = 0;
        while (true)
        {
            s1 = Console.ReadLine();
            if (s1 == "") break;
            s2 = Console.ReadLine();
            c++;
            double.TryParse(s1, out x);
            double.TryParse(s2, out y); 
            if (answerLength * answerLength > (x * x + y * y))
            {
                answerLength = Math.Sqrt(x * x + y * y);
                answer = c;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        System.Console.WriteLine(answer);
        System.Console.WriteLine(answerLength);
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
        double mark1, mark2, mark3, mark4, c = 0;
        string s1, s2, s3, s4;
        while (true)
        {
            s1 = Console.ReadLine();
            if (s1 == "") break;
            s2 = Console.ReadLine();
            s3 = Console.ReadLine();
            s4 = Console.ReadLine();
            double.TryParse(s1, out mark1);
            double.TryParse(s2, out mark2);
            double.TryParse(s3, out mark3);
            double.TryParse(s4, out mark4);
            if (mark1 < 3 || mark2 < 3 || mark3 < 3 || mark4 < 3)
                answer++;
            avg += mark1 + mark2 + mark3 + mark4;
            c += 4;
        }
        avg /= c;
        System.Console.WriteLine(answer);
        System.Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    #endregion
}