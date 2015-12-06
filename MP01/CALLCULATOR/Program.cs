using System;

namespace CALLCULATOR
{
	class MainClass
	{
		//Дефиниране на библиотеки

		public Userinnput.UInnput uinput = new	Userinnput.UInnput ();


		public static void Main (string[] args)
		{
			MainClass _program = new MainClass ();

			_program.uinput. getUserCommands ();




		}
	}
}
