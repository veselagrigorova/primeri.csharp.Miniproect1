using System;

namespace CALLCULATOR
{
	class MainClass
	{
		//Дефиниране на библиотеки

		public Userinnput.UInnput uinput = new	Userinnput.UInnput ();
		public About.Me about = new About.Me ();


		public static void Main (string[] args)
		{
			MainClass _program = new MainClass ();
			//форматиране на програмата
			Console.Title = _program.about.shortName + ", " + _program.about.version;

			//стартиране на програмата
			_program.uinput.SayHello ();
			_program.uinput. getUserCommands ();




		}
	}
}
