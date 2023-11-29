using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ResourcesSharedFiles.Utilities
{
	public static class TranslationUtils
	{
		public static async Task<string> Translate(string textToTranslate, string targetLanguage)
		{
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
				return result;
			}
		}
	}
}
