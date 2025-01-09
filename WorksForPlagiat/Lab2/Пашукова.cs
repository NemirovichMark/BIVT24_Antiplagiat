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
        program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;
        bool a = true;
        // code here
        if (Math.Abs(x * x + y * y - 2 * 2) < 0.001)
        {
            answer=true;
        }
         Console.WriteLine(answer);
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
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
  
        if (a>0 && a > b)
            answer= a;
        if (a > 0 && b > a)
            answer= b;
        if (a <= 0 && a > b)
            answer= b;
        if (a <= 0 && b > a)
            answer =a;

        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        double i = 0;
        // code here
        if (a > b)
            i= b;
        else
            i= a;
        if (i > c)
            answer = i;
        else
            answer = c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (2 * Math.Sqrt(r / Math.PI) > Math.Sqrt(s) * Math.Sqrt(2))
            return answer = true;

        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (2 * Math.Sqrt(r / Math.PI) < Math.Sqrt(s) )
            return answer = true;

        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1)
            answer = 1;
        if (Math.Abs(x) <= 1)
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
        if (Math.Abs(x) < 1)
            answer = (x * x) - 1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 0;
        if (x > -1 && x <= 0)
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
        if (x > -1 && x <= 1)
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
        double r = 0;
        // code here
        for (int k = 0; k < n; k++)
        {
            r = double.Parse(Console.ReadLine());
            answer += r;
        }
        answer /= n;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x = 0;
        double y = 0;
        double R = 0;
        // code here
        for (int k = 0; k < n; k++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            R = Math.Sqrt(((x - a) * (x - a)) + ((y - b) * (y - b)));
            if (R < r)
                answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        double v = 0;
        // code here
        for (int k = 0; k < n; k++)
        {
            v = double.Parse(Console.ReadLine());
            if (v < 30)
                answer += 200;
        }

        Console.WriteLine(answer / 1000);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        double x = 0;
        double y = 0;
        double R = 0;
        // code here
        for (int k=0; k<n; k++)
        {
            x= double.Parse(Console.ReadLine());
            y= double.Parse(Console.ReadLine());
            R = Math.Sqrt(x * x + y * y);
            if ( r1<R && R> r2)
                answer++;

        }
        Console.WriteLine(answer);
         //end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        double r = 0;
        // code here
        for (int k = 0; k < n; k++)
        {
            r = double.Parse(Console.ReadLine());
            if (r <= norm)
                answer++;

        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        double x = 0;
        double y = 0;
        // code here
        for (int k = 0; k < n; k++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ((x >= 0) && (x <= Math.PI) && (Math.Sin(x) >= y))
                answer++;
            
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
        double x = 0;
        double y = 0;
        // code here
        for (int k = 0; k < n; k++)
        { 
            x=double.Parse(Console.ReadLine());
            y= double.Parse(Console.ReadLine());
            if (y > 0 && x > 0)
            {
                answer1++;
                Console.WriteLine("1");
            }
            if (y < 0 && x > 0)
            {
                answer3++;
                Console.WriteLine("3");
            }
            if(y>0 && x<0)
                Console.WriteLine("2");
            if (y < 0 && x > 0)
                Console.WriteLine("4");
        }
        // end
        Console.WriteLine($"{answer1} and {answer3}");
        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        double x = 0;
        double y = 0;
        double R = 0;
        // code here
        for (int k = 1; k <= n; k++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            R = Math.Sqrt(x * x + y * y);
            if (R < answerLength)
            {
                answer = k;
                answerLength = R;

            } 
        }
        // end
        answerLength= Math.Round(answerLength,2);
        Console.WriteLine($"{answer} and {answerLength}");
        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double r = 0;
        // code here
        for (int k = 0; k < n; k++)
        { 
            r=double.Parse(Console.ReadLine());
            if (r < answer)
                answer = r;
        
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        double a = 0;
        double b = 0;
        double c = 0;
        double d = 0;
        // code here;
        for (int k = 0; k < n; k++)
        { 
            a= double.Parse(Console.ReadLine());
            b= double.Parse(Console.ReadLine());
            c= double.Parse(Console.ReadLine());
            d= double.Parse(Console.ReadLine());
            if (a > 3 && b > 3 && c > 3 && d > 3)
                answer++;
        
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        double a = 0;
        double b = 0;
        double c = 0;
        double d = 0;
        // code here;
        for (int k = 0; k < n; k++)
        {
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            avg += a + b + c + d;
            if (a==2 || b==2 || c==2 || d==2)
                answer++;
        }
        avg /= (n * 4);
        Console.WriteLine($"{avg} and {answer}");
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        if (r < 0) return answer = 0;
        // code here;
        switch (type)
        {
            case 0:
                answer = Math.Round((r * r), 2);
                break;
            case 1:
                answer= Math.Round((Math.PI *r*r), 2);
                break;
            case 2:
                answer = Math.Round(((r * r * Math.Sqrt(3)) / 4), 2);
                break;
            default:
                break;
    
        }
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        double ger = 0;
        if (A<=0 || B<=0) return answer = 0;
        // code here;
        switch (type)
        {
            case 0:
                answer = Math.Round((A * B), 2);
                break;
            case 1:
                if (A > B)
                {
                    answer = Math.Round((Math.PI * (A * A - B * B)), 2);
                }
                else if (B > A)
                {
                    answer = Math.Round((Math.PI * (B * B - A * A)), 2);
                }
                if (answer < 0)
                {
                    return answer = 0;
                }
                break;
            case 2:
                ger = (A + B + B) / 2;
                answer = Math.Round((Math.Sqrt(ger * (ger - A) * (ger - B) * (ger - B))), 2);
                if (answer > 0) return answer;
                else return answer = 0;
                break;
            default:
                break;

        }
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
        double x = 0;
        double y = 0;
        double R = 0;
        // code here
        while (true)
        {
            x = double.Parse(Console.ReadLine());
            if (x == 99999)
                Console.WriteLine(answer);
            y = double.Parse(Console.ReadLine());
            R = Math.Sqrt(((x - a) * (x - a)) + ((y - b) * (y - b)));
            if (R < r) 
                answer++;
        }
        Console.WriteLine(answer);

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

        // end

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;
        double r = 0;
        // code here
        while(true)
        {
            r = double.Parse(Console.ReadLine());
            if (r==99999) Console.WriteLine( answer);
            if (r <= norm)
                answer++;

        }
        // end
        Console.WriteLine(answer);
        return answer;
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

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;
        double x = 0;
        double y = 0;
        double R = 0;
       while (true)
        {
            n++;
            x = double.Parse(Console.ReadLine());
            if (x == 99999)
            { 
                Console.WriteLine(answer);
                 break;
            }
            y = double.Parse(Console.ReadLine());
            R = Math.Sqrt(x * x + y * y);
            if (R < answerLength)
            {
                answer = n;
                answerLength = R;

            }
        }
        // end
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine($"{answer} and {answerLength}");
        return (answer, answerLength);
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

        // end

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;
        double a = 0;
        double b = 0;
        double c = 0;
        double d = 0;
        // code here;
        while(true)
        {
            a = double.Parse(Console.ReadLine());
            if (a == 99999)
            {
                Console.WriteLine(answer);
                break;
            }

            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            avg += a + b + c + d;
            n++;
            if (a == 2 || b == 2 || c == 2 || d == 2)
                answer++;
        }
        avg /= (n * 4);
        Console.WriteLine($"{avg} and {answer}");

        // end

        return (answer, avg);
    }
    #endregion
}