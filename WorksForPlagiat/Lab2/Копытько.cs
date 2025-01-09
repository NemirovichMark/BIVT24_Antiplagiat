using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

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

        answer = Math.Abs(x * x + y * y - 4) <= 0.001;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here

        answer = y >= 0 && y + Math.Abs(x) <= 1;
        // end

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
        else if (a <= 0)
        {
            if (a > b) answer = b;
            else answer = a;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here

        double mn;
        if (a < b) mn = a;
        else mn = b;
        if (mn > c) answer = mn;
        else answer = c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here

        double diametr = Math.Sqrt(r / Math.PI) * 2, diagonal = Math.Sqrt(s * 2);
        answer = diagonal <= diametr;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here

        double diametr = Math.Sqrt(r / Math.PI) * 2, a = Math.Sqrt(s);
        answer = a >= diametr;
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
        else if (x > -1 && x <= 1) answer = x * -1;
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

        double sm = 0, height;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out height);
            sm += height;
        }
        answer = sm / n;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here

        double x, y;
        for (int i = 0; i < n; i ++)
        {
            Console.WriteLine($"Input {i + 1} point:");
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r) answer += 1;
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
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out weight);
            if (weight < 30) answer += 0.2;
        }
        answer = Math.Round(answer, 1);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here

        double x, y;
        for (int i = 0; i < n; i ++)
        {
            Console.WriteLine($"Input {i + 1} point:");
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x * x + y * y > r1 * r1 && x * x + y * y < r2 * r2) answer += 1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here

        double rez;
        for (int i = 0; i < n; i ++)
        {
            double.TryParse(Console.ReadLine(), out rez);
            if (rez <= norm) answer += 1;
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
        for (int i = 0; i < n; i ++)
        {
            Console.WriteLine($"Input {i + 1} point:");
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (y >= 0 && x >= 0 && x <= Math.PI && y <= Math.Sin(x)) answer += 1;
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
            Console.WriteLine($"Input {i + 1} point:");
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x >= 0 && y >= 0)
            {
                answer1++;
                Console.WriteLine("1 kvadrant");
            }
            else if (x < 0 && y >= 0) Console.WriteLine("2 kvadrant");
            else if (x < 0 && y < 0)
            {
                answer3++;
                Console.WriteLine("3 kvadrant");
            }
            else Console.WriteLine("4 kvadrant");
        }
        Console.WriteLine($"{answer1} - v 1 kvadrante,{answer3} - v 3 kvadrante");
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here

        double minimalLegth = -1, minimal = -1, x, y, r;
        for (int i = 0; i < n; i ++)
        {
            Console.WriteLine($"Input {i + 1} point:");
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            r = Math.Round(Math.Sqrt(x * x + y * y), 2);
            if (minimalLegth == -1)
            {
                minimal = i + 1;
                minimalLegth = r;
            }
            else if (r < minimalLegth)
            {
                minimal = i + 1;
                minimalLegth = r;
            }
        }
        Console.WriteLine($"Point number {minimal} on distance {minimalLegth}");
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here

        double best = -1, current;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out current);
            if (best == -1) best = current;
            else if (current < best) best = current;
        }
        Console.WriteLine(best);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;

        for (int i = 0; i < n; i ++)
        {
            bool fl = true;
            Console.WriteLine($"Input {i + 1} student marks:");
            for (int j = 0; j < 4; j ++)
            {
                int mark;
                int.TryParse(Console.ReadLine(), out mark);
                if (mark == 2 || mark == 3) fl = false;
            }
            if (fl) answer++;
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

        double sm = 0;
        for (int i = 0; i < n; i++)
        {
            bool fl = false;
            Console.WriteLine($"Input {i + 1} student marks:");
            for (int j = 0; j < 4; j++)
            {
                int mark;
                int.TryParse(Console.ReadLine(), out mark);
                sm += mark;
                if (mark == 2) fl = true;
            }
            if (fl) answer++;
        }
        avg = Math.Round(sm / n / 4, 9);
        Console.WriteLine($"{answer} unsuccessfull students, avg = {avg}");
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;

        if (r <= 0 || !(type >= 0 && type <= 2)) return 0;
        switch (type)
        {
            case 0: answer = Math.Round(r * r, 2); break;
            case 1: answer = Math.Round(r * r * Math.PI, 2); break;
            case 2: answer = Math.Round(r * r * Math.Sqrt(3) / 4, 2); break;
        }    

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;

        if (A <= 0 || B <= 0 || !(type >= 0 && type <= 2)) return 0;
        switch (type)
        {
            case 0: answer = Math.Round(A * B, 2); break;
            case 1:
                if (A > B) answer = Math.Round(A * A * Math.PI - B * B * Math.PI, 2);
                else answer = Math.Round(B * B * Math.PI - A * A * Math.PI, 2);
                break;
            case 2:
                double p = (A + B + B) / 2;
                answer = Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - B)), 2);
                break;
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
        bool stop = false;
        for (int i = 0;; i++)
        {
            stop = !double.TryParse(Console.ReadLine(), out weight);
            if (stop) break;
            if (weight < 30) answer += 0.2;
        }
        answer = Math.Round(answer, 1);
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

        bool stop = false;
        double x, y;
        for (int i = 0; ; i++)
        {
            Console.WriteLine($"Input {i + 1} point:");
            stop = !double.TryParse(Console.ReadLine(), out x);
            if (stop) break;
            stop = !double.TryParse(Console.ReadLine(), out y);
            if (stop) break;
            if (y >= 0 && x >= 0 && x <= Math.PI && y <= Math.Sin(x)) answer += 1;
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

        bool stop = false;
        double best = -1, current;
        for (int i = 0; i < n; i++)
        {
            stop = !double.TryParse(Console.ReadLine(), out current);
            if (stop) break;
            if (best == -1) best = current;
            else if (current < best) best = current;
        }
        Console.WriteLine(best);
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