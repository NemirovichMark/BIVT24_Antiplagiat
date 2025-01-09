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
        //program.Task_2_5(10,30);
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
        //Console.WriteLine("Введите координату по x");
        //x =  Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Введите координату по y");
        //y = Convert.ToDouble(Console.ReadLine());

        if (Math.Abs(x * x + y * y - r * r) <= 0.001)
        {
            answer = true;
            Console.WriteLine("Точка лежит на окружности");
        }
        else
        {
            answer = false;
            Console.WriteLine("Точка не лежит на окружности");
        }

        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        //Console.WriteLine("Введите координату по x");
        //x =  Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Введите координату по y");
        //y =  Convert.ToDouble(Console.ReadLine());
        if (y>=0 && (y+ Math.Abs(x) <= 1)){
            answer = true;
            Console.WriteLine("Точка принадлежит фигуре");
        }
        else
        {
            answer= false;
            Console.WriteLine("Точка не принаждлежит фигуре");
        }

        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here

        //Console.WriteLine("Введите a");
        //a =  Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Введите b");
        //b =  Convert.ToDouble(Console.ReadLine());
        double c;
        if (a > 0)
        {
            if (a > b) c = a;
            else c = b;

        }
        else
        {
            if (a < b) c = a;
            else c = b;
        }

        answer = c;
        Console.WriteLine($"C = {answer}");
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double min_ab;
        double z;
        //Console.WriteLine("Введите a");
        //a = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Введите b");
        //b = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Введите c");
        //c = Convert.ToDouble(Console.ReadLine());

        if (a < b) min_ab = a;
        else min_ab = b;

        if (min_ab > c) z = min_ab;
        else z = c;

        answer = z;
        Console.WriteLine($"z = {answer}");
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here

        //Console.WriteLine("Введите r");
        //r = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Введите s");
        //s = Convert.ToDouble(Console.ReadLine());
        double diagonal = Math.Sqrt(s/2);
        double radius = Math.Sqrt(r / Math.PI);
        if (diagonal <= radius)
        {
            Console.WriteLine("Поместится");
            answer = true;
        }
        else
        {
            Console.WriteLine("Не поместится");
            answer = false;
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here

        //Console.WriteLine("Введите r");
        //r = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Введите s");
        //s = Convert.ToDouble(Console.ReadLine());
        double diagonal = Math.Sqrt(s);
        double radius = Math.Sqrt(r / Math.PI);
        if (radius * 2 <= diagonal)
        {
            Console.WriteLine("Поместится");
            answer = true;
        }
        else
        {
            Console.WriteLine("Не поместится");
            answer = false;
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
            return 1;
        }
        else
        {
            return Math.Abs(x);
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
            return 0;
        }
        else
        {
            return x * x - 1;
        }

        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here

        if (x <= -1) return 0;
        else if (x > -1 && x <= 0) return 1 + x;
        else return 1;

        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here

        if (x <= -1) return 1;
        else if (x>-1 && x<=1) return -x;
        else return -1;

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double summarosta = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Введите рост {i} ребенка");
            double r = Convert.ToDouble(Console.ReadLine()); 
            summarosta += r;
        }
        answer = summarosta / n;
        Console.WriteLine($"Средний рост {answer}");
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        //code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите координату точки по х");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату точки по y");
            double y = Convert.ToDouble(Console.ReadLine());
            if (((x - a)*(x-a) + (y - b)*(y-b) <= r*r)) answer += 1;
        }

        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Введите вес {i} ребенка");
            double ves = Convert.ToDouble(Console.ReadLine());
            if (ves < 30) answer += 0.2;

        }
        answer = Math.Round(answer, 1);
        Console.WriteLine($"Потребуется {answer} л молока");

        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите координату точки по х");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату точки по y");
            double y = Convert.ToDouble(Console.ReadLine());
            if ((x*x+y*y >=r1*r1) && (x*x + y*y <= r2 * r2)){
                answer += 1;

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
            Console.WriteLine($"Введите время {i} спортсмена");
            double time = Convert.ToDouble(Console.ReadLine());
            if (time <= norm) answer += 1;
        }
        Console.WriteLine(answer);
            // end

            return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Введите x {i} точки");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Введите y {i} точки");
            double y = Convert.ToDouble(Console.ReadLine());
            if ((x >= 0) && (x <= Math.PI) && (Math.Sin(x) >= y))
            {
                answer += 1;
            }
        }
        Console.WriteLine($"{answer} т. принадлежат фигуре");

        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Введите x {i} точки");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Введите y {i} точки");
            double y = Convert.ToDouble(Console.ReadLine());
            if (x>0 && y > 0)
            {
                Console.WriteLine("Точка лежит в 1 четверти");
                answer1 += 1;
            } else if (x<0 && y > 0)
            {
                Console.WriteLine("Точка лежит во 2 четверти");
            } else if (x<0 && y < 0)
            {
                Console.WriteLine("Точка лежит в 3 четверти");
                answer3 += 1;
            } else
            {
                Console.WriteLine("Точка лежит в 4 четверти");
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
        double length = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Введите x {i} точки");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Введите y {i} точки");
            double y = Convert.ToDouble(Console.ReadLine());
            length = Math.Sqrt(x*x + y*y);
            if (length < answerLength)
            {
                answerLength = length;
                answer = i;
            }
        }
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
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Введите результат {i} спортсмена");
            double res = Convert.ToDouble(Console.ReadLine());
            if (res < answer) answer = res;
        }
        Console.WriteLine($"Лучший результат: {answer}");
            // end

            return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        
        for (int i = 1; i <= n; i++)
        {
            double first_mark = Convert.ToDouble(Console.ReadLine());
            double second_mark = Convert.ToDouble(Console.ReadLine());
            double third_mark = Convert.ToDouble(Console.ReadLine());
            double fourth_mark = Convert.ToDouble(Console.ReadLine());
            
            if ((first_mark == 4 || first_mark==5) && (second_mark==4 || second_mark==5) && (third_mark==4 || third_mark==5) && (fourth_mark==4 || fourth_mark == 5)){
                answer += 1;
            }
        }
        Console.WriteLine($"Студенты с хорошими оценками: {answer}");

        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double summa=0;
        double k = 0;
        for (int i = 1; i <= n; i++)
        {
            double first_mark = Convert.ToDouble(Console.ReadLine());
            double second_mark = Convert.ToDouble(Console.ReadLine());
            double third_mark = Convert.ToDouble(Console.ReadLine());
            double fourth_mark = Convert.ToDouble(Console.ReadLine());

            if (first_mark == 2 || second_mark == 2 || third_mark == 2 || fourth_mark == 2)
            {
                answer += 1;
            }
            summa += first_mark + second_mark + third_mark + fourth_mark;
            k += 4;
        }
        avg = summa/k;

        Console.WriteLine($"Ср балл: {avg}");
        Console.WriteLine($"Неуспевающих студентов: {answer}");

        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        //Console.WriteLine("Площадь какой фигуры нужно поссчитать?\n0 - квадрат\n1-круг\n2-равносторонний треугольник");
        //type = int.Parse(Console.ReadLine());
        if (r <= 0) return 0;
        switch (type)
        {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = Math.PI * r * r;
                break;
            case 2:
                answer = (r * r * Math.Sqrt(3)) / 4;
                break;
        }
        answer = Math.Round(answer, 2);


        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        //Console.WriteLine("Площадь какой фигуры нужно поссчитать?\n0 - площадь прямоугольника со сторонами А, В\n1-площадь кольца, заключенного между двумя окружностями с радиусами А и В\n2-площадь равнобедренного треугольника со сторонами А, B, В");
        //type = int.Parse(Console.ReadLine());

        if ((A <= 0) || (B <= 0)) return 0;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                break;
            case 2:
                answer = (A * Math.Sqrt(4 * B * B - A * A)) / 4;
                break;
        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    #endregion

    #region Level 3
    //Номер в группе 10
    //10 % 3 + 1 = 2
    //2 5 8 11
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
        string vvod1 = "";
        string vvod2 = "";
        double x;
        double y;

        Console.WriteLine("Для остановки введите: Stop");
        while (true)
        {
            Console.WriteLine("Введите координату точки по х");
            vvod1 = Console.ReadLine();
            if (vvod1 != "Stop")
            {
                x = Convert.ToDouble(vvod1);
                Console.WriteLine("Введите координату точки по y");
                vvod2 = Console.ReadLine();
                if (vvod2 != "Stop")
                {
                    y = Convert.ToDouble(vvod2);
                }
                else break;
            }
            else break;
            if (((x - a) * (x - a) + (y - b) * (y - b) <= r * r)) answer += 1;
        }
        Console.WriteLine($"Ответ: {answer}");

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
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here
        string vvod = "";
        double time;
        double y;
        int i = 1;
        Console.WriteLine("Для остановки введите: Stop");
        while (true)
        {
            Console.WriteLine($"Введите время {i} спортсмена");
            vvod = Console.ReadLine();
            if (vvod != "Stop" )
            {
                time = Convert.ToDouble(vvod);

            }
            else break;
            if (time <= norm) answer += 1;
            i += 1;
        }
        Console.WriteLine($"Ответ: {answer}");

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
        double length;

        // code here
        string vvod1 = "";
        string vvod2 = "";
        double x, y;
        int i = 1;
        Console.WriteLine("Для остановки введите: Stop");
        while (true)
        {
            Console.WriteLine("Введите координату точки по х");
            vvod1 = Console.ReadLine();
            if (vvod1 != "Stop")
            {
                x = Convert.ToDouble(vvod1);
                Console.WriteLine("Введите координату точки по y");
                vvod2 = Console.ReadLine();
                if (vvod2 != "Stop")
                {
                    y = Convert.ToDouble(vvod2);
                }
                else break;
            }
            else break;

            length = Math.Sqrt(x * x + y * y);
            if (length < answerLength)
            {
                answerLength = length;
                answer = i;
            }
            i += 1;
        }
        
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine($"Номер точки: {answer}");
        Console.WriteLine($"Расстояние: {answerLength}");

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
        double summa = 0;
        double k = 0;

        string vvod1 = "";
        string vvod2 = "";
        string vvod3 = "";
        string vvod4 = "";
        double first_mark, second_mark, third_mark, fourth_mark;
        int i = 1;
        Console.WriteLine("Для остановки введите: Stop");
        while (true)
        {
            Console.WriteLine("Введите 1 оценку");
            vvod1 = Console.ReadLine();
            if (vvod1 != "Stop")
            {
                first_mark = Convert.ToDouble(vvod1);
                Console.WriteLine("Введите 2 оценку");
                vvod2 = Console.ReadLine();
                if (vvod2 != "Stop")
                {
                    second_mark = Convert.ToDouble(vvod2);
                    Console.WriteLine("Введите 3 оценку");
                    vvod3 = Console.ReadLine();
                    if (vvod3 != "Stop")
                    {
                        third_mark = Convert.ToDouble(vvod3);
                        Console.WriteLine("Введите 4 оценку");
                        vvod4 = Console.ReadLine();
                        if (vvod4 != "Stop")
                        {
                            fourth_mark = Convert.ToDouble(vvod4);
                        }
                        else break;
                    }
                    else break;
                }
                else break;
            }
            else break;
            
            if (first_mark == 2 || second_mark == 2 || third_mark == 2 || fourth_mark == 2)
            {
                answer += 1;
            }
            summa += first_mark + second_mark + third_mark + fourth_mark;
            k += 4;
        }

        avg = summa / k;

        Console.WriteLine($"Ср балл: {avg}");
        Console.WriteLine($"Неуспевающих студентов: {answer}");

        // end

        return (answer, avg);
    }
    #endregion
}