using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Dynamic;
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
        //program.Task_3_11();
        //program.Task_3_12(10, 0); !
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        string inside ="true";
        string outside = "false";
        double r;
        double.TryParse(Console.ReadLine(), out x);
        double.TryParse(Console.ReadLine(), out y);
        double.TryParse(Console.ReadLine(), out r);
        if (x * x + y * y - r*r <= (Math.Pow(10,-3)))
            Console.WriteLine(inside);
        else
            Console.WriteLine(outside);
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        double.TryParse(Console.ReadLine(), out x);
        double.TryParse(Console.ReadLine(), out y);
        if (y>=0 && y+Math.Abs(x)<=1)
            System.Console.WriteLine(true);
        else
            System.Console.WriteLine(false);
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        double c;
        string s;
        System.Console.WriteLine("a: ");
        a=double.Parse(Console.ReadLine());
        System.Console.WriteLine("b: ");
        b=double.Parse(Console.ReadLine());
        
        if (a>0)
        {
            if (a>b)
            
                c = a;
            
            else
            
                c = b;
            
            s = " ";
        }
        else
        {
            if (a>b)
            
                c = b;
            
            else
            
                c = a;
            
            s=" ";
        }
        //end
        System.Console.Write(s);
        System.Console.WriteLine(c);
        Console.ReadKey();
        
        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double min;
        System.Console.WriteLine("a:");
        a = double.Parse(Console.ReadLine());
        System.Console.WriteLine("b:");
        b = double.Parse(Console.ReadLine());
        System.Console.WriteLine("c:");
        c = double.Parse(Console.ReadLine());

        if (a>b)
            min = b;
        else
            min = a;
        if (min>c)
            System.Console.WriteLine(min);
        else 
            System.Console.WriteLine(c);
        Console.ReadKey();
        
        
       
        
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        string inside = "true";
        string outside = "false";
        double a, b;
        System.Console.WriteLine("r:");
        r = double.Parse(Console.ReadLine());
        System.Console.WriteLine("s:");
        s = double.Parse(Console.ReadLine());
        a = r / Math.PI;
        b = (s / 4) * (s / 4);
        if (a<b)
            System.Console.WriteLine(inside);
        else
            System.Console.WriteLine(outside);
    
        
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        string inside = "true";
        string outside = "false";

        double a, b;
        System.Console.WriteLine("r:");
        r = double.Parse(Console.ReadLine());
        System.Console.WriteLine("s:");
        s = double.Parse(Console.ReadLine());
        double d = r * 2;
        double diag_k = (s*s)+(s*s);
        double diam_r = d * d;
        if (diag_k <= diam_r)
            System.Console.WriteLine("true");
        else
            System.Console.WriteLine("false");
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        System.Console.WriteLine("введите значение:");
        x = double.Parse(Console.ReadLine());
        if (Math.Abs(x) > 1)
            System.Console.WriteLine(" y = 1 ");
        else
            System.Console.WriteLine(Math.Abs(x));
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        double y;
        System.Console.WriteLine("введите значение:");
        x = double.Parse(Console.ReadLine());
        if (Math.Abs(x) >= 1)
            y = 0;
        else
            y = x*x - 1;
        
        System.Console.WriteLine(y);

        // end
        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        System.Console.WriteLine("введите значение:");
        x = double.Parse(Console.ReadLine());
        if (x <= -1 )
        
            y = 0;
        
        if (-1 < x && x<=1)
        
            y = 1;
        
        if (x > 1)
        
            y = -1;
        
           
        System.Console.WriteLine(y);
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        System.Console.WriteLine("введите значение:");
        x = double.Parse(Console.ReadLine());
        if (x <= -1)
            y = 1;
        if (x > 1 && x <= 1)
            y = -x;
        if (x > 1)
            y = - 1;
        System.Console.WriteLine(y);
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        
        // code here
        int a = 0;
        double rost = 0; double sr;
        for (int i = 1; i <= n; i++)
        {
            double rost_uch;
            Console.WriteLine($"Введите рост{i}");
            rost_uch = double.Parse(Console.ReadLine());
            rost += rost_uch;
            a++;

        }   
        sr = rost / a;
        Console.WriteLine(sr);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        int k = 0;
        double x, y;
        System.Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        System.Console.WriteLine("r:  ");
        r = double.Parse(Console.ReadLine());
        System.Console.WriteLine("a:");
        a = double.Parse(Console.ReadLine());
        System.Console.WriteLine("b:");
        b = double.Parse(Console.ReadLine());
        for ( int i = 0; i < n; i++)
        {
            System.Console.WriteLine("x{0}:", i + 1);
            x = double.Parse(Console.ReadLine());
            System.Console.WriteLine("y{0}:", i + 1);
            y = double.Parse(Console.ReadLine());
            if (((x - a) * (x - a) + (y - b) * (y - b)) <= r * r)
                k++;
        }
        System.Console.WriteLine("num=" + k);
        
        
        
        
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        int i = 1;
        double a;
        double s = 0;
        System.Console.WriteLine("количество учеников: ");
        n = int.Parse(Console.ReadLine());
        while (i <= n)
        {
            i = i + 1;
            System.Console.WriteLine("вес ученика: ");
            a = double.Parse(Console.ReadLine());
            if (a < 30)
                s += 200;
        }
        if (s % 200 == 0)
                System.Console.WriteLine(s/1000);
        else
            System.Console.WriteLine(s / 1000 + 1);
        
        
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        string inside = "true";
        string outside = "false";
        double x, y, x0, y0;
        int i, k;
        System.Console.WriteLine("количество точек:");
        n = int.Parse(Console.ReadLine());
        System.Console.WriteLine("внутренний радиус кольца:");
        r1 = double.Parse(Console.ReadLine());
        System.Console.WriteLine("внешний радиус кольца:");
        r2 = double.Parse(Console.ReadLine());
        System.Console.WriteLine("x центра кольца:");
        x0 = double.Parse(Console.ReadLine());
        System.Console.WriteLine("y центра кольца");
        y0 = double.Parse(Console.ReadLine());

        k = 0;
        for (i = 1; i <= n; i++)
            System.Console.WriteLine("x {0}", i);
            x = double.Parse(Console.ReadLine());
            System.Console.WriteLine("y {0}", i);
            y = double.Parse(Console.ReadLine());
            if ((x - x0) * (x - x0) + (y - y0) * (y - y0) >= r1*r1 && (x-x0) * (x-x0) + (y-y0) * (y-y0) <= r2*r2)
            {
                k++;
                System.Console.WriteLine(inside);
            }
            else
            {
                System.Console.WriteLine(outside);
            }
        System.Console.WriteLine("{} точек из {1}", k, n);
   
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        
        // code here
       System.Console.WriteLine("количество спортсменов:");
       n = int.Parse(Console.ReadLine());
       System.Console.WriteLine("норматив:");
       norm = double.Parse(Console.ReadLine());
       int s = 0;
       for(int i = 1; i <= n; i++)
       {
            System.Console.WriteLine("результат:");
            double a = double.Parse(Console.ReadLine());
            if (a<norm)
            {
                s++;
                System.Console.WriteLine($"Спортсмен {i} выполнил норматив.");
            }
            else
            {
                System.Console.WriteLine($"Спортсмен {i} не выполнил норматив.");
            }
       }
       System.Console.WriteLine(s);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        System.Console.WriteLine("количество точек:");
        n = int.Parse(Console.ReadLine());
        
        for (int i = 1; i<=n; i++)
        {
            System.Console.WriteLine("координаты точек:");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x>=0 && x<=Math.PI && y>=0 && y<=Math.Sin(x))
            {
                answer++;
                System.Console.WriteLine($"({x}, {y}) принадлежaт фигуре.");
            }
            else
            {
                Console.WriteLine($"({x}, {y}) не принадлежaт фигуре.");
            }
        }
        Console.WriteLine($"точки внутри фигуры: {answer}");
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        
        int i = 0, j = 0, k =0;
        System.Console.WriteLine("количесвто точек:");
        n = int.Parse(Console.ReadLine());
        System.Console.WriteLine("введите точки с помощью двух координат");
        while(k<n)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x>0 && y>0)
            {
                System.Console.WriteLine("Квадрант 1");
                i++;
            }
            if (x<0 && y>0)
            {
                System.Console.WriteLine("Квадрант 2");
            }
            if (x<0 && y<0)
            {
                System.Console.WriteLine("Квадрант 3");
                j++;
            }
            if (x>0 && y<0)
            {
                System.Console.WriteLine("Квадрант 4");
            }
            else
                System.Console.WriteLine("Не определяется");
            k++;
        System.Console.WriteLine($"кол-во точек в 1 квадранте:{i,3}");
        System.Console.WriteLine($"кол-во точек в 3 квадранте:{j,3}");
        }

        
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here]
        int s = 1;
        System.Console.WriteLine("кол-во точек:");
        n = int.Parse(Console.ReadLine());
        
        for (int i = 1; i<=n; i++)
        {
            double x, y;
            
            System.Console.WriteLine("x:");
            x = double.Parse(Console.ReadLine());
            System.Console.WriteLine("y:");
            y = double.Parse(Console.ReadLine());
            
            double r = Math.Sqrt(x*x + y*y);
            if (r<answerLength)
            {
                s = i;
                answerLength = r;
            }
        }
        System.Console.WriteLine($"точка:{s} расстояние: {Math.Round(answerLength,2)}");
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double max = double.MaxValue;
        // code here
        System.Console.WriteLine("кол-во спорсменов:");
        n = int.Parse(Console.ReadLine());
        if (n<=0)
            return 0;
        for (int i = 1; i<=n; i++)
        {
            System.Console.WriteLine("результат:");
            double r = double.Parse(Console.ReadLine());
            
            if (r<max)
                max = r;
        }
        System.Console.WriteLine($"лучший результат: {max}");
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int m1,m2,m3,m4;
        int k = 0; //счетчик
        System.Console.WriteLine("кол-во учеников:");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i<n; i++)
        {
            System.Console.WriteLine("оценки:");
            m1 = int.Parse(Console.ReadLine());
            m2 = int.Parse(Console.ReadLine());
            m3 = int.Parse(Console.ReadLine());
            m4 = int.Parse(Console.ReadLine());

            if (m1>=4 && m2>=4 && m3>=4 && m4>=4)
                k++;
        }
        System.Console.WriteLine($"студентов без <2> и <3>: {k}");
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        int p1,p2,p3,p4;
        int k = 0;
        double sum = 0;
        System.Console.WriteLine("кол-во студентов:");
        n = int.Parse(Console.ReadLine());
        for (int i=0;i<n;i++)
        {
            System.Console.WriteLine("оценки:");
            p1 = int.Parse(Console.ReadLine());
            p2 = int.Parse(Console.ReadLine());
            p3 = int.Parse(Console.ReadLine());
            p4 = int.Parse(Console.ReadLine());
            sum += p1+p2+p3+p4;
            avg = sum/(n*4);

            if (p1>=4 && p2>=4 && p3>=4 && p4>=4)
                k++;
        }        
        System.Console.WriteLine($"студенты сдавшие экзамен: {k}");
        System.Console.WriteLine($"средний балл группы: {avg}");
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
       
        System.Console.WriteLine("выберите площадь какой фигуры вычеслим (от 1 до 3):");
        int c = int.Parse(Console.ReadLine());
        
        
        switch (c)
        {
            case 1:
                System.Console.WriteLine("квадрат");
                answer = r*r;
                break;
            case 2:
                System.Console.WriteLine("круг");
                answer = Math.PI*r*r;
                break;
            case 3:
                System.Console.WriteLine("равнобедренный треугольник");
                answer = (Math.Sqrt(3)/4)*r*r;
                break;
            default:
                return 0;
        }
        System.Console.WriteLine(Math.Round(answer,2));

        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        System.Console.WriteLine("выберите площадь какой фигуры вычеслим (от 1 до 3):");
        int c = int.Parse(Console.ReadLine());
        
        switch (c)
        {
            case 1:
                System.Console.WriteLine("прямоугольник");
                answer = A*B;
                break;
            case 2:
                System.Console.WriteLine("кольцо");
                answer = Math.Abs(Math.PI*A*A-Math.PI*B*B);
                break;
            case 3:
                System.Console.WriteLine("равнобедренный треугольник");
                answer = Math.Sqrt((B*B-A*A)/4)*A/2;
                break;
            default:
                return 0;
        }
        System.Console.WriteLine(Math.Round(answer,2));
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
        double s = 0;
        double r, m;

        do
        {
            System.Console.WriteLine("вес школьника:");
            System.Console.WriteLine("чтобы закончить введите 0");
            r = double.Parse(Console.ReadLine());
            if (r==0)
                break;
            if (r<30)
                s+=200;  
        } while (r>0);
            m = s/1000;
            if (s%1000 == 0)
                System.Console.WriteLine(m);
            else
                System.Console.WriteLine(m);
        // end
        System.Console.WriteLine($"необходимо ежедневно {m} литров молока");

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
        
       
        System.Console.WriteLine("вводите x и y:");
        System.Console.WriteLine("чтобы закончить введите 0");
       int k = 1;
       while(n<k)
        {
            double x = double.Parse(Console.ReadLine());
            if (x==0)
                break;
            double y = double.Parse(Console.ReadLine());
            if (x>=0 && x<=Math.PI && y>=0 && y<=Math.Sin(x))
            {
                answer++;
                System.Console.WriteLine($"{x} и {y} принадлежат фигуре");
            }
            else
                System.Console.WriteLine($"{x} и {y} не пренадлежат фигуре");
               
        }
        System.Console.WriteLine($"точки внутри фигуры:{answer}");

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
        double a, t;
        double T = 0;
        int i = 1;
        do
        {
            System.Console.WriteLine("время прохождения дистанции");
            a = double.Parse(Console.ReadLine());
            if (a==0)
                break;
            if (i==1)
                T=a;
                i++;
            if (a<T)
                T=a; 
        } while (a!=0);
        System.Console.WriteLine($"лучшее время дистанции: {T}");
        
        // end

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;
        double a, t;
        double T = 0;
        int i = 1;
        do
        {
            System.Console.WriteLine("время прохождения дистанции");
            a = double.Parse(Console.ReadLine());
            if (a==0)
                break;
            if (i==1)
                T=a;
                i++;
            if (a<T)
                T=a; 
        } while (a!=0);
        System.Console.WriteLine($"лучшее время дистанции: {T}");
        

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