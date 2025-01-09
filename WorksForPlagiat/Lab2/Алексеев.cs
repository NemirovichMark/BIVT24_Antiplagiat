using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Reflection;
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
        program.Task_3_8();
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

        if (Math.Abs((x * x) + (y * y) - (r * r)) <= 0.001)
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
        if (y >= 0 && y + Math.Abs(x) <= 1)
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
        double c;
        c = a;
        if (a > 0)
        {
            if (b > c)
            {
                c = b;
                answer = c;
            }
            else
            {
                answer = c;
            }
        }
        else if (a <= 0)
        {
            if (b > c)
            {
                answer = c;
            }
            else
            {
                c = b;
                answer = c;
            }
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        double z, min;
        // code here

        if (a > b)
        {
            min = b;
        }
        else
        {
            min = a;
        }
        if (min > c)
        {
            z = min;
        }
        else
        {
            z = c;
        }
        answer = z;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double radius = Math.Sqrt(r / Math.PI);
        double diametr = 2 * radius;
        double diagonal = Math.Sqrt(2) * Math.Sqrt(s);
        if (diametr >= diagonal)
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
        double radius = Math.Sqrt(r / Math.PI);
        double diametr = 2 * radius;
        double side = Math.Sqrt(s);
        if (diametr <= side)
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
    public double Task_1_7(double x)
    {
        double answer = 0;
        double y;
        // code here

        if (Math.Abs(x) > 1)
        {
            y = 1;
            answer = y;
        }
        else if (Math.Abs(x) <= 1)
        {
            y = Math.Abs(x);
            answer = y;
        }



        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;
        double y;
        // code here


        if (Math.Abs(x) >= 1)
        {
            y = 0;
            answer = y;
        }
        else if (Math.Abs(x) < 1)
        {
            y = x * x - 1;
            answer = y;
        }

        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;
        double y;
        // code here
        if (x <= -1)
        {
            y = 0;
            answer = y;
        }
        else if (-1 < x && x <= 0)
        {
            y = 1 + x;
            answer = y;
        }
        else if (x > 0)
        {
            y = 1;
            answer = y;
        }
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;
        double y;
        // code here
        if (x <= -1)
        {
            y = 1;
            answer = y;
        }
        else if (-1 < x && x <= 1)
        {
            y = -x;
            answer = y;
        }
        else if (x > 1)
        {
            y = -1;
            answer = y;
        }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        double average = 0, height = 0, sum = 0;
        // code here
        for (int i = 0; i < n; i++)
        {

            height = double.Parse(Console.ReadLine());
            sum += height;
        }
        average = sum / n;
        answer = average;
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0, Counter = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double dist = Math.Sqrt(Math.Pow(x - a, 2) + Math.Pow(y - b, 2));
            if (dist <= r * r)
            {
                Counter++;
            }
        }
        // end
        Console.WriteLine(Counter);
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        double Counter = 0;
        // code here
        for (int i = 0; i < n; i++)
        {
            double weight = double.Parse(Console.ReadLine());
            if (weight < 30)
            {
                Counter += 0.2;
            }
        }
        // end
        Console.WriteLine(Counter);
        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        int Counter = 0;
        // code here
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double dist = Math.Sqrt(x * x + y * y);
            if (dist >= r1 && dist <= r2)
            {
                Counter++;
            }
        }
        // end
        Console.WriteLine(Counter);
        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        int Counter = 0;
        // code here
        for (int i = 0; i < n; i++)
        {
            double result = double.Parse(Console.ReadLine());
            if (result <= norm)
            {
                Counter++;
            }
        }
        // end
        Console.WriteLine(Counter);
        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        int Counter = 0;
        // code here
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
            {
                Counter++;
            }
        }
        // end
        Console.WriteLine(Counter);
        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse((Console.ReadLine()));
            double y = double.Parse((Console.ReadLine()));
            if (x > 0 && y > 0)
            {
                Console.WriteLine($"({x}, {y}) - принадлежат 1 четверти.");
                answer1++;
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"({x}, {y}) - принадлежат 2 четверти.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"({x}, {y}) - принадлежат 3 четверти.");
                answer3++;
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"({x}, {y}) - принадлежат 4 четверти.");
            }
            else
            {
                Console.WriteLine($"({x}, {y}) - принадлежат оси координат.");
            }
        }
        // end
        Console.WriteLine($"Точек в 1 четверти: {answer1}");
        Console.WriteLine($"Точек в 3 четверти: {answer3}");
        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        int Counter = 0;
        // code here
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double dist = Math.Sqrt(x * x + y * y);
            if (dist < answerLength)
            {
                answerLength = dist;
                Counter = i + 1;
            }
        }
        answer = Counter;
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 0; i < n; i++)
        {
            double result = double.Parse(Console.ReadLine());
            if (result < answer)
            {
                answer = result;
            }
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        int Counter = 0;
        // code here;
        for (int i = 0; i < n; i++)
        {
            int f = 0;
            for (int j = 0; j < 4; j++)
            {
                double rating = double.Parse(Console.ReadLine());
                if (rating == 2 || rating == 3)
                {
                    f = 1;
                }

            }
            if (f == 0)
            {
                Counter++;
            }



        }
        // end
        Console.WriteLine($"отв {Counter}");
        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        int Counter = 0;
        // code here;
        for (int i = 0; i < n; i++)
        {
            int f = 0;
            for (int j = 0; j < 4; j++)
            {
                double rating = double.Parse(Console.ReadLine());
                avg += rating;
                if (rating == 2)
                {
                    f = 1;
                }

            }
            if (f == 1)
            {
                Counter++;
            }
            // end
        }
        avg /= n * 4;
        avg = Math.Round(avg, 2);
        Console.WriteLine(avg);
        Console.WriteLine(Counter);
        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r > 0)
        {
            switch (type)
            {
                case 0:
                    answer = r * r;
                    break;
                case 1:
                    answer = r * r * Math.PI;
                    break;
                case 2:
                    answer = r * r * Math.Sqrt(3) / 4;
                    break;

            }
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        double p = (A + B + B) / 2;
        if (A > 0 && B > 0)
        {

            switch (type)
            {
                case 0:
                    answer = A * B;
                    break;
                case 1:
                    answer = Math.PI * (B * B - A * A);
                    break;
                case 2:
                    answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B));
                    break;

            }
        }
        answer = Math.Abs(answer);
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
        String y = "", x = "",  stop_word = "";
        // code here

        while (stop_word != "break")
        {
            stop_word = Console.ReadLine();
            if (stop_word != "break")
            {
                x = stop_word;
                y = Console.ReadLine();
                if (y == "break")
                {
                    break;
                }
                else
                {
                    double dist = Math.Sqrt(Math.Pow(double.Parse(x) - a, 2) + Math.Pow(double.Parse(y) - b, 2));
                    if (dist <= r)
                    {
                        n++;
                    }
                }
                
                
            }
        }
        Console.WriteLine(n);
        return answer;

    }
        
        // end

       
    


   
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
        int answer = 0, n = 0, Counter = 0;

        // code here
        String result = "";
        while (result != "break")
        {
            result = Console.ReadLine();
            if (result == "break")
            {
                break;
            }
            else
            {
                if (double.Parse(result) <= norm)
                {
                    Counter++;
                }
            }
        }
        Console.WriteLine(Counter);

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
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here
        int Counter = 0, i = 0;
        String x = " ", y = "", stop_word = "";

        while (stop_word != "break")
        {
            stop_word = Console.ReadLine();
            if ( stop_word != "break")
            {

                x = stop_word;
                y = Console.ReadLine();
                if (y == "break")
                {
                    break;
                }

                i++;
                double dist = Math.Sqrt(Math.Pow(double.Parse(x), 2) + Math.Pow(double.Parse(y), 2));

                if (dist < answerLength)
                {
                    answerLength = dist;
                    answer = i;
                }



            }
            
            
        }

        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
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
        int Counter = 0;
        // code here;
        double exz1, exz2, exz3, exz4;
        String exz_1 = "";
        while (exz_1 != "break")
        {
            n++;
            exz_1 = Console.ReadLine();
            if (exz_1 != "break")
            {
                
                exz1 = double.Parse(exz_1);
                exz2 = double.Parse(Console.ReadLine());
                exz3 = double.Parse(Console.ReadLine());
                exz4 = double.Parse(Console.ReadLine());
                avg += exz1 + exz2 + exz3 + exz4;
                if ((exz1 == 2) || (exz2 == 2) || (exz3 == 2) || (exz4 == 2))
                {
                    Counter += 1;
                }
            }
        }
        avg /= n * 4;
        Console.WriteLine(Counter);
        Console.WriteLine(avg);

        // end
        return (answer, avg);
    }
    #endregion
}