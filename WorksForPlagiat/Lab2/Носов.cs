using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.Metrics;
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
        //program.Task_2_13(10,5,0);
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
        if (Math.Abs(x * x + y * y - r * r) < 0.001)
            answer = true;

        // end

        return answer;
        
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;
        if (y < 0 || y > 1 + x || y > 1 - x)
            answer = false;
        else
            answer = true;
              
        // code here

        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if(a>0)
        {
            answer = b;
            if (a > b)
                answer = a;
        }
        else
        {
            answer = b;
            if (a < b)
                answer = a;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        answer = a;
        if (a > b)
            answer = b;
        if (c > answer)
            answer = c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        r = 2 * Math.Sqrt(r / Math.PI);
        s = Math.Sqrt(s);
        s = Math.Sqrt(2 * s * s);
        if (s <= r)
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        r = 2 * Math.Sqrt(r / Math.PI);
        s = Math.Sqrt(s);
       
        if (s >= r)
            answer = true;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1)
            answer = 1;
        else answer = Math.Abs(x);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1)
            answer = 0;
        else answer = x*x-1;
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
        for(int i=0;i<n;i++)
        {
            answer += double.Parse(Console.ReadLine());
        }
        // end
        answer = answer / n;
        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for(int i = 0; i <n;i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (((a-x)*(a-x)+(b-y)*(b-y))<=r*r) answer += 1;
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double s = double.Parse(Console.ReadLine());
            if (s < 30)
                answer += 0.2;
        }

        

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x * x + y * y >= r1 * r1 && x * x + y * y <= r2 * r2) answer += 1;
        }
        // end
        
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        
        // code here
        for(int i=0;i<n;i++)
        {
            double v = double.Parse(Console.ReadLine());
            if (v < norm) answer++;
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
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x >= 0 && x<=Math.PI && y>=0 && Math.Sin(x) >= y) answer++;
        }
        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1
        
        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for(int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0) answer1++;
            else if (x < 0 && y < 0) answer3++;
        }
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        //Console.WriteLine( $"{answer1}"+" "+ $"{answer3}");
        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        //!!!!!!!!
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        
        
        for(int i=1;i<=n;i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double d = Math.Sqrt(x * x + y * y);
            if (d < answerLength)
            {
                answer = i ;
                answerLength = d;
                
            }
        }
        // end
        //Console.WriteLine($"{answer}" + " " + $"{answerLength}");
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double v = double.Parse(Console.ReadLine());        
        // code here
        for(int i=0;i<n;i++)
        {
            
         double b= double.Parse(Console.ReadLine());
            if (b < v) v = b;
        }
        answer = v;
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        double k = 0;
        double r = 0;
        double t = 0;
        double u = 0;
        // code here;
        for (int i=0;i<n;i++)
        {
            k= double.Parse(Console.ReadLine());
            r = double.Parse(Console.ReadLine());
            t = double.Parse(Console.ReadLine());
            u= double.Parse(Console.ReadLine());
            if (k >= 4 && r>=4 && t>=4 && u>=4) answer++;
            
        }
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        //Console.WriteLine (answer);
        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here
        double k = 0;
        double r = 0;
        double t = 0;
        double u = 0;
        double m = 0;
        // code here;
        for (int i = 0; i < n; i++)
        {
            k = double.Parse(Console.ReadLine());
            r = double.Parse(Console.ReadLine());
            t = double.Parse(Console.ReadLine());
            u = double.Parse(Console.ReadLine());
            if (k==2 || r==2 ||  t==2||u==2) answer++;
            m = m + k + r + t + u;
        }
        // end
        m = m / n / 4;
        avg = Math.Round(m, 2);
        //Console.WriteLine($"{answer}" + " " + $"{avg}");
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        //Console.WriteLine($"{answer}" + " " + $"{avg}");
        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        if (r > 0)
        { switch (type)
            {
                case 0:
                    answer = r * r;
                    break;
                case 1:
                    answer = Math.PI * r * r;
                    break;
                case 2:
                    answer = r * r * Math.Sqrt(3) / 4;
                    break;
                default:
                    answer = 0;
                    break;
            }

        }
        else
        { 
        answer= 0;
        }  
        return Math.Round(answer,2);
        
    }
        
        // end

        
    
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        if (A > 0 && B > 0)
        {
            switch (type)
            {
                case 0:
                    answer = A * B;
                    break;
                case 1:
                    answer = Math.Abs(Math.PI * (A * A - B * B));
                    break;

                case 2:

                    if (B + B > A)
                    {
                        double P = (2 * B + A) / 2;
                        answer = Math.Sqrt(P * (P - B) * (P - A) * (P - B));
                    }
                    else answer = 0;
                    break;
                //else answer = 0;

                default:
                    answer = 0;
                    break;
            }
        }
        else
        {
            answer = 0;
        }
        //Console.WriteLine(answer);
        return Math.Round(answer, 2);
        // end



    
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
        

        // code here
        while (true)
        {
            string q = Console.ReadLine();
            if (q == "stop") break;
            string w = Console.ReadLine();
            if (w == "stop") break;
            double x = double.Parse(q);
            double y = double.Parse(w);
            if (((a - x) * (a - x) + (b - y) * (b - y)) <= r * r) answer += 1;
        }
        // end
        //Console.WriteLine(answer);
       
        
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here

        // end

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
        while (true)
        {
            double v = double.Parse(Console.ReadLine());
            if (v <= 0) break;
            if (v < norm) answer++;
            
        }
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
        int b = 0;
        // code here
        while(true)
        {
            b++;
            string q = Console.ReadLine();
            if (q == "stop") break;
            string w = Console.ReadLine();
            if (w == "stop") break;
            double x = double.Parse(q);
            double y = double.Parse(w);
            double d = Math.Sqrt(x * x + y * y);
            if (d < answerLength)
            {
                answer = b;
                answerLength = d;

            }
        } 
        //Console.WriteLine($"{answer}" + " " + $"{answerLength}");
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
        
        double k = 0;
        double r = 0;
        double t = 0;
        double u = 0;
        double m = 0;
        double a_143 = 0;
        while(true)
        {
            string k_1 = Console.ReadLine();
            if (k_1 == "stop") break;
            
            string r_1 = Console.ReadLine();
            if (r_1 == "stop") break;
            
            string t_1 = Console.ReadLine();
            if (t_1 == "stop") break;
          
            string u_1 = Console.ReadLine();
            if (u_1 == "stop") break;
            k = double.Parse(k_1);
            m += k;
            r = double.Parse(r_1);
            m += r;
            t = double.Parse(t_1);
            m += t;
            u = double.Parse(u_1);
            m += u;
            if (k == 2 || r == 2 || t == 2 || u == 2) answer++;
            a_143++;
        }
        m = m / a_143 / 4;
        avg = Math.Round(m, 2);
        Console.WriteLine($"{answer}" + " " + $"{avg}");
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
