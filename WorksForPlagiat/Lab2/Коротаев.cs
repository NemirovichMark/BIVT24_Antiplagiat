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
        // program.Task_2_4(5, 1, 2);
        // program.Task_2_5(10, 30);
        // program.Task_2_6(5);
        //program.Task_2_7(5);
        // program.Task_2_8(5);
        // program.Task_2_9(10);
        // program.Task_2_10(10);
        // program.Task_2_11(10);
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
        if (Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -3)) answer = true;
        // end

        return answer;
    }

    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && y + Math.Abs(x) <= 1) answer = true;
        // end

        return answer;
    }

    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        answer = (a > 0) ? ((a > b) ? a : b) : ((a < b) ? a : b);
        // end

        return answer;
    }

    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double minAB = (a < b) ? a : b;
        answer = (minAB > c) ? minAB : c;
        // end

        return answer;
    }

    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double d = 2*Math.Sqrt(r / double.Pi);
        double d1= Math.Sqrt(s+s);
        if (d1 <= d) answer = true;
        // end

        return answer;
    }

    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double d = 2 * Math.Sqrt(r / double.Pi);
        double d1 = Math.Sqrt(s);
        if (d<=d1) answer = true;
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
        answer = (Math.Abs(x) >= 1) ? 0 : x*x-1 ;
        // end

        return answer;
    }

    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) {
            answer = 0;
        } else {
            if (x > -1 && x <= 0) answer = 1 + x;
            else answer = 1;
        }
        // end

        return answer;
    }
    
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        else if (x > -1 && x <= 1) answer = -x;
        else answer = -1;
        // end

        return answer;
    }

    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double a = 0;
        double b;

        for (int i=1; i<=n; i++) {
            b = int.Parse(Console.ReadLine());
            a += b;
        }

        answer = a / n;
        // end

        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++) {
            Console.WriteLine("Введите координаты точки (x y): ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            if (Math.Pow(x - a, 2) + Math.Pow(y - b, 2) <= r * r) {
                answer++;
            }
        }
        // end
        
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for (int i = 0; i < n; i++) {
            Console.WriteLine("Введите вес ученика: ");
            double w = Convert.ToDouble(Console.ReadLine());

            if (w < 30) {
                answer += 0.2;
            }
        }
        
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++) {
            Console.WriteLine("Введите координаты точки (x y): ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double dist2 = x * x + y * y;

            if (dist2 >= r1 * r1 && dist2 <= r2 * r2) {
                answer++;
            }
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++) {
            double res = Convert.ToDouble(Console.ReadLine());
            if (res <= norm) {
                answer++;
            }
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++) {
            Console.WriteLine("Введите координаты точки (x y): ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x)) {
                answer++;
            }
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for (int i = 0; i < n; i++) {
            Console.WriteLine("Введите координаты точки (x y): ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            if (x > 0 && y > 0) Console.WriteLine("четверть 1");
            if (x < 0 && y > 0) Console.WriteLine("четверть 2");
            if (x < 0 && y < 0) Console.WriteLine("четверть 3");
            if (x > 0 && y < 0) Console.WriteLine("четверть 4");

            if (x > 0 && y > 0) answer1++;
            else if (x < 0 && y < 0) answer3++;
        }
        // end

        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        for (int i = 0; i < n; i++) {
            Console.WriteLine("Введите координаты точки (x y): ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            double dist = Math.Sqrt(x * x + y * y);
            if (dist < answerLength) {
                answerLength = dist;
                answer = i + 1;
            }
        }
        // end

        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength,2));
        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 0; i < n; i++) {
            double res = Convert.ToDouble(Console.ReadLine());
            if (res < answer) answer = res;
        }
        // end

        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 0; i < n; i++) {
            bool hasLow = false;
            Console.WriteLine("Введите оценки студента: ");
            for (int j = 0; j < 4; j++) {
                int grade = Convert.ToInt32(Console.ReadLine());
                if (grade == 2 || grade == 3) hasLow = true;
            }
            if (!hasLow) answer++;
        }
        // end

        Console.WriteLine(answer);
        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double total = 0;

        // code here;
        for (int i = 0; i < n; i++) {
            int sumGrades = 0;
            bool isFailing = false;
            Console.WriteLine("Введите оценку студента: ");
            for (int j = 0; j < 4; j++)
            {
                
                int grade = Convert.ToInt32(Console.ReadLine());
                sumGrades += grade;

                if (grade < 3) isFailing = true;
            }

            total += sumGrades;
            if (isFailing) answer++;
        }
        double avg = total / (n * 4);
        // end

        Console.WriteLine(answer);
        Console.WriteLine(avg);
        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        if (r > 0) {
            switch (type) {
                case 0:
                    answer = r * r;
                    break;
                case 1:
                    answer = r * r * Math.PI;
                    break;
                case 2:
                    answer = r * r * Math.Sqrt(3) / 4;
                    break;
                default:
                    answer = 0;
                    break;
            }
        }
        return Math.Round(answer, 2);
    }

    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        if (A > 0 && B > 0) {
            switch (type) {
                case 0:
                    answer = A * B;
                    break;
                case 1:
                    answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                    break;
                case 2:
                    answer = A / 2 * Math.Sqrt(B * B - A * A / 4);
                    break;
                default:
                    answer = 0;
                    break;
            }
        }
        return Math.Round(answer, 2);
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

        // code here
        Console.WriteLine("Введите вес учеников (оставьте строку пустой для завершения ввода).");

        while (true) {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;
            if (double.TryParse(input, out double weight)) {
                if (weight < 30) answer += 0.2;
            } else {
                Console.WriteLine("Некорректный ввод, попробуйте снова.");
            }
        }
        // end

        Console.WriteLine(answer);
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
        Console.WriteLine("Введите координаты точек через пробел (оставьте строку пустой для завершения ввода).");
        while (true) {
            Console.Write("(x y): ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;

            string[] coordinates = input.Split();
            if (coordinates.Length != 2 || 
                !double.TryParse(coordinates[0], out double x) || 
                !double.TryParse(coordinates[1], out double y))
            {
                Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                continue;
            }

            if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x)) {
                answer++;
            }
        }
        // end

        Console.WriteLine(answer);
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

        // code here
        Console.WriteLine("Введите результаты (оставьте строку пустой для завершения ввода):");
        while (true) {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;
            if (double.TryParse(input, out double result)) {
                if (result < answer) answer = result;
            } else {
                Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            }
        }

        if (answer == double.MaxValue) {
            Console.WriteLine("Результаты не были введены.");
            return 0;
        }
        // end

        Console.WriteLine(answer);
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