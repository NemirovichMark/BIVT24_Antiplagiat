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
        int r = 2;
        if (Math.Abs(x * x + y * y - r * r) <= (1 / 1000))
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if ((y >= 0) && ((y + Math.Abs(x)) <= 1))
            answer = true;
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
                answer = a;
            else
                answer = b;
        }
        else 
        {
            if (a < b)
                answer = a;
            else
                answer = b;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double m = 0;
        if (a < b)
            m = a;
        else
            m = b;

        if (c > m)
            answer = c;
        else
            answer = m;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        // Квадрат поместится в круге, если его диагональ меньше или равна диаметру круга
        double diam_r = Math.Sqrt(r * 4 / Math.PI);
        double diag_s = Math.Sqrt(2 * s);
        if (diam_r >= diag_s)
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double diam_r = Math.Sqrt(r * 4 / Math.PI);
        double storona = Math.Sqrt(s);
        if (diam_r < storona) 
            answer = true;
        // end

        return answer;  
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1)
            answer = 1;
        else
            answer = Math.Abs(x);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1)
            answer = 0;
        else
            answer = x * x - 1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 0;
        if ((-1 < x) && (x <= 0))
            answer = 1 + x;
        if (x > 0)
            answer = 1;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 1;
        if ((-1 < x) && (x <= 1)) 
            answer = -1 * x;
        if (x > 1)
            answer = -1;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double len_class = 0;
        for (int i = 0; i < n; i++)
        {
            double len_per = double.Parse(Console.ReadLine());
            len_class += len_per;
        }
        answer = len_class / n;
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double a1 = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            if ((a - a1) * (a - a1) + (b - b1) * (b - b1) <= r * r)
                answer++;
        }
            // end
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        // code here
        for (int i = 0; i < n; i++)
        {
            int ves = int.Parse(Console.ReadLine());
            if (ves < 30)
                answer += 0.2;
        }
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
            if (((x * x) + (y * y) >= r1 * r1) && ((x * x) + (y * y) <= r2 * r2))
                answer++;

        }
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
            if (rez <= norm)
                answer++;
        }
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((x >= 0) && (x <= Math.PI) && (y >= 0) && (y <= Math.Sin(x)))
                answer++;
        }
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x >= 0)
            {
                if (y >= 0)
                    answer1++;
            }
            else
            {
                if (y < 0)
                    answer3++;
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
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (Math.Sqrt(x * x + y * y) < answerLength)
            {
                answer = i;
                answerLength = Math.Sqrt((x * x) + (y * y));
            }
        }
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 0; i < n; i++)
        {
            double rez = double.Parse(Console.ReadLine());
            if (rez < answer)
            {
                answer = rez;
            }
        }
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 0; i < n; i++)
        {
            int ok = 1;
            for (int j = 0; j < 4; j++)
            {
                double otmetka = double.Parse(Console.ReadLine());
                if (otmetka == 2 || otmetka == 3)
                {
                    ok = 0;
                }
            }
            answer += ok;
        }
            // end

            return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0; // неуспевающие
        double avg = 0.0; // средний балл группы
        double summa = 0.0;

        // code here;
        for (int i = 0; i < n; i++)
        {
            int d = 0;
            for (int j = 0; i < 4; j++)
            {
                double ball = double.Parse((Console.ReadLine()));
                summa += ball;
                if (ball == 2)
                    d = 1;
            }
            answer += d;
        }
        avg = summa / (n * 4);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r <= 0) 
            return 0;
        switch (type)
        {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = r * r * Math.PI;
                break;
            case 2:
                answer = Math.Sqrt(3) * r * r / 4;
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
        if (A < 0 || B < 0) 
            return 0;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                if (B < A) 
                    return 0;
                answer = Math.PI * (B * B - A * A);
                break;
            case 2:
                if (2 * B < A) 
                    return 0;
                answer = Math.Sqrt(B * B - A * A / 4) * A / 2;
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
        string stopp = "Напишите 'stop', чтобы закончить";
        Console.WriteLine(stopp);
        while (true)
        {
            stopp = Console.ReadLine();
            if (stopp == "stop")
                break;
            double x;
            double.TryParse(stopp, out x);
            answer += x;
            ++n;
        }
        answer /= n;
        Console.WriteLine(answer);
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
        string stopp = "Напишите 'stop', чтобы закончить";
        Console.WriteLine(stopp);
        while (true)
        {
            stopp = Console.ReadLine();
            if (stopp == "stop")
                break;
            double x, y;
            double.TryParse(stopp, out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x * x + y * y <= r2 * r2 && x * x + y * y >= r1 * r1)
                ++answer;
        }
        Console.WriteLine($"Ответ: {answer}");
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
        string stopp = "Напишите 'stop', чтобы закончить";
        Console.WriteLine(stopp);
        while (true)
        {
            stopp = Console.ReadLine();
            if (stopp == "stop")
                break;
            double x, y;
            double.TryParse(stopp, out x);
            double.TryParse(Console.ReadLine(), out y);
            if (y > 0)
            {
                if (x > 0)
                {
                    ++answer1;
                    Console.WriteLine($"Точка ({x}, {y}) лежит в I квадранте");
                }
                else if (x < 0)
                    Console.WriteLine($"Точка ({x}, {y}) лежит во II квадранте");
                else
                    Console.WriteLine($"Точка ({x}, {y}) лежит на оси");
            }
            else if (y < 0)
            {
                if (x > 0)
                    Console.WriteLine($"Точка ({x}, {y}) лежит в IV квадранте");
                else if (x < 0)
                {
                    Console.WriteLine($"Точка ({x}, {y}) лежит в III квадранте");
                    ++answer3;
                }
                else
                    Console.WriteLine($"Точка ({x}, {y}) лежит на оси");
            }
            else
                Console.WriteLine($"Точка ({x}, {y}) лежит на оси");
        }
        Console.WriteLine($"{answer1} точек лежит в I квадранте, {answer3} в III");
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
        string stopp = "Напишите 'stop', чтобы закончить";
        int rez1, rez2, rez3, rez4;
        for (int i = 0; i < 100000000; i++)
        {
            stopp = Console.ReadLine();
            if (stopp == "stop") 
                break;
            else
            {
                rez1 = int.Parse(stopp);
                rez2 = int.Parse(Console.ReadLine());
                rez3 = int.Parse(Console.ReadLine());
                rez4 = int.Parse(Console.ReadLine());
                if (rez1 > 3 && rez2 > 3 && rez3 > 3 && rez4 > 3)
                    answer++;
            }
        }
        Console.WriteLine(answer);

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