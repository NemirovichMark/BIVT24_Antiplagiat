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
        double r = 2;
        if (Math.Abs((x * x)+(y * y)-(r * r))<=0.001)
        {
            answer = true;
        }
        else 
        {
            answer = false;
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && (y + Math.Abs(x)) <= 1)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        double c = 0;
        if (a > 0)
        {
            if (a > b)
            {
                c = a;
            }
            else 
            c = b;
        }
         else if (a <= 0)
        {
            if (a < b)
            {
                c = a;
            }
            else 
            c = b;
        }
        answer = c;
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double min = 0;
        double z = 0;
        if (a > b)
        {
            min = b;
        }
        else 
        min = a;
        if (c > min)
        {
            z = c;
        }
        else 
        z = min;
        answer = z;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double D1 = r / Math.PI;
        D1 = Math.Sqrt(D1) * 2;
        double D2 = Math.Sqrt(s + s);
        if (D2 <= D1)
        {
            answer = true;
        }
        else 
        {
            answer = false;
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double D1 = r / Math.PI;
        D1 = Math.Sqrt(D1) * 2;
        double D2 = Math.Sqrt(s);
        if (D1 <= D2)
        {
            answer = true;
        }
        else 
        {
            answer = false;
        }
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        if (Math.Abs(x) > 1)
        {
            y = 1;
        }
        else if (Math.Abs(x) <= 1)
        {
            y = Math.Abs(x);
        }
        answer = y;
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        if (Math.Abs(x) >= 1)
        {
            y = 0;
        }
        else if (Math.Abs(x) < 1)
        {
            y = x * x - 1;
        }
        answer = y;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        if (Math.Abs(x) <= -1)
        {
            y = 0;
        }
        else if (x > -1 && x <= 0)
        {
            y = 1 + x;
        }
        else if (x > 0)
        {
            y = 1;
        }
        answer = y;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        if (x <= -1)
        {
            y = 1;
        }
        else if (x > -1 && x <= 1)
        {
            y = -x;
        }
        else if (x > 1)
        {
            y = -1;
        }
        answer = y;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double rost = 0, s = 0, sr = 0;
        for (int i = 1; i <= n; i++)
        {
            rost = double.Parse(Console.ReadLine());
            s += rost;
        }
        sr = s / n;
        answer = sr;
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x = 0;
        double y = 0;
        for (int i = 1; i <= n; i += 1)
        {
            x = double.Parse(System.Console.ReadLine());
            y = double.Parse(System.Console.ReadLine());
            double d = Math.Sqrt(Math.Pow(x - a, 2) + Math.Pow(y - b, 2));
            if (d <= r)
            {
                answer += 1;
            }
        }
        Console.WriteLine(answer);
        
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double weight = 0;
        double m = 0;
        for (int i = 1; i <= n; i += 1)
        {
            weight = double.Parse(System.Console.ReadLine());
            if (weight < 30)
            {
                m += 0.2;
            }
        }
        answer += m;
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i += 1)
        {
            double x = double.Parse(System.Console.ReadLine());
            double y = double.Parse(System.Console.ReadLine());
            double d = Math.Sqrt((x * x) + (y * y));
            if (d >= r1 && d <= r2)
            {
                answer += 1;
            }
        }
        System.Console.WriteLine(answer);
        // додо
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double results = 0;
        for(int i = 1; i <= n; i += 1)
        {
            results = double.Parse(System.Console.ReadLine());
            if (results <= norm)
            {
                answer += 1;
            }
        }
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x >= 0 && y >= 0 && x <= Math.PI && y <= Math.Sin(x))
            {
                answer += 1;
            }
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
        int answer2 = 0;
        int answer4 = 0;
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                answer1 += 1;
                System.Console.WriteLine("1 квадрант");
            }
            else if (x < 0 && y < 0)
            {
                answer3 += 1;
                System.Console.WriteLine("3 квадрант");

            }
            else if (x > 0 && y < 0)
            {
                answer2 += 1;
                System.Console.WriteLine("2 квадрант");
            }
            else if (x < 0 && y > 0)
            {
                answer4 += 1;
                System.Console.WriteLine("4 квадрант");
            }
        }
        System.Console.WriteLine($" 1 квадрант {answer1}");
        System.Console.WriteLine($" 3 квадрант {answer3}");

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double d = 0;
        n = 4;
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            d = Math.Sqrt((x * x) + (y * y));
            if (answerLength > d)
            {
                answer = i;
                answerLength = d;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        System.Console.WriteLine(answerLength);
        System.Console.WriteLine(answer);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double m1 = double.Parse(Console.ReadLine());
            if (answer > m1)
            {
                answer = m1;
            }
        }
        System.Console.WriteLine($"best time {answer}");
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 1; i <= n; i++)
        {
            double o1 = double.Parse(Console.ReadLine());
            double o2 = double.Parse(Console.ReadLine());
            double o3 = double.Parse(Console.ReadLine());
            double o4 = double.Parse(Console.ReadLine());
            if (o1 > 3 && o2 > 3 && o3 > 3 && o4 > 3)
            {
                answer += 1;
            }
        }
        System.Console.WriteLine($"students {answer}");
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double sum = 0;
        double o = 0;
        for (int i = 1; i <= n; i ++)
        {
            double o1 = double.Parse(Console.ReadLine());
            double o2 = double.Parse(Console.ReadLine());
            double o3 = double.Parse(Console.ReadLine());
            double o4 = double.Parse(Console.ReadLine());
            if (o1 <= 3 || o2 <= 3 || o3 <= 3 || o4 <= 3)
            {
                answer += 1;
            }
            sum += o1 + o2 + o3 + o4;
            o += 4;
        }
        avg = sum / o;
        System.Console.WriteLine($"students {answer} sr {avg}");
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r <= 0 || type < 0 || type > 2) return 0;
        switch (type)
        {
            case  0:
                answer = r * r;
                break;
            case  1:
                answer = Math.PI * r * r;
                break;
            case  2:
                answer = r * r * Math.Sqrt(3) / 4;
                break;
        }
        answer = Math.Round(answer , 2);
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A <= 0 || B <= 0 || type < 0 || type > 2) return 0;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs(Math.PI * ((A * A) - (B * B)));
                break;
            case 2:
                answer = Math.Sqrt(B * B - (A * A / 4)) * 0.5 * A;
                break;
        }
        answer = Math.Round(answer, 2);
        System.Console.WriteLine(answer);
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
        double rost = 0, s = 0, sr = 0;
        while (true)
        {
            System.Console.WriteLine("введите start или stop");
            string start = Console.ReadLine();
            if (start == "stop") break;
            else if (start == "start")
            {
                rost = double.Parse(Console.ReadLine());
                s += rost;
                n += 1;
            }
            sr = s / n;
            answer = sr;
        }
        System.Console.WriteLine(answer);
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

        // end

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here
        double x = 0;
        double y = 0;
        while (true)
        {
            System.Console.WriteLine("введите start или stop");
            string start = Console.ReadLine();
            if (start == "stop") break;
            else if (start == "start")
            x = double.Parse(System.Console.ReadLine());
            y = double.Parse(System.Console.ReadLine());
            double d = Math.Sqrt((x * x) + (y * y));
            if (d >= r1 && d <= r2)
            {
                answer += 1;
            }
        }
        System.Console.WriteLine(answer);
        
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

        // end

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here
        double x = 0, y = 0;
        while (true)
        {
            System.Console.WriteLine("введите start или stop");
            string start = Console.ReadLine();
            if (start == "stop") break;
            else if (start == "start")
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                answer1 += 1;
            }
            else if (x < 0 && y < 0)
            {
                answer3 += 1;
            }
        }
        System.Console.WriteLine($" 1 квадрант {answer1}");
        System.Console.WriteLine($" 2 квадрант {answer3}");
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

        // end

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;
        double o1 = 0, o2 = 0, o3 = 0, o4 = 0;
        while (true)
        {
            System.Console.WriteLine("введите start или stop");
            string start = Console.ReadLine();
            if (start == "stop") break;
            else if (start == "start")
            o1 = double.Parse(Console.ReadLine());
            o2 = double.Parse(Console.ReadLine());
            o3 = double.Parse(Console.ReadLine());
            o4 = double.Parse(Console.ReadLine());
            if (o1 > 3 && o2 > 3 && o3 > 3 && o4 > 3)
            {
                answer += 1;
            }
        }
        System.Console.WriteLine($"students {answer}");

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