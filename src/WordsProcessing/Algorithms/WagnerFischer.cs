using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordsProcessing;

namespace WordsProcessing.Algorithms
{
    /// <summary>
    /// Реализует расчет расстояние Левенштейна по алгоритму Вагнера-Фишера
    /// </summary>
    public class WagnerFischer : ILevenshteinDistance
    {
        private List<List<int>> matrix;
        private int N;
        private int M;

        /// <summary>
        /// Возвращает и устанавливает вес удаления.
        /// </summary>
        public int DeletionWeight { get; set; }

        /// <summary>
        /// Возвращает и устанавливает вес замены.
        /// </summary>
        public int ReplacementWeight { get; set; }

        /// <summary>
        /// Возвращает и устанавливает вес вставки.
        /// </summary>
        public int InsertionWeight { get; set; }

        /// <summary>
        /// Инициализирует объект класса WagnerFischer и заполняет члены начальными значениями
        /// </summary>
        public WagnerFischer() 
        {
            matrix = new List<List<int>>();
            N = 0;
            M = 0;
            DeletionWeight = 2;
            ReplacementWeight = 1;
            InsertionWeight = 3;
        }

        /// <summary>
        /// Создаёт матрицу, используемую для расчета расстояния Левенштейна
        /// </summary>
        /// <param name="rowsCount">Количество строк в матрице</param>
        /// <param name="columnsCount">Количество столбцов в матрице</param>
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

        /// <summary>
        /// Заполняет матрицу, используемую для расчета расстояния Левенштейна,
        /// начальными значениями
        /// </summary>
        private void FillMatrix()
        {
            matrix[0][0] = 0;
            for (int i = 1; i < N; i++)
                matrix[i][0] = i * DeletionWeight;
            for (int i = 1; i < M; i++)
                matrix[0][i] = i * InsertionWeight;
        }

        /// <summary>
        /// Возвращает минимум из трёх чисел
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <param name="c">Третье число</param>
        /// <returns>Минимальное число</returns>
        private int Min(int a, int b, int c)
        {
            int min = (a < b) ? a : b;
            if (min < c)
                return min;
            return c;
        }

        /// <summary>
        /// Рассчитывает расстояние Левенштейна, используя алгоритм Вагнера-Фишера
        /// </summary>
        /// <param name="firstString">Первая строка</param>
        /// <param name="secondString">Вторая строка</param>
        /// <returns>Расстояние Левенштейна</returns>
        public int CalcLevenshteinDistance(string firstString, string secondString)
        {
            if (firstString == null || secondString == null)
                throw new ArgumentNullException();

            N = firstString.Length + 1;
            M = secondString.Length + 1;

            CreateMatrix(N, M);
            FillMatrix();

            for (int i = 1; i < N; i++)
            {
                for (int j = 1; j < M; j++)
                {
                    int diff = (firstString[i - 1] == secondString[j - 1]) ? 0 : ReplacementWeight;
                    matrix[i][j] = Min(matrix[i - 1][j] + DeletionWeight, matrix[i][j - 1] + InsertionWeight,
                            matrix[i - 1][j - 1] + diff);
                }
            }
            return matrix[N - 1][M - 1]; ;
        }
    }
}
