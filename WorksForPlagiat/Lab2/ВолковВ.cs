using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

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
        double r = 2;
        if (Math.Abs(x * x + y * y - r * r) <= 0.001)
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if ((y <= x + 1) && (y <= 1 - x) && (y >= 0))
            answer = true;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)
        {
            answer = (a > b) ? a : b;
        }
        else
        {
            answer = (a < b) ? a : b;
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
            answer = (a < c) ? c : a;
        }
        else
        {
            answer = (b < c) ? c : b;
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double diagonal = Math.Sqrt(2) * Math.Sqrt(s);
        double cirleDiameter = 2 * Math.Sqrt(r / Math.PI);

        if (diagonal <= cirleDiameter)
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double sqSide = Math.Sqrt(s);
        double cirleDiameter = 2 * Math.Sqrt(r / Math.PI);

        if (cirleDiameter <= sqSide)
            answer = true;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        answer = (Math.Abs(x) > 1) ? 1 : Math.Abs(x);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        answer = (Math.Abs(x) >= 1) ? 0 : (x * x - 1);
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x > 0)
        {
            answer = 1;
        }
        else if (-1 < x && x <= 0)
        {
            answer = 1 + x;
        }
        else
        {
            answer = 0;
        }
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x > 1)
        {
            answer = -1;
        }
        else if (-1 < x && x <= 1)
        {
            answer = -x;
        }
        else
        {
            answer = 1;
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
        double sum = 0, height;
        for (int i = 0; i < n; i++)
        {
            height = double.Parse(Console.ReadLine());
            sum += height;
        }

        answer = sum / n;
        Console.WriteLine("\nСредний рост класса: " + answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        CultureInfo culture = new CultureInfo("en-US");
        double x, y;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), culture, out x);
            double.TryParse(Console.ReadLine(), culture, out y);

            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
                answer++;
           }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double weight;
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out weight);
            if (weight < 30)
                k++;
        }
        answer = k * 0.2;
        Console.WriteLine(Math.Round(answer, 1));
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x, y;
        for(int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out x);
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out y);

            double distance = Math.Sqrt(x * x + y * y); 

            if (distance >= r1 && distance <= r2)
                answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double result;

        for(int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out result);
            if (result < norm)
                answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x, y;

        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out x);
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out y);

            if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
                answer++; 
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
        double x, y;

        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out x);
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out y);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("1-й квадрант");
                answer1++;
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("2-й квадрант");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("3-й квадрант");
                answer3++;
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("4-й квадрант");
            }
        }
        Console.WriteLine("Кол-во точек в 1-й квадранте: "+answer1+"\n"+ "Кол-во точек в 3-й квадранте: "+answer3);
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x, y;

        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out x);
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out y);

            if (Math.Sqrt(x * x + y * y) < answerLength)
            {
                answerLength = Math.Sqrt(x * x + y * y);
                answer = i + 1;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine($"Точка {answer} : {answerLength}");
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double res;

        for (int i = 0; i < n; ++i)
        {
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out res);
            if (res < answer)
            {
                answer = res;
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
        int m1,m2,m3,m4;

        for(int i = 0; i < n; i++)
        {
            int.TryParse(Console.ReadLine(), out m1);
            int.TryParse(Console.ReadLine(), out m2);
            int.TryParse(Console.ReadLine(), out m3);
            int.TryParse(Console.ReadLine(), out m4);

            if (!(m1 == 2 || m1 == 3) && !(m2 == 2 || m2 == 3) && !(m3 == 2 || m3 == 3) && !(m4 == 2 || m4 == 3))
                answer++;
        }
        Console.WriteLine("Число студентов: " + answer);
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        int m1, m2, m3, m4;

        for (int i = 0; i < n; i++)
        {
            int.TryParse(Console.ReadLine(), out m1);
            int.TryParse(Console.ReadLine(), out m2);
            int.TryParse(Console.ReadLine(), out m3);
            int.TryParse(Console.ReadLine(), out m4);

            if (m1 == 2 || m2 == 2 || m3 == 2 || m4 == 2)
                answer++;
            avg += (m1 + m2 + m3 + m4);
        }
        avg = Math.Round(avg / (4* n));
        Console.WriteLine($"\nЧисло неуспевающих студентов {answer} и средний балл группы {avg}");
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (type < 0 || type > 2) return 0;

        if (r > 0)
        {
            if (type == 0)
            {
                answer = r * r;
            }
            else if (type == 1)
            {
                answer = Math.PI * r * r;
            }
            else
            {
                answer = (Math.Sqrt(3)/4) * r * r;
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
        if (type < 0 || type > 2) return 0;
        if (A <= 0 || B <= 0) return 0;
        
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                break;
            case 2:
                double h = Math.Sqrt(B * B - A * A / 4);
                answer = A * h / 2;
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
        int k = 0;
        string input;
        Console.WriteLine("Введите вес (для окончания ввода напишите exit):");
        
        while (true)
        {
            Console.Write("Вес: ");
            input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }
            if (double.TryParse(input, CultureInfo.InvariantCulture, out double weight))
            {
                if (weight < 30)
                {
                    k++;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод, попробуйте снова");
            }
        }

        answer = k * 0.2;
        Console.WriteLine(Math.Round(answer, 1));

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
        Console.WriteLine("Введите координаты точек (для окончания ввода напишите exit):");

        while (true)
        {
            n++;
            Console.WriteLine($"Точка {n}");
            Console.Write("X: ");
            string input1 = Console.ReadLine();

            if (input1.ToLower() == "exit")
            {
                break;
            }
            if(double.TryParse(input1, CultureInfo.InvariantCulture, out double x))
            {
                Console.Write("Y: ");
                string input2 = Console.ReadLine();
                if (input2.ToLower() == "exit")
                {
                    break;
                }
                if (double.TryParse(input2, CultureInfo.InvariantCulture, out double y))
                {
                    if (y <= Math.Sin(x) && x >= 0 && x <= Math.PI)
                    {
                        answer++;
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод, попробуйте снова");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод, попробуйте снова");
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
        double answer = double.MaxValue;
        int n = 0;

        // code here
        Console.WriteLine("Введите результат спортсменов (для окончания ввода напишите exit):");

        while (true)
        {
            Console.Write("Результат: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }
            if (double.TryParse(input, CultureInfo.InvariantCulture, out double result))
            {
                if (result < answer)
                {
                    answer = result;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод, попробуйте снова");
            }
        }

        Console.WriteLine($"Лучший результат: {answer} с");
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
