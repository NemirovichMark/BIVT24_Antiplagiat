using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Assemblies;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
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
        //program.Task_2_1(10); //ПРАВИЛЬНО
        //program.Task_2_2(5, 3, 2, 1); //ПРАВИЛЬНО
        //program.Task_2_2(5, 1.5, 1.5, 1); //ПРАВИЛЬНО
        //program.Task_2_2(5, 1, 3, 1); //ПРАВИЛЬНО
        //program.Task_2_3(10); //ПРАВИЛЬНО
        //program.Task_2_4(5, 1, 2); //ПРАВИЛЬНО
        //program.Task_2_5(10, 30); //ПРАВИЛЬНО
        //program.Task_2_6(5); //ПРАВИЛЬНО
        //program.Task_2_7(5); //ПРАВИЛЬНО
        //program.Task_2_8(10); //ПРАВИЛЬНО
        //program.Task_2_9(10); //ПРАВИЛЬНО
        //program.Task_2_10(10); //ПРАВИЛЬНО
        //program.Task_2_11(10); //ПРАВИЛЬНО
        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1); //ПРАВИЛЬНО
        //program.Task_3_2(1.5, 1.5, 1); //ПРАВИЛЬНО
        //program.Task_3_2(1, 3, 1); //ПРАВИЛЬНО
        //program.Task_3_3();
        //program.Task_3_4(1, 2);
        //program.Task_3_5(30); //ПРАВИЛЬНО
        //program.Task_3_6();
        //program.Task_3_7();
        //program.Task_3_8(); //ПРАВИЛЬНО
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
        double r =2;
        bool uslovie = (Math.Abs(x*x +y*y - r*r) <= Math.Pow(10,-3));
        if (uslovie==true)
        {
            answer=true;
        }
        else
        {
            answer=false;
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y>=0 && (y+Math.Abs(x))<=1)
        {
            answer =true;
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
        double c=0;
        if (a>0)
        {
            if (a>b)
            {
                c = a;
            }
            else
            {
                c=b;
            }
        }
        else
        {
            if (a<b)
            {
                c=a;
            }
            else
            {
                c=b;
            }
        }
        answer = c;
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double z =0;
        double k =0;
        if (a<b)
        {
            k=a;
        }
        else
        {
            k=b;
        }
        if (k>c)
        {
            z=k;
        }
        else
        {
            z=c;
        }
        answer=z;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double diagonal= Math.Sqrt(s)*Math.Sqrt(2);
        double radius = Math.Sqrt(r/Math.PI);
        if (diagonal<=(2*radius))
        {
            answer=true;
        }
        else
        {
            answer=false;
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double radius = Math.Sqrt(r/Math.PI);
        double storona = Math.Sqrt(s);
        if ((2*radius)<=storona)
        {
            answer=true;
        }
        else
        {
            answer=false;
        }
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x)>1)
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
        if (Math.Abs(x)>=1)
        {
            answer = 0;
        }
        else
        {
            answer = x * x - 1;
        }
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x<=(-1))
        {
            answer=0;
        }
        else if (x>(-1) && x<=0)
        {
            answer=1+x;
        }
        else
        {
            answer=1;
        }
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x<=(-1))
        {
            answer=1;
        }
        else if (x>(-1) && x<=1)
        {
            answer=-x;
        }
        else
        {
            answer=-1;
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
        n=int.Parse(Console.ReadLine());
        double a=0;
        double summa =0;
        double count=0;
        for (int i=1;i<=n;i++)
        {
            a=double.Parse(Console.ReadLine());
            summa+=a;
            count++;
        }
        answer=summa/count;
        System.Console.WriteLine(answer);
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        n=int.Parse(Console.ReadLine());
        double x = 0;
        double y =0;
        for (int i=1;i<=n;i++)
        {
            x=double.Parse(Console.ReadLine());
            y=double.Parse(Console.ReadLine());
            if (Math.Sqrt((x-a)*(x-a) + (y-b)*(y-b))<=r)
            {
                answer++;
            }
        }
        System.Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        n=int.Parse(Console.ReadLine());
        double ves = 0;
        for (int i=1;i<=n;i++)
        {
            ves=double.Parse(Console.ReadLine());
            if (ves<30.0)
            {
                answer+=0.2;
            }
        }
        System.Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        n=int.Parse(Console.ReadLine());
        double x =0;
        double y =0;
        for (int i =1; i<=n;i++)
        {
            x=double.Parse(Console.ReadLine());
            y=double.Parse(Console.ReadLine());
            if (Math.Sqrt(x*x+y*y)>=r1 && Math.Sqrt(x*x+y*y)<=r2)
            {
                answer++;
            }
        }
        System.Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        n=int.Parse(Console.ReadLine());
        double dlina=0;
        for (int i=1;i<=n;i++)
        {
            dlina=double.Parse(Console.ReadLine());
            if (dlina>=norm)
            {
                answer++;
            }
        }
        System.Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        n=int.Parse(Console.ReadLine());
        double x=0;
        double y=0;
        for (int i=1;i<=n;i++)
        {
            x=double.Parse(Console.ReadLine());
            y=double.Parse(Console.ReadLine());
            double pi=Math.PI;
            if (y>=0 && y<=1 && x>=0 && x<=pi && y<=Math.Sin(x))
            {
                answer++;
            }
        }
        System.Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        n=int.Parse(Console.ReadLine());
        double x=0;
        double y=0;
        for (int i=1;i<=n;i++)
        {
            x=double.Parse(Console.ReadLine());
            y=double.Parse(Console.ReadLine());
            if (x>0 && y>0)
            {
                answer1++;
            }
            else if (x<0 && y<0)
            {
                answer3++;
            }
        }
        System.Console.WriteLine(answer1);
        System.Console.WriteLine(answer3);
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        n=int.Parse(Console.ReadLine());
        double x=0;
        double y=0;
        double dlina=0;
        for (int i=1;i<=n;i++)
        {
            x=double.Parse(Console.ReadLine());
            y=double.Parse(Console.ReadLine());
            dlina=Math.Sqrt(y*y+x*x);
            if (dlina<=answerLength)
            {
                answerLength=dlina;
                answer=i;
            }
        }
        System.Console.WriteLine(answer);
        System.Console.WriteLine(Math.Round(answerLength,2));
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        n=int.Parse(Console.ReadLine());
        double rezult=0;
        double otwet=1000000;
        for (int i=1;i<=n;i++)
        {
            rezult=double.Parse(Console.ReadLine());
            if (rezult<=otwet)
            {
                otwet=rezult;
            }
        }
        answer=otwet;
        System.Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        n=int.Parse(Console.ReadLine());
        int o1=0;
        int o2=0;
        int o3=0;
        int o4=0;
        for (int i=1;i<=n;i++)
        {
            o1=int.Parse(Console.ReadLine());
            o2=int.Parse(Console.ReadLine());
            o3=int.Parse(Console.ReadLine());
            o4=int.Parse(Console.ReadLine());
            if (o1>3 && o2>3 && o3>3 && o4>3)
            {
                answer++;
            }
        }
        System.Console.WriteLine(answer);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        n=int.Parse(Console.ReadLine());
        int o1=0;
        int o2=0;
        int o3=0;
        int o4=0;
        double count = 0;
        double suma=0;
        for (int i=1;i<=n;i++)
        {
            o1=int.Parse(Console.ReadLine());
            o2=int.Parse(Console.ReadLine());
            o3=int.Parse(Console.ReadLine());
            o4=int.Parse(Console.ReadLine());
            count+=4;
            suma+=o1;
            suma+=o2;
            suma+=o3;
            suma+=o4;
            if (o1<3 || o2<3 || o3<3 || o4<3)
            {
                answer++;
            }
        }
        avg=suma/count;
        System.Console.WriteLine($"{answer} {avg}");
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r<=0)
        {
            return 0;
        }
        switch (type)
        {
            case 0:
                answer=r*r;
                break;
            case 1:
                answer=r*r*Math.PI;
                break;
            case 2:
                answer=r*r*Math.Sqrt(3)/4;
                break;
        }
        answer=Math.Round(answer,2);
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A<=0 || B<=0)
        {
            return 0;
        }
        switch(type)
        {
            case 0:
                answer=A*B;
                break;
            case 1:
                answer=Math.Abs(Math.PI*(A*A-B*B));
                break;
            case 2:
                answer=0.5*A*Math.Sqrt(B*B-0.25*A*A);
                break;
        }
        answer=Math.Round(answer,2);
        System.Console.WriteLine(answer);
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

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here
        System.Console.WriteLine("Для окончания ввода введите x=1000");
        double x=0;
        double y=0;
        while(x<1000)
        {
            x=double.Parse(Console.ReadLine());
            y=double.Parse(Console.ReadLine());
            if (Math.Sqrt((x-a)*(x-a) + (y-b)*(y-b))<=r)
            {
                answer++;
            }
        }
        System.Console.WriteLine($"{answer}");
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

        return answer;
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
        int answer = 0, n = 0;

        // code here
        double dlina=1;
        System.Console.WriteLine("Для окончания ввода введите 0");
        while (dlina>0)
        {
            dlina=double.Parse(Console.ReadLine());
            if (dlina>=norm)
            {
                answer++;
            }
        }
        System.Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer

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
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here
        System.Console.WriteLine("Для окончания ввода введите 1000");
        double x=0;
        double y=0;
        double dlina=0;
        int i =0;
        while(x<1000 || y<1000)
        {
            x=double.Parse(Console.ReadLine());
            y=double.Parse(Console.ReadLine());
            dlina=Math.Sqrt(y*y+x*x);
            i++;
            if (dlina<=answerLength)
            {
                answerLength=dlina;
                answer=i;
            }
        }
        System.Console.WriteLine(answer);
        System.Console.WriteLine(Math.Round(answerLength,2));
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_8 answer

        return (answer, answerLength);
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
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;
        System.Console.WriteLine("Для окончания ввода введите 0");
        int o1=1;
        int o2=1;
        int o3=1;
        int o4=1;
        double count = 0;
        double suma=0;
        for (int i=1; ; i++)
        {
            o1=int.Parse(Console.ReadLine());
            o2=int.Parse(Console.ReadLine());
            o3=int.Parse(Console.ReadLine());
            o4=int.Parse(Console.ReadLine());
            if (o1==0 || o2==0 || o3==0 || o4==0)
            {
                break;
            }
            else
            {
                count+=4;
                suma+=o1;
                suma+=o2;
                suma+=o3;
                suma+=o4;
                if (o1<3 || o2<3 || o3<3 || o4<3)
                {
                    answer++;
                }
            }
            
        }
        avg=suma/count;
        System.Console.WriteLine($"{answer} {avg}");
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
