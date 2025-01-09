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
        program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        double r = 2;
        if (Math.Abs(x * x + y * y - r * r) <= 1 / 1000)
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y>= 0 && y + Math.Abs(x)<= 1)
            answer = true;

        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0 && a>b)
            answer = a;
        if (a > 0 && a<b)
            answer = b;
        if (a <= 0 && a > b)
            answer = b;
        if (a <= 0 && a < b)
            answer = a;




        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        double min = 0;
        // code here
        if (a > b)
        { 
            min = b;
            if ((min > c))
                answer = min;
            else
                answer = c;
        }
        if (a < b)
        {
            min = a;
            if ((min > c))
                answer = min;
            else
                answer = c;
        }



        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double pi = 3.14;
        if (2 * (r / pi) <= Math.Sqrt(s))
            answer = false;
        else
            answer = true;

       


        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;
        // code here
        if ( r / Math.PI <= s/4)
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
        if (Math.Abs(x) >= 1)
            answer = 0;
        else
            answer = x * x - 1;

        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer  = 0;
        if (-1 < x && x <= 0)
            answer = 1 + x;
        if (x > 0)
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
        if (-1 < x && x <= 1)
            answer = -x;
        if (x>1)
            answer = -1;

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        double s ;
        double x = 0 ;
        // code here
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            s = double.Parse(Console.ReadLine());
            x = x + s;

        }
        answer = x / n;
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double distance = Math.Sqrt(Math.Pow(x - a, 2) + Math.Pow(y - b, 2));
            if (distance <= r)
                answer = answer + 1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        int norma = 30;
        double mass;
        for (int i = 0;i <n; i++)
        {
            mass = double.Parse(Console.ReadLine());
            if (mass < norma)
                answer = answer + 0.2;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;    

        // code here
        double a;
        double b;
        n = int.Parse(Console.ReadLine());
        r1 = double.Parse(Console.ReadLine());
        r2 = double.Parse(Console.ReadLine());
        for (int i = 0;i<n;i++)
        {
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());   
            if ((a*a + b*b <= r2 * r2) && (a * a + b * b >= r1 * r1)) answer = answer + 1;                        
        }
        Console.WriteLine(answer);
            
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        n = int.Parse(Console.ReadLine());
        norm = double.Parse(Console.ReadLine());
        double rez;
        // code here
        for (int i = 0;i<n;i++)
        {
            rez = double.Parse(Console.ReadLine());
            if (rez <= norm) answer = answer + 1;

        }
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x;
        double y;
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ((x >= 0) && (x <= Math.PI) && (Math.Sin(x) >= y))
                answer = answer + 1;
        }
        Console.WriteLine(answer);




        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
        double x;
        double y;

        // code here
        n = int.Parse(Console.ReadLine());
        for (int i = 0;i<n;i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x>0 && y > 0)
            {
                Console.WriteLine("1 квадрант ");
                answer1 += 1;
            } 
            if (x < 0 && y > 0)
            {
                Console.WriteLine("2 квадрант ");
            }
            if (x <0 && y < 0)
            {
                Console.WriteLine("3 квадрант ");
                answer3 += 1;
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("4 квадрант ");
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
        n = int.Parse(Console.ReadLine());
        for (int i = 0;i<n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double distance = Math.Sqrt(x*x + y*y);
            if (distance< answerLength)
            {
                answerLength = distance;
                answer = i + 1;
            }
            


        }
        answerLength = Math.Round(answerLength,2);
        Console.WriteLine($"ближайшая точка{answer}, растояние:{answerLength}");


        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double f = 333;
        // code here
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            double rez = double.Parse(Console.ReadLine());
            if (rez < answer)
            {
                answer = rez;
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
        n = int.Parse(Console.ReadLine());
        for (int i = 0;i<n;i++)
        {
            int max1 = int.Parse(Console.ReadLine());
            int max2 = int.Parse(Console.ReadLine());
            int max3 = int.Parse(Console.ReadLine());
            int max4 = int.Parse(Console.ReadLine());
            if ((max1 != 2 && max1 != 3 ) && (max2 != 2 && max2 != 3) && (max3 != 2 && max3 != 3 ) &&( max4 != 2 && max4 != 3 ))
            {
                answer = answer + 1;
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
        double v = 0;

        // code here;
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i<n; i++)
        {
            int max1 = int.Parse(Console.ReadLine());
            int max2 = int.Parse(Console.ReadLine());
            int max3 = int.Parse(Console.ReadLine());
            int max4 = int.Parse(Console.ReadLine());
            if (max1 < 3 || max2 < 3 || max3 < 3 || max4 < 3)
            {
                answer = answer + 1;
            }
            v =v +  max1 + max2 + max3 + max4;
        }
        avg = v / (4*n);
        Console.WriteLine("    ");
        Console.WriteLine(answer);
        Console.WriteLine(avg);


        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here
        if (r <= 0) return 0;
        switch(type)
        {
             case 0:
                answer = r * r;
                answer = Math.Round(answer, 2);
                Console.WriteLine(answer);
                break;
             case 1:
                answer = Math.PI * r * r;
                answer = Math.Round(answer, 2);
                Console.WriteLine(answer);
                break;
             case 2:
                answer = (Math.Sqrt(3) / 4) * r * r;
                answer = Math.Round(answer, 2);
                Console.WriteLine(answer);
                break;
        }      
        Console.WriteLine();
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A <= 0 || B <= 0) return 0;
        switch (type)
        {
            case 0:
                answer = Math.Round(A * B, 2);
                answer = Math.Round(answer, 2);
                break;
            case 1:
                answer = (Math.Abs(Math.PI * (A * A - B * B)));
                answer = Math.Round(answer, 2);
                break;
            case 2:
                answer = A / 4 * Math.Sqrt(4 * B * B - A * A);
                answer = Math.Round(answer, 2);
                break;
        }
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
        Console.WriteLine("введите радиус");
        r = double.Parse(Console.ReadLine());
        Console.WriteLine("введите 1 координату центра круга ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("введите 2 координату центра круга");
        b = double.Parse(Console.ReadLine());
        double x;
        double y;
        do
        {
            Console.WriteLine("введите x= 1000 для окончания");
            Console.WriteLine("введите координаты x");
            x = double.Parse(Console.ReadLine());
            if (x >= 1000) break;
            Console.WriteLine("введите координаты y");
            y = double.Parse(Console.ReadLine());
            double distance = Math.Sqrt(Math.Pow(x - a, 2) + Math.Pow(y - b, 2));
            if (distance <= r)
                answer = answer + 1;
        } while (x < 1000);
        Console.WriteLine(answer);




        // end

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
        int answer = 0, n = 0;

        // code here

        
        Console.WriteLine("введите норматив ");
        norm = double.Parse(Console.ReadLine());
        double rez;
        Console.WriteLine("введите результаты забега,для остановки введите отрицательное число");
        for (int i = 0; ;i++)
        {
            rez = double.Parse(Console.ReadLine());
            if (rez <= norm) answer = answer + 1;
            if (rez <= 0) break;

        }
        Console.WriteLine($"сдало норматив:{answer}");
  
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
        double x;
        double y;
        Console.WriteLine("введите x= 1000 для окончания");
        for (int i = 0; ; i++)
        {
            Console.WriteLine("введите координаты x");
            x = double.Parse(Console.ReadLine());
            if (x >= 1000) break;
            Console.WriteLine("введите координаты y");
            y = double.Parse(Console.ReadLine());
            double distance = Math.Sqrt(x * x + y * y);
            if (distance < answerLength)
            {
                answerLength = distance;
                answer = answer + 1;
            }

        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine($"ближайшая точка{answer}, растояние:{answerLength}");

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

        // code here;
        double v = 0;
        int i;
        for ( i = 1; ; i++)

        {
            Console.WriteLine("введите значение меньше 2 или больше 5 для остановки");
            int max1 = int.Parse(Console.ReadLine());
            int max2 = int.Parse(Console.ReadLine());
            int max3 = int.Parse(Console.ReadLine());
            int max4 = int.Parse(Console.ReadLine());
            if (max1 < 2 || max2 < 2 || max3 < 2 || max4 < 2) break;
            if (max1 >5 || max2 > 5 || max3 > 5 || max4 > 5) break;
            if (max1 < 3 || max2 < 3 || max3 < 3 || max4 < 3)
            {
                answer = answer + 1;
            }
            v = v + max1 + max2 + max3 + max4;
        }
        avg = v / (4 * i);
        Console.WriteLine("    ");
        Console.WriteLine(answer);
        Console.WriteLine(avg);


        // end

        return (answer, avg);
    }
    #endregion
}