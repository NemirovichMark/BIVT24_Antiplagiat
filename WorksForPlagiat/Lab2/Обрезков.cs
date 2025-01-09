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
        // System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");  // to enter fractional numbers using a dot (1.2) rather than a comma (1,2)
        
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
        program.Task_2_1(10);
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
        double r = 2;

        if (Math.Abs(x * x + y * y - r * r) <= 1e-3)
        {
            answer = true;
        }

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        if (y > 0 && y + Math.Abs(x) <= 1)
        {
            answer = true;
        }

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = a;

        if (a > 0)
        {
            if (b > answer) answer = b;
        }
        else
        {
            if (b < answer) answer = b;
        }

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = a;

        if (b < answer) answer = b;
        if (c > answer) answer = c;

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        double a_r = Math.Sqrt(r / Math.PI) * 2, a_s = Math.Sqrt(s) * Math.Sqrt(2);

        if (a_r >= a_s) answer = true;

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        double a_r = Math.Sqrt(r / Math.PI) * 2, a_s = Math.Sqrt(s);

        if (a_r <= a_s) answer = true;

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        if (Math.Abs(x) > 1) answer = 1;
        else answer = Math.Abs(x);

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        if (Math.Abs(x) >= 1) answer = 0;
        else answer = x * x - 1;

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        if (x <= -1) answer = 0;
        else if (-1 < x && x <= 0) answer = 1 + x;
        else answer = 1;

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        if (x <= -1) answer = 1;
        else if (-1 < x && x <= 1) answer = -x;
        else answer = -1;

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        for (int i = 0; i < n; i++)
        {
            answer += int.Parse(Console.ReadLine());
        }

        answer /= n;
        if (n == 0) answer = 0;
        
        Console.WriteLine(answer);
        
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());

            if (Math.Pow(x - a, 2) + Math.Pow(y - b, 2) <= Math.Pow(r, 2)) answer++;
        }
        
        Console.WriteLine(answer);
        
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        for (int i = 0; i < n; i++)
        {
            double weight = double.Parse(Console.ReadLine());

            if (weight < 30) answer += 0.2;
        }

        answer = Math.Round(answer, 1);
        Console.WriteLine(answer);
        
        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());

            if (r1 * r1 <= x * x + y * y && x * x + y * y <= r2 * r2)
            {
                answer++;
            }
        }
        
        Console.WriteLine(answer);
        
        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            double res = double.Parse(Console.ReadLine());

            if (res < norm) answer++;
        }
        
        Console.WriteLine(answer);
        
        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());

            if (0 <= x && x <= Math.PI && 0 <= y && y <= Math.Sin(x))
            {
                answer++;
            }
        }
        
        Console.WriteLine(answer);
        
        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());

            if (x > 0)
            {
                if (y > 0) answer1++;
            }
            else
            {
                if (y < 0) answer3++;
            }
        }
        
        Console.WriteLine($"{answer1}\n{answer3}");
        
        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
            double length = Math.Sqrt(x * x + y * y);
            
            if (length < answerLength)
            {
                answer = i;
                answerLength = length;
            }
        }

        answerLength = Math.Round(answerLength, 2);

        if (n == 0) answerLength = 0;
        
        Console.WriteLine($"{answer}\n{answerLength}");
        
        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        for (int i = 0; i < n; i++)
        {
            double res = double.Parse(Console.ReadLine());

            if (res < answer) answer = res;
        }

        if (n == 0) answer = 0;
        
        Console.WriteLine(answer);
        
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            bool isGood = true;
            
            for (int j = 0; j < 4; j++)
            {
                int mark = int.Parse(Console.ReadLine());
                if (mark == 3 || mark == 2) isGood = false;
            }

            if (isGood) answer++;
        }
        
        Console.WriteLine(answer);
        
        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        for (int i = 0; i < n; i++)
        {
            bool isGood = true;

            for (int j = 0; j < 4; j++)
            {
                int mark = int.Parse(Console.ReadLine());
                if (mark == 2) isGood = false;

                avg += mark;
            }

            if (!isGood) answer++;
        }

        avg /= n * 4;
        avg = Math.Round(avg, 2);
        if (n == 0) avg = 0;
        
        Console.WriteLine($"{answer}\n{avg}");
        
        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

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
        }
        
        answer = Math.Round(answer, 2);

        if (r <= 0) answer = 0;
        
        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer;

        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                double temp = (A > B) ? A : B;
                A = (A > B) ? B : A;
                B = temp;
                answer = Math.PI * B * B - Math.PI * A * A;
                break;
            case 2:
                double h = Math.Sqrt(B * B - Math.Pow(A / 2, 2));
                answer = 0.5 * A * h;
                break;
            default:
                answer = 0;
                break;
        }

        answer = Math.Round(answer, 2);

        if (A <= 0 || B <= 0) answer = 0;
        
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
        double answer = 0, weight = double.MaxValue;
        int n = 0;
        string input;

        do
        {
            if (weight < 30)
            {
                answer += 0.2;
            }
            
            input = Console.ReadLine();
        } while (double.TryParse(input, out weight));
        
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
        string inputX, inputY;
        double x = -1, y = -1;

        do
        {
            if (0 <= x && x <= Math.PI && 0 <= y && y <= Math.Sin(x)) answer++;
            
            inputX = Console.ReadLine();
            inputY = Console.ReadLine();
        } while (double.TryParse(inputX, out x) && double.TryParse(inputY, out y));
        
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
        double answer = double.MaxValue, dist = double.MaxValue;
        int n = 0;
        string input;

        do
        {
            answer = (dist < answer) ? dist : answer;
            
            input = Console.ReadLine();
        } while (double.TryParse(input, out dist));
        
        Console.WriteLine(answer);

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
