namespace Log4Net.NetCore.Example.Commands.Server
{
	public class Server
    {
		public State CurrentState { get; set; }

		public void SwitchState()
		{
			if (CurrentState == State.On)
				TurnOff();
			else
				TurnOn();
		}

		private void TurnOn()
		{
			Configuration.GetLogger().Info("Server On");
			CurrentState = State.On;
		}

		private void TurnOff()
		{
			Configuration.GetLogger().Info("Server Off");
			CurrentState = State.Off;
		}
	}
}
