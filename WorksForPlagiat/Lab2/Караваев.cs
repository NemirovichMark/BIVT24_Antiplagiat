using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
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
        if (Math.Abs(x*x + y*y - r*r) <= 0.001)
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
        if (y >= 0 && y+Math.Abs(x) <= 1)
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
            if (a >= b)
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
            if (a <= b)
            {
                answer = a;
            }
            else { answer = b; }
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        double min = 0;
        // code here
        if (a <= b)
        {
            min = a;
        } 
        else { min = b; }
        if (min >= c)
        {
            answer = min;
        }
        else { answer = c; }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double radius = r / Math.PI;
        double half_diagonal = (Math.Sqrt(s / 2)) / 2;
        if (half_diagonal <= radius)
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
        double diameter = 2 * Math.Sqrt((r / Math.PI));
        double side = Math.Sqrt(s);
        if (diameter < side)
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
        if (Math.Abs(x) > 1)
        {
            answer = 1;
        }
        else
        { answer = Math.Abs(x); }
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
        else { answer = x * x - 1; }
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
        if (x <= -1)
        {
            answer = 1;
        }
        else if (-1 < x && x <= 1)
        {
            answer = -x;
        }
        else { answer = -1; }
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
        for (int i = 0; i <= n - 1; i++)
        {
            s += double.Parse(Console.ReadLine());
        }
        answer = s / n;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ((x-a)*(x-a) + (y - b)*(y - b) <= r * r)
            {
                answer++;
            }
        }
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double m;
        for (int i = 0; i < n; i++)
        {
            m = double.Parse(Console.ReadLine());
            if (m < 30.0)
            {
                answer += 0.2;
            }
        }
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 0; i <= n-1; i++)
        {
            if (r1 > r2)
            {
                Console.WriteLine("r1 > r2; it is not correct");
                break;
            }
            if (r1 == r2)
            {
                Console.WriteLine("r1 == r2; it is not correct");
                break;
            }
            if (r1 < r2)
            {
                double x, y;
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());
                if (x*x + y*y >= r1*r1 && x*x + y*y <= r2*r2)
                {
                    answer++;
                }
            }
        }
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i = 0; i <= 29; i++)
        {
            double znach = double.Parse(Console.ReadLine());
            if (znach <= norm)
            {
                answer++;
            }
        }
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        
        // code here
        for (int i = 0; i <= n-1; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (0 <= x && x <= Math.PI && 0 <= y && y <= Math.Sin(x))
            {
                answer++;
            }
        }
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for (int i = 0; i <= (n - 1); i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("The first");
                answer1++;
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("The second");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("The third");
                answer3++;
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("The fourth");
            }
            if (x*y == 0)
            {
                Console.WriteLine("point is on x = 0 or y = 0");
            }
        }
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        if (n > 0)
        {
            for (int i = 0; i <= (n - 1); i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double R = Math.Pow(x * x + y * y, 0.5);
                if (R <= answerLength)
                {
                    answerLength = R;
                    answer = i;
                }
            }
            answer += 1;
        }
        if (n <= 0)
        {
            answerLength = 0;
            answer = 0;
        }
        
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        if (n > 0)
        {
            for (int i = 0; i <= n - 1; i++)
            {
                double R = double.Parse(Console.ReadLine());
                if (R <= answer)
                {
                    answer = R;
                }
            }
        }
        else
        { 
            Console.WriteLine("pls no jokes"); 
        }
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        answer = n;
        for (int i = 0; i <= n - 1; i++)
        {
            int ak = 0;
            for (int j = 0; j <= 3 ; i++)
            {
                int mark = int.Parse(Console.ReadLine());
                if (mark == 2 || mark == 3)
                {
                    ak += 1;
                }
            }
            if (ak != 0)
            {
                answer -= 1;
            }
        }
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        for (int i = 0; i<=n-1; i++)
        {
            int ak = 0;
            for (int j = 0; j <= 3; i++)
            {
                int mark = int.Parse(Console.ReadLine());
                if (mark == 2)
                {
                    ak += 1;
                }
                avg += mark;
            }
            if (ak != 0)
            {
                answer += 1;
            }
        }
        avg = avg / n;
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        switch (type)
        {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = Math.PI * r * r;
                break;
            case 2:
                answer = r * r * Math.Sqrt(3) / 4.0;
                break;
        }
        if (r <= 0 || type < 0 || type > 2)
        {
            answer = 0;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.PI * Math.Abs(A * A - B * B);
                break;
            case 2:
                answer = A * Math.Sqrt(4 * B * B - A * A) / 4.0;
                break;
        }
        if (type < 0 || type > 2 || A*B <= 0 || A+B<=0)
        {
            answer = 0;
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
            string a = Console.ReadLine();
            if (string.IsNullOrEmpty(a))
            {
                break;
            }
            if (double.TryParse(a, out double m))
            {
                if (m < 30)
                {
                    answer += 1;
                }
            }
        }
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
        while (true)
        {
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            if (string.IsNullOrEmpty(x) || string.IsNullOrEmpty(y))
            {
                break;
            }
            if (double.TryParse(x, out double X) && double.TryParse(y, out double Y))
            {
                if (0 <= X && X <= Math.PI && 0 <= Y && Y <= Math.Sin(X))
                {
                    answer++;
                }
            }
        }
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
        while (true)
        {
            string a = Console.ReadLine();
            if (string.IsNullOrEmpty(a))
            {
                break;
            }
            if (double.TryParse(a, out double b))
            {
                if (b <= answer)
                {
                    answer = b;
                }
            }
        }
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