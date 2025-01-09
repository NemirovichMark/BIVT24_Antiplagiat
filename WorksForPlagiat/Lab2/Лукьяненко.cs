using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

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
        if (Math.Abs(x * x + y * y - r * r) <= 0.001)
            answer = true;
        else
            answer = false;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if ((y >= 0) && (y + Math.Abs(x) <= 1))
        {
            answer = true;
        }
        else answer = false;


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
        else
            if (a > b) answer = b;
        else answer = a;
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        double mab = 0;
        // code here
        if (a > b) mab = b;
        else mab = a;
        if (mab > c) answer = mab;
        else answer = c;
        // end
        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (r * r * 4 > 4 * s) answer = true;
        else answer = false;
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (s >= 4 * r / Math.PI) answer = true; else answer = false;
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;
        // code here
        if (x > 1) answer = 1;
        else answer = Math.Abs(x);
        // end
        return Math.Round(answer, 1);
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1) answer = 0;
        else answer = x * x - 1;
        // end
        Console.WriteLine(Math.Round(answer, 2));
        return Math.Round(answer, 2);
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 0;
        else if ((0 >= x) && (x > -1)) answer = x + 1;
        else answer = 1;

        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        else if ((-1 < x) && (x <= 1)) answer = -x;
        else answer = -1;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        double sum = 0;
        // code here
        for (double i = 1; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double R);

            sum += R;
            answer = sum / i;
        }
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (double i = 1; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double A);
            double.TryParse(Console.ReadLine(), out double B);
            if ((r >= Math.Abs(B)) && (r >= Math.Abs(A))) answer += 1;
        }
        // end
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        double R = 0;
        // code here
        for (double i = 0; i < n; i++)
        {
            R = double.Parse(Console.ReadLine());
            if (R < 30)
            {
                answer += 0.2;
            }
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        // code here
        for (double i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double t1);
            double.TryParse(Console.ReadLine(), out double t2);
            if ((t1 + t2 > r1) && (t1 + t2 < r2)) answer += 1;
        }
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        Console.WriteLine(answer);

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        int normal = 30;
        // code here
        for (double i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double result);
            if (normal >= result) answer += 1;
        }
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        Console.WriteLine(answer);
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
            if ((x >= 0) && (x <= Math.PI) && (Math.Sin(x) >= y) && (y >= 0))
            {
                  answer += 1;
            }
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

        // code here
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double x);
            double.TryParse(Console.ReadLine(), out double y);
            if ((x > 0) && (y > 0))
            {
                answer1 += 1;
                Console.WriteLine("3");
            }
            if ((x < 0) && (y < 0))
            {
                answer3 += 1;
                Console.WriteLine("1");
            }
            if ((x > 0) && (y < 0))
            {
                Console.WriteLine("2");
            }
            if ((x < 0) && (y > 0))
            {
                Console.WriteLine("4");
            }
        }
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        n = 5;
        // code here
        double dl = 0, mdl = 435834785987834895;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out double x);
            double.TryParse(Console.ReadLine(), out double y);
            dl = x * x + y * y;
            if (mdl > dl)
            {
                answerLength = Math.Sqrt(dl);
                answer = i;
            }
        }
        // end
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        n = 6;
        // code here
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double R);
            if (answer >= R) answer = R;

                 
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        n = 10;
        // code here;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double m1);
            double.TryParse(Console.ReadLine(), out double m3);
            double.TryParse(Console.ReadLine(), out double m2);
            double.TryParse(Console.ReadLine(), out double m4);
            if ((m1 != 2) && (m1 != 3) && (m2 != 2) && (m2 != 3) && (m3 != 2) && (m3 != 3) && (m4 != 2) && (m4 != 3)) answer += 1;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public (int, double) Task_2_11(double n)
    {
        int answer = 0;
        double avg = 0.0;
        n = 10;
        // code here;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double m1); 
            double.TryParse(Console.ReadLine(), out double m3); 
            double.TryParse(Console.ReadLine(), out double m2);
            double.TryParse(Console.ReadLine(), out double m4);
            avg += m1 + m2 + m3 + m4;
         
            if ((m1 != 2)  && (m2 != 2) &&  (m3 != 2) &&  (m4 != 2)) answer += 1;
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        avg = avg / (n * 4);
        Console.WriteLine(avg);
        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r > 0)
        {
            switch (type)
            {
                case 0:
                    answer = r * r;
                    break;
                case 1:
                    answer = Math.PI * (r * r);
                    break;
                case 2:
                    answer = Math.Sqrt(3) / 4 * (r * r);
                    break;
                default:
                    answer = 0;
                    break;
            }
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
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs(A * A * Math.PI - B * B * Math.PI);
                break;
            case 2:
                answer = 0.5 * A * Math.Sqrt(B * B - 0.25 * A * A);
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

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;
        string R; // условие выхода
        // code here
        while (true) 
        {

            R = Console.ReadLine();
            if (R == "") break;
            double.TryParse(R, out double W);
            if (W < 30)
            {
                answer += 0.2;
            }
        }
        Console.WriteLine(answer);
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

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer

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
            double.TryParse(s1, out double x);
            double.TryParse(Console.ReadLine(), out double y);

            if ((x >= 0) && (x <= Math.PI) && (Math.Sin(x) >= y) && (y >= 0))
            {
                answer += 1;
            }
        }
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

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_8 answer

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
            double.TryParse(s1, out double R);
            if (answer >= R) answer = R;


        }
        // end
        Console.WriteLine(answer);
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
