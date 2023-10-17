using ConsoleApp4.DataContext;
using ConsoleApp4.Documents;


namespace ConsoleApp4.Factories
{
	public class CommandFactory : IDocumentFactory
	{
		public AbstractDocument CreateDocument()
		{
			IDBContext dbContext = new DBContext();
			return dbContext.CreateCommand();
		}
	}
}
