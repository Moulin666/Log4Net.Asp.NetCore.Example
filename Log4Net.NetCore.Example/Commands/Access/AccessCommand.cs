namespace Log4Net.NetCore.Example.Commands.Access
{
	public class AccessCommand : ICommand
	{
		private Access access { get; set; }

		public AccessCommand(Access access)
		{
			this.access = access;
		}

		public void Execute()
		{
			access.SwitchState();
		}
	}
}
