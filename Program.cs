namespace SVNSkillFactory14
{
	///<summary>
	///4.4.2. Модифицируйте свою программу для ввода личной информации пользователя так,
	///чтобы данные записывались в кортеж anketa.
	///</summary>
	internal class Program
    {
		static void Main(string[] args)
		{
			(string name, int age) anketa;
			Console.Write("Введите имя: ");
			anketa.name = Console.ReadLine();
			Console.Write("Введите возраст с цифрами: ");
			anketa.age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Ваше имя: {0}", anketa.name);
			Console.WriteLine("Ваш возраст: {0}", anketa.age);
			Console.ReadKey();
		}
    }
}