using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourcesSharedFiles.Utilities
{
	public static class StringFormattingUtils
	{
		// Function to convert text to PascalCase
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

		public static string ConvertToKey(string input)
		{
			// Convert input to PascalCase
			string pascalCaseWord = ConvertToPascalCase(input);

			// Eliminar caracteres no permitidos en el archivo JS (Shared.js)
			StringBuilder cleanKey = new StringBuilder();
			foreach (char c in pascalCaseWord)
			{
				// Verificar si el carácter es válido
				if (Char.IsLetterOrDigit(c) || c == '_')
				{
					cleanKey.Append(c);
				}
			}

			return cleanKey.ToString();

		}
	}
}
