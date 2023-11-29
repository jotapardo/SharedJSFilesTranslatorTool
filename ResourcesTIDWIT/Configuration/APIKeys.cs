using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourcesSharedFiles.Configuration
{
	public static class APIKeys
	{
		public static readonly string endpoint = "https://api.cognitive.microsofttranslator.com";
		public static readonly string key = "01b1813872524527b45edbceb33bc1a9";
		public static readonly string location = "centralus";// location, also known as region. // required if you're using a multi-service or regional (not global) resource. It can be found in the Azure portal on the Keys and Endpoint page.

	}
}
