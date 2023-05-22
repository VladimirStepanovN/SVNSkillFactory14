namespace SVNSkillFactory14
{
	///<summary>
	///4.3.15. Задайте одномерный массив и напишите алгоритм,
	///который находит в нем количество положительных чисел.
	///</summary>
	internal class Program
    {
		static void Main(string[] args)
		{
			var arr = new int[] { -5, 6, 9, -1, 2, -3, -4 };
			int nElems = 0;
			foreach(int elem in arr)
            {
				nElems += elem > 0 ? 1 : 0;
            }
            Console.WriteLine(nElems);
		}
    }
}