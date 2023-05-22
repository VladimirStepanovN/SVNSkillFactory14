namespace SVNSkillFactory14
{
	///<summary>
	///4.3.7. Используя полученные знания и способы работы с данными,
	///напишите программу, которая переставляет буквы вашего имени в обратном порядке.
	///</summary>
	internal class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("Введите своё имя");
			var name = Console.ReadLine();
			Console.WriteLine("Ваше имя в обратном порядке: ");
			for (int i = name.Length - 1; i >= 0; i--)
			{
                Console.Write(name[i]);
			}
			Console.ReadKey();
		}
    }
}