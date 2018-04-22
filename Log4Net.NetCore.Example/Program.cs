using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace Log4Net.NetCore.Example
{
	public class Program
    {
		private static ILog log { get; set; }
		private static Random random { get; set; }

        public static void Main(string[] args)
        {
			GlobalContext.Properties["LogFileName"] = "AppName";
			var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
			XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

			log = LogManager.GetLogger(typeof(Program));
			random = new Random();

			DoProgram();
			Console.ReadKey();
		}

		private static async void DoProgram()
		{
			for (int i = 0; i < 10; i++)
			{
				var info = random.Next(1, 100);
				info += i;
				log.DebugFormat("Id({0}) - {1}", i, info);
			}

			log.Warn("TEST WARN");

			log.Error("TEST ERROR");

			try
			{
				var t = await Div(20, 2);
				log.DebugFormat("20 / 2 = {0}", t);
				t = await Div(9, 0);
				log.DebugFormat("9 / 0 = {0}", t);
			}
			catch(Exception ex)
			{
				log.ErrorFormat("Exception - {0}", ex.ToString());
			}
		}

		private static async Task<float> Div(float a, float b)
		{
			if (b == 0)
				throw new Exception("Div by zero");

			return a / b;
		}
    }
}
