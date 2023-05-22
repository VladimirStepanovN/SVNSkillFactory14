namespace SVNSkillFactory14
{
	///<summary>
	///4.3.12. Эта задача является одной из базовых задач при работе с массивами — 
	///сортировка одномерного массива.
	///Вам необходимо отсортировать его в порядке возрастания цифр и вывести на экран.
	///</summary>
	internal class Program
    {
		static void Main(string[] args)
		{
			var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
			int inner, outer;
			for(outer = 1; outer < arr.Length; outer++)
            {
				int temp = arr[outer];
				inner = outer;
				while(inner > 0 && arr[inner - 1] >= temp)
                {
					arr[inner] = arr[inner - 1];
					--inner;
                }
                arr[inner] = temp;
            }
            foreach(int i in arr)
            {
                Console.Write($@"{i} ");
            }
		}
    }
}