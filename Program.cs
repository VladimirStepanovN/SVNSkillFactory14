namespace SVNSkillFactory14
{
	///<summary>
	///4.3.17. Одной из нетривиальных задач является задача сортировки двумерного массива.
	///Как минимум, не слишком понятно, как же сортировать, есть ведь «строки» и «столбцы».
	///Как требуется проводить сортировку?
	///В данном случае давайте реализуем просто сортировку элементов массива внутри одной строки.
	///</summary>
	internal class Program
    {
		static void Main(string[] args)
		{
			int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
			//------------------------------вывод до-----------------------------------------------
			for(int i = 0; i < arr.GetUpperBound(0) + 1; i++)
			{
				for(int j = 0; j < arr.GetUpperBound(1) + 1; j++)
				{
                    Console.Write($@"{arr[i, j]} ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			Console.WriteLine();
			//------------------------------сортировка вставкой------------------------------------
			int inner, outer, row;
			for (row = 0; row < arr.GetUpperBound(0) + 1; row++)
			{
				int temp;
				for (outer = 1; outer < arr.GetUpperBound(1) + 1; outer++)
				{
					inner = outer;
					temp = arr[row, outer];
					while (inner > 0 && arr[row, inner - 1] >= temp)
					{
						arr[row, inner] = arr[row, inner - 1];
						--inner;
					}
					arr[row, inner] = temp;
				}					
			}
			//------------------------------вывод после--------------------------------------------
			for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
			{
				for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
				{
					Console.Write($@"{arr[i, j]} ");
				}
                Console.WriteLine();
			}
		}
    }
}