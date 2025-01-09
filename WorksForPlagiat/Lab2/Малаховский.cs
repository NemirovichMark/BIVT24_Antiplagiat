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
        if (Math.Abs(x*x+y*y-r*r) <= 0.001)
        {
            answer = !answer;
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && y + Math.Abs(x) <= 1)
        {
            answer = !answer;
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
        double minab = -1000000000;
        if (a < b)
        {
            minab = a;
        }
        else
        {
            minab = b;
        }
        if (c > minab)
        {
            answer = c;
        }
        else
        {
            answer = minab;
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (Math.Sqrt(s) * Math.Sqrt(2) <= 2 * Math.Sqrt(r / Math.PI))
        {
            answer = !answer;
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (Math.Sqrt(s) >= 2 * Math.Sqrt(r / Math.PI))
        {
            answer = !answer;
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
        else
        {
            answer = x*x - 1;
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
        if (x > -1 && x <= 0)
        {
            answer = 1 + x;
        }
        if (x > 0)
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
        if (x > -1 && x <= 1)
        {
            answer = -x;
        }
        if (x > 1)
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
        double r = 0;
        for (int i = 0; i < n; i++)
        {
            r = double.Parse(Console.ReadLine());
            s += r;
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
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (Math.Sqrt((x-a)*(x-a)+(y-b)*(y-b)) <= r)
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
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            double w = double.Parse((Console.ReadLine()));
            if (w < 30.0)
            {
                answer += 0.2;
            }

        }
        answer = Math.Round(answer,1);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x = 0;
        double y = 0;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (Math.Sqrt(x*x+y*y) <= r2 && Math.Sqrt(x*x+y*y) >= r1)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double rez = double.Parse(Console.ReadLine());
            if (0 < rez && rez <= norm)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
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
            if(x>=0 && y>=0 && x<= Math.PI && y <= Math.Sin(x))
            {
                answer++;
            }
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
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x>0 && y > 0)
            {
                Console.WriteLine("1 квадрант");
                answer1++;
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("2 квадрант");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("3 квадрант");
                answer3++;
            }
            else 
            {
                Console.WriteLine("4 квадрант");
            }
        }
        // end
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        for (int i = 1; i<=n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (Math.Sqrt(x*x + y*y) < answerLength)
            {
                answer = i;
                answerLength = Math.Sqrt(x*x + y*y);
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength, 2));
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double rez = double.Parse(Console.ReadLine());
            if (rez < answer)
            {
                answer = rez;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 1; i<=n; i++)
        {
            double mark1 = double.Parse(Console.ReadLine());
            double mark2 = double.Parse(Console.ReadLine());
            double mark3 = double.Parse(Console.ReadLine());
            double mark4 = double.Parse(Console.ReadLine());
            if (mark1 > 3 && mark2 > 3 && mark3 > 3 && mark4 > 3)
            {
                answer++;
            }
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
        for (int i = 1; i<=n; i++)
        {
            double mark1 = double.Parse(Console.ReadLine());
            double mark2 = double.Parse(Console.ReadLine());
            double mark3 = double.Parse(Console.ReadLine());
            double mark4 = double.Parse(Console.ReadLine());
            avg += mark1 + mark2 + mark3 + mark4;
            if (mark1 == 2 || mark2 == 2 || mark3 == 2 || mark4 == 2)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(avg/(4*n));
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r <= 0)
        {
            return 0;
        }
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
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A <= 0 || B <= 0)
        {
            return 0;
        }
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                break;
            case 2:
                answer = (Math.Sqrt(B * B - A * A / 4) * A * 0.5);
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

        // answer should be equal to the task_2_1 answer
        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here
        double x = 0;
        do
        {
            x = double.Parse(Console.ReadLine());
            if (x >= 1000)
            {
                break;
            }
            double y = double.Parse(Console.ReadLine());
            if (Math.Sqrt((x - a) * (x - a) + (y - b) * (y - b)) <= r)
            {
                answer++;
            }
        } while (x < 1000);
        Console.WriteLine(answer);
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

        // end

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;
        double rez = 0;

        // code here
        do
        {
            rez = double.Parse(Console.ReadLine());
            if (rez <= 0)
            {
                break;
            }
            if (0 < rez && rez <= norm)
            {
                answer++;
            }
        } while (rez > 0);
        Console.WriteLine(answer);
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

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here
        double x = 0;
        do
        {
            x = double.Parse(Console.ReadLine());
            if (x >= 1000)
            {
                break;
            }
            double y = double.Parse(Console.ReadLine());
            n++;
            if (Math.Sqrt(x * x + y * y) < answerLength)
            {
                answer = n;
                answerLength = Math.Sqrt(x * x + y * y);
            }
        } while (x < 1000);
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength,2));
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

        // end

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;
        double mark1 = 0;
        do
        {
            mark1 = double.Parse(Console.ReadLine());
            if (mark1 == 0)
            {
                break;
            }
            double mark2 = double.Parse(Console.ReadLine());
            double mark3 = double.Parse(Console.ReadLine());
            double mark4 = double.Parse(Console.ReadLine());
            if (mark1 == 2 || mark2 == 2 || mark3 == 2 || mark4 == 2)
            {
                answer++;
            }
            avg += mark1 + mark2 + mark3 + mark4;
            n++;
        } while (mark1 != 0);
        Console.WriteLine(answer);
        Console.WriteLine(avg / (4 * n));
        // end
        return (answer, avg);
    }
    #endregion
}
