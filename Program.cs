namespace SVNSkillFactory14
{
	///<summary>
	///4.3.9. Проверьте, что будет, если вывести многомерный массив через цикл foreach?
	///</summary>
	internal class Program
    {
		static void Main(string[] args)
		{
			int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
			foreach (int i in array)
            {
				Console.Write($@"{i} ");
            }
		}
    }
}