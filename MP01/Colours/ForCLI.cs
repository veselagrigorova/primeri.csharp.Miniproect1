﻿using System;

namespace Colours
{
	public class ForCLI
	{
		public ForCLI ()
		{
		}

		public void Default ()
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
		}

		public void Prompt ()
		{
			Console.ForegroundColor = ConsoleColor.DarkCyan;

		}
		public void Command ()
		{
			Console.ForegroundColor = ConsoleColor.DarkGreen;

		}
		public void Result ()
		{
			Console.ForegroundColor = ConsoleColor.DarkRed;

		}
	}
}

