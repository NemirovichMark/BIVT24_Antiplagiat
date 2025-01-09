using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.Task_1_1(0.9, 1.23);
        program.Task_1_2(0.9, 1.23);
        program.Task_1_3(0.9, 1.23);
        program.Task_1_4(0.9, 1.23, -0.1);
        program.Task_1_5(0.9, 1.23);
        program.Task_1_6(0.9, 1.23);
        program.Task_1_7(0.9);
        program.Task_1_8(0.9);
        program.Task_1_9(0.9);
        program.Task_1_10(0.9);
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
        //program.Task_2_10(6);
        //program.Task_2_11(10);
        program.Task_2_12(10, 0);
        program.Task_2_13(10, 5, 0);
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
        if (Math.Abs(x*x + y*y - r*r) <= Math.Pow(10, -3)){
            answer = true;
        }
        else
        {
            answer = false;
        }
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
        else if (a <= 0)
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
        double f = 0;
        if (a < b)
        {
            f = a;
        }
        else
        {
            f = b;
        }
        if (f > c)
        {
            answer = f;
        }
        else
        {
            answer = c;
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double square_side = Math.Sqrt(s);
        double diagonal = square_side * Math.Sqrt(2);
        double diametr = 2 * Math.Sqrt(r / Math.PI);
        if (diagonal <= diametr)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        Console.WriteLine("{0} {1}", diametr, diagonal);
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double square_side = Math.Sqrt(s);
        double diametr = 2 * Math.Sqrt(r / Math.PI);
        if (square_side >= diametr)
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
        else if ((-1 < x) && (x <= 0))
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
        else if ((-1 < x) && (x <= 1))
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
        double answer = 0;

        // code here
        double summ = 0;
        for (int i = 1; i <= n; i++)
        {
            double height = double.Parse(Console.ReadLine());
            summ+= height;
        }
        answer = summ / n;
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
            if ((Math.Pow(x-a, 2) + Math.Pow(y-b, 2)) <= r * r)
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
        for (int i = 1; i <= n; i++)
        {
            double weight = double.Parse(Console.ReadLine());
            if (weight < 30)
            {
                answer += 0.2;
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
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((r1 <= Math.Sqrt(x*x + y*y)) && (r2 >= Math.Sqrt(x*x + y * y))) //формула расстояния = корень из (x^2 + y^2) 
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
            double member_result = double.Parse(Console.ReadLine());
            if (member_result <= norm)
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
            if ((x >= 0) && (x <= Math.PI))
            {
                if ((y >= 0) && (y <= Math.Sin(x)))
                {
                    answer++;
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
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((x > 0) && (y > 0))
            {
                answer1++;
                Console.WriteLine("quadrant 1");
            }
            else if (((x < 0) && (y > 0)))
            {
                Console.WriteLine("quadrant 2");
            }
            else if ((x < 0) && (y < 0))
            {
                answer3++;
                Console.WriteLine("quadrant 3");
            }
            else if (((x > 0) && (y < 0)))
            {
                Console.WriteLine("quadrant 4");
            }
        }
        Console.WriteLine("{0} {1}", answer1, answer3);
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        // code here
        double s;
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            s = Math.Sqrt(x * x + y * y); //расстояние точки с введенными координатами до начала координат
            if (s < answerLength)
            {
                answerLength = s;
                answer = i;
            }
        }
        Console.WriteLine("{0} {1}", answer, Math.Round(answerLength, 2));
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double result = double.Parse(Console.ReadLine());
            if (result < answer)
            {
                answer = result;
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
        for (int i = 1;i <= n; i++)
        {
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            if (((x1 != 2) && (x1 != 3)) && ((x2 != 2) && (x2 != 3)) && ((x3 != 2) && (x3 != 3)) && ((x4 != 2) && (x4 != 3)))
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
        int answer = 0; //счетчик неуспеваемых студентов
        double avg = 0.0;

        // code here;
        int assasment1, assasment2, assasment3, assasment4 = 0;
        for (int i = 1; i <= n; i++)
        {
            assasment1 = int.Parse(Console.ReadLine());
            assasment2 = int.Parse(Console.ReadLine());
            assasment3 = int.Parse(Console.ReadLine());
            assasment4 = int.Parse(Console.ReadLine());
            if (assasment1 == 2 || assasment2 == 2 || assasment3 == 2 || assasment4 == 2)
            {
                answer++;
            }
            avg += assasment1 + assasment2 + assasment3 + assasment4;
        }
        avg = avg / (n * 4);
        Console.WriteLine("{0} {1}", answer, avg);
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
            case 0:
                answer = r * r; break;
            case 1:
                answer = r * r * Math.PI; break;
            case 2:
                answer = (Math.Sqrt(3) / 4) * r * r; break;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if ((A <= 0) || (B <= 0)) return 0;
        switch (type)
        {
            case 0 : answer = A * B; break;
            case 1 : answer = Math.PI * Math.Abs((A * A - B * B)); break;
            case 2 :
                double p = (A + B + B) / 2;
                if (A >= 2 * B) return 0;
                answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B));
                break;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
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
        double height, summ = 0;
        for (; ; n++ )
        {
            double.TryParse(Console.ReadLine(), out height);
            if (height <= 0) break;
            summ += height;
        }
        answer = summ / n;
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
        double weight = 0;
        while (weight != 1000) 
        {
            double.TryParse(Console.ReadLine(), out weight);
            if (weight < 30)
            {
                answer += 0.2;
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
        double x = 0;
        double y = 0;
        while (x != 10)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((x >= 0) && (x <= Math.PI))
            {
                if ((y >= 0) && (y <= Math.Sin(x)))
                {
                    answer++;
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
        double result = 0;
        while (result != 1000)
        {
            double.TryParse(Console.ReadLine(), out result);
            if (result < answer)
            {
                answer = result;
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