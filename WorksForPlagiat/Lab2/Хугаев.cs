using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

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

        answer = Math.Abs(x*x + y*y - 4) <= Math.Pow(10,-3);

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = y>= 0 && y + Math.Abs(x) <= 1;

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        if (a > 0)
            if (a > b)
                answer = a;
            else
                answer = b;
        else
            if (a < b)
                answer = a;
            else
                answer = b;

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        if (a < b)
            if (c > a)
                answer = c;
            else
                answer = a;
         else
            if (c > b)
                answer = c;
            else
                answer = b;


      
        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        r = Math.Sqrt(r / (Math.PI/4));
        s = Math.Sqrt(2 * s) ;
        bool answer = s <= r;
        Console.WriteLine( s + "<=" + r + "=" + answer);

        

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        r = Math.Sqrt(r / (Math.PI / 4));
        //Нужна длина стороны квадрата, а не длина диагонали
        s = Math.Sqrt(s);
        bool answer = s >= r;
        Console.WriteLine(s + ">=" + r + "=" + answer);

        return answer;
    }
    public double Task_1_7(double x)
    {
        x = Math.Abs(x);
        double answer = 0;
        if (x>1)
            answer = 1;
        else
            answer = x;

        return answer;
    }
    public double Task_1_8(double x)
    {
        x = Math.Abs(x);
        double answer = 0;
        if (x >= 1)
            answer = 0;
        else
            answer = x*x-1;

        return answer;
    }
    public double Task_1_9(double x)
    {

        double answer = 0;
        if (x <= -1)
            answer = 0;
        else if (x > 0)
            answer = 1;
        else
            answer = 1 + x;
        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;
        if (x <= -1)
            answer = 1;
        else if (x > 1)
            answer = -1;
        else
            answer = -1 * x;
        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        for (double amount = 1; amount<=n;amount++ )
        {
            Console.WriteLine(amount);
            Console.WriteLine("Ввод роста следующего ребенка:");
            answer += double.Parse(System.Console.ReadLine());
        }
        answer /= n;
        Console.WriteLine(answer);


        // end
        
        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0, kolvo = 0;

        // code here

        for (;kolvo<n; kolvo++)
        {
            Console.WriteLine("Ввод точек:");
            double x = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            double y = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            if ((a-x) * (a-x) + (b-y) * (b - y) <= r * r) answer++;

        }
        Console.WriteLine( answer+ " / " + kolvo);

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        int answer = 0, kolvo = 0;

        // code here

        for (; kolvo < n; kolvo++)
        {
            Console.WriteLine("Ввод веса:");
            double weight = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            if (weight<30) answer++;

        }
        Console.WriteLine(answer + " / " + kolvo);
        Console.WriteLine(Math.Round(answer * 0.2, 2));

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return Math.Round(answer * 0.2,2);
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0, kolvo = 0;

        for (; kolvo < n; kolvo++)
        {
            Console.WriteLine("Ввод точек:");
            double x = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            double y = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            if ((x*x + y*y <= r2 * r2) && (x * x + y * y >= r1 * r1)) answer++;

        }
        Console.WriteLine(answer + " / " + kolvo);



        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {

        int answer = 0, kolvo = 0;

        // code here

        for (; kolvo < n; kolvo++)
        {
            Console.WriteLine("Ввод результата:");
            double run = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            if (run <= norm) answer++;

        }
        Console.WriteLine(answer + " / " + kolvo);
        Console.WriteLine(answer);

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0, kolvo = 0;

        // code here

        for (; kolvo < n; kolvo++)
        {
            Console.WriteLine("Ввод точек:");
            double x = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            double y = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            if ((x >= 0) && (x <= Math.PI) && (Math.Sin(x) >= y)) answer++;

        }
        Console.WriteLine(answer + " / " + kolvo);

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer3 = 0, kolvo = 0, answer1 = 0;

        // code here

        for (; kolvo < n; kolvo++)
        {
            Console.WriteLine("Ввод точек:");
            double x = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            double y = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            if ((x > 0) && (y > 0)) { answer1++; Console.WriteLine("1"); }
            if ((x < 0) && (y < 0)) { answer3++; Console.WriteLine("3"); }
            if ((x > 0) && (y < 0)) Console.WriteLine("4");
            if ((x < 0) && (y > 0)) Console.WriteLine("2");


        }
        Console.WriteLine(answer1 + " ,,,,,, " + answer3);

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0, kolvo = 0;
        double answerLength = double.MaxValue;
        

        // code here

        for (; kolvo < n; kolvo++)
        {
            Console.WriteLine("Ввод точек:");
            double x = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            double y = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            if (Math.Sqrt(x * x + y * y) < answerLength) { answerLength = Math.Sqrt(x * x + y * y); answer = kolvo; }

        }
        Console.WriteLine(answer+1 + " / " + Math.Round(answerLength,2));


        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5

        return (answer + 1, Math.Round(answerLength, 2));
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        int kolvo = 0;

        // code here

        for (; kolvo < n; kolvo++)
        {
            Console.WriteLine("Ввод результата:");
            double swim = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            if (swim <= answer) answer = swim;

        }
        Console.WriteLine(answer);

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0, kolvo = 0;

        // code here

        for (; kolvo < n; kolvo++)
        {
            Console.WriteLine("Ввод оценок:");
            double fst_m = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            double sec_m = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            double thr_m = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            double for_m = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            if (fst_m != 2 && sec_m != 2 && thr_m != 2 && for_m != 2 && fst_m != 3 && sec_m != 3 && thr_m != 3 && for_m != 3) answer++;

        }
        Console.WriteLine(answer + " / " + kolvo);
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        
        double avg = 0;

        int answer = 0, kolvo = 0;

        // code here

        for (; kolvo < n; kolvo++)
        {
            Console.WriteLine("Ввод оценок:");
            double fst_m = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            double sec_m = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            double thr_m = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            double for_m = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));

            avg += fst_m + sec_m + thr_m + for_m;
                
            

            if (fst_m == 2 || sec_m == 2 || thr_m == 2 || for_m == 2) answer++;

        }
        Console.WriteLine(answer + " / " + kolvo);
        avg /= kolvo * 4;
        Console.WriteLine(avg);
        
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4


        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        

        // code here

        Console.WriteLine("тип " + type + " radius = " + r);
        if (type == 0)
            answer = r * r;
        else
            if (type == 1)
            answer = Math.PI * r * r;
        else
                if (type == 2)
            answer = (r * r * Math.Sqrt(3)) / 4;
        else answer = 0;
            
       

        Console.WriteLine(Math.Round(answer, 2));
        if (r >= 0)
            return Math.Round(answer, 2);
        else return 0;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        Console.WriteLine("тип " + type + " A = " + A + "B = " + B);
        if (type == 0)
            answer = A * B;
        else
            if (type == 1)
            answer = Math.PI * Math.Abs(A*A-B*B);
        else
                if (type == 2)
            answer = A/4*Math.Sqrt(4*B*B-A*A);
        else answer = 0;



        Console.WriteLine(Math.Round(answer, 2));
        if (A > 0 && B > 0)
            return Math.Round(answer, 2);
        else return 0;
    }
    #endregion

    #region Level 3
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
        

        // code here
        int answer = 0, kolvo = 0;


        string end = "___";
        while (end != "end")
        {
            Console.WriteLine("Ввод точек:");
            double x = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            double y = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            if ((a - x) * (a - x) + (b - y) * (b - y) <= r * r) answer++;

            kolvo++;
            Console.WriteLine("Конец? (Введите end)");
            end = System.Console.ReadLine();

        }
        Console.WriteLine(answer + " / " + kolvo);


        return answer;
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here

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
        int answer = 0, kolvo = 0;

        // code here

        string end = "___";
        while (end != "end")
        {
            Console.WriteLine("Ввод результата:");
            double run = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            if (run <= norm) answer++;

            kolvo++;
            Console.WriteLine("Конец? (Введите end)");
            end = System.Console.ReadLine();

        }
        Console.WriteLine(answer + " / " + kolvo);
        Console.WriteLine(answer);

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here

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
        int answer = 0, kolvo = 0;
        double answerLength = double.MaxValue;

        string end = "___";
        while (end != "end")
        {
            Console.WriteLine("Ввод точек:");
            double x = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            double y = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            if (Math.Sqrt(x * x + y * y) < answerLength) { answerLength = Math.Sqrt(x * x + y * y); answer = kolvo; }

            kolvo++;
            Console.WriteLine("Конец? (Введите end)");
            end = System.Console.ReadLine();
        }
        Console.WriteLine(answer + 1 + " / " + Math.Round(answerLength, 2));


        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5

        return (answer + 1, Math.Round(answerLength, 2));
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here

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
        double avg = 0;

        int answer = 0, kolvo = 0;

        // code here

        string end = "___";
        while (end != "end")
        {
            Console.WriteLine("Ввод оценок:");
            double fst_m = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            double sec_m = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            double thr_m = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            double for_m = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));

            avg += fst_m + sec_m + thr_m + for_m;



            if (fst_m == 2 || sec_m == 2 || thr_m == 2 || for_m == 2) answer++;


            kolvo++;
            Console.WriteLine("Конец? (Введите end)");
            end = System.Console.ReadLine();
        }
    
        Console.WriteLine(answer + " / " + kolvo);
        avg /= kolvo * 4;
        Console.WriteLine(avg);

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

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
