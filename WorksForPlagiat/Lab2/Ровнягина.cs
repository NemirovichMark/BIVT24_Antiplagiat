using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Xml.Schema;
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
        //program.Task_2_2(5, 3, 2, 1);
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(10);
        //program.Task_2_4(5, 1, 2);
        //program.Task_2_5(10, 25.2);
        //program.Task_2_6(5);
        //program.Task_2_7(5);
        //program.Task_2_8(5);
        //program.Task_2_9(6);
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
        int r = 2;
        if (Math.Abs(Math.Pow(x, 2) + Math.Pow(y, 2) - Math.Pow(r, 2)) <= Math.Pow(10, -3))  {
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && (y + Math.Abs(x) <= 1))
        {
            answer = true;
        }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = b;

        // code here
        if (a > 0)
        {
            if (a > b)
            {
                answer = a;
            }
        
        }
        else
        {
            if (a < b)
            {
                answer = a;
            }
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = c;

        // code here
        double mini = b;
        if (a < b)
        {
            mini = a;
        }
        if (mini > c)
        {
            answer = mini;
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double d_circle = Math.Sqrt(r / (Math.PI / 4));
        double d_square = Math.Sqrt(2 * s);
        if (d_square <= d_circle) {
            answer = true;
        }

           // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double d_circle = Math.Sqrt(r / (Math.PI / 4));
        double square = Math.Sqrt(s);
        if (d_circle < square)
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
        if (Math.Abs(x) > 1)
        {
            answer = 1;
        }
        else
        {
            answer = Math.Abs(x);
        }
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1)
        {
            answer = 0;
        }
        else if (Math.Abs(x) <= 1)
        {
            answer = Math.Pow(x, 2) - 1;
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
        else if ((-1 < x) && (x<= 0))
        {
            answer = 1 + x;
        }
        else if (x > 0)
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
        else if ((-1 < x) && (x <= 1))
        {
            answer = -x;
        }
        else if (x > 1)
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
        double general = 0;
        for (int i=0; i<n; i++)
        {
            double x;
            double.TryParse(Console.ReadLine(), out x);
            general = general + x;
        }
        answer = general / n;
        Console.WriteLine(answer);
       
        
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double x;
            double.TryParse(Console.ReadLine(), out x);
            double y;
            double.TryParse(Console.ReadLine(), out y);

            if (Math.Pow(x - a,2) + Math.Pow(y - b,2) <= Math.Pow(r,2))
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
        double answer_mil = 0;
        for (int i = 0; i < n; i++)
        {
            double m;
            double.TryParse(Console.ReadLine(), out m);
            if (m < 30)
            {
                answer_mil += 200;
            }   
        }
        answer = answer_mil / 1000;
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
            double x;
            double.TryParse(Console.ReadLine(), out x);
            double y;
            double.TryParse(Console.ReadLine(), out y);
            if (((Math.Pow(x, 2) + Math.Pow(y, 2) >= Math.Pow(r1, 2)) && (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(r2, 2))))
            {
                answer++;
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
        
        for (int i = 1; i <= n; i++)
        {
            double res;
            double.TryParse(Console.ReadLine(), out res);
            if (res <= norm) { answer++; }

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
            double x;
            double.TryParse(Console.ReadLine(), out x);
            double y;
            double.TryParse(Console.ReadLine(), out y);
            
            if (((0 <= x) && (x <= Math.PI)) && ((0 <= y) && (y <= Math.Sin(x)))) { answer++;}            
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
        for (int i = 0; i < n; i++)
        {
            double x;
            double.TryParse(Console.ReadLine(), out x);
            double y;
            double.TryParse(Console.ReadLine(), out y);
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Первый квадрант");
                answer1++;
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Второй квадрант");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Третий квадрант");
                answer3++;
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Четвертый квадрант");
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
        double MinValue = Double.PositiveInfinity;
        for (int i = 1; i <= n; i++)
        {
            double x;
            double.TryParse(Console.ReadLine(), out x);
            double y;
            double.TryParse(Console.ReadLine(), out y);
            double d = Math.Sqrt(x * x + y * y); 
            if (d < MinValue)
            {
                MinValue = d;
                answer = i;
            }
        }
        Console.WriteLine("Answer: {0}, Answer Length: {1}", answer, answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double maxx = 10000000;
        for (int i = 1; i <= n; i++)
        {
            double res;
            double.TryParse(Console.ReadLine(), out res);
            if (res < maxx)
            {
                maxx = res;
            }
        }
        answer = maxx;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Введите оценки ученикa номер {i}:");
            double rate1;
            double.TryParse(Console.ReadLine(), out rate1);
            double rate2;
            double.TryParse(Console.ReadLine(), out rate2);
            double rate3;
            double.TryParse(Console.ReadLine(), out rate3);
            double rate4;
            double.TryParse(Console.ReadLine(), out rate4);
            if ((rate1 != 2) && (rate2 != 2) && (rate3 != 2) && (rate4 != 2))
            {
                if ((rate1 != 3) && (rate2 != 3) && (rate3 != 3) && (rate4 != 3))
                {
                    answer++;
                }            
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

        // code here;
        double suma = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Введите оценки ученикa номер {i}:");
            double rate1;
            double.TryParse(Console.ReadLine(), out rate1);
            double rate2;
            double.TryParse(Console.ReadLine(), out rate2);
            double rate3;
            double.TryParse(Console.ReadLine(), out rate3);
            double rate4;
            double.TryParse(Console.ReadLine(), out rate4);
            suma = suma + rate1 + rate2 + rate3 + rate4;
            if ((rate1 == 2 || rate2 == 2 || rate3 == 2 || rate4 == 2) || (rate1 == 3 || rate2 == 3 || rate3 == 3 || rate4 == 3))
            {
            answer++;
            }
            avg = suma / (n * 4);
        }
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here
        if(r > 0)
        {
            switch (type)
            {
                case 0:
                    answer = r * r;
                    break;
                case 1:
                    answer = Math.PI * (r * r);
                    break;
                case 2:
                    answer = (r * r) * Math.Sqrt(3) / 4;
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
        if (A > 0 && B > 0)
        {
            switch (type)
            {
                case 0:
                    answer = A * B;
                    break;
                case 1:
                    answer = Math.Abs(Math.PI * (A * A) - Math.PI * (B * B));
                    break;
                case 2:
                    if (A < 2 * B)
                    {
                        double h = Math.Sqrt(Math.Pow(B, 2) - Math.Pow(A / 2, 2));
                        answer = 0.5 * A * h;
                    }
                    break;
                default: break;
            }
            
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
        double general = 0;
        while(true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                break;
            }
            if (double.TryParse(input, out double x))
            {
                general += x;
                n++;
            }
            
            
        }
        answer = general / n;
        Console.WriteLine(answer);
        // end

        
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
        int answer = 0;

        Console.WriteLine("Введите координаты (x, y) точек. Окончите ввод пустой строкой:");
        while (true)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2))
            {
                break; 
            }

           if (double.TryParse(input1, out double x) && double.TryParse(input2, out double y))
           {
                double distanceSquared = Math.Pow(x, 2) + Math.Pow(y, 2);

                if (distanceSquared >= Math.Pow(r1, 2) && distanceSquared <= Math.Pow(r2, 2))
                {
                    answer++; 
                }
           }
            else
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите действительные координаты.");
            }
        }

        Console.WriteLine($"Количество точек, находящихся между окружностями: {answer}");
        return answer; // Возвращаем ответ
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
        while (true)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2))
            {
                break;
            }

            if (double.TryParse(input1, out double x) && double.TryParse(input2, out double y))
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Первый квадрант");
                    answer1++;
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Второй квадрант");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Третий квадрант");
                    answer3++;
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Четвертый квадрант");
                }
            }

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
        
        while (true)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            string input4 = Console.ReadLine();

            if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2) || string.IsNullOrEmpty(input3) || string.IsNullOrEmpty(input4))
            {
                break;
            }

            if (double.TryParse(input1, out double rate1) && double.TryParse(input2, out double rate2) && double.TryParse(input3, out double rate3) && double.TryParse(input4, out double rate4))
            {
                
                if ((rate1 != 2) && (rate2 != 2) && (rate3 != 2) && (rate4 != 2))
                {
                    if ((rate1 != 3) && (rate2 != 3) && (rate3 != 3) && (rate4 != 3))
                    {
                        answer++;
                    }
                }
            }

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