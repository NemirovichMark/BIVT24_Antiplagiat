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
        answer = Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -3);

        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        answer = y >= 0 && (y + Math.Abs(x)) <= 1;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0) answer = a > b ? a : b;
        else answer = a < b ? a : b;
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double m = a < b ? a : b;
        answer = m > c ? m : c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double rad = Math.Sqrt(r / Math.PI);
        double diag = Math.Sqrt(s * 2);
        answer = (diag <= 2 * rad);
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false; 

        // code here
        double rad = Math.Sqrt(r / Math.PI);
        double side = Math.Sqrt(s);
        answer = (2 * rad <= side);
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Abs(x) >= 1 ? 1 : Math.Abs(x);       
        
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Abs(x) >= 1 ? 0 : x * x - 1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 0;
        else if (x > -1 && x <= 0) answer = 1 + x;
        else answer = 1;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        else if (-1 < x && x <= 1) answer = -1 * x;
        else answer = -1;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"¬ведите рост {i}-го ученика: ");
            answer += double.Parse(Console.ReadLine());
        }
        answer /= n;
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
            Console.Write($"¬ведите коориднату x {i} точки: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write($"¬ведите коориднату y {i} точки: ");
            double y = double.Parse(Console.ReadLine());
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r) answer += 1;
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
            Console.Write($"¬ведите вес {i}-го ученика");
            double w = double.Parse(Console.ReadLine());
            if (w < 30) answer += 0.2;
        }
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
            Console.Write($"¬ведите координату X точки {i}: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write($"¬ведите координату Y точки {i}: ");
            double y = double.Parse(Console.ReadLine());
            if (((x * x + y * y) >= r1 * r1) && ((x * x + y * y) <= r2 * r2)) answer++;
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
            Console.Write($"¬ведите результат {i}-го спортсмена: ");
            double r = double.Parse(Console.ReadLine());
            if (r <= norm) answer++;
        }
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"¬ведите координату x {i} точки: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write($"¬ведите координату y {i} точки: ");
            double y = double.Parse(Console.ReadLine());
            if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x)) answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"¬ведите координату x {i} точки: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write($"¬ведите координату y {i} точки: ");
            double y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                answer = 1;
                answer1++;
            }
            else if (x < 0 && y > 0) answer = 2;
            else if (x < 0 && y < 0)
            {
                answer = 3;
                answer3++;
            }
            else if (x > 0 && y < 0) answer = 4;
            Console.WriteLine(answer);
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
            Console.Write($"¬ведите координату x {i} точки: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write($"¬ведите координату y {i} точки: ");
            double y = double.Parse(Console.ReadLine());
            double l = Math.Sqrt(x * x + y * y);
            if (l < answerLength)
            {
                answer = i;
                answerLength = l;
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
            Console.Write($"¬ведите результат {i}-го спортсмена: ");
            double r = double.Parse(Console.ReadLine());
            if (r < answer) answer = r;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 1; i <= n; i++)
        {
            bool f = true;
            for (int j = 1; j <= 4; j++)
            {
                Console.Write($"¬ведите оценку є{j} {i}-го студента: ");
                int current = int.Parse(Console.ReadLine());
                if (current < 4) f = false;
            }
            if (f) answer++;
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
            bool f = false;
            for (int j = 1; j <= 4; j++)
            {
                Console.Write($"¬ведите оценку за є{j}-й экзамен {i}-го студента: ");
                int current = int.Parse(Console.ReadLine());
                if (current == 2) f = true;
                avg += current;
            }
            if (f) answer++;
        }
        avg /= n * 4;
        Console.WriteLine(answer);
        Console.WriteLine(avg);
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
            default: answer = 0; break;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A <= 0 || B <= 0) return 0;
        switch (type)
        {
            case 0: answer = A * B; break;
            case 1: answer = Math.Abs(Math.PI * A * A - Math.PI * B * B); break;
            case 2: double p = (A + B + B) / 2; answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B)); break;
            default: answer = 0; break;
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
        while (true)
        {
            Console.Write($"¬ведите рост ученика, дл€ окончани€ 0: ");
            double height = double.Parse(Console.ReadLine());
            if (height == 0) break;
            answer += height;
            n++;
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
        while (true)
        {
            Console.Write($"¬ведите координату X точки, дл€ окончани€ \"—топ\": ");
            string strX = Console.ReadLine();
            bool result = double.TryParse(strX, out double x);
            if (!result) break;
            Console.Write($"¬ведите координату Y точки: ");
            double y = double.Parse(Console.ReadLine());
            if (((x * x + y * y) >= r1 * r1) && ((x * x + y * y) <= r2 * r2)) answer++;
        }
        Console.WriteLine(answer);
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
        while (true)
        {
            Console.Write($"¬ведите координату x точки, дл€ окончани€ \"—топ\": ");
            string strX = Console.ReadLine();
            bool result = double.TryParse(strX, out double x);
            if (!result) break;
            Console.Write($"¬ведите координату y точки: ");
            double y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine(1);
                answer1++;
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine(2);
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine(2);
                answer3++;
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine(2);
            }
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
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
        while (true)
        {
            bool f = true, e = false;
            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"¬ведите оценку студента, дл€ окончани€ 0: ");
                int o = int.Parse(Console.ReadLine());
                if (o == 0) { e = true; break; }
                if (o < 4) f = false;
            }
            if (e) break;
            if (f) answer++;
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