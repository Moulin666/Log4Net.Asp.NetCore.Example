namespace Log4Net.NetCore.Example.Commands.Access
{
	public class Access
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
			Configuration.GetLogger().Info("Access On");
			CurrentState = State.On;
		}

		private void TurnOff()
		{
			Configuration.GetLogger().Info("Access Off");
			CurrentState = State.Off;
		}
    }
}
