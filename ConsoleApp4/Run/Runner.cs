using ConsoleApp4.Documents;
using ConsoleApp4.Factories;

namespace ConsoleApp4.Run
{
	internal class Runner : IRunner
	{
		private Dictionary<string, IDocumentFactory> factories = new Dictionary<string, IDocumentFactory>

		{
			{"Command", new CommandFactory()},
			{"Letter", new LetterFactory()},
			{"OfficialMemo", new OfficialMemoFactory()},
			{"Order", new OrderFactory()},
			{ "Statement", new StatementFactory()}
		};

		public void Run()
		{
			foreach (var kvp in factories)
			{
				string documentType = kvp.Key;
				IDocumentFactory factory = kvp.Value;

				AbstractDocument document = factory.CreateDocument();
				Console.WriteLine($"{documentType}: {document}");
			}
		}
	}
}
