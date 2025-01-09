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
        //program.Task_1_1(2, 4);
        //program.Task_1_2(-0.5, 0.25);
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
        program.Task_3_9();
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
        if (Math.Abs((x * x) + (y * y) - (r * r)) <= 1e-3)
        {
            answer = true;
        }
        else 
        {
            answer = false;
        }
        System.Console.WriteLine(answer);

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
        else
        {
            answer = false;
        }
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)
        {
            if (b > a)
            answer = b;

            else
            answer = a;
        }
        else if (a <= 0)
        {
            if (a < b)
            answer = a;

            else
            answer = b;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double min = 0;
        if (a > b)
        min = b;

        else
        min = a;

        if (min > c)
        answer = min;

        else
        answer = c;


        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double a = Math.Sqrt(s); 
        if (r >= a)
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
        double a = Math.Sqrt(s);
        double deam = 2 * Math.Sqrt(r/Math.PI);
        if (deam <= a)
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

        // code here

        if(Math.Abs(x) > 1 )
        answer = 1;

        else if(Math.Abs(x) <= 1)
        answer = Math.Abs(x);

        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if(Math.Abs(x) >= 1 )
        answer = 0;

        else if(Math.Abs(x) < 1)
        answer = (x*x) - 1;


        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if(x <= -1)
        answer = 0;

        else if(-1 < x && x <= 0)
        answer = 1 + x;

        else if (x > 0)
        answer = 1;


        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if(x <= -1)
        answer = 1;

        else if (-1 < x && x <= 1)
        answer = -x;

        else if (x > 1)
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
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            string ? s = Console.ReadLine();
            double.TryParse (s, out double x);
            sum += x;
        }
        answer = sum / n;
        Console.WriteLine(answer);
        return answer; 
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
    }
    
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите координаты точки {i + 1}: ");
            string ? s = Console.ReadLine();
            string ? s2 = Console.ReadLine();
            double.TryParse(s, out double x);
            double.TryParse(s2, out double y);
            double distance = Math.Sqrt(Math.Pow(x - a, 2) + Math.Pow(y - b, 2));
            if (distance <= r)
            {
                answer++;
            }
        }
        System.Console.WriteLine($"Количество точек внутри круга: {answer}");
        return answer; 
    }

    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        Console.WriteLine("Введите вес учеников");
        for (int i = 0; i < n; i++)
        {
            string ? s = Console.ReadLine();
            double.TryParse(s, out double weight);
            if (weight < 30)
            {
                answer += 0.2;
            }
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine($"Потребуется: {answer} литров молока в день");

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
       
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите координаты точки {i + 1}: ");
            string ? s = Console.ReadLine();
            string ? s2 = Console.ReadLine();
            double.TryParse(s, out double x);
            double.TryParse(s2, out double y);
            double distance = Math.Sqrt(x * x + y * y);
            if (distance >= r1 && distance <= r2)
            {
                answer++;
            }
        }
        System.Console.WriteLine($"{answer} Точек входит в промежуток");
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }

    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите результат спортсмена {i + 1}: ");
            string ? s = Console.ReadLine();
            double.TryParse(s, out double result);
            if (result < norm)
            {
                answer++;
            }
        }
        System.Console.WriteLine($"{answer} Спортсменов выполнили нормотивы");

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }

    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите координаты точки {i + 1}: ");
            string ? s = Console.ReadLine();
            string ? s2 = Console.ReadLine();
            double.TryParse(s, out double x);
            double.TryParse(s2, out double y);
            if (0 <= x && x <= Math.PI  && 0 <= y && y <= Math.Sin(x))
            {
                answer++;
            }
        }
        System.Console.WriteLine($"{answer} Точек пренадлежат фигуре");
        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }

    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите координаты точки {i + 1}: ");
            string ? s = Console.ReadLine();
            string ? s2 = Console.ReadLine();
            double.TryParse(s, out double x);
            double.TryParse(s2, out double y);
            if (x > 0 && y > 0)
            {
                answer1++;
            }
            else if (x < 0 && y < 0)
            {
                answer3++;
            }
        }
        System.Console.WriteLine($"Количество точек в первом квадранте: {answer1}\nКоличество точек в третьем квадранте: {answer3}");
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }

    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите координаты точки {i + 1}: ");
            string ? s = Console.ReadLine();
            string ? s2 = Console.ReadLine();
            double.TryParse(s, out double x);
            double.TryParse(s2, out double y);

            double l = Math.Sqrt(x * x + y * y);
            if (l < answerLength)
            {
                answer = i;
                answerLength = l;
            }
        }
        System.Console.WriteLine($"number: {answer}\nlength: {Math.Round(answerLength,2)}");
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5

        return (answer, answerLength);
    }
   
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 0; i < n; i++)
        {
            string ? s = Console.ReadLine();  
            double.TryParse(s, out double time);
            if(answer > time)
            {
                answer = time;
            }
        }
        System.Console.WriteLine($"{answer} Лучшее время");

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
   
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for(int i = 0; i < n; i++)
        {
            bool a = true; 
            for(int j = 0; j < 4; j++)
            {
                string ? s = Console.ReadLine();
                int.TryParse(s, out int mark);
                if(mark > 3)
                {
                    a = false;
                }
            }
            if(a == true)
            {
                answer++;
            }
        }
        System.Console.WriteLine($"{answer} Студентов не имеют 3 и 2");

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }

    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        for(int i = 0; i < n; i++)
        {
            bool a = false; 
            int cnt = 0;
            for(int j = 0; j < 4; j++)
            {
                string ? s = Console.ReadLine();
                int.TryParse(s, out int mark);
                avg += mark;
                cnt++;
                if(mark <= 3)
                {
                    a = true;
                }
            }
            if(a == true)
            {
                answer++;
            }
            avg /= cnt;
        }
        avg = Math.Round(avg);
        System.Console.WriteLine($"Студентов не успевают :{answer} и средний бал группы :{avg}");

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }

    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r < 0)
        return 0;

        switch(type)
        {
            case 0:
                answer =  r * r;
                Console.WriteLine(answer);
                break;
            case 1:
                answer = Math.PI * (r * r);
                Console.WriteLine(answer);
                break;
            case 2:
                answer = r * r * Math.Sqrt(3) / 4;
                Console.WriteLine(answer);
                break;

            default:
            Console.WriteLine("Неверный ввод!");
            return 0;    
        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
   
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A <= 0 || B <= 0)
            return 0;

        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                break;
            case 2:
                answer = Math.Sqrt(B * B - A * A / 4) * A / 2;
                break;
            default:
            return 0;
        }

        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    #endregion
     
    #region Level 3
    /*
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;
        
        // code here

        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

        return answer;
    }
    */
    public double Task_3_3()
    {
        double answer = 0;

        // code here
        Console.WriteLine("Введите вес учеников или stop чтобы получить результат");
        while(true)
        {
            string ? s = Console.ReadLine();
            if (s == "stop")
            {
                break;
            }
            else
            {
                double.TryParse(s, out double weight);
                if (weight < 30 && weight > 0)
                {
                    answer += 0.2;
                }
            }
            
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine($"Потребуется: {answer} литров молока в день");
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_3 answer

        return answer;
    }

    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_4 answer

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0;

        // code here
        while(true)
        {
            Console.WriteLine($"Введите координаты точeк или stop чтобы получить результат");
            string ? s = Console.ReadLine();
            if (s == "stop")
            {
                break;
            }
            else
            {
                string ? s2 = Console.ReadLine();
                double.TryParse(s, out double x);
                double.TryParse(s2, out double y);
                if (0 <= x && x <= Math.PI  && 0 <= y && y <= Math.Sin(x))
                {
                    answer++;
                }
            }  
        }
        System.Console.WriteLine($"{answer} Точек пренадлежат фигуре");

        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1
        // answer should be equal to the task_2_6 answer

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_7 answer

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_8 answer

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        // code here
        while(true)
        {
            Console.WriteLine($"Введите время или stop чтобы получить результат");
            string ? s = Console.ReadLine();
            if (s == "stop")
            {
                break;
            }
            else
            {
                double.TryParse(s, out double time);
                if (time < answer && time > 0)
                {
                    answer = time;
                }
            }
        }
        System.Console.WriteLine($"{answer} Лучшее время");

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_9 answer

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_10 answer

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_11 answer

        return (answer, avg);
    }
    public double Task_3_12(double r, int type)
    {
        double answer = 0;

        // code here;

        // end
        // answer should be equal to the task_2_12 answer

        return answer;
    }
    public double Task_3_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;

        // end
        // answer should be equal to the task_2_13 answer

        return answer;
    }
    #endregion 
}
