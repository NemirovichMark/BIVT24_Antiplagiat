using Microsoft.VisualBasic;
using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection;
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
        //program.Task_2_8(10);
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
        double r = 2;

        if (Math.Abs(x * x + y * y - r * r) <= 1e-3)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        if (y >= 0 && y + Math.Abs(x) <= 1)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;
        if (a > 0)
        {
            answer = a > b ? a : b;
        }
        else
        {
            answer = a < b ? a : b;
        }

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        answer = (a < b ? a : b) > c ? (a < b ? a : b) : c;

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;
        double R = 4 * (r / Math.Round(Math.PI, 2)); //R = гипотенуза прямоугольного треугольника и диаметр в квадрате
        if (R >= s + s)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;
        double R = 4 * (r / Math.Round(Math.PI, 2));
        if (R <= s)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;
        if (Math.Abs(x) > 1)
        {
            answer = 1;
        }
        else
        {
            answer = Math.Abs(x);
        }
        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;
        if (Math.Abs(x) >= 1)
        {
            answer = 0;
        }
        else
        {
            answer = x * x - 1;
        }
        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;
        if (x <= -1)
        {
            answer = 0;
        }
        if (x > 0)
        {
            answer = 1;
        }
        if (x > -1 && x<= 0)
        {
            answer = 1 + x;
        }
        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;
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

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        double rost = 0;
        for (int i = 1; i <= n; i++)
        {
            rost += Convert.ToDouble(Console.ReadLine());
        }
        answer = rost / n;
        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if ((x - a) * (x - a) + (y - b) * (y - b) < r * r)
            {
                count++;
            }
        }
        Console.WriteLine(count);
        return count;

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
    }
    public double Task_2_3(int n)
    {
        double count = 0;
        for (int i = 0; i < n; i++)
        {
            double ves = Convert.ToDouble(Console.ReadLine());
            if (ves < 30) count += 200;
        }
        Console.WriteLine(count / 1000.0);
        return (count / 1000.0);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if ((x * x + y * y >= r1 * r1) && (x * x + y * y <= r2 * r2)) count++;
            if (r1 >= r2) Console.WriteLine(0);
        }
        Console.WriteLine(count);
        return (count);
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
    }
    public int Task_2_5(int n, double norm)
    {
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            double run = Convert.ToDouble(Console.ReadLine());
            if (run <= norm) count++;
        }
        Console.WriteLine(count);
        return (count);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
    }
    public int Task_2_6(int n)
    {
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if ((x >= 0) && (x <= Math.PI) && (y >= 0) && (y <= Math.Sin(x))) count++;
        }
        Console.WriteLine(count);
        return (count);
        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
        for (int i = 0; i < n; i++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (x >= 0 && y >= 0) answer1++;
            if (x < 0 && y < 0) answer3++;
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        return (answer1, answer3);
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        for (int i = 1; i <= n; i++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (Math.Sqrt(x * x + y * y) < answerLength)
            {
                answerLength = Math.Sqrt(x * x + y * y);
                answer = i;
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength, 2));
        return (answer, Math.Round(answerLength, 2));
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        for (int i = 0; i < n; i++)
        {
            double swim = Convert.ToDouble(Console.ReadLine());
            if (swim < answer) answer = swim;
        }
        Console.WriteLine(answer);
        return (answer);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
    }
    public int Task_2_10(int n)
    {
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            bool student = true;
            for (int j = 0; j < 4; j++)
            {
                int mark = Convert.ToInt32(Console.ReadLine());
                if (mark == 2 || mark == 3) student = false;
                if (j == 3 && student == true) count++;
            }
        }
        Console.WriteLine(count);
        return (count);
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
    }
    public (int, double) Task_2_11(int n)
    {
        double avg = 0.0;
        int two = 0;
        for (int i = 0; i < n; i++)
        {
            bool student = true;
            for (int j = 0; j < 4; j++)
            {
                int mark = Convert.ToInt32(Console.ReadLine());
                if (mark == 2 && student == true)
                {
                    student = false;
                    two++;
                }
                avg += mark;
            }
        }
        Console.WriteLine(two);
        Console.WriteLine(avg / (n * 4));
        return (two, avg / (n * 4));
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        if (r <= 0) return(0);
        switch (type)
        {
            case 0: answer = r * r; break;
            case 1: answer = Math.PI * r * r; break;
            case 2: answer = Math.Sqrt(3) * r * r / 4; break;
        }
        return Math.Round(answer, 2);
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        if (A <= 0 || B <= 0) return (0);
        
        switch(type)
        {
            case 0: answer = A * B; break;
            case 1:
                if (A >= B) return (0);
                answer = Math.PI * (B * B - A * A); break;
            case 2:
                answer = Math.Sqrt(B * B - A * A / 4) * A / 2; break;
        }
        return Math.Round(answer, 2);
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
        int count = 0;
        double x = 0;
        double y = 0;
        while(true)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            if (!double.TryParse(input1, out x) || !double.TryParse(input2, out y)) break;
            if ((x - a) * (x - a) + (y - b) * (y - b) < r * r) count++;
        }
        return count;
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer
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

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_4 answer

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int count = 0;
        double run = 0;
        while (true)
        {
            string input = Console.ReadLine();
            if (!double.TryParse(input, out run)) break;
            if (run <= norm) count++;
        }
        return (count);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer
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

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_7 answer

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0;
        double x, y;
        double answerLength = double.MaxValue;
        int count = 1;
        while (true)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            if (!double.TryParse(input1, out x) || !double.TryParse(input2, out y)) break;
            if (Math.Sqrt(x * x + y * y) < answerLength)
            {
                answerLength = Math.Sqrt(x * x + y * y);
                answer = count;
            }
            count++;
        }
        return (answer, Math.Round(answerLength, 2));
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_8 answer
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

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_10 answer

        return answer;
    }
    public (int, double) Task_3_11()
    {
        double avg = 0.0;
        int mark;
        int count = 0;
        int two = 0;
        while (true)
        {
            bool n = true;
            bool student = true;
            for (int j = 0; j < 4; j++)
            {
                string input = Console.ReadLine();
                if (!int.TryParse(input, out mark))
                {
                    n = false;
                    break;
                }
                if (mark == 2 && student == true)
                {
                    student = false;
                    two++;
                }
                avg += mark;
            }
            if (n == false) break;
            count++;
        }
        return (two,(double) avg / (4 * count));
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_11 answer
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
