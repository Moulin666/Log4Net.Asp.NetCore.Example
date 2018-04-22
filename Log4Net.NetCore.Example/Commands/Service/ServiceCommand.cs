namespace Log4Net.NetCore.Example.Commands.Service
{
	public class ServiceCommand : ICommand
	{
		private Service service { get; set; }

		public ServiceCommand(Service service)
		{
			this.service = service;
		}

		public void Execute()
		{
			service.SwitchState();
		}
	}
}
