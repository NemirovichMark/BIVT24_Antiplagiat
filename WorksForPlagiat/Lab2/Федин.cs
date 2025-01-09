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
        //program.Task_2_3(6); 
        //program.Task_2_4(4, 1, 3); 
        //program.Task_2_5(10, 25.2); 
        //program.Task_2_6(5); 
        //program.Task_2_7(5); 
        //program.Task_2_8(5);
        //program.Task_2_9(8); 
        //program.Task_2_10(8); 
        //program.Task_2_11(8); 
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
        int r = 2;
        if (Math.Abs(x*x + y*y - r*r) <= 0.0001){
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y>=0 && (y+Math.Abs(x))<= 1){
            answer = true;
        }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0){
            if (a>b){
                answer = a;
            }
            else{
                answer = b;
            }
        }
        else{
            if (a>b){
                answer = b;
            }
            else{
                answer = a;
            }
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double n;
        if (a>b){
            n = b;
        }
        else{
            n = a;
        }
        if (c>n){
            answer = c;
        }
        else{
            answer = n;
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double cube_diag = Math.Sqrt(s)*Math.Sqrt(2)*0.5;
        double circle_radius = Math.Sqrt(r/Math.PI);
        if (cube_diag < circle_radius){
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double cube_side = Math.Sqrt(s)/2;
        double circle_radius = Math.Sqrt(r/Math.PI);
        if (circle_radius < cube_side){
            answer = true;
        }
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1){
            answer = 1;
        }
        else{
            answer = Math.Abs(x);
        }
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1){
            answer = 0;
        }
        else{
            answer = x*x-1;
        }
        // end
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x<=-1){
            answer = 0;
        }
        else if (-1 < x && x<=0){
            answer = 1 + x;
        }
        else{
            answer = 1;
        }
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1){
            answer = 1;
        }
        else if (x > 1){
            answer = -1;
        }
        else{
            answer = -x;
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
        double x;
        for (int i = 0; i<n;i++){
            double.TryParse(Console.ReadLine(), out x);
            answer += x;
        }
        answer /= n;
        Console.WriteLine(answer);
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        // code here
        double x, y;
        for (int i = 0; i<n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);

            if ((x-a)*(x-a) + (y-b)*(y-b)<r*r){
                answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for (int i = 0; i < n; i++){
            double.TryParse(Console.ReadLine(), out double x);
            if (x < 30){
                answer += 0.2;
            }
        }
        Console.WriteLine($"answer: {answer}");
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 0; i< n; i++){
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            
            if ((x*x + y*y > r1*r1)&&(x*x + y*y < r2*r2)){
                answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double r = 0;
        for (int i = 0; i < n; i++){
            double.TryParse(Console.ReadLine(),  out r);
            if (r < norm){
                answer ++;
            }
        }              
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 0; i < n; i++){
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ( (x > 0) && (x < Math.PI) && (y>0) && (y < Math.Sin(x)) ){
                answer++;
            }
        }
        //Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        double x, y;
        for (int i = 0; i < n; i++){
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);

            if (x > 0 && y > 0){
                answer1++;
                Console.WriteLine(1);
            }
            if (x < 0 && y < 0){
                answer3++;
                Console.WriteLine(3);
            }
            if (x > 0 && y < 0){
                Console.WriteLine(4);
            }
            if (x < 0 && y > 0){
                answer3++;
                Console.WriteLine(2);
            }
        }
        Console.WriteLine($"first quarter: {answer1}, third quarter: {answer3}");
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x, y;
        double l = 1000000;
        for (int i = 1; i <= n; i++){
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (Math.Sqrt(x*x + y*y) < l){
                l = Math.Sqrt(x*x + y*y);
                answer = i;
            }
        }
        l = Math.Round(l, 2);
        Console.WriteLine($"point number {answer} that is {l} far away from (0, 0)");
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double r;
        for (int i = 0; i < n; i++){
            double.TryParse(Console.ReadLine(), out r);
            if (r < answer){
                answer = r;
            }
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int g1, g2, g3, g4;
        for (int i = 0; i < n; i++){
            int.TryParse(Console.ReadLine(), out g1);
            int.TryParse(Console.ReadLine(), out g2);
            int.TryParse(Console.ReadLine(), out g3);
            int.TryParse(Console.ReadLine(), out g4);
            if ( g1 > 3 && g2 > 3 && g3 > 3 && g4 > 3){
                answer++;
            }
        }
        Console.WriteLine($"answer: {answer}");
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        int g1, g2, g3, g4;
        for (int i = 0; i < n; i++){ 
            int.TryParse(Console.ReadLine(), out g1);
            int.TryParse(Console.ReadLine(), out g2);
            int.TryParse(Console.ReadLine(), out g3);
            int.TryParse(Console.ReadLine(), out g4);
            avg += g1 + g2 + g3 + g4;
            if (g1 == 2 || g2 == 2 || g3 == 2|| g4 == 2){
                answer++;
            }
        }
        avg /= n*4;
        Console.WriteLine($"{answer} students and the avg is {avg}");
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r > 0){
            switch (type){
                case 0:
                    answer = r*r;
                    break;
                case 1:
                    answer = Math.PI*r*r;
                    break;
                case 2:
                    answer = r*r*Math.Sqrt(3)*0.25;
                    break;
                default:
                    return answer;
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
        if (A > 0 && B > 0){
        switch (type){
            case 0:
                answer = A*B;
                break;
            case 1:
                answer = Math.Abs(A*A*Math.PI - B*B*Math.PI);
                break;
            case 2:
                double s = (A+B+B)/2;
                answer = Math.Sqrt(s*(s-A)*(s-B)*(s-B));
                break;
            default:
                return answer;

        }
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
        double x;
        string inp = Console.ReadLine();
        while (inp != "f"){
            double.TryParse(inp, out x);
            answer += x;
            inp = Console.ReadLine();
        }
        answer /= 10.0;
        Console.WriteLine(answer);
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
        string x_str, y_str;
        x_str = Console.ReadLine();
        y_str = Console.ReadLine();
        while (x_str != "f" && y_str != "f"){
            double.TryParse(x_str, out x);
            double.TryParse(y_str, out y);
            
            if ((x*x + y*y > r1*r1)&&(x*x + y*y < r2*r2)){
                answer++;
            }
            x_str = Console.ReadLine();
            y_str = Console.ReadLine();
        }
        Console.WriteLine(answer);
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
        double x, y;
        string x_str, y_str;
        x_str = Console.ReadLine();
        y_str = Console.ReadLine();
        while (x_str != "f" && y_str != "f"){
            double.TryParse(x_str, out x);
            double.TryParse(y_str, out y);
            
            if (x > 0 && y > 0){
                answer1++;
                Console.WriteLine(1);
            }
            if (x < 0 && y < 0){
                answer3++;
                Console.WriteLine(3);
            }
            if (x > 0 && y < 0){
                Console.WriteLine(4);
            }
            if (x < 0 && y > 0){
                answer3++;
                Console.WriteLine(2);
            }

            x_str = Console.ReadLine();
            y_str = Console.ReadLine();
        }
        Console.WriteLine($"first quarter: {answer1}, third quarter: {answer3}");
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
        int g1, g2, g3, g4;
        string G1, G2, G3, G4;
        G1 = Console.ReadLine();
        G2 = Console.ReadLine();
        G3 = Console.ReadLine();
        G4 = Console.ReadLine();
        
        while (G1 != "f" && G2 != "f" && G3 != "f" && G4 != "f"){
            int.TryParse(Console.ReadLine(), out g1);
            int.TryParse(Console.ReadLine(), out g2);
            int.TryParse(Console.ReadLine(), out g3);
            int.TryParse(Console.ReadLine(), out g4);
            if ( g1 > 3 && g2 > 3 && g3 > 3 && g4 > 3){
                answer++;
            }
            G1 = Console.ReadLine();
            G2 = Console.ReadLine();
            G3 = Console.ReadLine();
            G4 = Console.ReadLine();
        }
        Console.WriteLine($"answer: {answer}");
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
        while (type >= 0 && type <= 2 && A > 0 && B > 0){
            switch (type){
                case 0:
                    answer = A*B;
                    break;
                case 1:
                    answer = Math.Abs(A*A*Math.PI - B*B*Math.PI);
                    break;
                case 2:
                    double s = (A+B+B)/2;
                    answer = Math.Sqrt(s*(s-A)*(s-B)*(s-B));
                    break;
                default:
                    return answer;
                }   
            answer = Math.Round(answer, 2);
            Console.WriteLine(answer);
        }
        // end
        // answer should be equal to the task_2_13 answer

        return answer;
    }
    #endregion
}
