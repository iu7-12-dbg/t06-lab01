﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordsProcessing;

namespace WordsProcessing.Algorithms
{
    public class WagnerFischer : ILevenshteinDistance
    {
        private List<List<int>> matrix;
        private int N;
        private int M;

        private const int DELETE_WEIGHT = 2;
        private const int REPLACE_WEIGHT = 1;
        private const int INSERT_WEIGHT = 3;

        public WagnerFischer() 
        {
            matrix = new List<List<int>>();
            N = 0;
            M = 0;
        }

        private void CreateMatrix(int rowsCount, int columnsCount)
        {
            matrix.Clear();
            for (int i = 0; i < rowsCount; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j < columnsCount; j++)
                {
                    row.Add(0);
                }
                matrix.Add(row);
            }
        }

        private void FillMatrix()
        {
            matrix[0][0] = 0;
            for (int i = 1; i < N; i++)
                matrix[i][0] = i * DELETE_WEIGHT;
            for (int i = 1; i < M; i++)
                matrix[0][i] = i * INSERT_WEIGHT;
        }

        private int Min(int a, int b, int c)
        {
            int min = (a < b) ? a : b;
            if (min < c)
                return min;
            return c;
        }

        public int CalcLevenshteinDistance(string firstString, string secondString)
        {
            if (firstString.Length == 0 || secondString.Length == 0)
            {
                throw new NullReferenceException();
            }
            N = firstString.Length + 1;
            M = secondString.Length + 1;

            CreateMatrix(N, M);
            FillMatrix();

            for (int i = 1; i < N; i++)
            {
                for (int j = 1; j < M; j++)
                {
                    int diff = (firstString[i - 1] == secondString[j - 1]) ? 0 : REPLACE_WEIGHT;
                    matrix[i][j] = Min(matrix[i - 1][j] + DELETE_WEIGHT, matrix[i][j - 1] + INSERT_WEIGHT,
                            matrix[i - 1][j - 1] + diff);
                }
            }
            return matrix[N - 1][M - 1]; ;
        }
    }
}