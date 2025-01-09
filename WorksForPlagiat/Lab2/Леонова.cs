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
        //program.Task_2_4(3, 1, 3);
        //program.Task_2_5(6, 25.2);
        //program.Task_2_6(4);
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
        //program.Task_3_4(1, 3);
        //program.Task_3_5(30);
        //program.Task_3_6();
        //program.Task_3_7();
        //program.Task_3_8();
        //program.Task_3_9();
        program.Task_3_10();
        //program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        double a = 0;
        a = x * x + y * y - 4;
        if (Math.Abs(a) <= Math.Pow(10, -3)) answer = true;
        else answer = false;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if ((y >= 0) && ((y + Math.Abs(x)) <= 1)) answer = true;
        else answer = false;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        double max = 0, min = 0;
        if (a > b)
        {
            min = b;
            max = a;
        }
        else
        {
            min = a;
            max = b;
        }
        if (a > 0)
        {
            answer = max;
        }
        else
        {
            answer = min;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double n=0;
        if (a > b) n = b;
        else n = a;
        if (n > c) answer = n;
        else answer = c;
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
        if ((-1 < x) && (x <= 0)) answer = 1 + x;
        if (x > 0) answer = 1;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        if ((-1 < x) && (x <= 1)) answer = -x;
        if (x > 1) answer = -1;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        int i = n;
        while (i>0)
        {
            answer += Convert.ToDouble(Console.ReadLine());
            i--;
        }
        answer /= n;
        Console.WriteLine(answer);
        // end

        return answer;
        //yep
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int i = n; i > 0; i--)
        { 
            double x= Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double p = Math.Sqrt(Math.Pow(x - a, 2) + Math.Pow(y - b, 2));
            if (p <= r) answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
        //yep
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for (int i = n; i > 0; i--)
        {
            double w = Convert.ToDouble(Console.ReadLine());
            if (w < 30) answer += 0.2;
        }
        Console.WriteLine(answer);
        // end

        return answer;
        //yep
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = n; i > 0; i--)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double p = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            if ((p <= r2) && (p>=r1)) answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
        //yep
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        int i = n;
        while (i>0)
        {
            double result = Convert.ToDouble(Console.ReadLine());
            if (result <= norm)
            {
                answer++;
            } 
            i -= 1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
        //yep
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
        //yep
        
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
                Console.WriteLine("1 qvadrat");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("4 qvadrat");
            }
            else if (x < 0 && y < 0)
            {
                answer3++;
                Console.WriteLine("3 qvadrat");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("2 qvadrat");
            } 

        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        // end

        return (answer1, answer3);
        //yep
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        for (int i = n; i > 0; i--)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double a = Math.Sqrt(x * x + y * y);
            if (a < answerLength)
            {
                answer = i;
                answerLength = a;
            }
        }
        Console.WriteLine(answer);
        // end

        return (answer, answerLength);
        //yep
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = n; i > 0; i--)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            if (a< answer) answer=a;
        }
        Console.WriteLine(answer);
        // end

        return answer;
        //yep
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = n; i > 0; i--)
        {
            double k1 = Convert.ToDouble(Console.ReadLine());
            double k2 = Convert.ToDouble(Console.ReadLine());
            double k3 = Convert.ToDouble(Console.ReadLine());
            double k4 = Convert.ToDouble(Console.ReadLine());
            if (k1 != 2 && k1 != 3 && k2 != 2 && k2 != 3 && k3 != 2 && k3 != 3 && k4 != 2 && k4 != 3)
            {
                answer++;
            }    
        }
        Console.WriteLine(answer);
        // end

        return answer;
        //yep
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double sum1 = 0, sum2 = 0;
        for (int i = n; i > 0; i--)
        {
            double v1 = Convert.ToDouble(Console.ReadLine());
            double v2 = Convert.ToDouble(Console.ReadLine());
            double v3 = Convert.ToDouble(Console.ReadLine());
            double v4 = Convert.ToDouble(Console.ReadLine());
            sum2++;
            if (v1 == 2 || v2 == 2 || v3 == 2 || v4 == 2)
            {
                answer++;
            }
            sum1 += v1 + v2 + v3 + v4;
        }
        avg = sum1 / (sum2 * 4);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
        //yep
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r > 0)
        { 
            switch (type)
            {
                case 0: answer = r * r; break;
                case 1: answer = Math.PI * r * r; break;
                case 2: answer = r * r * Math.Sqrt(3) / 4; break;
                default:
                    answer = 0; break;
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
        if (A>0 && B>0)
        {
            switch (type)
            {
                case 0: answer = A*B; break;
                case 1: answer = Math.Abs(Math.PI * A * A - Math.PI * B * B); break;
                case 2: answer = Math.Sqrt(B * B - A * A / 4) * A / 2; break;
                default:
                    answer = 0; break;
            }
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
        int n = 0, i=0;

        // code here
        for (; ; i++)
        {
            string input = Console.ReadLine();
            if (input != "out")
            {
                answer += Convert.ToDouble(input);
            }
            else break;
        }
        answer /= i;
        Console.WriteLine(answer);
        // end

        // answer should be equal to the task_2_1 answer
        //yep
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
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here
        for (; ; )
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            if (input1 != "out" && input2 != "out")
            {
                double x = Convert.ToDouble(input1);
                double y = Convert.ToDouble(input2);
                double p = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                if ((p <= r2) && (p >= r1)) answer++;
            }
            else break;
        }
        Console.WriteLine(answer);
        // end

        return answer;
        //вроде yep
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
        for (; ; )
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            if (input1 != "out" && input2 != "out")
            {
                double x = Convert.ToDouble(input1);
                double y = Convert.ToDouble(input2);
                if (x > 0 && y > 0)
                {
                    answer1++;
                    Console.WriteLine("1 qvadrat");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("4 qvadrat");
                }
                else if (x < 0 && y < 0)
                {
                    answer3++;
                    Console.WriteLine("3 qvadrat");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("2 qvadrat");
                }
            }
            else break;
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        // end

        return (answer1, answer3);
        //вроде yep
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
        int answer = 0, n = 0;

        // code here;
        for (; ; )
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            string input4 = Console.ReadLine();
            if (input1 != "out" && input2 != "out" && input3 != "out" && input4 != "out")
            {
                double k1 = Convert.ToDouble(input1);
                double k2 = Convert.ToDouble(input2);
                double k3 = Convert.ToDouble(input3);
                double k4 = Convert.ToDouble(input4);
                if (k1 != 2 && k1 != 3 && k2 != 2 && k2 != 3 && k3 != 2 && k3 != 3 && k4 != 2 && k4 != 3)
                {
                    answer++;
                }
            }
            else break;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;
        //double sum1 = 0, sum2 = 0;
        //int i = 0;
        //for (; ;i++ )
        //{
        //    string input1 = Console.ReadLine();
        //    string input2 = Console.ReadLine();
        //    string input3 = Console.ReadLine();
        //    string input4 = Console.ReadLine();
        //    if (input1 != "out" && input2 != "out" && input2 != "out" && input3 != "out")
        //    {
        //        double v1 = Convert.ToDouble(input1);
        //        double v2 = Convert.ToDouble(input2);
        //        double v3 = Convert.ToDouble(input3);
        //        double v4 = Convert.ToDouble(input4);
        //        sum2++;
        //        if (v1 == 2 || v2 == 2 || v3 == 2 || v4 == 2)
        //        {
        //            answer++;
        //        }
        //        sum1 += v1 + v2 + v3 + v4;
                
        //    }
            
        //    else break;
        //}
        //avg = sum1 / (sum2 * 4);
        //Console.WriteLine(answer);
        //Console.WriteLine(avg);

        // end

        return (answer, avg);
        //yep
    }
    #endregion
}