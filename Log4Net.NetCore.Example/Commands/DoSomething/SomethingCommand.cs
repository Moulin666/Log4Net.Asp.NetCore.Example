namespace Log4Net.NetCore.Example.Commands.DoSomething
{
	public class SomethingCommand : ICommand
	{
		private DoSomething doSomething { get; set; }

		public SomethingCommand(DoSomething doSomething)
		{
			this.doSomething = doSomething;
		}

		public void Execute()
		{
			doSomething.DoProgram();
		}
	}
}
