using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
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
        program.Task_2_1(10);
        Console.WriteLine("expected answer  163,4 \n");

        program.Task_2_2(5, 3, 2, 1);
        Console.WriteLine("expected answer  3 \n");
        program.Task_2_2(5, 1.5, 1.5, 1);
        Console.WriteLine("expected answer  2 \n");
        program.Task_2_2(5, 1, 3, 1);
        Console.WriteLine("expected answer  0 \n");

        program.Task_2_3(10);
        Console.WriteLine("expected answer  1,2 \n");
        program.Task_2_3(8);
        Console.WriteLine("expected answer  0,8 \n");
        program.Task_2_3(6);
        Console.WriteLine("expected answer  0,6 \n");

        program.Task_2_4(5, 1, 2);
        Console.WriteLine("expected answer  2 \n");
        program.Task_2_4(5, 1, 3);
        Console.WriteLine("expected answer  3 \n");
        program.Task_2_4(4, 1, 2);
        Console.WriteLine("expected answer  2 \n");
        program.Task_2_4(4, 1, 3);
        Console.WriteLine("expected answer  3 \n");
        program.Task_2_4(3, 1, 2);
        Console.WriteLine("expected answer  1 \n");
        program.Task_2_4(3, 1, 3);
        Console.WriteLine("expected answer  2 \n");

        program.Task_2_5(10, 30);
        Console.WriteLine("expected answer  8 \n");
        program.Task_2_5(10, 25.5);
        Console.WriteLine("expected answer  2 \n");
        program.Task_2_5(8, 30);
        Console.WriteLine("expected answer  6 \n");
        program.Task_2_5(8, 25.5);
        Console.WriteLine("expected answer  1 \n");
        program.Task_2_5(6, 30);
        Console.WriteLine("expected answer  4 \n");
        program.Task_2_5(6, 25.5);
        Console.WriteLine("expected answer  1 \n");

        program.Task_2_6(5);
        Console.WriteLine("expected answer  3 \n");
        program.Task_2_6(4);
        Console.WriteLine("expected answer  2 \n");
        program.Task_2_6(3);
        Console.WriteLine("expected answer  2 \n");

        program.Task_2_7(5);
        Console.WriteLine("expected answer  2 ; 1 \n");
        program.Task_2_7(4);
        Console.WriteLine("expected answer  2 ; 0 \n");
        program.Task_2_7(3);
        Console.WriteLine("expected answer  1 ; 0 \n");

        program.Task_2_8(5);
        Console.WriteLine("expected answer  5 ; 0,71 \n");
        program.Task_2_8(4);
        Console.WriteLine("expected answer  3 ; 1,03 \n");
        program.Task_2_8(3);
        Console.WriteLine("expected answer  3 ; 1,03 \n");

        program.Task_2_9(10);
        Console.WriteLine("expected answer  20,1 \n");
        program.Task_2_9(8);
        Console.WriteLine("expected answer  22,3 \n");
        program.Task_2_9(6);
        Console.WriteLine("expected answer  22,3 \n");

        program.Task_2_10(10);
        Console.WriteLine("expected answer  5 \n");
        program.Task_2_10(8);
        Console.WriteLine("expected answer  4 \n");
        program.Task_2_10(6);
        Console.WriteLine("expected answer  3 \n");

        program.Task_2_11(10);
        Console.WriteLine("expected answer  4 ; 4,05 \n");
        program.Task_2_11(8);
        Console.WriteLine("expected answer  3 ; 4,1875 \n");
        program.Task_2_11(6);
        Console.WriteLine("expected answer  2 ; 4,291666667 \n");

        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        program.Task_3_4(1, 2);
        //program.Task_3_5(30);
        //program.Task_3_6();
        program.Task_3_7();
        //program.Task_3_8();
        //program.Task_3_9();
        program.Task_3_10();
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
        if (Math.Abs(x * x + y * y - r * r) <= 0.001)
        {
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if(y >= 0 && y + Math.Abs(x) <= 1)
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
        answer = a;
        bool aIsPositive = a > 0;
        bool bIsMaximum = a < b;
        if (aIsPositive == bIsMaximum)
            answer = b;
        /*
        if(a > 0 && a < b)
            answer = b;
        else if(a<=0 && a > b)
            answer = b;
        */
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        answer = a;
        if (c > a)
            answer = c;
        else if (a > b)
            answer = b;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if(Math.PI <= 2*r/s)
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (4 * r / s <= Math.PI)
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
        else
            answer = Math.Abs(x);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if(Math.Abs(x) < 1)
            answer = x*x - 1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) { }
        else if (x <= 0)
            answer = 1 + x;
        else
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
        else if (x <= 1)
            answer = -x;
        else
            answer = -1;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double sumHeight = 0;
        Console.WriteLine($"Task_2_1    enter {n} nubers (one by one)");
        for(int k = 0; k < n; k++)
        {
            double height;
            while(! double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out height))
            {
                Console.WriteLine("invalid input    try again");
            }
            sumHeight += height;
        }
        answer = sumHeight/n;
        Console.WriteLine($"Task_2_1    answer = {answer}");
        Console.WriteLine();
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        Console.WriteLine("Task_2_2");
        for (int k = 1; k <= n; k++)
        {
            Console.WriteLine($"input abscissa of {k} point");
            double x;
            while (!double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out x))
            {
                Console.WriteLine("invalid input    try again");
            }
            Console.WriteLine($"input ordinate of {k} point");
            double y;
            while (!double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out y))
            {
                Console.WriteLine("invalid input    try again");
            }

            if ((a - x) * (a - x) + (b - y) * (b - y) <= r * r)
            {
                answer++;
                Console.WriteLine($"{k} point is in circle");
            }
            else
                Console.WriteLine($"{k} point is not in circle");
            Console.WriteLine();
        }
        Console.WriteLine($"Task_2_2    answer = {answer}");
        Console.WriteLine();
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        Console.WriteLine($"Task_2_3    enter {n} nubers (one by one)");
        for(int k = 0; k < n; k++)
        {
            double weight;
            while (!double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out weight))
            {
                Console.WriteLine("invalid input    try again");
            }
            if(weight < 30)
                answer += 0.2;
        }
        Console.WriteLine($"Task_2_1    answer = {answer}");
        Console.WriteLine();
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        Console.WriteLine("Task_2_4");
        for (int k = 1; k <= n; k++)
        {
            Console.WriteLine($"input abscissa of {k} point");
            double x;
            while (!double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out x))
            {
                Console.WriteLine("invalid input    try again");
            }
            Console.WriteLine($"input ordinate of {k} point");
            double y;
            while (!double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out y))
            {
                Console.WriteLine("invalid input    try again");
            }

            if (x*x + y*y <= r2 * r2 && x * x + y * y >= r1 * r1)
            {
                answer++;
                Console.WriteLine($"{k} point is in ring");
            }
            else
                Console.WriteLine($"{k} point is not in ring");
            Console.WriteLine();
        }
        Console.WriteLine($"Task_2_4    answer = {answer}");
        Console.WriteLine();

        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        Console.WriteLine($"Task_2_5    enter {n} nubers (one by one)");
        for (int k = 0; k < n; k++)
        {
            double result;
            while (!double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out result))
            {
                Console.WriteLine("invalid input    try again");
            }
            if (result <= norm) 
                answer++;
        }
        Console.WriteLine($"Task_2_5    answer = {answer}");
        Console.WriteLine();

        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        Console.WriteLine("Task_2_6");
        for (int k = 1; k <= n; k++)
        {
            Console.WriteLine($"input abscissa of {k} point");
            double x;
            while (!double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out x))
            {
                Console.WriteLine("invalid input    try again");
            }
            Console.WriteLine($"input ordinate of {k} point");
            double y;
            while (!double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out y))
            {
                Console.WriteLine("invalid input    try again");
            }

            if (y >= 0 && x >=0 && x <= Math.PI && y <= Math.Sin(x)) //!!!
            {
                answer++;
                Console.WriteLine($"{k} point is in ring");
            }
            else
                Console.WriteLine($"{k} point is not in ring");
            Console.WriteLine();
        }
        Console.WriteLine($"Task_2_6    answer = {answer}");
        Console.WriteLine();

        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        Console.WriteLine("Task_2_7");
        for (int k = 1; k <= n; k++)
        {
            Console.WriteLine($"input abscissa of {k} point");
            double x;
            while (!double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out x))
            {
                Console.WriteLine("invalid input    try again");
            }
            Console.WriteLine($"input ordinate of {k} point");
            double y;
            while (!double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out y))
            {
                Console.WriteLine("invalid input    try again");
            }

            if(x == 0)
            {
                Console.WriteLine($"{k} point is in y axis");
            }
            if(y == 0)
            {
                Console.WriteLine($"{k} point is in x axis");
            }
            else if ( x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine($"{k} point is in 1 quad");
                    answer1++;
                }
                else if (y < 0)
                    Console.WriteLine($"{k} piont is in 4 quad");
            }
            else if(x < 0)
            {
                if (y > 0)
                    Console.WriteLine($"{k} point is in 2 quad");
                else if (y < 0)
                {
                    Console.WriteLine($"{k} point is in 3 quad");
                    answer3++; ;
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Task_2_7    answer1 = {answer1}, answer3 = {answer3}");
        Console.WriteLine();

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        Console.WriteLine("Task_2_8");
        for (int k = 1; k <= n; k++)
        {
            Console.WriteLine($"input abscissa of {k} point");
            double x;
            while (!double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out x))
            {
                Console.WriteLine("invalid input    try again");
            }
            Console.WriteLine($"input ordinate of {k} point");
            double y;
            while (!double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out y))
            {
                Console.WriteLine("invalid input    try again");
            }
            double currentLength = Math.Sqrt(x * x + y * y);
            if(answerLength > currentLength)
            {
                answer = k;
                answerLength = currentLength;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine($"Task_2_8    answer = {answer}, answerLength = {answerLength}");
        Console.WriteLine();
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        Console.WriteLine($"Task_2_9    enter {n} nubers (one by one)");
        for (int k = 0; k < n; k++)
        {
            double time;
            while (!double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out time))
            {
                Console.WriteLine("invalid input    try again");
            }

            if(time < answer)            
                answer = time;
        }
        Console.WriteLine($"Task_2_9    answer = {answer}");
        Console.WriteLine();
        // end

        return answer;
    }
    public int Task_2_10(int n) //!!!
    {
        int answer = 0;

        // code here;
        Console.WriteLine("Task_2_10");
        for (int k = 1; k <= n; k++)
        {
            Console.WriteLine($"input 4 marks of {k} student");
            double mark1, mark2, mark3, mark4;
            while (!double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out mark1))
            {
                Console.WriteLine("invalid input    try again");
            }
            while (!double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out mark2))
            {
                Console.WriteLine("invalid input    try again");
            }
            while (!double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out mark3))
            {
                Console.WriteLine("invalid input    try again");
            }
            while (!double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out mark4))
            {
                Console.WriteLine("invalid input    try again");
            }
            if(mark1 !=2 && mark1 != 3 && mark2 != 2 && mark2 != 3 
                && mark3 != 2 && mark3 != 3 && mark4 != 2 && mark4 != 3) 
            {
                answer++;
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Task_2_10    answer = {answer}");
        Console.WriteLine();
        // end
        /*
        // for test input in console:
        5, 3, 3, 4,
        5, 2, 4, 5,
        5, 4, 5, 4,
        2, 5, 3, 5,
        4, 5, 5, 5,
        5, 5, 5, 5,
        4, 4, 4, 4,
        4, 4, 2, 5,
        2, 2, 4, 2,
        5, 4, 5, 4
        */
        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        Console.WriteLine("Task_2_11");
        for (int k = 1; k <= n; k++) //средний бал группы
        {
            Console.WriteLine($"input 4 marks of {k} student");
            double mark1, mark2, mark3, mark4;
            while (!double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out mark1)) 
            {
                Console.WriteLine("invalid input    try again");
            }
            while (!double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out mark2)) 
            {
                Console.WriteLine("invalid input    try again");
            }
            while (!double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out mark3)) 
            {
                Console.WriteLine("invalid input    try again");
            }
            while (!double.TryParse(Console.ReadLine(), new CultureInfo("en-US"), out mark4)) 
            {
                Console.WriteLine("invalid input    try again");
            }
            avg += mark1 + mark2 + mark3 + mark4; 
            if (mark1 == 2 || mark2 == 2 || mark3 == 2 || mark4 == 2 )
            {
                answer++;
            }
            Console.WriteLine();
        }
        avg /= 4 * n;
        Console.WriteLine($"Task_2_11    answer = {answer}, avg = {avg}");
        Console.WriteLine();
        // end
        /*
        // for test input in console:
        5, 3, 3, 4,
        5, 2, 4, 5,
        5, 4, 5, 4,
        2, 5, 3, 5,
        4, 5, 5, 5,
        5, 5, 5, 5,
        4, 4, 4, 4,
        4, 4, 2, 5,
        2, 2, 4, 2,
        5, 4, 5, 4
        */
        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        // code here;
        Console.WriteLine("Task_2_12");
        if(r < 0)
        {
            Console.WriteLine("invalid radius");
            return answer;
        }
        switch (type)
        {
            case 0:
                answer = r * r;
                answer = Math.Round(answer, 2);
                break;
            case 1:
                answer = Math.PI * r * r;
                answer = Math.Round(answer, 2);
                break;
            case 2:
                answer = Math.Sqrt(3) * r * r / 4;
                answer = Math.Round(answer, 2);
                break;
            default:
                Console.WriteLine("undefined comand");
                break;
        }
        Console.WriteLine($"radius = {r}, command = {type} \nanswer = {answer}\n");
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        // code here;
        Console.WriteLine("Task_2_13");
        if (A <= 0 || B <= 0)
        {
            Console.WriteLine("A, B cannot be negative");
            return answer;
        }
        switch (type)
        {
            case 0:
                answer = A * B;
                answer = Math.Round(answer, 2);
                break;
            case 1:
                answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                answer = Math.Round(answer, 2);
                break;
            case 2:
                if (2 * B <= A)
                {
                    Console.WriteLine("impossible triangle");
                    return answer;
                }
                double h = Math.Sqrt(B * B - (A / 2) * (A / 2));
                answer = A * h / 2;
                answer = Math.Round(answer, 2);
                /*
                double p = (A + B + B) / 2;
                answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B));
                answer = Math.Round(answer, 2);
                */
                break;
            default:
                Console.WriteLine("undefined comand");
                break;
        }
        Console.WriteLine($"A = {A}, B = {B} command = {type} \nanswer = {answer}\n");
        // end

        return answer;
    }
    #endregion
    // 1 4 7 10
    #region Level 3 
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;

        // code here
        double sumHeight = 0;
        Console.WriteLine($"Task_3_1 enter 'stop' to finish input ");
        string currentLine = Console.ReadLine();
        while (currentLine != "stop")
        {
            double height;
            while (!double.TryParse(currentLine, new CultureInfo("en-US"), out height))
            {
                if (currentLine == "stop")
                    break;
                Console.WriteLine("invalid input    try again");
                currentLine = Console.ReadLine();
            }
            if (currentLine == "stop")
                break;
            sumHeight += height;
            n++;
            currentLine = Console.ReadLine();
        }
        answer = sumHeight / n;
        Console.WriteLine($"Task_3_1    answer = {answer}");
        Console.WriteLine();

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
        n = 1;
        Console.WriteLine($"Task_3_4 \nenter 'stop' to finish input;\n enter to continue ");
        string currentLine;
        do
        {
            Console.WriteLine($"input abscissa of {n} point");
            currentLine = Console.ReadLine();
            double x;
            while (!double.TryParse(currentLine, new CultureInfo("en-US"), out x))
            {
                Console.WriteLine("invalid input    try again");
                currentLine = Console.ReadLine();
            }
            
            Console.WriteLine($"input ordinate of {n} point");
            currentLine = Console.ReadLine();
            double y;
            while (!double.TryParse(currentLine, new CultureInfo("en-US"), out y))
            {
                Console.WriteLine("invalid input    try again");
                currentLine = Console.ReadLine();
            }

            if (x * x + y * y <= r2 * r2 && x * x + y * y >= r1 * r1)
            {
                answer++;
                Console.WriteLine($"{n} point is in ring");
            }
            else
                Console.WriteLine($"{n} point is not in ring");
            Console.WriteLine();
            n++;
            currentLine = Console.ReadLine();
        }
        while (currentLine != "stop");


        Console.WriteLine($"Task_3_4    answer = {answer}");
        Console.WriteLine();

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
        n = 1;
        Console.WriteLine("Task_3_7\n enter 'stop' to finish input;\n enter to continue");
        string currentLine;
        do
        {
            Console.WriteLine($"input abscissa of {n} point");
            currentLine = Console.ReadLine();
            double x;
            while (!double.TryParse(currentLine, new CultureInfo("en-US"), out x))
            {
                Console.WriteLine("invalid input    try again");
                currentLine = Console.ReadLine();
            }

            Console.WriteLine($"input ordinate of {n} point");
            currentLine = Console.ReadLine();
            double y;
            while (!double.TryParse(currentLine, new CultureInfo("en-US"), out y))
            {
                Console.WriteLine("invalid input    try again");
                currentLine = Console.ReadLine();
            }

            if (x == 0)
            {
                Console.WriteLine($"{n} point is in y axis");
            }
            if (y == 0)
            {
                Console.WriteLine($"{n} point is in x axis");
            }
            else if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine($"{n} point is in 1 quad");
                    answer1++;
                }
                else if (y < 0)
                    Console.WriteLine($"{n} piont is in 4 quad");
            }
            else if (x < 0)
            {
                if (y > 0)
                    Console.WriteLine($"{n} point is in 2 quad");
                else if (y < 0)
                {
                    Console.WriteLine($"{n} point is in 3 quad");
                    answer3++;
                }
            }
            n++;
            Console.WriteLine();
            currentLine = Console.ReadLine();
        }
        while (currentLine != "stop");
        Console.WriteLine($"Task_3_7    answer1 = {answer1}, answer3 = {answer3}");
        Console.WriteLine();

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
        n = 1;
        Console.WriteLine("Task_3_10");
        Console.WriteLine("enter 'stop' to finish input;\n enter to continue");
        string currentLine;
        do
        {
            Console.WriteLine($"input 4 marks of {n} student");
            double mark1, mark2, mark3, mark4;
            currentLine = Console.ReadLine();
            while (!double.TryParse(currentLine, new CultureInfo("en-US"), out mark1)) 
            {
                Console.WriteLine("invalid input    try again");
                currentLine = Console.ReadLine();
            }
            currentLine = Console.ReadLine();
            while (!double.TryParse(currentLine, new CultureInfo("en-US"), out mark2)) 
            {
                Console.WriteLine("invalid input    try again");
                currentLine = Console.ReadLine();
            }
            currentLine = Console.ReadLine();
            while (!double.TryParse(currentLine, new CultureInfo("en-US"), out mark3)) 
            {
                Console.WriteLine("invalid input    try again");
                currentLine = Console.ReadLine();
            }
            currentLine = Console.ReadLine();
            while (!double.TryParse(currentLine, new CultureInfo("en-US"), out mark4)) 
            {
                Console.WriteLine("invalid input    try again");
                currentLine = Console.ReadLine();
            }

            if (mark1 != 2 && mark1 != 3 && mark2 != 2 && mark2 != 3
                && mark3 != 2 && mark3 != 3 && mark4 != 2 && mark4 != 3)
            {
                answer++;
            }
            n++;
            Console.WriteLine();
            currentLine = Console.ReadLine();
        }
        while (currentLine != "stop");
        Console.WriteLine($"Task_3_10    answer = {answer}");
        Console.WriteLine();
        // end

         // for test input in console:
        // 5, 3, 3, 4,
        // 5, 2, 4, 5,
        // 5, 4, 5, 4,
        // 2, 5, 3, 5,
        // 4, 5, 5, 5,
        // 5, 5, 5, 5,
        // 4, 4, 4, 4,
        // 4, 4, 2, 5,
        // 2, 2, 4, 2,
        // 5, 4, 5, 4
        // answer should be equal to the task_2_10 answer

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