namespace SVNSkillFactory14
{
	///<summary>
	///4.5.2. Заполните кортеж User значениями с клавиатуры для полей: имя пользователя, фамилия, логин.
	///</summary>
	internal class Program
    {
		static void Main(string[] args)
		{
			(string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;
			Console.WriteLine("Введите имя");
			User.Name = Console.ReadLine();
			Console.WriteLine("Введите фамилию");
            User.LastName = Console.ReadLine();
			Console.WriteLine("Введите логин");
            User.Login = Console.ReadLine();
		}
    }
}