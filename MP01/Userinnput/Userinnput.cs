using System;

namespace Userinnput
{
	public class UInnput
	{
		About.Me about = new About.Me ();

		public UInnput ()
		{
		}

		public void SayHello ()
		{
			Console.WriteLine ("Добре дошли в " + about.shortName +",\n" + about.version +"!\n");
		}

		public void getUserCommands ()
		{
			string _command = "";
			do{
				//Взимане на команда

				Console.Write ("$");
				_command = Console.ReadLine();

				//Проверка на налични команди
				if ( _command.ToLower().Contains ("команда1" )) 	Console.WriteLine ("Стартирана е Команда 1\n");  
				if ( _command.ToLower().Contains ("команда2" )) 	Console.WriteLine ("Стартирана е Команда 2\n");
				if ( _command.ToLower().Contains ("команда3" ))		Console.WriteLine ("Стартирана е Команда 3 \n");


			}while(_command.ToLower() != "изход");
		}
				
		public void justTesting ()
		{
			Console.WriteLine ("Стартиране на Userinnput.UInnput.justTesting ()");
		}
	}
}

