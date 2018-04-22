using System.Collections.Generic;
using log4net;
using Log4Net.NetCore.Example.Commands;
using Log4Net.NetCore.Example.Commands.Access;
using Log4Net.NetCore.Example.Commands.DoSomething;
using Log4Net.NetCore.Example.Commands.Server;
using Log4Net.NetCore.Example.Commands.Service;

namespace Log4Net.NetCore.Example
{
	public class Controller
    {
		private ILog log { get; set; }
		private Dictionary<int, ICommand> commandCollection { get; set; }

		public Controller()
		{
			log = Configuration.GetLogger();

			commandCollection = new Dictionary<int, ICommand>();
			Init();
		}

		public void Init()
		{
			log.Info("Initialize controller.");

			commandCollection[1] = new AccessCommand(new Access());
			commandCollection[2] = new ServerCommand(new Server());
			commandCollection[3] = new ServiceCommand(new Service());
			commandCollection[4] = new SomethingCommand(new DoSomething());
			log.Info("Set command. Id - 1. Command - Access");
			log.Info("Set command. Id - 2. Command - Server");
			log.Info("Set command. Id - 3. Command - Service");
			log.Info("Set command. Id - 4. Command - Something");
		}

		public void ExecuteCommand(int id)
		{
			if (commandCollection.ContainsKey(id))
				commandCollection[id].Execute();
		}
    }
}
