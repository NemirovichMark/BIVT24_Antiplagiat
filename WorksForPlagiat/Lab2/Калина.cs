using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Xml;

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
        bool pointLies = false;
        const double r = 2;
        double n = Math.Abs(x * x + y * y - r * r);
        if (n <= 0.0001)
        {
            pointLies = !pointLies;
        }
        return pointLies;
        
    }
    public bool Task_1_2(double x, double y)
    {
        bool outside = false;
        if (y >= 0 && y + Math.Abs(x) <= 1)
            outside = !outside;   


        return outside;
    }
    public double Task_1_3(double a, double b)
    {
        double c = b;
        if (a > 0)
        {
            if (a >= b) c = a;
        }
        else
        {
            if (b >= a) c = a;
        }

        return c;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double value;
        value = b;
        if (a <= b) value = a;
        if (value <= c) value = c; 
        return value;
    }
    public bool Task_1_5(double r, double s)
    {
        bool isFit = false;
        double dSquare, dRound;
        dSquare = Math.Sqrt(2 * s);
        dRound = 2 * Math.Sqrt(r / Math.PI);
        if (dSquare <= dRound) isFit = !isFit;
        return isFit;
    }
    public bool Task_1_6(double r, double s)
    {
        bool isFit = false;
        double sideSquare, sideRound;
        sideSquare = Math.Sqrt(s);
        sideRound = 2 * Math.Sqrt(r / Math.PI);
        if (sideRound <= sideSquare) isFit = !isFit;
        return isFit;
    }
    public double Task_1_7(double x)
    {
        double y = 0;
        if (Math.Abs(x) > 1) y = 1;
        if (Math.Abs(x) <= 1) y = Math.Abs(x);
        return y;
    }
    public double Task_1_8(double x)
    {
        double y = 0;
        if (Math.Abs(x) >= 1) y = 0;
        else if (Math.Abs(x) < 1) y = x * x - 1;
        return y;
    }
    public double Task_1_9(double x)
    {
        double y = 0;
        if (x <= -1) y = 0;
        else if (x >= -1 && x <= 0) y = 1 + x;
        else if (x > 0) y = 1;
        return y;
    }
    public double Task_1_10(double x)
    {
        double y = 0;
        if (x <= -1) y = 1;
        else if (x > -1 && x <= 1) y = -x;
        else if (x > 1) y = -1;
        return y;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double rost, sum = 0;
        for (int i = 1; i <= n; i++)
        {
            double height = double.Parse(Console.ReadLine());
            sum += height;
        }
        rost = sum / n;
        Console.WriteLine(rost);
            // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        return rost;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int count = 0;
        double dist = 0, x, y;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            dist = (x - a) * (x - a) + (y - b) * (y - b);
            if (dist <= r*r) count += 1;
        }
        Console.WriteLine(count);

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return count;
    }
    public double Task_2_3(int n)
    {
        double liter = 0;
        const double ml = 200;
        for (int i = 1; i <= n; i++)
        {
            double weight = double.Parse(Console.ReadLine());
            if (weight < 30)
                liter += ml / 1000;
        }
        Console.WriteLine(liter);


        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return liter;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double dist = x * x + y * y;
            if ((dist >= r1 * r1) && (dist <= r2 * r2))
                count += 1;
        }

        Console.WriteLine(count);

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return count;
    }
    public int Task_2_5(int n, double norm)
    {
        int count = 0;

        for (int i = 1; i <= n; i++)
        {
            double standart = double.Parse(Console.ReadLine());
            if (standart < norm)
                count += 1;
        }
        Console.WriteLine(count);

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return count;
    }
    public int Task_2_6(int n)
    {
        int count = 0;

        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((x >= 0) && (y >= 0) && (x <= Math.PI) && (y <= Math.Sin(x)))
                count += 1;
        }
        Console.WriteLine(count);

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return count;
    }
    public (int, int) Task_2_7(int n)
    {
        int count1 = 0;
        int count3 = 0;
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x >= 0)
            {
                if (y >= 0)
                {
                    count1 += 1;
                    Console.WriteLine('1');
                }
                else
                    Console.WriteLine('4');
            }
            else if (x < 0)
            {
                if (y >= 0)
                    Console.WriteLine('2');
                else
                {
                    count3 += 1;
                    Console.WriteLine('3');
                }

            }
        }

        Console.WriteLine(count1);
        Console.WriteLine(count3);  

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (count1, count3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double distance = Math.Sqrt(x * x + y * y);
                if (answerLength >= distance)
                {
                    answerLength = distance;
                    answer = i;
                }


            }
        }
        else
            answerLength = 0;
        Console.WriteLine(answer);
        answerLength = Math.Round(answerLength);
        Console.WriteLine(answerLength);
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double time = double.MaxValue;
        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                double result = double.Parse(Console.ReadLine());
                if (time >= result)
                    time = result;
            }
        }
        else
            time = 0;
        Console.WriteLine();


        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return time;
    }
    public int Task_2_10(int n)
    {
        int count = 0;

        for (int i = 1; i <= n; i++)
        {
            bool flag = true;
            for (int j = 1; j <= 4; j++)
            {
                string mark = Console.ReadLine();
                if ((mark == "2") || (mark == "3"))
                {
                    flag = false;
                }

            }
            if (flag == false)
                continue;
            count++;
        }
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        Console.WriteLine(count);
        return count;
    }
    public (int, double) Task_2_11(int n)
    {
        // В группе учится n студентов. Каждый сдал 4 экзамена. Подсчитать число неуспевающих студентов и средний балл группы.
        int isFailed = 0;

        double avg = 0.0, sum = 0;

        for (int i = 1; i <= n; i++)
        {
            int t = 0;
            for (int j = 1; j <= 4; j++)
            {
                string res = Console.ReadLine();

                if (res == "2")
                {
                    t = 1;
                }

                sum += double.Parse(res);
            }
            isFailed += t;

        }
        if (n != 0)
            avg = sum / (n * 4);  
        
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        Console.WriteLine(isFailed);

        Console.WriteLine(Math.Round(avg, 2));

        return (isFailed, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double square = 0;
        if (r <= 0 || type < 0 || type > 2)
            return 0;
        switch (type)
        {
            case 0:
                square = r * r;
                break;
            case 1:
                square = Math.PI * r * r;
                break;
            case 2:
                square = Math.Sqrt(3) * r * r / 4;
                break;
        }
        square = Math.Round(square, 2);

        return square;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double square = 0;
        if (type < 0 || type > 2 || A <= 0 || B <= 0)
            return 0;
        switch (type)
        {
            case 0:
                square = A * B; 
                break;
            case 1:
                if (A > B)
                    return 0;
                square = Math.PI * (B * B - A * A);
                break;
            case 2:
                square = (A / 2) * Math.Sqrt(B * B - A * A / 4);
                break;
        }
        square = Math.Round(square, 2);
   
        return square;
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
        double liter = 0;
        const double ml = 200;
        for (int i = 1; i <= int.MaxValue; i++)
        {
            double weight = double.Parse(Console.ReadLine());
            if (weight <= 0) break;
            if (weight < 30)
                liter += ml / 1000;
        }
        Console.WriteLine(liter);


        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return liter;
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

        int count = 0;

        for (int i = 1; i <= int.MaxValue; i++)
        {
            string output1 = Console.ReadLine();
            bool result1 = double.TryParse(output1, out var x);
            if (result1 == false) break;

            string output2 = Console.ReadLine();
            bool result2 = double.TryParse(output2, out var y);
            if (result2 == false) break;

            if ((x >= 0) && (y >= 0) && (x <= Math.PI) && (y <= Math.Sin(x)))
                count += 1;
        }
        Console.WriteLine(count);

        return count;

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1
        // answer should be equal to the task_2_6 answer

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
        double time = double.MaxValue;
        for (int i = 1; i <= int.MaxValue; i++)
        {
            string output1 = Console.ReadLine();
            bool condition = double.TryParse(output1, out var result);
            if (condition == false) break; 
            if (time >= result) 
                time = result;
        }

        Console.WriteLine(time);

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return time;
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
