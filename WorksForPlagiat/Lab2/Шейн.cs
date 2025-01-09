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
        // code here
        if (Math.Abs(x * x + y * y - r * r) <= 0.001) answer = true;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here

        if ((y >= 0) && (y + Math.Abs(x) <= 1)) answer = true;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)
        {
            answer = b;
            if (a > b) answer = a; 
        }
        else if (a <= 0)
        {
            answer = b;
            if (a < b) answer = a;
        }
        
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        double x = 0;
        // code here
        x = b;
        if (a < b) x = a;
        answer = x;
        if (c > x) answer = c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;
        double D;
        double a;
        // code here
        D = Math.Sqrt(r / Math.PI) * 2;
        a = Math.Sqrt(s);
        a = Math.Sqrt(a * a * 2);
        if (a <= D) answer = true;

        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;
        double D;
        double a;
        // code here
        D = Math.Sqrt(r / Math.PI) * 2;
        a = Math.Sqrt(s);
        if (D < +a) answer = true;
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
        else if (-1 < x && x <= 1) answer = 0-x;
        else answer = -1;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        double r, s = 0;
        // code here
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out r);
            s += r;
        }
        answer = s / n;
        // end
        Console.WriteLine(answer.ToString());
        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x, y;

        for (int i = 0; i < n; i++)
        {
            // Ввод координат x и y по отдельности
            Console.WriteLine($"Введите координаты точки {i + 1} (x y):");
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            double distsqr = (x-a)*(x-a)+(y-b)*(y-b);
            if (distsqr <= r * r) answer++;
        }

        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        double veight;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out veight);
            if (veight < 30) answer += 200;
        }
        Console.WriteLine(answer/1000);
        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        double x, y, distsqr;
        // code here
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            distsqr = x * x + y * y;
            if (r1 * r1 <= distsqr && distsqr <= r2*r2) answer++;
            
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        double x;
        // code here
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            if (x <= norm) answer++;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        double x, y;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((0 <= x && x <= Math.PI) && (y >= 0) && (y <= Math.Sin(x))) answer++;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0, answer3 = 0;
        double x, y;

        // code here
        
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x > 0 && y > 0) answer1++;
            else if (x < 0 && y < 0) answer3++;
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
        double x, y, length;
        double answerLength = double.MaxValue;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            length = Math.Sqrt(x * x + y * y);
            if (length < answerLength)
            {
                answer = i;
                answerLength = length;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answer); Console.WriteLine(answerLength);
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double result = 0;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out result);
            if (result < answer) answer = result;
        }
        Console.WriteLine(answer);
        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        int grade;

        // code here;

        for (int i = 0; i < n; i++)
        {
            bool no34 = true;
            for (int a = 0; a < 4; a++)
            {
                int.TryParse(Console.ReadLine(), out grade);
                if (grade == 3 || grade == 2) no34 = false;
            }
            if (no34) answer++;
        }

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        int.TryParse(Console.ReadLine(), out n);
        double grade;
        double sum = 0;
        // code here;
        for (int i = 0; i < n; i++)
        {
            bool usl = false;
            for (int a = 0; a < 4; a++)
            {
                double.TryParse(Console.ReadLine(), out grade);
                sum += grade;
                if (grade == 2) usl = true;
            }
            if (usl) answer++;
        }
        avg = Math.Round((sum / (n * 4)), 9);
        Console.WriteLine(answer); Console.WriteLine(avg);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r > 0)
        {
            switch (type)
            {
                case 0: answer = r * r; break;
                case 1: answer = Math.PI * r * r; break;
                case 2: answer = r * r * Math.Sqrt(3) / 4.0; break;
            }
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A > 0 && B > 0)
        {
            switch (type)
            {
                case 0: 
                    answer = A * B; 
                    break;
                case 1:
                    double AS = Math.PI*A*A;
                    double BS = Math.PI*B*B;
                    answer = Math.Abs(AS - BS);
                    break;
                case 2:
                    double p = (A + B + B) / 2;
                    answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B));
                    break;
                default: break;
            }
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
        string input;
        double weight;
        // code here

        for (;;)
        {
            input = Console.ReadLine();
            if (input == "stop") break;
            double.TryParse(input, out weight);
            if ((weight < 30) && (weight > 0)) answer += 200;
        }
        answer = answer / 1000; 
        // end
        Console.WriteLine(answer);
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
        double x, y;
        string inputX, inputY;
        // code here
        for (; ;)
        {
            inputX = Console.ReadLine();
            inputY = Console.ReadLine();
            if ((inputY == "stop") || (inputX == "stop")) break;
            double.TryParse(inputX, out x); double.TryParse(inputY, out y);
            if ((0 <= x && x <= Math.PI) && (y >= 0) &&(y <= Math.Sin(x))) 
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
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
        int answer = 0, n = 0;
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
        int n = 0;
        string input;
        double result;
        // code here
        for (; ;)
        {
            input = Console.ReadLine();
            if (input == "stop") break;
            double.TryParse(input, out result);
            if (result < answer) answer = result;
        }
        // end
        Console.WriteLine(answer);
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
