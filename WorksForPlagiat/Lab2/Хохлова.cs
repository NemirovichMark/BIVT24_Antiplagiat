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
        //program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        double r=2;
        if (Math.Abs(x*x + y*y - r*r) <= 0.1*0.1*0.1)
        {
            answer = true;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y>=0 && y+Math.Abs(x)<=1)
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
        double c=0;
        if (a > 0)
        {
            if (a > b) { c = a; }
            else { c = b; }
        }
        else
        {
            if (a < b) { c = a; }
            else { c = b; }
        }
        answer = c;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double min = 0;
        if (a < b) { min = a; }
        else { min = b; }
        if (c > min) { answer = c; }
        else { answer = min; }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double R = 0, D = 0;
        R = Math.Sqrt(r / Math.PI);
        D = Math.Sqrt(s * 2)/2;
        if (D <= R) { answer = true; }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double R = 0, D = 0;
        R = Math.Sqrt(r / Math.PI);
        D = Math.Sqrt(s)/2;
        if (R <= D) { answer = true; }
        Console.WriteLine(answer);
        // end
                return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1) { answer = 1; }
        else { answer = Math.Abs(x); }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1) { answer = 0; }
        else { answer = x * x - 1; }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) return 0;
        else if (x > 0) return 1;
        else return 1 + x;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) return 1;
        else if (x > 1) return -1;
        else return -x;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double l;
        int i = n;
        while (i > 0)
        {
            double.TryParse(Console.ReadLine(), out l);
            answer += l;
            i -= 1;
        }
        answer /= n;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x = 0, y = 0;
        while (n>0)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (((x - a) * (x - a)) + ((y - b) * (y - b)) <= r * r) { answer++; }
            n -= 1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double s = 0, m=0;
        while (n>0)
        {
            double.TryParse(Console.ReadLine(), out m);
            if (m < 30)
                answer += 0.3;
            n -= 1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x = 0, y = 0;
        while (n > 0)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (((x * x + y *y) >= r1 * r1)&&((x*x+y*y) <= r2 * r2)) { answer++; }
            n -= 1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double s = 0;
        while (n>0)
        {
            double.TryParse(Console.ReadLine(), out s);
            if (s < norm) { answer++; }
            n -= 1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x = 0, y = 0;
        while (n>0)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x >= 0 && x <= Math.PI && Math.Sin(x) >= y && y>=0) { answer++; }
            n -= 1;
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
        double x = 0, y = 0;
        while ( (n>0))
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((x > 0) && (y > 0))
            {
                Console.WriteLine("1");
                answer1++;
            }
            if ((x<0) && (y>0))
            {
                Console.WriteLine("2");
            }
            if((x < 0) && (y < 0))
            {
                Console.WriteLine("3");
                answer3++;
            }
            if ((x>0) && (y<0))
            {
                Console.WriteLine("4");
            }
            n-= 1;
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
        double x = 0, y = 0;
        for (int i =1; i<=n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((x*x+y*y)<(answerLength*answerLength))
            {
                answer = i;
                answerLength = Math.Sqrt(x * x + y * y);
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
        double t = 0;
        while (n>0)
        {
            double.TryParse(Console.ReadLine(), out t);
            if (t < answer) { answer = t; }
            n -= 1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int m1 = 0, m2 = 0, m3 = 0, m4 = 0;
        while (n>0)
        {
            int.TryParse(Console.ReadLine(), out m1);
            int.TryParse(Console.ReadLine(), out m2);
            int.TryParse(Console.ReadLine(), out m3);
            int.TryParse(Console.ReadLine(), out m4);
            if ((m1 == 4 || m1 == 5) && (m2 == 4 || m2 == 5) && (m3 == 4 || m3 == 5) && (m4 == 4 || m4 == 5)) { answer++; }
            n -= 1;
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
        double m1 = 0, m2 = 0, m3 = 0, m4 = 0;
        for (int i=1; i<=n; i++)
        {
            double.TryParse(Console.ReadLine(), out m1);
            double.TryParse(Console.ReadLine(), out m2);
            double.TryParse(Console.ReadLine(), out m3);
            double.TryParse(Console.ReadLine(), out m4);
            if (m1 == 2 || m2 == 2 || m3 == 2 || m3 == 2) { answer++; }
            avg += m1 + m2 + m3 + m4;
        }
        avg /= (n * 4);
        Console.WriteLine("", answer, avg);
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
                answer = r * r;
                break;
            case 1:
                answer = Math.PI * r * r;
                break;
            case 2:
                answer = (r * r * Math.Sqrt(3))/4;
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

        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;

        // code here
        string CHl = "";
        double l;
        while (true)
        {
            CHl = Console.ReadLine();
            if (CHl != "STOP")
            {
                l = Convert.ToDouble(CHl);
                answer += l;
                n += 1;
            }
            else break;
        }
        answer /= n;
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

        // end

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here
        string CHx = "", CHy = "";
        double x, y;
        while (true)
        {
            CHx = Console.ReadLine();
            if (CHx != "STOP")
            {
                x = Convert.ToDouble(CHx);
                CHy = Console.ReadLine();
                if (CHy != "STOP")
                {
                    y = Convert.ToDouble(CHy);
                }
                else break;
            }
            else break;
            if (((x * x + y * y) >= r1 * r1) && ((x * x + y * y) <= r2 * r2)) { answer++; }
        }
        Console.WriteLine(answer);
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

        // end

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here
        string CHx = "", CHy = "";
        double x, y;
        while (true)
        {
            CHx = Console.ReadLine();
            if (CHx != "STOP")
            {
                x = Convert.ToDouble(CHx);
                CHy = Console.ReadLine();
                if (CHy != "STOP")
                {
                    y = Convert.ToDouble(CHy);
                }
                else break;
            }
            else break;
            if ((x > 0) && (y > 0)) { answer1++; }
            if ((x < 0) && (y < 0)) { answer3++; }
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
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

        // end

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;
        string CH1 = "", CH2 = "", CH3 = "", CH4 = "";
        int m1 = 0, m2 = 0, m3 = 0, m4 = 0;
        while (true)
        {
            CH1 = Console.ReadLine();
            if (CH1 != "STOP")
            {
                m1 = (int)Convert.ToDouble(CH1);
                CH2 = Console.ReadLine();
                if (CH2 != "STOP")
                {
                    m2 = (int)Convert.ToDouble(CH2);
                    CH3 = Console.ReadLine();
                    if (CH3 != "STOP")
                    {
                        m3 = (int)Convert.ToDouble(CH3);
                        CH4 = Console.ReadLine();
                        if (CH4 != "STOP")
                        {
                            m4 = (int)Convert.ToDouble(CH4);
                        }
                        else break;
                    }
                    else break;
                }
                else break;
            }
            else break;
            if ((m1 == 4 || m1 == 5) && (m2 == 4 || m2 == 5) && (m3 == 4 || m3 == 5) && (m4 == 4 || m4 == 5)) { answer++; }
        }
        Console.WriteLine(answer);
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