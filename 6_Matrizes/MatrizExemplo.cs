﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AlgoritmosELogicaCsharp._6_Matrizes
//{
//    internal class MatrizExemplo
//    {
//        static void Main(string[] args) {
//            int M, N;
//            int[,] A;
//            string[] s1 = Console.ReadLine().Split(' ');
//            M = int.Parse(s1[0]);
//            N = int.Parse(s1[1]);
//            A = new int[M, N];

//            for (int i = 0; i <M; i++) {
//                string[] s = Console.ReadLine().Split(' ');
//                for (int j = 0; j < N; j++)
//                {
//                    A[i,j] = int.Parse(s[j]);
                
//                }
            
//            }
//            for (int i =0; i<M; i++) {
//                for (int j = 0; j < N; j++) { 
//                Console.WriteLine(A[i,j] + " ");
//                }

//                Console.WriteLine();
//            }
        
//        }
//    }
//}
