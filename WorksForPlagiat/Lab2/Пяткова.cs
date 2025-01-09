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
        program.Task_2_5(10, 30);
        //program.Task_2_6(5);
        //program.Task_2_7(5);
        //program.Task_2_8(3);
        //program.Task_2_9(10);
        //program.Task_2_10(6);
        //program.Task_2_11(8);
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
        double a = Math.Abs(x*x + y*y - r*r);
        if (a <= Math.Pow(10,-3))
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
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && y + Math.Abs(x) <= 1)
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
        double max = -9999;
        double min = 9999;
        // code here
        if (a > 0)
        {
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            answer = max;
        }
        else if (a <= 0)
        {
            if (a > b)
            {
                min = b;
            }
            else
            {
                min = a;
            }
            answer = min;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double min = 999999;
        double max = -99999;
        if (a > b)
        {
            min = b;
        }
        else
        {
            min = a;
        }
        if (min > c)
        {
            max = min;
        }
        else
        {
            max = c;
        }
        // end
        answer = max;
        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (Math.Sqrt(s/2) <= Math.Sqrt(r/Math.PI))
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
        if (Math.Sqrt(r/Math.PI)*2 < Math.Sqrt(s))
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
        else if (Math.Abs(x) <= 1)
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
        else if (Math.Abs(x) < 1)
        {
            answer = x*x - 1;
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
        else if ((x > -1) && (x <= 0))
        {
            answer = 1 + x;
        }
        else if (x > 0)
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
        else if ((x > -1) && (x <= 1))
        {
            answer = -x;
        }
        else if (x > 1)
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
        for (int s = 1; s <= n; s += 1)
        {
            double h = double.Parse(Console.ReadLine());
            answer += h;

        }
        answer = answer / n;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        // code here
        for (int s = 1; s <= n; s += 1)
        {

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            //Console.WriteLine($"{x - a}  {y - b}  {r}");
            Console.WriteLine($"{x},{y}");
            if (((x - a)*(x - a) + (y - b)*(y -b )) <= (r*r)) 
            {
                answer += 1;
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
       for (int s = 1;s <= n; s += 1)
       {
            double weight = double.Parse(Console.ReadLine());
            if (weight < 30) 
            {
                answer += 200;
            }    
       }
        // end
        Console.WriteLine(answer/1000);
        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int s = 1; s <= n; s += 1)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine($"{x},{y}");
            if ((x*x+y*y>=r1*r1)&&(x*x+y*y<=r2*r2)) answer += 1;
 
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int s = 1; s <= n; s += 1)
        {
            double x = double.Parse(Console.ReadLine());
            if (x <= norm)
            {
                answer += 1;
            }
        }
        // end
        Console.WriteLine(answer);

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int s = 1; s <= n; s += 1)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((x >= 0) & (y >= 0) & (x <= Math.PI) & (y <= Math.Sin(x)))
            {
                answer += 1;
            }

        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for (int s = 1; s <= n; s += 1)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((x >= 0) && (y >= 0))
            {
                //Console.WriteLine("1 квадрант");
                answer1 += 1;
            }
            if ((x <= 0) && (y >= 0))
                Console.WriteLine("2 квадрант");
            if ((x <= 0) && (y <= 0))
            {
                //Console.WriteLine("3 квадрант");
                answer3 += 1;
            }
            if ((x >= 0) && (y <= 0))
                Console.WriteLine("4 квадрант");
        }
        // end
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        for (int s = 1; s <= n; s += 1)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x*x + y*y < answerLength)
            {
                answerLength = Math.Sqrt(x*x + y*y);
                answer = s;
            }


        }
        Console.WriteLine(answer);
        answerLength = Math.Round(answerLength,2);
        Console.WriteLine(answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int s = 1; s <= n; s += 1)
        {
            double rez = double.Parse(Console.ReadLine());
            if (rez < answer)
            {
                answer = rez;
            }
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int s = 1; s <= n; s += 1)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());
            double fourth = double.Parse(Console.ReadLine());
            if ((first > 3) && (second > 3) && (third > 3) && (fourth > 3))
            {
                answer += 1;
            }
            else
            {
                answer = answer;
            }
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        double summa = 0;

        // code here;
        for (int s = 1; s <= n; s += 1)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());
            double fourth = double.Parse(Console.ReadLine());
            if ((first == 2) || (second == 2) || (third == 2) || (fourth == 2))
            {
                answer += 1;
            }
            else
            {
                answer = answer;
            }
            summa = (first + second + third + fourth) / 4;
        }
        avg = summa / n;
        // end
        Console.WriteLine($"{answer} {avg}");
        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        Console.WriteLine($"{r}     {type}");
        if ((r < 0) || (type < 0) || (type > 2))
            return 0;
        switch (type)
        {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = Math.PI * r * r;
                break;
            case 2:
                answer = (r * r * Math.Sqrt(3)) / 4;
                break;
        }
        // end
        answer = Math.Round(answer,2);
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if ((A < 0) || (type < 0) || (type > 2) || (B < 0) || (A >= 2 * B))
            return 0;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                break;
            case 2:
                answer = (A * Math.Sqrt(4 * B * B - A * A)) / 4;
                break;
        }
        answer = Math.Round(answer, 2);
        // end
        Console.WriteLine(answer);
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
        Console.WriteLine("Для выхода написать -");
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "-")
            {
                break;
            }
            double weight = double.Parse(input);
            if (weight < 30) 
            {
                answer += 200;
                n += 1;
            }   
        }
        // end
        Console.WriteLine(answer/1000);
        Console.WriteLine(n);
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
        Console.WriteLine("Для выхода написать -");
        while (true)
        {
            string inputx = Console.ReadLine();
            string inputy = Console.ReadLine();
            if ((inputx == "-") || inputy == "-")
            {
                break;
            }
            double x = double.Parse(inputx);
            double y = double.Parse(inputy);
            if ((x >= 0) & (y >= 0) & (x <= Math.PI) & (y <= Math.Sin(x)))
            {
                answer += 1;
                n += 1;
            }
        }
        // end
        Console.WriteLine(answer);
        Console.WriteLine(n);
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
        Console.WriteLine("Для выхода написать -");
        // code here
        
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "-")
            {
                break;
            }
            double rez = double.Parse(input);
            if (rez < answer)
            {
                answer = rez;
                n += 1;
            }
        }

        // end
        Console.WriteLine(answer);
        Console.WriteLine(n);
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