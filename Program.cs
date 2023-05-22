namespace SVNSkillFactory14
{
	///<summary>
	///4.3.16. Давайте модифицируем нашу предыдущую задачу для работы с двумерным массивом.
	///Необходимо найти количество положительных элементов массива.
	///</summary>
	internal class Program
    {
		static void Main(string[] args)
		{
			int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
			int nElems = 0;
			foreach(int i in arr)
            {
				nElems += i > 0 ? 1 : 0;
            }
            Console.WriteLine(nElems);
		}
    }
}