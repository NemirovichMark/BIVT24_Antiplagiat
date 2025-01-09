using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

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
        program.Task_2_12(10, 0);
        program.Task_2_13(10, 5, 0);
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
        if (Math.Abs(x * x + y * y - r * r) <= 0.0001)
        {
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && y + Math.Abs(x) <= 1)
            answer = true;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)
            if (a > b) answer = a; else answer = b;
        else
            if (a < b) answer = a; else answer = b;
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        double minimum = 0;
        // code here
        if (a > b) minimum = b; else minimum = a;
        if (minimum > c) answer = minimum; else answer = c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;
        double side = Math.Sqrt(s);
        double diagonal = side * Math.Sqrt(2);
        double diametr = 2 * Math.Sqrt(r / Math.PI);

        // code here
        if (diagonal <= diametr)
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;
        double side = Math.Sqrt(s);
        double radius = Math.Sqrt(r / Math.PI);

        // code here
        if (radius <= side / 2)
            answer = true;
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
        double s = 0, i = 0;
        while (i < n)
        {
            double height = double.Parse(Console.ReadLine());
            s += height;
            i++;
        }
        answer = (s / n);
        // end
        Console.WriteLine(answer);
        return answer;
        
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here

        while (n > 0)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if (((x < r + a) && (x > a - r)) && ((y < r + b) && (y > b - r)))
                answer++;
            n--;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        while (n > 0)
        {
            double weight = double.Parse(Console.ReadLine());
            if (weight < 30.0)
            {
                answer += 0.2;
            }
            n--;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        while (n > 0)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if (Math.Sqrt(x * x + y * y) <= r2 && Math.Sqrt(x * x + y * y) >= r1)
            {
                answer++;
            }    
            n--;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        while (n > 0)
        {
            double result = double.Parse(Console.ReadLine());

            if (result <= norm)
            {
                answer++;
            }
            n--;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        while (n > 0)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if ((x > 0 && x < Math.PI) && (y > 0 && y < Math.Sin(x)))
            {
                answer++;
            }
            n--;
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
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x > 0)
            {
                if (y > 0)
                {
                    answer1++;
                    Console.WriteLine(" вадрант 1");
                }
                else
                {
                    Console.WriteLine(" вадрант 4");
                }
            }
            else
            {
                if (y > 0)
                {
                    Console.WriteLine(" вадрант 2");
                }
                else
                {
                    answer3++;
                    Console.WriteLine(" вадрант 3");
                }
            }
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
        int count = 0;

        while (n > 0)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double length = Math.Sqrt(x * x + y * y);
            count++;
            
            if (length < answerLength)
            {
                answerLength = length;
                answer = count;
            }
            n--;
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine($"{answer} {answerLength}");
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        while (n > 0)
        {
            double result = double.Parse(Console.ReadLine());

            if (result <= answer)
            {
                answer = result;
            }
            n--;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        while (n > 0) 
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            if (a > 3 && b > 3 && c > 3 && d > 3) answer++;
            n--;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0, i = n;
        double avg = 0.0;
        double sum = 0.0;
        // code here;
        while (n > 0)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            if (a == 2 || b == 2 || c == 2 || d == 2) answer++;
            sum += a + b + c + d;
            n--;
        }
        avg = sum / (4 * i);
        Console.WriteLine($"{answer} {avg}");
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r < 0) return 0;
        switch (type)
        {
            case 0: answer = r * r; break;
            case 1: answer = Math.PI * r * r; break;
            case 2: answer = Math.Sqrt(3) * r * r / 4; break;
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
        switch (type)
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
        
        // end

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here
        while (true)
        {
            string R = Console.ReadLine();
            if (R == "") break;
            double.TryParse(R, out double W);
            if (W < 30)
            {
                answer += 0.2;
            }
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
        string s1, s2;

        // code here
        while (true)
        {
            s1 = Console.ReadLine();
            if (s1 == "") break;
            s2 = Console.ReadLine();
            double.TryParse(s1, out double x);
            double.TryParse(s2, out double y);

            if ((x >= 0) && (x <= Math.PI) && (Math.Sin(x) >= y) && (y >= 0))
            {
                answer += 1;
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
        string s1;

        // code here
        while (true)
        {
            s1 = Console.ReadLine();
            if (s1 == "") break;

            double.TryParse(s1, out double result);
            if (result <= answer) answer = result;
        }
        // end
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