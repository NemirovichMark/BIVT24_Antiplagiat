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
        program.Task_3_2(3, 2, 1);
        program.Task_3_2(1.5, 1.5, 1);
        program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 2);
        program.Task_3_5(30);
        //program.Task_3_6();
        //program.Task_3_7();
        program.Task_3_8();
        //program.Task_3_9();
        //program.Task_3_10();
        program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;
        int r = 2;
        // code here
        if (Math.Abs(x*x + y*y - r*r)<= 0.001)
        {
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if ((y>=0) && (y + Math.Abs(x) <=1))
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
        if (a >0)         //а что, если a==b?
        {
            if (a>b)
            {
                answer = a;
            }
            else
            {
                answer = b;
            }

        }
        else
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
        double min;
        // code here
        if (a<b)
        {
            min = a;
        }
        else
        {
            min = b;
        }
        if (min>c)
        {
            answer = min;
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

        // code herel
        if (s <= 2*r/Math.PI)    //диагональ кв-та должна быть меньше/равна диаметра круга
        {
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (s >= 4 * r / Math.PI)    //сторона кв-та должна быть больше/равна диаметра круга 
        {
            answer = true;
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
        else if (-1<x && x<=0)
        {
            answer = 1+x;
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
        else if (-1 < x && x <= 1)
        {
            answer = -1*x;
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
        double height_sum = 0;
        // code here
        for (int i = 1; i<= n; i++)
        {
            string height = Console.ReadLine();
            height_sum += double.Parse(height);
        }
        answer = height_sum/n;
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x;
        double y;
        // code here
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (Math.Sqrt((x - a) * (x - a) + (y - b) * (y - b)) <= r)
            {
                answer += 1;
            }
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        double weight;
        // code here
        for (int i = 1; i <= n; i++)
        {
            weight = double.Parse(Console.ReadLine());
            if (weight < 30)
            {
                answer += 0.2;
            }
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x;
        double y;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (Math.Sqrt(x * x + y * y) >= 1 && Math.Sqrt(x * x + y * y) <= 2)
            {
                answer++;
            }

        }
        Console.WriteLine(answer);
        return answer;
        // end

       
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double result;
        for (int i = 1; i <= n; i++)
        {
            result = double.Parse(Console.ReadLine());
            if (result <= norm)
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
        double x;
        double y;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x < 0 || x > Math.PI)
            {
                continue;
            }
            else if (x >= 0 && y >= 0 && y <= Math.Sin(x))
            {
                answer++;
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
        double x;
        double y;

        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                answer1++;
                Console.WriteLine("1");
            }
            else if (x < 0 && y < 0)
            {
                answer3++;
                Console.WriteLine("3");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("4");
            }
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
        double x;
        double y;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (Math.Sqrt(x * x + y * y) < answerLength)
            {
                answerLength = Math.Sqrt(x * x + y * y);
                answer = i;
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
        double rez;
        for (int i = 1; i <= n; i++)
        {
            rez = double.Parse(Console.ReadLine());
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
        int mark1;
        int mark2;
        int mark3;
        int mark4;
        for (int i = 1; i <= n; i++)
        {
            mark1 = int.Parse(Console.ReadLine());
            mark2 = int.Parse(Console.ReadLine());
            mark3 = int.Parse(Console.ReadLine());
            mark4 = int.Parse(Console.ReadLine());
            if (mark1 > 3 && mark2 > 3 && mark3 > 3 && mark4 > 3)
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
        int answer = 0;
        double avg = 0.0;

        // code here;
        int mark1;
        int mark2;
        int mark3;
        int mark4;
        for (int i = 1; i <= n; i++)
        {
            mark1 = int.Parse(Console.ReadLine());
            mark2 = int.Parse(Console.ReadLine());
            mark3 = int.Parse(Console.ReadLine());
            mark4 = int.Parse(Console.ReadLine());
            if (mark1 < 3 || mark2 < 3 || mark3 < 3 || mark4 < 3)
            {
                answer++;
            }
            avg += (mark1 + mark2 + mark3 + mark4);
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
        if (r<0 || type<0 || type >2)
        {
            return 0;
        }
        // code here;
        switch (type)
        {
            case 0:
                answer = r*r;
                break;
            case 1:
                answer = r*r*Math.PI;
                break;
            case 2:
                answer = r*r*Math.Sqrt(3)/4;
                break;
        }
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        if (A <= 0 || B <= 0 || type < 0 || type > 2)
        {
            return 0;
        }
        // code here;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs(A * A * Math.PI - B * B * Math.PI);
                break;
            case 2:
                double p = (A + B + B)/2.0;
                answer = Math.Sqrt(p * (p-A) * (p-B) * (p-B));
                break;
        }
        // end
        answer = Math.Round(answer, 2);
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
        int answer = 0;
        double x;
        double y;
        string stop = "c";
        // code here
        while (stop == "c")
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            stop = Console.ReadLine();
            if (Math.Sqrt((x - a) * (x - a) + (y - b) * (y - b)) <= r)
            {
                answer += 1;
            }
        }
        // end
        Console.WriteLine(answer);
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

        // end

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0;

        // code here
        double result;
        string stop = "c";
        while (stop == "c")
        {
            result = double.Parse(Console.ReadLine());
            stop = Console.ReadLine();
            if (result <= norm)
            {
                answer++;
            }
        }

        Console.WriteLine(answer);
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

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x;
        double y;
        string stop = "c";
        int i = 0;
        while (stop == "c")
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            stop = Console.ReadLine();
            i++;
            if (Math.Sqrt(x * x + y * y) < answerLength)
            {
                answerLength = Math.Sqrt(x * x + y * y);
                answer = i;
            }
        }


        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength, 2));
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

        // end

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        int mark1;
        int mark2;
        int mark3;
        int mark4;
        int n = 0;
        string stop = "c";
        while (stop == "c")
        {
            n++;
            mark1 = int.Parse(Console.ReadLine());
            mark2 = int.Parse(Console.ReadLine());
            mark3 = int.Parse(Console.ReadLine());
            mark4 = int.Parse(Console.ReadLine());
            stop = Console.ReadLine();
            if (mark1 < 3 || mark2 < 3 || mark3 < 3 || mark4 < 3)
            {
                answer++;
            }
            avg += (mark1 + mark2 + mark3 + mark4);
        }
        avg /= n * 4;

        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    #endregion
}