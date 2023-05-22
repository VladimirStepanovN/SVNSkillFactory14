namespace SVNSkillFactory14
{
	///<summary>
	///4.4.5. Дан следующий кортеж:
	///(string Name, string Type, double Age, int NameCount) Pet;
	///Name — имя питомца;
	///Type — тип питомца: собака, рыбка, хомячок;
	///Age — возраст питомца;
	///NameCount — длина имени питомца.
	///Заполните данный кортеж значениями аналогично примерам, разобранным в модуле выше.
	///</summary>
	internal class Program
    {
		static void Main(string[] args)
		{
			(string Name, string Type, double Age, int NameCount) Pet;
            Console.Write("Введите имя вашего питомца: ");
			Pet.Name = Console.ReadLine();
			Console.Write("Введите возраст вашего питомца: ");
			Pet.Age = Double.Parse(Console.ReadLine());
			Console.Write("Введите тип вашего питомца: ");
			Pet.Type = Console.ReadLine();
			Pet.NameCount = Pet.Name.Length;
			Console.WriteLine($@"Имя вашего питомца: {Pet.Name}");
			Console.WriteLine($@"Возраст вашего питомца: {Pet.Age}");
            Console.WriteLine($@"Тип вашего питомца: {Pet.Type}");
            Console.WriteLine($@"Длина имени вашего питомца: {Pet.NameCount}");
		}
    }
}