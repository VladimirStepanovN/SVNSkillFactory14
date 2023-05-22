namespace SVNSkillFactory14
{
	///<summary>
	///4.3.14. Сделайте перебор данного массива массивов по аналогии с массивом строк.
	///</summary>
	internal class Program
    {
		static void Main(string[] args)
		{
			int[][] array = new int[3][];
			array[0] = new int[2] { 1, 2 };
			array[1] = new int[3] { 1, 2, 3 };
			array[2] = new int[5] { 1, 2, 3, 4, 5 };
			foreach(var arr in array)
            {
				foreach(int i in arr)
                {
                    Console.Write($@"{i} ");
                }
            }
		}
    }
}