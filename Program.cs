namespace SVNSkillFactory14
{
	///<summary>
	///4.3.13. Для заданного массива:
	///var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
	///Необходимо найти сумму всех его элементов.
	///</summary>
	internal class Program
    {
		static void Main(string[] args)
		{
			var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
			int sum = 0;
			foreach(var i in arr)
            {
				sum += i;
            }
            Console.WriteLine(sum);
		}
    }
}