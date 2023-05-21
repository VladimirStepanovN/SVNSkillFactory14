namespace SVNSkillFactory14
{
	///<summary>
	///4.1.16. Выберите вариант ответа, в котором описана правильная последовательность программы.
	///Если введём красный цвет, то консоль окрасится в красный, 
	///если любой другой, то в бирюзовый, если зелёный, то в зелёный
	///</summary>
	internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

			var color = Console.ReadLine();

			if (color == "red")
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is red!");
			}

			else if (color == "green")
			{
				Console.BackgroundColor = ConsoleColor.Green;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is green!");
			}
			else
			{
				Console.BackgroundColor = ConsoleColor.Cyan;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is cyan!");
			}
		}
    }
}