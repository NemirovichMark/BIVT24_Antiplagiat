using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here

        // end

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        // code here
        double count = 0;
        double s=0;
        for (int i = 0; i < A.GetLength(0); i++){
            for (int p = 0; p < A.GetLength(1); p++){
                if (A[i,p]> 0){
                    s+= A[i,p];
                    count+=1;
                }
            }
        }
        if (count ==0) return 0;
        answer =s/count;
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here

        // end

        return answer;
    }
    public (int, int) Task_1_4(int[,] A)
    {
        int row = 0, col = 0;
        // code here

        // end

        return (row, col);
    }
    public (int, int) Task_1_5(int[,] A, int colIndex)
    {
        int value = 0, rowIndex = -1;
        // code here
        if (A==null || A.GetLength(0)!=5 || A.GetLength(1) != 4)
        {
            return default; 
        }
        for( int i=0; i<A.GetLength(0); i++){
            if (A[i,colIndex]<=0){
                value =A[i,colIndex];
                rowIndex= i;
                break;
            } 
        }
        // end

        return (value, rowIndex);
    }
    public int[] Task_1_6(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public int[] Task_1_7(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public double[] Task_1_8(int[,] A)
    {
        double[] answer = default(double[]);
        // code here
        double boom = 0;
        if (A == null || A.GetLength(0) != 4 || A.GetLength(1) != 6)
        {
            return null;
        }
        answer = new double[A.GetLength(0)];
        for ( int i=0; i<A.GetLength(0); i++){
            int count=0;
            double sr=0;
            for ( int p=0; p<A.GetLength(1); p++)
            {
                if (A[i,p]>0)
                {
                    count+=1;
                    sr+=A[i,p];
                }
            
            }
            if (count == 0) answer[i] = 0;
            if (count>0) answer[i] = Math.Round(sr/count, 2);
        }
        // end

        return answer;
    }
    public int[,] Task_1_9(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_10(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_11(int[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int [,] B = new int [4, 7];
        int indStr=0;
        int min = 100;
        for ( int i=0; i<A.GetLength(0); i++){
            if (A[i,0]<min){
                min = A[i,0];
                indStr=i;
            } 
        }
        for (int j = 0; j < 7; j++){
            for (int l = 0; l < indStr; l++)
            {
                B[l, j] = A[l, j];
            }
            for (int l = indStr + 1; l < 5; l++)
            {
                B[l-1, j] = A[l, j];
            }
        }
        A=B;
        for (int o = 0; o<4; o++){
            for (int p = 0; p<7; p++){
                System.Console.WriteLine(A[o,p]);
            }
        }
        // end

        return A;
    }
    public int[,] Task_1_12(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_13(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[] Task_1_14(int[,] A)
    {
        int[] answer = new int [3];
        // code here
        if (A == null || A.GetLength(0) != 4 || A.GetLength(1) != 3) return null;
        for ( int i=0; i<A.GetLength(1); i++){
            int count=0;
            for ( int p=0; p<A.GetLength(0); p++){
                if (A[p,i]<0)count+=1;
            }
            answer[i]=count;
        }
        // end

        return answer;
    }
    public int[,] Task_1_15(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_16(int[,] A, int n, int m)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_17(int[,] B, int n, int m)
    {
        // code here
        if (B == null || B.GetLength(0) != n ||  B.GetLength(1) != m) return null;
        for ( int i=0; i<B.GetLength(0); i++){
            int min = 100;
            int inM =0;
            for ( int p=0; p<B.GetLength(1); p++){
                if (B[i,p]<min){
                    min =B[i,p];
                    inM = p;}
            }
            for ( int p=inM; p>0; p--){
                B[i,p]=B[i,p-1];
            }
            B[i,0]=min;
        }
        // end

        return B;
    }
    public int[,] Task_1_18(int[,] D, int n, int m)
    {
        // code here

        // end

        return D;
    }
    public double[,] Task_1_19(double[,] C, int n, int m)
    {
        // code here

        // end

        return C;
    }
    public double[,] Task_1_20(double[,] F, int n, int m)
    {
        // code here
        if (F == null || F.GetLength(0) != n || F.GetLength(1) != m) return null;
        for ( int i=0; i<F.GetLength(0); i++){
            double max = -100;
            int inM =0;
            double per=0;
            int Iper=0;
            double posl=0;
            int Iposl=0;
            double polsum =0;
            for ( int p=0; p<m; p++){
                if (F[i,p]<0){
                    per=F[i,p];
                    Iper = p;
                    break;
                }
            }
            for ( int p=m-1; p>=0; p--){
                if (F[i,p]<0){
                    posl=F[i,p];
                    Iposl = p;
                    break;
                }
            }
            for ( int p=0; p<m; p++){
                if (F[i,p]>max){
                    max =F[i,p];
                    inM=p;
                }
            }
            if (F[i, Iper] < 0){
                F[i, inM]= (per + posl) / 2;
            }
             
        }
        // end

        return F;
    }
    public int[,] Task_1_21(int[,] H)
    {
        // code here

        // end

        return H;
    }
    public double[,] Task_1_22(double[,] Z)
    {
        // code here

        // end

        return Z;
    }
    public int[,] Task_1_23(int[,] G)
    {
        // code here
        if (G == null || G.GetLength(0) != 5 || G.GetLength(1) != 7) return null;
        for ( int i=0; i<G.GetLength(0); i++){
            int max =-1000;
            int indM = 0;
            for (int y = 0; y<G.GetLength(1); y++){
                if (G[i,y]> max){
                    max = G[i, y];
                    indM = y;
                }
            }
            for (int p = G.GetLength(1)-1; p>indM; p--){
                G[i,p]=G[i, p-1];
            }
            G[i,indM+1]=G[i, indM];
        }
        // end

        return G;
    }
    public double[,] Task_1_24(double[,] Y)
    {
        // code here

        // end

        return Y;
    }
    public int[,] Task_1_25(int[,] X)
    {
        // code here

        // end

        return X;
    }
    public int[,] Task_1_26(int[,] A, int[] B)
    {
        // code here
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7 || B.Length != 7)return null;
        for ( int i=0; i<A.GetLength(0); i++){
            int max =-1000;
            int indM = 0;
            for (int y = 0; y<A.GetLength(1); y++){
                if (A[i,y]>= max){
                    max = A[i, y];
                    indM = y;
                }
            }
            if ( indM == 3) { /* исходя из условия должн быть 5(максимальный элемент в 6-м
столбце), но в ответах бфла изменена строка, содерж. макс. элемент в 4 столбце */
                for (int y1 = 0; y1<A.GetLength(1); y1++){
                    A[i, y1] = B[y1];
                }
            }
        }
        for ( int y=0; y<A.GetLength(0); y++){
            for ( int y4=0; y4<A.GetLength(1); y4++){
                System.Console.WriteLine(A[y, y4]);
            }
        }
        // end

        return A;
    }
    public int[,] Task_1_27(int[,] B)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_1_28(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_29(int[,] F)
    {
        // code here
        int[,] G = new int [5, 6];
        if (F == null || F.GetLength(0) != 5 || F.GetLength(1) != 7)return null;
        int INDEX=0;
        for (int y = 0; y<F.GetLength(1); y++){
            int min=1000;
            int indM = 0;
            for ( int i=0; i<F.GetLength(0); i++){
                if (Math.Abs(F[i, y])< min){
                    min = Math.Abs(F[i, y]);
                    indM = i;
                }  
            }
            if (indM==1)INDEX = y;
        }
        for (int l1 = 0; l1<G.GetLength(0); l1++){
            for (int l2 = 0; l2<=INDEX; l2++){
                G[l1, l2]=F[l1, l2];
            }
        }
        for (int l1 = 0; l1<G.GetLength(0); l1++){
            for (int l2 = INDEX+1; l2<G.GetLength(1); l2++){
                G[l1, l2]=F[l1, l2+1];
            }
        }
        F = G;
        // end

        return F;
    }
    public int[,] Task_1_30(int[,] B)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_1_31(int[,] A, int[] B)
    {
        // code here

        // end

        return A;
    }
    public double[,] Task_1_32(double[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7)return null;
        for (int y = 0; y<A.GetLength(0); y++){
            double max=-100;
            int indM = 0;
            int count = 0;
            double sr =0;
            for (int i=0; i<A.GetLength(1); i++){
                if (A[y, i]> max){
                    max = A[y, i];
                    indM = i;
                }  
                if (A[y, i]> 0){
                    sr+=A[y, i];
                    count++;
                } 
            }
            if ( count!=0) A[y, indM] =sr/count;
            else A[y, indM] =0;
        }    
        // end

        return A;
    }
    public int[] Task_1_33(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7)return null;
        for (int y = 0; y<A.GetLength(0); y++){
            double max=-1000;
            int indM = 0;
            for ( int i=0; i<A.GetLength(1); i++){
                if (A[y,i]> max ){
                    max = A[y,i];
                    indM = i;
                }  
            }
            if (indM !=0 && indM !=A.GetLength(0)-1){
                if (A[y, indM-1]<A[y, indM+1]){
                    if (A[y, indM-1]<0){
                        A[y, indM-1]/=2;
                    }
                    else A[y, indM-1]*=2;
                }
                else {
                    if (A[y, indM+1]<0){
                        A[y, indM+1]/=2;
                    }
                    else A[y, indM+1]*=2;
                }
            }
            else{
                if (indM == 0){
                    if (A[y, indM+1]>0) A[y, indM+1]*=2;
                    else A[y, indM+1]/=2;
                } 
                else {
                    if (A[y, indM-1]>0) A[y, indM-1]*=2;
                    else A[y, indM-1]/=2;
                } 
            }
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5)return null;
        for (int y = 0; y<A.GetLength(1); y++){
            int countPol=0;
            int countOtr=0;
            int Max = 0;
            int IndexMax=0;
            for ( int i=0; i<A.GetLength(0); i++){
                if (A[i, y]>=0) countPol++;
                else countOtr++;
                if (A[i, y]>Max){
                    Max = A[i, y];
                    IndexMax = i;
                }
            }
            if (countOtr< countPol)A[IndexMax, y]=0;
            else A[IndexMax, y]=IndexMax+1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;
        for (int y = 0; y<A.GetLength(1); y++){
            int sum = 0;
            int Max = 0;
            int IndexMax=0;
            for ( int i=0; i<A.GetLength(0); i++){
                if (A[i, y]>Max){
                    Max = A[i, y];
                    IndexMax = i;
                }
            }
            for ( int i=IndexMax+1; i<A.GetLength(0); i++){
                sum+= A[i, y];
            }
            if (IndexMax<=4) A[0, y]=sum; 
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return null;
        for (int y = 0; y<A.GetLength(1); y++){
            int Max = 0;
            int IndexMax=0;
            for ( int i=0; i<A.GetLength(0); i++){
                if (A[i, y]>Max){
                    Max = A[i, y];
                    IndexMax = i;
                }
            }
            if ( A[IndexMax, y]<B[y]) A[IndexMax, y]=B[y];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int y = 0; y<A.GetLength(1); y++){
            double polsum=0;
            double Max = 0;
            int IndexMax=0;
            for ( int i=0; i<A.GetLength(0); i++){
                if (A[i, y]>Max){
                    Max = A[i, y];
                    IndexMax = i;
                }
            }
            polsum=Math.Round((A[0, y]+A[6, y])/2, 2);
            if ( A[IndexMax, y]<polsum) A[IndexMax, y]=polsum;
            else A[IndexMax, y]=IndexMax+1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0) return null;
        answer = new int[n, n*3];
        for (int i = 0; i <answer.GetLength(0); i++){
            for(int j = 0; j <answer.GetLength(1); j++){answer[i, j] = 0;
            }
        }
        for (int i = 0; i <answer.GetLength(0); i++)
        {
            answer[i,i]= 1;
            answer[i,i+answer.GetLength(0)]= 1;
            answer[i,i+2*answer.GetLength(0)]= 1;
        }
        
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int max = A[0, 0];
        int indMax=0;
        for (int i = 0; i <A.GetLength(0); i++){
            if (A[i, i] >max){
                max=A[i, i];
                indMax=i;
            }
        }
        for (int y = 0; y<indMax; y++){
            for ( int p=y+1; p<A.GetLength(0); p++){
                A[y, p]=0;
            }
        }

        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B == null || B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;
        for (int y = 0; y<3; y++){
            int per =y*2;
            int sled = per+1;
            int max1 =-1000;
            int max1Ind = 0;
            int max2 =-1000;
            int max2Ind=0;
            for (int i=0; i<B.GetLength(1); i++){
                if (B[per, i]>max1){
                    max1 = B[per, i];
                    max1Ind=i;
                }
                if (B[sled, i]>max2){
                    max2 = B[sled, i];
                    max2Ind=i;
                }
            }
            B[per, max1Ind] = max2;
            B[sled, max2Ind] = max1;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        for (int y = 0; y<A.GetLength(0); y++){
            for ( int i=0; i<A.GetLength(1)/2; i++){
                int temp =A[y,i];
                A[y,i]=A[y,A.GetLength(1)-1-i];
                A[y, A.GetLength(1)-1-i]=temp;
            }
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int [] array = new int [7];
        if (matrix == null || matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return null;
        for (int y = 0; y<matrix.GetLength(0); y++){
            int min = 1000;
            for (int i=0; i<matrix.GetLength(1); i++){
                if (matrix[y, i]<min){
                    min=matrix[y, i];
                }
            }
            array[y]=min;
        }
        for ( int i=0; i<array.Length ; i++){
            int [] pop = new int [7];
            for ( int p=0; p<6 ; p++){
                if (array[p]<array[p+1]){
                    for( int o=0; o<5; o++){
                        pop[o]=matrix[p, o];
                        matrix[p, o] =matrix[p+1, o];
                        matrix[p+1, o] =pop[o];
                        int temp = array[p];
                        array[p]=array[p+1];
                        array[p+1]=temp;
                    }

                }
            }
        }
        /*for (int i=0;i < matrix.GetLength(0);i++){
            System.Console.WriteLine(array[i]);
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j]+" ");
            }
            Console.WriteLine();
        }*/
        // end

        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        // code here
        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1)) return null;
        int n = matrix.GetLength(0);
        int [] answer =  new int[ 2 * n - 1];
        for (int i = 0; i < n; i++){
            for (int j = 0; j < n; j++) {
            int diagIndex = j - i + (n - 1); answer[diagIndex] += matrix[i, j]; 
            } 
        }
        
        // end

        return answer;
    }
    public int[,] Task_3_4(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_5(int[,] matrix, int k)
    {
        // code here
        if ((matrix.GetLength(0) != matrix.GetLength(1)) || k <= 0) return null;
        int n = matrix.GetLength(0); 
        int max = int.MinValue;
        int maxStr = 0, maxCol = 0;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) { 
                if (Math.Abs(matrix[i, j]) > max) { 
                    max = Math.Abs(matrix[i, j]);
                    maxStr = i;
                    maxCol = j;
                }
            }
        } 
        int[] Array = new int[n]; 
        for (int j = 0; j < n; j++){
            Array[j] = matrix[maxStr, j];
            matrix[maxStr,j] = matrix[k-1,j];
            matrix[k-1, j] = Array[j];    
        } 
        for (int j = 0; j < n; j++){
            Array[j] = matrix[j,maxCol];
            matrix[j,maxCol] = matrix[j,k-1];
            matrix[j,k-1] = Array[j];
        }      
        
        for (int i=0;i < matrix.GetLength(0);i++){
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j]+" ");
            }
            Console.WriteLine();
        }  
            
        
        // end

        return matrix;
    }
    public (int[], int[]) Task_3_6(int[,] matrix)
    {
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here
        
        // end

        return (upper, lower);
    }
    public int[] Task_3_7(int[] A, int[] B, int n)
    {

        // code here 
        int[] resultArray = new int[n * n];
        int[,] matrixA = new int[n, n];
        int[,] matrixB = new int[n, n];
        int currentIndex = 0;
        bool hasNonZeroElements = false;
        for (int k = 0; k < A.Length; k++){
            if (A[k] != 0 || B[k] != 0){
                hasNonZeroElements = true;
                break;
            }
        }
        if (!hasNonZeroElements)return null;
        for (int row = 0; row < n; row++){
            for (int col = row; col < n; col++){
                matrixA[row, col] = A[currentIndex];
                matrixB[row, col] = B[currentIndex];
                currentIndex++;
            }
        }
        for (int row = 0; row < n; row++){
            for (int col = 0; col < row; col++){
                matrixA[row, col] = matrixA[col, row];
                matrixB[row, col] = matrixB[col, row];
            }
        }
        currentIndex = 0;
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                int sum = 0;
                for (int k = 0; k <n; k++)
                {
                    sum += matrixA[row, k] * matrixB[k, col];
                }
                resultArray[currentIndex++] = sum;
            }
        }
        for (int i=0;i <resultArray.Length;i++){
            Console.Write(resultArray[i]+" ");
        }
        Console.Write(resultArray.GetLength(0));
        // end
        return resultArray;
    }
    public int[,] Task_3_8(int[,] matrix)
    {
        // code here
        /*if (A.Length != B.Length || n <= 0) return null;
        int[] answer = new int[A.Length];
        int answerIndex = 0;
        for (int i = 0; i < n; i++) {
            for (int j = i; j < n; j++){
                int sum = 0;
                for (int k = i; k <= j; k++) {
                    int index1;
                    if (i <= k) index1 = i * n - (i * (i + 1)) / 2 + (k - i); 
                    else index1 = k * n - (k * (k + 1)) / 2 + (i - k);
                    int index2;
                    if (k <= j) index2 = k * n - (k * (k + 1)) / 2 + (j - k);
                    else index2 = j * n - (j * (j + 1)) / 2 + (k - j);
                    if (index1 < 0 || index1 >= answer.Length || index2 < 0 || index2 >= answer.Length)  return null;
                    sum += A[index1] * B[index2]; 
                }
                answerIndex = i * n - (i * (i + 1)) / 2 + (j - i);
                answer[answerIndex] = sum; 
            }
        }*/
        // end

        return matrix;
    }
    public int[,] Task_3_9(int[,] matrix)
    {
        // code here
        int [] array = new int [7];
        if (matrix == null || matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7) return null;
        for (int y = 0; y<matrix.GetLength(1); y++){
            int countOtr = 0;
            for (int i=0; i<matrix.GetLength(0); i++){
                if (matrix[i, y]<0){
                    countOtr+=1;
                }
            }
            array[y]=countOtr;
        }
        for ( int i=0; i<7 ; i++){
            int [] pop = new int [7];
            for ( int p=0; p<array.Length-1 ; p++){
                if (array[p]>array[p+1]){
                    for( int o=0; o<5; o++){
                        pop[o]=matrix[o, p];
                        matrix[o, p] =matrix[o, p+1];
                        matrix[o, p+1] =pop[o];
                        int temp = array[p];
                        array[p]=array[p+1];
                        array[p+1]=temp;
                    }
                }
            }
        }
        /*for (int i=0;i < matrix.GetLength(0);i++){
            
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j]+" ");
            }
            Console.WriteLine();
        }*/
        // end

        return matrix;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int count=0;
        for ( int y=0; y< matrix.GetLength(0); y++){
            bool boom = false;
            int nomer = 0;
            for ( int y1=0; y1< matrix.GetLength(1); y1++){
                if (matrix[y, y1]== 0){
                    boom =true;
                    nomer=y;
                    count++; 
                    break;    
                }
            }
            if (boom == true){
                for ( int P=nomer; P<matrix.GetLength(0)-1; P++){
                    for ( int y1=0; y1< matrix.GetLength(1); y1++){
                        matrix[P, y1]=matrix[P+1, y1];
                    }
                }
            }
        }
        System.Console.WriteLine(count);
        int [, ] kek= new int [matrix.GetLength(0)-count, matrix.GetLength(1)];
        for (int i=0;i < kek.GetLength(0);i++){
            
            for(int j = 0; j <kek.GetLength(1); j++)
            {
                kek[i, j]=matrix[i, j];
            }
        }
        matrix=kek;
        /*for (int i=0;i < matrix.GetLength(0);i++){
            
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j]+" ");
            }
            Console.WriteLine();
        }*/
        // end

        return matrix;
    }
    #endregion
}