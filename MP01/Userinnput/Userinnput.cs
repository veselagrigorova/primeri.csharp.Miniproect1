using System;

namespace Userinnput
{
	public class UInnput
	{
		About.Me about = new About.Me ();
		Colours.ForCLI  _c = new Colours.ForCLI();
		Calculations.MainLibrary _calc = new Calculations.MainLibrary();


		public UInnput ()
		{
		}

		public void SayHello ()
		{
			_c.Default (); Console.WriteLine ("Добре дошли в " + about.shortName +",\n" + about.version +"!\n");
		}

		public void getUserCommands ()
		{
			string _command = "";
			do{
				//Взимане на команда

				_c.Prompt(); Console.Write ("$");
				_c.Command(); _command = Console.ReadLine();

				//Проверка на налични команди
				if ( _command.ToLower().Contains ("яма" )) 	    _calc.F01.calc ( _command );
				if ( _command.ToLower().Contains ("въгъл"))    _calc.F02.calc ( _command );


				if ( _command.ToLower().Contains ("команда3" ))		Console.WriteLine ("Стартирана е Команда 3 \n");


			}while(_command.ToLower() != "изход");
		}
				
		public void justTesting ()
		{
			Console.WriteLine ("Стартиране на Userinnput.UInnput.justTesting ()");
		}
	}
}

