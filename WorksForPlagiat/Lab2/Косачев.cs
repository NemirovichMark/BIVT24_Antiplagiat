using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

public class Program
{
    double custom_pow(double expBase, int exp)
    {
        if (exp == 0)
        {
            return 1;
        }
        else
        {
            return expBase * custom_pow(expBase, exp - 1);
        }
    }

    public static void Main()
    {
        Program program = new Program();
        // program.Task_1_1(0.9, 1.23);
        // program.Task_1_2(0.9, 1.23);
        //program.Task_1_3(0.9, 1.23);
        //program.Task_1_4(0.9, 1.23, -0.1);
        //program.Task_1_5(0.9, 1.23);
        //program.Task_1_6(0.9, 1.23);
        //program.Task_1_7(0.9);
        //program.Task_1_8(0.9);
        //program.Task_1_9(0.9);
        //program.Task_1_10(0.9);
        // program.Task_2_1(10);
        // program.Task_2_2(5, 2);
        //  program.Task_2_3(10);
        // program.Task_2_4(5, 1, 3);
        // program.Task_2_5(10, 30);
        // program.Task_2_6(5);
        // program.Task_2_7(5);
        // program.Task_2_8(10);
        // program.Task_2_9(10);
        program.Task_2_10(10);
        // program.Task_2_11(10);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        // program.Task_3_1(10);
        //program.Task_3_2(5, 2);
        //program.Task_3_3(10);
        // program.Task_3_4(5, 1, 3);
        //program.Task_3_5(10, 30);
        //program.Task_3_6(5);
        // program.Task_3_7(5);
        //program.Task_3_8(10);
        //program.Task_3_9(10);
        // program.Task_3_10(10);
        //program.Task_3_11(10);
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }

    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer;
        const double r = 2;
        const double tolerance = 0.001;

        // code here
        if (Math.Abs(x * x + y * y - r * r) <= tolerance)
        {
            answer = true;
            Console.WriteLine($"Point ({x}, {y}) is on circle");
        }
        else
        {
            answer = false;
            Console.WriteLine($"Point ({x}, {y}) is not on circle");
        }
        // end

        return answer;
    }

    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (x + y <= 1 && x - y >= -1 && y >= 0)
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
        // end

        return answer;
    }

    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        if (a > b)
        {
            if (b > c)
            {
                answer = b;
            }
            else
            {
                answer = c;
            }
        }
        else
        {
            if (a > c)
            {
                answer = a;
            }
            else
            {
                answer = c;
            }
        }
        // end

        return answer;
    }

    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double circleRadius = Math.Sqrt(r / Math.PI);
        double squareSide = Math.Sqrt(s);
        double squareRadius = Math.Sqrt(2) * squareSide / 2;

        if (circleRadius >= squareRadius)
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
        double circleDiameter = Math.Sqrt(r / Math.PI) * 2;
        double squareSide = Math.Sqrt(s);

        if (circleDiameter <= squareSide)
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
            answer = x * x - 1;
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
        if (x <= -1)
        {
            answer = 1;
        }
        else if (-1 < x && x <= 1)
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
        Console.WriteLine(
            "for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161"
        );
        double answer = 0;

        // code here
        int amountOfStudents = n;
        double cumulativeSum = 0;
        double heightOfStudent;

        for (int i = 0; i < amountOfStudents; i++)
        {
            heightOfStudent = double.Parse(Console.ReadLine() ?? "0");
            cumulativeSum += heightOfStudent;
        }

        answer = cumulativeSum / amountOfStudents;
        Console.WriteLine(answer);
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }

    public int Task_2_2(int n, double r)
    {
        Console.WriteLine("for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5");
        int answer = 0;

        // code here
        double a = 0;
        double b = 0;
        for (int i = 0; i < n; i++)
        {
            string[] coords = Console.ReadLine().Split(null);
            double x = double.Parse(coords[0]);
            double y = double.Parse(coords[1]);

            if (custom_pow(x - a, 2) + custom_pow(y - b, 2) <= custom_pow(r, 2))
            {
                answer += 1;
            }
        }

        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }

    public double Task_2_3(int n)
    {
        Console.WriteLine(
            "for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5"
        );
        double answer = 0;

        // code here
        double weight;
        for (int i = 0; i < n; i++)
        {
            weight = double.Parse(Console.ReadLine());
            if (weight < 30)
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
        Console.WriteLine("for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5");
        int answer = 0;

        // code here
        double rPoint;
        for (int i = 0; i < n; i++)
        {
            string[] coords = Console.ReadLine().Split();
            double x = double.Parse(coords[0]);
            double y = double.Parse(coords[1]);

            rPoint = Math.Sqrt(custom_pow(x, 2) + custom_pow(y, 2));
            if (r1 <= rPoint && rPoint <= r2)
            {
                answer++;
            }
        }
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }

    public int Task_2_5(int n, double norm)
    {
        Console.WriteLine(
            "for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5"
        );
        int answer = 0;

        // code here
        double result;
        for (int i = 0; i < n; i++)
        {
            result = double.Parse(Console.ReadLine());
            if (result <= norm)
            {
                answer += 1;
            }
        }
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }

    public int Task_2_6(int n)
    {
        Console.WriteLine("for test input in console: -1.2 0.7, 2 2, 0.5 0.9, -1 1.5, 0.5 1.5");
        int answer = 0;
        double x,
            y;
        string[] xy;
        // code here
        for (int i = 0; i < n; i++)
        {
            xy = Console.ReadLine().Split();
            x = double.Parse(xy[0]);
            y = double.Parse(xy[1]);

            if (y > Math.Sin(x))
                continue;
            if (y < 0)
                continue;
            if (x < 0)
                continue;
            if (x > Math.PI)
                continue;

            answer += 1;
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: -1.2 0.7, 2 2, 0.5 0.9, -1 1.5, 0.5 1.5

        return answer;
    }

    public (int, int) Task_2_7(int n)
    {
        Console.WriteLine("for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5");
        int answer1 = 0;
        int answer3 = 0;

        string[] xy;
        double x,
            y;
        // code here
        for (int i = 0; i < n; i++)
        {
            xy = Console.ReadLine().Split();
            x = double.Parse(xy[0]);
            y = double.Parse(xy[1]);

            switch (x > 0, y > 0)
            {
                case (true, true):
                {
                    Console.WriteLine("Точка лежит в первом квадранте");
                    answer1 += 1;
                    break;
                }

                case (false, true):
                {
                    Console.WriteLine("Точка лежит во втором квадранте");
                    break;
                }

                case (false, false):
                {
                    Console.WriteLine("Точка лежит в третьем квадранте");
                    answer3 += 1;
                    break;
                }

                case (true, false):
                {
                    Console.WriteLine("Точка лежит в четвертом квадранте");
                    break;
                }
            }
        }
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }

    public (int, double) Task_2_8(int n)
    {
        Console.WriteLine("for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5");
        int answer = 0;
        double answerLength = double.MaxValue;

        string[] xy;
        double x,
            y;
        double r;
        // code here
        for (int i = 0; i < n; i++)
        {
            xy = Console.ReadLine().Split();
            x = double.Parse(xy[0]);
            y = double.Parse(xy[1]);

            r = Math.Sqrt(x * x + y * y);
            if (r < answerLength)
            {
                answer = i + 1;
                answerLength = r;
            }
        }
        // end
        Console.WriteLine($"n: {answer}, r: {answerLength:f.3}");
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer, answerLength);
    }

    public double Task_2_9(int n)
    {
        Console.WriteLine(
            "for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5"
        );
        double answer = double.MaxValue;
        double result;

        // code here
        for (int i = 0; i < n; i++)
        {
            result = double.Parse(Console.ReadLine());
            if (result < answer)
            {
                answer = result;
            }
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }

    public int Task_2_10(int n)
    {
        int answer = n;
        int mark;
        bool flag;
        // code here;
        for (int s = 0; s < n; s++)
        {
            flag = true;
            for (int m = 0; m < 4; m++)
            {
                mark = int.Parse(Console.ReadLine());
                if (mark < 3 && flag)
                {
                    flag = false;
                    answer--;
                }
            }
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }

    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        int mark;
        bool flag;

        // code here;
        for (int s = 0; s < n; s++)
        {
            flag = true;
            for (int m = 0; m < 4; m++)
            {
                mark = int.Parse(Console.ReadLine());
                avg += mark;
                if (mark < 3 && flag)
                {
                    flag = false;
                    answer++;
                }
            }
        }
        // end
        avg /= n * 4;
        Console.WriteLine($"N: {answer}, avg: {avg:f.3}");
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }

    public double Task_2_12(double r, int type)
    {
        double answer;
        if (r <= 0)
            return 0.0;

        // code here;
        switch (type)
        {
            case 0:
            {
                answer = r * r;
                break;
            }
            case 1:
            {
                answer = r * r * Math.PI;
                break;
            }
            case 2:
            {
                answer = Math.Sqrt(3) / 4 * r * r;
                break;
            }
            default:
                return 0.0;
        }
        // end

        return Math.Round(answer, 2);
    }

    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        if (A <= 0.0 || B <= 0.0)
            return 0.0;

        // code here;
        switch (type)
        {
            case 0:
            {
                answer = A * B;
                break;
            }
            case 1:
            {
                answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                break;
            }
            case 2:
            {
                if (A >= 2.0 * B)
                    return 0;
                double p = A + B + B;
                p /= 2.0;
                answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B));
                break;
            }
            default:
                return 0.0;
        }
        // end

        return Math.Round(answer, 2);
    }
    #endregion

    #region Level 3
    public double Task_3_1(int n)
    {
        Console.WriteLine("Input 'exit' to stop the program");
        Console.WriteLine(
            "for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161"
        );
        double answer = 0;

        // code here
        int amountOfStudents = n;
        double cumulativeSum = 0;
        double heightOfStudent;

        string input = Console.ReadLine();
        while (input != "exit")
        {
            heightOfStudent = double.Parse(input);
            cumulativeSum += heightOfStudent;
            input = Console.ReadLine();
        }

        answer = cumulativeSum / amountOfStudents;
        Console.WriteLine(answer);
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }

    public int Task_3_2(int n, double r)
    {
        int answer = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

        return answer;
    }

    public double Task_3_3(int n)
    {
        double answer = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_3 answer

        return answer;
    }

    public int Task_3_4(int n, double r1, double r2)
    {
        Console.WriteLine("Input 'exit' to stop the program");
        Console.WriteLine("for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5");
        int answer = 0;

        // code here
        double rPoint;
        string input = Console.ReadLine();
        while (input != "exit")
        {
            string[] coords = input.Split();
            double x = double.Parse(coords[0]);
            double y = double.Parse(coords[1]);

            rPoint = Math.Sqrt(x * x + y * y);
            if (r1 <= rPoint && rPoint <= r2)
            {
                answer++;
            }
            input = Console.ReadLine();
        }
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_4 answer

        return answer;
    }

    public int Task_3_5(int n, double norm)
    {
        int answer = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer

        return answer;
    }

    public int Task_3_6(int n)
    {
        int answer = 0;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 2, 0.5 0.9, -1 1.5, 0.5 1.5
        // answer should be equal to the task_2_6 answer

        return answer;
    }

    public (int, int) Task_3_7(int n)
    {
        Console.WriteLine("Input 'exit' to stop the program");
        Console.WriteLine("for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5");

        int answer1 = 0;
        int answer3 = 0;

        string input = Console.ReadLine();
        string[] xy;
        double x,
            y;
        // code here
        while (input != "exit")
        {
            if (input == null)
                break;
            xy = input.Split();
            x = double.Parse(xy[0]);
            y = double.Parse(xy[1]);

            switch (x > 0, y > 0)
            {
                case (true, true):
                {
                    Console.WriteLine("Точка лежит в первом квадранте");
                    answer1 += 1;
                    break;
                }

                case (false, true):
                {
                    Console.WriteLine("Точка лежит во втором квадранте");
                    break;
                }

                case (false, false):
                {
                    Console.WriteLine("Точка лежит в третьем квадранте");
                    answer3 += 1;
                    break;
                }

                case (true, false):
                {
                    Console.WriteLine("Точка лежит в четвертом квадранте");
                    break;
                }
            }
            input = Console.ReadLine();
        }

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_7 answer

        return (answer1, answer3);
    }

    public (int, double) Task_3_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_8 answer

        return (answer, answerLength);
    }

    public double Task_3_9(int n)
    {
        double answer = double.MaxValue;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_9 answer

        return answer;
    }

    public int Task_3_10(int n)
    {
        Console.WriteLine("Input 'exit' to stop the program");
        Console.WriteLine(
            "for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4"
        );
        int answer = 0;

        string input = Console.ReadLine();
        int mark;
        bool flag;
        // code here;
        while (true)
        {
            flag = true;
            for (int m = 0; m < 4; m++)
            {
                input = Console.ReadLine();
                if (input == "exit")
                    break;
                mark = int.Parse(input);
                if (mark > 3 && flag)
                {
                    flag = false;
                    answer += 1;
                }
            }

            if (input == "exit")
                break;
        }
        // end
        Console.WriteLine(answer);

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_10 answer

        return answer;
    }

    public (int, double) Task_3_11(int n)
    {
        int answer = 0;
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
        if (A <= 0.0 || B <= 0.0)
            return 0.0;

        // code here;
        switch (type)
        {
            case 0:
            {
                answer = A * B;
                break;
            }
            case 1:
            {
                answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                break;
            }
            case 2:
            {
                if (A <= 2.0 * B)
                    return 0;
                double p = A + B + B;
                p /= 2.0;
                answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B));
                break;
            }
            default:
                return 0.0;
        }
        // end

        return Math.Round(answer, 4);
    }
    #endregion
}
