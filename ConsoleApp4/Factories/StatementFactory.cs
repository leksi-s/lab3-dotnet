using ConsoleApp4.DataContext;
using ConsoleApp4.Documents;

namespace ConsoleApp4.Factories
{
	internal class StatementFactory : IDocumentFactory
	{
		public AbstractDocument CreateDocument()
		{
			IDBContext dbContext = new DBContext();
			return dbContext.CreateStatement();
		}
	}
}
