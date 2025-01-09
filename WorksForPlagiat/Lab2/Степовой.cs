using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        // program.Task_1_1(0.9, 1.23);
        //program.Task_1_2(0.9, 1.23);
        //program.Task_1_3(0.9, 1.23);
        //program.Task_1_4(0.9, 1.23, -0.1);
        //program.Task_1_5(0.9, 1.23);
        //program.Task_1_6(0.9, 1.23);
        //program.Task_1_7(0.9);
        //program.Task_1_8(0.9);
        //program.Task_1_9(0.9);
        //program.Task_1_10(0.9);
        // program.Task_2_1(10);
        // program.Task_2_2(5, 3, 2, 1);
        // program.Task_2_2(5, 1.5, 1.5, 1);
        // program.Task_2_2(5, 1, 3, 1);
        // program.Task_2_3(6);
        // program.Task_2_4(3, 1, 3);
        // program.Task_2_5(10, 30);
        // program.Task_2_6(5);
        // program.Task_2_7(5);
        // program.Task_2_8(4);
        // program.Task_2_9(6);
        // program.Task_2_10(10);
        // program.Task_2_11(10);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        // program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 2);
        // program.Task_3_5(30);
        //program.Task_3_6();
        //program.Task_3_7();
        // program.Task_3_8();
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

        if(Math.Abs(x*x+y*y-4)<=0.001)
        {
            answer=true;
        }

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        if (y>=0 && y+Math.Abs(x)<=1)
        {
            answer=true;
        }

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        if(a>0)
        {
            if(a>=b){answer=a;}
            else{answer=b;}
        }
        else
        {
            if(a>=b){answer=b;}
            else{answer=a;}
        }

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        double m=0;

        if(a>=b)
        {m=b;}
        else
        {m=a;}

        if(m>=c)
        {answer=m;}
        else
        {answer=c;}

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        if (Math.Pow(s/2,0.5)<=Math.Pow(r/Math.PI,0.5))
        {
            answer=true;
        }

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        if (Math.Pow(s/4,0.5)>=Math.Pow(r/Math.PI,0.5))
        {
            answer=true;
        }

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        if (Math.Abs(x)>1)
        {answer=1;}
        else
        {answer=Math.Abs(x);}

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        if (Math.Abs(x)>=1)
        {answer=0;}
        else
        {answer=x*x-1;}

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        if (x<=-1)
        {answer=0;}
        else if(-1<x && x<0)
        {answer=1+x;}
        else
        {answer=1;}

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        if (x<=-1)
        {answer=1;}
        else if(-1<x && x<=1)
        {answer=-x;}
        else
        {answer=-1;}

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        int iteration=0;
        double weight=0;
        double summa=0;

        while(iteration<n)
        {
            iteration++;
            Double.TryParse(Console.ReadLine(), out weight);
            summa+=weight;
        }
        answer=summa/n;
        System.Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        int iteration=0;

        while (iteration<n)
        {
            iteration++;
            Double.TryParse(Console.ReadLine(), NumberStyles.Any,new CultureInfo("en-US"), out double x);
            Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double y);
            if ((x-a)*(x-a)+(y-b)*(y-b)<=r*r) answer++;
        }
        System.Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        int iteration=0;

        while (iteration<n)
        {
            iteration++;
            Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double weight);
            if (weight<30) answer+=0.2;
        }
        System.Console.WriteLine(answer);

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        int iteration=0;

        while (iteration<n)
        {
            iteration++;
            Double.TryParse(Console.ReadLine(), NumberStyles.Any,new CultureInfo("en-US"), out double x);
            Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double y);
            if (x*x+y*y<=r2*r2 && x*x+y*y>=r1*r1) answer++;
        }
        System.Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        int iteration=0;

        while (iteration<n)
        {
            iteration++;
            Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double rez);
            if (rez<=norm) answer+=1;
        }
        System.Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        int iteration=0;

        while (iteration<n)
        {
            iteration++;
            Double.TryParse(Console.ReadLine(), NumberStyles.Any,new CultureInfo("en-US"), out double x);
            Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double y);
            if (y>=0 && x>=0 && y<=Math.Abs(Math.Sin(x)) && x<=Math.PI) answer++;
        }
        System.Console.WriteLine(answer);
        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
        int iteration=0;

        while (iteration<n)
        {
            iteration++;
            Double.TryParse(Console.ReadLine(), NumberStyles.Any,new CultureInfo("en-US"), out double x);
            Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double y);
            if (x>0 && y>0) answer1++;
            if (x<0 && y<0) answer3++;
        }
        System.Console.WriteLine(answer1);
        System.Console.WriteLine(answer3);
        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        int iteration=0;
        double x1,y1;

        while (iteration<n)
        {
            iteration++;
            Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double x);
            Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double y);
            if (Math.Sqrt(x*x+y*y)<answerLength)
            {
                x1=x;
                y1=y;
                answerLength=Math.Sqrt(x*x+y*y);
                answer=iteration;
            }
        }
        System.Console.WriteLine(answer);
        System.Console.WriteLine(answerLength);
        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        int iteration=0;
        
        while (iteration<n)
        {
            iteration++;
            Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double rez);
            if(rez<answer) answer=rez;
        }
        System.Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        int iteration=0;
        
        while (iteration<n)
        {
            iteration++;
            Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double a);
            Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double b);
            Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double c);
            Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double d);
            if(a!=2 && a!=3 && b!=2 && b!=3 && c!=2 && c!=3 && d!=2 && d!=3) answer++;
        }
        System.Console.WriteLine(answer);
        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        int iteration=0;
        
        while (iteration<n)
        {
            iteration++;
            Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double a);
            Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double b);
            Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double c);
            Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double d);
            if(a==2 || b==2 || c==2 || d==2) answer++;
            avg+=a+b+c+d;
        }
        System.Console.WriteLine(answer);
        System.Console.WriteLine(avg/n/4);
        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        if(r<=0)
        {
            return 0;
        }

        switch (type)
        {
            case 0:
                answer=r*r;
                break;
            case 1:
                answer=Math.PI*r*r;
                break;
            case 2:
                answer=Math.Sqrt(3)/4*r*r;
                break;
        }
        answer=Math.Round(answer,2);
        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        if(A<=0 || B<=0) return 0;
        switch (type)
        {
            case 0:
            answer=A*B;
            break;
            case 1:
            answer=Math.PI*Math.Abs(A*A-B*B);
            break;
            case 2:
            answer=A/4*Math.Sqrt(4*B*B-A*A);
            break;
        }
        answer=Math.Round(answer,2);
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

        while (true)
        {
            if (!Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double x)) break;
            if (!Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double y)) break;
            if ((x-a)*(x-a)+(y-b)*(y-b)<=r*r) answer++;
        }
        System.Console.WriteLine(answer);

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

        while (true)
        {
            if(!Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double rez)) break;
            if (rez<=norm) answer+=1;
        }
        System.Console.WriteLine(answer);

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
        double x1,y1;
        int iteration=0;

        while (true)
        {
            if (!Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double x)) break;
            if (!Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double y)) break;
            iteration++;
            if (Math.Sqrt(x*x+y*y)<answerLength)
            {
                x1=x;
                y1=y;
                answerLength=Math.Sqrt(x1*x1+y1*y1);
                answer=iteration;
            }
        }
        System.Console.WriteLine(answer);
        System.Console.WriteLine(answerLength);

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

        while (true)
        {
            if (!Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double a)) break;
            if (!Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double b)) break;
            if (!Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double c)) break;
            if (!Double.TryParse(Console.ReadLine(),new CultureInfo("en-US"), out double d)) break;
            n++;
            if(a==2 || b==2 || c==2 || d==2) answer++;
            avg+=a+b+c+d;
        }
        System.Console.WriteLine(answer);
        System.Console.WriteLine(avg/n/4);

        return (answer, avg);
    }
    #endregion
}