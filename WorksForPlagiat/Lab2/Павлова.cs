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

        double d = 0;
        d = Math.Sqrt((x * x) + (y * y));
        if (d == 2)
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

        if (y>=0 && y+Math.Abs(x)<=1)
        {
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
        }
        else
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

        double mn;
        if (a < b)
        {
            mn = a;
        }
        else
        {
            mn= b;
        }
        if (c > mn)
        {
            answer = c;
        }
        else
        {
            answer = mn;
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double radius = Math.Sqrt(r / (Math.PI));
        double a = Math.Sqrt(s);
        double b = Math.Sqrt(2)*a;

        if (b<=2*radius)
        {
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double diametr = 2 * Math.Sqrt(r / (Math.PI));
        double a = Math.Sqrt(s);

        if (diametr<=a)
        {
            answer = true;
        }
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here

        if (Math.Abs(x)>1)
        {
            answer = 1;
        }
        else if (Math.Abs(x)<=1)
        {
            answer = Math.Abs(x);
        }
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here

        if (Math.Abs(x) >= 1)
        {
            answer = 0;
        }
        else if (Math.Abs(x) < 1)
        {
            answer = x*x-1;
        }
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here

        if (x <= -1)
        {
            answer = 0;
        }
        else if (-1 < x && x <= 0)
        {
            answer = 1 + x;
        }
        else 
        {
            answer = 1;
        }
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here

        if (x<= -1)
        {
            answer = 1;
        }
        else if (-1<x && x<=1)
        {
            answer = -x;
        }
        else 
        {
            answer = -1;
        }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here

        double s = 0;
        for (int i = 1; i <= n; i++)
        {
            s += double.Parse(Console.ReadLine());
        }
        answer = s/n;
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
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
            {
                answer++;
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

        for (int i = 1; i <= n; i++)
        {
            double weight = double.Parse(Console.ReadLine());
            if (weight < 30) answer++;
        }
        answer *= 0.2;
        Console.WriteLine(Math.Round(answer, 1));
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here

        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (Math.Sqrt((x) * (x) + (y) * (y)) >= r1 && Math.Sqrt((x) * (x) + (y) * (y)) <= r2)
            {
                answer++;
            }
        }
        Console.Write(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i = 1;i <= n; i++)
        {
            double x = double.Parse((Console.ReadLine()));
            if (x <= norm) answer++;

        }
        Console.WriteLine (answer);
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
            if (x >= 0 && x <= Math.PI && y <= Math.Sin(x) && y >= 0) answer++;
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
            if (x > 0 && y > 0)
            {
                Console.WriteLine("1");
                answer1++;
            }
            if (x < 0 && y > 0)
                Console.WriteLine("2");
            if (x < 0 && y < 0)
            {
                Console.WriteLine("3");
                answer3++;
            }
            if (x > 0 && y < 0)
                Console.WriteLine("4");
        }
        Console.WriteLine($"{answer1}, {answer3}");
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double dlina = 10000000.0;

        // code here

        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double s = Math.Sqrt(x * x + y * y);
            if (s < dlina)
            {
                answer = i;
                dlina = s;
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(dlina, 2));
        // end

        return (answer, dlina);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here

        double mx = 100000.0;
        for (int i = 1; i <= n; i++)
        {
            double res = double.Parse(Console.ReadLine());
            if (res < mx) mx = res;
        }
        Console.WriteLine(Math.Round(mx, 1));
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;

        for (int i = 1; i <= n; i++)
        {
            int x = 0;
            for (int j = 1; j <= 4; j++)
            {
                int mark = int.Parse(Console.ReadLine());
                if (mark == 2 || mark == 3) x++;
            }
            if (x == 0) answer++;
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

        for (int i = 1; i <= n; i++)
        {
            int x = 0;
            for (int j = 1; j <= 4; j++)
            {
                int mark = int.Parse(Console.ReadLine());
                if (mark == 2) x++;
                avg += mark;
            }
            if (x != 0) answer++;
        }
        avg /= (n * 4);
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(avg, 2));
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;

        if (r <= 0) return 0;
        switch (type)
        {
            case 0: answer = r * r; break;
            case 1: answer = Math.PI * r * r; break;
            case 2: answer = r * r * Math.Sqrt(3) / 4; break;
        }
        // end

        return Math.Round(answer, 2);
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;

        if (A <= 0 || B <= 0) return 0;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.PI * Math.Abs(B * B - A * A);
                break;
            case 2:
                answer = A * Math.Sqrt(B * B - A * A / 4) / 2;
                break;
        }
        // end

        return Math.Round(answer, 2);
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {

        double answer = 0;
        string input;
        double s = 0, n = 0;
        while (true)
        {
            input = Console.ReadLine();
            if (input == "stop") break;
            s += int.Parse(input);
            n++;
        }
        answer = s / n;
        
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
        int answer = 0;

        // r1 - внутренний, r2 - внешний
        double x, y, s;
        string inputX, inputY;
        while (true)
        {
            inputX = Console.ReadLine();
            if (inputX == "stop") break;
            inputY = Console.ReadLine();
            if (inputY == "stop") break;
            double.TryParse(inputX, out x);
            double.TryParse(inputY, out y);
            s = x * x + y * y;
            if (s >= r1 * r1 && s <= r2 * r2) answer++;
        }

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
        double x, y;
        string inputX, inputY;
        while (true)
        {
            inputX = Console.ReadLine();
            if (inputX == "stop") break;
            inputY = Console.ReadLine();
            if (inputY == "stop") break;
            double.TryParse(inputX, out x);
            double.TryParse(inputY, out y);
            if (x > 0 && y > 0) answer1++;
            else if (x < 0 && y < 0) answer3++;
        }
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
        int mark;
        bool flag, stopFlag;
        string input;
        while (true)
        {
            stopFlag = false;
            flag = true;
            for (int j = 0; j < 4; j++)
            {
                input = Console.ReadLine();
                if (input == "stop")
                {
                    stopFlag = true;
                    break;
                }
                int.TryParse(input, out mark);
                if (mark == 2 || mark == 3) flag = false;
            }
            if (stopFlag) break;
            if (flag) answer++;
        }
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