using AzureCognitiveTranslator;
using ResourcesSharedFiles.Configuration;
using ResourcesSharedFiles.Views.Modules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResourcesSharedFiles.Utilities
{
	public static class FileUtils
	{
		public static event EventHandler<string> OperationCompleted;
		public static event EventHandler<string> OperationFailed;

		public static void InsertTranslationInFile(string filePath, string identifier, string translation)
		{
			try
			{
				ModifyFile(filePath, identifier, translation);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public static void SaveTranslationToFile(string language, string identifier, string translation)
		{
			string folderPath = ConfigurationManager.ReadSetting("PathFilesSharedJs");

			if (string.IsNullOrEmpty(folderPath))
			{
				// If there is no route stored in the configuration, provide a default route or ask the user to select one
				folderPath = @"C:\Development\TIDWIT60\C3\C3.MicroServices\C3.UI\C3.UI\src\js\i18n\lang";
			}

			string langFolderPath = Path.Combine(folderPath, language);
			string filePath = Path.Combine(langFolderPath, "Shared.js");

			if (!Directory.Exists(langFolderPath))
			{
				Directory.CreateDirectory(langFolderPath);
			}

			InsertTranslationInFile(filePath, identifier, translation);
		}

		public static void SortSharedJSFile(string filePath)
		{
			try
			{
				ModifyFile(filePath);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private static void ModifyFile(string filePath, string identifier = null, string translation = null)
		{
			// Read the contents of the file line by line.
			string[] lines = File.ReadAllLines(filePath);

			// Find the opening line of the "resx" object.
			int resxStartLine = -1;
			for (int i = 0; i < lines.Length; i++)
			{
				if (lines[i].Trim().StartsWith("resx: {"))
				{
					resxStartLine = i;
					break;
				}
			}

			if (resxStartLine == -1)
			{
				//return null;
				MessageBox.Show("Object 'resx' was not found.");
				OperationCompleted?.Invoke(null, "Object 'resx' was not found.\n");
			}

			// Encontrar la línea de cierre del objeto "resx".
			int resxEndLine = -1;
			for (int i = lines.Length - 1; i >= resxStartLine + 1; i--)
			{
				if (lines[i].Trim() == "},")
				{
					resxEndLine = i;
					break;
				}
			}

			if (resxEndLine == -1)
			{
				MessageBox.Show("Closure for object 'resx' not found.");
				OperationCompleted?.Invoke(null, "Closure for object 'resx' not found.\n");
			}

			// Extract the lines that represent the properties and values of the "resx" object.
			List<string> propertyLines = lines
				.Skip(resxStartLine + 1)
				.Take(resxEndLine - resxStartLine - 1)
				.Select(line => line.Trim())
				.ToList();

			if (identifier != null && translation != null)
			{
				// Check if the 'identifier' already exists in the properties.
				if (propertyLines.Select(line => line.Trim()).Any(line => line.StartsWith($"{identifier}: ")))
				{
					MessageBox.Show($"The 'identifier' '{identifier}' already exists in the 'resx' object.");
					OperationCompleted?.Invoke(null, $"The 'identifier' '{identifier}' already exists in the 'resx' object.\n");
					return;
				}

				// Insert the new line into the propertyLines collection.
				int insertIndex = resxEndLine;
				string newLine = $"{identifier}: \"{translation}\",\n";
				propertyLines.Insert(insertIndex - resxStartLine - 1, newLine);
			}

			// Concatenate all lines of the "resx" object.
			string resxContent = string.Join("\n", propertyLines);
			resxContent = resxContent.Replace("'", "\"") + "\n";

			// Use Split to split content into properties and values.
			var propertyMatches =
				resxContent.Split(new[] { "\",\n" }, StringSplitOptions.RemoveEmptyEntries)
				.Select(pair => pair + "\",")
				.Select(pair => pair.Replace("\n", ""))
				.Select(line => Regex.Match(line, @"([\w\s]+):\s*""(.*)"""))
				.Where(match => match.Success)
				.Select(match => new
				{
					Key = match.Groups[1].Value.Trim(),
					Value = match.Groups[2].Value.Replace("\"", "'")
				});

			if (!propertyMatches.Any())
			{
				MessageBox.Show("No properties found in 'resx'.");
				OperationCompleted?.Invoke(null, "No properties found in 'resx'.\n");
			}

			// Sort properties alphabetically.
			var sortedProperties = propertyMatches
				.OrderBy(prop => prop.Key)
				.Select(prop => $"{prop.Key}: \"{prop.Value}\"");

			//validate duplicate keys
			ValidateDuplicatedKeys(sortedProperties);

			// Build the updated content of the "resx" object.
			string sortedResxContent = string.Join(",\n", sortedProperties);

			int lenSplitedContent = sortedResxContent.Split('\n').Length;

			// Insert the updated lines of the "resx" object.
			lines = lines.Take(resxStartLine + 1)
				.Concat(sortedResxContent.Split('\n')
					.Select((line, index) =>
					{
						line = "    " + line;

						if (line.Length > 100) //TO-DO
						{
							int splitIndex = line.IndexOf(':'); // Find the position of the first ":"
							if (splitIndex >= 0)
							{
								return line.Substring(0, splitIndex) + ":\n      " + line.Substring(splitIndex + 1).TrimStart();
							}
						}
						// Add comma at the end if it is the last line
						if (index == lenSplitedContent - 1)
						{
							line += ",";
						}
						return line;
					})
					)
				.Concat(lines.Skip(resxEndLine))
				.ToArray();

			// Save the updated file.
			File.WriteAllLines(filePath, lines);

			//for debug
			string finalText = string.Join(Environment.NewLine, lines);

			OperationCompleted?.Invoke(null, "File Shared.js updated \n");
		}

		private static void ValidateDuplicatedKeys(IEnumerable<string> propertyLines)
		{
			var keyDictionary = new Dictionary<string, int>();
			var duplicateKeys = new List<string>();

			foreach (var line in propertyLines)
			{
				if (line.Contains(":"))
				{
					var keyValuePair = line.Split(':');
					var key = keyValuePair[0].Trim();
					if (keyDictionary.ContainsKey(key))
					{
						if (!duplicateKeys.Contains(key))
						{
							duplicateKeys.Add(key);
						}
					}
					else
					{
						keyDictionary[key] = 1;
					}
				}
			}

			if (duplicateKeys.Any())
			{
				var warningMessage = "Duplicate keys found: \n" + string.Join(", \n", duplicateKeys);
				MessageBox.Show(warningMessage, "Duplicate keys found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				OperationCompleted?.Invoke(null, warningMessage + "\n");
				return;
			}
		}
	}
}
