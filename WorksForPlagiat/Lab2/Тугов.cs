using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        //program.Task_2_2(5, 2);
        //program.Task_2_3(10, 1, 2);
        //program.Task_2_4(5, 1, 3);
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
        //program.Task_3_2(2);
        //program.Task_3_3();
        //program.Task_3_4(1, 3);
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
        if (x * x + y * y <= r * r + 1e-3)
        {
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = true;

        // code here
        if (x < 0 && 1 + x <= y) answer = false;
        if (x >= 0 && 1 - x <= y) answer = false;
        if (y < 0) answer = false;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)
        {
            answer = Math.Max(a, b);
        }
        else
        {
            answer = Math.Min(a, b);
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        answer = Math.Max(Math.Min(a, b), c);
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double R = Math.Sqrt(r / Math.PI), eps = 1e-3;
        double a = Math.Sqrt(s);
        if (2 * R >= Math.Sqrt(2 * s)) answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double R = Math.Sqrt(r / Math.PI), eps = 1e-3;
        double a = Math.Sqrt(s);
        if (2 * R < a) answer = true;
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
        else answer = x * x - 1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 0;
        else if (x > 0) answer = 1;
        else answer = 1 + x;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        else if (x > 1) answer = -1;
        else answer = -x;
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
        for (int i = 0; i < n; i++)
        {
            double tall;
            double.TryParse(Console.ReadLine(), out tall);
            s += tall;
        }
        answer = s / n;
        Console.WriteLine(answer);
                    //answer = 163.4;
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r)
    {
        int answer = 0;
        int a = 0, b = 0;
        // code here
        for (int i = 0; i < n; i++)
        {

            double x, y;
            string s = Console.ReadLine();
            string[] XY = s.Split(' ');
            double.TryParse(XY[0], out x); double.TryParse(XY[1], out y);
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r) answer++;

        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public int Task_2_3(int n, double r, double a, double b)
    {
        double answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double w; double.TryParse(Console.ReadLine(), out w);
            if (w < 30) answer += 200;
        }
        answer /= 1000;
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return (int)Math.Ceiling(answer);
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double x, y;
            string s = Console.ReadLine();
            string[] XY = s.Split(' ');
            double.TryParse(XY[0], out x); double.TryParse(XY[1], out y);
            if (x * x + y * y >= r1 * r1 && x * x + y * y <= r2 * r2) answer++;
        }
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double a; double.TryParse(Console.ReadLine(), out a);
            if (a <= norm) answer++;
        }
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double x, y;
            string s = Console.ReadLine();
            string[] XY = s.Split(' ');
            double.TryParse(XY[0], out x); double.TryParse(XY[1], out y);
            if (x > Math.PI || x < 0) continue;
            if (y <= Math.Sin(x)) answer++;
        }
        // end

        // for test input in console: -1.2 0.7, 2 2, 0.5 0.9, -1 1.5, 0.5 1.5

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double x, y;
            string s = Console.ReadLine();
            string[] XY = s.Split(' ');
            double.TryParse(XY[0], out x); double.TryParse(XY[1], out y);
            if (x > 0)
            {
                if (y < 0)
                {
                    answer1++;
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(4);
                }
            }
            else
            {
                if (y > 0)
                {
                    Console.WriteLine(2);
                }
                else
                {
                    answer3++;
                    Console.WriteLine(3);
                }
            }
        }
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double dist(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }

        for (int i = 0; i < n; i++)
        {
            double x, y;
            string s = Console.ReadLine();
            string[] XY = s.Split(' ');
            double.TryParse(XY[0], out x); double.TryParse(XY[1], out y);
            if (dist(x, y) < answerLength)
            {
                answer = i; answerLength = dist(x, y);
            }
        }
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i =0; i<n; i++)
        {
            double res; double.TryParse(Console.ReadLine(), out res);
            answer = Math.Min(answer, res);
        }
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i =0; i<n; i++)
        {
            bool flag = true;
            for (int j = 0; j<4; j++)
            {
                double r; double.TryParse(Console.ReadLine(), out r);
                if (r == 2 || r == 3) flag = false;
            }
            if (flag) answer++;
        }
        Console.WriteLine("Anser:{0:d}",answer);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        // Из предположения что неуспевающий это оценка 2
        // code here;
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            bool flag = false;
            for (int j = 0; j < 4; j++)
            {
                double r; double.TryParse(Console.ReadLine(), out r);
                sum += r;
                if (r == 2) flag = true;
            }
            if (flag) answer++;
        }
        avg = sum / n;
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        // Предположим что type = {1, 2, 3}, что соответственно значит
        // квадрат, круг и равносторонний треугольник соответственно
        switch (type)
        {
            case 1: answer = r * r; break;
            case 2: answer = Math.PI * r * r; break;
            case 3: answer = 0.5 * r * r * Math.Sin(Math.PI / 3); break;
        }
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        // Предположим что type = {1, 2, 3}, что соответственно значит
        // прямоугольник, кольцо и равнобедренный треугольник соответственно
        switch (type)
        {
            case 1: answer = A*B; break;
            case 2: answer = Math.Abs(Math.PI * A * A - Math.PI * B * B); break;
            case 3: answer = (B*(Math.Sqrt(4*A*A - B*B)))/4; break;
        }
        // end

        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;

        // code here
        int cnt = 0;
        while (true)
        {
            string input = Console.ReadLine();

            // Проверка на пустую строку для выхода из цикла
            if (string.IsNullOrEmpty(input))
            {
                break;
            }
            double tall;
            double.TryParse(input, out tall);
            answer += tall;
            cnt++;
        }
        answer /= cnt;
        Console.WriteLine(answer);
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }
    public int Task_3_2(double r)
    {
        int answer = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_3 answer

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0;

        // code here
        while (true)
        {
            string s = Console.ReadLine();

            // Проверка на пустую строку для выхода из цикла
            if (string.IsNullOrEmpty(s))
            {
                break;
            }
            double x, y;
            string[] XY = s.Split(' ');
            double.TryParse(XY[0], out x); double.TryParse(XY[1], out y);
            if (x * x + y * y >= r1 * r1 && x * x + y * y <= r2 * r2) answer++;
        }
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_4 answer

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 2, 0.5 0.9, -1 1.5, 0.5 1.5
        // answer should be equal to the task_2_6 answer

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        while(true)
        {
            string s = Console.ReadLine();

            // Проверка на пустую строку для выхода из цикла
            if (string.IsNullOrEmpty(s))
            {
                break;
            }
            double x, y;
            string[] XY = s.Split(' ');
            double.TryParse(XY[0], out x); double.TryParse(XY[1], out y);
            if (x > 0)
            {
                if (y < 0)
                {
                    answer1++;
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(4);
                }
            }
            else
            {
                if (y > 0)
                {
                    Console.WriteLine(2);
                }
                else
                {
                    answer3++;
                    Console.WriteLine(3);
                }
            }
        }
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_7 answer

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_8 answer

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_9 answer

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0;

        // code here;
        int cnt = 0;
        //bool flag = false;
        while (true)
        {
            string s = Console.ReadLine();

            // Проверка на пустую строку для выхода из цикла
            if (string.IsNullOrEmpty(s))
            {
                break;
            }
            bool flag = true;
            double f; double.TryParse(s, out f);
            if (f == 2 || f == 3) flag = false;
            for (int j = 0; j < 3; j++)
            {
                double r; double.TryParse(Console.ReadLine(), out r);
                if (r == 2 || r == 3) flag = false;
            }
            if (flag) answer++;
            /*
            double r; double.TryParse(Console.ReadLine(), out r);
            if (cnt % 4 == 0)
            {
                if (flag) answer++;
                flag = true;
                if (r == 2 || r == 3) flag = false;
            }
            else
            {
                if (r == 2 || r == 3) flag = false;
            }
            cnt++;
            */
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_10 answer

        return answer;
    }
    public (int, double) Task_3_11()
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

        // code here;
        // Предположим что type = {1, 2, 3}, что соответственно значит
        // прямоугольник, кольцо и равнобедренный треугольник соответственно
        switch (type)
        {
            case 1: answer = A * B; break;
            case 2: answer = Math.Abs(Math.PI * A * A - Math.PI * B * B); break;
            case 3: answer = (B * (Math.Sqrt(4 * A * A - B * B))) / 4; break;
        }
        // end
        // answer should be equal to the task_2_13 answer

        return answer;
    }
    #endregion
}