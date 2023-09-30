using System.Text;

namespace CSharpStrings
{
	internal class Program
	{
		static void Main()
		{
			StringExamples.StringsAreSequencesOfCharacters("Super");
			Console.WriteLine();

			StringExamples.UsefulStringAndCharFunctions();

			StringExamples.ImmutableStrings();
			StringExamples.UsingAStringBuilder();

			// Converting to and from character codes
			StringExamples.CharacterCodes();
			Console.WriteLine();
			
			// Character encoding
			Console.WriteLine($"The default encoding is {Encoding.Default}\n");
			StringExamples.PrintCharsWithByteArray("Hello");
			StringExamples.PrintCharsWithByteArray("Γεια σας");
		}
	}
}