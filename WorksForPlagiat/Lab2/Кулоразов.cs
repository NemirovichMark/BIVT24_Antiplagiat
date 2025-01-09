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
        //program.Task_2_1(10);             //1
        //program.Task_2_2(5, 3, 2, 1);     //1
        //program.Task_2_2(5, 1.5, 1.5, 1); //1
        //program.Task_2_2(5, 1, 3, 1);     //1
        //program.Task_2_3(10);             //1
        //program.Task_2_3(8);              //1
        //program.Task_2_3(6);              //1
        //program.Task_2_4(5, 1, 2);        //1
        //program.Task_2_4(5, 1, 3);        //1
        //program.Task_2_4(4, 1, 2);        //1
        //program.Task_2_4(4, 1, 3);        //1
        //program.Task_2_4(3, 1, 2);        //1
        //program.Task_2_4(3, 1, 3);        //1
        //program.Task_2_5(10, 30);         //1
        //program.Task_2_5(10, 25.2);       //1
        //program.Task_2_5(8, 30);          //1
        //program.Task_2_5(8, 25.2);        //1
        //program.Task_2_5(6, 30);          //1
        //program.Task_2_5(6, 25.2);        //1
        //program.Task_2_6(5);              //1
        //program.Task_2_6(4);              //1
        //program.Task_2_6(3);              //1
        //program.Task_2_7(5);              //1
        //program.Task_2_7(4);              //1
        //program.Task_2_7(3);              //1
        //program.Task_2_8(5);              //1
        //program.Task_2_8(4);              //1
        //program.Task_2_8(3);              //1
        //program.Task_2_8(0);              //1
        //program.Task_2_9(10);             //1
        //program.Task_2_9(8);              //1
        //program.Task_2_9(6);              //1
        //program.Task_2_9(0);              //1
        //program.Task_2_10(10);            //1
        //program.Task_2_10(8);             //1
        //program.Task_2_10(6);             //1
        //program.Task_2_11(10);            //1
        //program.Task_2_11(8);             //1
        //program.Task_2_11(6);             //1
        //program.Task_2_11(0);             //1
        //program.Task_2_12(10, 0);         //1
        //program.Task_2_13(3,2.5,1);       //1
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();//10           //1
        //program.Task_3_3();//8            //1
        //program.Task_3_3();//6            //1
        //program.Task_3_4(1, 2);
        //program.Task_3_5(30);
        //program.Task_3_6();//5            //1
        //program.Task_3_6();//4            //1
        //program.Task_3_6();//3            //1
        //program.Task_3_7();
        //program.Task_3_8();
        //program.Task_3_9();//10           //1
        //program.Task_3_9();//8            //1
        //program.Task_3_9();//6            //1
        //program.Task_3_9();//0            //1
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
        if (Math.Abs(x * x + y * y - r * r) <= 0.001)
            answer = true;
        else
            answer = false;
        Console.WriteLine(answer);
        Console.WriteLine(Math.Abs(x * x + y * y - r * r));

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        if (y >= 0 && y + Math.Abs(x) <= 1)
            answer = true;
        else
            answer = false;

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        if (a > 0)
        {
            if (a > b)
                answer = a;
            else
                answer = b;
        }
        else
        {
            if (a > b)
                answer = b;
            else
                answer = a;
        }

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        double p = 0;
        if (a > b)
            p = b;
        else
            p = a;
        if (p > c)
            answer = p;
        else
            answer = c;

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        r = Math.Sqrt(r / Math.PI);
        s = Math.Sqrt(s);
        s = Math.Sqrt(2) * s;
        if (s <= r * 2)
            answer = true;
        else
            answer = false;

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        r = Math.Sqrt(r / Math.PI);
        s = Math.Sqrt(s);
        if (2 * r <= s)
            answer = true;
        else
            answer = false;

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        if (Math.Abs(x) > 1)
            answer = 1;
        else
            answer = Math.Abs(x);

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        if (Math.Abs(x) >= 1)
            answer = 0;
        else
            answer = x * x - 1;

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        if (x <= -1)
            answer = 0;
        else
            if (x > 0)
            answer = 1;
        else
            answer = 1 + x;

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        if (x <= -1)
            answer = 1;
        else
            if (x > 1)
            answer = -1;
        else
            answer = -x;

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        for (int i = 1; i <= n; i++)
            answer += double.Parse(Console.ReadLine());
        answer = answer / n;
        answer = Math.Round(answer, 1);
        Console.WriteLine(answer);

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(),out double x);
            double.TryParse(Console.ReadLine(),out double y);
            if ((a - x) * (a - x) + (b - y) * (b - y) <= r*r)
                answer = answer + 1;
        }
        Console.WriteLine(answer);

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        double x = 0;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            if (x < 30)
                answer = answer + 0.2;
        }
        answer = Math.Round(answer,1);
        Console.WriteLine(answer);

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        double x = 0;
        double y = 0;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x * x + y * y - r1 * r1 >= 0 && x * x + y * y - r2 * r2 <= 0)
                answer = answer + 1;
        }
        Console.WriteLine(answer);
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        double x = 0;

        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            if (x < norm)
                answer = answer + 1;
        }
        Console.WriteLine("answer = {0}", answer);

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        double x = 0;
        double y = 0;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
                answer = answer + 1;
        }
        Console.WriteLine("answer = {0}", answer);
        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        double x = 0;
        double y = 0;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                answer1 = answer1 + 1;
                Console.WriteLine("answer = 1");
            }
            if (x < 0 && y < 0)
            {
                answer3 = answer3 + 1;
                Console.WriteLine("answer = 3");
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("answer = 2");
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("answer = 4");
            }
        }
        Console.WriteLine("answer1 = {0}", answer1);
        Console.WriteLine("answer3 = {0}", answer3);

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = -1;
        double answerLength = double.MaxValue;

        double x = 0;
        double y = 0;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (answerLength > Math.Sqrt(x * x + y * y))
            {
                answerLength = Math.Sqrt(x * x + y * y);
                answer = i;
            }
        }
        if (answer == -1)
        {
            answer = 0; 
            answerLength = 0;
        }
        Console.WriteLine("answer = {0}\tanswerLength = {1:f2}", answer, answerLength);
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        double x = 0;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            if (x < answer)
            {
                answer = x;
            }
        }
        if (answer == double.MaxValue)
            answer = 0;
        answer = Math.Round(answer, 1);
        Console.WriteLine(answer);

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        for (int i = 1; i <= n; i++)
        {
            bool flag = true;
            for (int j = 1; j <= 4; j++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a == 2 || a == 3)
                    flag = false;
            }
            if (flag)
                answer += 1;
        }
        Console.WriteLine("answer = {0}",answer);
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        for (int i = 1; i <= n; i++)
        {
            bool flag = true;
            for (int j = 1; j <= 4; j++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a == 2)
                    flag = false;
                avg += a;
            }
            if (flag == false)
                answer += 1;
        }
        if(n>0)
            avg = avg / (n * 4);
        else 
            avg = 0;
        Console.WriteLine("answer = {0}\tavg = {1:f2}", answer, avg);
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        //double.TryParse(Console.ReadLine(), out double a);
        if (r >= 0)
        {
            switch (type)
            {
                case 0:
                    answer = r * r;
                    break;
                case 1:
                    answer = Math.PI * r * r;
                    break;
                case 2:
                    answer = r * r * Math.Sqrt(3) / 2 / 2;
                    break;
                default:
                    answer = 0;
                    break;
            }
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        if (A >= 0 && B >= 0)
        {
            switch (type)
            {
                case 0:
                    answer = A * B;
                    break;
                case 1:
                    answer = Math.PI * Math.Abs(A * A - B * B);
                    break;
                case 2:
                    if (A<B*2)
                        answer = A * Math.Sqrt(B * B - (A / 2) * (A / 2)) / 2;
                    break;
                default:
                    answer = 0;
                    break;
            }
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);

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

        while (true)
        {
            string x = Console.ReadLine();
            if (double.TryParse(x, out double a))
            {
                if (a < 30)
                {
                    answer = answer + 0.2;
                }
            }
            else
                break;
        }
        answer = Math.Round(answer, 1);
        Console.WriteLine("ansvwer = {0}", answer);

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
        int answer = 0;

        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                if (double.TryParse(Console.ReadLine(), out double y))
                {
                    if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
                        answer = answer + 1; ;
                }
                else
                    break;
            }
            else
                break;
        }
        Console.WriteLine(answer);

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

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_8 answer

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;

        while (double.TryParse(Console.ReadLine(), out double x))
        {
            if (x < answer||answer==0)
                answer = x;
        }
        if (answer == double.MaxValue)
            answer = 0;
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
