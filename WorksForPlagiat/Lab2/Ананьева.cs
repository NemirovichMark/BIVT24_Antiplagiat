using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
        if (Math.Abs(x * x + y * y - r * r) <= 0.001)
        {
            answer = true;
        }
        else answer = false;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if ( (y >= 0) && (y + Math.Abs(x) <= 1))
        {
            answer = true;
        }
        else answer = false;
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
        else
        {
            if (a > b)
            {
                answer = b;
            }
            else
            {
                answer = a;
            }
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double Min = 0;
        if (a > b)
        {
            Min = b;
        }
        else
        {
            Min = a;
        }

        if (Min > c)
        {
            answer = Min;
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
        if (s <= r * 2/Math.PI)
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
        if (s >= r*4 / Math.PI)
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
        else { answer = Math.Abs(x); }
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x)>=1)
        {
            answer = 0;
        }
        else { answer = x*x - 1; }
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
        else if (-1 < x && x<=0)
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
        else if (-1 < x && x <= 1)
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
        double sum = 0;
        for (int i = 1; i<= n; i++)
        {
            double high = Convert.ToDouble(Console.ReadLine());
            sum += high;
        }
        answer = sum/n;
        Console.WriteLine(answer);  
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double sum = 0;
        for (int i = 1; i<= n; i++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            if ((a-x)*(a-x) + (b-y)*(b-y) <= r*r)
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
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            double ves = Convert.ToDouble(Console.ReadLine());
            if (ves < 30)
            {
                sum++;
            }
        }
        answer = (sum * 200) / 1000;
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
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            if ((x * x + y * y > r1 * r1) && (x * x + y * y < r2 * r2)) 
            {
                answer ++;
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
            double res = Convert.ToDouble(Console.ReadLine());
            if (res <= norm)
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
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            if (y >= 0 && x>=0 && x <= Math.PI && y<= Math.Sin(x))
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
        for (int i = 1; i <= n; i++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                answer1++;
                Console.WriteLine("1 кв");
            }
            else if (x < 0 && y > 0) Console.WriteLine("2 кв");
            else if (x < 0 && y < 0)
            {
                answer3++;
                Console.WriteLine("3 кв");
            }
            else Console.WriteLine("4 кв");

        }
        Console.WriteLine($" 1 кв: {answer1} \n 3 кв: {answer3}");
        
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
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double pr = Math.Sqrt(x * x + y * y);
            if (pr < answerLength)
            {
                answerLength = pr;
                answer= i;
            }

        }
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength,2));

        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 1; i<=n; i++)
        {
            double res = Convert.ToDouble(Console.ReadLine());
      
            if (res < answer)
            {
                answer = res;
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
        for (int i = 1; i <= n; i++)
        {
            double t1 = Convert.ToDouble(Console.ReadLine());
            double t2 = Convert.ToDouble(Console.ReadLine());
            double t3 = Convert.ToDouble(Console.ReadLine());
            double t4 = Convert.ToDouble(Console.ReadLine());

            if (t1 != 2 && t1 != 3 && t2 != 2 && t2 != 3 && t3 != 2 && t3 != 3 && t4 != 2 && t4 != 3)
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
        for (int i = 1; i <= n; i++)
        {
            double t1 = Convert.ToDouble(Console.ReadLine());
            double t2 = Convert.ToDouble(Console.ReadLine());
            double t3 = Convert.ToDouble(Console.ReadLine());
            double t4 = Convert.ToDouble(Console.ReadLine());
      
            if ((t1 == 2) || (t2 == 2) || (t3 == 2) || (t4 ==2))
            {
                answer++;
            }
            avg += (t1 + t2 + t3 + t4);
        }
        avg = avg / (n * 4);
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
            case 0:
                answer = r*r;
                break;
            case 1:
                answer = Math.PI * (r * r);
                break;
            case 2:
                answer = r*r*Math.Sqrt(3)/4;
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
        if (A <= 0 || B <= 0 || (type <= 0 && type >= 2)) return 0;
        switch (type)
        {
            case 0:
                answer = A*B;
                break;
            case 1:
                answer = Math.Abs(A*A*Math.PI - B*B * Math.PI);
                break;
            case 2:
                double t = (B+B+A)/2;
                answer = Math.Sqrt(t * (t - A) * (t - B) * (t - B));
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
        double x = 0, y = 0;

        // code here
        Console.WriteLine("¬ведите stop чтобы остановить прграмму");
        
        
        while (true)
        {
            string t = (Console.ReadLine());
            if (t == "stop") break;
            else
            {
                double.TryParse(t, out x);
                double.TryParse(Console.ReadLine(), out y);

                if ((a - x) * (a - x) + (b - y) * (b - y) <= r * r)
                {
                    answer += 1;
                }

            }
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
        int answer = 0, n = 0 ;
        double res = 0;

        // code here
        while (true) 
        {
            string t = (Console.ReadLine());
            if (t == "stop") break;
            else
            {
                double.TryParse(t, out res);
                if (res <= norm)
                {
                    answer++;
                }
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
        int answer = 0, n = 0, i=0;
        double answerLength = double.MaxValue;
        double x, y,pr;

        // code here
        while(true)
        {
            string t = (Console.ReadLine());
            if (t == "stop") break;
            else
            {
                double.TryParse(t, out x);
                double.TryParse(Console.ReadLine(), out y);
                pr = Math.Sqrt(x * x + y * y);
                i++;
                if (pr < answerLength)
                {
                    answerLength = pr;
                    answer = i;
                }
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
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;
        double t1, t2, t3, t4;
        while (true)
        {
            string t = (Console.ReadLine());
            if (t == "stop") break;
            else
            {
                double.TryParse(t, out t1);
                double.TryParse(Console.ReadLine(), out t2);
                double.TryParse(Console.ReadLine(), out t3);
                double.TryParse(Console.ReadLine(), out t4);
                n++;
                if ((t1 == 2) || (t2 == 2) || (t3 == 2) || (t4 == 2))
                {
                    answer++;
                }
                avg += (t1 + t2 + t3 + t4);
            }
        }
        avg = avg / (n * 4);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    #endregion
}