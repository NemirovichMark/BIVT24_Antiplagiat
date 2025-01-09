using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    private const bool V = true;

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
        int r = 2;
        if (Math.Abs(x * x + y * y - r * r) <= 0.001)
        {
            answer = true;
        }
        else answer = false;
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
        double c = 0;
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
            if (a > b)
            {
                answer = b;
            }
            else
            {
                answer = a;
            }
        }
        return answer;
        // end
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        // code here
        double minab = 0;
        double z = 0;
        if (a > b)
        {
            minab = b;
        }
        else
        {
            minab = a;
        }
        if (minab > c)
        {
            z = minab;
            answer = z;
        }
        else
        {
            z = c;
            answer = z;
        }
        // end
        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer;

        // code here
        double a = Math.Sqrt(s);
        if (a <= r)
        {
            answer = true;
        }
        else answer = false;
        // end
        Console.WriteLine(answer);

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double a = Math.Sqrt(s);
        double d = 2 * Math.Sqrt(r / Math.PI);
        if (d > a)
        {
            answer = false;
        }
        else answer = true;
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
        else answer = Math.Abs(x);

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
        else answer = x * x - 1;
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
        else if ((-1 < x) && (x <= 0))
        {
            answer = 1 + x;
        }
        else if (x > 0)
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
        else if ((-1 < x) && (x <= 1))
        {
            answer = -x;
        }
        else if (x > 1)
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
        double sum = 0;
        for (int sch = 0; sch < n; sch++)
        {
            double high = Convert.ToDouble(Console.ReadLine());
            sum += high;
        }
        answer = sum / n;
        Console.WriteLine(answer);
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int sch = 0; sch < n; sch++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if ((a - x) * (a - x) + (b - y) * (b - y) <= r * r)
            {
                answer++;
            }

        }
        Console.WriteLine(answer);

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double ml = 0.2;
        for (int sch = 0; sch < n; sch++)
        {
            double weight = Convert.ToDouble(Console.ReadLine());
            if (weight < 30)
            {
                answer += ml;
            }
            else
            {
                continue;
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
        for (int sch = 0; sch < n; sch++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if ((x * x + y * y) > r1 * r1)
            {
                if ((x * x + y * y) < r2 * r2)
                {
                    answer++;
                }
            }
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int sch = 0; sch < n; sch++)
        {
            double result = Convert.ToDouble(Console.ReadLine());
            if (result <= norm)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int sch = 0; sch < n; sch++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if ((x >= 0) && (y >= 0))
            {
                if (y <= Math.Sin(x))
                {
                    answer++;
                }
            }

        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for (int sch = 0; sch < n; sch++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if ((x > 0) && (y > 0))
            {
                answer1++;
            }
            else if ((x < 0) && (y < 0))
            {
                answer3++;
            }
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        for (int sch = 1; sch <= n; sch++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double distance = Math.Sqrt(x * x + y * y);
            if (distance < answerLength)
            {
                answerLength = distance;
                answer = sch;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int sch = 0; sch < n; sch++)
        {
            double result = Convert.ToDouble(Console.ReadLine());
            if (result < answer)
            {
                answer = result;
            }
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here
        int first, second, third, fourth = 0;
        for (int sch = 0; sch < n; sch++)
        {
            int.TryParse(Console.ReadLine(), out first);
            int.TryParse(Console.ReadLine(), out second);
            int.TryParse(Console.ReadLine(), out third);
            int.TryParse(Console.ReadLine(), out fourth);
            if ((first > 3) && (second > 3) && (third > 3) && (fourth > 3))
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double sum = 0;
        for (int sch = 0; sch < n; sch++)
        {
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            int third = Convert.ToInt32(Console.ReadLine());
            int fourth = Convert.ToInt32(Console.ReadLine());
            if ((first == 2) || (second == 2) || (third == 2) || (fourth == 2))
            {
                answer++;
            }
            sum += (first + second + third + fourth);
      
        }
        avg = sum / (n*4);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

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
                answer = Math.Round(r * r, 2);
                break;
            case 1:
                answer = Math.Round(Math.PI * (r * r), 2);
                break;
            case 2:
                answer = (r * r * Math.Sqrt(3)) / 4.0;
                answer = Math.Round(answer, 2);
                break;
            default:
                answer = 0;
                break;
        }
        Console.WriteLine(answer);
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
                answer = Math.Round(A * B, 2);
                break;
            case 1:
                double circleA = Math.PI * (A * A);
                double circleB = Math.PI * (B * B);
                answer = Math.Round(circleA - circleB, 2);
                break;
            case 2:
                answer = 1 / 2 * (A * Math.Sqrt(B * B - A * A / 4));
                answer = Math.Round(answer, 2);
                break;
            default:
                answer = 0;
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
        double h = 0;
        while (true)
        {
            h = Convert.ToInt32(Console.ReadLine());
            if (h == 10000)
            {
                break;
            }
            if (h <= 0)
            {
                break;
            }
            answer += h;
            n++;
        }
        answer /= n;
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);

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

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_3 answer

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
            x = Convert.ToDouble(Console.ReadLine());
            if (x == 10000)
            {
                break;
            }
            y = Convert.ToDouble(Console.ReadLine());
            if (y == 10000)
            {
                break;
            }
            if ((x * x + y * y) > r1 * r1)
            {
                if ((x * x + y * y) < r2 * r2)
                {
                    answer++;
                }
            }
        }
        Console.WriteLine(answer);
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

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1
        // answer should be equal to the task_2_6 answer

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here
        double x = 0;
        double y = 0;
        while (true)
        {
            x = Convert.ToDouble(Console.ReadLine());
            if (x == 10000)
            {
                break;
            }
            y = Convert.ToDouble(Console.ReadLine());
            if (y == 10000)
            {
                break;
            }
            if ((x > 0) && (y > 0))
            {
                Console.WriteLine("1");
                answer1++;
            }
            else if ((x < 0) && (y < 0))
            {
                Console.WriteLine("3");
                answer3++;
            }
            else if ((x < 0) && (y > 0))
            {
                Console.WriteLine("2");
            }
            else if ((x > 0) && (y < 0))
            {
                Console.WriteLine("4");
            }
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
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

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_9 answer

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;
        int first = 0;
        int second = 0;
        int third = 0;
        int fourth = 0;
        while (true)
        {
            first = Convert.ToInt32(Console.ReadLine());
            if (first == 0) break;
            second = Convert.ToInt32(Console.ReadLine());
            if (second == 0) break;
            third = Convert.ToInt32(Console.ReadLine());
            if (third == 0) break;
            fourth = Convert.ToInt32(Console.ReadLine());
            if (fourth == 0) break;
            if ((first > 3) && (second > 3) && (third > 3) && (fourth > 3))
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
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
