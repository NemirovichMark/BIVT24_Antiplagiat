using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Sources;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        int n = 20, score = 0, mark = 0;

        if (n-- > 0)
        {
            int.TryParse(Console.ReadLine(), out score);

            switch (score)
            {
                case >= 450: { Console.WriteLine("Отлично"); break; }
                case >= 350:
                    {
                        Console.WriteLine("Хорошо"); break;
                    }
                case >= 250: { Console.WriteLine("Удовлетворительно"); break; }
                case < 250: { Console.WriteLine("Неудовлетворительно"); break; }
            }
        }



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
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(6);
        //program.Task_2_4(3, 1, 2);
        //program.Task_2_5(8, 30);
        //program.Task_2_6(3);
        //program.Task_2_7(5);
        //program.Task_2_8(3);
        //program.Task_2_9(6);
        //program.Task_2_10(6);
        //program.Task_2_11(6);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 2);
        //program.Task_3_5(25.2);
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
        int r = 2;

        if (Math.Abs(x * x + y * y - r * r) <= 0.001) 
        answer = true;

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        if(Math.Abs(x) <= 1 && y >= 0 && y <= Math.Abs(x) + 1)
        answer = true;

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        if (a > 0) answer = Math.Max(a, b);
        else answer = Math.Min(a, b);

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        answer = Math.Max(Math.Min(a, b), c);

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        double square, circle;

        square = Math.Sqrt(s);
        circle = Math.Sqrt(r / Math.PI);

        if(square * square <= 2 * circle * circle) answer = true;
        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        double square, circle;

        square = Math.Sqrt(s);
        circle = Math.Sqrt(r / Math.PI);

        if(square >= 2 * circle) answer = true;

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        if (Math.Abs(x) > 1) answer = 1;
        else answer = Math.Abs(x);

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        if (Math.Abs(x) < 1) answer = x * x - 1;

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        if (x > -1 && x <= 0) answer = 1 + x;
        else if (x > 0) answer = 1;

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        if (x <= -1) answer = 1;
        else if (x > -1 && x <= 1) answer = -x;
        else answer = -1;

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0, student;

        if(n > 0)
            {try
                    {
                    for (int i = 1; i <= n; i++)
                        {
                        student = double.Parse(Console.ReadLine());
                        answer += student;
                        }
                    answer /= n;
                    Console.WriteLine(Math.Round(answer, 2));
                    }
             catch (FormatException exc) 
                    { 
                    Console.WriteLine(exc.Message); 
                    }
            }
        else Console.WriteLine("Некорректный ввод данных");
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x, y;
        bool successX, successY;
            
        for(int i = 1; i <= n; i++)
        {
            successX = double.TryParse (Console.ReadLine(), out x);
            successY = double.TryParse(Console.ReadLine(), out y);

            if (successX == false || successY == false) 
                {
                Console.WriteLine("Некорректный ввод данных");
                break; 
                }

            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r) answer++;

            if (i == n) Console.WriteLine(answer);
        }

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0, weight;
        bool success;

        for (int i = 1; i <= n; i++)
        {
            success = double.TryParse(Console.ReadLine(), out weight);

            if (success)
                {
                if (weight < 30) answer += 0.2;
                }
            else 
                {
                Console.WriteLine("Ошибка чтения данных");
                break; }

            if(i == n) Console.WriteLine("{0:f1}", answer);
        }

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        double x, y;
        bool successX, successY;
        for (int i = 1; i <= n; i++)
        {
             successX = double.TryParse(Console.ReadLine(),out x);
             successY = double.TryParse(Console.ReadLine(), out y);

             if(successX && successY)
                {
                if (x * x + y * y >= r1 * r1 && x * x + y * y <= r2 * r2) answer++;
                }
             else 
                { 
                Console.WriteLine("Ошибка чтения данных");
                break;
                }

             if (i == n) Console.WriteLine(answer);
        }

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        double result;
        bool success;

        for (int i = 1; i <= n; i++)
        {
            success = double.TryParse(Console.ReadLine(), out result);

            if(success)
                {
                if(result <= norm) answer++;
                }
            else
                {
                Console.WriteLine("Ошибка чтения данных");
                break;
            }

            if (i == n) Console.WriteLine(answer);
        }

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        double x, y;
        bool successX, successY;

        for (int i = 1; i <= n; i++)
        {
            successX = double.TryParse(Console.ReadLine(), out x);
            successY = double.TryParse(Console.ReadLine(), out y);

            if (successX && successY)
            {
                if (x >= 0 && x <= Math.PI && y <= Math.Sin(x) && y >= 0) answer++;
            }
            else
            {
                Console.WriteLine("Ошибка чтения данных");
                break;
            }

            if (i == n) Console.WriteLine(answer);
        }

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
        double x, y;
        bool successX, successY;

        for(int i = 1; i <= n; i++)
            {
            successX = double.TryParse((Console.ReadLine()), out x);
            successY = double.TryParse((Console.ReadLine()), out y);

            if(successX && successY)
                {
                if (x > 0 && y > 0) answer1++;
                if (x < 0 && y < 0) answer3++;
                }
            else 
                {
                Console.WriteLine("Ошибка ввода данных");
                break;
                }

            if (i == n) Console.WriteLine(answer1 + " " + answer3);
        }

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue, x ,y;
        bool successX, successY;

        for (int i = 1; i <= n; i++)
        {
            successX = double.TryParse((Console.ReadLine()), out x);
            successY = double.TryParse((Console.ReadLine()), out y);

            if (successX && successY)
            {
                if(Math.Sqrt(x * x + y * y) < answerLength)
                {
                    answer = i;
                    answerLength = Math.Sqrt(x * x + y * y);
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода данных");
                break;
            }

            if (i == n) {
                answerLength = Math.Round(answerLength, 2);
                Console.WriteLine(answer + " " + answerLength); }
        }

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue, result;
        try
        {
            for (int i = 1; i <= n; i++)
            {
                result = double.Parse(Console.ReadLine());
                if (result < answer) answer = result;
            }
            Console.WriteLine("{0:f1}", answer);
        }
        catch (FormatException exp)
            {
            Console.WriteLine(exp.Message); 
            }

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0, save = int.MaxValue;

        try
        {
            for (int i = 1; i <= n; ++i, save = int.MaxValue)
            {
                for(int k = 1, score; k <=4 ; k++)
                {
                    score = int.Parse(Console.ReadLine());
                    if(save > score) save = score;
                }

                if (save >= 4) answer++;
            }
            Console.WriteLine(answer);
        }
        catch (FormatException exp)
        {
            Console.WriteLine(exp.Message);
        }

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0, save = int.MaxValue;

        try
        {
            for (int i = 1; i <= n; ++i, save = int.MaxValue)
            {
                for (int k = 1, score; k <= 4; k++)
                {
                    score = int.Parse(Console.ReadLine());
                    avg += score;
                    if(save > score) save = score;
                }
                if (save < 3) answer++;

            }
            avg /= 4 * n;
            avg = Math.Round(avg, 2);
            Console.WriteLine(answer + " " + avg);
        }
        catch (FormatException exp)
        {
            Console.WriteLine(exp.Message);
        }

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        if(r > 0)
            {switch (type)
                {
                    case > 2:
                    case < 1: { answer = Math.PI * r * r; break; }
                    case 2: { answer = Math.Sqrt(3) * r * r / 4; break; }
                    default: break;     
            }
                answer = Math.Round(answer, 2);
            }

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0, h;

        if (A > 0 && B > 0)
            {
            switch(type)
                {
                case 0: { answer = A * B; break; }
                case 1: { answer = Math.PI * Math.Abs(A * A - B * B);
                          break; }
                case 2: { if(B + B > A)
                            {h = Math.Sqrt(B * B - A * A / 4);
                             answer = 0.5 * h * A;
                            }
                          break; }
                default: break;
                }
            answer = Math.Round(answer, 2);
            }

        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0, student;
        
        // code here

        // end

        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;
        double x, y;
        string inputX, inputY;

        try
            {while ((inputX = Console.ReadLine()) != "" && (inputY = Console.ReadLine()) != "") 
                {
                    x = double.Parse(inputX);
                    y = double.Parse(inputY);

                    if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r) answer++;
                }
            Console.WriteLine(answer);
            }
        catch(FormatException exc) { Console.WriteLine(exc.Message); }
        

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;

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
        int answer = 0, number = 1;
        double answerLength = double.MaxValue, x, y;
        string inputX, inputY;

        try
        {
            while ((inputX = Console.ReadLine()) != "" && (inputY = Console.ReadLine()) != "")
            {
                x = double.Parse(inputX);
                y = double.Parse(inputY);

                if (Math.Sqrt(x * x + y * y) < answerLength)
                {
                    answer = number;
                    answerLength = Math.Sqrt(x * x + y * y);
                }

                number++;
            }
            answerLength = Math.Round(answerLength, 2);
            Console.WriteLine(answer + " " + answerLength);
        }
        catch (FormatException exc) { Console.WriteLine(exc.Message); }
       
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
        double avg = 0.0, save = int.MaxValue;
        string input;
        bool pointer = true;

        try
        {
            while (pointer)
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
                    else { pointer = false;  break;}
                }
                if(pointer)
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

        return (answer, avg);
    }
    #endregion
}