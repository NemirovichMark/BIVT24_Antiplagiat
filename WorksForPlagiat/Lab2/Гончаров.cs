using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        //program.Task_2_3(6);
        //program.Task_2_4(5, 1, 2);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(5);
        //program.Task_2_7(5);
        //program.Task_2_8(5);
        //program.Task_2_9(10);
        //program.Task_2_10(10);
        //program.Task_2_11(10);
        //program.Task_2_12(10, 0);1,2
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

        if (Math.Abs(Math.Pow(x, 2) + Math.Pow(y, 2) - Math.Pow(r, 2)) <= Math.Pow(10, -3))
            answer = true;
        else
            answer = false;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here

        if ((y >= 0) & (y + Math.Abs(x) <= 1))
            answer = true;
        else
            answer =  false;
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
                answer = a;
            else
                answer = b;
        }
        if (a <= 0)
        {
            if (a <= b)
                answer = a;
            else
                answer = b;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        if (a >= b)
            a = b;
        if (a >= c)
            answer = a;
        if (a < c)
            answer = c;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double pi = Math.PI;
        pi = Math.Round(pi, 5);
        double Sr = Math.Sqrt(r / pi);
        double Ss = Math.Sqrt(s);

        double diagonal = Math.Sqrt(2) * Ss;

        if (2 * Sr >= diagonal)
            answer = true;
        else
            answer = false;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double pi = Math.PI;
        pi = Math.Round(pi, 5);


        double Sr = Math.Sqrt(r / pi);
        double Ss = Math.Sqrt(s);

        double diagonal = Math.Sqrt(2) * Ss;

        if (2 * Sr <= Ss)
            answer = true;
        else
            answer = false;
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
            answer = Math.Pow(x, 2) - 1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 0;
        if (-1 < x & x <= 0)
            answer = 1 + x;
        if (x > 0)
            answer = 1;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code her
        if (x <= -1)
            answer = 1;
        if (-1 < x & x <= 1)
            answer = -x;
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
        for (int i = 0; i < n; i++)
            answer += int.Parse(Console.ReadLine());
        answer /= n;
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

            // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x;
        double y;
        // code here
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (Math.Pow(x - a, 2) + Math.Pow(y - b, 2) < Math.Pow(r, 2))
                answer += 1;
        }
        Console.WriteLine(answer);

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        double massa;
        // code here
        for (int i = 0; i < n; i++)
        {
            massa = double.Parse(Console.ReadLine());
            if (massa < 30)
                answer += 1;
        }
        answer = answer * 0.2;
        Console.WriteLine(Math.Round(answer, 4));
            // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        double x;
        double y;
        // code here
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ((Math.Pow(r1, 2) < Math.Pow(x, 2) + Math.Pow(y, 2)) && (Math.Pow(x, 2) + Math.Pow(y, 2) < Math.Pow(r2, 2)))
                answer += 1;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        double prov;
        // code here
        for (int i = 0; i < n; i++)
        {
            prov = double.Parse(Console.ReadLine());
            if (prov <= norm)
                answer += 1;
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
        double x;
        double y;
        // code here
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
                answer += 1;
        }
        // end
        Console.WriteLine(answer);
                // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

                return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer2 = 0;
        int answer3 = 0;
        int answer4 = 0;
        double x;
        double y;
        // code here
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                answer1 += 1;
                Console.WriteLine(1);
            }
            if (x < 0 && y < 0)
            {
                answer3 += 1;
                Console.WriteLine(3);
            }
            if (x < 0 && y > 0)
            {
                answer2 += 1;
                Console.WriteLine(2);
            }
            if (x > 0 && y < 0)
            {
                answer4 += 1;
                Console.WriteLine(4);
            }
        }
            // end
            Console.WriteLine(answer1);
            Console.WriteLine(answer3);
            // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

            return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x;
        double y;
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            if (distance < answerLength)
            {
                answerLength = distance; // Обновление ближайшего расстояния
                answer = i + 1; // Обновление индекса ближайшей точки (1-based)
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double x;
        // code here
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            if (x < answer)
                answer = x;
        }
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        double num1;
        double num2;
        double num3;
        double num4;
        for (int i = 0; i < n; i++)
        {
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            num3 = double.Parse(Console.ReadLine());
            num4 = double.Parse(Console.ReadLine());
            if ((num1 >= 4) && (num2 >= 4) && (num3 >= 4) && (num4 >= 4))
                answer += 1;
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
        double num1;
        double num2;
        double num3;
        double num4;
        for (int i = 0; i < n; i++)
        {
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            num3 = double.Parse(Console.ReadLine());
            num4 = double.Parse(Console.ReadLine());
            if ((num1 < 3) || (num2 < 3) || (num3 < 3) || (num4 < 3))
                answer += 1;
            avg += num1 + num2 + num3 + num4;
        }
        Console.WriteLine(answer);
        Console.WriteLine(avg / (n*4));
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r < 0) return 0;
        switch (type)
        {
            case 0: 
                answer = r * r; 
                break;
            case 1: 
                answer = r * r * Math.PI; 
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
        if (A < 0 || B < 0 || (B + B) < A)
            return 0;

        switch (type)
        {
            case 0: 
                answer = A * B; 
                break;
            case 1: 
                answer = Math.Abs(A * A * Math.PI - B * B * Math.PI); 
                break;
            case 2: 
                answer = 0.5 * A * Math.Sqrt(B * B - 0.25 * A * A); 
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
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "")
                break;
            else
            {
                answer += double.Parse(input);
                n++;
            }
        }
        answer /= n;
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        double x;
        double y;
        // code here
        while (true)
        {
            string inputx = Console.ReadLine();
            if (inputx == "")
                break;
            else
            { 
                string inputy = Console.ReadLine();
                x = double.Parse(inputx);
                y = double.Parse(inputy);
                if (Math.Pow(x - a, 2) + Math.Pow(y - b, 2) < Math.Pow(r, 2))
                    answer += 1;
            }
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;
        double massa;
        // code here
        while (true) 
        {
            string input = Console.ReadLine();
            if (input == "")
                break;
            else
            {
                massa = double.Parse(input);
                if (massa < 30)
                    answer += 1;
                n++;
            }
        }
        answer = answer * 0.2;
        Console.WriteLine(Math.Round(answer, 4));
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_3 answer

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        double x;
        double y;
        // code here
        while (true)
        {
            string inputx = Console.ReadLine();
            if (inputx == "")
                break;
            else
            {
                string inputy = Console.ReadLine();
                x = double.Parse(inputx);
                y = double.Parse(inputy);
                if ((Math.Pow(r1, 2) < Math.Pow(x, 2) + Math.Pow(y, 2)) && (Math.Pow(x, 2) + Math.Pow(y, 2) < Math.Pow(r2, 2)))
                    answer += 1;
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
        double prov;
        // code here
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "")
                break;
            else
            {
                prov = double.Parse(input);
                if (prov <= norm)
                    answer += 1;
            }
        }
        Console.WriteLine(answer);

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
        int n = 0;
        int answer1 = 0;
        int answer3 = 0;
        int answer2 = 0;
        int answer4 = 0;
        double x;
        double y;
        // code here
        while (true)
        {
            string inputx = Console.ReadLine();
            if (inputx == "")
                break;
            else
            {
                string inputy = Console.ReadLine();
                x = double.Parse(inputx);
                y = double.Parse(inputy);
                if (x > 0 && y > 0)
                {
                    answer1 += 1;
                    Console.WriteLine(1);
                }
                if (x < 0 && y < 0)
                {
                    answer3 += 1;
                    Console.WriteLine(3);
                }
                if (x < 0 && y > 0)
                {
                    answer2 += 1;
                    Console.WriteLine(2);
                }
                if (x > 0 && y < 0)
                {
                    answer4 += 1;
                    Console.WriteLine(4);
                }
            }
        }
        // end
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
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
