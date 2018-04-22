using System;
using System.Threading.Tasks;

namespace Log4Net.NetCore.Example.Commands.DoSomething
{
	public class DoSomething
    {
		public async void DoProgram()
		{
			var random = new Random();

			for (int i = 0; i < 10; i++)
			{
				var info = random.Next(1, 100);
				info += i;
				Configuration.GetLogger().DebugFormat("Id({0}) - {1}", i, info);
			}

			Configuration.GetLogger().Warn("TEST WARN");

			Configuration.GetLogger().Error("TEST ERROR");

			try
			{
				var t = await Div(20, 2);
				Configuration.GetLogger().DebugFormat("20 / 2 = {0}", t);
				t = await Div(9, 0);
				Configuration.GetLogger().DebugFormat("9 / 0 = {0}", t);
			}
			catch (Exception ex)
			{
				Configuration.GetLogger().ErrorFormat("Exception - {0}", ex.ToString());
			}
		}

		private async Task<float> Div(float a, float b)
		{
			if (b == 0)
				throw new Exception("Div by zero");

			return a / b;
		}
	}
}
