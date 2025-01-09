using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(0.9, 1.23);
        //program.Task_1_2(0.9, 1.23);
        //program.Task_1_3(0, 2);
        //program.Task_1_4(0.9, 1.23, -0.1);
        //program.Task_1_5(0.9, 1.23);
        //program.Task_1_6(0.9, 1.23);
        //program.Task_1_7(0.9);
        //program.Task_1_8(0.9);
        //program.Task_1_9(0.9);
        //program.Task_1_10(0.9);


        //program.Task_2_1(10);  //+


        // Console.WriteLine("first");
        // program.Task_2_2(5, 3, 2, 1);

        // Console.WriteLine("second");
        // program.Task_2_2(5, 1.5, 1.5, 1);      //+++++++

        // Console.WriteLine("third");
        // program.Task_2_2(5, 1, 3, 1);


        // System.Console.WriteLine("First");
        // program.Task_2_3(10);

        // System.Console.WriteLine("Second");       //++++++
        // program.Task_2_3(8);

        // System.Console.WriteLine("Third");
        // program.Task_2_3(6);




        // System.Console.WriteLine("first");
        // program.Task_2_4(5, 1, 2);

        // Console.WriteLine("second");
        // program.Task_2_4(5, 1, 3);
        
        // System.Console.WriteLine("third (4)");
        // program.Task_2_4(4, 1, 2);
        //                                                     //+++++++
        // Console.WriteLine("fourth (4)");
        // program.Task_2_4(4, 1, 3);

        // System.Console.WriteLine("fifth (3)");
        // program.Task_2_4(3, 1, 2);

        // Console.WriteLine("sixth (3)");
        // program.Task_2_4(3, 1, 3);



        // System.Console.WriteLine("First 10");    
        // program.Task_2_5(10, 30);

        // System.Console.WriteLine("Second 10");    
        // program.Task_2_5(10, 25.2);


        // System.Console.WriteLine("Third 8");    
        // program.Task_2_5(8, 30);

        // System.Console.WriteLine("Fourth 8");       //+++++++
        // program.Task_2_5(8, 25.2);


        // System.Console.WriteLine("Fifth 6");    
        // program.Task_2_5(6, 30);

        // System.Console.WriteLine("Sixth 6");    
        // program.Task_2_5(6, 25.2);


        // System.Console.WriteLine("First");
        // program.Task_2_6(5);                 

        // System.Console.WriteLine("Second");      //+++++++
        // program.Task_2_6(4);

        // System.Console.WriteLine("Third");
        // program.Task_2_6(3);



        // System.Console.WriteLine("First");
        // program.Task_2_7(5);

        // System.Console.WriteLine("Second");      //++++++
        // program.Task_2_7(4);

        // System.Console.WriteLine("Third");
        // program.Task_2_7(3);

 

        // System.Console.WriteLine("First");
        // program.Task_2_8(5);

        // System.Console.WriteLine("Second");
        // program.Task_2_8(4);
        //                                                 //+++++++ (при последнем вводе -0,5 -0,5)
        // System.Console.WriteLine("Third");
        // program.Task_2_8(3);

        // System.Console.WriteLine("Fourth");
        // program.Task_2_8(0);



        // System.Console.WriteLine("First 10");
        // program.Task_2_9(10);

        // System.Console.WriteLine("Second 8");       
        // program.Task_2_9(8);                             //++++++

        // System.Console.WriteLine("Third 6");
        // program.Task_2_9(6);

        // System.Console.WriteLine("Fourth 0");
        // program.Task_2_9(0);



        // System.Console.WriteLine("First");
        // program.Task_2_10(10);

        // System.Console.WriteLine("Second");
        // program.Task_2_10(8);                     //+++++++
        
        // System.Console.WriteLine("Third");
        // program.Task_2_10(6);


        // System.Console.WriteLine("First 10");
        // program.Task_2_11(10);

        // System.Console.WriteLine("Second 8");
        // program.Task_2_11(8);                     //+++++++

        // System.Console.WriteLine("Third 6");
        // program.Task_2_11(6);

        // System.Console.WriteLine("Fourth 0");
        // program.Task_2_11(0);


        //program.Task_2_12(10, 0);
        //program.Task_2_13(-0.75, 1, 0);

        //program.Task_3_1();+

        //program.Task_3_2(2);
        //program.Task_3_3();


        // program.Task_3_4(1, 2);        //++


        //program.Task_3_5(30);
        //program.Task_3_6();

        //program.Task_3_7();              //++++

        //program.Task_3_8();
        //program.Task_3_9();

        //program.Task_3_10();               //++++++

        //program.Task_3_11();
        //program.Task_3_12(10, 0);

        program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        double r = 2;
    
        if (Math.Abs((x * x) + (y * y) - (r * r)) <= Math.Pow(10, -3))
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
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if ((y>=0) && (y + Math.Abs(x) <= 1)){
                answer = true;
            }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)
        {
            if (a>b){
                answer = a;
            }
            else{
            answer = b;
            }
        }
        else
        {
            if (a<b){
                answer = a;
            }
            else{
            answer = b;
            }
        }
        Console.WriteLine($"sdfsfd {answer}");
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        answer = Math.Max(Math.Min(a, b), c);
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double d_curcle = 2 * (Math.Sqrt(r / Math.PI));
        double square_d = Math.Sqrt(s)*Math.Sqrt(2);
        if (square_d <= d_curcle)
        {
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double d_curcle = 2 * (Math.Sqrt(r / Math.PI));
        double square_d = Math.Sqrt(s);
        if (square_d >= d_curcle)
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
        if (x <= -1)
        {
            answer = 0;
        }
        else if(-1<x && x <= 0)
        {
            answer = 1 + x;
        }
        else
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
        else if (-1 < x && x <= 1)
        {
            answer = -1 * x;
        }
        else
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
        double person_grow = 0;
        double sum_grow = 0;
        double count = 0;

        for (int i = 1; i<=n; i++){
            person_grow = double.Parse(Console.ReadLine());
            sum_grow+=person_grow;
            count++;
        }
        answer = sum_grow/count;
        System.Console.WriteLine(answer);
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        int count = 0;
        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Input x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Input y: ");
            double y = double.Parse(Console.ReadLine());
            double vector_ab = Math.Sqrt(((x - a)*(x - a))+((y - b)*(y - b)));
            Console.WriteLine($"{x}  {y} {vector_ab}  {r}");
            if (vector_ab < r)
            {
                count++;
                Console.WriteLine($"aproved");
            }
            Console.WriteLine("Mission complete");
        }
        Console.WriteLine($"answer: {count}");
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double glass_of_milk = 200;
        double child_weight;
        
        for (int i = 1; i <= n; i++){
            child_weight = double.Parse(Console.ReadLine());
            if (child_weight < 30){
                answer += glass_of_milk/(double)1000;
            }
        }
        answer = Math.Round(answer, 1);
        System.Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 1; i<=n; i++){

        System.Console.WriteLine("Enter x");
        double x = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter y");
        double y = double.Parse(Console.ReadLine());

        double s = Math.Sqrt((x*x)+(y*y));

        if (r1<s && s<r2){
            answer++;
        }
        }

        // end
        System.Console.WriteLine(answer);

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here

        for (int i = 1; i<=n; i++){
            double participant_time = double.Parse(Console.ReadLine());
            if (participant_time < norm){
                answer++;
            }
        }
        System.Console.WriteLine($"Answer = {answer}");
        // end

        // // for test input in console: 
        // 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9
        // 27.5, 32.5, 30, 22.3, 26.8, 36.6, 
        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = 1; i<=n; i++){
            System.Console.Write("enter x ");
            double x = double.Parse(Console.ReadLine());

            System.Console.Write("enter y");
            double y = double.Parse(Console.ReadLine());

            
            if (0 <= x && x <= Math.PI && 0 <= y && y <= Math.Sin(x)){
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
        
        for (int i = 1; i <= n; i++){
            System.Console.Write("Enter x");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y");
            double y = double.Parse(Console.ReadLine());

            if (x>0 && y>0){
                answer1++;
            }
            else if (x<0 && y<0){
                answer3++;
            }
        }
        System.Console.WriteLine($"Answer1 = {answer1}");
        System.Console.WriteLine($"Answer3 = {answer3}");
        // end

        // for test input in console: 
        // -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5,
        // -1.2 0.7, 2 -2, 0.5 0.9,

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        if (n==0){
            answerLength = 0;
        }
        else{
            for (int i = 1; i<=n; i++){
                System.Console.Write("enter x");
                double x = double.Parse(Console.ReadLine());

                Console.Write("enter y");
                double y = double.Parse(Console.ReadLine());

                double s = Math.Sqrt((x)*(x) + (y)*(y));
                if (s<=answerLength){
                    answer = i;
                    answerLength = s;
                }
                answerLength = Math.Round(answerLength, 2);
            }
        }
        System.Console.WriteLine($"answer = {answer}   length = {answerLength}");
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        if (n==0){
            answer = 0;
        }
        else{
        for (int i = 1; i <= n; i++){
            double swimmer_result = double.Parse(Console.ReadLine());

            if (swimmer_result<answer){
                answer = swimmer_result;
            }
        }
        }
        System.Console.WriteLine(answer);
        // end

        // // for test input in console: 
        // 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9
        // 27.5, 32.5, 30, 22.3, 26.8, 36.6

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int flag;

        for (int i = 1; i <= n; i++){
            flag = 1;
            for (int j = 1; j <= 4; j++){
                int enter = int.Parse(Console.ReadLine());
                if (2 <= enter && enter <= 3){
                    flag = 0;
                }
                else{
                    continue;
                }
            }
            if (flag == 1){
                answer++;
            }
            System.Console.WriteLine("student done");
        }

        System.Console.WriteLine(answer);
        // end

        // for test input in console: 
        // 5, 3, 3, 4, 
        // 5, 2, 4, 5, 
        // 5, 4, 5, 4, 
        // 2, 5, 3, 5, 
        // 4, 5, 5, 5, 
        // 5, 5, 5, 5,

        // 4, 4, 4, 4, 
        // 4, 4, 2, 5, 

        // 2, 2, 4, 2, 
        // 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double sum_grades_students = 0;
        double count = 0;
        if (n==0){
            avg = 0;
        }
        else{
        for (int i = 1; i <= n; i++){
            int flag = 0;
            for (int j = 1; j <= 4; j++){
                double grade = double.Parse(Console.ReadLine());
                if (grade < 3){
                    flag = 1;
                }
                sum_grades_students += grade;
                count++;
            }
            System.Console.WriteLine("Student done");
            if (flag == 1){
                answer++;
            }
        }
        avg = Math.Round(sum_grades_students/count, 2);
        }
        System.Console.WriteLine($"answer = {answer}    avg = {avg}");
        // end

        // for test input in console: 
        // 5, 3, 3, 4, 
        // 5, 2, 4, 5, 
        // 5, 4, 5, 4, 
        // 2, 5, 3, 5, 
        // 4, 5, 5, 5, 
        // 5, 5, 5, 5,  ----6
        // 4, 4, 4, 4, 
        // 4, 4, 2, 5,  ----8 
        // 2, 2, 4, 2, 
        // 5, 4, 5, 4



        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        if (r>0){
            switch (type){
                case 0:
                    answer = r*r;
                    break;
                case 1:
                    answer = Math.PI*r*r;
                    break;
                case 2:
                    answer = Math.Sqrt(3)*r*r/4.0;
                    break;
                default:
                    answer = 0;
                    break;
            }
        }
        else{
            answer = 0;
        }
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        if (A<=0 || B<=0){
            answer = 0;
        }
        else{
        switch (type){
            case 0:
                answer = A*B;
                break;
            case 1:
                answer = Math.Abs(Math.PI*B*B - Math.PI*A*A);
                break;
            case 2:
                answer = A/4.0*Math.Sqrt(4*B*B-A*A);
                break;
        }
        }
        answer = Math.Round(answer, 2);

        // code here;
        // if (type < 0 || type > 2 || (Math.Abs(type * 10.0 % 10) > 0) || A <= 0  || B <= 0){
        //     answer = 0;

        // end
        System.Console.WriteLine(answer);
        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        double enter_grow;
        double count = 0;
        double sum_grow = 0;

        // code here
        
        System.Console.WriteLine("To end the input please enter 0");

        while (true){
            enter_grow = int.Parse(Console.ReadLine());
            if (enter_grow == 0){
                break;
            }
            System.Console.WriteLine("Person height done");
            count++;
            sum_grow += enter_grow;
        }
        answer = sum_grow/count;
        System.Console.WriteLine(answer);

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
        double x, y; 
        
        System.Console.WriteLine("To end the input please enter 'stop' ");

        while (true){
        string input = (Console.ReadLine());
        if (input == "stop"){
            break;
        }
        x = Convert.ToDouble(input); 
        y = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Dot add"); 
        double s = Math.Sqrt(x*x+y*y);
        if (r1<s && s<r2){
            answer++;
        }
        }
        System.Console.WriteLine(answer);
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

        System.Console.WriteLine("To end the input please enter 'stop'");
        while (true){
            string input = Console.ReadLine();
            if (input == "stop"){
                break;
            }
            double x = Convert.ToDouble(input);
            double y = double.Parse(Console.ReadLine());

            if (x>0 && y>0){
                answer1++;
            }
            else if (x<0 && y<0){
                answer3++;
            }
        }
        System.Console.WriteLine($"answer1 = {answer1}  |  answer3 = {answer3}");


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

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
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

        System.Console.WriteLine("To end the input please enter 'stop'");
        while (true){
            int flag = 0;
            string first_input = Console.ReadLine();
            if (first_input == "stop"){
                break;
            }
            int first_grade = Convert.ToInt32(first_input);
            if (first_grade < 4){
                flag = 1;
            }
            for (int i = 1; i<= 3; i++){
                int grade = int.Parse(Console.ReadLine());
                if (grade < 4){
                    flag = 1;
                }
            }
            System.Console.WriteLine("Student add");
            if (flag == 1){
                answer++;
            }
        }
        System.Console.WriteLine(answer);
        // end

        // for test input in console: 
        // 5, 3, 3, 4,
        // 5, 2, 4, 5, 
        // 5, 4, 5, 4, 
        // 2, 5, 3, 5, 
        // 4, 5, 5, 5, 
        // 5, 5, 5, 5, 
        // 4, 4, 4, 4, 
        // 4, 4, 2, 5, 
        // 2, 2, 4, 2, 
        // 5, 4, 5, 4
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
        
        System.Console.WriteLine("To end the input please enter 'stop'");

        while (true){
            //tryParse(readLine, out n)
            System.Console.Write("Enter A");
            string input = Console.ReadLine();
            if (input == "stop"){
                break;
            }
            A = Convert.ToDouble(input);
            System.Console.Write("Enter B");
            B = double.Parse(Console.ReadLine());
            System.Console.Write("Enter type");
            type = int.Parse(Console.ReadLine());

            if (A<=0 || B<=0){
            answer = 0;
            }
            else{
            switch (type){
                case 0:
                    answer = A*B;
                    break;
                case 1:
                    answer = Math.Abs(Math.PI*B*B - Math.PI*A*A);
                    break;
                case 2:
                    answer = A/4.0*Math.Sqrt(4*B*B-A*A);
                    break;
            }
            }
            answer = Math.Round(answer, 2);
            System.Console.WriteLine(answer);
            answer = Math.Round(answer, 2);
            }
            
        // end
        // answer should be equal to the task_2_13 answer

        return answer;
    }
    #endregion
}
