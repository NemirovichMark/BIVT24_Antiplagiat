using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
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
    WriteLine("jnfvskj")
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        if (x*x+y*y==4) answer = true;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if(y>=0 && y<=x+1 && y<=-x+1)
        {
            answer = true;
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
            if (a >= b) answer = a;
            else answer = b;
        }
        else
        {
            if (a <= b) answer = a;
            else answer = b;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double z;
        if (a >= b) z = b; 
        else z = a; // находим минимум из a и b

        if (z >= c) answer = z;
        else answer = c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (s/r <= 2/Math.PI) answer = true; //вывел отношение площадей (Sквадрата / Sкруга = pi*r^2/(2*r^2))
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (r/s <= Math.PI/4) answer = true;    
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
        else if (x > -1 && x <= 1) answer = -x;
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
        double s = 0;
        double height = 0;

        for (int i = 0; i < n; i++)
        {
            height = double.Parse(Console.ReadLine());
            s += height;
        }

        if (n == 0) answer = 0;
        else answer = s/n;
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        int count = 0;

        for (int i = 0; i < n; i ++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (Math.Pow((x - a) * (x - a) + (y - b) * (y - b), 0.5) <= r) count += 1;
        }
        answer = count;
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double dopLitr = 0;

        for (int i = 0; i < n; i++)
        {
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine(weight);
            if (weight < 30)
            {
                dopLitr += 200;
            }
        }

        answer = dopLitr / 1000;
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());    
            double y = double.Parse(Console.ReadLine());
            if (Math.Pow(x * x + y * y, 0.5) >= r1 && (Math.Pow(x * x + y * y, 0.5)) <= r2) count++;
        }
        answer = count;
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            double CurrentResult = double.Parse(Console.ReadLine());
            if (CurrentResult <= norm && CurrentResult > 0) count++;
        }
        answer = count;
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
            if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x)) answer++;
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

            if (x > 0 && y > 0)
            {
                Console.WriteLine("1");
                answer1++;
            }
            else if (x <= 0 && y >= 0)
            {
                Console.WriteLine("2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("3");
                answer3++;
            }
            else
            {
                Console.WriteLine("4");
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

        for (int i = 0; i < n; i ++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double dist = Math.Pow(x * x + y * y, 0.5);
            if (dist < answerLength)
            {
                answerLength = dist;
                answer = i + 1;
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
            double x = double.Parse(Console.ReadLine());
            if (x < answer) answer = x;
        }
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 0; i < n; i ++)
        {
            bool flag = true;
            for (int u = 0; u < 4; u++)
            {
                double mark = double.Parse(Console.ReadLine());
                if (mark == 2 || mark == 3) flag = false;
            }
            if (flag) answer++;
        }
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        for (int i = 0; i < n; i++)
        {
            bool flag = false;
            for (int u = 0; u < 4; u++)
            {
                double mark = double.Parse(Console.ReadLine());
                if (mark == 2) flag = true;
                avg += mark;
            }
            if (flag) answer++;
        }
        avg /= (n * 4);
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
            case (0):
                answer = r * r;
                break;
            case (1):
                answer = Math.PI * r * r;
                break;
            case (2):
                answer = r * r * Math.Pow(3, 0.5) / 4;
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
        if ((A <= 0) || (B <= 0)) return 0;

        switch (type)
        {
            case (0):
                answer = A * B;
                break;
            case (1):
                answer = Math.PI * Math.Abs(B * B - A * A);
                break;
            case (2):
                answer = 0.5 * A * Math.Pow((B * B - A * A / 4), 0.5);
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
        while (true)
        {
            string m = Console.ReadLine();
            if (m == "") break;
            else if (double.TryParse(m, out double mm))
            {
                if (mm < 30)
                {
                    answer += 0.200; 
                }
            }
            else
            {
                return 0; 
            }
        }
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
        while (true)
        {
            string x = Console.ReadLine();
            if (x == "") break;
            else if (double.TryParse(x, out double xx))
            {
                double y = double.Parse(Console.ReadLine());
                if (xx >= 0 && xx <= Math.PI && y >= 0 && Math.Sin(xx) >= y)
                {
                    answer += 1;
                }
            }
            else
            {
                return 0;
            }
        }
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
        while (true)
        {
            string m = Console.ReadLine();
            if (m == "") break;
            else if (double.TryParse(m, out double mm))
            {
                if (mm < answer) answer = mm;
            }
            else
            {
                return 0;
            }
        }
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