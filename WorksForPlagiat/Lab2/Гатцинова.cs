using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;
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
        //program.Task_3_2(3, 2, 1);
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
        double s = Math.Abs(x*x + y*y -r*r);
        if (s <= 0.001) answer = true;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if ( y>= 0 && y+ Math.Abs(x) <=1) answer=true;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a>0)
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
            if (a<b) answer = a;
            else answer =b;
            
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        double d;
        // code here
        if (a < b) d=a;
        else d=b;
        if (d > c) answer = d;
        else answer=c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double d = (Math.Sqrt(s) * Math.Sqrt(2))/2;
        double R = Math.Sqrt(r/Math.PI);
        if (d <= R) answer =true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double S = Math.Sqrt(s);
        double D = 2*Math.Sqrt(r/Math.PI);
        if (D <= S) answer =true;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >1) answer = 1;
        else answer = Math.Abs(x);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1) answer = 0;
        else answer= x*x -1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 0;
        else if (x > -1 && x<=0) answer = 1+x;
        else answer = 1;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        else if (x > -1 && x<=1) answer = -x;
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
        double k=n;
        double s = 0,r;
        for (double i =0; i< k; i++)
        {
            double.TryParse(Console.ReadLine(),out r);
            s+=r;
        }
        answer= s/k;
        Console.WriteLine(answer);
        return answer;
        // end

        
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x,y;
        for (int i =0; i<n;i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (Math.Sqrt((x-a)*(x-a) + (y-b)*(y-b)) <= r) answer++;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0,s=0;
        double v;
        // code here
        for (int i =0; i < n; i++)
        {
            
            double.TryParse(Console.ReadLine(), out v);
            if (v <30) s+=1;
        }
        // end
        answer=s*200/1000;
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x,y;
        for (int i=0;i<n;i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((x*x +y*y < r2*r2) && (x*x + y*y >r1*r1)) answer++ ;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i=0; i<n; i++)
        {
            double.TryParse(Console.ReadLine(), out double res);
            if (res<=norm) answer++;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i=0; i<n; i++)
        {
            double.TryParse(Console.ReadLine(), out double x);
            double.TryParse(Console.ReadLine(), out double y);
            if (x>=0 && x<= Math.PI && y<= Math.Sin(x) && y >=0) answer++;
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
        for (int i=0; i<n; i++)
        {
            double.TryParse(Console.ReadLine(), out double x);
            double.TryParse(Console.ReadLine(), out double y);
            if (x >0 && y>0)
            {
                answer1++;
                Console.WriteLine("Лежит в 1 квадранте");
            }
            else if (y>0 && x<0) Console.WriteLine("Лежит в 2 квадранте");
            else if (x<0 && y<0)
            {
                answer3++;
                Console.WriteLine("Лежит в 3 квадранте");
            } 
            else Console.WriteLine("Лежит в 4 квадранте");
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
        for (int i=1; i<=n;i++)
        {
            double.TryParse(Console.ReadLine(),out double x);
            double.TryParse(Console.ReadLine(),out double y);
            if (Math.Sqrt(x*x +y*y) <= answerLength)
            {
                answerLength = Math.Sqrt(x*x +y*y);
                answer = i;
            }
        }
        // end
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength,2));
        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i=0; i<n;i++)
        {
            double.TryParse(Console.ReadLine(),out double res);
            if (res<answer) answer=res;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i=0; i<n;i++)
        {
            int.TryParse(Console.ReadLine(),out int a);
            int.TryParse(Console.ReadLine(),out int b);
            int.TryParse(Console.ReadLine(),out int c);
            int.TryParse(Console.ReadLine(),out int d);
            if (a >= 4 && b>=4 && c>=4 && d>=4) answer++;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        double sum=0;
        // code here;
        for (int i=0; i<n;i++)
        {
            double.TryParse(Console.ReadLine(), out double a);
            double.TryParse(Console.ReadLine(), out double b);
            double.TryParse(Console.ReadLine(), out double c);
            double.TryParse(Console.ReadLine(), out double d);
            if (a==2 || b==2 || c==2 || d==2)
            {
                sum=sum+(a+b+c+d)/4;
                answer++;
            }
            else sum+=(a+b+c+d)/4;
        }
        avg=sum/n;
        Console.WriteLine(answer);
        Console.WriteLine(avg);

        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r<=0) answer=0;
        else
        {
            switch(type)
            {
                case 0:
                    answer=r*r;
                    Console.WriteLine(answer);
                    break;
                case 1:
                    answer=Math.PI*r*r;
                    Console.WriteLine(answer);
                    break;
                case 2:
                    answer=r*r*Math.Sqrt(3)/4;
                    Console.WriteLine(answer);
                    break;
                default:
                    Console.WriteLine("Введите число 0,1 или 2");
                    break;
            }
        }
        // end
        answer=Math.Round(answer,2);
        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A <=0 || B<=0) answer =0;
        else
        {
            switch(type)
            {
                case 0:
                    answer=A*B;
                    Console.WriteLine(answer);
                    break;
                case 1:
                    answer=Math.Abs((Math.PI *A*A) - (Math.PI*B*B));
                    Console.WriteLine(answer);
                    break;
                case 2:
                    answer=(A*Math.Sqrt(B*B -(A*A/4)))/2;
                    Console.WriteLine(answer);
                    break;
                default:
                    Console.WriteLine("Введите число 0,1 или 2");
                    break;
            }
        }
        answer=Math.Round(answer,2);
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
        int answer = 0;
        // code here
        while(true)
        {
            if ((!double.TryParse(Console.ReadLine(), out double x)) || (!double.TryParse(Console.ReadLine(), out double y))) break;
            if (Math.Sqrt((x-a)*(x-a) + (y-b)*(y-b)) <= r) answer++;
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
        int answer = 0, n = 0;

        // code here
        while(true)
        {
            if (!double.TryParse(Console.ReadLine(),out double res)) break;
            if (res<=norm) answer++;
        }
        // end
        Console.WriteLine(answer);
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
        int i=0;
        // code here
        while(true)
        {
            i++;
            if ((!double.TryParse(Console.ReadLine(), out double x)) || (!double.TryParse(Console.ReadLine(),out double y))) break;
            if (Math.Sqrt(x*x +y*y) <= answerLength)
            {
                answerLength = Math.Sqrt(x*x +y*y);
                answer = i;
            }
        }
        // end
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength,2));
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
        int n=0;
        // code here;
        while(true)
        {
            int f =1;
            bool student = true;
            for (int i =0; i<4;i++)
            {
                if (!int.TryParse(Console.ReadLine(),out int mark))
                {
                    f=0;
                    break;
                }
                if (mark==2 && student==true)
                {
                    student=false;
                    answer++;
                }
                avg+=mark;
            }
            if (f==0) break;
            n++;
        }
        // end
        avg=avg/(4*n);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        return (answer, avg);
    }
    #endregion
}