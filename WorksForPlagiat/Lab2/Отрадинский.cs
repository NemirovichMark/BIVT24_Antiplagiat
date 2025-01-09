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
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_3(6);
        //program.Task_2_4(5, 1, 3);
        //program.Task_2_5(6, 25.2);
        //program.Task_2_6(3);
        program.Task_2_7(3);
        //program.Task_2_8(3);
        //program.Task_2_9(10);
        //program.Task_2_10(10);
        //program.Task_2_11(10);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(0.2, 2.8, 2);
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

 //TO DO: 2_8

    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here

        int r = 2;

        if (Math.Abs(x * x + y * y - r * r) <= 0.001) { answer = true; }
        else { answer = false; }

        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here

        if ((y >= 0) && (y + Math.Abs(x) <= 1)) { answer = true; }
        else { answer = false; }

        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here

        if (a > 0)
        {
            if (a > b) { answer = a; } else { answer = b; }
        }
        else
        { 
            if (a < b) { answer = a; } else { answer = b;  }
        }

        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here

        if (a < b)
        {
            if (a > c) { answer = a; } else { answer = c; }
        }
        else 
        {
            if (b > c) { answer = b; } else { answer = c; }
        }

        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        
        double radius = Math.Sqrt(r / Math.PI);
        double sq_side = Math.Sqrt(s);
        double sq_diag = Math.Sqrt(sq_side * sq_side * 2) / 2;

        if (radius >= sq_diag) { answer = true; }

        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here

        double radius = Math.Sqrt(r / Math.PI);
        double sq_side = Math.Sqrt(s) / 2;

        if (radius <= sq_side) { answer = true; }


        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here


        if (Math.Abs(x) > 1) {  answer = 1; }
        else {  answer = Math.Abs(x); }

        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here

        if (Math.Abs(x) >= 1) { answer = 0;  }
        else { answer = x * x - 1; }

        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here

        if (x <= -1) { answer = 0; }
        else if ((x > -1) && (x <= 0)) { answer = 1 + x; }
        else { answer = 1; }

        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here

        if (x <= -1) { answer = 1; }
        else if ((-1 < x) && (x <= 1)) { answer = -x; }
        else if (x > 1) { answer = -1; }

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here

        double S = 0;
        int i = n;

        while (n > 0)
        {
            string str_num = Console.ReadLine();
            double num = double.Parse(str_num);
            S += num;
            n--;
        }

        answer = S / i;

        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here

        int i = n;
        int cnt = 0;

        while (i > 0)
        {
            double a_1 = double.Parse(Console.ReadLine());
            double b_1 = double.Parse(Console.ReadLine());

            if ((a_1 < (r + a)) && (a_1 > (a - r)))
            {
                if ((b_1 < (r + b)) && (b_1 > (b - r)))
                {
                    cnt += 1;
                }
            }

            i--;

        }

        answer = cnt;
        
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here

        int i = n;

        while (i > 0)
        {
            double curr_weigh = double.Parse(Console.ReadLine());
            if (curr_weigh < 30) { answer += 0.2; }
            i--;
        }

        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here

        int i = 2 * n;
        int cnt = 0;


        while (i > 0)
        {
            double a_1 = double.Parse(Console.ReadLine());
            double b_1 = double.Parse(Console.ReadLine());
            
            if ((Math.Sqrt(a_1 * a_1 + b_1 * b_1) <= r2) && (Math.Sqrt(a_1 * a_1 + b_1 * b_1) >= r1))
            {
                cnt++;
            }

            i -= 2;

        }

        answer = cnt;
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        
        int i = n;
        

        while (i > 0)
        {
            double curr_res = double.Parse(Console.ReadLine());

            if (curr_res <= norm){ answer++; }

            i--;
        }
        
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here

        while (n > 0)
        {
            double x = double.Parse((Console.ReadLine()));
            double y = double.Parse((Console.ReadLine()));

            if (x >= 0 && x <= Math.PI && y >= 0  && y <= Math.Sin(x)) { answer++; }

            n--;
        }

        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        while (n > 0)
        {
            double x = double.Parse((Console.ReadLine()));
            double y = double.Parse((Console.ReadLine()));

            if (x > 0 && y > 0) { answer1++; Console.WriteLine("quad:1"); }
            if (x < 0 && y > 0) { Console.WriteLine("quad:2"); }
            if (x < 0 && y < 0) { answer3++; Console.WriteLine("quad:3"); }
            if (x > 0 && y < 0) { Console.WriteLine("quad:4"); }

            n--;
        }

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        int cnt = 0;

        while (n > 0)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double curr_l = Math.Sqrt(a * a + b * b);
            cnt++;

            if (curr_l < answerLength) 
            { 
                answerLength = curr_l;
                answer = cnt;
            }
            
            n--;
            
        }

        answerLength = Math.Round(answerLength, 2);

        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here

        int i = n;

        while (i > 0)
        {
            double curr_res = double.Parse(Console.ReadLine());
            if (answer > curr_res) { answer = curr_res; }
            i--;
        }

        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;

        int i = n, f = 0;
        answer = n;

        while (i > 0)
        {
            for (int j = 0; j < 4; j++)
            {
                int curr_gr = int.Parse(Console.ReadLine());
                if ((curr_gr == 3) ||  (curr_gr == 2))
                {
                    f = 1;
                }
            }
            if (f == 1) { answer--; }
            f = 0;
            i--;
        }

        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;

        double total_s = 0;
        int f = 0, i = n;

        while (n > 0)
        {
            for (int j = 0; j < 4; j++)
            {
                double curr_gr = double.Parse(Console.ReadLine());
                total_s += curr_gr;
                if (curr_gr == 2) { f = 1; }
            }

            if (f == 1) { answer++; }

            f = 0;
            n--;
        }

        avg = total_s / (i * 4.0);

        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;

        if (r > 0)
        {
            switch(type)
            {
                case 0:
                    answer = r * r;
                    break;
                case 1:
                    answer = Math.PI * r * r;
                    break;
                case 2:
                    answer = (Math.Sqrt(3) * r * r) / 4;
                    break;
                default:
                    answer = 0; break;

            }
        }
        else { answer = 0; }

        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;

        if (A > 0 && B > 0 )
        {
            switch (type)
            {
                case 0:
                    answer = A * B; break;
                case 1:
                    answer = Math.Abs(Math.PI * B * B - Math.PI * A * A);
                    break;
                case 2:
                    double p = (A + B + B) / 2;
                    answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B));
                    break;
                default:
                    answer = 0; break;
            }
        }
        else { answer = 0; }

        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
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
        bool f = true;

        while (f)
        {
            double curr_weigh = 0;
            f = double.TryParse(Console.ReadLine(), out curr_weigh);
            if (!f) { break; }
            if (curr_weigh < 30) { answer += 0.2; }

            answer = Math.Round(answer, 2);
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
        bool f1 = true, f2 = true;

        while (f1 && f2)
        {
            double x = 0;
            double y = 0;

            f1 = double.TryParse(Console.ReadLine(), out x);
            if (!f1) { break; }
            f2 = double.TryParse(Console.ReadLine(), out y);
            if (!f2) { break; }

            if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x)) { answer++; }

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