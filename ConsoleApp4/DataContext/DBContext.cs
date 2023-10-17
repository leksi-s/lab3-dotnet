using ConsoleApp4.Documents;

namespace ConsoleApp4.DataContext
{
	internal class DBContext : IDBContext
	{
		public Letter CreateLetter()
		{
			return new Letter(1, DateTime.Now, "some info", "Sender1", "Receiver1");
		}

		public Command CreateCommand()
		{
			return new Command(3, DateTime.Now, "info", 2, DateTime.Today, "Someone");
		}

		public OfficialMemo CreateMemo()
		{
			return new OfficialMemo(4, DateTime.Today, "some info");
		}
		public Order CreateOrder()
		{
			return new Order(5, DateTime.Today, "information", 1, DateTime.Today);
		}

		public Statement CreateStatement()
		{
			return new Statement(6, DateTime.Today, "information", "Employee", "resourses");
		}
	}
}
