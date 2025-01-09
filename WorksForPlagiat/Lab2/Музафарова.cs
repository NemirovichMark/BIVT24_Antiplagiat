
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
        

        // code here
        bool answer = false;

        // code here
        int r = 2;
        if (Math.Abs(x * x + y * y - r * r) <= 1.0 / (10 * 10 * 10))
        {
            answer = true;
        }
        // end

        
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && (y + Math.Abs(x)) <= 1)
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
            if (a >= b)
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
            if (a <= b)
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
       

        // code here
        double answer = 0;
        double h = 0;

        // code here
        if (a <= b)
        {
            h = a;
        }
        else
        {
            h = b;
        }
        if (h >= c)
        {
            answer = h;
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
        

        // code here
        bool answer = false;

        // code here
        double rad = Math.Sqrt(r / Math.PI);
        double diag = Math.Sqrt(s) * Math.Sqrt(2);
        if (diag <= 2 * rad)
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
        double rad = Math.Sqrt(r / Math.PI);
        double diag = Math.Sqrt(s) * Math.Sqrt(2);
        if ((diag >= 2 * rad) && (Math.Sqrt(s) >= 2 * rad))
        {
            answer = true;
        }
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double y = 0;

        // code here
        if (Math.Abs(x) > 1)
        {
            y = 1;
        }
        else
        {
            y = Math.Abs(x);
        }
        // end
        // end

        return y;
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
            answer = (x * x) - 1;
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
        else if (x > 1)
        {
            answer = -1;
        }
        else
        {
            answer = -x;
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
        double height = 0;
        for (int i = 1; i <= n; i += 1)
        {
            double.TryParse(Console.ReadLine(), out height);
            answer += height;
        }
        answer /= n;
        // end
        Console.WriteLine(answer);

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x = 0;
        double y = 0l;
        // code here
        for (int i = 1; i <= n; i += 1)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);

            if ((((x - a) * (x - a)) + ((y - b) * (y - b))) <= r * r)
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
        double wt = 0;
        for (int i = 1; i <= n; i += 1)
        {
            double.TryParse(Console.ReadLine(), out wt);
            if (wt < 30)
            {
                answer += 200;
            }
        }
        Console.WriteLine(Math.Round(answer / 1000, 1));
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        double x;
        double y;

        // code here
        for (int i = 1; i <= n; i += 1)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((x * x + y * y >= r1 * r1))
            {
                if (x * x + y * y <= r2 * r2) { answer += 1; }
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
        for (int i = 1; i <= n; i += 1)
        {
            double.TryParse(Console.ReadLine(), out double res);
            if (res <= norm)
            {
                answer += 1;
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
        for (int i = 1; i <= n; i += 1)
        {
            double.TryParse(Console.ReadLine(), out double x);
            double.TryParse(Console.ReadLine(), out double y);
            if ((x >= 0) && (y >= 0) && (x <= Math.PI) && (y <= Math.Sin(x)))
            {
                answer += 1;
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
            double.TryParse(Console.ReadLine(), out double x);
            double.TryParse(Console.ReadLine(), out double y);
            if (x > 0)
            {
                if (y > 0)
                {
                    //1 квадрант
                    answer1++;
                }
                if (y < 0)
                {
                    //4 квадрант
                }
            }
            else if (x < 0)
            {
                if (y > 0)
                {
                    //2 квадрант
                }
                if (y < 0)
                {
                    //3 квадрант
                    answer3++;
                }
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
        double answerLeng = double.MaxValue;

        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out double x);
            double.TryParse(Console.ReadLine(), out double y);
            double s = Math.Sqrt(x * x + y * y);
            if (s < answerLeng)
            {
                answer = i;
                answerLeng = s;
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLeng, 2));
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double result;
        for (int i = 1; i <= n; i += 1)
        {
            double.TryParse(Console.ReadLine(), out result);
            if (result < answer)
            {
                answer = result;
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
        for (int i = 1; i <= n; i += 1)
        {
            int.TryParse(Console.ReadLine(), out int mark1);
            int.TryParse(Console.ReadLine(), out int mark2);
            int.TryParse(Console.ReadLine(), out int mark3);
            int.TryParse(Console.ReadLine(), out int mark4);
            if (mark1 != 3 && mark1 != 2 && mark2 != 3 && mark2 != 2 &&
                    mark3 != 3 && mark3 != 2 && mark4 != 3 && mark4 != 2)
            {
                answer += 1;
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
        for (int i = 1; i <= n; i += 1)
        {
            int.TryParse(Console.ReadLine(), out int mark1);
            int.TryParse(Console.ReadLine(), out int mark2);
            int.TryParse(Console.ReadLine(), out int mark3);
            int.TryParse(Console.ReadLine(), out int mark4);
            if (mark1 < 3 || mark2 < 3 || mark3 < 3 || mark4 < 3)
            {
                answer += 1;
            }
            avg += (double)(mark1 + mark2 + mark3 + mark4) / 4;
        }
        avg /= n;
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here
        
        if (r <= 0)
        {
            return 0;
        }
        switch (type)
        {
            case 0: answer = r * r; 
                break;
            case 1: answer = r * r * Math.PI; 
                break;
            case 2: answer = r * r * Math.Sqrt(3) / 4; 
                break;
        }

        return Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (type < 0 || type > 2) return 0;
        if (A <= 0) return 0;
        if (B <= 0) return 0;
        if (type == 0)
        {
            answer = A * B;
        }
        else if (type == 1)
        {

            answer = Math.PI * Math.Abs(B * B - A * A);
        }
        else if (type == 2)
        {
            double h = Math.Sqrt(B * B - A * A / 4);
            answer = A * h / 2;
        }
        answer = Math.Round(answer, 2);
        // end
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

            // code here
            double answer = 0;
            double wt = 0;
            bool h;

            while (true)
            {

                h = double.TryParse(Console.ReadLine(), out wt);
                if (h == false)
                {
                    break;
                }

                if (wt < 30)
                {
                    answer += 200;
                }
            }
            Console.WriteLine(Math.Round(answer / 1000, 1));
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
            int answer = 0;

            // code here
            double x = 0;
            double y = 0;
            bool h1;
            bool h2;
            while (true)
            {
                h1 = double.TryParse(Console.ReadLine(), out x);
                h2 = double.TryParse(Console.ReadLine(), out y);
                if (h1 == false || h2 == false)
                {
                    break;
                }
                if (x >= 0 && y >= 0 && x <= Math.PI && y <= Math.Sin(x))
                {
                    answer += 1;
                }
            }
            Console.WriteLine(answer);
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
            // code here
            double answer = double.MaxValue;
            double result;
            bool h;
            while (true)
            {
                h = double.TryParse(Console.ReadLine(), out result);
                if (h == false)
                {
                    break;
                }
                if (result < answer)
                {
                    answer = result;
                }

            }
            Console.WriteLine(answer);
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
