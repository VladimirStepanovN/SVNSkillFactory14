namespace SVNSkillFactory14
{
	///<summary>
	///4.4.3. Используя такую запись кортежа, измените предыдущую программу.
	///Сначала отобразите на экран имя и возраст. 
	///После этого попросите пользователя ввести эту же информацию с клавиатуры.
	///</summary>
	internal class Program
    {
		static void Main(string[] args)
		{
			var (name, age) = ("Евгения", 27);
			Console.WriteLine("Ваше имя: {0}", name);
			Console.WriteLine("Ваш возраст: {0}", age);
			Console.Write("Введите имя: ");
			name = Console.ReadLine();
			Console.Write("Введите возраст с цифрами: ");
			age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Ваше имя: {0}", name);
			Console.WriteLine("Ваш возраст: {0}", age);
			Console.ReadKey();
		}
    }
}