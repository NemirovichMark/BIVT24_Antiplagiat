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
        answer = Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -3);
        
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        answer = (y >= 0) && (y + Math.Abs(x) <= 1);
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        answer = a > 0
            ? a > b
                ? a
                : b
            : a > b
                ? b
                : a; 
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double z;

        z = a < b ? a : b;
        answer = z > c ? z : c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        answer = (Math.Sqrt(2 * s) <= 2 * Math.Sqrt(r / Math.PI));
        
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        answer = Math.Sqrt(s) >= 2 * Math.Sqrt(r / Math.PI);
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Abs(x) > 1 ? 1 : Math.Abs(x);      
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Abs(x) >= 1 ? 0 : x*x-1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        answer = x <= -1
            ? 0
            : -1 < x && x <= 0
                ? 1 + x
                : 1;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        answer = x <= -1
            ? 1
            : -1 < x && x <= 1
                ? -1 * x
                : -1;
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
        for (int i = 1; i <= n; i++)
        {
            bool isParsed = double.TryParse(Console.ReadLine(), out double height);
            if (isParsed)
            {
                sum += height;
            }
        }
        answer = sum / n;
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
            bool isParsedX = double.TryParse(Console.ReadLine(), out double x);
            bool isParsedY = double.TryParse(Console.ReadLine(), out double y);
            if (isParsedX && isParsedY)
            {
                if (Math.Pow((x - a), 2) + Math.Pow((y - b), 2) <= Math.Pow(r, 2))
                {
                    answer += 1;
                }
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
            bool isParsed = double.TryParse(Console.ReadLine(), out double weight);
            if (isParsed)
            {
                if (weight < 30)
                {
                    answer += 0.2;
                }
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            bool isParsedX = double.TryParse(Console.ReadLine(), out double x);
            bool isParsedY = double.TryParse(Console.ReadLine(), out double y);
            if (isParsedX && isParsedY)
            {
                if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(r2, 2)) && (Math.Pow(x, 2) + Math.Pow(y, 2) > Math.Pow(r1, 2)))
                {
                    answer += 1;
                }
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
            bool isParsed = double.TryParse(Console.ReadLine(), out double p);
            if (isParsed && p <= norm)
            {
                answer += 1;
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
            bool isParsedX = double.TryParse(Console.ReadLine(), out double x);
            bool isParsedY = double.TryParse(Console.ReadLine(), out double y);
            if (isParsedX && isParsedY)
            {
                if (x <= Math.PI && x > 0 && y >= 0 && y <= Math.Sin(x))
                {
                    answer += 1;
                }
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
            bool isParsedX = double.TryParse(Console.ReadLine(), out double x);
            bool isParsedY = double.TryParse(Console.ReadLine(), out double y);

            if (isParsedX && isParsedY && x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine(1);
                    answer1 += 1;
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine(2);
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine(3);
                    answer3 += 1;
                }
                else
                {
                    Console.WriteLine(4);
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
        for (int i = 1; i <= n; i++)
        {
            bool isParsedX = double.TryParse(Console.ReadLine(), out double x);
            bool isParsedY = double.TryParse(Console.ReadLine(), out double y);

            if (isParsedX && isParsedY)
            {
                if (Math.Sqrt(x * x + y * y) < answerLength)
                {
                    answerLength = Math.Sqrt(x * x + y * y);
                    answer = i;
                }

            }
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 1; i <= n; i++)
        {
            bool isParsed = double.TryParse(Console.ReadLine(), out double x);

            if (isParsed)
            {
                if (x < answer)
                {
                    answer = x;
                }

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
        int Task_2_10(int n)
        {
            int answer = 0;

            // code here;
            answer = n;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Student {i}:");

                for (int j = 1; j <= 4; j++)
                {
                    bool isParsed = double.TryParse(Console.ReadLine(), out double grade);

                    if (isParsed)
                    {
                        if (grade <= 3)
                        {
                            answer -= 1;
                            break;
                        }
                    }
                }
            }
            // end

            Console.WriteLine(answer);
            return answer;
        }
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        answer = n;
        int underachievers = 0;
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {

            Console.WriteLine($"Student {i}:");
            var isUnderachiever = false;

            for (int j = 1; j <= 4; j++)
            {
                bool isParsed = double.TryParse(Console.ReadLine(), out double grade);
                if (isParsed)
                {

                    if (grade == 2)
                    {
                        isUnderachiever = true;
                    }
                    sum += grade;
                }
            }
            if (isUnderachiever)
            {
                underachievers++;
            }
        }
        answer = underachievers;
        avg = sum / n / 4;
        Console.WriteLine(answer);
        Console.WriteLine(avg);
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
                answer = r * r * Math.PI;
                break;

            case 2:
                answer = Math.Sqrt(3) / 4 * (r * r);
                break;

            default:
                answer = 0;
                break;

        }
        answer = Math.Round(answer, 2);
        // end
        Console.WriteLine(answer);
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
                answer = Math.Sqrt(B * B - A * A / 4) * A / 2;
                break;

            default:
                answer = 0;
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
            string value = Console.ReadLine();
            if (value == "q")
            {
                break;
            }
            bool isParsed = double.TryParse(value, out double weight);
            if (isParsed)
            {
                if (weight < 30)
                {
                    answer += 0.2;
                }
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

        // code here
        while(true)
        {
            var value = Console.ReadLine();
            if (value == "q")
            {
                break;
            }
            bool isParsedX = double.TryParse(value, out double x);
            bool isParsedY = double.TryParse(Console.ReadLine(), out double y);
            if (isParsedX && isParsedY)
            {
                if (x <= Math.PI && x > 0 && y >= 0 && y <= Math.Sin(x))
                {
                    answer += 1;
                }
            }
        }
        Console.WriteLine(answer);
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
            var value = Console.ReadLine();
            if(value == "q")
            {
                break;
            }
            bool isParsed = double.TryParse(value, out double x);

            if (isParsed)
            {
                if (x < answer)
                {
                    answer = x;
                }

            }
        }
        Console.WriteLine(answer);
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