namespace Log4Net.NetCore.Example.Commands.Server
{
	public class ServerCommand : ICommand
	{
		private Server server { get; set; }

		public ServerCommand(Server server)
		{
			this.server = server;
		}

		public void Execute()
		{
			server.SwitchState();
		}
	}
}
