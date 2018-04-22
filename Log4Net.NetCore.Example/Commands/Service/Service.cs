namespace Log4Net.NetCore.Example.Commands.Service
{
	public class Service
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
			Configuration.GetLogger().Info("Service On");
			CurrentState = State.On;
		}

		private void TurnOff()
		{
			Configuration.GetLogger().Info("Service Off");
			CurrentState = State.Off;
		}
	}
}
