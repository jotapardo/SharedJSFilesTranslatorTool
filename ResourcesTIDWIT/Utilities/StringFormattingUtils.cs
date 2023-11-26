using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourcesTIDWIT.Utilities
{
	public static class StringFormattingUtils
	{
		// Función para convertir texto a PascalCase
		public static string ConvertToPascalCase(string input)
		{
			if (string.IsNullOrEmpty(input))
			{
				return input;
			}

			string[] words = input.Split(' ');
			StringBuilder pascalCaseText = new StringBuilder();

			foreach (string word in words)
			{
				if (!string.IsNullOrEmpty(word))
				{
					pascalCaseText.Append(char.ToUpper(word[0]) + word.Substring(1));
				}
			}

			return pascalCaseText.ToString();
		}
	}
}
