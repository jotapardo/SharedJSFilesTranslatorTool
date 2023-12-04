using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourcesSharedFiles.Configuration
{
	public class ConfigurationManager
	{
		private const string ConfigFileName = "config.json";

		public static string ReadSetting(string key)
		{
			try
			{
				if (File.Exists(ConfigFileName))
				{
					string json = File.ReadAllText(ConfigFileName);
					var config = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
					return config.ContainsKey(key) ? config[key] : null;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error reading configuration: " + ex.Message);
			}
			return null;
		}

		public static void WriteSetting(string key, string value)
		{
			try
			{
				Dictionary<string, string> config;
				if (File.Exists(ConfigFileName))
				{
					string json = File.ReadAllText(ConfigFileName);
					config = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
				}
				else
				{
					config = new Dictionary<string, string>();
				}

				config[key] = value;
				string updatedJson = JsonConvert.SerializeObject(config);
				File.WriteAllText(ConfigFileName, updatedJson);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error writing configuration: " + ex.Message);
			}
		}
	}
}
