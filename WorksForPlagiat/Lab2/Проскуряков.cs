using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

public class Program
{
    public static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
        Program program = new Program();
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        double eps = 0.001, r = 2;
        answer = Math.Abs(x*x + y*y - r*r) <= eps;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        answer = y >= 0 && (y + Math.Abs(x) <= 1);
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if(a > 0) answer = Math.Max(a, b);
        else answer = Math.Min(a, b);
        
        /*if(a > 0) 
        {
            if(a >= b) answer = a;
            else answer = b;
        }
        else {
            if(a <= b) answer = a;
            else answer = b;
        }*/
        
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        
        double abMin;
        if(a <= b) abMin = a;
        else abMin = b;
        
        if(c >= abMin) answer = c;
        else answer = abMin;
        
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double D = Math.Sqrt(2*s), R = Math.Sqrt(r/Math.PI);
        answer = D <= 2*R;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double A = Math.Sqrt(s), R = Math.Sqrt(r/(Math.PI));
        answer = 2*R <= A;
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
        else answer = Math.Pow(x, 2) - 1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 0;
        else if (-1 < x && x <= 0) answer = 1 + x;
        else answer = 1;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        else if (-1 < x && x <= 1) answer = -x;
        else answer = -1;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n) // ok
    {
        double answer = 0;

        // code here
        double s = 0;
        for (int i = 0; i < n; i++) s += int.Parse(Console.ReadLine());
        answer = s / n;
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b) // ok
    {
        int answer = 0;
        // code here
        double x, y;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if(((x - a)*(x - a) + (y - b)*(y - b)) <= (r*r)) answer++;
        }
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        return answer;
    }
    public double Task_2_3(int n) // ok
    {
        double answer = 0;

        // code here
        double x;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            if (x < 30) answer += 0.2;
        }
        // end
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2) // ok
    {
        int answer = 0;

        // code here
        // r1 - внутренний, r2 - внешний
        double x, y, s;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            s = x*x + y*y;
            if(s >= r1*r1 && s <= r2*r2) answer++;
        }
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        return answer;
    }
    public int Task_2_5(int n, double norm) // ok
    {
        int answer = 0;

        // code here
        double x;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            if (x < norm) answer++;
        }
        // end
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
    
        return answer;
    }
    public int Task_2_6(int n) // ok
    {
        int answer = 0;

        // code here
        double x, y, y_p;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x >= 0 && x <= Math.PI)
            {
                y_p = Math.Sin(x);
                if (y >= 0 && y <= y_p) answer++;
            }
        }
        // end
        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n) // ok
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        double x, y;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if(x > 0 && y > 0) answer1++;
            else if(x < 0 && y < 0) answer3++;
        }
        // end
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = 0;

        // code here
        // d = sqrt( (x - x0)^2 + (y - y0)^2   )
        double x, y, dist, minDist = double.PositiveInfinity;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            dist = Math.Sqrt(x*x + y*y);
            //Console.WriteLine($"({x}; {y}) {dist}");
            if (dist < minDist)
            {
                minDist = dist;
                answerLength = Math.Round(minDist, 2);
                answer = i;
            }
        }
        // end
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n) // ok
    {
        double answer = double.MaxValue;

        // code here
        double res;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out res);
            if(res < answer) answer = res;
        }
        // end
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n) // ok
    {
        int answer = 0, mark;
        bool flag;
        for (int i = 0; i < n; i++)
        {
            flag = true;
            for (int j = 0; j < 4; j++)
            {
                int.TryParse(Console.ReadLine(), out mark);
                if (mark == 2 || mark == 3)
                {
                    // Console.WriteLine($"{i}: {mark}");
                    flag = false;
                }
            }
            if (flag) answer++;
        }
        // end
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0, mark;
        double avg = 0.0, S = 0.0, s;
        bool flag;

        for (int i = 0; i < n; i++)
        {
            flag = false;
            s = 0.0;
            for (int j = 0; j < 4; j++)
            {
                int.TryParse(Console.ReadLine(), out mark);
                if(mark == 2) flag = true;
                s += mark;
            }
            S += s / 4;
            if (flag) answer++;
        }

        avg = S / n;
        
        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here
        if (r <= 0) return 0;
        switch (type)
        {
            case 0: answer = r*r; break;
            case 1: answer = Math.PI*r*r; break;
            case 2: answer = r * r * Math.Sqrt(3) / 4; break;
        }
        
        // end

        return Math.Round(answer, 2);
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        // code here
        if (A <= 0 || B <= 0) return 0;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.PI * Math.Abs(B*B - A*A);
                break;
            case 2:
                answer = A * Math.Sqrt(B * B - A * A / 4) / 2;
                break;
        }
        // end
        // Console.WriteLine($"{A} {B} {type} {answer}");
        return Math.Round(answer, 2);
    }
    #endregion

    #region Level 3
    // 1, 4, 7, 10
    public double Task_3_1() // ok
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

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        return answer;
    }

    public int Task_3_4(double r1, double r2) // ok
    {
        int answer = 0;
        
        // r1 - внутренний, r2 - внешний
        double x, y, s;
        string inputX, inputY;
        while(true)
        {
            inputX = Console.ReadLine();
            if(inputX == "stop") break;
            inputY = Console.ReadLine();
            if (inputY == "stop") break;
            double.TryParse(inputX, out x);
            double.TryParse(inputY, out y);
            s = x * x + y * y;
            if (s >= r1 * r1 && s <= r2 * r2) answer++;
        }

        return answer;
    }
    public (int, int) Task_3_7() // ok
    {
        int answer1 = 0;
        int answer3 = 0;
        double x, y;
        string inputX, inputY;
        while(true)
        {
            inputX = Console.ReadLine();
            if(inputX == "stop") break;
            inputY = Console.ReadLine();
            if(inputY == "stop") break;
            double.TryParse(inputX, out x);
            double.TryParse(inputY, out y);
            if(x > 0 && y > 0) answer1++;
            else if(x < 0 && y < 0) answer3++;
        }
        return (answer1, answer3);
    }
    public int Task_3_10() // ok
    {
        int answer = 0, mark;
        bool flag, stopFlag;
        string input;
        while(true)
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
            if(stopFlag) break;
            if (flag) answer++;
        }
        // end
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    #endregion
}