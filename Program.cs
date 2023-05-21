namespace SVNSkillFactory14
{
	///<summary>
	///4.1.15. Какой будет результат?
	///</summary>
	internal class Program
    {
        static void Main(string[] args)
        {
			var a = 6;
			var b = 7;

			var c = a != b ? a + b : b;

			Console.WriteLine(c);
		}
    }
}