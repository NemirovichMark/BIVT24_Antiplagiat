using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class Program
{
	public static void Main()
	{
		Program program = new Program();
		program.Task_3_11( new int[,] {
                { 1,    2,      -3,     7,      -5,     7,      7 },
                { 5,    6,      -7,     8,      9,      9,      -11 },
                { 9,    10,     11,     12,     13,     15,     15 },
                { -13,  0,      25,     25,     16,     0,      -19 },
                { -6,   -5,     -1,     -2,     -3,     -4,     0 }
            });

	}
	#region Level 1
	public int Task_1_1(int[,] A)
	{
		int answer = 0;
		// code here
		for(int i = 0; i< A.GetLength(0); ++i)
		{
			for (int j = 0; j < A.GetLength(1); ++j)
			{
				answer += A[i,j];
			}
		}
		// end

		return answer;
	}
	public double Task_1_2(int[,] A)
	{
		double answer = 0;
		// code here
		int n= 0 ;
		for(int i = 0;i< A.GetLength(0); ++i)
		{
			for (int j = 0; j < A.GetLength(1); ++j)
			{
				if (A[i, j] > 0)
				{
					answer += A[i, j];
					n++;
				}
			}
		}
		if (n != 0)
		{
			answer /= n;
		}
		else
		{
			answer = 0;
		}
		// end

		return answer;
	}
	public int Task_1_3(int[,] A)
	{
		int answer = 0;
		// code here
		for(int i = 0; i< A.GetLength(0); ++i)
		{
			answer += A[i, i];
		}

		// end

		return answer;
	}
	public (int, int) Task_1_4(int[,] A)
	{
		int row = 0, col = 0;
		// code here
		double mi = double.MaxValue;
		for(int i = 0; i<A.GetLength(0); ++i)
		{
			for(int j = 0; j < A.GetLength(1); ++j)
			{
				if (A[i, j] < mi)
				{
					mi = A[i, j];
					row = i;
					col = j;
				}
			}
		}
		// end

		return (row, col);
	}
	public (int, int) Task_1_5(int[,] A, int colIndex)
	{
		int value = 0, rowIndex = -1;
		if(A.GetLength(0) != 5 || A.GetLength(1)!= 4)
		{
			return (0,0);
		}
		// code here
		for (int i = 0; i < A.GetLength(0); ++i)
		{
			if (A[i, colIndex] < 0)
			{
				value = A[i, colIndex];
				rowIndex = i;
				break;
			}
			rowIndex = -1;
		}
		// end

		return (value, rowIndex);
	}
	public int[] Task_1_6(int[,] A)
	{
		int[] answer = default(int[]);
		// code here
		if(A.GetLength(0)!= 4 || A.GetLength(1)!= 7)
		{
			return answer;
		}
		answer = new int[A.GetLength(0)];
		for(int i = 0; i < A.GetLength(0); ++i)
		{
			double miel = A[i,0];
			int mi = 0;
			for(int j =0; j<A.GetLength(1); ++j)
			{
				if (A[i,j]  < miel)
				{
					miel = A[i,j];
					mi = j;
				}
			}
			answer[i] = mi;
		}
		// end

		return answer;
	}
	public int[] Task_1_7(int[,] A)
	{
		int[] answer = default(int[]);
		// code here
		if (A.GetLength(0) != 3 || A.GetLength(1)!= 5)
		{
			return answer;
		}
		answer = new int[A.GetLength(1)];
		for(int j = 0; j<A.GetLength(1);++j)
		{
			int ma = A[0,j];
			for(int i = 0; i<A.GetLength(0); ++i)
			{
				if (A[i,j] > ma)
				{
					ma = A[i,j];
				}
			}
			answer[j] = ma;
		}
		// end

		return answer;
	}
	public double[] Task_1_8(int[,] A)
	{
		double[] answer = default(double[]);
		// code here
		if(A.GetLength(0) != 4  || A.GetLength(1)!= 6)
		{
			return answer;
		}
		int n = 0;
		answer= new double[A.GetLength(0)];
		for(int i = 0; i<A.GetLength(0); i++)
		{
			n = 0;
			for( int j = 0; j< A.GetLength(1); ++j)
			{
				
				if (A[i,j] > 0)
				{
					answer[i] += A[i,j];
					n++;
				}
			}
			if (n != 0)
			{
				answer[i] /= n;
			} else
			{
				answer[i] = 0;
			}
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
		int mel = 1000000000, mi = 0;
		int[,] ans = default(int[,]);
		if(A.GetLength(0) != 5 || A.GetLength(1)!= 7)
		{
			return ans;
		}
		ans = new int[A.GetLength(0)-1,A.GetLength(1)];
		for(int i = 0; i< A.GetLength(0); i++)
		{
			if (A[i,0] < mel)
			{
				mel = A[i,0];
				mi = i;
			}
		}
		for(int i = 0; i<2; i++)
		{
			for(int j = 0;  j<A.GetLength(1); j++)
			{
				ans[i, j] = A[i, j];
			}
		}
		for(int i = mi+1; i<A.GetLength(0); i++)
		{
			for (int j = 0; j < A.GetLength(1); j++)
			{
				ans[i-1, j] = A[i, j];
			}
		}
		A = ans;
		for (int i = 0; i < A.GetLength(0); i++)
		{
			for (int j = 0; j < A.GetLength(1); j++)
				Console.Write("{0:d} ", A[i, j]);
			Console.WriteLine();
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
		int[] answer = default(int[]);
		// code here
		if (A.GetLength(0) != 4 || A.GetLength(1)!= 3)
		{
			return answer;
		}
		answer = new int [A.GetLength(1)];
		for(int j = 0; j< A.GetLength(1); ++j)
		{
			int n = 0;
			for(int i = 0; i< A.GetLength(0); ++i)
			{
				if(A[i, j] < 0)
				{
					n++;
				}
			}
			answer[j] = n;
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
		if (B.GetLength(0) != n ||  B.GetLength(1)!= m)
		{
			return B;
		}
		int miel = 10000000;
		int mi = 0;
		for(int i = 0; i< B.GetLength(0); ++i)
		{
			for(int j = 0;j< B.GetLength(1); ++j)
			{
				if(B[i, j] < miel)
				{
					miel = B[i, j];
					mi = j;
				}
			}
			if(mi != 0)
			{
				for(int j = mi; j >0; --j)
				{
					B[i,j] = B[i,j-1];
				}
				B[i, 0] = miel;
			}
			miel = int.MaxValue;
			mi = 0;
		}
		for(int i =0; i< B.GetLength(0); ++i)
		{
			for(int j = 0; j< B.GetLength(1); ++j)
			{
				Console.Write($"{B[i,j]} ");
			}
			Console.WriteLine();
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
		double mael = -10000000, fotr = 0, lotr = 0;
		int mind = 0;
		bool fl = false;
		for (int i = 0; i < F.GetLength(0); ++i)
		{
			for (int j = 0; j < F.GetLength(1); ++j)
			{
				if (F[i, j] > mael)
				{
					mael = F[i, j];
					mind = j;
				}
				if (F[i, j] < 0 && !fl)
				{
					fotr = F[i, j];
					fl = true;
				}
				if (F[i, j] < 0 )
				{
					lotr = F[i, j];
				}
			}
			if(fotr != 0 && lotr != 0)
			{
				F[i, mind] = (fotr + lotr) / 2;
				mind = 0;
				mael = -100000000;
				fotr = 0;
				lotr = 0;
				fl = false;
			}
			
		}
		for (int i = 0; i < F.GetLength(0); ++i)
		{
			for(int j = 0; j < F.GetLength(1); ++j)
			{
				Console.Write($"{F[i,j]} ");
			}
			Console.WriteLine();
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
		if(G.GetLength(0) < 5 || G.GetLength(1) > 7)
		{
			return null;
		}
		int maind;
		for(int i = 0; i < G.GetLength(0); i++)
		{
			maind = 0;
			for(int j = 0; j< G.GetLength(1); j++)
			{
				if (G[i,j]> G[i, maind])
				{
					maind = j;
				}
			}
			for(int j = G.GetLength(1)-1; j > maind; j--)
			{
				G[i,j] = G[i,j-1];
			}
		}
		for (int i = 0; i < G.GetLength(0); ++i)
		{
			for (int j = 0; j < G.GetLength(1); ++j)
			{
				Console.Write($"{G[i, j]} ");
			}
			Console.WriteLine();
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
		if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || B.Length != 7)
		{
			return null;
		}

		int mi = 0;
		for(int i = 0; i < A.GetLength(0); ++i)
		{
			if (A[i, 5] > A[mi, 5])
			{
				mi = i;
			}
		}

		for(int j = 0; j < 7; ++j)
		{
			A[mi, j] = B[j];
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
		if (F.GetLength(0) != 5 || F.GetLength(1)!= 7)
		{
			return null;
		}
		int mi = 0;
		for(int j = 0; j < F.GetLength(1); ++j)
		{
			if (F[2, j] < F[2, mi])
			{
				mi = j;
			}
		}
		mi += 1;
		int[,] mod = new int[5, 6];
		for(int i = 0; i < 5; ++i)
		{
			for(int j = 0; j < 6; ++j)
			{
				if(j < mi)
				{
					mod[i,j] = F[i,j];
				} else
				{
					mod[i,j] = F[i,j+1];
				}
			}
		}
		F = mod;
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
		if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
		{
			return null;
		}
		double meanpol;
		int mi,npol;
		for(int i = 0; i < A.GetLength(0); ++i)
		{
			meanpol = 0;
			mi = 0;
			npol = 0;
			for(int j = 0; j < A.GetLength(1); ++j)
			{
				if (A[i,j] > A[i, mi])
				{
					mi = j;
				}
				if (A[i,j] > 0)
				{
					meanpol += A[i,j];
					npol++;
				}
			}
			if(npol != 0)
			{
				meanpol /= npol;
			}
			A[i,mi]= meanpol; 
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
		int n = A.GetLength(0) ,m = A.GetLength(1);
		if(n != 5 || m != 7)
		{
			return null;
		}
		int mi;
		for (int i = 0; i < n; ++i)
		{
			mi = 0;
			for (int j = 0; j < m; ++j)
			{
				if (A[i, j] > A[i, mi])
				{
					mi = j;
				}
			}
			if (mi == m-1)
			{
				A[i,mi-1] *= 2;
			} else if(mi == 0)
			{
				A[i, mi + 1] *= 2;
			} else
			{
				if (A[i,mi-1] > A[i, mi + 1])
				{
					if(A[i, mi + 1] < 0)
					{
						A[i, mi + 1] *= 0.5;
					} else
					{
						A[i, mi + 1] *= 2;
					}

				} else
				{
					if (A[i, mi - 1] < 0)
					{
						A[i, mi - 1] *= 0.5;
					}
					else
					{
						A[i, mi - 1] *= 2;
					}
				}
			}
		}
		for(int i = 0; i < n; ++i)
		{
			for(int j = 0; j < m; j++)
			{
				Console.Write($"{A[i,j]} ");
			}
			Console.WriteLine();
		}
		// end

		return A;
	}

	public int[,] Task_2_2(int[,] A)
	{
		// code here
		int n = A.GetLength(0);
		int m = A.GetLength(1);
		if(n != 7 || m != 5)
		{
			return null;
		}
		int mi,cpol,cotr;
		for(int j = 0; j < m; ++j)
		{
			mi = 0;
			cpol = 0;
			cotr = 0;
			for(int i = 0; i < n; ++i)
			{
				if (A[i,j]> 0)
				{
					cpol++;
				}
				if (A[i,j] < 0)
				{
					cotr++;
				}
				if (A[i, j] > A[mi, j])
				{
					mi = i;
				}
			}
			if (cpol > cotr)
			{
				A[mi, j] = 0;
			}
			else
			{
				A[mi, j] = mi + 1;
			}
		}
		for (int i = 0; i < n; ++i)
		{
			for (int j = 0; j < m; j++)
			{
				Console.Write($"{A[i, j]} ");
			}
			Console.WriteLine();
		}
		// end

		return A;
	}
	public int[,] Task_2_3(int[,] A)
	{
		// code here
		int n = A.GetLength(0);	
		int m = A.GetLength(1);
		if(n!=10 || m != 5)
		{
			return null;
		}

		int mi, sma;
		for(int j = 0; j < m; ++j)
		{
			mi = 0;
			sma = 0;
			for(int i = 0; i < n; i++)
			{
				if (A[i,j] > A[mi, j])
				{
					mi = i;
				}
			}
			if(mi <= n / 2)
			{
				for(int i = mi+1; i < n; ++i)
				{
					sma += A[i, j];
				}
				A[0,j] = sma;
			}
		}
		// end

		return A;
	}
	public int[,] Task_2_4(int[,] A, int[] B)
	{
		// code here
		int n = A.GetLength(0);
		int m = A.GetLength(1);
		if( n != 7 || m != 5)
		{
			return null;
		}
		if( B.Length != 5)
		{
			return null;
		}
		int mi;
		for(int j = 0; j < m; ++j) {
			mi = 0;
			for(int i = 0; i < n; ++i)
			{
				if (A[i,j]> A[mi, j])
				{
					mi = i;
				}
			}
			if (B[j] > A[mi, j])
			{
				A[mi,j]  = B[j];
			}
		}
		// end

		return A;
	}
	public double[,] Task_2_5(double[,] A)
	{
		// code here
		int n = A.GetLength(0), m = A.GetLength(1);
		if(n != 7 || m != 5)
		{
			return null;
		}

		int mi;
		for(int j = 0; j < m; ++j)
		{
			mi = 0;
			for(int i = 0; i < n; ++i)
			{
				if (A[i,j] > A[mi, j])
				{
					mi = i;
				}
			}
			if (A[mi,j]< (A[0, j] + A[n-1, j]) / 2)
			{
				A[mi, j] = (A[0, j] + A[n-1, j]) / 2;
			}
			else
			{
				A[mi, j] = mi + 1;
			}
		}
		// end

		return A;
	}
	public int[,] Task_2_6(int n)
	{
		int[,] answer = default(int[,]);
		// code here
		if(n  <= 0)
		{
			return null;
		}
		answer = new int[n, 3 * n];
		int m = answer.GetLength(1);
		for(int j = 0; j < m; ++j)
		{
			for(int i =0; i < n; ++i)
			{
				if(i == j % n)
				{
					answer[i, j] = 1;
				} else
				{
					answer[i, j] = 0;
				}
			}
		}
		// end

		return answer;
	}
	public int[,] Task_2_7(int[,] A)
	{
		// code here
		int n = A.GetLength(0);
		int m = A.GetLength(1);	
		if(n != 6 || m != 6)
		{
			return null;
		}
		int mi = 0;
		for(int i = 0; i < n; ++i)
		{
			if (A[i,i] > A[mi, mi])
			{
				mi = i;
			}
		}
		for(int i = 0; i < mi; ++i)
		{
			for(int j = i+1; j < n; ++j)
			{
				A[i, j] = 0;
			}
		}
		// end

		return A;
	}
	public int[,] Task_2_8(int[,] B)
	{
		// code here
		int n = B.GetLength(0);
		int m = B.GetLength(1);
		if (n != 6 || m != 6)
		{
			return null;
		}
		int mi, mi2;
		for(int i = 0;i < n; i += 2)
		{
			mi = 0;
			mi2 = 0;
			for(int j =0; j < n; ++j)
			{
				if (B[i,j] > B[i, mi])
				{
					mi = j;
				}
				if (B[i+1,j] > B[i+1, mi2])
				{
					mi2 = j;
				}
			}
			int t  = B[i,mi];
			B[i,mi] = B[i+1,mi2];
			B[i+1,mi2] = t;
		}
		// end

		return B;
	}
	public int[,] Task_2_9(int[,] A)
	{
		// code here
		int n = A.GetLength(0);
		int m = A.GetLength(1);
		if (n != 6 || m != 7)
		{
			return null;
		}
		for(int i = 0; i < n; ++i)
		{
			for(int j =0; j < m/2; ++j)
			{
				int t  = A[i,j];
				A[i, j] = A[i, m - j-1];
				A[i, m-j-1] = t;
			}
		}
		// end

		return A;
	}
	#endregion
	#region Level 3
	public int[,] Task_3_1(int[,] matrix)
	{
		// code here
		int n = matrix.GetLength(0);
		int m = matrix.GetLength(1);
		if( n!= 7 || m != 5)
		{
			return null ;
		}
		int[] mins = new int[n];
		int[] mind = new int[] {0,1,2,3,4,5,6};
		for(int i = 0; i < n; ++i)
		{
			mins[i] = 0;
			for(int j = 0; j < m; ++j)
			{
				if(matrix[i,j] < matrix[i, mins[i]])
				{
					mins[i] = j;
				}
			}
		}
		for(int i = 0; i < n; ++i)
		{
			for(int j = 0; j < n-i-1; ++j)
			{
				if (matrix[mind[j],mins[j]] < matrix[mind[j+1],mins[j + 1]])
				{
					int t= mins[j];
					mins[j] = mins[j+1];
					mins[j+1] = t;
					t = mind[j];
					mind[j] = mind[j+1];
					mind[j+1] = t;
				}
			}
		}
		int[,] nm = new int[n, m];
		for(int i = 0; i < n; ++i)
		{
			for(int j = 0;j < m; ++j)
			{
				nm[i, j] = matrix[mind[i], j];
			}
		}
		matrix = nm;
		for(int i = 0; i < n; ++i)
		{
			for(int j = 0; j <m; ++j)
			{
				Console.Write($"{matrix[i,j]} " );
			}
			Console.WriteLine();
		}

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
		int[] answer = default(int[]);
		// code here
		int n = matrix.GetLength(0);
		int m = matrix.GetLength(1);
		if(n != m) {
			return null;	
		}
		answer = new int[2 * n - 1];
		int cntr = 1;
		for (int i = 0; i < 2 * n - 1; i++)
		{
			int cds = 0;

			if (i < n)
			{
				for (int di = n - i - 1, dj = 0; di < n; di++, dj++)
				{
					cds += matrix[di, dj];
				}
			}
			else
			{
				for (int di = 0, dj = i - n + 1; dj < n; di++, dj++)
				{
					cds += matrix[di, dj];
				}
			}
			answer[i] = cds;
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
		int max = 0, ii = 0, jj = 0, t = 0;
		int n = matrix.GetLength(0);
		if (matrix.GetLength(0) == matrix.GetLength(1) && k <= n && k >= 1)
		{
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (Math.Abs(matrix[i, j]) > Math.Abs(max))
					{
						max = matrix[i, j];
						ii = i;
						jj = j;
					}
				}
			}
			for (int i = 0; i < n; i++)
			{
				t = matrix[ii, i];
				matrix[ii, i] = matrix[k - 1, i];
				matrix[k - 1, i] = t;
			}
			for (int i = 0; i < n; i++)
			{
				t = matrix[i, jj];
				matrix[i, jj] = matrix[i, k - 1];
				matrix[i, k - 1] = t;
			}
		}
		else
		{
			matrix = default(int[,]);
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
		int[] answer = default(int[]);

		// code here
		if (A.Length != (n * (n + 1) / 2) && B.Length != (n * (n + 1) / 2))
		{
			return null;
		}
		answer = new int[n*n];
		int[,] matra = new int[n, n];
		int[,] matrb = new int[n, n];
		int[,] rm  = new int[n, n];
		int pos = 0;
		for(int i = 0; i < n; ++i)
		{
			for(int j = i; j < n; ++j)
			{
				matra[i, j] = A[pos];
				matra[j,i]  = A[pos];
				matrb[i, j] = B[pos];
				matrb[j,i] = B[pos];
				pos++;
			}
		}
		for(int i =0; i < n; ++i)
		{
			for(int j =0; j < n; ++j)
			{
				for(int k = 0; k < n; ++k)
				{
					rm[i, j] += matra[i, k] * matrb[k, j];
				}
				answer[j + i * n] = rm[i, j];
			}
		}
		for(int i = 0; i < n*n; ++i)
		{
			Console.Write(answer[i]  + " " );
		}
		// end

		return answer;
	}
	public int[,] Task_3_8(int[,] matrix)
	{
		// code here
		// end

		return matrix;
	}
	public int[,] Task_3_9(int[,] matrix)
	{
        // code here
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        if (n != 5 || m != 7)
        {
            return null;
        }
        int neg;
        int pos = 0, t = 0;
        int[] negs = new int[m];
        for (int j = 0; j < m; ++j)
        {
            neg = 0;
            for (int i = 0; i < n; ++i)
            {
                if (matrix[i, j] < 0)
                {
                    neg++;
                }
            }
            negs[j] = neg;
        }

        for (int j = 0; j < m; ++j)
        {
            for (int i = 0; i < n; ++i)
            {
                if (negs[i] > negs[i + 1])
                {
                    t = negs[i];
                    negs[i] = negs[i + 1];
                    negs[i + 1] = t;
                    for (int k = 0; k < n; ++k)
                    {
                        t = matrix[k, i];
                        matrix[k, i] = matrix[k, i + 1];
                        matrix[k, i + 1] = t;
                    }
                }
            }
        }
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < m; ++j)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
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
		int n = matrix.GetLength(0);
		int m = matrix.GetLength(1);
		int[] zeros = new int[n];
		bool fl;
		for(int i = 0; i < matrix.GetLength(0); ++i)
		{
			fl = true;
			for(int j = 0; j < matrix.GetLength(1); ++j)
			{
				if (matrix[i, j] == 0)
				{
					n--;
					fl = false;
					break;
				}
			}
			if (fl)
			{
				zeros[i] = 1;
			}
		}
		int[,] nm = new int[n,matrix.GetLength(1)];
		int k = 0;
		for(int i =0; i < matrix.GetLength(0); ++i)
		{
			for(int j = 0;j < matrix.GetLength(1); ++j)
			{
				if(zeros[i] == 1)
				{
					nm[k,j] = matrix[i,j];
				}
			}
			k++;
		}
		matrix = nm;
		for(int i = 0;i < matrix.GetLength(0); ++i)
		{
			for(int j=  0; j < matrix.GetLength(1); ++j)
			{
				Console.Write(matrix[i,j]+ " ");
			}
			Console.WriteLine();
		}
		// end

		return matrix;
	}
	#endregion
}