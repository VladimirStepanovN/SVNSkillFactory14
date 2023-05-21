namespace SVNSkillFactory14
{
	///<summary>
	///4.1.14. Какой отобразится результат?
	///</summary>
	internal class Program
    {
        static void Main(string[] args)
        {
			var a = 6;
			var b = 7;

			if (a == b && b > 1)
			{
				Console.WriteLine("Условие истинно");
			}

			else if (b > 10 || b == 7)
			{
				Console.WriteLine("Значение b = {0} больше 10 или равно 7", b);
			}
			else
			{
				Console.WriteLine("Значение b = {0}", b);
			}
		}
    }
}