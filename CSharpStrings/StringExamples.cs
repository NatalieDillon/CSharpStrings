using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStrings
{
	public class StringExamples
	{
		public static void ImmutableStrings()
		{
			// Immutable strings
			// We cannot change a string. They are immutable
			// So when we want to alter a string we must reassign it and
			// a new string instance gets created in memory			
			string nameA = "Fred";
			string nameB = nameA;
			Console.WriteLine($"nameA:{nameA} nameB:{nameB}");
			nameA = "James";
			Console.WriteLine($"nameA:{nameA} nameB:{nameB}\n");
		}

		public static void UsingAStringBuilder()
		{
			// Each time we change a string a new string instance gets created in memory
			// Thats why repeated concatenation is slow. Best to use a string builder.
			SlowConcatenation();
			FastConcatenation();
		}

		public static void SlowConcatenation()
		{
			DateTime start = DateTime.Now;
			string val = "";
			for (int i = 0; i < 20000; i++)
			{
				val += i;
			}
			TimeSpan duration = DateTime.Now - start;
			Console.WriteLine($"Value is {val.Length} characters long");
			Console.WriteLine($"It took {duration.TotalMilliseconds} milliseconds");
		}

		public static void FastConcatenation()
		{
			DateTime start = DateTime.Now;
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < 20000; i++)
			{
				sb.Append(i);
			}
			string val = sb.ToString();
			TimeSpan duration = DateTime.Now - start;
			Console.WriteLine($"Value is {val.Length} characters long");
			Console.WriteLine($"It took {duration.TotalMilliseconds} milliseconds");
		}

		public static void StringsAreSequencesOfCharacters(string input)
		{
			// Strings are sequences of characters
			Console.Write($"{input} is {input.Length} characters long\n");
			foreach (char c in input) // we can iterate over the characters in a string using a foreach loop
			{
				Console.WriteLine(c);
			}
			//for (int i=0; i <input.Length; i++) // we can also use a for loop and access each character by index
			//{
			//	Console.WriteLine(input[i]);
			//	// Why won't the line of code below compile?
			//	//input[i] = "r";
			//}
		}

		public static void CharacterCodes()
		{
			// To get the character code for a character we can cast it to an integer 
			char letter = 'c';
			Console.WriteLine($"The character code for {letter} is {(int)letter}");

			// Or we can implicitly convert it to an integer variable
			int code = 'a';
			Console.WriteLine($"The character code for a is {code}");

			// To convert a integer to a character code we can cast it to a char
			char greekLetter = (char)937;
			Console.WriteLine($"The character for code 937 is {greekLetter}");
		}

		// Some of the many functions we can use with strings and chars
		// Look them up in the documentation
		public static void UsefulStringAndCharFunctions()
		{
			string sentence = " The cat sat on the mat. ";
			Console.WriteLine(sentence);
			Console.WriteLine($"cat appears at index {sentence.IndexOf("cat")}");
			Console.WriteLine($"trim removes white space: {sentence.Trim()}");
			Console.WriteLine($"We can replace characters: {sentence.Replace("cat", "dog")}");
			Console.WriteLine($"We can substring characters: {sentence.Substring(1, 3)}");
			Console.WriteLine($"Check the character type: {sentence[1]} is lower = {char.IsLower(sentence[1])}\n");
		}

		public static void PrintCharsWithByteArray(string val, int numberBase = 2)
		{
			Console.WriteLine($"\"{val}\".Length = {val.Length}");
			for (int i = 0; i < val.Length; i++)
			{
				Console.Write($"val[{i}] = '{val[i]}'");
				// Gets the character as an array of bytes i.e integers between 0-255
				byte[] byteArray = Encoding.Default.GetBytes(new[] { val[i] }); 
				foreach (byte b in byteArray)
				{
					string displayVal = Convert.ToString(b, numberBase);
					if (numberBase == 2)
					{
						displayVal = displayVal.PadLeft(8, '0');
					}
					Console.Write($" {displayVal}");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}

	}
}
