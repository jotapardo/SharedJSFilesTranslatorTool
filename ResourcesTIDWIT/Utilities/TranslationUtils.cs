using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ResourcesSharedFiles.Configuration;
using MS.WindowsAPICodePack.Internal;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace ResourcesSharedFiles.Utilities
{
	public static class TranslationUtils
	{
		public static async Task<string> Translate(string textToTranslate, string targetLanguage)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(targetLanguage)) return null;
				if (string.IsNullOrWhiteSpace(textToTranslate)) return null;

				string ServiceTranslation = ConfigurationManager.ReadSetting("ServiceTranlation");

				if (ServiceTranslation == null)
				{
					ConfigurationManager.WriteSetting("ServiceTranlation", "Azure");
					ServiceTranslation = "Azure";
				}

				switch (ServiceTranslation)
				{
					case "Azure":
						//https://learn.microsoft.com/en-us/azure/ai-services/translator/create-translator-resource
						//https://learn.microsoft.com/en-us/azure/ai-services/translator/quickstart-text-rest-api?tabs=csharp

						string route = $"/translate?api-version=3.0&to={targetLanguage}";

						object[] body = new object[] { new { Text = textToTranslate } };
						var requestBody = JsonConvert.SerializeObject(body);

						using (var client = new HttpClient())
						using (var request = new HttpRequestMessage())
						{
							// Build the request.
							request.Method = HttpMethod.Post;
							request.RequestUri = new Uri(Configuration.APIKeys.endpoint + route);
							request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
							request.Headers.Add("Ocp-Apim-Subscription-Key", Configuration.APIKeys.key);
							// location required if you're using a multi-service or regional (not global) resource.
							request.Headers.Add("Ocp-Apim-Subscription-Region", Configuration.APIKeys.location);

							// Send the request and get response.
							HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);
							// Read response as a string.
							string result = await response.Content.ReadAsStringAsync();
							if (result.Contains("\"error\":{\"code\":401000,\"message\":\"The request is not authorized because credentials are missing or invalid.\""))
							{
								throw new Exception("Credentials are missing or invalid. Please check the subscription.");
							}

							return result;
						}
					case "Google":
						throw new Exception("Not implemented Yet Google API.");
					default:
						return null;
				}
				
			}
			catch (Exception ex)
			{
				throw ex;
			}





		}
	}
}
