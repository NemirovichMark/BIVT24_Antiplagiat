using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 3, 2, 1);
        //program.Task_2_2(5, 1, 3, 1);
        program.Task_2_3(6);
        //program.Task_2_4(3, 1, 2);
        //program.Task_2_5(6,25.2);
        //program.Task_2_6(3);
        //program.Task_2_7(3);
        //program.Task_2_8(4);
        //program.Task_2_9(6);
        //program.Task_2_10(6);
        //program.Task_2_11(6);
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
        double r = 2;
        if ((x * x + y * y - r * r <= 1 / 1000) && (x * x + y * y - r * r >= 1 / 1000))
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
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && Math.Abs(x) + y <= 1)
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
        if (a > b)
        {
            answer = b;
        }
        else
        {
            answer = a;
        }
        if (answer < c)
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
        double a = Math.Sqrt(r / Math.PI) * 2;
        double b = Math.Sqrt(s) * Math.Sqrt(2);
        if (b > a)
        {
            answer = false;
        }
        else
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
        double a = Math.Sqrt(r / Math.PI) * 2;
        if (a > Math.Sqrt(s))
        {
            answer = false;
        }
        else
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
        if (Math.Abs(x) > 1) answer = 1;
        else answer = Math.Abs(x);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if ((x > -1) && (x < 1))
        {
            answer = (x * x) - 1;
        }
        else
        {
            answer = 0;
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
            answer = x + 1;
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
        else if ((x > -1) && (x <= 1))
        {
            answer = x * (-1);
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
        for (int i = 0; i < n; i++)
        {
            answer = answer + double.Parse(Console.ReadLine());
        }
        answer = answer / n;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ((x - a) * (x - a) + (y - b) * (y - b) > r * r)
            {
                answer += 0;
            }
            else
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

        double s = 0;
        // code here
        for (int i = 0; i < n; i++)
        {
            if (double.Parse(Console.ReadLine()) < 30)
            {
                s++;
            }
        }
        answer = s / 5;
        Console.WriteLine(answer);

        // end

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
            if ((x * x + y * y >= r1 * r1) && (x * x + y * y <= r2 * r2))
            {
                answer++;
            }
            Console.WriteLine(answer);
            // end
        }
        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                if (double.Parse(Console.ReadLine()) <= norm)
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
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if (y >= 0 && y <= Math.Sin(x) && x >= 0 && x <= Math.PI) answer++;
        }

        Console.WriteLine(answer);
        
            // end

            return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
            double x, y;

            // code here
            for (int i = 0; i < n; i++)
            {
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());
                if ((y > 0) && (x > 0))
                {
                    answer1++;
                }
                else if ((y < 0) && (x < 0))
                {
                    answer3++;
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
        double x, y;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            answerLength = x * x + y * y;
            answer = 1;
            for (int i = 2; i < n + 1; i++)
            {
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());
                if (answerLength > x * x + y * y)
                {
                    answerLength = x * x + y * y;
                    answer = i;
                }
                answerLength = Math.Round((Math.Sqrt(answerLength)), 2);
            }
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
            // end

            return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double t = 0;
            
            for (int i = 0; i < n; i++)
            {
                t = double.Parse(Console.ReadLine());
                if (answer > t)
                {
                    answer = t;
                }
            }
            answer = Math.Round(answer, 1);
        Console.WriteLine(answer);
            // end

            return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 0; i < n; i++)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());
            double n4 = double.Parse(Console.ReadLine());

            if (n1 >= 4 && n2 >= 4 && n3 >= 4 && n4 >= 4)
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
        double s = 0;
        // code here
        for (int i = 0; i < n; i++)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());
            double n4 = double.Parse(Console.ReadLine());
            if (n1 == 2 || n2 == 2 || n3 == 2 || n4 == 2)
            {
                s = s + (n1 + n2 + n3 + n4) / 4;
                answer++;
            }
            else
            {
                s += (n1 + n2 + n3 + n4) / 4;
            }
        }
        avg = s / n;
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);  
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        
        if ((type < 0) || (type > 2) || (r <= 0))
        {
            return 0;
        }
        
        else
        {
            switch (type)
            {
                case 0:
                    answer = r * r;break;
                case 1:
                    answer = r * r * Math.PI; break;
                case 2:
                    answer = r * r * Math.Sqrt(3) / 4; break;

            }
            Console.WriteLine((r, type, answer));
            answer = Math.Round(answer, 2);
        }
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if((A<=0) || (B<=0) || (type<0 || type > 2))
        {
            return 0;
        }
        else
        {
            switch (type)
            {
                case 0:
                    answer = A * B; break;
                case 1:
                    answer = Math.Abs((A * A - B * B) * Math.PI); break;
                case 2:
                    answer = (Math.Sqrt(B * B - ((A * A) / 4))) * (A / 2); break;
            }
            answer = Math.Round(answer,2);
        }
        return answer;
        
        
        








      
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;

        // code here
       
        // end

        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int  answer=0;

        // code here
        double x, y;
        string inputX, inputY;

        try
        {
            while ((inputX = Console.ReadLine()) != "" && (inputY = Console.ReadLine()) != "")
            {
                x = double.Parse(inputX);
                y = double.Parse(inputY);

                if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
                {
                    answer++;
                }
            }
            
        }
        catch (FormatException exc) { Console.WriteLine(exc.Message); }
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

        // code here
        double result;
        string input;

        try
        {
            while ((input = Console.ReadLine()) != "")
            {
                result = double.Parse(input);
                if (result <= norm) answer++;
            }
            Console.WriteLine(answer);

           
        }
        catch (FormatException exp) { Console.WriteLine(exp.Message); }
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
        int answer = 0, n = 1;
        double answerLength = double.MaxValue,x,y;
        string inputX, inputY;
        // code here
        try
        {
            while ((inputX = Console.ReadLine()) != "" && (inputY = Console.ReadLine()) != "")
            {
                x = double.Parse(inputX);
                y = double.Parse(inputY);

                if (Math.Sqrt(x * x + y * y) < answerLength)
                {
                    answer = n;
                    answerLength = Math.Sqrt(x * x + y * y);
                }

                n++;
            }
            answerLength = Math.Round(answerLength, 2);
            Console.WriteLine(answer + " " + answerLength);
        }
        catch (FormatException exc) { Console.WriteLine(exc.Message); }
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
        int answer = 0, save = int.MaxValue, n = 0;
        string input;
        double avg = 0.0;
        bool f = true;

        // code here;
        try
        {
            while (f)
            {
                for (int k = 1, score; k <= 4; k++)
                {
                    if ((input = Console.ReadLine()) != "")
                    {
                        score = int.Parse(input);
                        avg += score;
                        n++;
                        if (save > score) save = score;
                    }
                    else { f = false; break; }
                }
                if (f)
                {
                    if (save < 3) answer++;
                    save = int.MaxValue;
                }
            }
            avg /= n;
            avg = Math.Round(avg, 2);
            Console.WriteLine(answer + " " + avg);
        }
        catch (FormatException exp)
        {
            Console.WriteLine(exp.Message);
        }

        // end

        return (answer, avg);
    }
    #endregion
}