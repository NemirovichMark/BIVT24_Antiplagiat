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
        program.Task_1_1(0.9, 1.23);
        program.Task_1_2(0.9, 1.23);
        program.Task_1_3(0.9, 1.23);
        program.Task_1_4(0.9, 1.23, -0.1);
        program.Task_1_5(0.9, 1.23);
        program.Task_1_6(0.9, 1.23);
        program.Task_1_7(0.9);
        program.Task_1_8(0.9);
        program.Task_1_9(0.9);
        program.Task_1_10(0.9);
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
        program.Task_2_12(10, 0);
        program.Task_2_13(10, 5, 0);
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
        int r = 2;
        if (Math.Abs(x*x+y*y-r*r)<=0.001){
            answer = true;
        }
Console.WriteLine("1.1 Ответ: " + answer);
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        //code here
        if (y>=0 && y+Math.Abs(x)<=1){
                answer = true;
        }
Console.WriteLine("1.2 Ответ: " + answer);
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a>0){
            if (a>=b) answer = a;
            else answer=b;
        }
        if (a<=0){
            if (a<=b) answer = a;
            else answer=b;
        }
        Console.WriteLine("1.3 Ответ: " + answer);
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double p1;
        if (a<=b) p1=a;
        else p1=b;
        if (p1>=c) answer=p1;
        else answer=c; 
Console.WriteLine("1.4 Ответ: " + answer);
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (s<=2*r/Math.PI) answer=true;
Console.WriteLine("1.5 Ответ: " + answer);
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (r<=Math.PI*s/4) answer=true;
Console.WriteLine("1.6 Ответ: " + answer);
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1) answer = 1;
        else answer=Math.Abs(x);
Console.WriteLine("1.7 Ответ: " + answer);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x)>=1) answer=0;
        else answer=x*x-1;
Console.WriteLine("1.8 Ответ: " + answer);
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x<=-1) answer=0;
        if (x>-1 && x<=0) answer=1+x;
        if (x>0) answer=1;
Console.WriteLine("1.9 Ответ: " + answer);
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x<=-1) answer=1;
        if (x>-1 && x<=1) answer=-x;
        if (x>1) answer=-1;
Console.WriteLine("1.10 Ответ: " + answer);
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        Console.WriteLine("2.1:");
        double p1=0;
        for (int i=1;i<=n;i++){
            Console.WriteLine("Рост " + i + " ученика" );
            double p2=Convert.ToDouble(Console.ReadLine());
            p1+=p2;
        }
        answer=p1/n;
Console.WriteLine("2.1 Ответ: " + answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        Console.WriteLine("2.2:");
        double x;
        double y;
        for (int i=0;i<=n;i++){
            Console.WriteLine("x " + i);
            x=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y " + i);
            y=Convert.ToDouble(Console.ReadLine());
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r) answer++;
        }
Console.WriteLine("2.2 Ответ: " + answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double p1;
        for (int i=1;i<=n;i++){
            Console.WriteLine("Вес ученика " + i);
            p1=Convert.ToDouble(Console.ReadLine());
            if (p1<30) answer+=0.2;
        }
        Console.WriteLine("2.3 Ответ: " + answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x;
        double y;
        for(int i=1;i<=n;i++){
            Console.WriteLine("x " + i);
            x=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y " + i);
            y=Convert.ToDouble(Console.ReadLine());
             if ((x * x + y * y >= r1 * r1) && (x * x + y * y <= r2 * r2)) answer++;
        }
        Console.WriteLine("2.4 Ответ: " + answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double sp;
        for (int i=1;i<=n;i++){
            Console.WriteLine("Скорость " + i + " спортсмена");
            sp=Convert.ToDouble(Console.ReadLine());
            if (sp<=norm) answer++;
        }
        Console.WriteLine("2.5 Ответ: " + answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x;
        double y;
        for (int i=1;i<=n;i++){
            Console.WriteLine("x " + i);
            x=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y " + i);
            y=Convert.ToDouble(Console.ReadLine());
            if (x >= 0 && x <= Math.PI && Math.Sin(x) >= y && y>=0) answer++;
        }       
        Console.WriteLine("2.6 Ответ: " + answer);
         // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        double x;
        double y;
        for (int i=1;i<=n;i++){
            Console.WriteLine("x " + i);
            x=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y " + i);
            y=Convert.ToDouble(Console.ReadLine());
            if (x>0 && y>0){
                Console.WriteLine("1 квадрат");
                answer1++;
            }
            else if (x<0 && y>0) Console.WriteLine("2 квадрат");
            if (x<0 && y<0){
                Console.WriteLine("3 квадрат");
                answer3++;
                }
            else Console.WriteLine("4 квадрат");
        }
        Console.WriteLine("2.7 Ответ1: " + answer1);
        Console.WriteLine("2.7 Ответ3: " + answer3);
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x;
        double y;
        double z;
        for (int i=1;i<=n;i++){
            Console.WriteLine("x " + i);
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y " + i);
            y = Convert.ToDouble(Console.ReadLine());
            z = Math.Sqrt(x * x + y * y);
            if (z < answerLength)
            {
                answerLength = z;
                answer = i;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine("2.8 ОтветA: " + answer);
        Console.WriteLine("2.8 ОтветL: " + answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double time;
        for (int i=1;i<=n;i++){
            Console.WriteLine("Время " + i + " спортсмена:");
            time=Convert.ToDouble(Console.ReadLine());
            if (time < answer) answer=time;
        }
        Console.WriteLine("2.9 Ответ: " + answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int p1;
        int p2;
        int p3;
        int p4;
        for (int i=1;i<=n;i++){
            Console.WriteLine("ученик "+ i + ":");
            Console.WriteLine("1 оценка:");
            p1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2 оценка:");
            p2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3 оценка:");
            p3=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("4 оценка:");
            p4=Convert.ToInt32(Console.ReadLine());
            if (p1*p2>=16 && p3*p4>=16) answer++;
        }
        Console.WriteLine("2.10 Ответ: " + answer);
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        int p1;
        int p2;
        int p3;
        int p4;
        int sum=0;
        int oc=0;
        for (int i=1;i<=n;i++){
            Console.WriteLine("студент "+ i + ":");
            Console.WriteLine("1 экзамен:");
            p1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2 экзамен:");
            p2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3 экзамен:");
            p3=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("4 экзамен:");
            p4=Convert.ToInt32(Console.ReadLine());
            if (p1==2 || p2==2 || p3==2 || p4==2) answer++;
        sum+=p1+p2+p3+p4;
        oc+=4;
        }
        avg=sum/oc;
        Console.WriteLine("2.11 ОтветAn: " + answer);
        Console.WriteLine("2.11 ОтветAvg: " + avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r < 0) return 0;
        switch (type){
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = Math.PI * r * r;
                break;
            case 2:
                answer = (r * r * Math.Sqrt(3)) / 4;
                break;
            default:
            return 0;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine("2.12 Ответ: " + answer);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
  
        // code here;
        if ((A <= 0) || (B <= 0)) return 0;
        switch (type){
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                break;
            case 2:
                answer = (A * Math.Sqrt(4 * B * B - A * A)) / 4;
                break;
            default:
            return 0;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine("2.13 Ответ: " + answer);
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
        double m;
        string check;
        Console.WriteLine("Количество учеников:");
        n=Convert.ToInt32(Console.ReadLine());
        for (int i = 1;i<=n;i++){
            Console.WriteLine("Вес " + i + " ученика:");
            check = Console.ReadLine();
            if (check == "Exit") break;
            else m = Convert.ToDouble(check);
            if (m<30) answer+=0.2;
        }
        answer=Math.Round(answer, 2);
        Console.WriteLine("3.3 Ответ: " + answer);
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
        int x;
        int y;
        string checkx;
        string checky;
        Console.WriteLine("Количество точек:");
        n=Convert.ToInt32(Console.ReadLine());
        for (int i = 1;i<=n;i++){
            Console.WriteLine("x " + i);
            checkx = Console.ReadLine();
            Console.WriteLine("y " + i);
            checky = Console.ReadLine();
            if (checkx == "Exit" || checky == "Exit") break;
            else{
                x = Convert.ToInt32(checkx);
                y = Convert.ToInt32(checky);
            }
            if (x >= 0 && x <= Math.PI && Math.Sin(x) >= y && y>=0) answer++;
        }
        Console.WriteLine("3.6 Ответ: " + answer);
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
        string check;
        double time;
        Console.WriteLine("Количество спортсменов:");
        n=Convert.ToInt32(Console.ReadLine());
        for (int i = 1;i<=n;i++){
            Console.WriteLine("Время " + i + " спортсмена:");
            check = Console.ReadLine();
            if (check == "Exit") break;
            else time = Convert.ToDouble(check);
            if (time < answer) answer = time;
        }
        Console.WriteLine("3.9 Ответ: " + answer);
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
