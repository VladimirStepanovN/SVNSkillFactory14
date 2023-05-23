namespace SVNSkillFactory14
{
	///<summary>
	///4.5.4. Напишите условие, которое устанавливает значение ИСТИНА в поле наличие/отсутствие животных,
	///если пользователь вводит "Да", и ЛОЖЬ при любом другом варианте.
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
			User.LoginLength = User.Login.Length;
			Console.WriteLine("Есть ли у вас животные? Да или Нет");
			User.HasPet = "Да".Equals(Console.ReadLine());
		}
    }
}