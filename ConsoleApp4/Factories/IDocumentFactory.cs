using ConsoleApp4.Documents;

namespace ConsoleApp4.Factories
{
	internal interface IDocumentFactory
	{
		public AbstractDocument CreateDocument();
	}
}
