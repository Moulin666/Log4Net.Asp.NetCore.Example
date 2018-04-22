using System;
using log4net;

namespace Log4Net.NetCore.Example
{
	public class Program
    {
		private static ILog log { get; set; }

        public static void Main(string[] args)
        {
			log = Configuration.GetLogger();

			var controller = new Controller();
			string input;

			do
			{
				Console.Write("Command: ");
				var inputCommand = Console.ReadLine();
				int id;
				int.TryParse(inputCommand, out id);

				controller.ExecuteCommand(id);

				Console.Write("\nContinue? (y/n): ");
				input = Console.ReadLine();
			} while (input == "y");
		}
    }
}
